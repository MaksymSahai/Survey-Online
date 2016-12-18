using SurveyOnline.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyOnline.DAL.Repositories
{
    public interface IQuestionRepository
    {
        /// <summary>
        /// Gets list of questions.
        /// </summary>
        IEnumerable<Question> Questions { get; }
    }
}
