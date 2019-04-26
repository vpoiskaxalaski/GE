using System;
using System.Collections.Generic;
using System.Text;
using GE.DAL.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GE.WEB.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Subcategory> Subcategories { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<ImagesGallery> ImagesGalleries { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Point> Points { get; set; }
        public DbSet<Order> Orders { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
