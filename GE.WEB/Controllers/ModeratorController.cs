using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GE.SL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using PagedList.Core;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GE.WEB.Controllers
{
    public class ModeratorController : Controller
    {
        private IPostService _postService;
        private IImageGalleryService _imageGalleryService;

        public ModeratorController(IPostService postService, IImageGalleryService imageGalleryService)
        {
            _postService = postService;
            _imageGalleryService = imageGalleryService;
        }

        public ActionResult Index(int? page)
        { 
            ViewBag.Message = TempData["Message"];
            int pageSize = 20;
            int pageNumber = (page ?? 1);
            ViewBag.Posts = _postService.GetAll().Where(i => i.Status == "0");
            return View();//View(_postService.GetAll().Where(i => i.Status == "0").ToList().ToPagedList(pageNumber, pageSize));
        }

        [HttpPost]
        public ActionResult ResolvePost(int id)
        {
            var post = _postService.FindById(id); 
            post.Status = "1";
            _postService.Update(post);
            TempData["Message"] = "Пост был успешно одобрен";

            return RedirectToAction("Index", "Moderator");
        }

        [HttpPost]
        public ActionResult RejectPost(int id)
        { 
            var post = _postService.FindById(id);
            if (post != null)
            {
                _postService.Remove(id);

                var images = _imageGalleryService.Find(id).ToList();
                if (images.Count == 1)
                    _imageGalleryService.RemoveItem(images[0]);
                else
                    _imageGalleryService.RemoveRange(images);

                TempData["Message"] = "Пост был успешно отклонен";
            }
            else TempData["Message"] = "Что-то пошло не так";

            return RedirectToAction("Index");
        }
    }
}
