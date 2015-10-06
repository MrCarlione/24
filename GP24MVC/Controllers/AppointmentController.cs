using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GP24MVC.Controllers
{
    public class AppointmentController : Controller
    {
        // GET: Appointment
        public ActionResult PortalPatient()
        {
            return Redirect("https://rmis52.cdmarf.ru/pp/#!/group/clinic_2750/!/");
        }

        public ActionResult OrderRecords()
        {
            return View();
        }

        public ActionResult PlotService()
        {
            return View();
        }
    }
}