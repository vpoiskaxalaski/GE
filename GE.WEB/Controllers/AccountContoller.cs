﻿using AutoMapper;
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
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AccountController(
            IAccountService accountService, 
            IEmailService emailService,
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            RoleManager<IdentityRole> roleManager)
        {
            _accountService = accountService;
            _emailService = emailService;
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
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
                var user = _userManager.FindByEmailAsync(model.Email).Result;
                await _signInManager.CreateUserPrincipalAsync(user);
                var result = _signInManager.PasswordSignInAsync(user.UserName, model.Password, false, false).Result;


                if (result.Succeeded)
                {
                    // Authenticate(model.Email);
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
                ApplicationUserVM newUser = new ApplicationUserVM
                {
                    UserName = model.Name,
                    Email = model.Email,
                    PhoneNumber = model.PhoneNumber,
                    Role = "User"
                };

                var config = new MapperConfiguration(cfg => {
                    cfg.CreateMap<ApplicationUserVM, ApplicationUser>();
                });
                var map = config.CreateMapper();
                var user =  map.Map<ApplicationUserVM, ApplicationUser>(newUser);

                if (user != null)
                {
                    var result = await _userManager.CreateAsync(user, model.Password);
                    var roleCheck = await _roleManager.RoleExistsAsync("User");
                    if (!roleCheck)
                    {
                        await _roleManager.CreateAsync(new IdentityRole("User"));
                    }
                    await _userManager.AddToRoleAsync(user, "User");
                    SendMessage(user);
                    return PartialView("DisplayEmail");
                }

                ModelState.AddModelError("", "Пользователь с таким Еmail или именем уже существует");
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
                var user = _userManager.FindByEmailAsync(model.Email).Result;
                await _signInManager.CreateUserPrincipalAsync(user);
                var result = await _signInManager.PasswordSignInAsync(user.UserName, model.Password, false, false);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                    //return Json(new { success = true });
                }

                ModelState.AddModelError("", "Неверный Email или пароль");
                ModelState.AddModelError("", "Подтвердите Email");
            }
            return View();//View(model);

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
                ApplicationUserVM newUser = new ApplicationUserVM
                {
                    UserName = model.Name,
                    Email = model.Email,
                    PhoneNumber = model.PhoneNumber
                };

                var config = new MapperConfiguration(cfg => {
                    cfg.CreateMap<ApplicationUserVM, ApplicationUser>();
                });
                var map = config.CreateMapper();
                var user = map.Map<ApplicationUserVM, ApplicationUser>(newUser);
                var result = await _userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    var roleCheck = await _roleManager.RoleExistsAsync("User");
                    if (!roleCheck)
                    {
                        IdentityResult roleResult = await _roleManager.CreateAsync(new IdentityRole("User"));
                    }
                    await _userManager.AddToRoleAsync(user, "User");
                    SendMessage(user);
                    return PartialView("DisplayEmail");
                }

                ModelState.AddModelError("", "Пользователь с таким Еmail или именем уже существует");
            }
            return View(model);
        }


        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login", "Account");
        }

        public async void SendMessage(ApplicationUser user)
        {
            var u = _userManager.FindByEmailAsync(user.Email).Result;
            var code = await _userManager.GenerateEmailConfirmationTokenAsync(u);
            var callbackUrl = Url.Action("ConfirmEmail", "Account", new { email = user.Email, code }, protocol: Request.Scheme);
            ViewBag.Messages = callbackUrl.ToString();
            try
            {
               await _emailService.SendEmailAsync(user.Email, "Для завершения регистрации перейдите по ссылке: <a href=\"" + callbackUrl + "\"> завершить регистрацию</a>");
            }
            catch(Exception ex) {  }

        }

        public IActionResult ConfirmEmail(string email, string code)
        {
            if (email != null && code != null)
            {
                var result = _userManager.ConfirmEmailAsync( _userManager.FindByEmailAsync(email).Result , code).Result;

                return View(result.Succeeded ? "ConfirmEmail" : "Error");
            }
 
            return View("Error");
        }

    }
}
