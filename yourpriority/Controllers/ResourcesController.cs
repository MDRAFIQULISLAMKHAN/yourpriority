using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;

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

        // sub pages of News/Blog
        public ActionResult _How_To_Refinance()
        {
            return View();
        }

        public ActionResult _Top_Ways_To_Cut_Expenses()
        {
            return View();
        }

        public ActionResult _Rentvesting()
        {
            return View();
        }

        public ActionResult _Your_First_Meeting()
        {
            return View();
        }

        public ActionResult _Five_Ways_To_Fund()
        {
            return View();
        }

        public ActionResult _What_Is_Lmi()
        {
            return View();
        }

        public ActionResult _What_Are_The_Extra_Cost()
        {
            return View();
        }

        public ActionResult _2020_Christmas_Office_Closure_Dates()
        {
            return View();
        }

        public ActionResult _Your_Property_Invest_Checking()
        {
            return View();
        }

        public ActionResult _Three_Key_Triggers()
        {
            return View();
        }

        public ActionResult _How_Rba_Rate()
        {
            return View();
        }

        public ActionResult _Another_Rba_Rate()
        {
            return View();
        }
    }
}