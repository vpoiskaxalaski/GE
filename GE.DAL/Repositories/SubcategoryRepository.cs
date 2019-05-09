using GE.DAL.Model;
using GE.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace GE.DAL.Repositories
{
    class SubcategoryRepository : IRepository<Subcategory>
    {
        private DatabaseContext db;

        public SubcategoryRepository(DatabaseContext context)
        {
            this.db = context;
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
        public IEnumerable<Subcategory> Find(Func<Subcategory, Boolean> predicate)
        {
            return db.Subcategories.Where(predicate).ToList();
        }
        public void Delete(int id)
        {
            Subcategory subcategory = db.Subcategories.Find(id);
            if (subcategory != null)
                db.Subcategories.Remove(subcategory);
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