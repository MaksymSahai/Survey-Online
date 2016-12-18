using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyOnline.DAL.Entities
{
    /// <summary>
    /// Class entity of Questionnaire of survey
    /// </summary>
    public class Questionnaire
    {
        /// <summary>
        /// Gets or sets the unique entity key to be selected by.
        /// </summary>
        public int QuestionnaireId { get; set; }
        /// <summary>
        /// Gets or sets the outside key to selected by.
        /// </summary>
        public int SurveyId { get; set; }
        /// <summary>
        /// Gets or sets the outside key to selected by.
        /// </summary>
        public int QuestionId { get; set; }
        /// <summary>
        /// Gets or sets the outside key to selected by.
        /// </summary>
        public int AnswerVariantId { get; set; }
    }
}
