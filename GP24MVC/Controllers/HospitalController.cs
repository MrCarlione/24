using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GP24MVC.Controllers
{
    public class HospitalController : Controller
    {
        // GET: Hospital
        public ActionResult HospitalsRules()
        {
            return View();
        }

        public ActionResult Nursing()
        {
            return View();
        }
    }
}