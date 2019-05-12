using GE.DAL.Interfaces;
using GE.DAL.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GE.DAL.Repositories
{
    internal class CategoryRepository : IRepository<Category>
    {
        private DatabaseContext db;
        private IRepository<Subcategory> subcategoryRepository;

        public CategoryRepository(DatabaseContext context, IRepository<Subcategory> subcategoryRepository)
        {
            db = context;
            this.subcategoryRepository = subcategoryRepository;
        }
        public void Create(Category item)
        {
            db.Add(item);
        }

        public void Delete(int id)
        {
            Category category = db.Categories.Find(id);
            if (category != null)
            {
                db.Categories.Remove(category);
            }
        }

        public IEnumerable<Category> Find(Func<Category, bool> predicate)
        {
            return db.Categories.Include(s => subcategoryRepository.GetAll().Where(i => s.Name == i.CategoryName));
        }

        public Category Get(int id)
        {
            Category category = db.Categories.Find(id);

            return category;
        }

        public IEnumerable<Category> GetAll()
        {
            return db.Categories.Include(s => s.Subcategories);
        }

        public int GetCount()
        {
            return db.Categories.Count();
        }

        public void RemoveRange(IEnumerable<Category> items)
        {
            throw new NotImplementedException();
        }

        public void Update(Category item)
        {
            db.Entry(item).State = EntityState.Modified;
        }
    }
}
