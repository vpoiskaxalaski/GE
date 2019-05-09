namespace GE.Models
{
    public class CityVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string RegionName { get; set; }

        public RegionVM Region { get; set; }
    }
}
