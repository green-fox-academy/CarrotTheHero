using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Todos.Controllers
{
    public class TodoController : Controller
    {
        [Route("/todo")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("/")]
        [Route("/list")]
        public IActionResult List()
        {
            string words = "This is my first todo";
            return View((object)words);
        }
    }
}
