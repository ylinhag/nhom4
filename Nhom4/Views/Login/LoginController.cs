using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Nhom4.Views.Login
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string username, string password)
        {
            if(username =="admin" && password == "admin")
            {
                HttpContext.Session.SetString("isLoggedIn", "true");
                return RedirectToAction("Index", "/");
            }
            return View();
        }


        public IActionResult Logout()
        {
            HttpContext.Session.Remove("isLoggedIn");
            return RedirectToAction("Index");
        }

    }
}