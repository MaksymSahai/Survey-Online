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
    public class AnswerVariantRepository : IAnswerVariantRepository
    {
        SurveyOnlineContext context = new SurveyOnlineContext();

        public IEnumerable<AnswerVariant> AnswerVariants
        {
            get { return context.AnswerVariants; }
        }
    }
}
