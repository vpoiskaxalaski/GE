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
            var postsVM = map.Map<IEnumerable<Post>, ICollection<PostVM>>(posts);

            foreach(PostVM item in postsVM)
            {
                var subcategory = _unitOfWork.Subcategories.Find(x => x.Id == item.SubcategoryId).FirstOrDefault();
                item.Subcategory = new SubcategoryVM { Id = subcategory.Id, Name = subcategory.Name, Points = subcategory.Points };
            }

            List<PostVM> result = postsVM.ToList();

            return result;
        }

        public void CreatePost(RegisterPostViewModel model, IEnumerable<IFormFile> images, ApplicationUserVM user)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ApplicationUserVM, ApplicationUser>();
            });
            var map = config.CreateMapper();
            var dbUser = map.Map<ApplicationUserVM, ApplicationUser>(user);

            var post = new Post
            {
                Name = model.Name,
                Description = model.Description,
                City = _unitOfWork.Cities.Find(i => i.Name == model.City).First(),
                DateCreatePost = GetTime(),
                UserId = dbUser.Id,
                ImagesGallery = AddImagesInDb(images, user.Id),
                Subcategory = _unitOfWork.Subcategories.Find(i => i.Name == model.Subcategory).FirstOrDefault(),
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
                    imagesGallery.Add(new ImagesGallery() { Name = name });
                }
            }
            return imagesGallery;
        }



        private static string GetTime()
        {
            string localDateTime = "";
            try
            {
                var client = new TcpClient("time.nist.gov", 13);

                using (var streamReader = new StreamReader(client.GetStream()))
                {
                    var response = streamReader.ReadToEnd();
                    var utcDateTimeString = response.Substring(7, 17);
                    localDateTime = DateTime.ParseExact(utcDateTimeString, "yy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal).ToString();
                }
            }
            catch
            {

            }
            
            return localDateTime;
        }

        public void Remove(int id)
        {
            _unitOfWork.Posts.Delete(id);
            _unitOfWork.Save();
        }

        public PostVM FindById(int id)
        {
            var post = _unitOfWork.Posts.Get(id);

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ImagesGallery, ImagesGalleryVM>();
            });
            var map = config.CreateMapper();            

            return new PostVM
            {
                Id = post.Id,
                CityId = post.CityId,
                DateCreatePost = post.DateCreatePost,
                Description = post.Description,
                Name = post.Name,
                Status = post.Status,
                SubcategoryId = post.SubcategoryId,
                UserId = post.UserId,
                ImagesGallery = map.Map<IEnumerable<ImagesGallery>, ICollection<ImagesGalleryVM>>(post.ImagesGallery)
            };
        }

        public void Update(PostVM post)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<PostVM, Post>();
            });
            var map = config.CreateMapper();
            var dbPost = map.Map<PostVM, Post>(post);

            _unitOfWork.Posts.Update(dbPost);
            _unitOfWork.Save();
        }
    }
}
