using System;
using System.Collections.Generic;
using System.Text;

namespace GE.Models
{
    public class ImagesGalleryVM
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        //public byte[] ImageData { get; set; }
        public int PostId { get; set; }

        public virtual PostVM Post { get; set; }
    }
}
