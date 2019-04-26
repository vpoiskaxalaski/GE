using GE.RL.Interfaces;
using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Text;
using GE.DAL.Model;

namespace GE.RL.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private DatabaseContext db;
        private CategoryRepository categoryRepository;
        private SubcategoryRepository subcategoryRepository;
        private PostRepository postRepository;
        private CityRepository cityRepository;
        private RegionRepository regionRepository;
        /*
  private OrderRepository orderRepository;
  private ImagesGalleryRepository imagesGlleryRepository;
  private PointRepository pointRepository;

  */

        public UnitOfWork(DbContextOptions<DatabaseContext> options)
        {
            db = new DatabaseContext(options);
        }
        /*
        public IRepository<Order> Orders
        {
            get
            {
                if (orderRepository == null)
                    orderRepository = new OrderRepository(db);
                return orderRepository;
            }
        }
        */
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

        public IRepository<Post> Posts
        {
            get
            {
                if (postRepository == null)
                {
                    postRepository = new PostRepository(db);
                }

                return postRepository;
            }
        }

        public IRepository<City> Cities
         {
            get
            {
                if (cityRepository == null)
                {
                    cityRepository = new CityRepository(db);
                }

                return cityRepository;
            }
        }

        public IRepository<Region> Regions
        {
            get
            {
                if (regionRepository == null)
                {
                   regionRepository = new RegionRepository(db);
                }

                return regionRepository;
            }
        }
        /*






       public IRepository<Point> Points => throw new NotImplementedException();

       public IRepository<ImagesGallery> ImagesGallery => throw new NotImplementedException();
       */
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

        public void CategoriesInit()
        {
            if (Categories.GetCount() == 0)
            {
                Categories.Create(
                   new Category
                   {
                       Name = "Мода и стиль",
                       Subcategories = new List<Subcategory>()
                       {
                           new Subcategory("Мужская одежда", 15, "Мода и стиль"),
                           new Subcategory("Женская одежда", 15, "Мода и стиль"),
                           new Subcategory("Мужская обувь", 10, "Мода и стиль"),
                           new Subcategory("Женская обувь", 10, "Мода и стиль"),
                           new Subcategory("Аксессуары и часы", 8, "Мода и стиль"),
                           new Subcategory("Косметика и парфюмерия",8,"Мода и стиль")
                       }
                   });
                Categories.Create(
                 new Category
                 {
                     Name = "Техника",
                     Subcategories = new List<Subcategory>()
                     {
                            new Subcategory("Аудиотехника", 25, "Техника"),
                            new Subcategory("ТВ и видеотехника", 30, "Техника"),
                            new Subcategory("Компьютеры и комплектующие", 35, "Техника"),
                            new Subcategory("Фототехника и оптика", 25, "Техника"),
                            new Subcategory("Телефоны", 15, "Техника"),
                            new Subcategory("Фототехника и оптика", 25, "Техника"),
                            new Subcategory("Бытовая техника", 30, "Техника"),
                            new Subcategory("Планшеты и электронные книги", 20, "Техника"),
                            new Subcategory("Бытовая техника", 30, "Техника"),
                     }
                 });
                Categories.Create(
                 new Category
                 {
                     Name = "Все для дома",
                     Subcategories = new List<Subcategory>()
                     {
                            new Subcategory("Мебель и интерьер", 20, "Все для дома"),
                            new Subcategory("Посуда и кухонные принадлежности", 20, "Все для дома"),
                            new Subcategory("Комнатные растения", 5, "Все для дома"),
                            new Subcategory("Мебель и интерьер", 20, "Все для дома"),
                            new Subcategory("Мебель и интерьер", 20, "Все для дома"),
                            new Subcategory("Мебель и интерьер", 20, "Все для дома")
                     }
                 });
                Categories.Create(
                 new Category
                 {
                     Name = "Сад и огород",
                     Subcategories = new List<Subcategory>()
                      {
                            new Subcategory("Садовая мебель", 10, "Сад и огород"),
                            new Subcategory("Садовые растения рассада и семена", 5, "Сад и огород"),
                            new Subcategory("Садовая техника и инвентарь", 8, "Сад и огород"),
                            new Subcategory("Садовые аксессуары", 10, "Сад и огород"),
                      }
                 });
                db.SaveChanges();
            }
        }
    }
}
