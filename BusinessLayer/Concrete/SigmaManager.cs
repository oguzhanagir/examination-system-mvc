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
        Repository<Question> repoQuestion = new Repository<Question>();


        public int SigmaCheckAddBL(Sigma p, Question q)
        {
            Question question = repoQuestion.Find(x => x.QuestionID == q.QuestionID);

            Sigma sigma = repoSigma.Find(x => x.QuestionID == q.QuestionID);



            if (sigma.QuestionID == q.QuestionID )
            {
                if (question.Answer.RightAnswer == p.UserAnswer)
                {
                    sigma.SigmaCount += 1;
                    
                }
                else
                {
                    sigma.SigmaCount = 0;
                }

                if (sigma.SigmaCount == 6)
                {
                    sigma.SigmaCheck = true;
                    //Bilinen Soruya Taşı ve Gösterme
                }
                else
                {
                    sigma.SigmaCheck = false;
                }
                
                return repoSigma.Update(p);
            }

            
            return repoSigma.Insert(p);




        }

    }
}
