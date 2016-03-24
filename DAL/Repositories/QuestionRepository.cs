using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Contracts;
using DAL.Entities;

namespace DAL.Repositories
{
    public class QuestionRepository : GenericRepository<Question>, IQuestionRepository
    {
        public QuestionRepository(AppDbContext context)
            :base(context)
        {}


        public IEnumerable<Question> GetByQuizId(int QuizId)
        {
            return _context.Questions.Where(q => q.QuizId == QuizId);
        }
    }
}
