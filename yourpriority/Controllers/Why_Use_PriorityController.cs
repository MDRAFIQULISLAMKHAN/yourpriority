using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace yourpriority.Controllers
{
    public class Why_Use_PriorityController : Controller
    {
        // GET: Why_Use_Priority
        public ActionResult Why_use_Priority()
        {
            return View("why-use-priority");
        }

        public ActionResult Application_Process()
        {
            return View("application-process");
        }

        public ActionResult Testimonial()
        {
            return View("testimonial");
        }

        public ActionResult What()
        {
            return View("why-use-priority");
        }
    }
}