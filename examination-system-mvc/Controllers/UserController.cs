using BusinessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace examination_system_mvc.Controllers
{
    public class UserController : Controller
    {
        // GET: User

        UserProfileManager profileManager = new UserProfileManager();

        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult UserProfileList(string p)
        {
            p = (string)Session["Mail"];

            var profileValues = profileManager.GetUserByMail(p);
            return PartialView(profileValues);
        }

    }
}