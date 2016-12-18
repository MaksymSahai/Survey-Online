using System;
using SurveyOnline.DAL.Entities;
using SurveyOnline.DAL.Interfaces;
using SurveyOnline.DAL.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyOnline.Core.Managers
{
    public class AnswerVariantManager
    {
        private IAnswerVariantRepository repository = new AnswerVariantRepository();

        public IEnumerable<AnswerVariant> GetAnswerVariants(int questionID)
        {
            return repository.AnswerVariants.Where(question => question.QuestionId == questionID);
        }
    }
}
