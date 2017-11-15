using ExamQuiz.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamQuiz.Servicies
{
    public class ExamQuizService
    {
        ExamQuizRepository ExamQuizRepository;

        public ExamQuizService(ExamQuizRepository examQuizRepository)
        {
            ExamQuizRepository = examQuizRepository;
        }
    }
}
