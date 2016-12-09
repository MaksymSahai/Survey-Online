﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SurveyOnline.WebSite.Controllers
{
    public class SurveyController : Controller
    {
        /// <summary>
        /// List of customer survey.
        /// </summary>
        /// <returns>Survey list action result.</returns>
        [Authorize]
        public ActionResult List()
        {
            return View();
        }
    }
}