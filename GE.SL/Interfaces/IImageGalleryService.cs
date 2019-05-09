using GE.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GE.SL.Interfaces
{
    public interface IImageGalleryService
    {
        void RemoveRange(IEnumerable<ImagesGalleryVM> items);

        void RemoveItem(ImagesGalleryVM item);

        List<ImagesGalleryVM> Find(int postId);
    }
}
