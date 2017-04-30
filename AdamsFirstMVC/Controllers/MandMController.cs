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
        private readonly BandsUnitOfWork _bandsUnitOfWork;
        private readonly AboutUnitOfWork _aboutUnitOfWork;
        private readonly DJUnitOfWork _dJUnitOfWork;

        public MandMController()
        {
            _bandsUnitOfWork = new BandsUnitOfWork();
            _aboutUnitOfWork = new AboutUnitOfWork();
            _dJUnitOfWork = new DJUnitOfWork();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View(_aboutUnitOfWork);
        }

        public ActionResult Bands()
        {
            return View(_bandsUnitOfWork);
        }
        public ActionResult DJs()
        {
            return View(_dJUnitOfWork);
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}