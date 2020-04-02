using Andafa.Mes.Bll;
using Andafa.Mes.Bll.WebApiBll;
using Andafa.Mes.MainWebSite.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Andafa.Mes.MainWebSite.Controllers
{
    /// <summary>
    /// ado controller
    /// </summary>
    public class AdoController : ApiController
    {
        /// <summary>
        /// query int
        /// </summary>
        /// <param name="sqlFileName">sql file name</param>
        /// <param name="sqlId">sql id</param>
        /// <param name="pmsObj">query parameters object</param>
        /// <returns>int result</returns>
        [HttpPost]
        //[Route("api/ado/post/{sqlFileName}/{sqlId}")]
        public int Post(string sqlFileName, string sqlId, [FromBody]object pmsObj)
        {
            List<Dictionary<string, object>> pmsList = pmsObj as List<Dictionary<string, object>>;
            if (pmsList == null || pmsList.Count <= 0)
            {
                Dictionary<string, object> pms = pmsObj as Dictionary<string, object>;
                if (pms != null && pms.Count > 0)
                {
                    pmsList.Add(pms);
                }
                else
                {
                    return -200;
                }
            }
            WebApiBasicBll bll = new WebApiBasicBll();
            return bll.QueryInt(sqlFileName, sqlId, pmsList);
        }

        /// <summary>
        /// query record
        /// </summary>
        /// <param name="sqlFileName">sql file name</param>
        /// <param name="sqlId">sql id</param>
        /// <param name="pmsStr">query parameters string</param>
        /// <returns>record</returns>
        [HttpGet]
        //[Route("api/ado/getdict/{sqlFileName}/{sqlId}?pmsStr={pmsStr}")]
        public Dictionary<string, object> GetDict(string sqlFileName, string sqlId, string pmsStr)
        {
            WebApiBasicBll bll = new WebApiBasicBll();
            return bll.QueryRecord(sqlFileName, sqlId, ControllerTool.ConvertPms(pmsStr));
        }

        /// <summary>
        /// query record list
        /// </summary>
        /// <param name="sqlFileName">sql file name</param>
        /// <param name="sqlId">sql id</param>
        /// <param name="pmsStr">query parameters string</param>
        /// <returns>record list</returns>
        [HttpGet]
        //[Route("api/ado/getdictlist/{sqlFileName}/{sqlId}?pmsStr={pmsStr}")]
        public List<Dictionary<string, object>> GetDictList(string sqlFileName, string sqlId, string pmsStr)
        {
            WebApiBasicBll bll = new WebApiBasicBll();
            return bll.QueryRecordList(sqlFileName, sqlId, ControllerTool.ConvertPms(pmsStr));
        }

        /// <summary>
        /// query object list
        /// </summary>
        /// <param name="sqlFileName">sql file name</param>
        /// <param name="sqlId">sql id</param>
        /// <param name="pmsStr">query parameters string</param>
        /// <returns></returns>
        [HttpGet]
        //[Route("api/ado/getobj/{sqlFileName}/{sqlId}?pmsStr={pmsStr}")]
        public object GetObj(string sqlFileName, string sqlId, string pmsStr)
        {
            WebApiBasicBll bll = new WebApiBasicBll();
            return bll.QueryObj(sqlFileName, sqlId, ControllerTool.ConvertPms(pmsStr));
        }
    }
}
