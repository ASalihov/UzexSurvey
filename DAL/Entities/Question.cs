using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.ViewModels;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DAL.Entities
{
    public class Question
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Text is Required")]
        public string Text { get; set; }
        public int QuizId { get; set; }

        [Required(ErrorMessage = "Type is Required")]
        [DisplayName("Type")]
        [Range(1, int.MaxValue, ErrorMessage = "Select a type")]
        public QuestionType QuestionType { get; set; }

        public virtual ICollection<Option> Options { get; set; }
    }
}
