using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using yourpriority.Models;

namespace yourpriority.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult MaiResult(Contact pv)
        {

            var jsonString = JsonConvert.SerializeObject(pv);
            pv = JsonConvert.DeserializeObject<Contact>(jsonString);

            try
            {
                string body = string.Empty;
                body += "Hi Team,";
                body += "<br/> This is from ByteHeart Contact us enquiry:";
                body += "<br/>Name: " + pv.Name;
                body += "<br/>Email: " + pv.Email;
                body += "<br/>Phone: " + pv.Phone;
                body += "<br/>Office: " + pv.Office;
                body += "<br/>Refference: " + pv.Refference;
                body += "<br/>Message: " + pv.Message;
                body += "<br/> Date: " + DateTime.Now.ToString("dd MMM yyyy");

                bool hasWords = HasBadWords(pv.Message);

                if (hasWords == false)
                {
                    var client = new SmtpClient("smtp.gmail.com", 587)
                    {
                        Credentials = new NetworkCredential("test.sgff@gmail.com", "testingg"),
                        EnableSsl = true
                    };
                    client.Send("test.sgff@gmail.com", "sagorkhan.fts@gmail.com", "test", body);
                }
            }
            catch (Exception ex)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("<div class=\"alert alert-success\" id=\"contactSuccess\">");
                sb.AppendFormat(" <strong>Error!</strong> There was an error sending your message.{0} - {1}", ex.Message, ex.InnerException?.Message);
                sb.AppendFormat("<span class=\"font-size-xs mt-sm display-block\" id=\"mailErrorMessage\"></span>");
                sb.AppendFormat("</div>");
                pv.EmailStatus = sb.ToString();
            }

            return View("~/Views/Contact/Index.cshtml",pv);
        }
        public bool HasBadWords(string inputWords)
        {
            Regex wordFilter = new Regex("(eаrn mоnеy оnlinе|mystrikingly|makemoney|earnmoney|sеx|adult|fucк|dating|woman|girls)");
            return wordFilter.IsMatch(inputWords.ToLower());
        }

       
    }
}