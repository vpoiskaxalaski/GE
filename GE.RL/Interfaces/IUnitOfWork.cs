using GE.DAL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace GE.RL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Lot> Lots { get; }
        IRepository<Order> Orders { get; }
        void Save();
    }
}
