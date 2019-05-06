using GE.DAL.Model;
using GE.Models;
using GE.SL.Interfaces;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace GE.WEB.Controllers
{

    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;
        private readonly IEmailService _emailService;
        private readonly UserManager<ApplicationUserVM> _userManager;

        public AccountController(IAccountService accountService, IEmailService emailService, UserManager<ApplicationUserVM> userManager)
        {
            _accountService = accountService;
            _emailService = emailService;
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult LoginModal()
        {
            return PartialView();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LoginModal(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (_accountService.Login(model) != false)
                {
                    await Authenticate(model.Email);
                    return Json(new { success = true });
                }
                ModelState.AddModelError("", "Неверный Email или пароль");
                ModelState.AddModelError("", "Подтвердите Email");
            }
            return PartialView(model);

        }

        [HttpGet]
        public IActionResult RegisterModal()
        {
            return PartialView();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RegisterModal(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (_accountService.Registration(model) == true)
                {
                    await Authenticate(model.Email);
                    SendMessage(model);
                    ViewBag.Message = "На указанный электронный адрес отправлены дальнейшие инструкции по завершению регистрации";
                    return PartialView();
                }
                ModelState.AddModelError("", "Еmail уже существует");
            }
            return PartialView(model);
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (_accountService.Login(model) != false)
                {
                   await Authenticate(model.Email);

                    return RedirectToAction("Index", "Home");
                }
//Check for EmailConfirm I wrote in ApplicationUserRepository.
//If you want to separate errors, you should change login method
                ModelState.AddModelError("", "Неверный Email или пароль");
                ModelState.AddModelError("", "Подтвердите Email");
            }
            return View(model);

        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (_accountService.Registration(model) == true)
                {
                    await Authenticate(model.Email);
                    SendMessage(model);
                    return View("DisplayEmail");
                }
                ModelState.AddModelError("", "Еmail уже существует");
            }
            return View(model);
        }

        private async Task Authenticate(string mail)
        {

            List<Claim> claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, mail),
                new Claim(ClaimsIdentity.DefaultRoleClaimType, _accountService.GetRole(mail))
            };

            var authProperties = new AuthenticationProperties
            {
                AllowRefresh = true,
                ExpiresUtc = DateTimeOffset.Now.AddDays(1),
                IsPersistent = true,
            };

            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType,
                ClaimsIdentity.DefaultRoleClaimType);

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id), authProperties);
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Account");
        }

        public async void SendMessage(RegisterViewModel model)
        {
            var user = _userManager.CreateAsync(new ApplicationUserVM { UserName = model.Name, Email = model.Email, PhoneNumber = model.PhoneNumber });
            //var t = _userManager.FindByEmailAsync(model.Email);
            var code = await _userManager.GenerateEmailConfirmationTokenAsync(_accountService.GetByEmail(model.Email));
            var callbackUrl = Url.Action("ConfirmEmail", "Account", new { email = model.Email, code }, protocol: Request.Scheme);
            ViewBag.Messages = callbackUrl.ToString();
            await _emailService.SendEmailAsync(model.Email, "Для завершения регистрации перейдите по ссылке: <a href=\"" + callbackUrl + "\"> завершить регистрацию</a>");
        }

        public IActionResult ConfirmEmail(string email, string code)
        {
            if (email != null && code != null)
            {
                bool result = _accountService.ConfirmEmail(email);

                return View(result ? "ConfirmEmail" : "Error");
            }
 
            return View("Error");

        }

    }
}
