using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DAL.Entities
{
    public class Option
    {
        public int Id { get; set; }

        public int QuestionId { get; set; }

        [Required(ErrorMessage = "Name is Required")]
        public string Name { get; set; }

        [DisplayName("Type")]
        [Required(ErrorMessage = "Type is Required")]
        [Range(1, int.MaxValue, ErrorMessage = "Select a type")]
        public OptionType OptionType { get; set; }

        public int Position { get; set; }

    }
}
