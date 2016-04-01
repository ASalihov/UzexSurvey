using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Quiz
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }

        [Required(ErrorMessage = "Name is Required")]
        public string Name { get; set; }

        public string Description { get; set; }

        public virtual ICollection<Question> Questions { get; set; } 
    }
}
