using Andafa.Mes.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andafa.Mes.Bll.WebApiBll
{
    /// <summary>
    /// web api basic bll
    /// </summary>
    public class WebApiBasicBll
    {
        /// <summary>
        /// read all models
        /// </summary>
        /// <typeparam name="T">model type</typeparam>
        /// <returns>all models</returns>
        public virtual List<T> Index<T>() where T : class
        {
            IMainDal dal = new MainDal();
            return dal.Index<T>();
        }

        /// <summary>
        /// read single model
        /// </summary>
        /// <typeparam name="T">model type</typeparam>
        /// <param name="pms">query parameter</param>
        /// <returns>model</returns>
        public virtual T ReadModelByPms<T>(Dictionary<string, object> pms) where T : class
        {
            IMainDal dal = new MainDal();
            return dal.ReadModelByPms<T>(pms);
        }

        /// <summary>
        /// create model
        /// </summary>
        /// <typeparam name="T">model type</typeparam>
        /// <param name="model">model</param>
        /// <returns>create model quantity</returns>
        public virtual int CreateByModel<T>(T model) where T : class
        {
            IMainDal dal = new MainDal();
            return dal.CreateByModel<T>(model);
        }

        /// <summary>
        /// update model
        /// </summary>
        /// <typeparam name="T">model type</typeparam>
        /// <param name="model">model</param>
        /// <returns>update model quantity</returns>
        public virtual int UpdateByModel<T>(T model) where T : class
        {
            IMainDal dal = new MainDal();
            return dal.UpdateByModel<T>(model);
        }

        /// <summary>
        /// delete model
        /// </summary>
        /// <typeparam name="T">model type</typeparam>
        /// <param name="pms">query parameter</param>
        /// <returns>delete model quantity</returns>
        public virtual int DeleteModelByPms<T>(Dictionary<string, object> pms) where T : class
        {
            IMainDal dal = new MainDal();
            return dal.DeleteByPms(typeof(T).Name, pms);
        }

        /// <summary>
        /// read single model
        /// </summary>
        /// <typeparam name="T">model type</typeparam>
        /// <param name="pms">query parameter</param>
        /// <returns>model list</returns>
        public virtual List<T> ReadModelListByPms<T>(Dictionary<string, object> pms) where T : class
        {
            IMainDal dal = new MainDal();
            return dal.ReadModelListByPms<T>(pms);
        }

        /// <summary>
        /// create model
        /// </summary>
        /// <typeparam name="T">model type</typeparam>
        /// <param name="modelList">model list</param>
        /// <returns>create model quantity</returns>
        public virtual int CreateByModel<T>(List<T> modelList) where T : class
        {
            IMainDal dal = new MainDal();
            return dal.CreateByModel(modelList);
        }

        /// <summary>
        /// update model
        /// </summary>
        /// <typeparam name="T">model type</typeparam>
        /// <param name="modelList">model list</param>
        /// <returns>update model quantity</returns>
        public virtual int UpdateByModel<T>(List<T> modelList) where T : class
        {
            IMainDal dal = new MainDal();
            return dal.UpdateByModel<T>(modelList);
        }

        /// <summary>
        /// delete model
        /// </summary>
        /// <typeparam name="T">model type</typeparam>
        /// <param name="pmsList">query parameter list</param>
        /// <returns>delete model quantity</returns>
        public virtual int DeleteModelByPms<T>(List<Dictionary<string, object>> pmsList) where T : class
        {
            IMainDal dal = new MainDal();
            return dal.DeleteByPms(typeof(T).Name, pmsList);
        }

        /// <summary>
        /// page
        /// </summary>
        /// <typeparam name="T">model type</typeparam>
        /// <param name="pageIndex">page index</param>
        /// <param name="pageSize">page size</param>
        /// <returns>page result</returns>
        public virtual Tuple<int, List<T>> Page<T>(int pageIndex, int pageSize) where T : class
        {
            IMainDal dal = new MainDal();
            return dal.Page<T>(pageIndex, pageSize);
        }

        /// <summary>
        /// query record in view model
        /// </summary>
        /// <param name="sqlFileName">sql file name</param>
        /// <param name="sqlId">sql id</param>
        /// <param name="pms">query parameter</param>
        /// <returns>view model result</returns>
        public virtual Dictionary<string, object> QueryRecord(string sqlFileName, string sqlId, Dictionary<string, object> pms)
        {
            IMainDal dal = new MainDal();
            return dal.ReadRecordByPms(sqlFileName, sqlId, pms);
        }

        /// <summary>
        /// query record list in view model
        /// </summary>
        /// <param name="sqlFileName">sql file name</param>
        /// <param name="sqlId">sql id</param>
        /// <param name="pms">query parameter</param>
        /// <returns>view model list result</returns>
        public virtual List<Dictionary<string, object>> QueryRecordList(string sqlFileName, string sqlId, Dictionary<string, object> pms)
        {
            IMainDal dal = new MainDal();
            return dal.ReadRecordListByPms(sqlFileName, sqlId, pms);
        }

        /// <summary>
        /// query object
        /// </summary>
        /// <param name="sqlFileName">sql file name</param>
        /// <param name="sqlId">sql id</param>
        /// <param name="pms">query parameter</param>
        /// <returns>object result</returns>
        public virtual object QueryObj(string sqlFileName, string sqlId, Dictionary<string, object> pms)
        {
            IMainDal dal = new MainDal();
            return dal.QueryObj(sqlFileName, sqlId, pms);
        }

        /// <summary>
        /// query int
        /// </summary>
        /// <param name="sqlFileName">sql file name</param>
        /// <param name="sqlId">sql id</param>
        /// <param name="pms">query parameter</param>
        /// <returns>int result</returns>
        public virtual int QueryInt(string sqlFileName, string sqlId, Dictionary<string, object> pms)
        {
            IMainDal dal = new MainDal();
            return dal.CUDByPms(sqlFileName, sqlId, pms);
        }

        /// <summary>
        /// query int
        /// </summary>
        /// <param name="sqlFileName">sql file name</param>
        /// <param name="sqlId">sql id</param>
        /// <param name="pmsList">query parameter list</param>
        /// <returns>int result</returns>
        public virtual int QueryInt(string sqlFileName, string sqlId, List<Dictionary<string, object>> pmsList)
        {
            IMainDal dal = new MainDal();
            return dal.CUDByPms(sqlFileName, sqlId, pmsList);
        }
    }
}
