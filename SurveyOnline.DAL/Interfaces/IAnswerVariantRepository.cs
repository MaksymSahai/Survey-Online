using SurveyOnline.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyOnline.DAL.Interfaces
{
    public interface IAnswerVariantRepository
    {
        /// <summary>
        /// Gets list of answer variants.
        /// </summary>
        IEnumerable<AnswerVariant> AnswerVariants { get; }
    }
}
