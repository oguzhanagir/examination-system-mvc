using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using PagedList;
using PagedList.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Word = Microsoft.Office.Interop.Word;

namespace examination_system_mvc.Controllers
{
    public class QuestionController : Controller
    {
        // GET: Question
        Context c = new Context();
        QuestionManager questionManager = new QuestionManager();
        SigmaManager sigmaManager = new SigmaManager();
        
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult QuestionAdd()
        {
            return View();
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult QuestionAdd(Question p)
        {
            
            questionManager.QuestionAddBL(p);
            return RedirectToAction("QuestionAdd");
            
        }

        public ActionResult QuestionGetList()
        {
            var questionList = questionManager.GetAll();
            return PartialView(questionList);
        }

        public ActionResult DeleteQuestion(int id)
        {
            questionManager.DeleteQuestionBL(id);
            return RedirectToAction("QuestionGetList");
        }

        [HttpGet]
        public ActionResult Exam(int page = 1)
        {
            var questionGetRandomList = questionManager.GetRandom().ToPagedList(page, 1);
            return View(questionGetRandomList);
        }

        [HttpPost]
        public ActionResult Exam(Sigma p)
        {
            sigmaManager.SigmaCheckAddBL(p);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateQuestion(int id)
        {
            Question question = questionManager.FindQuestion(id);


            return View(question);
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult UpdateQuestion(Question p)
        {
            questionManager.UpdateQuestion(p);
            return RedirectToAction("QuestionGetList");
        }


        
    }
}