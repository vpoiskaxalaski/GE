using System;
using System.Collections.Generic;
using System.Text;

namespace GE.DAL.Model
{
    public class City
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string RegionName { get; set; }
        public string RegionId { get; set; }
        public Region Region { get; set; }
    }
}
