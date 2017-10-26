using GreetSomeoneApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace GreetSomeoneApp.Controllers
{
    public class HomeController : Controller
    {
        private UserInfo UserInfo;

        public HomeController(UserInfo userInfo)
        {
            UserInfo = userInfo;
        }

        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View(UserInfo);
        }

        [HttpPost]
        [Route("")]
        public IActionResult Post(string inputInfo)
        {
            UserInfo.Name = inputInfo;
            return RedirectToAction("Greet");
        }

        [HttpGet]
        [Route("greet")]
        public IActionResult Greet()
        {
            return View(UserInfo);
        }
    }
}
