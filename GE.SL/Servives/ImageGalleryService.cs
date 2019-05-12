using AutoMapper;
using GE.DAL.Interfaces;
using GE.DAL.Model;
using GE.Models;
using GE.SL.Interfaces;
using System.Collections.Generic;

namespace GE.SL.Servives
{
    public class ImageGalleryService : IImageGalleryService
    {
        private IUnitOfWork _unitOfWork;

        public ImageGalleryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public List<ImagesGalleryVM> Find(int postId)
        {
            IEnumerable<ImagesGallery> items = _unitOfWork.ImagesGallery.GetAll();
            MapperConfiguration config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ImagesGallery, ImagesGalleryVM>();
            });
            IMapper map = config.CreateMapper();
            ICollection<ImagesGalleryVM> images = map.Map<IEnumerable<ImagesGallery>, ICollection<ImagesGalleryVM>>(items);
            List<ImagesGalleryVM> result = new List<ImagesGalleryVM>();
            result.AddRange(images);

            return result.FindAll(x => x.PostId == postId);
        }

        public void RemoveItem(ImagesGalleryVM item)
        {
            _unitOfWork.ImagesGallery.Delete(item.Id);
            _unitOfWork.Save();
        }

        public void RemoveRange(IEnumerable<ImagesGalleryVM> items)
        {
            MapperConfiguration config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ImagesGalleryVM, ImagesGallery>();
            });
            IMapper map = config.CreateMapper();
            ICollection<ImagesGallery> images = map.Map<IEnumerable<ImagesGalleryVM>, ICollection<ImagesGallery>>(items);

            _unitOfWork.ImagesGallery.RemoveRange(images);
        }
    }
}
