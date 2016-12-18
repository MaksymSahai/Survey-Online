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

        /// <summary>
        /// Gets detail of survey. Colection survey questions, Collection question answers.
        /// </summary>
        /// <param name="id">Survey id.</param>
        /// <returns>Survey details.</returns>
        public SurveyDetailViewModel GetSurveyDetail(int id)
        {
            //if (id <= 0)
            //    return HttpNotFound();

            var model = new SurveyDetailVMFactory();
            return model.Build(id, true);
        }

    }
}
