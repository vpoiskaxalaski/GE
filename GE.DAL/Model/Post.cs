using System.Collections.Generic;

namespace GE.DAL.Model
{
    public class Post
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; } 
        public string DateCreatePost { get; set; }           
        public string Status { get; set; }
        public int CityId { get; set; }
        public string UserId { get; set; }
        public int SubcategoryId { get; set; }

        public virtual City City { get; set; }
        public virtual ApplicationUser User { get; set; }
        public virtual Subcategory Subcategory { get; set; }
        public virtual ICollection<ImagesGallery> ImagesGallery { get; set; }
    }
}
