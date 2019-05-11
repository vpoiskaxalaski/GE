using GE.Models;
using GE.SL.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace GE.WEB.Controllers
{
    [Authorize(Roles = "User,Moderator")]
    public class ManageController : Controller
    {
        private readonly IAccountService _accountService;
        private readonly IPostService _postService;
        private readonly IOrderService _orderService;
        private readonly IOperationService _operationService;
        private readonly IImageGalleryService _imageGalleryService;
        private readonly ICategoryService _categoryService;

        public ManageController(IAccountService accountService, 
            IPostService postService, 
            IOrderService orderService, 
            IOperationService operationService,
            IImageGalleryService imageGalleryService,
            ICategoryService categoryService)
        {
            _accountService = accountService;
            _postService = postService;
            _orderService = orderService;
            _operationService = operationService;
            _imageGalleryService = imageGalleryService;
            _categoryService = categoryService;
        }

        [HttpGet]
        public ActionResult CreatePost()
        {
            
            GetCacheData();
            if(ViewBag.Categories == null)
            {
                ViewBag.Categories = _categoryService.GetAll();
            }
            return View();
        }

        [HttpPost]
        public IActionResult CreatePost(RegisterPostViewModel model, IEnumerable<IFormFile> images)
        {
            if (ModelState.IsValid) //&& !(images.All(i => Equals(i, null))))
            {
                var user = _accountService.GetByUserName(User.Identity.Name);
                _postService.CreatePost(model, images, user);
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


        [HttpGet]
        public ActionResult Profile()
        {
            var user = _accountService.GetByUserName(User.Identity.Name);
            ViewBag.User = user;
            return View();
        }

        [HttpGet]
        public string GetBonus()
        {
            var user = _accountService.GetByUserName(User.Identity.Name);
            return user.Points.ToString();
        }


        [HttpGet]
        public IActionResult Posts()
        {
            ViewBag.Message = TempData["Message"];
            string userName = User.Identity.Name;
            GetCacheData();
            ViewBag.Posts = _postService.GetAll().Where(x => x.User.UserName == userName); 
            return View();
        }

        [HttpGet]
        public ActionResult Post(int Id)
        {
            ViewBag.User = _accountService.GetByUserName(User.Identity.Name);
            ViewBag.Post = _postService.GetAll().FirstOrDefault(i => i.Id == Id);

            return View();
        }

        [HttpGet]
        public IActionResult RequestPost()
        {
            ViewBag.Message = TempData["Message"];
            string userId = _accountService.GetByUserName(User.Identity.Name).Id;
            ViewBag.Orders = _orderService.GetAll().Where(x => x.UserId == userId).ToList();
            return View();
        }

        [HttpPost]
        public IActionResult RequestPost(int postId)
        {
            var user = _accountService.GetByUserName(User.Identity.Name);
            var post = _postService.GetAll().Find(x => x.Id == postId);

            if (post != null && user.Points>= post.Subcategory.Points)
            {
                var orders = _orderService.GetAll().Where(x => x.PostId == postId && x.UserId == user.Id);//db.Orders.Where(i => i.PostId == postId).ToList().Where(i => i.UserId == userId).ToList(); //all orders from this postid and userid
                if (orders.Count() == 0)
                {
                    _orderService.Create(new OrderVM
                    {
                        PostId = postId,
                        UserId = user.Id,
                        Post = _postService.GetAll().FirstOrDefault(x => x.Id == postId),
                        User = _accountService.GetById(user.Id)
                    });
                }
                else TempData["Message"] = "Вы не можете запросить повторно один и тот же пост";
            }
            TempData["Message"] = "У вас недостаточно бонусов";

            return RedirectToAction("RequestPost");
        }

        [HttpGet]
        public ActionResult ResponsePost()
        {
            ViewBag.Message = TempData["Message"];
            string userId = _accountService.GetByUserName(User.Identity.Name).Id;
            ViewBag.Orders = _orderService.GetAll().Where(x => x.Post.UserId == userId);
            return View();
        }

        [HttpGet]
        public ActionResult PostInformation(int id)
        {
            return View(_postService.GetAll().Find(x => x.Id == id));
        }

        [HttpPost]
        public ActionResult ResolveRequest(int id)//orderId
        {
            var user = _accountService.GetByUserName(User.Identity.Name);
            var order = _orderService.GetAll().Where(x => x.Id == id).FirstOrDefault();
            if (order != null)
            {
                var currentUser = user;
                var requestUser = _accountService.GetById(order.UserId);
                int points = order.Post.Subcategory.Points;
                if (requestUser != null)
                {
                    if (requestUser.Points >= points)
                    {
                        requestUser.Points -= points;
                        _accountService.UpdateUserPoints(requestUser);
                        _operationService.Create(CreateOperation(true, points, requestUser.Id));
                        currentUser.Points += points;
                        _accountService.UpdateUserPoints(currentUser);
                        _operationService.Create(CreateOperation(false, points, requestUser.Id));
                        _orderService.Delete(order.Id);
                        TempData["Message"] = "Операция произведена успешно";
                    }
                    else TempData["Message"] = "Вы не можете совершить обмен с данным пользователем";
                }
                else TempData["Message"] = "Такого пользователя не существует";
            }
            else TempData["Message"] = "Такого запроса не существует";

            return RedirectToAction("ResponsePost");
        }

        [HttpPost]
        public ActionResult RejectRequest(int id)//orderId
        {
            var user = _accountService.GetByUserName(User.Identity.Name);
            var order = _orderService.GetAll().Where(x => x.Id == id).FirstOrDefault();
            if (order != null)
            {
                _orderService.Delete(order.Id);
                TempData["Message"] = "Операция произведена успешно";
            }
            else TempData["Message"] = "Такого запроса не существует";

            return RedirectToAction("ResponsePost");
        }

        [HttpGet]
        public ActionResult ChangePost(int postId)
        {
            //Tuple<IList<Category>, IList<Region>> tuple = HomeController.GetDataFromCatReg();
            //ViewBag.Categories = tuple.Item1;
            //ViewBag.Regions = tuple.Item2;
            ViewBag.Post = _postService.FindById(postId);

            return View();
        }

        [HttpPost]
        public ActionResult ChangePost(PostVM model)
        {
            var user = _accountService.GetByUserName(User.Identity.Name);
            var post = _postService.FindById(model.Id);// db.Posts.FirstOrDefault(i => i.Id == model.Id);
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
                post.Status = "0";
                _postService.Update(post);
                _orderService.RemoveRange(_orderService.GetAll().Where(x=>x.PostId==model.Id).ToList());
                //_orderService.Delete(post.Id);
                //post.Subcategory = db.Subcategories.First(i => i.Name == model.Subcategory),
                ViewBag.Message = "Пост успешно изменен";
                ViewBag.Post = _postService.FindById(model.Id);
                return View();
            }
            ViewBag.Error = "Описание должно иметь не менее 5 символов";
            return View();
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
        public ActionResult DeletePost(int Id)
        {
            var post = _postService.GetAll().FirstOrDefault( x => x.Id == Id );// db.Posts.Find(postId);
            if (post != null)
            {
                //db.ImagesGallery.RemoveRange(db.ImagesGallery.Where(i => i.PostId == post.Id).ToList());

                //db.Orders.RemoveRange(db.Orders.Where(i => i.PostId == post.Id).ToList());
                _postService.Remove(Id);

                var images = _imageGalleryService.Find(Id).ToList();
                if (images.Count == 1)
                    _imageGalleryService.RemoveItem(images[0]);
                else
                    _imageGalleryService.RemoveRange(images);

                var orders = _orderService.GetAll().Where(x => x.PostId == Id).ToList();
                if (orders.Count > 0)
                    _orderService.RemoveRange(orders);

                TempData["Message"] = "Пост был успешно удален";
            }
            else TempData["Message"] = "Что-то пошло не так";

            return RedirectToAction("Posts");
        }

        private OperationVM CreateOperation(bool SpentOrEarned, int valueOfBonus, string userId)
        {
            if (SpentOrEarned)
            {
                return new OperationVM
                {
                    Date = HomeController.GetTime(),
                    Spent = valueOfBonus,
                    UserId = userId
                };
            }
            else
            {
                return new OperationVM
                {
                    Date = HomeController.GetTime(),
                    Earned = valueOfBonus,
                    UserId = userId
                };

            }

        }

        private void AddErrors(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error.ToString());
            }
        }
    }
}