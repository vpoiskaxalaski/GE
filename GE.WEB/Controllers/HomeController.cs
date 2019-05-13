using GE.Models;
using GE.SL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Sockets;

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

        [HttpGet]
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
                List<PostVM> posts = _postsService.GetAll().Where(x =>
                {
                    string n = x.Name.ToUpper(), s = q.ToUpper();
                    return n.Contains(s);
                }).ToList();
                if (posts.Count() == 0)
                {
                    ViewBag.Posts = null;
                }
                else
                {
                    ViewBag.Posts = posts;
                }
                ViewBag.Q = q;

                return View();
            }
            else
            {
                return RedirectToAction("Index");
            }
        }


        [Route("/{id}")]
        [HttpGet]
        public ActionResult Search(int id)
        {
            List<PostVM> posts = _postsService.GetAll().Where(x => x.SubcategoryId == id).ToList();
            if (posts.Count() == 0)
            {
                ViewBag.Posts = null;

                return View();
            }

            ViewBag.Posts = posts;

            return View();
        }

        public static string GetTime()
        {
            TcpClient client = new TcpClient("time.nist.gov", 13);
            string localDateTime = "";
            using (StreamReader streamReader = new StreamReader(client.GetStream()))
            {
                string response = streamReader.ReadToEnd();
                string utcDateTimeString = response.Substring(7, 17);
                localDateTime = DateTime.ParseExact(utcDateTimeString, "yy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal).ToString();
            }

            return localDateTime;
        }
    }
}
