using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class SigmaManager
    {
        Repository<Sigma> repoSigma = new Repository<Sigma>();

        public int SigmaAddBL(Sigma p)
        {
            //Soru Doğru ve Yanlış Durumuna Göre SigmaCheck True False Değeri Değiştirelecektir.
            return repoSigma.Insert(p);
        }

        public int SigmaCheckBL(Sigma p)
        {
            Sigma sigma = repoSigma.Find(x => x.SigmaID == 11);
            
            

            if (sigma.UserAnswer == sigma.Question.Answer.RightAnswer)
            {
                sigma.SigmaCheck1 = true;
            }

            return repoSigma.Insert(p);
        }

    }
}
