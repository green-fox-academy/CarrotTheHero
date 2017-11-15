using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamQuiz.Models
{
    public class QuestionRound
    {
        public int Id { get; set; }
        public List<QuestionModel> Questions { get; set; }
    }
}
