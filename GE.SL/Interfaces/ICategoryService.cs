using GE.Models;
using System.Collections.Generic;

namespace GE.SL.Interfaces
{
    public interface ICategoryService
    {
        List<CategoryVM> GetAll();
    }
}
