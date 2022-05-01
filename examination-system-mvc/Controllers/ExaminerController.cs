using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace examination_system_mvc.Controllers
{
    public class ExaminerController : Controller
    {
        // GET: Examiner
        public ActionResult Index()
        {
            return View();
        }
    }
}