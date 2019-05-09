namespace GE.SL.Interfaces
{
    public interface ICacheService
    {
        void CacheCategories(ICategoryService categoryService);
        void CacheRegions(IRegionService regionService);
    }
}
