using System.Collections.Generic;

namespace GE.DAL.Model
{
    public class Region
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<City> Cities { get; set; }
    }
}
