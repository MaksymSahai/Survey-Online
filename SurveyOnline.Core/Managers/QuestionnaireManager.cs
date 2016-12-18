using SurveyOnline.DAL.Interfaces;
using SurveyOnline.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyOnline.Core.Managers
{
    public class QuestionnaireManager
    {
        private IQuestionnaireRepository repository = new QuestionnaireRepository();

        public int GetAnswerCount(int surveyID, int asnwerVariantID)
        {
            return repository.Questionnaires.Where(s => s.SurveyId == surveyID && s.AnswerVariantId == asnwerVariantID).Count();
        }
    }
}
