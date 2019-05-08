using GE.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GE.SL.Interfaces
{
    public interface IOrderService
    {
        List<OrderVM> GetAll();

        void Create(OrderVM order);
    }
}
