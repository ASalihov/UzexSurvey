using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Question
    {
        public int Id { get; set; }
        public string Body { get; set; }
        public int QuizId { get; set; }

        public QuestionType QuestionType { get; set; }
        public virtual Quiz Quiz { get; set; }

        public virtual ICollection<Answer> Answers { get; set; }
    }
}
