using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SurveyOnline.WebSite.ViewModels
{
    public class SurveyQuestionsViewModel
    {
        public int QuestionId { get; set; }
        public string QuestionName { get; set; }
        public int QuestionTypeId { get; set; }
        public IEnumerable<QuestionAnswersViewModel> AnswersVariants { get; set; }
    }
}