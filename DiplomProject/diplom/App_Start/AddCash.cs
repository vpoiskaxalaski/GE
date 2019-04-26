using diplom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace diplom
{ 
    public class AddCash
    {
        public static void AddCashMethod()
        {
            List<Category> categories = System.Runtime.Caching.MemoryCache.Default["Categories"] as List<Category>;
            List<Region> regions = System.Runtime.Caching.MemoryCache.Default["Regions"] as List<Region>;
            List<City> cities = System.Runtime.Caching.MemoryCache.Default["Cities"] as List<City>;
            List<Subcategory> subcategories = System.Runtime.Caching.MemoryCache.Default["Subcategories"] as List<Subcategory>;
            if (categories == null || regions == null || cities == null || subcategories == null) //not in cache
            {
                using (ApplicationDbContext db = new ApplicationDbContext())
                {
                    categories = db.Categories.ToList();
                    regions = db.Regions.ToList();
                    cities = db.Cities.ToList();
                    subcategories = db.Subcategories.ToList();
                    System.Runtime.Caching.MemoryCache.Default["Categories"] = categories;
                    System.Runtime.Caching.MemoryCache.Default["Regions"] = regions;
                    System.Runtime.Caching.MemoryCache.Default["Cities"] = cities;
                    System.Runtime.Caching.MemoryCache.Default["Subcategories"] = subcategories;
                }
            }
        }
    }
}