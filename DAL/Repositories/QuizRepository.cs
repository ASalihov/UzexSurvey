using System;
using System.Collections.Generic;
using System.Linq;
using DAL.Entities;
using DAL.Contracts;
using DAL.ViewModels;

namespace DAL.Repositories
{
    public class QuizRepository : GenericRepository<Quiz>, IQuizRepository
    {
        public QuizRepository(AppDbContext context)
            :base(context)  
        {}

        public QuizViewModel GetQuizToPass(int id)
        {

            var quiz = GetById(id);
            var quizVm = new QuizViewModel()
            {
                CreatedOn = quiz.CreatedOn,
                Id = quiz.Id,
                Name = quiz.Name,
                Description = quiz.Description,
                Questions = new List<QuestionViewModel>()
            };
            var questions = _context.Set<Question>().Where(q => q.QuizId == id).ToList();
            foreach (var question in questions)
            {
                var questionVm = new QuestionViewModel
                {
                    Id = question.Id,
                    Text = question.Text,
                    Options = new List<OptionViewModel>(),
                    Type = question.QuestionType
                };

                var query = (
                    from opts in question.Options
                    join answers in _context.Set<Answer>()
                        on opts.Id equals answers.SelectedOptionId
                        into g
                    where opts.QuestionId == question.Id
                    select new
                    {
                        Id = opts.Id,
                        Name = opts.Name,
                        OptionType = opts.OptionType,
                        Position = opts.Position,
                        QuestionId = opts.QuestionId,
                        AnswersCount = g.Count()
                    }
                );
                var options = query.ToList();
                foreach (var option in options)
                {
                    var optionVm = new OptionViewModel
                    {
                        Id = option.Id,
                        Name = option.Name,
                        OptionType = option.OptionType,
                        Position = option.Position,
                        QuestionId = option.QuestionId,
                        AnswersCount = option.AnswersCount
                    };
                    questionVm.Options.Add(optionVm);
                }
                quizVm.Questions.Add(questionVm);
            }
            return quizVm;
        }

        public IEnumerable<Quiz> GetNotEmpties()
        {
            return _context.Set<Quiz>().Where(q => q.Questions.Any()).ToList();
        }

        public void Add(Quiz quiz)
        {
            quiz.CreatedOn = DateTime.Now;
            _context.Set<Quiz>().Add(quiz);
        }
    }
}
