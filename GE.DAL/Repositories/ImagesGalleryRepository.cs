﻿using GE.DAL.Interfaces;
using GE.DAL.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GE.DAL.Repositories
{
    public class ImagesGalleryRepository : IRepository<ImagesGallery>
    {
        private DatabaseContext db;

        public ImagesGalleryRepository(DatabaseContext context)
        {
            db = context;
        }
        public void Create(ImagesGallery item)
        {
            db.Add(item);
        }

        public void Delete(int id)
        {
            ImagesGallery item = db.ImagesGalleries.Find(id);
            if (item != null)
            {
                db.ImagesGalleries.Remove(item);
            }
        }

        public IEnumerable<ImagesGallery> Find(Func<ImagesGallery, bool> predicate)
        {
            return db.ImagesGalleries.Where(predicate);
        }

        public ImagesGallery Get(int id)
        {
            ImagesGallery item = db.ImagesGalleries.Find(id);
            return item;
        }

        public IEnumerable<ImagesGallery> GetAll()
        {
            return db.ImagesGalleries.ToList();
        }

        public int GetCount()
        {
            return db.ImagesGalleries.Count();
        }

        public void RemoveRange(IEnumerable<ImagesGallery> items)
        {
            db.ImagesGalleries.RemoveRange(items);
        }

        public void Update(ImagesGallery item)
        {
            db.Entry(item).State = EntityState.Modified;
        }
    }
}
