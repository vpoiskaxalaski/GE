using GE.DAL.Model;
using GE.RL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GE.RL.Repositories
{
    class CategoryRepository : IRepository<Category>
    {
        private DatabaseContext db;

        public CategoryRepository(DatabaseContext context)
        {
            this.db = context;
        }
        public void Create(Category item)
        {
            db.Add(item);
        }

        public void Delete(int id)
        {
            Category category = db.Categories.Find(id);
            if (category != null)
                db.Categories.Remove(category);
        }

        public IEnumerable<Category> Find(Func<Category, bool> predicate)
        {
            return db.Categories.Where(predicate).ToList();
        }

        public Category Get(int id)
        {
            return db.Categories.Find(id);
        }

        public IEnumerable<Category> GetAll()
        {
            return db.Categories;
        }

        public int GetCount()
        {
            return db.Categories.Count();
        }

        public void Update(Category item)
        {
            db.Entry(item).State = EntityState.Modified;
        }
    }
}
