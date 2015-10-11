using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GP24MVC.Controllers
{
    public class FeedbackController : Controller
    {
        // GET: Feedback
        public ActionResult Reception()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Administration()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Administration(string a)
        {
            return View(a);
        }

        public ActionResult Question()
        {
            return View();
        }

        public ActionResult Review()
        {
            return View();
        }

        public ActionResult Mark()
        {
            return View();
        }
    }
}