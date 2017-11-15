using ExamQuiz.Servicies;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamQuiz.Controllers
{
    public class ExamQuizController : Controller
    {
        ExamQuizService ExamQuizService;

        public ExamQuizController(ExamQuizService examQuizService)
        {
            ExamQuizService = examQuizService;
        }

        [Route("/questions")]
        [HttpGet]
        public IActionResult Index()
        {
            return Json(ExamQuizService.GetFiveQuestion());
        }
    }
}
