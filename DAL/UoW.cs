using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Contracts;
using DAL.Repositories;

namespace DAL
{
    public class UoW : IUoW
    {
        protected readonly AppDbContext _context;
        private IQuizRepository _quizes;
        private IQuestionRepository _questions;
        
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
