using AdamsFirstMVC.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdamsFirstMVC.Controllers
{
    public class MandMController : Controller
    {
        private MandMContext db = new MandMContext();

        public ActionResult Index()
        {

            return View(db);
        }

        public ActionResult Feature()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
        public ActionResult Bands()
        {
            return View();
        }
        public ActionResult Event_Calendar()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
    }
}