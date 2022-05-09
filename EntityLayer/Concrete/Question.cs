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

        [StringLength(50)]
        public string LessonName { get; set; }

        [StringLength(50)]
        public string UnitName { get; set; }

        [StringLength(50)]
        public string SubjectName { get; set; }

        public int GradeLevel { get; set; }
        public int UnitNo { get; set; }
        public int SubjectNo { get; set; }
        public int QuestionNo { get; set; }
        public string CodeNo { get; set; }
        public char RightAnswer { get; set; }
        public char WrongAnswers { get; set; }

        [StringLength(200)]
        public string PicturePath { get; set; }

        [StringLength(600)]
        public string QuestionText { get; set; }

     
        
    }
}
