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

namespace GE.WEB.Controllers
{
    public class HomeController : Controller
    {

        private IUnitOfWork unitOfWork;

        public HomeController()
        {
            IKernel ninjectKernel = new StandardKernel();
            DbConnection dbConnection = new DbConnection("MyConnection");

            ninjectKernel.Bind<IUnitOfWork>().To<UnitOfWork>().WithConstructorArgument(dbConnection.GetOptions());
            unitOfWork = ninjectKernel.Get<IUnitOfWork>();
            unitOfWork.CategoriesInit();
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
    }
}
