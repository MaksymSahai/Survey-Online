using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SurveyOnline.WebSite.ViewModels
{
    public class QuestionAnswersViewModel
    {
        /// <summary>
        /// Gets or sets the unique entity key to be selected by.
        /// </summary>
        public int AnswerVariantId { get; set; }
        /// <summary>
        /// Gets or sets the name of variant answer.
        /// </summary>
        public string AnswerVariantName { get; set; }
        /// <summary>
        /// Gets or sets the count of answers to this answer vatiant.
        /// </summary>
        public int AnswerVariantCount { get; set; }
    }
}