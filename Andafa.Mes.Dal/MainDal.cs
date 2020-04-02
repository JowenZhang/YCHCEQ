using Andafa.Mes.Common.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andafa.Mes.Dal
{
    /// <summary>
    /// main dal
    /// </summary>
    public class MainDal : IMainDal
    {
        #region read all
        /// <summary>
        /// get whole model list
        /// </summary>
        /// <typeparam name="T">model type</typeparam>
        /// <returns>whole model list</returns>
        public virtual List<T> Index<T>() where T : class
        {
            IBaseDal dal = new BaseDal();
            return dal.Read<T>("Index");
        }
        #endregion

        #region read
        /// <summary>
        /// read model
        /// </summary>
        /// <typeparam name="T">model type</typeparam>
        /// <param name="model">parameter model</param>
        /// <returns>model</returns>
        public virtual T ReadModelByModel<T>(T model) where T : class
        {
            IBaseDal dal = new BaseDal();
            return dal.ReadSingle<T>("Read", BaseDal.ConvertEntityToParameters<T>(model));
        }

        /// <summary>
        /// read model
        /// </summary>
        /// <typeparam name="T">model type</typeparam>
        /// <param name="pmsDict">parameters</param>
        /// <returns>model</returns>
        public virtual T ReadModelByPms<T>(Dictionary<string, object> pmsDict = null) where T : class
        {
            IBaseDal dal = new BaseDal();
            return dal.ReadSingle<T>("Read", pmsDict);
        }

        /// <summary>
        /// read model
        /// </summary>
        /// <typeparam name="T">entity type</typeparam>
        /// <param name="sqlFileName">sql file name</param>
        /// <param name="sqlId">sql id</param>
        /// <param name="pmsDict">parameters</param>
        /// <returns>data</returns>
        public virtual T ReadModelByPms<T>(string sqlFileName, string sqlId, Dictionary<string, object> pmsDict) where T : class
        {
            IBaseDal dal = new BaseDal();
            return dal.ReadSingle<T>(sqlFileName, sqlId, pmsDict);
        }

        /// <summary>
        /// read models
        /// </summary>
        /// <typeparam name="T">model type</typeparam>
        /// <param name="model">parameter model</param>
        /// <returns></returns>
        public virtual List<T> ReadModelListByModel<T>(T model) where T : class
        {
            IBaseDal dal = new BaseDal();
            return dal.Read<T>("Read", BaseDal.ConvertEntityToParameters<T>(model));
        }

        /// <summary>
        /// read models
        /// </summary>
        /// <typeparam name="T">model type</typeparam>
        /// <param name="pms">parameters</param>
        /// <returns>models</returns>
        public virtual List<T> ReadModelListByPms<T>(Dictionary<string, object> pms = null) where T : class
        {
            IBaseDal dal = new BaseDal();
            return dal.Read<T>("Read", pms);
        }

        /// <summary>
        /// read models
        /// </summary>
        /// <typeparam name="T">entity type</typeparam>
        /// <param name="sqlFileName">sql file name</param>
        /// <param name="sqlId">sql id</param>
        /// <param name="pmsDict">parameters</param>
        /// <returns>models</returns>
        public virtual List<T> ReadModelListByPms<T>(string sqlFileName, string sqlId, Dictionary<string, object> pmsDict = null) where T : class
        {
            IBaseDal dal = new BaseDal();
            return dal.Read<T>(sqlFileName, sqlId, pmsDict);
        }

        /// <summary>
        /// read record list
        /// </summary>
        /// <param name="sqlFileName">sql file name</param>
        /// <param name="sqlId">sql id</param>
        /// <param name="pmsDict">parameteres</param>
        /// <returns>record list</returns>
        public virtual List<Dictionary<string, object>> ReadRecordListByPms(string sqlFileName, string sqlId, Dictionary<string, object> pmsDict = null)
        {
            IBaseDal dal = new BaseDal();
            return dal.Read(sqlFileName, sqlId, pmsDict);
        }

        /// <summary>
        /// read record
        /// </summary>
        /// <param name="sqlFileName">sql file name</param>
        /// <param name="sqlId">sql id</param>
        /// <param name="pmsDict">parameteres</param>
        /// <returns>record</returns>
        public virtual Dictionary<string, object> ReadRecordByPms(string sqlFileName, string sqlId, Dictionary<string, object> pmsDict = null)
        {
            IBaseDal dal = new BaseDal();
            return dal.ReadSingle(sqlFileName, sqlId, pmsDict);
        }
        #endregion

        #region create
        /// <summary>
        /// create recorrd by model
        /// </summary>
        /// <typeparam name="T">model type</typeparam>
        /// <param name="models">models</param>
        /// <returns>create quantity</returns>
        public virtual int CreateByModel<T>(List<T> models) where T : class
        {
            IBaseDal dal = new BaseDal();
            return dal.CUD<T>("Create", models);
        }

        /// <summary>
        /// create recorrd by model
        /// </summary>
        /// <typeparam name="T">model type</typeparam>
        /// <param name="model">model</param>
        /// <returns>create quantity</returns>
        public virtual int CreateByModel<T>(T model) where T : class
        {
            IBaseDal dal = new BaseDal();
            return dal.CUD<T>("Create", model);
        }

        /// <summary>
        /// create record by parameter
        /// </summary>
        /// <param name="sqlFileName">sql file name</param>
        /// <param name="pmsDict">model parameter</param>
        /// <returns>create quantity</returns>
        public virtual int CreateByPms(string sqlFileName, Dictionary<string, object> pmsDict)
        {
            IBaseDal dal = new BaseDal();
            return dal.CUD(sqlFileName, "Create", pmsDict);
        }

        /// <summary>
        /// create record by parameter
        /// </summary>
        /// <param name="sqlFileName">sql file name</param>
        /// <param name="pmsDictList">parameter list</param>
        /// <returns>create quantity</returns>
        public virtual int CreateByPms(string sqlFileName, List<Dictionary<string, object>> pmsDictList)
        {
            IBaseDal dal = new BaseDal();
            return dal.CUD(sqlFileName, "Create", pmsDictList);
        }
        #endregion

        #region update
        /// <summary>
        /// update record by model
        /// </summary>
        /// <typeparam name="T">model type</typeparam>
        /// <param name="models">models</param>
        /// <returns>update quantity</returns>
        public virtual int UpdateByModel<T>(List<T> models) where T : class
        {
            IBaseDal dal = new BaseDal();
            return dal.CUD<T>("Update", models);
        }

        /// <summary>
        /// update record by model
        /// </summary>
        /// <typeparam name="T">model type</typeparam>
        /// <param name="model">model</param>
        /// <returns>update quantity</returns>
        public virtual int UpdateByModel<T>(T model) where T : class
        {
            IBaseDal dal = new BaseDal();
            return dal.CUD<T>("Update", model);
        }

        /// <summary>
        /// update record by parameters
        /// </summary>
        /// <param name="sqlFileName">sql file name</param>
        /// <param name="pms">model parameter</param>
        /// <returns>update quantity</returns>
        public virtual int UpdateByPms(string sqlFileName, Dictionary<string, object> pms)
        {
            IBaseDal dal = new BaseDal();
            return dal.CUD(sqlFileName, "Update", pms);
        }

        /// <summary>
        /// update record by parameters
        /// </summary>
        /// <param name="sqlFileName">sql file name</param>
        /// <param name="pmsDictList">parameter list</param>
        /// <returns>update quantity</returns>
        public virtual int UpdateByPms(string sqlFileName, List<Dictionary<string, object>> pmsDictList)
        {
            IBaseDal dal = new BaseDal();
            return dal.CUD(sqlFileName, "Update", pmsDictList);
        }
        #endregion

        #region delete
        /// <summary>
        /// delete record by model
        /// </summary>
        /// <typeparam name="T">model type</typeparam>
        /// <param name="models">models</param>
        /// <returns>delete quantity</returns>
        public virtual int DeleteByModel<T>(List<T> models) where T : class
        {
            IBaseDal dal = new BaseDal();
            return dal.CUD<T>("Delete", models);
        }

        /// <summary>
        /// delete record by model
        /// </summary>
        /// <typeparam name="T">model type</typeparam>
        /// <param name="model">model</param>
        /// <returns>delete quantity</returns>
        public virtual int DeleteByModel<T>(T model) where T : class
        {
            IBaseDal dal = new BaseDal();
            return dal.CUD<T>("Delete", model);
        }

        /// <summary>
        /// delete record by parameters
        /// </summary>
        /// <param name="sqlFileName">sql file name</param>
        /// <param name="pmsDict">parameter</param>
        /// <returns>delete quantity</returns>
        public virtual int DeleteByPms(string sqlFileName, Dictionary<string, object> pmsDict)
        {
            IBaseDal dal = new BaseDal();
            return dal.CUD(sqlFileName, "Delete", pmsDict);
        }

        /// <summary>
        /// delete record by parameters
        /// </summary>
        /// <param name="sqlFileName">sql file name</param>
        /// <param name="pmsDictList">parameter list</param>
        /// <returns>delete quantity</returns>
        public virtual int DeleteByPms(string sqlFileName, List<Dictionary<string, object>> pmsDictList)
        {
            IBaseDal dal = new BaseDal();
            return dal.CUD(sqlFileName, "Delete", pmsDictList);
        }
        #endregion

        #region create,update,delete
        /// <summary>
        /// create,update,delete record by parameter
        /// </summary>
        /// <param name="sqlFileName">sql file name</param>
        /// <param name="sqlId">sql id</param>
        /// <param name="pmsDict">model parameter</param>
        /// <returns>create,update,delete quantity</returns>
        public virtual int CUDByPms(string sqlFileName, string sqlId, Dictionary<string, object> pmsDict)
        {
            IBaseDal dal = new BaseDal();
            return dal.CUD(sqlFileName, sqlId, pmsDict);
        }

        /// <summary>
        /// create,update,delete record by parameter
        /// </summary>
        /// <param name="sqlFileName">sql file name</param>
        /// <param name="sqlId">sql id</param>
        /// <param name="pmsDictList">parameter list</param>
        /// <returns>create,update,delete quantity</returns>
        public virtual int CUDByPms(string sqlFileName, string sqlId, List<Dictionary<string, object>> pmsDictList)
        {
            IBaseDal dal = new BaseDal();
            return dal.CUD(sqlFileName, sqlId, pmsDictList);
        }

        /// <summary>
        /// create,update,delete record by parameter
        /// </summary>
        /// <typeparam name="T">model type</typeparam>
        /// <param name="sqlFileName">sql file name</param>
        /// <param name="sqlId">sql id</param>
        /// <param name="model">model</param>
        /// <returns>create,update,delete quantity</returns>
        public virtual int CUDByModel<T>(string sqlFileName, string sqlId, T model) where T : class
        {
            IBaseDal dal = new BaseDal();
            return dal.CUD(sqlFileName, sqlId, BaseDal.ConvertEntityToParameters<T>(model));
        }

        /// <summary>
        /// create,update,delete record by parameter
        /// </summary>
        /// <typeparam name="T">model type</typeparam>
        /// <param name="sqlFileName">sql file name</param>
        /// <param name="sqlId">sql id</param>
        /// <param name="modelList">model list</param>
        /// <returns>create,update,delete quantity</returns>
        public virtual int CUDByModel<T>(string sqlFileName, string sqlId, List<T> modelList) where T : class
        {
            IBaseDal dal = new BaseDal();
            return dal.CUD(sqlFileName, sqlId, modelList.Select(a => { return BaseDal.ConvertEntityToParameters<T>(a); }).ToList());
        }
        #endregion

        #region page
        /// <summary>
        /// page
        /// </summary>
        /// <typeparam name="T">model type</typeparam>
        /// <param name="pageIndex">page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="pmsDict">parameters</param>
        /// <returns>page result</returns>
        public virtual Tuple<int, List<T>> Page<T>(int pageIndex, int pageSize, Dictionary<string, object> pmsDict = null) where T : class
        {
            IBaseDal dal = new BaseDal();
            int total = 0;
            List<T> list = dal.Page<T>("Count", "Page", pageIndex, pageSize, out total, pmsDict);
            return new Tuple<int, List<T>>(total, list);
        }
        #endregion

        #region ado
        /// <summary>
        /// query object
        /// </summary>
        /// <param name="sqlFileName">sql file name</param>
        /// <param name="sqlId">sql id</param>
        /// <param name="pmsDict">parameters</param>
        /// <returns>object result in string</returns>
        public virtual object QueryObj(string sqlFileName, string sqlId, Dictionary<string, object> pmsDict)
        {
            IBaseDal dal = new BaseDal();
            return dal.QueryObj(sqlFileName, sqlId, pmsDict);
        }
        #endregion

        #region exist
        /// <summary>
        /// exist current record by field
        /// </summary>
        /// <param name="sqlFileName">sql file name\</param>
        /// <param name="sqlId">sql id</param>
        /// <param name="pmsDict">parameters</param>
        /// <returns>exist result</returns>
        public bool Exist(string sqlFileName, string sqlId, Dictionary<string, object> pmsDict = null)
        {
            IBaseDal dal = new BaseDal();
            return dal.Exist(sqlFileName, sqlId, pmsDict);
        }

        /// <summary>
        /// exist current entity
        /// </summary>
        /// <typeparam name="T">type</typeparam>
        /// <param name="sqlId">sql id</param>
        /// <param name="entity">current entity</param>
        /// <returns>exist result</returns>
        public bool Exist<T>(string sqlId, T entity) where T : class
        {
            IBaseDal dal = new BaseDal();
            return dal.Exist<T>(sqlId, entity);
        }
        #endregion

        #region count
        /// <summary>
        /// count by parameters
        /// </summary>
        /// <typeparam name="T">type</typeparam>
        /// <param name="sqlId">sql id</param>
        /// <param name="entity">parameter entity</param>
        /// <returns>count quantity</returns>
        public int Count<T>(string sqlId, T entity) where T : class
        {
            IBaseDal dal = new BaseDal();
            return dal.Count<T>(sqlId, entity);
        }

        /// <summary>
        /// count by parameters
        /// </summary>
        /// <param name="sqlFileName">sql file name</param>
        /// <param name="sqlId">sql id</param>
        /// <param name="pmsDict">parameters</param>
        /// <returns>count quantity</returns>
        public int Count(string sqlFileName, string sqlId, Dictionary<string, object> pmsDict = null)
        {
            IBaseDal dal = new BaseDal();
            return dal.Count(sqlFileName, sqlId, pmsDict);
        }
        #endregion

        /// <summary>
        /// fetch sql string from config file
        /// </summary>
        /// <param name="sqlId">sql id</param>
        /// <param name="sqlFilePath">sql config file path</param>
        /// <returns>sql file path</returns>
        private string FetchSqlById(string sqlId, string sqlFilePath = "")
        {
            string sqlXPath = string.Format("/sqls/sql[@id='{0}']", sqlId);
            if (string.IsNullOrWhiteSpace(sqlFilePath))
            {
                sqlFilePath = AppDomain.CurrentDomain.BaseDirectory + "Config\\AllSqls.xml";
            }
            return XmlTool.GetNodeValueByXPath(sqlXPath, sqlFilePath, false);
        }
    }
}
