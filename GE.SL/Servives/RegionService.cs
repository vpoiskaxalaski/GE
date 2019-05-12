using AutoMapper;
using GE.DAL.Interfaces;
using GE.DAL.Model;
using GE.Models;
using GE.SL.Interfaces;
using System.Collections.Generic;

namespace GE.SL.Servives
{
    public class RegionService : IRegionService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public RegionService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public List<RegionVM> GetAll()
        {
            List<RegionVM> regionsVM = new List<RegionVM>();
            List<CityVM> citiesVM = new List<CityVM>();
            ICollection<CityVM> cityVMs;
            RegionVM regionVM;

            IEnumerable<Region> regions = _unitOfWork.Regions.GetAll();

            MapperConfiguration config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<City, CityVM>();
            });
            IMapper map = config.CreateMapper();

            foreach (Region region in regions)
            {
                regionVM = new RegionVM { Name = region.Name };
                cityVMs = map.Map<ICollection<City>, ICollection<CityVM>>(region.Cities);
                regionVM.Cities = cityVMs;
                regionsVM.Add(regionVM);
            }

            return regionsVM;
        }
    }
}
