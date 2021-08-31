using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace yourpriority.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        public ActionResult Index()
        {
            return View("~/Views/About/Priority_History.cshtml");
        }

        public ActionResult Priority_History()
        {
            return View();
        }
        public ActionResult meet_the_team()
        {
            return View();
        }
        public ActionResult Lenders()
        {
            return View();
        }

    }
}