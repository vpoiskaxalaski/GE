using GE.DAL.Model;
using GE.RL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace GE.RL.Repositories
{
    public class RegionRepository : IRepository<Region>
    {
        private DatabaseContext db;

        public RegionRepository(DatabaseContext context)
        {
            this.db = context;
        }
        public void Create(Region item)
        {
            db.Add(item);
        }

        public void Delete(int id)
        {
            Region item = db.Regions.Find(id);
            if (item != null)
                db.Regions.Remove(item);
        }

        public IEnumerable<Region> Find(Func<Region, bool> predicate)
        {
            return db.Regions.ToList();
        }

        public Region Get(int id)
        {
            Region item = db.Regions.Find(id);
            return item;
        }

        public IEnumerable<Region> GetAll()
        {
            return db.Regions.Include(s => s.Cities);
        }

        public int GetCount()
        {
            return db.Regions.Count();
        }

        public void Update(Region item)
        {
            db.Entry(item).State = EntityState.Modified;
        }
    }
}