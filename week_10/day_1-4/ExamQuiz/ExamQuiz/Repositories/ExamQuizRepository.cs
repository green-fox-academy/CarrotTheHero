using ExamQuiz.Entities;
using ExamQuiz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamQuiz.Repositories
{
    public class ExamQuizRepository
    {
        ExamQuizContext ExamQuizContext;

        public ExamQuizRepository(ExamQuizContext examQuizContext)
        {
            ExamQuizContext = examQuizContext;
        }

        public List<Quiz> GetFive()
        {
            var random = new Random();
            return ExamQuizContext.Quizes.OrderBy(x => random.Next()).Take(5).ToList();
        }
    }
}
