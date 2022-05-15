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

        public List<Question> GetRandom()
        {
            return repoQuestion.RandomList();
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

        public int QuestionAddBL(Question p)
        {
            return repoQuestion.Insert(p);
        }

        public int UpdateQuestion(Question p)
        {
            Question question = repoQuestion.Find(x => x.QuestionID == p.QuestionID);
            question.CodeNo = p.CodeNo;
            question.GradeLevel = p.GradeLevel;
            question.LessonName = p.LessonName;
            question.UnitNo = p.UnitNo;
            question.UnitName = p.UnitName;
            question.SubjectNo = p.SubjectNo;
            question.SubjectName = p.SubjectName;
            question.QuestionNo = p.QuestionNo;
            question.QuestionText = p.QuestionText;
            question.RightAnswer = p.RightAnswer;
            question.Answer.OptionA = p.Answer.OptionA;
            question.Answer.OptionB = p.Answer.OptionB;
            question.Answer.OptionC= p.Answer.OptionC;
            question.Answer.OptionD = p.Answer.OptionD;

            return repoQuestion.Update(question);
        }
        
        public Question FindQuestion(int id)
        {
            return repoQuestion.Find(x => x.QuestionID == id);
        }

       

    }
}
