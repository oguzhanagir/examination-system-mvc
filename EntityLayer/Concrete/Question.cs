using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Question
    {
        [Key]
        public int QuestionID { get; set; }
        [StringLength(600)]
        public string QuestionText { get; set; }

        public int SectionID { get; set; }

        public int UnitID { get; set; }
        [StringLength(200)]
        public string PicturePath { get; set; }
        [StringLength(5)]
        public string RightAnswer { get; set; }
        [StringLength(5)]
        public string Wrong { get; set; }
    }
}
