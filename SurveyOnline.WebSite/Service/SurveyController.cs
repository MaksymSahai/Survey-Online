using SurveyOnline.WebSite.Factories;
using SurveyOnline.WebSite.ViewModels;
using System.Collections.Generic;
using System.Web.Http;

namespace SurveyOnline.WebSite.Service
{
    public class SurveyController : ApiController
    {
        /// <summary>
        /// Gets list of user Survey by ulr
        /// api/survey
        /// </summary>
        /// <returns>IEnumerable colection of user survey.</returns>
        public IEnumerable<SurveyViewModel> GetSurveyByUser()
        {
            var model = new SurveyListVMFactory();
            return model.Build();
        }
    }
}
