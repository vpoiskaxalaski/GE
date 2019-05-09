namespace GE.DAL.Model
{
    public class Operation
    {
        public int Id { get; set; }
        public int? Earned { get; set; }
        public int? Spent { get; set; }
        public string Date { get; set; }
        public string UserId { get; set; }

        public ApplicationUser User { get; set; }
    }
}
