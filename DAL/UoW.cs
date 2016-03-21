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

        public IQuizRepository Quizes { get; private set; }

        public UoW(AppDbContext context)
        {
            _context = context;
            Quizes = new QuizRepository(_context);
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
