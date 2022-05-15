using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Answer
    {
        [Key]
        public int AnswerID { get; set; }

        [StringLength(500)]
        public string OptionA { get; set; }
        [StringLength(500)]
        public string OptionB { get; set; }
        [StringLength(500)]
        public string OptionC { get; set; }
        [StringLength(500)]
        public string OptionD { get; set; }

        public IEnumerable<Question> Questions { get; set; }

    }
}
