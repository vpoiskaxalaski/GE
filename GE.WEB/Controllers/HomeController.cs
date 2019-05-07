using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using System.Net.Sockets;
using System.IO;
using System.Globalization;
using Microsoft.AspNetCore.Authorization;
using GE.SL.Interfaces;
using GE.Models;
using AutoMapper;

namespace GE.WEB.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPostService _postsService;


        public HomeController(IPostService postService)
        {
            _postsService = postService;
            
        }

        public IActionResult Index()
        {         
            ViewBag.posts = _postsService.GetAll();

            return View();
        }

        [HttpGet]
        public IActionResult Post(string Id)
        {
          
            var post = _postsService.GetAll().FirstOrDefault(i => i.Id == int.Parse(Id));
            if (post != null)
                return View(post);
            else return RedirectToAction("Index");
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


    }
}
