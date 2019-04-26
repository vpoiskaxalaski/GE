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

        public IEnumerable<Region> GetAll()
        {
            return db.Regions;
        }

        public Region Get(int id)
        {
            return db.Regions.Find(id);
        }

        public void Create(Region region)
        {
            db.Regions.Add(region);
        }

        public void Update(Region region)
        {
            db.Entry(region).State = EntityState.Modified;
        }

        public IEnumerable<Region> Find(Func<Region, Boolean> predicate)
        {
            return db.Regions.Where(predicate);
        }

        public void Delete(int id)
        {
            Region region = db.Regions.Find(id);
            if (region != null)
                db.Regions.Remove(region);
        }

        public int GetCount()
        {
            return db.Regions.Count();
        }
    }
}