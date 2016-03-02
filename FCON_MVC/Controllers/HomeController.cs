using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Mail;
using FCON_MVC.Models;
using System.Text;


namespace FCON_MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Please Login";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "or Manufacturing Request System";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
       

            [HttpPost]
            public ActionResult Contact(ContactModels c)
            {
                if (ModelState.IsValid)
                {
                    try
                    {
                        MailMessage msg = new MailMessage();
                        SmtpClient client = new SmtpClient();
                        StringBuilder sb = new StringBuilder();
                        msg.To.Add("confidential");
                        msg.Subject = "Issue Report";
                        msg.IsBodyHtml = false;
                        client.Host = "smtp.gmail.com";
                        client.Port = 587;
                        client.EnableSsl = true;
                        client.DeliveryMethod = SmtpDeliveryMethod.Network;
                        client.Credentials = new System.Net.NetworkCredential("private", "extra-private");
                        sb.Append("In-Game Name: " + c.InGameName);
                        sb.Append(Environment.NewLine);
                        sb.Append("Comments: " + c.Comment);
                        msg.Body = sb.ToString();
                        client.Send(msg);

                        msg.Dispose();
                        return View("Success");
                    }
                    catch (Exception)
                    {
                        return View("");
                    }
                }
                return View();
            }
        }
    }
