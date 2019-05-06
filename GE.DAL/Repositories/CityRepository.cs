using GE.DAL.Model;
using GE.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GE.DAL.Repositories
{
    public class CityRepository : IRepository<City>
    {
        private DatabaseContext db;

        public CityRepository(DatabaseContext context)
        {
            this.db = context;
        }
        public void Create(City item)
        {
            db.Add(item);
        }

        public void Delete(int id)
        {
            City item = db.Cities.Find(id);
            if (item != null)
                db.Cities.Remove(item);
        }

        public IEnumerable<City> Find(Func<City, bool> predicate)
        {
            return db.Cities;
        }

        public City Get(int id)
        {
            City item = db.Cities.Find(id);
            return item;
        }

        public IEnumerable<City> GetAll()
        {
            return db.Cities;
        }

        public int GetCount()
        {
            return db.Cities.Count();
        }

        public void Update(City item)
        {
            db.Entry(item).State = EntityState.Modified;
        }
    }
}
