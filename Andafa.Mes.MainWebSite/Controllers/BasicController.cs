using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Andafa.Mes.MainWebSite.Controllers
{
    /// <summary>
    /// basic web api controller
    /// </summary>
    public class BasicController : ApiController
    {
        
        /// <summary>
        /// test the web api is connectable
        /// </summary>
        /// <returns>web api exist result</returns>
        [HttpGet]
        public bool GetExist()
        {
            return true;
        }
    }
}
