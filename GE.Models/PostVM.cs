using System;
using System.Collections.Generic;
using System.Text;

namespace GE.Models
{
    public class PostVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CityId { get; set; }    
        public string DateCreatePost { get; set; }       
        public string UserId { get; set; }        
        public int SubcategoryId { get; set; }        
        public int? VideoId { get; set; }        
        public string Status { get; set; }

        public virtual CityVM City { get; set; }
        public virtual ApplicationUserVM User { get; set; }
        public virtual SubcategoryVM Subcategory { get; set; }
        public virtual VideoVM Video { get; set; }
        public virtual ICollection<ImagesGalleryVM> ImagesGallery { get; set; }
    }
}
