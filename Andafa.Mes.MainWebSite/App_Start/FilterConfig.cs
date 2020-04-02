using System.Web;
using System.Web.Mvc;

namespace Andafa.Mes.MainWebSite
{
    /// <summary>
    /// filter config
    /// </summary>
    public class FilterConfig
    {
        /// <summary>
        /// register global filters
        /// </summary>
        /// <param name="filters">filters</param>
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}