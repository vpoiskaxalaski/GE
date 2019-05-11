using System;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Net.Sockets;
using System.IO;
using System.Globalization;
using GE.SL.Interfaces;
using GE.Models;
using System.Collections.Generic;

namespace GE.WEB.Controllers
{

    public class HomeController : Controller
    {
        private readonly IPostService _postsService;
        private readonly IAccountService _accountService;

        public HomeController(IPostService postService, IAccountService accountService)
        {
            _postsService = postService;
            _accountService = accountService;
        }

        public IActionResult Index()
        {
            ViewBag.posts = _postsService.GetAll().Where(x => x.Status == "1");

            return View();
        }

        [HttpGet]
        public IActionResult Post(int Id)
        {
            ViewBag.User = _accountService.GetByUserName(User.Identity.Name);
            ViewBag.Post = _postsService.GetAll().FirstOrDefault(i => i.Id == Id);

            return View();
        }

        [HttpGet]
        public ActionResult Search(int? page, string q)
        {
            if (q != "" && q != null)
            {
                var posts = _postsService.GetAll().Where(x => x.Name.Contains(q)).ToList();
                if (posts.Count() == 0)
                    ViewBag.Posts = null;
                else
                    ViewBag.Posts = posts;

                //ViewBag.Categories = System.Runtime.Caching.MemoryCache.Default["Categories"] as IList<CategoryVM>;
                //ViewBag.Regions = System.Runtime.Caching.MemoryCache.Default["Regions"] as IList<RegionVM>;
                //int pageSize = 10;
                //int pageNumber = (page ?? 1);
                ViewBag.Q = q;
                //return View(db.Posts.Where(x => x.Name.Contains(q) == true && x.Status != "0").ToList().ToPagedList(pageNumber, pageSize));
                return View();
            }
            else return RedirectToAction("Index");
        }

        //[HttpGet("{id}")]
        [Route("/{id}")]
        public ActionResult Search(int id)
        {
            var posts = _postsService.GetAll().Where(x => x.SubcategoryId == id).ToList();
            if (posts.Count() == 0)
            {
                ViewBag.Posts = null;
                return View();
            }                    

            ViewBag.Posts = posts;
            return View();
            //int pageSize = 10;
            //int pageNumber = (page ?? 1);
            //return View(db.Posts.Where(x => x.Name.Contains(q) == true && x.Status != "0").ToList().ToPagedList(pageNumber, pageSize));

        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
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
    }
}
