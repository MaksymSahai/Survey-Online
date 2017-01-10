using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SurveyOnline.WebSite.Controllers
{
    public class ContentController : Controller
    {
        // GET: Content
        public ActionResult Faq()
        {
            return View();
        }

        public ActionResult Howit()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}