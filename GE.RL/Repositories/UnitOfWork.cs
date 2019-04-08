using GE.RL.Interfaces;
using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Text;
using GE.DAL.Model;

namespace GE.RL.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private DatabaseContext db;
        private LotRepository lotRepository;
        private OrderRepository orderRepository;

        public UnitOfWork(DbContextOptions<DatabaseContext> options)
        {
            db = new DatabaseContext(options);
        }
        public IRepository<Lot> Lots
        {
            get
            {
                if (lotRepository == null)
                    lotRepository = new LotRepository(db);
                return lotRepository;
            }
        }

        public IRepository<Order> Orders
        {
            get
            {
                if (orderRepository == null)
                    orderRepository = new OrderRepository(db);
                return orderRepository;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
