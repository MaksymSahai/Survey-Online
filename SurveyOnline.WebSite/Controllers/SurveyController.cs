using SurveyOnline.WebSite.Factories;
using System;
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

        /// <summary>
        /// Detail of survey by id.
        /// </summary>
        /// <param name="id">Survey id.</param>
        /// <returns>Survey detail action result.</returns>
        [Authorize]
        public ActionResult Detail(int id)
        {
            return View();
        }

        public ActionResult Statistic(int id)
        {
            var model = new SurveyDetailVMFactory();
            var vm = model.Build(id, false);

            return View(vm);
        }

        public ActionResult Conduct(int id)
        {
            return View();
        }
    }
}