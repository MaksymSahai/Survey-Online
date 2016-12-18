using SurveyOnline.DAL.Context;
using SurveyOnline.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyOnline.DAL.Repositories
{
    public class QuestionRepository : IQuestionRepository
    {
        SurveyOnlineContext context = new SurveyOnlineContext();

        public IEnumerable<Question> Questions
        {
            get { return context.Questions; }
        }
    }
}
