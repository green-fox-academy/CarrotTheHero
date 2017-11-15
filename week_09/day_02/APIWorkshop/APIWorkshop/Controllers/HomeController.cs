using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using APIWorkshop.Models;
using APIWorkshop.Repositories;

namespace APIWorkshop.Controllers
{
    public class HomeController : Controller
    {
        HomeRepository HomeRepository;

        public HomeController(HomeRepository homeRepository)
        {
            HomeRepository = homeRepository;
        }

        [Route("/")]
        public IActionResult Index()
        {
            return File("index.html", "text/html");
        }

        [Route("/doubling")]
        [HttpGet]
        public IActionResult Doubling(int? input)
        {
            if (input == null)
            {
                return Json(new { error = "Please provide an input!" });
            }
            return Json(new { received = input, result = input * 2 });
        }

        [Route("/greeter")]
        [HttpGet]
        public IActionResult Greeter(string name, string title)
        {
            if (name == null)
            {
                return Json(new { error = "Please provide a name!" });
            }
            else if (title == null)
            {
                return Json(new { error = "Please provide a title!" });
            }
            else
            {
                return Json(new { welcome_message = $"Oh, hi there {name}, my dear {title}!" });
            }
        }

        [Route("/appenda/{appendable}")]
        [HttpGet]
        public IActionResult Appenda(string appendable)
        {
            return Json(new { appended = appendable + 'a' });
        }

        [HttpGet]
        [Route("/appenda/")]
        public IActionResult Append()
        {
            return NotFound();
        }

        [HttpPost]
        [Route("/dountil/{what}")]
        [Route("/dountil/")]
        public IActionResult DoUntil([FromBody] JsonObject jsonObject, string what)
        {
            if (what == "factor")
            {
                int factorial = 1;
                for (int i = 1; i < jsonObject.Until + 1; i++)
                {
                    factorial *= i;
                }
                return Json(new { result = factorial });
            }
            else if (what == "sum")
            {
                int sum = 0;
                for (int i = 1; i < jsonObject.Until + 1; i++)
                {
                    sum += i;
                }
                return Json(new { result = sum });
            }
            else
            {
                return Json(new { error = "Please provide a number!" });
            }
        }

        [HttpPost]
        [Route("arrays")]
        public IActionResult ArrayHandler([FromBody]ComplexData complexData)
        {
            dynamic result = 0;

            if (complexData != null)
            {
                if (complexData.Numbers == null || complexData.Numbers.Length == 0)
                {
                    return Json(new { error = "Please provide an array of numbers!" });
                }
                else if (complexData.What == null)
                {
                    return Json(new { error = "Please provide what to do with the numbers!" });
                }
                else
                {
                    return Json(new { result = HomeRepository.ArithmeticTypeCheck(complexData) });
                }
            }
            else
            {
                return Json(new { error = "Please provide proper inputs!" });
            }
        }
    }
}
