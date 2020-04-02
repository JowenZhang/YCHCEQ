using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andafa.Mes.Dal
{
    /// <summary>
    /// main dal interface
    /// </summary>
    public interface IMainDal
    {
        #region read all
        /// <summary>
        /// get whole model list
        /// </summary>
        /// <typeparam name="T">model type</typeparam>
        /// <returns>whole model list</returns>
        List<T> Index<T>() where T : class;
        #endregion

        #region read
        /// <summary>
        /// read model
        /// </summary>
        /// <typeparam name="T">model type</typeparam>
        /// <param name="model">parameter model</param>
        /// <returns>model</returns>
        T ReadModelByModel<T>(T model) where T : class;

        /// <summary>
        /// read model
        /// </summary>
        /// <typeparam name="T">model type</typeparam>
        /// <param name="pmsDict">parameters</param>
        /// <returns>model</returns>
        T ReadModelByPms<T>(Dictionary<string, object> pmsDict = null) where T : class;

        /// <summary>
        /// read model
        /// </summary>
        /// <typeparam name="T">entity type</typeparam>
        /// <param name="sqlFileName">sql file name</param>
        /// <param name="sqlId">sql id</param>
        /// <param name="pmsDict">parameters</param>
        /// <returns>data</returns>
        T ReadModelByPms<T>(string sqlFileName, string sqlId, Dictionary<string, object> pmsDict) where T : class;

        /// <summary>
        /// read models
        /// </summary>
        /// <typeparam name="T">model type</typeparam>
        /// <param name="model">parameter model</param>
        /// <returns></returns>
        List<T> ReadModelListByModel<T>(T model) where T : class;

        /// <summary>
        /// read models
        /// </summary>
        /// <typeparam name="T">model type</typeparam>
        /// <param name="pms">parameters</param>
        /// <returns>models</returns>
        List<T> ReadModelListByPms<T>(Dictionary<string, object> pms = null) where T : class;

        /// <summary>
        /// read data
        /// </summary>
        /// <typeparam name="T">entity type</typeparam>
        /// <param name="sqlFileName">sql file name</param>
        /// <param name="sqlId">sql id</param>
        /// <param name="pmsDict">parameters</param>
        /// <returns>data</returns>
        List<T> ReadModelListByPms<T>(string sqlFileName, string sqlId, Dictionary<string, object> pmsDict = null) where T : class;

        /// <summary>
        /// read record list
        /// </summary>
        /// <param name="sqlFileName">sql file name</param>
        /// <param name="sqlId">sql id</param>
        /// <param name="pmsDict">parameteres</param>
        /// <returns>record list</returns>
        List<Dictionary<string, object>> ReadRecordListByPms(string sqlFileName, string sqlId, Dictionary<string, object> pmsDict = null);

        /// <summary>
        /// read record
        /// </summary>
        /// <param name="sqlFileName">sql file name</param>
        /// <param name="sqlId">sql id</param>
        /// <param name="pmsDict">parameteres</param>
        /// <returns>record</returns>
        Dictionary<string, object> ReadRecordByPms(string sqlFileName, string sqlId, Dictionary<string, object> pmsDict = null);
        #endregion

        #region create
        /// <summary>
        /// create recorrd by model
        /// </summary>
        /// <typeparam name="T">model type</typeparam>
        /// <param name="models">models</param>
        /// <returns>create quantity</returns>
        int CreateByModel<T>(List<T> models) where T : class;

        /// <summary>
        /// create recorrd by model
        /// </summary>
        /// <typeparam name="T">model type</typeparam>
        /// <param name="model">model</param>
        /// <returns>create quantity</returns>
        int CreateByModel<T>(T model) where T : class;

        /// <summary>
        /// create record by parameter
        /// </summary>
        /// <param name="sqlFileName">sql file name</param>
        /// <param name="pmsDict">model parameter</param>
        /// <returns>create quantity</returns>
        int CreateByPms(string sqlFileName, Dictionary<string, object> pmsDict);

        /// <summary>
        /// create record by parameter
        /// </summary>
        /// <param name="sqlFileName">sql file name</param>
        /// <param name="pmsDictList">parameter list</param>
        /// <returns>create quantity</returns>
        int CreateByPms(string sqlFileName, List<Dictionary<string, object>> pmsDictList);
        #endregion

        #region update
        /// <summary>
        /// update record by model
        /// </summary>
        /// <typeparam name="T">model type</typeparam>
        /// <param name="models">models</param>
        /// <returns>update quantity</returns>
        int UpdateByModel<T>(List<T> models) where T : class;

        /// <summary>
        /// update record by model
        /// </summary>
        /// <typeparam name="T">model type</typeparam>
        /// <param name="model">model</param>
        /// <returns>update quantity</returns>
        int UpdateByModel<T>(T model) where T : class;

        /// <summary>
        /// update record by parameters
        /// </summary>
        /// <param name="sqlFileName">sql file name</param>
        /// <param name="pms">model parameter</param>
        /// <returns>update quantity</returns>
        int UpdateByPms(string sqlFileName, Dictionary<string, object> pms);

        /// <summary>
        /// update record by parameters
        /// </summary>
        /// <param name="sqlFileName">sql file name</param>
        /// <param name="pmsDictList">parameter list</param>
        /// <returns>update quantity</returns>
        int UpdateByPms(string sqlFileName, List<Dictionary<string, object>> pmsDictList);
        #endregion

        #region delete
        /// <summary>
        /// delete record by model
        /// </summary>
        /// <typeparam name="T">model type</typeparam>
        /// <param name="models">models</param>
        /// <returns>delete quantity</returns>
        int DeleteByModel<T>(List<T> models) where T : class;

        /// <summary>
        /// delete record by model
        /// </summary>
        /// <typeparam name="T">model type</typeparam>
        /// <param name="model">model</param>
        /// <returns>delete quantity</returns>
        int DeleteByModel<T>(T model) where T : class;

        /// <summary>
        /// delete record by parameters
        /// </summary>
        /// <param name="sqlFileName">sql file name</param>
        /// <param name="pmsDict">parameter</param>
        /// <returns>delete quantity</returns>
        int DeleteByPms(string sqlFileName, Dictionary<string, object> pmsDict);

        /// <summary>
        /// delete record by parameters
        /// </summary>
        /// <param name="sqlFileName">sql file name</param>
        /// <param name="pmsDictList">parameter list</param>
        /// <returns>delete quantity</returns>
        int DeleteByPms(string sqlFileName, List<Dictionary<string, object>> pmsDictList);
        #endregion

        #region create,update,delete
        /// <summary>
        /// create,update,delete record by parameter
        /// </summary>
        /// <param name="sqlFileName">sql file name</param>
        /// <param name="sqlId">sql id</param>
        /// <param name="pmsDict">model parameter</param>
        /// <returns>create,update,delete quantity</returns>
        int CUDByPms(string sqlFileName, string sqlId, Dictionary<string, object> pmsDict);

        /// <summary>
        /// create,update,delete record by parameter
        /// </summary>
        /// <param name="sqlFileName">sql file name</param>
        /// <param name="sqlId">sql id</param>
        /// <param name="pmsDictList">parameter list</param>
        /// <returns>create,update,delete quantity</returns>
        int CUDByPms(string sqlFileName, string sqlId, List<Dictionary<string, object>> pmsDictList);

        /// <summary>
        /// create,update,delete record by parameter
        /// </summary>
        /// <typeparam name="T">model type</typeparam>
        /// <param name="sqlFileName">sql file name</param>
        /// <param name="sqlId">sql id</param>
        /// <param name="model">model</param>
        /// <returns>create,update,delete quantity</returns>
        int CUDByModel<T>(string sqlFileName, string sqlId, T model) where T : class;

        /// <summary>
        /// create,update,delete record by parameter
        /// </summary>
        /// <typeparam name="T">model type</typeparam>
        /// <param name="sqlFileName">sql file name</param>
        /// <param name="sqlId">sql id</param>
        /// <param name="modelList">model list</param>
        /// <returns>create,update,delete quantity</returns>
        int CUDByModel<T>(string sqlFileName, string sqlId, List<T> modelList) where T : class;
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
        Tuple<int, List<T>> Page<T>(int pageIndex, int pageSize, Dictionary<string, object> pmsDict = null) where T : class;
        #endregion

        #region ado
        /// <summary>
        /// query object
        /// </summary>
        /// <param name="sqlFileName">sql file name</param>
        /// <param name="sqlId">sql id</param>
        /// <param name="pmsDict">parameters</param>
        /// <returns>object result in string</returns>
        object QueryObj(string sqlFileName, string sqlId, Dictionary<string, object> pmsDict);
        #endregion

        #region exist
        /// <summary>
        /// exist current record by field
        /// </summary>
        /// <param name="sqlFileName">sql file name\</param>
        /// <param name="sqlId">sql id</param>
        /// <param name="pmsDict">parameters</param>
        /// <returns>exist result</returns>
        bool Exist(string sqlFileName, string sqlId, Dictionary<string, object> pmsDict = null);

        /// <summary>
        /// exist current entity
        /// </summary>
        /// <typeparam name="T">type</typeparam>
        /// <param name="sqlId">sql id</param>
        /// <param name="entity">current entity</param>
        /// <returns>exist result</returns>
        bool Exist<T>(string sqlId, T entity) where T : class;
        #endregion

        #region count
        /// <summary>
        /// count by parameters
        /// </summary>
        /// <typeparam name="T">type</typeparam>
        /// <param name="sqlId">sql id</param>
        /// <param name="entity">parameter entity</param>
        /// <returns>count quantity</returns>
        int Count<T>(string sqlId, T entity) where T : class;

        /// <summary>
        /// count by parameters
        /// </summary>
        /// <param name="sqlFileName">sql file name</param>
        /// <param name="sqlId">sql id</param>
        /// <param name="pmsDict">parameters</param>
        /// <returns>count quantity</returns>
        int Count(string sqlFileName, string sqlId, Dictionary<string, object> pmsDict = null);
        #endregion
    }
}
