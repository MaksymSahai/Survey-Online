using SurveyOnline.WebSite.Factories;
using SurveyOnline.WebSite.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            var model = new SurveyListVMFactory();
            var vm = model.Build();
            return View(vm);
        }

        /// <summary>
        /// Detail of survey by id.
        /// </summary>
        /// <param name="id">Survey id.</param>
        /// <returns>Survey detail action result.</returns>
        [Authorize]
        public ActionResult Detail(int id)
        {
            var model = new SurveyDetailVMFactory();
            var vm = model.Build(id, false);
            return View(vm);
        }

        public ActionResult Statistic(int id)
        {
            var model = new SurveyDetailVMFactory();
            var vm = model.Build(id, true);

            return View(vm);
        }

        public ActionResult Conduct(int id)
        {
            var model = new SurveyDetailVMFactory();
            var vm = model.Build(id, false);
            return View(vm);
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult Conduct(SurveyDetailViewModel model)
        {
            if (ModelState.IsValid)
            {
                foreach (var q in model.SurveyQuestions)
                {
                }
                return RedirectToAction("Index", "Home");
            }
            return View(model);
        }

        [Authorize]
        public ActionResult Create()
        {
            return View();
        }
    }
}