using GE.DAL.Model;
using GE.RL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GE.RL.Repositories
{
    public class CityRepository : IRepository<City>
    {
        private DatabaseContext db;

        public CityRepository(DatabaseContext context)
        {
            this.db = context;
        }

        public IEnumerable<City> GetAll()
        {
            return db.Cities;
        }

        public City Get(int id)
        {
            return db.Cities.Find(id);
        }

        public void Create(City City)
        {
            db.Cities.Add(City);
        }

        public void Update(City City)
        {
            db.Entry(City).State = EntityState.Modified;
        }

        public IEnumerable<City> Find(Func<City, Boolean> predicate)
        {
            return db.Cities.Where(predicate);
        }

        public void Delete(int id)
        {
            City city = db.Cities.Find(id);
            if (city != null)
                db.Cities.Remove(city);
        }

        public int GetCount()
        {
            return db.Cities.Count();
        }
    }
}
