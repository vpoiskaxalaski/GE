using GE.DAL.Model;
using GE.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GE.DAL.Repositories
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
            return db.Posts.Include(x => x.ImagesGallery)
                .Include(x => x.ImagesGallery)
                .Include(x => x.Subcategory)
                .Include(x => x.City)
                .Include(x => x.User);
        }

        public Post Get(int id)
        {
            var imageGallery = db.ImagesGalleries.Where(x => x.PostId == id);
            var post = db.Posts.Find(id);
            post.ImagesGallery = imageGallery.ToList();
            return post;
        }

        public void Create(Post lot)
        {
            db.Posts.Add(lot);
        }

        public void Update(Post item)
        {
            var result = Get(item.Id);
            if (result != null)
            {
                result.Name = item.Name;
                result.Description = item.Description;
                result.Status = item.Status;
            }
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

        public void RemoveRange(IEnumerable<Post> items)
        {
            throw new NotImplementedException();
        }
    }
}
