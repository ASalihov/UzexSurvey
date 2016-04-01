using System.ComponentModel;
namespace DAL.Entities
{
    public class Option
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public string Name { get; set; }

        [DisplayName("Type")]
        public OptionType OptionType { get; set; }
        public int Position { get; set; }

    }
}
