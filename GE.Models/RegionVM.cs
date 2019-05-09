using System.Collections.Generic;

namespace GE.Models
{
    public class RegionVM
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<CityVM> Cities { get; set; }
    }
}
