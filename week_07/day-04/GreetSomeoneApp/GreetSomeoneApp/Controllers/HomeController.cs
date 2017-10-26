using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GreetSomeoneApp.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GreetSomeoneApp.Controllers
{
    public class HomeController : Controller
    {
        UserInfo userInfo;

        public HomeController(UserInfo userInfo)
        {
            this.userInfo = userInfo;
        }

        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View(userInfo);
        }

        [HttpPost]
        [Route("")]
        public IActionResult Post(UserInfo userInfo)
        {
            return RedirectToAction("Greet", userInfo);
        }

        [HttpGet]
        [Route("greet")]
        public IActionResult Greet(UserInfo userInfo)
        {
            return View(userInfo);
        }
    }
}
