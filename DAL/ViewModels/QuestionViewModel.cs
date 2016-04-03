using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.ViewModels
{
    public class QuestionViewModel
    {
        public int Id { get; set; }
        public int QuizId { get; set; }
        public string Text{ get; set; }

        [Required(ErrorMessage = "Option must be selected")]
        public int? SelectedOption { get; set; }

        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [Required(ErrorMessage = "Answer the question", AllowEmptyStrings = true)]
        public string TextAnswer { get; set; }

        public QuestionType Type { get; set; }

        public List<OptionViewModel> Options { get; set; }
    }
}