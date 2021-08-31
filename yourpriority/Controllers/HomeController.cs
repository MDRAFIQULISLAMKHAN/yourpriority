﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace yourpriority.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult OurServices()
        {
            return View("~/Views/Home/Our_Services.cshtml");
        }
        // Sub Options
        public ActionResult HomeLoans()
        {
            return View("~/Views/Home/Home-Loans.cshtml");
        }

    }
}