using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            var quizVM = new QuizViewModel()
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
                var options = _context.Set<Option>().Where(o => o.QuestionId == question.Id).ToList();
                var qVm = new QuestionViewModel
                {
                    Id = question.Id,
                    Text = question.Text,
                    Options = options,
                    Type = question.QuestionType
                };
                quizVM.Questions.Add(qVm);
            }
            return quizVM;
        }

        public IEnumerable<Quiz> GetNotEmpties()
        {
            return _context.Set<Quiz>().Where(q => q.Questions.Count() > 0).ToList();
        }

        public void Add(Quiz quiz)
        {
            quiz.CreatedOn = DateTime.Now;
            _context.Set<Quiz>().Add(quiz);
        }

        public void SavePassedQuiz(QuizViewModel quizVm)
        {
            var quiz = quizVm;
        }
    }
}
