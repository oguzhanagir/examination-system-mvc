using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace examination_system_mvc.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login

        Context c = new Context();
        LoginManager loginManager = new LoginManager();
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(User p)
        {
            var userInfo = c.Users.FirstOrDefault(x => x.Mail == p.Mail &&
            x.Password == p.Password);
            if (userInfo != null )
            {
                FormsAuthentication.SetAuthCookie(userInfo.Mail, false);
                Session["Mail"] = userInfo.Mail.ToString();

                if (userInfo.UserType.UserTypeName == "Admin")
                {
                    return RedirectToAction("Index", "Admin");
                }
                else if(userInfo.UserType.UserTypeName == "Öğrenci")
                {
                    return RedirectToAction("Index", "Student");
                }
                else
                {
                    return RedirectToAction("Index", "Examiner");
                }
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
           
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(User p)
        {
            loginManager.UserAddBL(p);
            return RedirectToAction("Register");
        }

        public ActionResult ForgotPassword()
        {
            return View();
        }
    }
}