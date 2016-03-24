using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace DAL.Contracts
{
    public interface IQuestionRepository : IRepository<Question>
    {
        IEnumerable<Question> GetByQuiz(int QuizId);
    }
}
