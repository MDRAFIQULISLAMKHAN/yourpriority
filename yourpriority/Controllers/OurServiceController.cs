using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace yourpriority.Controllers
{
    public class OurServiceController : Controller
    {
        // GET: OurService
        public ActionResult Our_Services()
        {
            return View("our-services");
        }
        public ActionResult Home_Loans()
        {
            return View("home-loans");
        }
        public ActionResult Commercial_and_Leasing()
        {
            return View("commercial-and-leasing");
        }
        public ActionResult Business_Loans()
        {
            return View("business-loans");
        }
        public ActionResult Pre_approvals()
        {
            return View("pre-approvals");
        }
        public ActionResult Refinancing()
        {
            return View("refinancing");
        }
        public ActionResult First_Home_Buyers()
        {
            return View("first-home-buyers");
        }
        public ActionResult Investment_Loans()
        {
            return View("investment-loans");
        }
        public ActionResult Construction_Loans()
        {
            return View("construction-loans");
        }
        public ActionResult Deposit_Bonds()
        {
            return View("deposit-bonds");
        }
        public ActionResult Car_and_Equipment_Finance()
        {
            return View("car-and-equipment-finance");
        }

        public ActionResult What_Comes_First()
        {
            return View("what-comes-first");
        }
    }
}