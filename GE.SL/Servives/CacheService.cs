using GE.Models;
using GE.SL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GE.SL.Servives
{
    public class CacheService : ICacheService
    {
        public void CacheCategories(ICategoryService categoryService)
        {
            IList<CategoryVM> categories = System.Runtime.Caching.MemoryCache.Default["Categories"] as IList<CategoryVM>;
            if (categories == null) //not in cache
            {
                categories = categoryService.GetAll();
                System.Runtime.Caching.MemoryCache.Default["Categories"] = categories;
            }
        }
    }
}
