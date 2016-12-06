using SurveyOnline.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace SurveyOnline.DAL.Context
{
    public class SurveyOnlineContext : IdentityDbContext<User>
    {
        public SurveyOnlineContext()
            : base("SurveyOnlineDB")
        {
        }

        public static SurveyOnlineContext Create()
        {
            return new SurveyOnlineContext();
        }
    }
}
