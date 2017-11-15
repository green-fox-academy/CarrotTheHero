using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExamQuiz.Models;

namespace ExamQuiz.Entities
{
    public class ExamQuizContext : DbContext
    {
        public ExamQuizContext(DbContextOptions<ExamQuizContext> options) : base(options)
        {

        }

        public DbSet<Quiz> Quizes { get; set; }
    }
}
