using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Business.Models;
using Business.Models.ViewModel;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    public class UserController : Controller
    {
        [Route("api/login")]
        [HttpGet]
        public IActionResult Login(string returnUrl = "api/user/dashboard", int id)
        {
            var model = new LoginViewModel { ReturnUrl = returnUrl };
            return Dashboard(model, id);
        }


        [Route("api/register")]
        [HttpPost]
        public IActionResult Register()
        {
            return View();
        }

        [Route("api/forgot_password")]
        [HttpGet]
        public IActionResult Forgot(string returnUrl = "api/user/dashboard", int id)
        {
            return Login(returnUrl, id);
        }



        [Route("api/user/dashboard")]
        public IActionResult Dashboard(LoginViewModel model, int id)
        {
            return View();
        }
    }
}
