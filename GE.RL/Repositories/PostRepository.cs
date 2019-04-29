using GE.DAL.Model;
using GE.RL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GE.RL.Repositories
{
    public class PostRepository : IRepository<Post>
    {
        private DatabaseContext db;

        public PostRepository(DatabaseContext context)
        {
            this.db = context;
        }

        public IEnumerable<Post> GetAll()
        {
            return db.Posts;
        }

        public Post Get(int id)
        {
            return db.Posts.Find(id);
        }

        public void Create(Post lot)
        {
            db.Posts.Add(lot);
        }

        public void Update(Post lot)
        {
            db.Entry(lot).State = EntityState.Modified;
        }

        public IEnumerable<Post> Find(Func<Post, Boolean> predicate)
        {
            return db.Posts.Where(predicate).ToList();
        }

        public void Delete(int id)
        {
            Post lot  = db.Posts.Find(id);
            if (lot != null)
                db.Posts.Remove(lot);
        }

        public int GetCount()
        {
            return db.Posts.Count();
        }
    }
}
