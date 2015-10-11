using System.Web.Mvc;
using XMLHelper;

namespace GP24MVC.Controllers
{
    public class WorkController : Controller
    {
        public ActionResult DistrictService()
        {
            XMLReader readerXML = new XMLReader();
            var data = readerXML.RetrunListOfDoctors();
            return View(data);
        }

        public ActionResult Specialists()
        {
            return View();
        }

        public ActionResult Dentists()
        {
            return View();
        }
    }
}