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
        IRepository<Subcategory> subcategoryRepository;

        public CategoryRepository(DatabaseContext context, IRepository<Subcategory> subcategoryRepository)
        {
            this.db = context;
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
                db.Categories.Remove(category);
        }

        public IEnumerable<Category> Find(Func<Category, bool> predicate)
        {
            return db.Categories.Include(s => subcategoryRepository.GetAll().Where(i => s.Name == i.CategoryName )).ToList();
        }

        public Category Get(int id)
        {
            Category category = db.Categories.Find(id);
            category.Subcategories.AddRange(subcategoryRepository.GetAll().Where(i => category.Name == i.CategoryName));
            return category;
        }

        public IEnumerable<Category> GetAll()
        {
            return db.Categories.Include(s => s.Subcategories );
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
