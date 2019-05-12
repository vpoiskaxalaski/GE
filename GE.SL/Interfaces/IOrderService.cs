using GE.Models;
using System.Collections.Generic;

namespace GE.SL.Interfaces
{
    public interface IOrderService
    {
        List<OrderVM> GetAll();

        OrderVM FindById(int Id);

        void Create(OrderVM order);

        void Delete(int id);

        void RemoveRange(ICollection<OrderVM> items);

        void Update(int id, OrderVM order);
    }
}
