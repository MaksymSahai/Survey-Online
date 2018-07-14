using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyOnline.DAL.Entities
{
    public class AnswerVariant
    {
        /// <summary>
        /// Gets or sets the unique entity key to be selected by.
        /// </summary>
        public int AnswerVariantId { get; set; }
        /// <summary>
        /// Gets or sets the outside key to selected by.
        /// </summary>
        public int QuestionId { get; set; }
        /// <summary>
        /// Gets or sets the name of variant answer.
        /// </summary>
        public string AnswerVariantName { get; set; }
    }
}
