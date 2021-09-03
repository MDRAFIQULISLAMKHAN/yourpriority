using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Web.Routing;

namespace yourpriority.Controllers
{
    public class ResourcesController : Controller
    {
        // GET: Resources
        public ActionResult Index()
        {
            return View();
        }
        [ActionName("new-customer")]
        public ActionResult New_Customer()
        {
            return View("new-customer");
        }
        public ActionResult News()
        {
            return View("news");
        }
        public ActionResult Calculators()
        {

            return View("calculators");
        }
        public ActionResult Our_Dispute_Resolution_Policy()
        {
            return View("our-dispute-resolution-policy");
        }
        public ActionResult Privacy_Policy()
        {
            return View("privacy-policy");
        }

        public ActionResult Subscribe()
        {
            return View("subscribe");
        }

        // sub pages of News/Blog
        public ActionResult _How_To_Refinance()
        {
            return View("how-to-refinance-to-renovate");
        }

        public ActionResult _Top_Ways_To_Cut_Expenses()
        {
            return View("top-ways-to-cut-expenses-and-increase-savings-for-your-house-deposit");
        }

        public ActionResult _Rentvesting()
        {
            return View("rentvesting");
        }

        public ActionResult _Your_First_Meeting()
        {
            return View("your-first-meeting-with-a-broker");
        }

        public ActionResult _Five_Ways_To_Fund()
        {
            return View("five-ways-to-fund-a-renovation");
        }

        public ActionResult _What_Is_Lmi()
        {
            return View("what-is-lmi3f");
        }

        public ActionResult _What_Are_The_Extra_Cost()
        {
            return View("what-are-the-extra-costs-of-buying-a-home3f");
        }

        public ActionResult _2020_Christmas_Office_Closure_Dates()
        {
            return View("2020-christmas-office-closure-dates");
        }

        public ActionResult _Your_Property_Invest_Checking()
        {
            return View("your-property-investing-checklist");
        }

        public ActionResult _Three_Key_Triggers()
        {
            return View("three-key-triggers-telling-you-to-get-a-depreciation-schedule");
        }

        public ActionResult _How_Rba_Rate()
        {
            return View("how-rba-rate-changes-affect-your-interest-rate");
        }

        public ActionResult _Another_Rba_Rate()
        {
            return View("another-rba-rate-cut21");
        }

        public ActionResult _RBA_Rate_Cut()
        {
            return View("rba-rate-cut21");
        }

        public ActionResult _APRA_Process()
        {
            return View("apra-proposes-regulation-changes-to-help-new-Home-Loan-customers");
        }

        public ActionResult _What_To_Consider()
        {
            return View("what-to-consider-when-buying-a-second-property");
        }

        public ActionResult _Stamp_Duty_Explained()
        {
            return View("stamp-duty-explained");
        }

        public ActionResult _Why_Should_I_Make()
        {
            return View("why-should-i-make-extra-repayments-on-my-home-loan3f");
        }

        public ActionResult _Five_Questions_Potentials()
        {
            return View("five-questions-potential-first-home-buyers-should-ask-themselves");
        }

        public ActionResult _Comparing_Apples()
        {
            return View("comparing-apples-with-apples3a-comparison-rates-explained");
        }

        public ActionResult _Inspection_Checklist()
        {
            return View("Inspection-checklist");
        }

        public ActionResult _When_Is_The_Best()
        {
            return  View("when-is-the-best-time-to-refinance-your-home-loan3f");
        }

        public ActionResult _Thinking_Of_Buying()
        {
            return View("thinking-of-buying-off-the-plan3f-Read-this-first.");
        }

        public ActionResult _Dont_Kill_Competition()
        {
            return View("don27t-kill-competition");
        }

        public ActionResult _Why_Some_Interest()
        {
            return View("why-some-interest-only-borrowers-are-keen-to-switch");
        }

    }
}