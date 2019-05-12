using GE.DAL.Interfaces;
using GE.DAL.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GE.DAL.Repositories
{

    public class OrderRepository : IRepository<Order>
    {
        private DatabaseContext db;

        public OrderRepository(DatabaseContext context)
        {
            db = context;
        }

        public IEnumerable<Order> GetAll()
        {
            return db.Orders.Include(x => x.Post).Include(x => x.User);
        }

        public Order Get(int id)
        {
            var o = db.Orders.FirstOrDefault(x => x.Id == id);
            if (o != null)
            {
                o.Post = db.Posts.FirstOrDefault(x => x.Id == o.PostId);
                o.User = db.ApplicationUsers.FirstOrDefault(x => x.Id == o.UserId);
            }

            return o;
        }

        public void Create(Order order)
        {
            db.Orders.Add(order);
        }

        public void Update(Order order)
        {
            db.Entry(order).State = EntityState.Modified;
        }
        public IEnumerable<Order> Find(Func<Order, bool> predicate)
        {
            return db.Orders.Where(predicate);
        }
        public void Delete(int id)
        {
            Order item = db.Orders.Find(id);
            if (item != null)
            {
                db.Orders.Remove(item);
            }
        }

        public int GetCount()
        {
            return db.Orders.Count();
        }

        public void RemoveRange(IEnumerable<Order> items)
        {
            db.Orders.RemoveRange(items);
        }
    }
}