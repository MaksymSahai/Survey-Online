using SurveyOnline.DAL.Entities;
using SurveyOnline.DAL.Interfaces;
using SurveyOnline.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyOnline.Core.Managers
{
    public class QuestionAPI
    {
        private IQuestionRepository repository = new QuestionRepository();

        public int GetCountQuestions(int surveyID)
        {
            return repository.Questions.Where(survey => survey.SurveyId == surveyID).Count();
        }

        public IEnumerable<Question> GetQuestions(int surveyID)
        {
            return repository.Questions.Where(survey => survey.SurveyId == surveyID);
        }
    }
}
