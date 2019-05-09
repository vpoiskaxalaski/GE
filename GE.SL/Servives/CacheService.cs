using GE.Models;
using GE.SL.Interfaces;
using System.Collections.Generic;

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

        public void CacheRegions(IRegionService regionService)
        {
            IList<RegionVM> regions = System.Runtime.Caching.MemoryCache.Default["Regions"] as IList<RegionVM>;
            if (regions == null) //not in cache
            {
                regions = regionService.GetAll();
                System.Runtime.Caching.MemoryCache.Default["Regions"] = regions;
            }
        }
    }
}
