using DAL.Contracts;
using DAL.Repositories;

namespace DAL
{
    public class UoW : IUoW
    {
        protected readonly AppDbContext _context;
        private IQuizRepository _quizes;
        private IQuestionRepository _questions;
        private IOptionRepository _Options;
        private IAnswerRepository _Answers;
        
        public UoW(AppDbContext context)
        {
            _context = context;
        }

        public IQuizRepository Quizes
        {
            get { return _quizes ?? (_quizes = new QuizRepository(_context)); }
        }

        public IQuestionRepository Questions
        {
            get { return _questions ?? (_questions = new QuestionRepository(_context)); }
        }

        public IOptionRepository Options
        {
            get { return _Options ?? (_Options = new OptionRepository(_context)); }
        }

        public IAnswerRepository Answers
        {
            get { return _Answers ?? (_Answers = new AnswerRepository(_context)); }
        }

        public int Complete()
        {   
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            if (_context != null)
            {
                _context.Dispose();
            }
        }
    }
}
