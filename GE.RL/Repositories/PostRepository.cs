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

        public void Create(Post post)
        {
            db.Posts.Add(post);
        }

        public void Update(Post post)
        {
            db.Entry(post).State = EntityState.Modified;
        }

        public IEnumerable<Post> Find(Func<Post, Boolean> predicate)
        {
            return db.Posts.Where(predicate);
        }

        public void Delete(int id)
        {
            Post post  = db.Posts.Find(id);
            if (post != null)
                db.Posts.Remove(post);
        }

        public int GetCount()
        {
            return db.Posts.Count();
        }
    }
}
