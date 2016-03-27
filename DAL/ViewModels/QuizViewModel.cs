using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.ViewModels
{
    public class QuizViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedOn { get; set; }
        public List<QuestionViewModel> Questions { get; set; }
        public int MyProperty { get; set; }
    }
}