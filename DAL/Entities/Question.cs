﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.ViewModels;
using System.ComponentModel;

namespace DAL.Entities
{
    public class Question
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int QuizId { get; set; }

        [DisplayName("Type")]
        public QuestionType QuestionType { get; set; }

        public virtual ICollection<Option> Options { get; set; }
    }
}
