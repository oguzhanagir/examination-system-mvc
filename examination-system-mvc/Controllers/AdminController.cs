using BusinessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace examination_system_mvc.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin

        UserManager userManager = new UserManager();
        QuestionManager questionManager = new QuestionManager();

        public ActionResult Index()
        {
            return View();
        }
     


        public PartialViewResult UserCount()
        {
            var userCount = userManager.UserCountBL();
            ViewBag.userCount = userCount.ToString();
            return PartialView();
        }

        public PartialViewResult QuestionCount()
        {
            var questionCount = questionManager.QuestionCountBL();
            ViewBag.questionCount = questionCount.ToString();
            return PartialView();
        }


        
    }
}