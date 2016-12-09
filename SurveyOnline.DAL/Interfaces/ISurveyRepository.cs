using SurveyOnline.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyOnline.DAL.Interfaces
{
    public interface ISurveyRepository
    {
        /// <summary>
        /// Gets list of surveys.
        /// </summary>
        IEnumerable<Survey> Surveys { get; }
    }
}
