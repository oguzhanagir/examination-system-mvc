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
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult QuestionAdd()
        {
            return View();
        }

        public ActionResult Exam()
        {
            return View();
        }
    }
}