using System.Collections.Generic;
using DAL.Entities;
using DAL.ViewModels;

namespace DAL.Contracts
{
    public interface IQuizRepository : IRepository<Quiz>
    {
        IEnumerable<Quiz> GetNotEmpties();
        QuizViewModel GetQuizToPass(int id);

    }
}
