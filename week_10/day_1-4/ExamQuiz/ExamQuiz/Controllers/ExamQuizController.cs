using ExamQuiz.Servicies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamQuiz.Controllers
{
    public class ExamQuizController
    {
        ExamQuizService ExamQuizService;

        public ExamQuizController(ExamQuizService examQuizService)
        {
            ExamQuizService = examQuizService;
        }
    }
}
