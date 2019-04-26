using System;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using diplom.Models;
using System.Collections.Generic;
using System.IO;

namespace diplom.Controllers
{
    [Authorize(Roles = "User,Moderator")]
    public class ManageController : Controller
    {
        private ApplicationSignInManager _signInManager;
        private ApplicationUserManager _userManager;
        private ApplicationDbContext db;

        public ManageController()
        {
        }

        public ManageController(ApplicationUserManager userManager, ApplicationSignInManager signInManager)
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

        [HttpGet]
        public async Task<ActionResult> Index(ManageMessageId? message)
        {
            ViewBag.StatusMessage =
                message == ManageMessageId.ChangePasswordSuccess ? "Ваш пароль изменен."
                : message == ManageMessageId.SetPasswordSuccess ? "Пароль задан."
                : message == ManageMessageId.SetTwoFactorSuccess ? "Настроен поставщик двухфакторной проверки подлинности."
                : message == ManageMessageId.Error ? "Произошла ошибка."
                : message == ManageMessageId.AddPhoneSuccess ? "Ваш номер телефона добавлен."
                : message == ManageMessageId.RemovePhoneSuccess ? "Ваш номер телефона удален."
                : "";

            var userId = User.Identity.GetUserId();
            var model = new IndexViewModel
            {
                HasPassword = HasPassword(),
                PhoneNumber = await UserManager.GetPhoneNumberAsync(userId),
                TwoFactor = await UserManager.GetTwoFactorEnabledAsync(userId),
                Logins = await UserManager.GetLoginsAsync(userId),
                BrowserRemembered = await AuthenticationManager.TwoFactorBrowserRememberedAsync(userId)
            };
            return View(model);
        }

        [HttpGet]
        public ActionResult CreatePost()
        {
            Tuple<IList<Category>, IList<Region>> tuple = HomeController.GetDataFromCatReg();
            ViewBag.Categories = tuple.Item1;
            ViewBag.Regions = tuple.Item2;
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> CreatePost(RegisterPostViewModel model, IEnumerable<HttpPostedFileBase> images, HttpPostedFileBase video)
        {
            if (ModelState.IsValid && !(images.All(i => Equals(i, null))))
            {
                db = new ApplicationDbContext();
                var user = await UserManager.FindByIdAsync(User.Identity.GetUserId());
                string postId = Guid.NewGuid().ToString();
                var post = new Post
                {
                    Id = postId,
                    Name = model.Name,
                    Description = model.Description,
                    City = db.Cities.First(i => i.Name == model.City),
                    DateCreatePost = DateTime.Now.ToString(),
                    ImagesGallery = AddImagesInDb(images, user.Id),
                    Video = AddVideoInDb(video),
                    Subcategory = db.Subcategories.First(i => i.Name == model.Subcategory),
                    User = db.Users.Find(user.Id),
                    Status = "0"
                };
                db.Posts.Add(post);
                await db.SaveChangesAsync();
                return RedirectToAction("Posts");
            }
            else
            {
                Tuple<IList<Category>, IList<Region>> tuple = HomeController.GetDataFromCatReg();
                ViewBag.Categories = tuple.Item1;
                ViewBag.Regions = tuple.Item2;
                return View();
            }
        }

        private List<ImagesGallery> AddImagesInDb(IEnumerable<HttpPostedFileBase> images, string userId)
        {
            List<ImagesGallery> imagesGallery = new List<ImagesGallery>();
            foreach (var image in images)
            {
                if (image != null)
                {
                    var id = Guid.NewGuid().ToString();
                    var uploadFilesDir = System.Web.HttpContext.Current.Server.MapPath("~/Images/" + userId + "/");
                    if (!Directory.Exists(uploadFilesDir))
                    {
                        Directory.CreateDirectory(uploadFilesDir);
                    }
                    var extension = Path.GetExtension(image.FileName);
                    var fileSavePath = Path.Combine(uploadFilesDir, id.ToString() + extension);
                    image.SaveAs(fileSavePath);
                    var name = Path.GetFileName(image.FileName);
                    imagesGallery.Add(new ImagesGallery() { Id = id, Title = id.ToString(), Name = name });
                }
            }
            return imagesGallery;
        }

        private Video AddVideoInDb(HttpPostedFileBase videoData)
        {
            Video video = null;
            if (videoData != null)
            {
                var id = Guid.NewGuid().ToString();
                var uploadFilesDir = System.Web.HttpContext.Current.Server.MapPath("~/Videos");
                if (!Directory.Exists(uploadFilesDir))
                {
                    Directory.CreateDirectory(uploadFilesDir);
                }
                var extension = Path.GetExtension(videoData.FileName);
                var fileSavePath = Path.Combine(uploadFilesDir, id.ToString() + extension);
                videoData.SaveAs(fileSavePath);
                var name = Path.GetFileName(videoData.FileName);
                video = new Video() { Id = id, Title = id.ToString(), Name = name };
            }
            return video;
        }

        [HttpGet]
        public ActionResult GetSubcategories(string Id)
        {
            ViewBag.Subcategories = HomeController.GetDataFromSubCit().Item1.Where(i => i.CategoryName == Id).ToList();
            return PartialView();
        }

        [HttpGet]
        public ActionResult GetCities(string Id)
        {
            ViewBag.Cities = HomeController.GetDataFromSubCit().Item2.Where(i => i.RegionName == Id).ToList();
            return PartialView();
        }


        [HttpGet]
        public ActionResult Profile()
        {
            db = new ApplicationDbContext();
            var user = db.Users.Find(User.Identity.GetUserId());
            ViewBag.User = user;
            ViewBag.HistoryOperations = db.Operations.Where(i => i.PointId == user.Points.Id).ToList();
            return View();
        }

        [HttpGet]
        public string GetBonus()
        {
            var userId = User.Identity.GetUserId();
            db = new ApplicationDbContext();
            string points = db.Points.Find(userId).Points.ToString();
            return points;
        }

        [HttpGet]
        public ActionResult ChangeProfile()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult ChangeProfile(ChangeLoginOrPhoneViewModel model)
        {
            db = new ApplicationDbContext();
            if (ModelState.IsValid)
            {
                var userCurrent = UserManager.FindById(User.Identity.GetUserId());
                if (userCurrent.UserName == model.Name && userCurrent.PhoneNumber == model.PhoneNumber)
                    return PartialView(model);
                else if (userCurrent.UserName != model.Name)
                {
                    var userTemp = UserManager.FindByName(model.Name);
                    if (userTemp == null)
                    {
                        userCurrent.UserName = model.Name;
                        userCurrent.PhoneNumber = model.PhoneNumber;
                        IdentityResult result = UserManager.Update(userCurrent);
                        if (result.Succeeded)
                        {
                            ViewBag.Message = "Данные успешно сохранены";
                            return PartialView(model);
                        }
                    }
                    else
                    {
                        ViewBag.MessageError = "Такой логин уже существует";
                        return PartialView(model);
                    }
                }
                else if (userCurrent.UserName == model.Name && userCurrent.PhoneNumber != model.PhoneNumber)
                {
                    userCurrent.PhoneNumber = model.PhoneNumber;
                    IdentityResult result = UserManager.Update(userCurrent);
                    if (result.Succeeded)
                    {
                        ViewBag.Message = "Номер телефона успешно изменен";
                        return PartialView(model);
                    }
                }
            }
            else return PartialView(model);
            return PartialView(model);
        }

        public ActionResult ChangePassword()
        {
            return PartialView();
        }

        [HttpPost]
        public async Task<ActionResult> ChangePassword(ChangePasswordViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return PartialView(model);
            }
            var result = await UserManager.ChangePasswordAsync(User.Identity.GetUserId(), model.OldPassword, model.NewPassword);
            if (result.Succeeded)
            {
                var user = await UserManager.FindByIdAsync(User.Identity.GetUserId());
                if (user != null)
                {
                    await SignInManager.SignInAsync(user, isPersistent: false, rememberBrowser: false);
                }
                ViewBag.Message = "Пароль успешно изменен";
                return PartialView(model);
            }
            ViewBag.Message = "Что-то пошло не так";
            return PartialView(model);
        }

        [HttpGet]
        public ActionResult Posts()
        {
            ViewBag.Message = TempData["Message"];
            db = new ApplicationDbContext();
            string userId = User.Identity.GetUserId();
            ViewBag.Posts = db.Posts.Where(i => i.UserId == userId).ToList();
            return View();
        }

        [HttpGet]
        public ActionResult Post(string Id)
        {
            db = new ApplicationDbContext();
            var post = db.Posts.Find(Id);
            if (post != null)
                return View(post);
            else return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult ChangePost(string postId)
        {
            //Tuple<IList<Category>, IList<Region>> tuple = HomeController.GetDataFromCatReg();
            //ViewBag.Categories = tuple.Item1;
            //ViewBag.Regions = tuple.Item2;
            db = new ApplicationDbContext();
            var post = db.Posts.Find(postId);
            if (post != null)
                return View(post);
            else return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult ChangePost(Post model, HttpPostedFileBase video)//IEnumerable<HttpPostedFileBase> images)
        {
            db = new ApplicationDbContext();
            var user = db.Users.Find(User.Identity.GetUserId());
            var post = db.Posts.FirstOrDefault(i => i.Id == model.Id);
            //if (!(images.All(i => Equals(i, null))))
            //{
            //db = new ApplicationDbContext();
            //var user = db.Users.Find(User.Identity.GetUserId());
            //var post = db.Posts.FirstOrDefault(i => i.Id == model.Id);
            //if (post != null)
            //{
            if (model.Description.Count() >= 5)
            {
                post.Name = model.Name;
                post.Description = model.Description;
                //post.City = db.Cities.First(i => i.Name == model.City.Name);
                //post.DateCreatePost = DateTime.Now.ToString();
                //post.ImagesGallery = AddImagesInDb(images, user.Id);
                if (video != null)
                {
                    post.Video = AddVideoInDb(video);
                }
                post.Status = "0";
                db.Orders.RemoveRange(db.Orders.Where(i => i.PostId == post.Id).ToList());
                //post.Subcategory = db.Subcategories.First(i => i.Name == model.Subcategory),
                db.SaveChanges();
                ViewBag.Message = "Пост успешно изменен";
                return View(post);
            }
            ViewBag.Error = "Описание должно иметь не менее 5 символов";
            return View(post);
            //}
            //ViewBag.Error = "Что-то пошло не так";
            //return View(post);
            //}
            //else
            //{
            //    ViewBag.Error = "Добавьте хотя бы одну фотографию";
            //    return View(post);
            //}
        }

        [HttpPost]
        public ActionResult DeletePost(string postId)
        {
            db = new ApplicationDbContext();
            var post = db.Posts.Find(postId);
            if (post != null)
            {
                db.ImagesGallery.RemoveRange(db.ImagesGallery.Where(i => i.PostId == post.Id).ToList());
                db.Orders.RemoveRange(db.Orders.Where(i => i.PostId == post.Id).ToList());
                db.Posts.Remove(post);
                db.SaveChanges();
                TempData["Message"] = "Пост был успешно удален";
            }
            else TempData["Message"] = "Что-то пошло не так";

            return RedirectToAction("Posts");
        }

        [HttpGet]
        public ActionResult RequestPost()
        {
            ViewBag.Message = TempData["Message"];
            db = new ApplicationDbContext();
            string userId = User.Identity.GetUserId();
            ViewBag.Posts = db.Orders.Where(i => i.UserId == userId).ToList();
            return View();
        }

        [HttpPost]
        public ActionResult RequestPost(string postId)
        {
            db = new ApplicationDbContext();
            var userId = User.Identity.GetUserId();
            var post = db.Posts.Find(postId);

            if (post != null)
            {
                if (post.UserId != userId)
                {
                    var orders = db.Orders.Where(i => i.PostId == postId).ToList().Where(i => i.UserId == userId).ToList(); //all orders from this postid and userid
                    if (orders.Count == 0)
                    {
                        var order = new Order
                        {
                            Id = Guid.NewGuid().ToString(),
                            PostId = postId,
                            UserId = userId
                        };
                        db.Orders.Add(order);
                        db.SaveChanges();
                        TempData["Message"] = "Пост был успешно добавлен в запросы";
                    }
                    else TempData["Message"] = "Вы не можете запросить повторно один и тот же пост";
                }
                else TempData["Message"] = "Вы не можете запросить свой же пост";
            }
            else TempData["Message"] = "Что-то пошло не так";
            return RedirectToAction("RequestPost");
        }

        [HttpGet]
        public ActionResult ResponsePost()
        {
            ViewBag.Message = TempData["Message"];
            db = new ApplicationDbContext();
            string userId = User.Identity.GetUserId();
            ViewBag.Posts = db.Orders.Where(i => i.Post.UserId == userId).ToList();
            return View();
        }

        [HttpGet]
        public ActionResult PostInformation(string id)
        {
            //ViewBag.Message = TempData["Message"];
            db = new ApplicationDbContext();
            //string userId = User.Identity.GetUserId();
            //ViewBag.Posts = db.Posts.Find(id);
            return View(db.Posts.Find(id));
        }

        [HttpPost]
        public ActionResult ResolveRequest(string id)
        {
            //ViewBag.Message = TempData["Message"];

            db = new ApplicationDbContext();
            string userId = User.Identity.GetUserId();
            var order = db.Orders.Find(id);
            if (order != null)
            {
                var currentUser = db.Users.Find(userId);
                var requestUser = db.Users.Find(order.UserId);
                int points = order.Post.Subcategory.Points;
                if (requestUser != null)
                {
                    if (requestUser.Points.Points >= points)
                    {
                        requestUser.Points.Points -= points;
                        requestUser.Points.Operations.Add(CreateOperation(true, points, requestUser.Points.Id));
                        currentUser.Points.Points += points;
                        currentUser.Points.Operations.Add(CreateOperation(false, points, requestUser.Points.Id));
                        db.Orders.RemoveRange(db.Orders.ToList().Where(i => i.PostId == order.PostId).ToList());
                        db.SaveChanges();
                        TempData["Message"] = "Операция произведена успешно";
                    }
                    else TempData["Message"] = "Вы не можете совершить обмен с данным пользователем";
                }
                else TempData["Message"] = "Такого пользователя не существует";
            }
            else TempData["Message"] = "Такого запроса не существует";
            return RedirectToAction("ResponsePost");


            //ViewBag.Posts = db.Posts.Find(id);
            //return View(db.Posts.Find(id));
        }

        [HttpPost]
        public ActionResult RejectRequest(string id)
        {
            //ViewBag.Message = TempData["Message"];

            db = new ApplicationDbContext();
            string userId = User.Identity.GetUserId();
            var order = db.Orders.Find(id);
            if (order != null)
            {
                db.Orders.Remove(order);
                db.SaveChanges();
                TempData["Message"] = "Операция произведена успешно";
            }

            else TempData["Message"] = "Такого запроса не существует";
            return RedirectToAction("ResponsePost");


            //ViewBag.Posts = db.Posts.Find(id);
            //return View(db.Posts.Find(id));
        }

        private Operation CreateOperation(bool SpentOrEarned, int valueOfBonus, string pointId)
        {
            if (SpentOrEarned)
            {
                return new Operation
                {
                    Id = Guid.NewGuid().ToString(),
                    Date = HomeController.GetTime(),
                    Spent = valueOfBonus,
                    PointId = pointId
                };
            }
            else
            {
                return new Operation
                {
                    Id = Guid.NewGuid().ToString(),
                    Date = HomeController.GetTime(),
                    Earned = valueOfBonus,
                    PointId = pointId
                };

            }

        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && _userManager != null)
            {
                _userManager.Dispose();
                _userManager = null;
            }
            if (db != null)
            {
                db.Dispose();
                db = null;
            }

            base.Dispose(disposing);
        }

        #region Вспомогательные приложения
        // Используется для защиты от XSRF-атак при добавлении внешних имен входа
        private const string XsrfKey = "XsrfId";

        private IAuthenticationManager AuthenticationManager
        {
            get
            {
                return HttpContext.GetOwinContext().Authentication;
            }
        }

        private void AddErrors(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error);
            }
        }

        private bool HasPassword()
        {
            var user = UserManager.FindById(User.Identity.GetUserId());
            if (user != null)
            {
                return user.PasswordHash != null;
            }
            return false;
        }

        private bool HasPhoneNumber()
        {
            var user = UserManager.FindById(User.Identity.GetUserId());
            if (user != null)
            {
                return user.PhoneNumber != null;
            }
            return false;
        }

        public enum ManageMessageId
        {
            AddPhoneSuccess,
            ChangePasswordSuccess,
            SetTwoFactorSuccess,
            SetPasswordSuccess,
            RemoveLoginSuccess,
            RemovePhoneSuccess,
            Error
        }

        #endregion
    }
}