﻿using AdamsFirstMVC.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdamsFirstMVC.Controllers
{
    public class MandMController : Controller
    {
        private BandsUnitOfWork bandsUnitOfWork;
        private AboutUnitOfWork aboutUnitOfWork;

        public MandMController()
        {
            bandsUnitOfWork = new BandsUnitOfWork();
            aboutUnitOfWork = new AboutUnitOfWork();
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
            return View(aboutUnitOfWork);
        }

        public ActionResult Bands()
        {
            return View(bandsUnitOfWork);
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