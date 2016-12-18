using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyOnline.DAL.Entities
{
    /// <summary>
    /// Class entity of types questions
    /// </summary>
    public class QuestionType
    {
        /// <summary>
        /// Gets or sets the unique entity key to be selected by.
        /// </summary>
        public int QuestionTypeId { get; set; }
        /// <summary>
        /// Gets or sets the name of question type
        /// </summary>
        public string QuestionTypeName { get; set; }
        /// <summary>
        /// Gets or Sets question type description.
        /// </summary>
        public string QuestionTypeDescription { get; set; }
    }
}
