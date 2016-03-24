using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;
using DAL.Contracts;

namespace DAL.Repositories
{
    public class QuizRepository : GenericRepository<Quiz>, IQuizRepository
    {
        public QuizRepository(AppDbContext context)
            :base(context)  
        {}

        public void Add(Quiz quiz)
        {
            quiz.CreatedOn = DateTime.Now;
            _context.Set<Quiz>().Add(quiz);
        }
    }
}
