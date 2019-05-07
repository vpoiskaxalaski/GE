using GE.Models;
using GE.SL.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GE.WEB.Controllers
{
    [Authorize(Roles = "User,Moderator")]
    public class ManageController : Controller
    {
        private readonly IAccountService _accountService;
        private readonly IPostService _postService;

        public ManageController(IAccountService accountService, IPostService postService)
        {
            _accountService = accountService;
            _postService = postService;
        }

        //public ManageController(ApplicationUserManager userManager, ApplicationSignInManager signInManager)
        //{
        //    UserManager = userManager;
        //    SignInManager = signInManager;
        //}

        [HttpGet]
        public async Task<ActionResult> Index()
        {
            //ViewBag.StatusMessage = message == ManageMessageId.Error ? "Произошла ошибка." : "";

            //var userId = User.Identity.GetUserId();
            //var model = new IndexViewModel
            //{
            //    HasPassword = HasPassword(),
            //    PhoneNumber = await UserManager.GetPhoneNumberAsync(userId),
            //    TwoFactor = await UserManager.GetTwoFactorEnabledAsync(userId),
            //    Logins = await UserManager.GetLoginsAsync(userId),
            //    BrowserRemembered = await AuthenticationManager.TwoFactorBrowserRememberedAsync(userId)
            //};
            return View();
        }

        [HttpGet]
        public ActionResult CreatePost()
        {
            GetCacheData();
            return View();
        }

        [HttpPost]
        public IActionResult CreatePost(RegisterPostViewModel model, IEnumerable<IFormFile> images, IFormFile video)
        {
            if (ModelState.IsValid && !(images.All(i => Equals(i, null))))
            {
                var user = _accountService.GetByUserName(User.Identity.Name);
                _postService.CreatePost(model, images, video, user);
                return RedirectToAction("Posts");
            }
            else
            {
                GetCacheData();
                return View();
            }
        }

        private void GetCacheData()
        {
            ViewBag.Categories = System.Runtime.Caching.MemoryCache.Default["Categories"] as IList<CategoryVM>;
            ViewBag.Regions = System.Runtime.Caching.MemoryCache.Default["Regions"] as IList<RegionVM>;
        }

        [HttpGet]
        public ActionResult GetSubcategories(string Id)
        {
            IList<CategoryVM> categoryVM = System.Runtime.Caching.MemoryCache.Default["Categories"] as IList<CategoryVM>;
            IList<SubcategoryVM> subcategoryVMs = new List<SubcategoryVM>();
            categoryVM.ToList().ForEach(i => i.Subcategories.ToList().ForEach(y => { if (y.CategoryName == Id) { subcategoryVMs.Add(y); } }));
            ViewBag.Subcategories = subcategoryVMs.ToList();
            return PartialView();
        }

        [HttpGet]
        public ActionResult GetCities(string Id)
        {
            IList<RegionVM> regionVM = System.Runtime.Caching.MemoryCache.Default["Regions"] as IList<RegionVM>;
            IList<CityVM> cityVM = new List<CityVM>();
            regionVM.ToList().ForEach(i => i.Cities.ToList().ForEach(y => { if (y.RegionName == Id) { cityVM.Add(y); } }));
            ViewBag.Cities = cityVM;
            return PartialView();
        }


        //[HttpGet]
        //public ActionResult Profile()
        //{
        //    db = new ApplicationDbContext();
        //    var user = db.Users.Find(User.Identity.GetUserId());
        //    ViewBag.User = user;
        //    ViewBag.HistoryOperations = db.Operations.Where(i => i.PointId == user.Points.Id).ToList();
        //    return View();
        //}

        //[HttpGet]
        //public string GetBonus()
        //{
        //    var userId = User.Identity.GetUserId();
        //    db = new ApplicationDbContext();
        //    string points = db.Points.Find(userId).Points.ToString();
        //    return points;
        //}

        //[HttpGet]
        //public ActionResult ChangeProfile()
        //{
        //    return PartialView();
        //}


        //[HttpGet]
        //public ActionResult Posts()
        //{
        //    ViewBag.Message = TempData["Message"];
        //    db = new ApplicationDbContext();
        //    string userId = User.Identity.GetUserId();
        //    ViewBag.Posts = db.Posts.Where(i => i.UserId == userId).ToList();
        //    return View();
        //}

        //[HttpGet]
        //public ActionResult Post(string Id)
        //{
        //    db = new ApplicationDbContext();
        //    var post = db.Posts.Find(Id);
        //    if (post != null)
        //        return View(post);
        //    else return RedirectToAction("Index");
        //}

        //[HttpGet]
        //public ActionResult ChangePost(string postId)
        //{
        //    //Tuple<IList<Category>, IList<Region>> tuple = HomeController.GetDataFromCatReg();
        //    //ViewBag.Categories = tuple.Item1;
        //    //ViewBag.Regions = tuple.Item2;
        //    db = new ApplicationDbContext();
        //    var post = db.Posts.Find(postId);
        //    if (post != null)
        //        return View(post);
        //    else return RedirectToAction("Index");
        //}

        //[HttpPost]
        //public ActionResult ChangePost(Post model, HttpPostedFileBase video)//IEnumerable<HttpPostedFileBase> images)
        //{
        //    db = new ApplicationDbContext();
        //    var user = db.Users.Find(User.Identity.GetUserId());
        //    var post = db.Posts.FirstOrDefault(i => i.Id == model.Id);
        //    //if (!(images.All(i => Equals(i, null))))
        //    //{
        //    //db = new ApplicationDbContext();
        //    //var user = db.Users.Find(User.Identity.GetUserId());
        //    //var post = db.Posts.FirstOrDefault(i => i.Id == model.Id);
        //    //if (post != null)
        //    //{
        //    if (model.Description.Count() >= 5)
        //    {
        //        post.Name = model.Name;
        //        post.Description = model.Description;
        //        //post.City = db.Cities.First(i => i.Name == model.City.Name);
        //        //post.DateCreatePost = DateTime.Now.ToString();
        //        //post.ImagesGallery = AddImagesInDb(images, user.Id);
        //        if (video != null)
        //        {
        //            post.Video = AddVideoInDb(video);
        //        }
        //        post.Status = "0";
        //        db.Orders.RemoveRange(db.Orders.Where(i => i.PostId == post.Id).ToList());
        //        //post.Subcategory = db.Subcategories.First(i => i.Name == model.Subcategory),
        //        db.SaveChanges();
        //        ViewBag.Message = "Пост успешно изменен";
        //        return View(post);
        //    }
        //    ViewBag.Error = "Описание должно иметь не менее 5 символов";
        //    return View(post);
        //    //}
        //    //ViewBag.Error = "Что-то пошло не так";
        //    //return View(post);
        //    //}
        //    //else
        //    //{
        //    //    ViewBag.Error = "Добавьте хотя бы одну фотографию";
        //    //    return View(post);
        //    //}
        //}

        //[HttpPost]
        //public ActionResult DeletePost(string postId)
        //{
        //    db = new ApplicationDbContext();
        //    var post = db.Posts.Find(postId);
        //    if (post != null)
        //    {
        //        db.ImagesGallery.RemoveRange(db.ImagesGallery.Where(i => i.PostId == post.Id).ToList());
        //        db.Orders.RemoveRange(db.Orders.Where(i => i.PostId == post.Id).ToList());
        //        db.Posts.Remove(post);
        //        db.SaveChanges();
        //        TempData["Message"] = "Пост был успешно удален";
        //    }
        //    else TempData["Message"] = "Что-то пошло не так";

        //    return RedirectToAction("Posts");
        //}

        //[HttpGet]
        //public ActionResult RequestPost()
        //{
        //    ViewBag.Message = TempData["Message"];
        //    db = new ApplicationDbContext();
        //    string userId = User.Identity.GetUserId();
        //    ViewBag.Posts = db.Orders.Where(i => i.UserId == userId).ToList();
        //    return View();
        //}

        //[HttpPost]
        //public ActionResult RequestPost(string postId)
        //{
        //    db = new ApplicationDbContext();
        //    var userId = User.Identity.GetUserId();
        //    var post = db.Posts.Find(postId);

        //    if (post != null)
        //    {
        //        if (post.UserId != userId)
        //        {
        //            var orders = db.Orders.Where(i => i.PostId == postId).ToList().Where(i => i.UserId == userId).ToList(); //all orders from this postid and userid
        //            if (orders.Count == 0)
        //            {
        //                var order = new Order
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                    PostId = postId,
        //                    UserId = userId
        //                };
        //                db.Orders.Add(order);
        //                db.SaveChanges();
        //                TempData["Message"] = "Пост был успешно добавлен в запросы";
        //            }
        //            else TempData["Message"] = "Вы не можете запросить повторно один и тот же пост";
        //        }
        //        else TempData["Message"] = "Вы не можете запросить свой же пост";
        //    }
        //    else TempData["Message"] = "Что-то пошло не так";
        //    return RedirectToAction("RequestPost");
        //}

        //[HttpGet]
        //public ActionResult ResponsePost()
        //{
        //    ViewBag.Message = TempData["Message"];
        //    db = new ApplicationDbContext();
        //    string userId = User.Identity.GetUserId();
        //    ViewBag.Posts = db.Orders.Where(i => i.Post.UserId == userId).ToList();
        //    return View();
        //}

        //[HttpGet]
        //public ActionResult PostInformation(string id)
        //{
        //    //ViewBag.Message = TempData["Message"];
        //    db = new ApplicationDbContext();
        //    //string userId = User.Identity.GetUserId();
        //    //ViewBag.Posts = db.Posts.Find(id);
        //    return View(db.Posts.Find(id));
        //}

        //[HttpPost]
        //public ActionResult ResolveRequest(string id)
        //{
        //    //ViewBag.Message = TempData["Message"];

        //    db = new ApplicationDbContext();
        //    string userId = User.Identity.GetUserId();
        //    var order = db.Orders.Find(id);
        //    if (order != null)
        //    {
        //        var currentUser = db.Users.Find(userId);
        //        var requestUser = db.Users.Find(order.UserId);
        //        int points = order.Post.Subcategory.Points;
        //        if (requestUser != null)
        //        {
        //            if (requestUser.Points.Points >= points)
        //            {
        //                requestUser.Points.Points -= points;
        //                requestUser.Points.Operations.Add(CreateOperation(true, points, requestUser.Points.Id));
        //                currentUser.Points.Points += points;
        //                currentUser.Points.Operations.Add(CreateOperation(false, points, requestUser.Points.Id));
        //                db.Orders.RemoveRange(db.Orders.ToList().Where(i => i.PostId == order.PostId).ToList());
        //                db.SaveChanges();
        //                TempData["Message"] = "Операция произведена успешно";
        //            }
        //            else TempData["Message"] = "Вы не можете совершить обмен с данным пользователем";
        //        }
        //        else TempData["Message"] = "Такого пользователя не существует";
        //    }
        //    else TempData["Message"] = "Такого запроса не существует";
        //    return RedirectToAction("ResponsePost");


        //    //ViewBag.Posts = db.Posts.Find(id);
        //    //return View(db.Posts.Find(id));
        //}

        //[HttpPost]
        //public ActionResult RejectRequest(string id)
        //{
        //    //ViewBag.Message = TempData["Message"];

        //    db = new ApplicationDbContext();
        //    string userId = User.Identity.GetUserId();
        //    var order = db.Orders.Find(id);
        //    if (order != null)
        //    {
        //        db.Orders.Remove(order);
        //        db.SaveChanges();
        //        TempData["Message"] = "Операция произведена успешно";
        //    }

        //    else TempData["Message"] = "Такого запроса не существует";
        //    return RedirectToAction("ResponsePost");


        //    //ViewBag.Posts = db.Posts.Find(id);
        //    //return View(db.Posts.Find(id));
        //}

        //private Operation CreateOperation(bool SpentOrEarned, int valueOfBonus, string pointId)
        //{
        //    if (SpentOrEarned)
        //    {
        //        return new Operation
        //        {
        //            Id = Guid.NewGuid().ToString(),
        //            Date = HomeController.GetTime(),
        //            Spent = valueOfBonus,
        //            PointId = pointId
        //        };
        //    }
        //    else
        //    {
        //        return new Operation
        //        {
        //            Id = Guid.NewGuid().ToString(),
        //            Date = HomeController.GetTime(),
        //            Earned = valueOfBonus,
        //            PointId = pointId
        //        };

        //    }

        //}

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing && _userManager != null)
        //    {
        //        _userManager.Dispose();
        //        _userManager = null;
        //    }
        //    if (db != null)
        //    {
        //        db.Dispose();
        //        db = null;
        //    }

        //    base.Dispose(disposing);
        //}

        //#region Вспомогательные приложения
        //// Используется для защиты от XSRF-атак при добавлении внешних имен входа
        //private const string XsrfKey = "XsrfId";
        //private readonly ICategoryService _categoryService;

        //private IAuthenticationManager AuthenticationManager
        //{
        //    get
        //    {
        //        return HttpContext.GetOwinContext().Authentication;
        //    }
        //}

        //private void AddErrors(IdentityResult result)
        //{
        //    foreach (var error in result.Errors)
        //    {
        //        ModelState.AddModelError("", error);
        //    }
        //}

        //private bool HasPassword()
        //{
        //    var user = UserManager.FindById(User.Identity.GetUserId());
        //    if (user != null)
        //    {
        //        return user.PasswordHash != null;
        //    }
        //    return false;
        //}

        //private bool HasPhoneNumber()
        //{
        //    var user = UserManager.FindById(User.Identity.GetUserId());
        //    if (user != null)
        //    {
        //        return user.PhoneNumber != null;
        //    }
        //    return false;
        //}

        //public enum ManageMessageId
        //{
        //    AddPhoneSuccess,
        //    ChangePasswordSuccess,
        //    SetTwoFactorSuccess,
        //    SetPasswordSuccess,
        //    RemoveLoginSuccess,
        //    RemovePhoneSuccess,
        //    Error
        //}

        //#endregion
    }
}