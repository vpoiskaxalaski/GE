namespace GE.DAL.Model
{
    public class Subcategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Points { get; set; }
        public string CategoryName { get; set; }

        public Category Category { get; set; }
    }
}