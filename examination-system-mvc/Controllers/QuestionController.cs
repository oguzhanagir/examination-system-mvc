using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace examination_system_mvc.Controllers
{
    public class QuestionController : Controller
    {
        // GET: Question

        QuestionManager questionManager = new QuestionManager();
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
            return RedirectToAction("QuestionGetList");
            
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
        public ActionResult Exam()
        {
            var questionList = questionManager.GetAll();
            return View(questionList);
        }

        [HttpPost]
        public ActionResult Exam(Question p)
        {
            
            return RedirectToAction("");
        }


    }
}