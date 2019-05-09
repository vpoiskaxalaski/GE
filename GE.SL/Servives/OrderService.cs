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
            _unitOfWork.Orders.Create(new Order { PostId =order.PostId, UserId = order.UserId  });
            _unitOfWork.Save();
        }

        public void Delete(int id)
        {
            _unitOfWork.Orders.Delete(id);
            _unitOfWork.Save();
        }

        public OrderVM FindById(int postId)
        {
            var order = _unitOfWork.Orders.Get(postId);

            return new OrderVM { Id = order.Id, PostId = order.PostId, UserId = order.UserId };
        }

        public List<OrderVM> GetAll()
        {
            List<OrderVM> ordersVM = new List<OrderVM>();
            IEnumerable<Order> orders = _unitOfWork.Orders.GetAll();

            var postConfig = new MapperConfiguration(cfg => {
                cfg.CreateMap<Post, PostVM>();
            });
            var postMap = postConfig.CreateMapper();
            var userConfig = new MapperConfiguration(cfg => {
                cfg.CreateMap<ApplicationUser, ApplicationUserVM>();
            });
            var userMap = userConfig.CreateMapper();
            var imageConfig = new MapperConfiguration(cfg => {
                cfg.CreateMap<ImagesGallery, ImagesGalleryVM>();
            });
            var imageMap = imageConfig.CreateMapper();

            foreach (Order order in orders)
            {
                var userVM = userMap.Map<ApplicationUser, ApplicationUserVM>(order.User);
                var imageGallery = _imageGalleryService.Find(order.PostId);
                var subcategory = _unitOfWork.Subcategories.Get(order.Post.SubcategoryId);
                var postVM = postMap.Map<Post, PostVM>(order.Post);
                postVM.Subcategory = new SubcategoryVM { Id = subcategory.Id, Name = subcategory.Name, Points = subcategory.Points };
                postVM.ImagesGallery = imageGallery;

                ordersVM.Add(new OrderVM { Id=order.Id, PostId = order.PostId, UserId = order.UserId, Post = postVM, User = userVM});
            }

            return ordersVM;
        }

        public void RemoveRange(ICollection<OrderVM> items)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<OrderVM, Order>();
            });
            var map = config.CreateMapper();
            var orders = map.Map<IEnumerable<OrderVM>, ICollection<Order>>(items);

            _unitOfWork.Orders.RemoveRange(orders);
        }
    }
}
