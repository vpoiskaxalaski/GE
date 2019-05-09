namespace GE.Models
{
    public class OrderVM
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public string UserId { get; set; }

        public virtual PostVM Post { get; set; }
        public virtual ApplicationUserVM User { get; set; }
    }
}
