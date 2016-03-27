using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;
using DAL.ViewModels;

namespace DAL.Contracts
{
    public interface IQuizRepository : IRepository<Quiz>
    {
        IEnumerable<Quiz> GetNotEmpties();
        QuizViewModel GetQuizToPass(int id);

        void SavePassedQuiz(QuizViewModel quizVm);
    }
}
