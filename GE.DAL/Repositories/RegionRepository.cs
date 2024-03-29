﻿using GE.DAL.Interfaces;
using GE.DAL.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GE.DAL.Repositories
{
    public class RegionRepository : IRepository<Region>
    {
        private DatabaseContext db;

        public RegionRepository(DatabaseContext context)
        {
            db = context;
        }
        public void Create(Region item)
        {
            db.Add(item);
        }

        public void Delete(int id)
        {
            Region item = db.Regions.Find(id);
            if (item != null)
            {
                db.Regions.Remove(item);
            }
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

        public void RemoveRange(IEnumerable<Region> items)
        {
            throw new NotImplementedException();
        }

        public void Update(Region item)
        {
            db.Entry(item).State = EntityState.Modified;
        }
    }
}