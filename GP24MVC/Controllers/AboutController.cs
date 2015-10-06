using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GP24MVC.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        public ActionResult ShemeWay()
        {
            return View();
        }

        public ActionResult Contacts()
        {
            return View();
        }
        public ActionResult Employeers()
        {
            return View();
        }
        public ActionResult MedCare()
        {
            return View();
        }
        public ActionResult Vacancy()
        {
            return View();
        }
    }
}