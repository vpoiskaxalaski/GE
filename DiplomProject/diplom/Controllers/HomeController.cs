using diplom.Models;
using PagedList;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Web;
using System.Web.Mvc;

namespace diplom.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db;

        [HttpGet]
        public ActionResult Index(int? page)
        {
            Tuple<IList<Category>, IList<Region>> tuple = GetDataFromCatReg();
            ViewBag.Categories = tuple.Item1;
            ViewBag.Regions = tuple.Item2;
            db = new ApplicationDbContext();
            int pageSize = 10;
            int pageNumber = (page ?? 1);
            return View(db.Posts.Where(i => i.Status != "0").ToList().ToPagedList(pageNumber, pageSize));
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
        public ActionResult Sorting(int? page, string attCat, string attReg, string Id, string q)
        {
            db = new ApplicationDbContext();
            int pageSize = 10;
            int pageNumber = (page ?? 1);
            ViewBag.attCat = String.IsNullOrEmpty(attCat) ? "none" : attCat;
            ViewBag.attReg = String.IsNullOrEmpty(attReg) ? "none" : attReg;
            ViewBag.q = String.IsNullOrEmpty(attReg) ? "none" : q;
            if (string.IsNullOrEmpty(q))
            {
                if (attCat == "none" && attReg == "none" && Id == null) return RedirectToAction("Index");
                if (attCat != "none" && attReg == "none" && Id == null)
                {
                    if (attCat != "all") return View(db.Posts.Where(i => i.Subcategory.CategoryName == attCat && i.Status != "0").ToList().ToPagedList(pageNumber, pageSize));
                    else return RedirectToAction("Index");
                }
                if (attCat == "none" && attReg != "none" && Id == null)
                {
                    if (attReg != "all") return View(db.Posts.Where(i => i.City.RegionName == attReg && i.Status != "0").ToList().ToPagedList(pageNumber, pageSize));
                    else return RedirectToAction("Index");
                }
                if (attCat != "none" && attReg != "none" && Id == null)
                {
                    if (attCat != "all" && attReg != "all") return View(db.Posts.Where(i => i.City.RegionName == attReg && i.Status != "0").Where(i => i.Subcategory.CategoryName == attCat && i.Status != "0").ToList().ToPagedList(pageNumber, pageSize));
                    if (attCat == "all" && attReg == "all") return RedirectToAction("Index");
                    if (attCat == "all" && attReg != "all") return View(db.Posts.Where(i => i.City.RegionName == attReg && i.Status != "0").ToList().ToPagedList(pageNumber, pageSize));
                    if (attCat != "all" && attReg == "all") return View(db.Posts.Where(i => i.Subcategory.CategoryName == attCat && i.Status != "0").ToList().ToPagedList(pageNumber, pageSize));
                }
                if (attCat == null && attReg == null && Id != null && Id != "")
                {
                    List<Post> posts = new List<Post>();
                    posts = db.Posts.Where(i => i.Subcategory.Name == Id && i.Status != "0").ToList();
                    if (posts.Count != 0)
                        return View(posts.ToPagedList(pageNumber, pageSize));
                    else return View(db.Posts.Where(i => i.City.Name == Id && i.Status != "0").ToList().ToPagedList(pageNumber, pageSize));
                }
            }
            else
            {
                var posts = db.Posts.Where(x => x.Name.Contains(q) == true && x.Status != "0").ToList();
                if (attCat == "none" && attReg == "none" && Id == null) return RedirectToAction("Index");
                if (attCat != "none" && attReg == "none" && Id == null)
                {
                    if (attCat != "all") return View(posts.Where(i => i.Subcategory.CategoryName == attCat).ToList().ToPagedList(pageNumber, pageSize));
                    else return RedirectToAction("Index");
                }
                if (attCat == "none" && attReg != "none" && Id == null)
                {
                    if (attReg != "all") return View(posts.Where(i => i.City.RegionName == attReg).ToList().ToPagedList(pageNumber, pageSize));
                    else return RedirectToAction("Index");
                }
                if (attCat != "none" && attReg != "none" && Id == null)
                {
                    if (attCat != "all" && attReg != "all") return View(posts.Where(i => i.City.RegionName == attReg).Where(i => i.Subcategory.CategoryName == attCat).ToList().ToPagedList(pageNumber, pageSize));
                    if (attCat == "all" && attReg == "all") return RedirectToAction("Index");
                    if (attCat == "all" && attReg != "all") return View(posts.Where(i => i.City.RegionName == attReg).ToList().ToPagedList(pageNumber, pageSize));
                    if (attCat != "all" && attReg == "all") return View(posts.Where(i => i.Subcategory.CategoryName == attCat).ToList().ToPagedList(pageNumber, pageSize));
                }
                if (attCat == null && attReg == null && Id != null && Id != "")
                {
                    List<Post> tempPosts = new List<Post>();
                    tempPosts =posts.Where(i => i.Subcategory.Name == Id).ToList();
                    if (tempPosts.Count != 0)
                        return View(tempPosts.ToPagedList(pageNumber, pageSize));
                    else return View(posts.Where(i => i.City.Name == Id).ToList().ToPagedList(pageNumber, pageSize));
                }
            }
            ViewBag.Posts = "sorry";
            return View();
        }

        [HttpGet]
        public ActionResult Search(int? page, string q)
        {
            if (q != "" && q != null)
            {
                Tuple<IList<Category>, IList<Region>> tuple = GetDataFromCatReg();
                ViewBag.Categories = tuple.Item1;
                ViewBag.Regions = tuple.Item2;
                db = new ApplicationDbContext();
                int pageSize = 10;
                int pageNumber = (page ?? 1);
                ViewBag.Q = q;
                return View(db.Posts.Where(x => x.Name.Contains(q) == true && x.Status != "0").ToList().ToPagedList(pageNumber, pageSize));
            }
            else return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult GetSubcategories(string Id)
        {
            ViewBag.Subcategories = GetDataFromSubCit().Item1.Where(i => i.CategoryName == Id).ToList();
            return PartialView();
        }

        [HttpGet]
        public ActionResult GetCities(string Id)
        {
            ViewBag.Cities = GetDataFromSubCit().Item2.Where(i => i.RegionName == Id).ToList();
            return PartialView();
        }

        public static Tuple<IList<Category>, IList<Region>> GetDataFromCatReg()
        {
            IList<Category> categories = System.Runtime.Caching.MemoryCache.Default["Categories"] as IList<Category>;
            IList<Region> regions = System.Runtime.Caching.MemoryCache.Default["Regions"] as IList<Region>;
            if (categories == null || regions == null) //not in cache
            {
                using (ApplicationDbContext db = new ApplicationDbContext())
                {
                    categories = db.Categories.ToList();
                    regions = db.Regions.ToList();
                    System.Runtime.Caching.MemoryCache.Default["Categories"] = categories;
                    System.Runtime.Caching.MemoryCache.Default["Regions"] = regions;
                }
            }
            return Tuple.Create(categories, regions);
        }

        public static Tuple<IList<Subcategory>, IList<City>> GetDataFromSubCit()
        {
            IList<Subcategory> subcategories = System.Runtime.Caching.MemoryCache.Default["Subcategories"] as IList<Subcategory>;
            IList<City> cities = System.Runtime.Caching.MemoryCache.Default["Cities"] as IList<City>;
            if (subcategories == null || cities == null) //not in cache
            {
                using (ApplicationDbContext db = new ApplicationDbContext())
                {
                    subcategories = db.Subcategories.ToList();
                    cities = db.Cities.ToList();
                    System.Runtime.Caching.MemoryCache.Default["Subcategories"] = subcategories;
                    System.Runtime.Caching.MemoryCache.Default["Cities"] = cities;
                }
            }
            return Tuple.Create(subcategories, cities);
        }

        public static string GetTime()
        {
            var client = new TcpClient("time.nist.gov", 13);
            string localDateTime = "";
            using (var streamReader = new StreamReader(client.GetStream()))
            {
                var response = streamReader.ReadToEnd();
                var utcDateTimeString = response.Substring(7, 17);
                localDateTime = DateTime.ParseExact(utcDateTimeString, "yy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal).ToString();
            }
            return localDateTime;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (db != null)
                {
                    db.Dispose();
                    db = null;
                }
            }
            base.Dispose(disposing);
        }
    }
}