using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace DAL.ViewModels
{
    public class OptionViewModule
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public string Name { get; set; }
        public OptionType OptionType { get; set; }
        public int Position { get; set; }
        public bool Selected { get; set; }
        public string TextAnswer { get; set; }
        public int MyProperty { get; set; }

    }
}
