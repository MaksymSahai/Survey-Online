using AutoMapper;
using Microsoft.AspNet.Identity;
using SurveyOnline.Core.Managers;
using SurveyOnline.DAL.Entities;
using SurveyOnline.WebSite.ViewModels;
using System.Collections.Generic;
using System.Web;

namespace SurveyOnline.WebSite.Factories
{
    public class SurveyListVMFactory
    {
        /// <summary>
        /// Build survey list view model from db.
        /// </summary>
        /// <returns>IEnumerable colection of user survey in vm format.</returns>
        public IEnumerable<SurveyViewModel> Build()
        {
            var surveyManager = new SurveyAPI();
            var userID = HttpContext.Current.User.Identity.GetUserId();
            var dm = surveyManager.GetUserSurveys(userID);

            Mapper.Initialize(cfg => cfg.CreateMap<Survey, SurveyViewModel>());
            IEnumerable<SurveyViewModel> surveyVM = Mapper.Map<IEnumerable<Survey>, IEnumerable<SurveyViewModel>>(dm);

            return surveyVM;
        }
    }
}