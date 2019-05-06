using GE.DAL.Interfaces;
using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Text;
using GE.DAL.Model;

namespace GE.DAL.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private DatabaseContext db;

        private CategoryRepository categoryRepository;
        private SubcategoryRepository subcategoryRepository;
        private OrderRepository orderRepository;
        private RegionRepository regionRepository;
        private CityRepository cityRepository;
        private ImagesGalleryRepository imagesGlleryRepository;
        private PointRepository pointRepository;
        private PostRepository postRepository;
        private ApplicationUserRepository userRepository;
        

        public UnitOfWork(DbContextOptions<DatabaseContext> options)
        {
            db = new DatabaseContext(options);
        }

        public IRepository<Subcategory> Subcategories
        {
            get
            {
                if (subcategoryRepository == null)
                {
                    subcategoryRepository = new SubcategoryRepository(db);
                }

                return subcategoryRepository;
            }
        }

        public IRepository<Category> Categories 
        {
            get
            {
                if (categoryRepository == null)
                {
                    categoryRepository = new CategoryRepository(db, Subcategories);
                }

                return categoryRepository;
            }
        }

        
        public IRepository<Order> Orders
        {
            get
            {
                if (orderRepository == null)
                    orderRepository = new OrderRepository(db);
                return orderRepository;
            }
        }


        public IRepository<Region> Regions
        {
            get
            {
                if (regionRepository == null)
                    regionRepository = new RegionRepository(db);
                return regionRepository;
            }
        }

        public IRepository<City> Cities
        {
            get
            {
                if (cityRepository == null)
                    cityRepository = new CityRepository(db);
                return cityRepository;
            }
        }

        public IRepository<Post> Posts
        {
            get
            {
                if (postRepository == null)
                    postRepository = new PostRepository(db);
                return postRepository;
            }
        }

        public IRepository<Point> Points
        {
            get
            {
                if (pointRepository == null)
                    pointRepository = new PointRepository(db);
                return pointRepository;
            }
        }

        public IRepository<ImagesGallery> ImagesGallery
        {
            get
            {
                if (imagesGlleryRepository == null)
                    imagesGlleryRepository = new ImagesGalleryRepository(db);
                return imagesGlleryRepository;
            }
        }

        IApplicationUserRepository IUnitOfWork.ApplicationUsers
        {
            get
            {
                if (userRepository == null)
                    userRepository = new ApplicationUserRepository(db);
                return userRepository;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
