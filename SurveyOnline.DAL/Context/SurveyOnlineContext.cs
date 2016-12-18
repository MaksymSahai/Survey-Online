using SurveyOnline.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using SurveyOnline.DAL.Entities;

namespace SurveyOnline.DAL.Context
{
    /// <summary>
    /// Class db context : from asp.net identity db context.
    /// </summary>
    public class SurveyOnlineContext : IdentityDbContext<User>
    {
        /// <summary>
        /// Constructor create db context.
        /// </summary>
        public SurveyOnlineContext()
            : base("SurveyOnlineDB")
        {
        }

        /// <summary>
        /// Constructor create db context using constructor.
        /// </summary>
        /// <returns>New db context.</returns>
        public static SurveyOnlineContext Create()
        {
            return new SurveyOnlineContext();
        }

        /// <summary>
        /// Initialize Survey db context.
        /// </summary>
        public virtual DbSet<Survey> Surveys { get; set; }
        /// <summary>
        /// Initialize QuestionType db context.
        /// </summary>
        public virtual DbSet<QuestionType> QuestionTypes { get; set; }

        /// <summary>
        /// Initialize Question db context.
        /// </summary>
        public virtual DbSet<Question> Questions { get; set; }

        /// <summary>
        /// Initialize AnswerVariant db context.
        /// </summary>
        public virtual DbSet<AnswerVariant> AnswerVariants { get; set; }
    }
}
