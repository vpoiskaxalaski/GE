using GE.DAL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace GE.RL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {        
        IRepository<Category> Categories { get; }
        IRepository<Subcategory> Subcategories { get; }
        IRepository<Post> Posts { get; }
        IRepository<City> Cities { get; }
        IRepository<Region> Regions { get; }
        /*



        IRepository<Point> Points { get; }
        IRepository<ImagesGallery> ImagesGallery { get; }
        IRepository<Order> Orders { get; }
        */

        void Save();
        void CategoriesInit();
    }
}
