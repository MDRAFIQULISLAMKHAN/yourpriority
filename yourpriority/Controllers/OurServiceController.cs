﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace yourpriority.Controllers
{
    public class OurServiceController : Controller
    {
        // GET: OurService
        public ActionResult Index()
        {
            return View("~/Views/OurService/Our_Services.cshtml");
        }
        public ActionResult Home_Loans()
        {
            return View();
        }
        public ActionResult Commercial_and_Leasing()
        {
            return View();
        }
        public ActionResult Business_Loans()
        {
            return View();
        }
        public ActionResult Pre_approvals()
        {
            return View();
        }
        public ActionResult Refinancing()
        {
            return View();
        }
        public ActionResult First_Home_Buyers()
        {
            return View();
        }
        public ActionResult Investment_Loans()
        {
            return View();
        }
        public ActionResult Construction_Loans()
        {
            return View();
        }
        public ActionResult Deposit_Bonds()
        {
            return View();
        }
        public ActionResult Car_and_Equipment_Finance()
        {
            return View();
        }
    }
}