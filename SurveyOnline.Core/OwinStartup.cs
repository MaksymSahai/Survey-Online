using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using SurveyOnline.DAL.Context;
using SurveyOnline.Core.Managers;
using Microsoft.Owin.Security.Cookies;
using Microsoft.AspNet.Identity;

[assembly: OwinStartup(typeof(SurveyOnline.Core.OwinStartup))]

namespace SurveyOnline.Core
{
    public class OwinStartup
    {
        public void Configuration(IAppBuilder app)
        {
            app.CreatePerOwinContext<SurveyOnlineContext>(SurveyOnlineContext.Create);
            app.CreatePerOwinContext<ApplicationUserManager>(ApplicationUserManager.Create);
            app.CreatePerOwinContext<ApplicationSignInManager>(ApplicationSignInManager.Create);

            // Enable the application to use a cookie to store information for the signed in user
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Account/Login")
            });
        }
    }
}
