using SurveyOnline.Core.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SurveyOnline.WebSite.App_Start
{
    public class SurveyCustomRoute : RouteBase
    {
        /// <summary>
        /// Gets controller action and ID by custom url of suvrey if it`s present.
        /// </summary>
        /// <param name="httpContext"></param>
        /// <returns>Controller name, Action naame, id of survey</returns>
        public override RouteData GetRouteData(HttpContextBase httpContext)
        {
            if (httpContext.Request == null || httpContext.Request.Url == null)
                return null;

            var host = httpContext.Request.Url.Host;
            string url = httpContext.Request.Url.AbsolutePath.TrimStart('/');
            string controller = "Survey";
            string action = "Conduct";

            var surveyManager = new SurveyManager();
            var surveyUrl = surveyManager.IsSurveyUrl(url);

            if (!surveyUrl)
                return null;

            var surveyID = surveyManager.GetSurveyIdByUrl(url);
            var routeData = new RouteData(this, new MvcRouteHandler());
            routeData.Values.Add("controller", controller);
            routeData.Values.Add("action", action);
            routeData.Values.Add("id", surveyID);

            return routeData;
        }

        public override VirtualPathData GetVirtualPath(RequestContext requestContext, RouteValueDictionary values)
        {
            return null;
        }
    }
}