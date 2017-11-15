using ExamQuiz.Entities;
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
    }
}
