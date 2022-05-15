using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
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
            var questionGetRandomList = questionManager.GetRandom();
            return View(questionGetRandomList);
        }

        [HttpPost]
        public ActionResult Exam(Question p)
        {
            var questionInfo = c.Questions.FirstOrDefault(x => x.RightAnswer == p.RightAnswer);
            
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


        //public ActionResult GetDataWord(HttpPostedFileBase wordFile)
        //{
        //    if (wordFile == null || wordFile.ContentLength ==0)
        //    {
        //        ViewBag.Error = "Lütfen Dosya Seçimi Yapınız";
        //        return View();
        //    }
        //    else
        //    {
        //        //Dosya uzantısı docx ise
        //        if (wordFile.FileName.EndsWith("docx")|| wordFile.FileName.EndsWith("doc"))
        //        {
        //            //Dosyanın Nereye Yükleneceği Seçimi
        //            string path = Server.MapPath("~/Content/Questions/" + wordFile.FileName);

        //            //Dosya Kontrol Edilir Varsa Silinir.
        //            if (System.IO.File.Exists(path))
        //            {
        //                System.IO.File.Delete(path);
        //            }

        //            //Word Path Yoluna Kaydedilir

        //            wordFile.SaveAs(path);

        //            Word.Application application = new Word.Application();
        //            Word.Workbook workbook = application.Workbooks.Open(path);


        //        }
        //    }

        //}
    }
}