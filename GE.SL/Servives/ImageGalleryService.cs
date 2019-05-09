using AutoMapper;
using GE.DAL.Interfaces;
using GE.DAL.Model;
using GE.Models;
using GE.SL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

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
            var items = _unitOfWork.ImagesGallery.GetAll();
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<ImagesGallery, ImagesGalleryVM>();
            });
            var map = config.CreateMapper();
            var images = map.Map<IEnumerable<ImagesGallery>, ICollection<ImagesGalleryVM>>(items);
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
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<ImagesGalleryVM, ImagesGallery>();
            });
            var map = config.CreateMapper();
            var images = map.Map<IEnumerable<ImagesGalleryVM>, ICollection<ImagesGallery>>(items);

            _unitOfWork.ImagesGallery.RemoveRange(images);
        }
    }
}
