using diplom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;

namespace diplom.Controllers
{
    public class ModeratorController : Controller
    {
        private ApplicationDbContext db;
        // GET: Moderator
        public ActionResult Index(int? page)
        {
            db = new ApplicationDbContext();
            ViewBag.Message = TempData["Message"];
            int pageSize = 20;
            int pageNumber = (page ?? 1);
            return View(db.Posts.Where(i => i.Status == "0").ToList().ToPagedList(pageNumber, pageSize));
        }

        [HttpPost]
        public ActionResult ResolvePost(string id)
        {
            db = new ApplicationDbContext();
            var post = db.Posts.Find(id);
            post.Status = "1";
            db.SaveChanges();
            TempData["Message"] = "Пост был успешно одобрен";
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult RejectPost(string id)
        {
            db = new ApplicationDbContext();
            var post = db.Posts.Find(id);
            if (post != null)
            {

                db.ImagesGallery.RemoveRange(db.ImagesGallery.Where(i => i.PostId == post.Id).ToList());
                db.Posts.Remove(post);
                TempData["Message"] = "Пост был успешно отклонен";
            } else TempData["Message"] = "Что-то пошло не так";
            db.SaveChanges();            
            return RedirectToAction("Index");
        }
    }
}