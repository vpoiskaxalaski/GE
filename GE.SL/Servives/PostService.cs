using AutoMapper;
using GE.DAL.Interfaces;
using GE.DAL.Model;
using GE.Models;
using GE.SL.Interfaces;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;

namespace GE.SL.Servives
{
    public class PostService : IPostService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IHostingEnvironment _hostingEnvironment;

        public PostService(IUnitOfWork unitOfWork, IMapper mapper, IHostingEnvironment hostingEnvironment)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _hostingEnvironment = hostingEnvironment;
        }

        public List<PostVM> GetAll()
        {
            var posts = _unitOfWork.Posts.GetAll();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Post, PostVM>();
            });


            var map = config.CreateMapper();
            var postsVM = map.Map<IEnumerable<Post>, IEnumerable<PostVM>>(posts);

            List<PostVM> result = postsVM.Cast<PostVM>().ToList();

            return result;
        }

        public void CreatePost(RegisterPostViewModel model, IEnumerable<IFormFile> images, IFormFile video, ApplicationUserVM user)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<ApplicationUserVM, ApplicationUser>();
            });
            var map = config.CreateMapper();
            var dbUser = map.Map<ApplicationUserVM, ApplicationUser>(user);

            var post = new Post
            {
                Name = model.Name,
                Description = model.Description,
                City = _unitOfWork.Cities.Find(i => i.Name == model.City).First(), //db.Cities.First(i => i.Name == model.City),
                DateCreatePost = GetTime(),
                ImagesGallery = AddImagesInDb(images, user.Id),
                Video = AddVideoInDb(video),
                Subcategory = _unitOfWork.Subcategories.Find(i => i.Name == model.Subcategory).FirstOrDefault(),
                User = dbUser,
                Status = "0"
            };
            _unitOfWork.Posts.Create(post);
            _unitOfWork.Save();
        }

        private List<ImagesGallery> AddImagesInDb(IEnumerable<IFormFile> images, string userId)
        {

            List<ImagesGallery> imagesGallery = new List<ImagesGallery>();
            foreach (var image in images)
            {
                if (image != null)
                {
                    var fileId = Guid.NewGuid().ToString();
                    var uploadFilesDir = _hostingEnvironment.WebRootPath + "/images/" + userId + "/";
                    string path = "/images/" + userId + "/" + image.FileName;
                    if (!Directory.Exists(uploadFilesDir))
                    {
                        Directory.CreateDirectory(uploadFilesDir);
                    }
                    using (var fileStream = new FileStream(_hostingEnvironment.WebRootPath + path, FileMode.Create))
                    {
                        image.CopyTo(fileStream);
                    }
                    var extension = Path.GetExtension(image.FileName);
                    var fileSavePath = Path.Combine(uploadFilesDir, userId + extension);
                    var name = Path.GetFileName(image.FileName);
                    imagesGallery.Add(new ImagesGallery() { Title = fileId, Name = name });     
                }
            }
            return imagesGallery;
        }

        private Video AddVideoInDb(IFormFile videoData)
        {
            Video video = null;
            if (videoData != null)
            {
                var videoId = Guid.NewGuid().ToString();
                var uploadFilesDir = _hostingEnvironment.WebRootPath + "/Videos";
                if (!Directory.Exists(uploadFilesDir))
                {
                    Directory.CreateDirectory(uploadFilesDir);
                }
                var extension = Path.GetExtension(videoData.FileName);
                var fileSavePath = Path.Combine(uploadFilesDir, videoId + extension);
                var name = Path.GetFileName(videoData.FileName);
                video = new Video() { Title = videoId, Name = name };
            }
            return video;
        }

        private static string GetTime()
        {
            var client = new TcpClient("time.nist.gov", 13);
            string localDateTime = "";
            using (var streamReader = new StreamReader(client.GetStream()))
            {
                var response = streamReader.ReadToEnd();
                var utcDateTimeString = response.Substring(7, 17);
                localDateTime = DateTime.ParseExact(utcDateTimeString, "yy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal).ToString();
            }
            return localDateTime;
        }
    }
}
