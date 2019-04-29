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
    
    public class ApplicationUserRepository : IRepository<ApplicationUser>
    {
        private DatabaseContext db;

        public ApplicationUserRepository(DatabaseContext context)
        {
            this.db = context;
        }
        public void Create(ApplicationUser item)
        {
            db.Add(item);
        }

        public void Delete(int id)
        {
            ApplicationUser item = db.Users.Find(id);
            if (item != null)
                db.Users.Remove(item);
        }

        public IEnumerable<ApplicationUser> Find(Func<ApplicationUser, bool> predicate)
        {
            return db.Users;
        }

        public ApplicationUser Get(int id)
        {
            ApplicationUser item = db.Users.Find(id);
            //item.Subcategories.AddRange(subitemRepository.GetAll().Where(i => item.Name == i.ApplicationUserName));
            return item;
        }

        public IEnumerable<ApplicationUser> GetAll()
        {
            return db.Users;
        }

        public int GetCount()
        {
            return db.Users.Count();
        }

        public void Update(ApplicationUser item)
        {
            db.Entry(item).State = EntityState.Modified;
        }
    }
}