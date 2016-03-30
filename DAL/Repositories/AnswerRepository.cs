using DAL.Entities;
using DAL.Contracts;
using DAL.ViewModels;
using System;

namespace DAL.Repositories
{
    public class AnswerRepository : GenericRepository<Answer>, IAnswerRepository
    {

        public AnswerRepository(AppDbContext context)
            :base(context)
        {}

        public void SavePassedQuiz(QuizViewModel quizVm)
        {
            foreach (var question in quizVm.Questions)
            {
                switch (question.Type)
                {
                    case QuestionType.radio:
                        Answer answer = new Answer
                        {
                            QuizId = quizVm.Id,
                            QuestionId = question.Id,
                            SelectedOptionId = question.SelectedOption,
                            OptionText = question.Options.Find(o => o.Id == question.SelectedOption).TextAnswer,
                            PassedOn = DateTime.Now
                        };
                        _context.Answers.Add(answer);
                        break;
                    case QuestionType.ckeckbox:
                        break;
                    case QuestionType.textarea:
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
