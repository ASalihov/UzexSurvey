using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;
using DAL.ViewModels;

namespace DAL.Contracts
{
    public interface IAnswerRepository : IRepository<Answer>
    {
        void SavePassedQuiz(QuizViewModel quizVm);
    }
}
