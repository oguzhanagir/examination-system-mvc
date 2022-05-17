using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Sigma
    {
        [Key]
        public int SigmaID { get; set; }
        public bool SigmaCheck1 { get; set; }
        public bool SigmaCheck2 { get; set; }
        public bool SigmaCheck3 { get; set; }
        public bool SigmaCheck4 { get; set; }
        public bool SigmaCheck5 { get; set; }
        public bool SigmaCheck6 { get; set; }

        [StringLength(10)]
        public string UserAnswer { get; set; }

        public int UserID { get; set; }
        public virtual User User { get; set; }

        public int QuestionID { get; set; }
        public virtual Question Question { get; set; }

    }
}
