using System;
using System.Collections.Generic;
using System.Text;

namespace GE.Models
{
    public class RegionVM
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<CityVM> Cities { get; set; }
    }
}
