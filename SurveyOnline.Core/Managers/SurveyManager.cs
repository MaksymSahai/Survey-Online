using SurveyOnline.DAL.Context;
using SurveyOnline.DAL.Entities;
using SurveyOnline.DAL.Interfaces;
using SurveyOnline.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyOnline.Core.Managers
{
    public class SurveyManager
    {
        private ISurveyRepository repository = new SurveyRepository();

        /// <summary>
        /// Gest IEnumerable colection of survey by current user.
        /// </summary>
        /// <param name="userID">Current user Id.</param>
        /// <returns>IEnumerable colection of survey.</returns>
        public IEnumerable<Survey> GetUserSurveys(string userID)
        {
            var model = repository.Surveys.OrderBy(survey => survey.SurveyId).Where(survey => survey.UserId == userID);

            if (!model.Any())
                return null;

            return model;
        }

        /// <summary>
        /// Gets Survey by user id and survey id.
        /// </summary>
        /// <param name="surveyID">Survey ID.</param>
        /// <param name="userID">Current user ID.</param>
        /// <returns>Surey by user and ID.</returns>
        public Survey GetSurveyIdByID(int surveyID, string userID)
        {
            var model = repository.Surveys.OrderBy(survey => survey.SurveyId).Where(survey => survey.UserId == userID && survey.SurveyId == surveyID).First();

            if (model == null)
                return null;

            return model;
        }

        /// <summary>
        /// Gets boolean value is url is custom survey url.
        /// </summary>
        /// <param name="surveyUrl">requested url to check is it custom survey url.</param>
        /// <returns>Bool value is requested url is custom survey url.</returns>
        public bool IsSurveyUrl(string surveyUrl)
        {
            SurveyOnlineContext db = new SurveyOnlineContext();
            var isCustomUrl = db.Surveys.FirstOrDefault(u => u.SurveyUrl == surveyUrl);
            if (isCustomUrl != null)
                return true;
            return false;
        }

        /// <summary>
        /// Gets survey Id by url.
        /// </summary>
        /// <param name="surveyUrl">Survey url to shearch.</param>
        /// <returns>Survey ID by url.</returns>
        public int GetSurveyIdByUrl(string surveyUrl)
        {
            SurveyOnlineContext db = new SurveyOnlineContext();
            var surveyID = db.Surveys.FirstOrDefault(u => u.SurveyUrl == surveyUrl).SurveyId;
            return surveyID;
        }
    }
}
