using System.ComponentModel.DataAnnotations;

namespace SurveyOnline.DAL.Entities
{
    public class Survey
    {
        /// <summary>
        /// Gets or sets the unique entity key to be selected by.
        /// </summary>
        [Key]
        [Required]
        public int SurveyId { get; set; }
        /// <summary>
        /// Gets or sets the name of survey.
        /// </summary>
        [Required]
        [MaxLength(250)]
        public string SurveyName { get; set; }
        /// <summary>
        /// Gets or sets the full description.
        /// </summary>
        [Required]
        public string SurveyDescription { get; set; }
        /// <summary>
        /// Gets or sets status of survey.
        /// </summary>
        [Required]
        public bool SurveyStatus { get; set; }
        /// <summary>
        /// Gets or sets custom url for survey.
        /// </summary>
        [Required]
        [MaxLength(50)]
        public string SurveyUrl { get; set; }
        /// <summary>
        /// Gets or sets the user key to be selected by.
        /// </summary>
        [Required]
        public string UserId { get; set; }
    }
}
