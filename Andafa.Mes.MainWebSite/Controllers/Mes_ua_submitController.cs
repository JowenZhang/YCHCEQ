using Andafa.Mes.Bll.WebApiBll;
using Andafa.Mes.Common.Tools;
using Andafa.Mes.MainWebSite.Tools;
using Model.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Andafa.Mes.MainWebSite.Controllers
{
    /// <summary>
    /// mes_ua_submit webapi controller
    /// </summary>
    public class Mes_ua_submitController : ApiController
    {
        /// <summary>
        /// read single model
        /// </summary>
        /// <param name="pmsStr">web api parameters string</param>
        /// <returns>model</returns>
        [HttpGet]
        //[Route("api/{controller}/getsingle?pmsStr={pmsStr}")]
        public Mes_ua_submit GetSingle(string pmsStr)
        {
            WebApiBasicBll bll = new WebApiBasicBll();
            return bll.ReadModelByPms<Mes_ua_submit>(ControllerTool.ConvertPms(pmsStr));
        }

        /// <summary>
        /// read model list
        /// </summary>
        /// <param name="pmsStr">web api parameters string</param>
        /// <returns>model list</returns>
        [HttpGet]
        //[Route("api/{controller}")]
        public List<Mes_ua_submit> GetIndex()
        {
            WebApiBasicBll bll = new WebApiBasicBll();
            return bll.Index<Mes_ua_submit>();
        }

        /// <summary>
        /// read model list
        /// </summary>
        /// <param name="pmsStr">web api parameters string</param>
        /// <returns>model list</returns>
        /// api/{controller}/{pmsStr}
        [HttpGet]
        //[Route("api/{controller}/getlist?pmsStr={pmsStr}")]
        public List<Mes_ua_submit> GetList(string pmsStr)
        {
            Dictionary<string, object> pms = ControllerTool.ConvertPms(pmsStr);
            WebApiBasicBll bll = new WebApiBasicBll();
            if (pms == null || pms.Count <= 0)
            {
                return null;
            }
            else
            {
                return bll.ReadModelListByPms<Mes_ua_submit>(pms);
            }
        }

        /// <summary>
        /// create model
        /// </summary>
        /// <param name="modelObj">model object</param>
        /// api/{controller}
        [HttpPost]
        //[Route("api/{controller}")]
        public void Post([FromBody]object modelObj)
        {
            WebApiBasicBll bll = new WebApiBasicBll();
            bll.CreateByModel(ModelTool.ChangeObjectToList<Mes_ua_submit>(modelObj));
        }

        /// <summary>
        /// update model
        /// </summary>
        /// <param name="modelObj">model object</param>
        [HttpPut]
        //[Route("api/{controller}")]
        public void Put([FromBody]object modelObj)
        {
            WebApiBasicBll bll = new WebApiBasicBll();
            bll.UpdateByModel(ModelTool.ChangeObjectToList<Mes_ua_submit>(modelObj));
        }

        /// <summary>
        /// delete model
        /// </summary>
        /// <param name="pmsObj">web api parameter object</param>
        [HttpDelete]
        //[Route("api/{controller}")]
        public void Delete([FromBody]object pmsObj)
        {
            WebApiBasicBll bll = new WebApiBasicBll();
            bll.DeleteModelByPms<Mes_ua_submit>(ModelTool.ChangeObjectToList<Dictionary<string, object>>(pmsObj));
        }

        /// <summary>
        /// get page
        /// </summary>
        /// <param name="pageIndex">page index</param>
        /// <param name="pageSize">page size</param>
        /// <returns>page result</returns>
        [HttpGet]
        //[Route("api/{controller}?pageIndex={pageIndex}&pageSize={pageSize}")]
        public Tuple<int, List<Mes_ua_submit>> Get(int pageIndex, int pageSize)
        {
            WebApiBasicBll bll = new WebApiBasicBll();
            return bll.Page<Mes_ua_submit>(pageIndex, pageSize);
        }
    }
}
