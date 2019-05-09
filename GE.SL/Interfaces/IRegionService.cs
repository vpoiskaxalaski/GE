using GE.Models;
using System.Collections.Generic;

namespace GE.SL.Interfaces
{
    public interface IRegionService
    {
        List<RegionVM> GetAll();
    }
}
