using AutoMapper;
using GE.DAL.Interfaces;
using GE.DAL.Model;
using GE.Models;
using GE.SL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GE.SL.Servives
{
    public class PostService : IPostService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public PostService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
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
    }
}
