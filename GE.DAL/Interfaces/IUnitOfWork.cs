using GE.DAL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace GE.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {           
        IRepository<Category> Categories { get; }
        IRepository<Subcategory> Subcategories { get; }
        IRepository<Region> Regions { get; }
        IRepository<City> Cities{ get; }
        IRepository<Post> Posts { get; }
        IRepository<ImagesGallery> ImagesGallery { get; }
        IRepository<Order> Orders { get; }
        IRepository<Operation> Operations { get; }
        IApplicationUserRepository ApplicationUsers { get; }
        
        void Save();
    }
}
