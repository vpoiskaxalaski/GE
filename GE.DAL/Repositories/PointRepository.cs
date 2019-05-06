using GE.DAL.Model;
using GE.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GE.DAL.Repositories
{
    public class PointRepository : IRepository<Point>
    {
        private DatabaseContext db;

        public PointRepository(DatabaseContext context)
        {
            this.db = context;
        }
        public void Create(Point item)
        {
            db.Add(item);
        }

        public void Delete(int id)
        {
            Point item = db.Points.Find(id);
            if (item != null)
                db.Points.Remove(item);
        }

        public IEnumerable<Point> Find(Func<Point, bool> predicate)
        {
            return db.Points.ToList();
        }

        public Point Get(int id)
        {
            Point item = db.Points.Find(id);
            return item;
        }

        public IEnumerable<Point> GetAll()
        {
            return db.Points;
        }

        public int GetCount()
        {
            return db.Points.Count();
        }

        public void Update(Point item)
        {
            db.Entry(item).State = EntityState.Modified;
        }
    }
}
