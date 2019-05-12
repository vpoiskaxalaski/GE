using GE.SL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;


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

        [HttpGet]
        [Route("/Moderator")]
        [Route("/Moderator/Index")]
        public ActionResult Index(int? page)
        {
            ViewBag.Message = TempData["Message"];
            ViewBag.Posts = _postService.GetAll().Where(i => i.Status == "0");

            return View();
        }

        [HttpPost]
        public IActionResult ResolvePost(int id)
        {
            Models.PostVM post = _postService.FindById(id);
            post.Status = "1";
            _postService.Update(post);
            TempData["Message"] = "Пост был успешно одобрен";

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult RejectPost(int id)
        {
            Models.PostVM post = _postService.FindById(id);
            if (post != null)
            {
                _postService.Remove(id);
                List<Models.ImagesGalleryVM> images = _imageGalleryService.Find(id).ToList();
                if (images.Count == 1)
                {
                    _imageGalleryService.RemoveItem(images[0]);
                }
                else
                {
                    _imageGalleryService.RemoveRange(images);
                }

                TempData["Message"] = "Пост был успешно отклонен";
            }
            else
            {
                TempData["Message"] = "Что-то пошло не так";
            }

            return RedirectToAction("Index");
        }
    }
}
