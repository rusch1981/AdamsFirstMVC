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
        private BandsUnitOfWork unitOfWork = null;

        public MandMController()
        {
            unitOfWork = new BandsUnitOfWork();
        }

        public MandMController(BandsUnitOfWork _UnitOfWork)
        {
            this.unitOfWork = _UnitOfWork;
        }

        public ActionResult Index()
        {
            return View();
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
            return View(unitOfWork);
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