using System;
using System.Collections.Generic;
using DAL.Entities;
using DAL.Contracts;
using DAL.ViewModels;

namespace DAL.Repositories
{
    public class AnswerRepository : GenericRepository<Answer>, IAnswerRepository
    {
        public AnswerRepository(AppDbContext context)
            : base(context)
        { }

        private void SaveSingle(QuestionViewModel questionVM)
        {
            var answer = new Answer
                {
                    QuizId = questionVM.QuizId,
                    QuestionId = questionVM.Id,
                    SelectedOptionId = questionVM.SelectedOption,
                    TextAnswer = questionVM.TextAnswer,
                    OptionText = questionVM.Options != null ? questionVM.Options.Find(o => o.Id == questionVM.SelectedOption).TextAnswer : null,
                    PassedOn = DateTime.Now
                };

            _context.Set<Answer>().Add(answer);
            //_context.Answers.Add(answer);
        }
        private void SaveChecboxes(QuestionViewModel questionVM)
        {
            Answer answer = new Answer();
            foreach (var option in questionVM.Options)
            {
                if (option.Selected)
                {
                    answer = new Answer
                    {
                        QuizId = option.QuizId,
                        QuestionId = option.QuestionId,
                        SelectedOptionId = option.Id,
                        OptionText = option.TextAnswer,
                        PassedOn = DateTime.Now
                    };
                    _context.Set<Answer>().Add(answer);
                }
            }
            //_context.Answers.Add(answer);
        }

        public void SavePassedQuiz(QuizViewModel quizVm)
        {
            foreach (var question in quizVm.Questions)
            {
                switch (question.Type)
                {
                    case QuestionType.ckeckbox:
                        SaveChecboxes(question);
                        break;
                    default:
                        SaveSingle(question);
                        break;
                }
            }
        }
    }
}
