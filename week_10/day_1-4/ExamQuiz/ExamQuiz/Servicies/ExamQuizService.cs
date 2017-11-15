using ExamQuiz.Models;
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

        public QuestionRound GetFiveQuestion()
        {
            var Quests = new List<QuestionModel>();
            var ListOfFive = ExamQuizRepository.GetFive();

            for (int i = 0; i < ListOfFive.Count; i++)
            {
                var question = new QuestionModel();
                question.Id = ListOfFive[i].Id;
                question.Question = ListOfFive[i].Question;
                Quests.Add(question);
            }

            var BigQuestions = new QuestionRound()
            {
                Id = 1,
                Questions = Quests
            };
            return BigQuestions;
        }
    }
}
