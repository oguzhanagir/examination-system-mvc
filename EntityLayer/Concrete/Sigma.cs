using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Sigma
    {
        [Key]
        public int SigmaID { get; set; }
        public int SigmaCount { get; set; }
        

        [StringLength(10)]
        public string UserAnswer { get; set; }

        

        public bool SigmaCheck { get; set; }

        public int UserID { get; set; }
        public virtual User User { get; set; }

        public int QuestionID { get; set; }
        public virtual Question Question { get; set; }

    }
}
