using AutoMapper;
using GE.DAL.Interfaces;
using GE.DAL.Model;
using GE.Models;
using GE.SL.Interfaces;
using System.Collections.Generic;

namespace GE.SL.Servives
{
    public class OrderService : IOrderService
    {
        private IUnitOfWork _unitOfWork;
        private IImageGalleryService _imageGalleryService;

        public OrderService(IUnitOfWork unitOfWork, IImageGalleryService imageGalleryService)
        {
            _unitOfWork = unitOfWork;
            _imageGalleryService = imageGalleryService;
        }

        public void Create(OrderVM order)
        {
            _unitOfWork.Orders.Create(new Order { PostId = order.PostId, UserId = order.UserId });
            _unitOfWork.Save();
        }

        public void Delete(int id)
        {
            _unitOfWork.Orders.Delete(id);
            _unitOfWork.Save();
        }

        public OrderVM FindById(int postId)
        {
            Order order = _unitOfWork.Orders.Get(postId);

            MapperConfiguration config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Post, PostVM>();
            });
            IMapper map = config.CreateMapper();
            var post = map.Map<Post, PostVM>(order.Post);

            MapperConfiguration userConfig = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ApplicationUser, ApplicationUserVM>();
            });
            IMapper userMap = config.CreateMapper();
            var user = map.Map<ApplicationUser, ApplicationUserVM>(order.User);             

            return new OrderVM { Id = order.Id, PostId = order.PostId, UserId = order.UserId, Post = post, User = user };
        }

        public List<OrderVM> GetAll()
        {
            List<OrderVM> ordersVM = new List<OrderVM>();
            IEnumerable<Order> orders = _unitOfWork.Orders.GetAll();

            MapperConfiguration postConfig = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Post, PostVM>();
            });
            IMapper postMap = postConfig.CreateMapper();
            MapperConfiguration userConfig = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ApplicationUser, ApplicationUserVM>();
            });
            IMapper userMap = userConfig.CreateMapper();
            MapperConfiguration imageConfig = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ImagesGallery, ImagesGalleryVM>();
            });
            IMapper imageMap = imageConfig.CreateMapper();

            foreach (Order order in orders)
            {
                ApplicationUserVM userVM = userMap.Map<ApplicationUser, ApplicationUserVM>(order.User);
                List<ImagesGalleryVM> imageGallery = _imageGalleryService.Find(order.PostId);
                Subcategory subcategory = _unitOfWork.Subcategories.Get(order.Post.SubcategoryId);
                PostVM postVM = postMap.Map<Post, PostVM>(order.Post);
                postVM.Subcategory = new SubcategoryVM { Id = subcategory.Id, Name = subcategory.Name, Points = subcategory.Points };
                postVM.ImagesGallery = imageGallery;

                ordersVM.Add(new OrderVM { Id = order.Id, PostId = order.PostId, UserId = order.UserId, Post = postVM, User = userVM });
            }

            return ordersVM;
        }

        public void RemoveRange(ICollection<OrderVM> items)
        {
            MapperConfiguration config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<OrderVM, Order>();
            });
            IMapper map = config.CreateMapper();
            ICollection<Order> orders = map.Map<IEnumerable<OrderVM>, ICollection<Order>>(items);

            _unitOfWork.Orders.RemoveRange(orders);
        }

        public void Update(int id, OrderVM order)
        {
            var o = _unitOfWork.Orders.Get(id);
            if (o != null)
            {
                o.PostId = order.PostId;
                o.UserId = order.UserId;
                _unitOfWork.Orders.Update(o);
                _unitOfWork.Save();
            }
        }
    }
}
