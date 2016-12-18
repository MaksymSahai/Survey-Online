using SurveyOnline.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyOnline.DAL.Interfaces
{
    public interface IQuestionnaireRepository
    {
        /// <summary>
        /// Gets list of Questionnaire.
        /// </summary>
        IEnumerable<Questionnaire> Questionnaires { get; }
    }
}
