using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace DAL.Contracts
{
    public interface IOptionRepository : IRepository<Option>
    {
        IEnumerable<Option> GetByQuestionId(int questionId);
    }
}