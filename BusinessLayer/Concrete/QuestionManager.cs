using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class QuestionManager
    {
        Repository<Question> repoQuestion = new Repository<Question>();

        public List<Question> GetAll()
        {
            return repoQuestion.List();
        }

        public int DeleteQuestionBL(int p)
        {
            Question question = repoQuestion.Find(x => x.QuestionID == p);
            return repoQuestion.Delete(question);
        }

        public int QuestionCountBL()
        {
            return repoQuestion.List().Count();
        }
    }
}
