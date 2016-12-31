using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyOnline.DAL.Entities
{
    /// <summary>
    /// Class entity of questions
    /// </summary>
    public class Question
    {
        /// <summary>
        /// Gets or sets the unique entity key to be selected by.
        /// </summary>
        public int QuestionId { get; set; }
        /// <summary>
        /// Gets or sets the outside key to selected by.
        /// </summary>
        public int SurveyId { get; set; }
        /// <summary>
        /// Gets or sets the name of questions.
        /// </summary>
        public string QuestionName { get; set; }
        /// <summary>
        /// Gets or sets the outside key to selected by.
        /// </summary>
        public int QuestionTypeId { get; set; }
        public string SelectedAnswer { set; get; }
    }
}
