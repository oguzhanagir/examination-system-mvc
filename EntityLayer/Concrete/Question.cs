using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Word = Microsoft.Office.Interop.Word;

namespace EntityLayer.Concrete
{
    public class Question
    {
        [Key]
        public int QuestionID { get; set; }
        [StringLength(50)]
        public string LessonName { get; set; }
        public int GradeLevel { get; set; }
        public int UnitNo { get; set; }
        public int QuestionNo { get; set; }
        [StringLength(10)]
        public string CodeNo { get; set; }
        public string QuestionText { get; set; }


        public int AnswerID { get; set; }
        public virtual Answer Answer { get; set; }
        public ICollection<Sigma> Sigmas { get; set; }

    }
}
