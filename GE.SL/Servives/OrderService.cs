using AutoMapper;
using GE.DAL.Interfaces;
using GE.DAL.Model;
using GE.Models;
using GE.SL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GE.SL.Servives
{
    public class OrderService : IOrderService
    {
        private IUnitOfWork _unitOfWork;

        public OrderService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Create(OrderVM order)
        {
            _unitOfWork.Orders.Create(new Order { PostId =order.PostId, UserId = order.UserId  });
            _unitOfWork.Save();
        }

        public List<OrderVM> GetAll()
        {
            List<OrderVM> ordersVM = new List<OrderVM>();
            //PostVM postVM = new PostVM();
            //OrderVM orderVM = new OrderVM();

            IEnumerable<Order> orders = _unitOfWork.Orders.GetAll();


            //var config = new MapperConfiguration(cfg =>
            //{
            //    cfg.CreateMap<Post, PostVM>();
            //});
            //var map = config.CreateMapper();

            foreach (Order order in orders)
            {
                // postVM = map.Map<Post, PostVM>(order.Post);
                // orderVM = new OrderVM {  Id=order.Id, PostId};
                ordersVM.Add(new OrderVM { Id = order.Id, PostId = order.PostId, UserId = order.Post.UserId });
            }

            return ordersVM;
        }
    }
}
