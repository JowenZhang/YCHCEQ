using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Andafa.Mes.MainWebSite.Filters
{
    /// <summary>
    /// valid user
    /// </summary>
    public class ValidUserFilter : ActionFilterAttribute
    {
        /// <summary>
        /// exam user in cookie exist
        /// </summary>
        /// <param name="filterContext">filter content</param>
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            //if cookie exist
            HttpCookie userCookie = System.Web.HttpContext.Current.Request.Cookies.Get("UserInfo");
            if (userCookie == null)
            {
                filterContext.Result = new RedirectResult("/");
            }
        }
    }
}