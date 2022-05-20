using Ecommerce.Data.Entities;
using Ecommerce.Data.ViewModels;
using ECommerce.Service;
using ECommerce.Service.Abstract;
using ECommerce.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NLog;
using System.Diagnostics;
using System.Security.Claims;

namespace ECommerce.Web.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;
        private readonly UserManager<AppUser> _userManager;
        private readonly IProductService _productService;

        public HomeController(
            SignInManager<AppUser> signInManager,
            UserManager<AppUser> userManager,
            IProductService productService)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _productService = productService;
        }

        public async Task<IActionResult> Index()
        {
            var result = await _productService.GetAllProductAsync();

            var roles = ((ClaimsIdentity)User.Identity).Claims
                .Where(c => c.Type == ClaimTypes.Role)
                .Select(c => c.Value);


            return View(result);

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {

            return View();
        }

        [HttpGet]
        public IActionResult LogOut()
        {
            _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public IActionResult Login(UserLoginViewModel userLoginModel)
        {
            if (!ModelState.IsValid)
            {
                return View(userLoginModel);
            }
            var SignInResult = _signInManager.PasswordSignInAsync(userLoginModel.UserName, userLoginModel.Password, userLoginModel.RememberMe, false).Result;
            if (!SignInResult.Succeeded)
            {
                ModelState.AddModelError("", "Kullanıcı veya Şifre hatalı");
                return View();
            }

            return RedirectToAction("Index", "Home");

        }

        [HttpGet]
        public IActionResult NotFound(int code)
        {
            ViewBag.Code = code;

            return View();
        }

        [Route("/Error")]
        [HttpGet]
        public IActionResult Error()
        {
            var ErrorInfo = HttpContext.Features.Get<IExceptionHandlerPathFeature>();
            var logger = LogManager.GetLogger("FileLogger");
            logger.Log(NLog.LogLevel.Error, $"\nHatanın Gerçekleştiği yer:{ErrorInfo.Path}\nHata Mesajı: {ErrorInfo.Error.Message}\nStack Trace:{ErrorInfo.Error.StackTrace}");
            return View();
        }

        [HttpGet]
        public IActionResult ForgetPassword()
        {

            return View();
        }

    }
}