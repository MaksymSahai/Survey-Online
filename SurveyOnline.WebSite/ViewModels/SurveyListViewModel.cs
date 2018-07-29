using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SurveyOnline.WebSite.ViewModels
{
    public class SurveyListViewModel
    {
        public IEnumerable<SurveyViewModel> Surveys { get; set; }
    }
}