using GE.DAL.Interfaces;
using GE.DAL.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GE.DAL.Repositories
{
    internal class SubcategoryRepository : IRepository<Subcategory>
    {
        private DatabaseContext db;

        public SubcategoryRepository(DatabaseContext context)
        {
            db = context;
        }

        public IEnumerable<Subcategory> GetAll()
        {
            return db.Subcategories;
        }

        public Subcategory Get(int id)
        {
            return db.Subcategories.Find(id);
        }

        public void Create(Subcategory subcategory)
        {
            db.Subcategories.Add(subcategory);
        }

        public void Update(Subcategory subcategory)
        {
            db.Entry(subcategory).State = EntityState.Modified;
        }
        public IEnumerable<Subcategory> Find(Func<Subcategory, bool> predicate)
        {
            return db.Subcategories.Where(predicate).ToList();
        }
        public void Delete(int id)
        {
            Subcategory subcategory = db.Subcategories.Find(id);
            if (subcategory != null)
            {
                db.Subcategories.Remove(subcategory);
            }
        }

        public int GetCount()
        {
            return db.Subcategories.Count();
        }

        public void RemoveRange(IEnumerable<Subcategory> items)
        {
            throw new NotImplementedException();
        }
    }
}