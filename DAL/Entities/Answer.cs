using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Entities
{
    public class Answer
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public string Name { get; set; }
        public AnswerType AnswerType { get; set; }

    }
}
