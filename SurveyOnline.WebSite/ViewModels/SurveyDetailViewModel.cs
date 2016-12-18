using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SurveyOnline.WebSite.ViewModels
{
    /// <summary>
    /// Class contains view model for page survey details.
    /// </summary>
    public class SurveyDetailViewModel
    {
        /// <summary>
        /// Gets or sets survey name.
        /// </summary>
        public string SurveyName { get; set; }
        /// <summary>
        /// Gets or sets survey description.
        /// </summary>
        public string SurveyDescription { get; set; }
        /// <summary>
        /// Gets or sets survey status.
        /// </summary>
        public bool SurveyStatus { get; set; }
        /// <summary>
        /// Gets or Sets count questions of survey.
        /// </summary>
        public int SurvewyQuestionsCount { get; set; }
        /// <summary>
        /// Gets or Sets IEnumerable collection questions of survey.
        /// </summary>
        public IEnumerable<SurveyQuestionsViewModel> SurveyQuestions { get; set; }
    }
}