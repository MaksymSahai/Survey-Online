using SurveyOnline.DAL.Context;
using SurveyOnline.DAL.Entities;
using SurveyOnline.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyOnline.DAL.Repositories
{
    public class SurveyRepository : ISurveyRepository
    {
        SurveyOnlineContext context = new SurveyOnlineContext();

        public IEnumerable<Survey> Surveys
        {
            get { return context.Surveys; }
        }
    }
}
