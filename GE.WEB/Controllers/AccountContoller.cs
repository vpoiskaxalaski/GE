using GE.DAL.Model;
using GE.RL.Interfaces;
using GE.WEB.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;
using Microsoft.AspNetCore.Identity;

namespace GE.WEB.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private IUnitOfWork db;

        public AccountController(IUnitOfWork unitOfWork)
        {
            this.db = unitOfWork;
        }
        [HttpGet]
        public IActionResult Login()
        {
            return PartialView();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser user = db.Users.GetAll().FirstOrDefault(u => u.UserName == model.Name && u.PasswordHash == model.Password);
                if (user != null)
                {
                    await Authenticate(model.Name); // аутентификация

                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("", "Некорректные логин и(или) пароль");
            }
            return View(model);
        }

        [HttpGet]
        [AllowAnonymous]
        public ActionResult RegisterModal()
        {
            return PartialView();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<ActionResult> RegisterModal(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser user = db.Users.GetAll().FirstOrDefault(u => u.Email == model.Email && u.PasswordHash == model.Password);
                if (user == null)
                {
                    // добавляем пользователя в бд
                    db.Users.Create(CreateUser(model));
                    await Authenticate(model.Email); // аутентификация

                    return RedirectToAction("Index", "Home");
                }
                else
                    ModelState.AddModelError("", "Некорректные логин и(или) пароль");
            }
            return View(model);

        }


        private async Task Authenticate(string userName)
        {
            // создаем один claim
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, userName)
            };
            // создаем объект ClaimsIdentity
            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
            // установка аутентификационных куки
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Account");
        }


        //    if (ModelState.IsValid)
        //    {
        //        var user = CreateUser(model);
        //        var result = await UserManager.CreateAsync(user, model.Password);
        //        if (result.Succeeded)
        //        {
        //            var code = await UserManager.GenerateEmailConfirmationTokenAsync(user.Id);
        //            var callbackUrl = Url.Action("ConfirmEmail", "Account", new { userId = user.Id, code = code }, protocol: Request.Url.Scheme);
        //            await UserManager.SendEmailAsync(user.Id, "Подтверждение электронной почты", "Для завершения регистрации перейдите по ссылке: <a href=\"" + callbackUrl + "\"> завершить регистрацию</a>");
        //            ViewBag.Message = "На указанный электронный адрес отправлены дальнейшие инструкции по завершению регистрации";
        //            return PartialView();
        //        }
        //        AddErrors(result);
        //    }
        //    return PartialView(model);
        //}


        private ApplicationUser CreateUser(RegisterViewModel model)
        {
            var user = new ApplicationUser
            {
                UserName = model.Name,
                Email = model.Email,
                Posts = new List<Post>(),
                Points = new Point
                { 
                    Points = 25,
                    Operations = new List<Operation>()
                    {
                        new Operation
                        {
                            Earned = 25,
                            Date = HomeController.GetTime()
                        }
                    }
                },
                PhoneNumber = model.PhoneNumber
            };
            return user;
        }


        //[AllowAnonymous]
        //public async Task<ActionResult> ConfirmEmail(string userId, string code)
        //{
        //    if (userId == null || code == null)
        //    {
        //        return View("Error");
        //    }
        //    var result = await UserManager.ConfirmEmailAsync(userId, code);
        //    await UserManager.AddToRoleAsync(userId, "User");
        //    return View(result.Succeeded ? "ConfirmEmail" : "Error");
        //}

        //[HttpPost]
        //public ActionResult LogOff()
        //{
        //    AuthenticationManager.SignOut(DefaultAuthenticationTypes.ApplicationCookie);
        //    return RedirectToAction("Index", "Home");
        //}
    }
}
