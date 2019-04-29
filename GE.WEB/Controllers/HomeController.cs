using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GE.WEB.Models;
using GE.RL.Interfaces;
using Microsoft.Extensions.Configuration;
using Ninject;
using GE.RL.Repositories;
using Microsoft.EntityFrameworkCore;
using GE.RL;
using GE.WEB.Data;
using System.Net.Sockets;
using System.IO;
using System.Globalization;

namespace GE.WEB.Controllers
{
    public class HomeController : Controller
    {

        private IUnitOfWork unitOfWork;

        public HomeController(IUnitOfWork unitOfWork)
        {
            //DbConnectionService dbConnection = new DbConnectionService("MyConnection");
            //unitOfWork = dbConnection.GetUnitOfWork();
            this.unitOfWork = unitOfWork;
        }




        public IActionResult Index()
        {
            ViewBag.categories = unitOfWork.Categories.GetAll();
            return View();
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
