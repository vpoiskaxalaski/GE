using System;
using System.Collections.Generic;
using System.Text;

namespace GE.DAL.Model
{
    public class Region
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<City> Cities { get; set; }
    }
}
