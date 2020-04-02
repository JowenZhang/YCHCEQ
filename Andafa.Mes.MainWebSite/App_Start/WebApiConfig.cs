using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Web.Http;

namespace Andafa.Mes.MainWebSite
{
    /// <summary>
    /// web api config
    /// </summary>
    public static class WebApiConfig
    {
        /// <summary>
        /// web api config
        /// </summary>
        /// <param name="config">http config</param>
        public static void Register(HttpConfiguration config)
        {
            config.Formatters.Clear();
            config.Formatters.Add(new JsonMediaTypeFormatter());

            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{pmsStr}",
                defaults: new { action = RouteParameter.Optional, pmsStr = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "AdoApi",
                routeTemplate: "api/{controller}/{action}/{sqlFileName}/{sqlId}/{pmsStr}",
                defaults: new { pmsStr = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "PageApi",
                routeTemplate: "api/{controller}/{pageIndex}/{pageSize}"
            );
        }
    }
}
