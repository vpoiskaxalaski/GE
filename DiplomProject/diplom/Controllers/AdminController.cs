using PagedList;
using System;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using diplom.Models;
using System.Collections.Generic;
using Microsoft.AspNet.Identity.EntityFramework;

namespace diplom.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class AdminController : Controller
    {
        private ApplicationDbContext db;
        private ApplicationSignInManager _signInManager;
        private ApplicationUserManager _userManager;
        public AdminController()
        {
        }

        public AdminController(ApplicationUserManager userManager, ApplicationSignInManager signInManager)
        {
            UserManager = userManager;
            SignInManager = signInManager;
        }

        public ApplicationSignInManager SignInManager
        {
            get
            {
                return _signInManager ?? HttpContext.GetOwinContext().Get<ApplicationSignInManager>();
            }
            private set
            {
                _signInManager = value;
            }
        }

        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }
        public ActionResult Index(int? page)
        {          
            db = new ApplicationDbContext();           
            ViewBag.Message = TempData["Message"];
            var role = db.Roles.FirstOrDefault(i => i.Name == "User");
            int pageSize = 20;
            int pageNumber = (page ?? 1);
            return View(db.Users.Where(i => i.Roles.Any(r => r.RoleId == role.Id)).Where(i => i.UserName != "admin").ToList().ToPagedList(pageNumber, pageSize));
        }

        public ActionResult UserInformation(string id)
        {
            db = new ApplicationDbContext();
            return View(db.Users.Find(id));
        }

        [HttpPost]
        public ActionResult DeleteUser(string Id) //Возможны ошибки потом чекни
        {
            db = new ApplicationDbContext();
            var user = db.Users.Find(Id);
            if (user != null)
            {
                var listPosts = db.Posts.Where(i => i.UserId == user.Id).ToList();
                foreach (var post in listPosts)
                {
                    db.ImagesGallery.RemoveRange(post.ImagesGallery);
                }
                db.Orders.RemoveRange(db.Orders.Where(i => i.UserId == user.Id).ToList());
                db.Orders.RemoveRange(db.Orders.Where(i => i.Post.UserId == user.Id).ToList());
                db.Posts.RemoveRange(listPosts);
                db.Operations.RemoveRange(db.Operations.Where(i => i.PointId == user.Id).ToList());
                db.Points.Remove(db.Points.Find(user.Id));
                db.Users.Remove(user);
                db.SaveChanges();
                TempData["Message"] = "Пользователь был успешно удален";
            }
            else TempData["Message"] = "Что-то пошло не так";

            return RedirectToAction("Index");
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<ActionResult> CreateModerator(string login, string email)
        {
            if (login != "" && email != "")
            {
                string id = Guid.NewGuid().ToString();
                var user = new ApplicationUser
                {
                    Id = id,
                    UserName = login,
                    Email = email,
                    EmailConfirmed = true,
                    PhoneNumber = ""
                };
                var result = await UserManager.CreateAsync(user, "3904And`");
                if (result.Succeeded)
                {
                    await UserManager.AddToRoleAsync(id, "Moderator");
                    TempData["Message"] = "Пользователь был успешно добавлен";
                }
                foreach (var item in result.Errors)
                {
                    TempData["Message"] += item.ToString() + '\n'  ;
                }
            }
            else TempData["Message"] = "Логин не должен быть пустым";
            return RedirectToAction("Index");
        }
    }

    

}