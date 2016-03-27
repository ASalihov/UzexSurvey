﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL.Entities;
using System.ComponentModel.DataAnnotations;

namespace DAL.ViewModels
{
    public class QuestionViewModel
    {
        public int Id { get; set; }
        public string Text{ get; set; }
        [Required]
        public int? SelectedOption { get; set; }
        public int?[] MultiSelectedOptions { get; set; }
        public string TextAnswer { get; set; }
        public QuestionType Type { get; set; }
        public IEnumerable<Option> Options { get; set; }
    }
}