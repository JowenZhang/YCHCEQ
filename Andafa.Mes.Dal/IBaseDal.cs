using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andafa.Mes.Dal
{
    /// <summary>
    /// base dal interface
    /// </summary>
    public interface IBaseDal
    {
        #region create,update,delete
        /// <summary>
        /// create,update,delete records
        /// </summary>
        /// <typeparam name="T">entity type</typeparam>
        /// <param name="sqlId">sql id</param>
        /// <param name="entities">entities data</param>
        /// <returns>create,update,delete quantity</returns>
        int CUD<T>(string sqlId, List<T> entities = null) where T : class;

        /// <summary>
        /// create,update,delete records
        /// </summary>
        /// <typeparam name="T">entity type</typeparam>
        /// <param name="sqlId">sql id</param>
        /// <param name="entity">entity data</param>
        /// /// <returns>create,update,delete quantity</returns>
        int CUD<T>(string sqlId, T entity) where T : class;


        /// <summary>
        /// create,update,delete records
        /// </summary>
        /// <param name="sqlFileName">sql file name</param>
        /// <param name="sqlId">sql id</param>
        /// <param name="pmsDictList">insert parameter list</param>
        /// <returns>create,update,delete quantity</returns>
        int CUD(string sqlFileName, string sqlId, List<Dictionary<string, object>> pmsDictList = null);

        /// <summary>
        /// create,update,delete records
        /// </summary>
        /// <param name="sqlFileName">sql file name</param>
        /// <param name="sqlId">sql id</param>
        /// <param name="pmsDict">insert parameter</param>
        /// <returns>create,update,delete quantity</returns>
        int CUD(string sqlFileName, string sqlId, Dictionary<string, object> pmsDict);
        #endregion

        #region read
        /// <summary>
        /// read data
        /// </summary>
        /// <typeparam name="T">entity type</typeparam>
        /// <param name="sqlId">sql id</param>
        /// <param name="pmsDict">select parameter</param>
        /// <returns>data</returns>
        List<T> Read<T>(string sqlId, Dictionary<string, object> pmsDict = null) where T : class;

        /// <summary>
        /// read data
        /// </summary>
        /// <typeparam name="T">entity type</typeparam>
        /// <param name="sqlId">sql id</param>
        /// <param name="pmsDict">parameter</param>
        /// <returns>data</returns>
        T ReadSingle<T>(string sqlId, Dictionary<string, object> pmsDict) where T : class;

        /// <summary>
        /// read data
        /// </summary>
        /// <param name="sqlFileName">sql file name</param>
        /// <param name="sqlId">sql id</param>
        /// <param name="pmsDict">parameters</param>
        /// <returns>data</returns>
        List<Dictionary<string, object>> Read(string sqlFileName, string sqlId, Dictionary<string, object> pmsDict = null);

        /// <summary>
        /// read data
        /// </summary>
        /// <param name="sqlFileName">sql file name</param>
        /// <param name="sqlId">sql id</param>
        /// <param name="pmsDict">parameters</param>
        /// <returns>data</returns>
        Dictionary<string, object> ReadSingle(string sqlFileName, string sqlId, Dictionary<string, object> pmsDict);

        /// <summary>
        /// read data
        /// </summary>
        /// <typeparam name="T">entity type</typeparam>
        /// <param name="sqlFileName">sql file name</param>
        /// <param name="sqlId">sql id</param>
        /// <param name="pmsDict">parameters</param>
        /// <returns>data</returns>
        List<T> Read<T>(string sqlFileName, string sqlId, Dictionary<string, object> pmsDict = null) where T : class;

        /// <summary>
        /// read data
        /// </summary>
        /// <typeparam name="T">entity type</typeparam>
        /// <param name="sqlFileName">sql file name</param>
        /// <param name="sqlId">sql id</param>
        /// <param name="pmsDict">parameters</param>
        /// <returns>data</returns>
        T ReadSingle<T>(string sqlFileName, string sqlId, Dictionary<string, object> pmsDict) where T : class;
        #endregion

        #region ado
        /// <summary>
        /// execute scalar query sql
        /// </summary>
        /// <param name="sqlFileName">sql file name</param>
        /// <param name="sqlId">sql id</param>
        /// <param name="pmsDict">parameters</param>
        /// <returns>result string</returns>
        object QueryObj(string sqlFileName, string sqlId, Dictionary<string, object> pmsDict);
        #endregion

        #region page
        /// <summary>
        /// page
        /// </summary>
        /// <typeparam name="T">entity type</typeparam>
        /// <param name="countSqlId">count sql id</param>
        /// <param name="pageSqlId">page sql id</param>
        /// <param name="pageIndex">page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="pmsDict">parameters</param>
        /// <param name="total">total</param>
        /// <returns>rows</returns>
        List<T> Page<T>(string countSqlId, string pageSqlId, int pageIndex, int pageSize, out int total, Dictionary<string, object> pmsDict = null) where T : class;
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
