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
        private IMandMRepository mandMRepository;

        public MandMController()
        {
            this.mandMRepository = new MandMRepository(new MandMContext());
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

            return View(mandMRepository.GetBandImages());
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