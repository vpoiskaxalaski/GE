using System;
using System.Collections.Generic;
using System.Text;

namespace GE.DAL.Model
{
    public class Post
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string CityId { get; set; }
        public virtual City City { get; set; }
        public string DateCreatePost { get; set; }
        public virtual ICollection<ImagesGallery> ImagesGallery { get; set; }
        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }
        public string SubcategoryId { get; set; }
        public virtual Subcategory Subcategory { get; set; }
        public string VideoId { get; set; }
        public virtual Video Video { get; set; }
        public string Status { get; set; }
    }
}
