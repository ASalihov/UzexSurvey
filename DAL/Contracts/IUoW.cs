using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Contracts
{
    public interface IUoW : IDisposable
    {
        IQuizRepository Quizes { get; }
        IQuestionRepository Questions { get; }
        IOptionRepository Options { get; }
        IAnswerRepository Answers { get; }
        int Complete();
    }
}
