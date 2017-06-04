using System;
using System.Configuration;
using System.Net;
using AdamsFirstMVC.DAL;
using System.Web.Mvc;
using System.Net.Mail;
using System.Text;
using AdamsFirstMVC.Models;
using CaptchaMvc.HtmlHelpers;

namespace AdamsFirstMVC.Controllers
{
    public class MandMController : Controller
    {
        private readonly BandsUnitOfWork _bandsUnitOfWork;
        private readonly AboutUnitOfWork _aboutUnitOfWork;
        private readonly DJUnitOfWork _dJUnitOfWork;

        public MandMController()
        {
            _bandsUnitOfWork = new BandsUnitOfWork();
            _aboutUnitOfWork = new AboutUnitOfWork();
            _dJUnitOfWork = new DJUnitOfWork();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View(_aboutUnitOfWork);
        }

        public ActionResult Bands()
        {
            return View(_bandsUnitOfWork);
        }
        public ActionResult DJs()
        {
            return View(_dJUnitOfWork);
        }

        public ActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Contact(Contact contact)
        {
            if (this.IsCaptchaValid("Validate your Captcha"))
                ViewBag.ErrMessage = "Validation Message";

            if (ModelState.IsValid)
            {
                try
                {
                    MailMessage msg = new MailMessage();
                    SmtpClient smtp = new SmtpClient();
                    StringBuilder sb = new StringBuilder();
                    MailAddress from = new MailAddress(ConfigurationManager.AppSettings["smtpFromAddress"]);

                    smtp.Host = ConfigurationManager.AppSettings["smtpHost"];
                    smtp.EnableSsl =  Convert.ToBoolean(ConfigurationManager.AppSettings["smtpSsl"]);
                    smtp.Port = Convert.ToInt16(ConfigurationManager.AppSettings["smtpPort"]);
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.Credentials = new NetworkCredential(ConfigurationManager.AppSettings["smtpEmail"],
                        ConfigurationManager.AppSettings["smtpPassword"]);

                    sb.Append("First name: " + contact.FirstName);
                    sb.Append(Environment.NewLine);
                    sb.Append("Last name: " + contact.LastName);
                    sb.Append(Environment.NewLine);
                    sb.Append("Email: " + contact.Email);
                    sb.Append(Environment.NewLine);
                    sb.Append("Comments: " + contact.Comment);

                    msg.To.Add(ConfigurationManager.AppSettings["smtpToAddresses"]);
                    msg.From = from;
                    msg.Subject = "Contact Us";
                    msg.IsBodyHtml = false;
                    msg.Body = sb.ToString();
                    smtp.Send(msg);
                    msg.Dispose();
                    return View("Success");
                }
                catch (Exception e)
                {
                    return View("Error");
                }
            }
            return View();
        }
    }
}