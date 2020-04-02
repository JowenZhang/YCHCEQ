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
    /// me_worker webapi controller
    /// </summary>
    public class Me_workerController : ApiController
    {
        /// <summary>
        /// read single model
        /// </summary>
        /// <param name="pmsStr">web api parameters string</param>
        /// <returns>model</returns>
        [HttpGet]
        //[Route("api/{controller}/getsingle?pmsStr={pmsStr}")]
        public Me_worker GetSingle(string pmsStr)
        {
            WebApiBasicBll bll = new WebApiBasicBll();
            return bll.ReadModelByPms<Me_worker>(ControllerTool.ConvertPms(pmsStr));
        }

        /// <summary>
        /// read model list
        /// </summary>
        /// <param name="pmsStr">web api parameters string</param>
        /// <returns>model list</returns>
        [HttpGet]
        //[Route("api/{controller}")]
        public List<Me_worker> GetIndex()
        {
            WebApiBasicBll bll = new WebApiBasicBll();
            return bll.Index<Me_worker>();
        }

        /// <summary>
        /// read model list
        /// </summary>
        /// <param name="pmsStr">web api parameters string</param>
        /// <returns>model list</returns>
        /// api/{controller}/{pmsStr}
        [HttpGet]
        //[Route("api/{controller}/getlist?pmsStr={pmsStr}")]
        public List<Me_worker> GetList(string pmsStr)
        {
            Dictionary<string, object> pms = ControllerTool.ConvertPms(pmsStr);
            WebApiBasicBll bll = new WebApiBasicBll();
            if (pms == null || pms.Count <= 0)
            {
                return null;
            }
            else
            {
                return bll.ReadModelListByPms<Me_worker>(pms);
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
            bll.CreateByModel(ModelTool.ChangeObjectToList<Me_worker>(modelObj));
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
            bll.UpdateByModel(ModelTool.ChangeObjectToList<Me_worker>(modelObj));
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
            bll.DeleteModelByPms<Me_worker>(ModelTool.ChangeObjectToList<Dictionary<string, object>>(pmsObj));
        }

        /// <summary>
        /// get page
        /// </summary>
        /// <param name="pageIndex">page index</param>
        /// <param name="pageSize">page size</param>
        /// <returns>page result</returns>
        [HttpGet]
        //[Route("api/{controller}?pageIndex={pageIndex}&pageSize={pageSize}")]
        public Tuple<int, List<Me_worker>> Get(int pageIndex, int pageSize)
        {
            WebApiBasicBll bll = new WebApiBasicBll();
            return bll.Page<Me_worker>(pageIndex, pageSize);
        }
    }
}
