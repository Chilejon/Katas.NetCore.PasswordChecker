using Katas.NetCore.PasswordChecker;
using LoginForm.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LoginForm.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(IndexModel indexModel)
        {
            if (!ModelState.IsValid)
            {
                return View(indexModel);
            }

            PasswordChecker checker = new();
            string result = checker.Check(indexModel.Password);
            //if (result != "Password is acceptable") {
                indexModel.ErrorMessage = result;
                return View(indexModel); 
            //}

            //return View("BackEnd");
        }

    }
}