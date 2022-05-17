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

        public int SigmaCheckAddBL(Sigma p)
        {
            Sigma sigma = repoSigma.Find(x => x.SigmaID == p.SigmaID); //Sigma ID ulaşma eksik


            if (sigma.UserAnswer == sigma.Question.Answer.RightAnswer)
            {
                sigma.SigmaCount += sigma.SigmaCount;
            }
            else //SigmaCount 6 ya Ulaşınca Bilinen soru Havuzuna Taşı
            {
                sigma.SigmaCount = 0;
            }


            return repoSigma.Insert(p);
        }

    }
}
