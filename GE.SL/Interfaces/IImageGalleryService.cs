using GE.Models;
using System.Collections.Generic;

namespace GE.SL.Interfaces
{
    public interface IImageGalleryService
    {
        void RemoveRange(IEnumerable<ImagesGalleryVM> items);

        void RemoveItem(ImagesGalleryVM item);

        List<ImagesGalleryVM> Find(int postId);
    }
}
