using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SurveyOnline.WebSite.ViewModels
{
    /// <summary>
    /// Class contains all field for view page contact us.
    /// </summary>
    public class EmailModelViewModel
    {
        /// <summary>
        /// Subject of mail.
        /// </summary>
        [Required(ErrorMessage = "Поле обов'язкове для заповнення")]
        [MaxLength(150)]
        public string Subject { get; set; }
        /// <summary>
        /// Gets or sets user name for email.
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// From address in mail.
        /// </summary>
        [Required(ErrorMessage = "Поле обов'язкове для заповнення")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Невірний формат електронної адреси")]
        [MaxLength(150)]
        public string From { get; set; }
        /// <summary>
        /// Body of mail.
        /// </summary>
        [Required(ErrorMessage = "Поле обов'язкове для заповнення")]
        [DataType(DataType.MultilineText)]
        public string Body { get; set; }
    }
}