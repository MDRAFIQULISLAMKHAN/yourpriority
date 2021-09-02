using System;
using System.Collections.Generic;
using System.IO;
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

            /*string body = string.Empty;
            using (StreamReader reader = new StreamReader(Server.MapPath("~/Views/Email_Templates/User_success_email.cshtml")))
            {
                body = reader.ReadToEnd();
            }
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
            
            body = body.Replace("{Name}", pv.Name);
            body = body.Replace("{Email}", pv.Email);
            body = body.Replace("{Phone}", pv.Phone);
            body = body.Replace("{Office}", pv.Office);
            body = body.Replace("{Refference}", pv.Refference);
            body = body.Replace("{Message}", pv.Message);

            using (MailMessage mailMessage = new MailMessage())
            {
                mailMessage.From = new MailAddress(pv.Name);
                mailMessage.Subject = "New User";
                mailMessage.Body = body;
                mailMessage.IsBodyHtml = true;
                mailMessage.To.Add(new MailAddress("sagorkhan.fts@gmail.com"));
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "test.sgff@gmail.com";
                smtp.EnableSsl = true;
                System.Net.NetworkCredential NetworkCred = new System.Net.NetworkCredential();
                NetworkCred.UserName = "test.sgff@gmail.com";
                NetworkCred.Password = "testingg";
                smtp.UseDefaultCredentials = true;
                smtp.Credentials = NetworkCred;
                smtp.Port = 587;
                smtp.Send(mailMessage);
            }

            return View("~/Views/Contact/Index.cshtml", pv);*/


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