namespace GE.DAL.Model
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string RegionName { get; set; }       

        public Region Region { get; set; }
    }
}
