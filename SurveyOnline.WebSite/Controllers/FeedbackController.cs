using SurveyOnline.WebSite.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace SurveyOnline.WebSite.Controllers
{
    public class FeedbackController : Controller
    {
        /// <summary>
        /// Controller contains logic of sending mails.
        /// </summary>
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }
            [HttpPost]
            [ValidateAntiForgeryToken]
            public async Task<ActionResult> Index(EmailModelViewModel model)
            {
                if (ModelState.IsValid)
                {
                    var body = "<p>Email From: {0} ({1})</p><p>Message:</p><p>{2}</p>";
                    var message = new MailMessage();
                    message.To.Add(new MailAddress("recipient@gmail.com"));  // replace with valid value 
                    message.From = new MailAddress("sender@outlook.com");  // replace with valid value
                    message.Subject = string.Format(model.Subject);
                    message.Body = string.Format(body, model.UserName, model.From, model.Body);
                    message.IsBodyHtml = true;

                    using (var smtp = new SmtpClient())
                    {
                        await smtp.SendMailAsync(message);
                        return RedirectToAction("Sent");
                    }
                }
                return View(model);
            }

            public ActionResult Sent()
            {
                return View();
            }
        }
}