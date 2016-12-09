using Microsoft.AspNet.Identity;
using SurveyOnline.DAL.Entities;
using System.Web;

namespace SurveyOnline.WebSite.ViewModels
{
    public class SurveyViewModel
    {
        /// <summary>
        /// Gets or sets the unique entity key to be selected by.
        /// </summary>
        public int SurveyId { get; set; }
        /// <summary>
        /// Gets or sets the name of survey.
        /// </summary>
        public string SurveyName { get; set; }
        /// <summary>
        /// Gets or sets the full description.
        /// </summary>
        public string SurveyDescription { get; set; }
        /// <summary>
        /// Gets or sets status of survey.
        /// </summary>
        public string SurveyStatus { get; set; }
        /// <summary>
        /// Gets or sets custom url for survey.
        /// </summary>
        public string SurveyUrl { get; set; }
        /// <summary>
        /// Gets or sets the user key to be selected by.
        /// </summary>
        public string UserId { get; set; }

        public static implicit operator SurveyViewModel(Survey dm)
        {
            var vm = new SurveyViewModel();

            vm.SurveyId = dm.SurveyId;
            vm.SurveyName = dm.SurveyName;
            vm.SurveyDescription = dm.SurveyDescription;
            if (dm.SurveyStatus)
                vm.SurveyStatus = "open";
            vm.SurveyStatus = "closed";
            vm.SurveyUrl = dm.SurveyUrl;
            vm.UserId = dm.UserId;
            
            return vm;
        }

        public static implicit operator Survey(SurveyViewModel vm)
        {
            var dm = new Survey();

            dm.SurveyId = vm.SurveyId;
            dm.SurveyName = vm.SurveyName;
            dm.SurveyDescription = vm.SurveyDescription;
            dm.SurveyStatus = false;
            dm.SurveyUrl = vm.SurveyUrl;
            dm.UserId = HttpContext.Current.User.Identity.GetUserId(); 

            return dm;
        }
    }
}