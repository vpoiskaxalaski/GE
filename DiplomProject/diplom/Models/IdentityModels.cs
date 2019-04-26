using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace diplom.Models
{
    // В профиль пользователя можно добавить дополнительные данные, если указать больше свойств для класса ApplicationUser. Подробности см. на странице https://go.microsoft.com/fwlink/?LinkID=317594.
    public class ApplicationUser : IdentityUser
    {
        public virtual Point Points { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Обратите внимание, что authenticationType должен совпадать с типом, определенным в CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Здесь добавьте утверждения пользователя
            return userIdentity;
        }
    }

    public class Post
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string CityId { get; set; }
        public virtual City City { get; set; }
        public string DateCreatePost { get; set; }
        public virtual ICollection<ImagesGallery> ImagesGallery { get; set; }
        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }
        public string SubcategoryId { get; set; }
        public virtual Subcategory Subcategory { get; set; }
        public string VideoId { get; set; }
        public virtual Video Video { get; set; }
        public string Status { get; set; }
    }

    public class ImagesGallery
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        //public byte[] ImageData { get; set; }
        public string PostId { get; set; }
        public virtual Post Post { get; set; }
    }

    public class Video
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
    }

    public class Point
    {
        public string Id { get; set; }
        [Required]
        public virtual ApplicationUser User { get; set; }
        public int Points { get; set; }
        public virtual ICollection<Operation> Operations { get; set; }
    }

    public class Operation
    {
        public string Id { get; set; }
        public int? Earned { get; set; }
        public int? Spent { get; set; }
        public string Date { get; set; }
        public string PointId { get; set; }
        public virtual Point Point { get; set; }
    }

    public class Order
    {
        public string Id { get; set; }
        public string PostId { get; set; }
        public virtual Post Post { get; set; }
        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }
    }

    public class Category
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Subcategory> Subcategories { get; set; }
    }

    public class Subcategory
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Points { get; set; }
        public string CategoryName { get; set; }
        public string CategoryId { get; set; }
        public Category Category { get; set; }
    }

    public class Region
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<City> Cities { get; set; }
    }

    public class City
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string RegionName { get; set; }
        public string RegionId { get; set; }
        public Region Region { get; set; }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Subcategory> Subcategories { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Point> Points { get; set; }
        public DbSet<ImagesGallery> ImagesGallery { get; set; }
        public DbSet<Operation> Operations { get; set; }
        public DbSet<Order> Orders { get; set; }
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

    }
}