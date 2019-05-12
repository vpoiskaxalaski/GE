using AutoMapper;
using GE.DAL.Interfaces;
using GE.DAL.Model;
using GE.Models;
using GE.SL.Interfaces;
using System.Collections.Generic;

namespace GE.SL.Servives
{
    public class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CategoryService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public List<CategoryVM> GetAll()
        {
            List<CategoryVM> categoriesVM = new List<CategoryVM>();
            List<SubcategoryVM> subcategoriesVM = new List<SubcategoryVM>();
            ICollection<SubcategoryVM> subcategoryVMs;
            CategoryVM categoryVM;

            IEnumerable<Category> categories = _unitOfWork.Categories.GetAll();

            MapperConfiguration config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Subcategory, SubcategoryVM>();
            });


            IMapper map = config.CreateMapper();

            foreach (Category category in categories)
            {
                categoryVM = new CategoryVM { Name = category.Name };

                subcategoryVMs = map.Map<ICollection<Subcategory>, ICollection<SubcategoryVM>>(category.Subcategories);

                categoryVM.Subcategories = subcategoryVMs;
                categoriesVM.Add(categoryVM);
            }

            return categoriesVM;
        }
    }
}
