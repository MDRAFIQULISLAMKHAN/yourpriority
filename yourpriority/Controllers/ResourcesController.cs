﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace yourpriority.Controllers
{
    public class ResourcesController : Controller
    {
        // GET: Resources
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult New_Customer()
        {
            return View();
        }
        public ActionResult News()
        {
            return View();
        }
        public ActionResult Calculators()
        {
            return View();
        }
        public ActionResult Our_Dispute_Resolution_Policy()
        {
            return View();
        }
        public ActionResult Privacy_Policy()
        {
            return View();
        }

        public ActionResult Subscribe()
        {
            return View();
        }
    }
}