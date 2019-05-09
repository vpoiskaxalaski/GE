namespace GE.Models
{
    public class SubcategoryVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Points { get; set; }
        public string CategoryName { get; set; }

        public CategoryVM Category { get; set; }
    }
}