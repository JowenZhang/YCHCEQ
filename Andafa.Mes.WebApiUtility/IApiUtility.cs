using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Andafa.Mes.WebApiUtility
{
    /// <summary>
    /// web api utility
    /// </summary>
    public interface IApiUtility
    {
        /// <summary>
        /// read model list
        /// </summary>
        /// <typeparam name="T">model type</typeparam>
        /// <param name="pms">query parameter</param>
        /// <returns>model list</returns>
        List<T> GetAny<T>(Dictionary<string, object> pms = null) where T : class;

        /// <summary>
        /// read model
        /// </summary>
        /// <typeparam name="T">model type</typeparam>
        /// <param name="pms">query parameter</param>
        /// <returns>model</returns>
        T GetOne<T>(Dictionary<string, object> pms) where T : class;

        /// <summary>
        /// create model
        /// </summary>
        /// <typeparam name="T">model type</typeparam>
        /// <param name="model">model value</param>
        /// <returns>create resut</returns>
        bool Post<T>(T model) where T : class;

        /// <summary>
        /// create model list
        /// </summary>
        /// <typeparam name="T">model type</typeparam>
        /// <param name="modelList">model list value</param>
        /// <returns>create resut</returns>
        bool Post<T>(List<T> modelList) where T : class;

        /// <summary>
        /// update model
        /// </summary>
        /// <typeparam name="T">model type</typeparam>
        /// <param name="model">model data</param>
        /// <returns>update result</returns>
        bool Put<T>(T model) where T : class;

        /// <summary>
        /// update model List
        /// </summary>
        /// <typeparam name="T">model type</typeparam>
        /// <param name="modelList">model list data</param>
        /// <returns>update result</returns>
        bool Put<T>(List<T> modelList) where T : class;

        /// <summary>
        /// delete record
        /// </summary>
        /// <typeparam name="T">model type</typeparam>
        /// <param name="pms">query parameter</param>
        /// <returns>delete result</returns>
        bool Delete<T>(Dictionary<string, object> pms) where T : class;

        /// <summary>
        /// delete records
        /// </summary>
        /// <typeparam name="T">model type</typeparam>
        /// <param name="pmsList">query parameter list</param>
        /// <returns>delete result</returns>
        bool Delete<T>(List<Dictionary<string, object>> pmsList) where T : class;

        /// <summary>
        /// page
        /// </summary>
        /// <typeparam name="T">model type</typeparam>
        /// <param name="pageIndex">page index</param>
        /// <param name="pageSize">page size</param>
        /// <returns>page result</returns>
        Tuple<int, List<T>> Page<T>(int pageIndex, int pageSize) where T : class;

        /// <summary>
        /// is web api exist
        /// </summary>
        /// <returns>web api exist result</returns>
        bool GetExist();

        /// <summary>
        /// run sql to get int by post
        /// </summary>
        /// <param name="sqlFileName">sql file name</param>
        /// <param name="sqlId">sql id</param>
        /// <param name="pms">qurey parameter</param>
        /// <returns>int result</returns>
        int Post(string sqlFileName, string sqlId, Dictionary<string, object> pms);

        /// <summary>
        /// run sql to get int by post
        /// </summary>
        /// <param name="sqlFileName">sql file name</param>
        /// <param name="sqlId">sql id</param>
        /// <param name="pmsList">qurey parameter list</param>
        /// <returns>int result</returns>
        int Post(string sqlFileName, string sqlId, List<Dictionary<string, object>> pmsList);

        /// <summary>
        /// run sql in record by get
        /// </summary>
        /// <param name="sqlFileName">sql file name</param>
        /// <param name="sqlId">sql id</param>
        /// <param name="pms">query parameters</param>
        /// <returns>record</returns>
        Dictionary<string, object> GetDict(string sqlFileName, string sqlId, Dictionary<string, object> pms);

        /// <summary>
        /// run sql in record list by get
        /// </summary>
        /// <param name="sqlFileName">sql file name</param>
        /// <param name="sqlId">sql id</param>
        /// <param name="pms">query parameters</param>
        /// <returns>record list</returns>
        List<Dictionary<string, object>> GetDictList(string sqlFileName, string sqlId, Dictionary<string, object> pms);

        /// <summary>
        /// run sql in object by get
        /// </summary>
        /// <param name="sqlFileName">sql file name</param>
        /// <param name="sqlId">sql id</param>
        /// <param name="pms">query parameters</param>
        /// <returns>object</returns>
        object GetObj(string sqlFileName, string sqlId, Dictionary<string, object> pms);
    }
}
