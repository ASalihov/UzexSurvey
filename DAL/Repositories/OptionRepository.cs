using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Contracts;
using DAL.Entities;

namespace DAL.Repositories
{
    public class OptionRepository : GenericRepository<Option>, IOptionRepository
    {
        public OptionRepository(AppDbContext context)
            :base(context)
        {}


        public IEnumerable<Option> GetByQuestionId(int QuestionId)
        {
            return _context.Options.Where(q => q.QuestionId == QuestionId).OrderBy(q => q.Position);
        }
    }
}
