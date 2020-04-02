using Andafa.Mes.Common.Tools;
using Andafa.Mes.DbUtility;
using Dapper;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Andafa.Mes.Dal
{
    /// <summary>
    /// basic dal
    /// </summary>
    internal class BaseDal:IBaseDal
    {
        #region create,update,delete
        /// <summary>
        /// create,update,delete records
        /// </summary>
        /// <typeparam name="T">entity type</typeparam>
        /// <param name="sqlId">sql id</param>
        /// <param name="entities">entities data</param>
        /// <returns>create,update,delete quantity</returns>
        public int CUD<T>(string sqlId, List<T> entities = null) where T : class
        {
            string sql = FetchSqlById<T>(sqlId);
            if (string.IsNullOrWhiteSpace(sql))
            {
                return -10;
            }
            IDbConnection con = DbConnectionFactory.Con;
            if (con == null)
            {
                return -11;
            }
            try
            {
                return SqlMapper.Execute(con, sql, entities);
            }
            catch (Exception ex)
            {
                LogTool.Error(ex);
                return -12;
            }
        }

        /// <summary>
        /// create,update,delete records
        /// </summary>
        /// <typeparam name="T">entity type</typeparam>
        /// <param name="sqlId">sql id</param>
        /// <param name="entity">entity data</param>
        /// /// <returns>create,update,delete quantity</returns>
        public int CUD<T>(string sqlId, T entity) where T : class
        {
            string sql = FetchSqlById<T>(sqlId);
            if (string.IsNullOrWhiteSpace(sql))
            {
                return -10;
            }
            IDbConnection con = DbConnectionFactory.Con;
            if (con == null)
            {
                return -11;
            }
            try
            {
                return SqlMapper.Execute(con, sql, entity);
            }
            catch (Exception ex)
            {
                LogTool.Error(ex);
                return -12;
            }
        }

        /// <summary>
        /// create,update,delete records
        /// </summary>
        /// <param name="sqlFileName">sql file name</param>
        /// <param name="sqlId">sql id</param>
        /// <param name="pmsDictList">parameters list</param>
        /// <returns>create,update,delete quantity</returns>
        public int CUD(string sqlFileName, string sqlId, List<Dictionary<string, object>> pmsDictList = null)
        {
            string sql = FetchSqlById(sqlFileName, sqlId);
            if (string.IsNullOrWhiteSpace(sql))
            {
                return -10;
            }
            IDbConnection con = DbConnectionFactory.Con;
            if (con == null)
            {
                return -11;
            }
            try
            {
                return SqlMapper.Execute(con, sql, pmsDictList);
            }
            catch (Exception ex)
            {
                LogTool.Error(ex);
                return -12;
            }
        }

        /// <summary>
        /// create,update,delete records
        /// </summary>
        /// <param name="sqlFileName">sql file name</param>
        /// <param name="sqlId">sql id</param>
        /// <param name="pmsDict">parameters</param>
        /// <returns>create,update,delete quantity</returns>
        public int CUD(string sqlFileName, string sqlId, Dictionary<string, object> pmsDict)
        {
            string sql = FetchSqlById(sqlFileName, sqlId);
            if (string.IsNullOrWhiteSpace(sql))
            {
                return -10;
            }
            IDbConnection con = DbConnectionFactory.Con;
            if (con == null)
            {
                return -11;
            }
            try
            {
                return SqlMapper.Execute(con, sql, pmsDict);
            }
            catch (Exception ex)
            {
                LogTool.Error(ex);
                return -12;
            }
        }
        #endregion

        #region read
        /// <summary>
        /// read data
        /// </summary>
        /// <typeparam name="T">entity type</typeparam>
        /// <param name="sqlId">sql id</param>
        /// <param name="pmsDict">select parameter</param>
        /// <returns>data</returns>
        public List<T> Read<T>(string sqlId, Dictionary<string, object> pmsDict = null) where T : class
        {
            string sql = FetchSqlById<T>(sqlId);
            if (string.IsNullOrWhiteSpace(sql))
            {
                return null;
            }
            IDbConnection con = DbConnectionFactory.Con;
            if (con == null)
            {
                return null;
            }
            try
            {
                IEnumerable<T> tmp = SqlMapper.Query<T>(con, sql, pmsDict);
                if (tmp == null || tmp.Count<T>() <= 0)
                {
                    return null;
                }
                return tmp.ToList();
            }
            catch (Exception ex)
            {
                LogTool.Error(ex);
                return null;
            }
        }

        /// <summary>
        /// read data
        /// </summary>
        /// <typeparam name="T">entity type</typeparam>
        /// <param name="sqlId">sql id</param>
        /// <param name="pmsDict">parameter</param>
        /// <returns>data</returns>
        public T ReadSingle<T>(string sqlId, Dictionary<string, object> pmsDict) where T : class
        {
            string sql = FetchSqlById<T>(sqlId);
            if (string.IsNullOrWhiteSpace(sql))
            {
                return null;
            }
            IDbConnection con = DbConnectionFactory.Con;
            if (con == null)
            {
                return null;
            }
            try
            {
                IEnumerable<T> tmp = SqlMapper.Query<T>(con, sql, pmsDict);
                if (tmp == null || tmp.Count<T>() != 1)
                {
                    return null;
                }
                return tmp.ToList()[0];
            }
            catch (Exception ex)
            {
                LogTool.Error(ex);
                return null;
            }
        }

        /// <summary>
        /// read data
        /// </summary>
        /// <typeparam name="T">entity type</typeparam>
        /// <param name="sqlId">sql id</param>
        /// <param name="entity">entity to complete</param>
        /// <returns>data</returns>
        public List<T> Read<T>(string sqlId, T entity) where T : class
        {
            string sql = FetchSqlById<T>(sqlId);
            if (string.IsNullOrWhiteSpace(sql))
            {
                return null;
            }
            IDbConnection con = DbConnectionFactory.Con;
            if (con == null)
            {
                return null;
            }
            try
            {
                IEnumerable<T> tmp = SqlMapper.Query<T>(con, sql, entity);
                if (tmp == null || tmp.Count<T>() <= 0)
                {
                    return null;
                }
                return tmp.ToList();
            }
            catch (Exception ex)
            {
                LogTool.Error(ex);
                return null;
            }
        }

        /// <summary>
        /// read data
        /// </summary>
        /// <typeparam name="T">entity type</typeparam>
        /// <param name="sqlId">sql id</param>
        /// <param name="entity">entity</param>
        /// <returns>data</returns>
        public T ReadSingle<T>(string sqlId, T entity) where T : class
        {
            string sql = FetchSqlById<T>(sqlId);
            if (string.IsNullOrWhiteSpace(sql))
            {
                return null;
            }
            IDbConnection con = DbConnectionFactory.Con;
            if (con == null)
            {
                return null;
            }
            try
            {
                IEnumerable<T> tmp = SqlMapper.Query<T>(con, sql, entity);
                if (tmp == null || tmp.Count<T>() != 1)
                {
                    return null;
                }
                return tmp.ToList()[0];
            }
            catch (Exception ex)
            {
                LogTool.Error(ex);
                return null;
            }
        }

        /// <summary>
        /// read data
        /// </summary>
        /// <param name="sqlFileName">sql file name</param>
        /// <param name="sqlId">sql id</param>
        /// <param name="pmsDict">parameters</param>
        /// <returns>data</returns>
        public List<Dictionary<string, object>> Read(string sqlFileName, string sqlId, Dictionary<string, object> pmsDict = null)
        {
            string sql = FetchSqlById(sqlFileName, sqlId);
            if (string.IsNullOrWhiteSpace(sql))
            {
                return null;
            }
            IDbConnection con = DbConnectionFactory.Con;
            if (con == null)
            {
                return null;
            }
            try
            {
                IEnumerable obj = SqlMapper.Query<dynamic>(con, sql, pmsDict).ToList();
                string tmpObj = JsonConvert.SerializeObject(obj);
                List<Dictionary<string, object>> res = JsonConvert.DeserializeObject<List<Dictionary<string, object>>>(tmpObj);
                return res;
            }
            catch (Exception ex)
            {
                LogTool.Error(ex);
                return null;
            }
        }

        /// <summary>
        /// read data
        /// </summary>
        /// <param name="sqlFileName">sql file name</param>
        /// <param name="sqlId">sql id</param>
        /// <param name="pmsDict">parameters</param>
        /// <returns>data</returns>
        public Dictionary<string, object> ReadSingle(string sqlFileName, string sqlId, Dictionary<string, object> pmsDict)
        {
            string sql = FetchSqlById(sqlFileName, sqlId);
            if (string.IsNullOrWhiteSpace(sql))
            {
                return null;
            }
            IDbConnection con = DbConnectionFactory.Con;
            if (con == null)
            {
                return null;
            }
            try
            {
                IEnumerable obj = SqlMapper.Query<dynamic>(con, sql, pmsDict).ToList();
                string tmpObj = JsonConvert.SerializeObject(obj);
                List<Dictionary<string, object>> res = JsonConvert.DeserializeObject<List<Dictionary<string, object>>>(tmpObj);
                if (res == null || res.Count != 1)
                {
                    return null;
                }
                return res[0];
            }
            catch (Exception ex)
            {
                LogTool.Error(ex);
                return null;
            }
        }

        /// <summary>
        /// read data
        /// </summary>
        /// <typeparam name="T">entity type</typeparam>
        /// <param name="sqlFileName">sql file name</param>
        /// <param name="sqlId">sql id</param>
        /// <param name="pmsDict">parameters</param> 
        /// <returns>data</returns>
        public List<T> Read<T>(string sqlFileName, string sqlId, Dictionary<string, object> pmsDict = null) where T : class
        {
            string sql = FetchSqlById(sqlFileName, sqlId);
            if (string.IsNullOrWhiteSpace(sql))
            {
                return null;
            }
            IDbConnection con = DbConnectionFactory.Con;
            if (con == null)
            {
                return null;
            }
            try
            {
                IEnumerable<T> tmp = SqlMapper.Query<T>(con, sql, pmsDict).ToList();
                if (tmp == null || tmp.Count() <= 1)
                {
                    return null;
                }
                return tmp.ToList();
            }
            catch (Exception ex)
            {
                LogTool.Error(ex);
                return null;
            }
        }

        /// <summary>
        /// read data
        /// </summary>
        /// <typeparam name="T">entity type</typeparam>
        /// <param name="sqlFileName">sql file name</param>
        /// <param name="sqlId">sql id</param>
        /// <param name="pmsDict">parameters</param>
        /// <returns>data</returns>
        public T ReadSingle<T>(string sqlFileName, string sqlId, Dictionary<string, object> pmsDict) where T : class
        {
            string sql = FetchSqlById(sqlFileName, sqlId);
            if (string.IsNullOrWhiteSpace(sql))
            {
                return null;
            }
            IDbConnection con = DbConnectionFactory.Con;
            if (con == null)
            {
                return null;
            }
            try
            {
                IEnumerable<T> tmp = SqlMapper.Query<T>(con, sql, pmsDict).ToList();
                if (tmp == null || tmp.Count() != 1)
                {
                    return null;
                }
                return tmp.ToList()[0];
            }
            catch (Exception ex)
            {
                LogTool.Error(ex);
                return null;
            }
        }
        #endregion

        #region ado
        /// <summary>
        /// execute scalar query sql
        /// </summary>
        /// <param name="sqlFileName">sql file name</param>
        /// <param name="sqlId">sql id</param>
        /// <param name="pmsDict">parameters</param>
        /// <returns>result string</returns>
        public object QueryObj(string sqlFileName, string sqlId, Dictionary<string, object> pmsDict)
        {
            string sql = FetchSqlById(sqlFileName, sqlId);
            if (string.IsNullOrWhiteSpace(sql))
            {
                return null;
            }
            IDbConnection con = DbConnectionFactory.Con;
            if (con == null)
            {
                return null;
            }
            try
            {
                object obj = SqlMapper.ExecuteScalar(con, sql, pmsDict, null, null, null);
                return obj;
            }
            catch (Exception ex)
            {
                LogTool.Error(ex);
                return null;
            }
        }

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
        public List<T> Page<T>(string countSqlId, string pageSqlId, int pageIndex, int pageSize, out int total, Dictionary<string, object> pmsDict = null) where T : class
        {
            pmsDict = pmsDict == null ? new Dictionary<string, object>() : pmsDict;
            if (pmsDict.Keys.Contains("pageIndex"))
            {
                pmsDict["pageIndex"] = pageIndex;
            }
            else
            {
                pmsDict.Add("pageIndex", pageIndex);
            }
            if (pmsDict.Keys.Contains("pageSize"))
            {
                pmsDict["pageSize"] = pageSize;
            }
            else
            {
                pmsDict.Add("pageSize", pageSize);
            }
            total = ConvertTool.GetInt(QueryObj(FetchSqlFileNameByType<T>(), countSqlId, pmsDict));
            List<T> res = Read<T>(pageSqlId, pmsDict);
            if (total > 0 && res != null && res.Count > 0)
            {
                return res;
            }
            else
            {
                total = 0;
                return null;
            }
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
            object obj = QueryObj(sqlFileName, sqlId, pmsDict);
            return ConvertTool.GetInt(obj) > 0;
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
            object obj = QueryObj(FetchSqlFileNameByType<T>(), sqlId, ConvertEntityToParameters<T>(entity));
            return ConvertTool.GetInt(obj) > 0;
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
            object obj = QueryObj(FetchSqlFileNameByType<T>(), sqlId, ConvertEntityToParameters<T>(entity));
            return ConvertTool.GetInt(obj);
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
            object obj = QueryObj(sqlFileName, sqlId, pmsDict);
            return ConvertTool.GetInt(obj);
        }
        #endregion

        #region basic function
        /// <summary>
        /// fetch sql string from config file
        /// </summary>
        /// <param name="sqlFileName">sql file name</param>
        /// <param name="sqlId">sql id</param>
        /// <param name="sqlFilePath">sql config file path</param>
        /// <returns>sql string</returns>
        private string FetchSqlById(string sqlFileName, string sqlId, string sqlFilePath = null)
        {
            if (string.IsNullOrWhiteSpace(sqlFileName) || string.IsNullOrWhiteSpace(sqlId))
            {
                return string.Empty;
            }
            string sqlXPath = string.Format("/sqls/sql[@id='{0}']", sqlId);
            if (string.IsNullOrWhiteSpace(sqlFilePath))
            {
                sqlFilePath = AppDomain.CurrentDomain.BaseDirectory + string.Format("Config\\Sqls\\{0}Sqls.xml", sqlFileName);
            }
            return XmlTool.GetNodeValueByXPath(sqlXPath, sqlFilePath, false);
        }

        /// <summary>
        /// fetch sql string from config file
        /// </summary>
        /// <typeparam name="T">entity type</typeparam>
        /// <param name="sqlId">sql id</param>
        /// <param name="sqlFilePath">sql config file path</param>
        /// <returns>sql string</returns>
        private string FetchSqlById<T>(string sqlId, string sqlFilePath = null) where T : class
        {
            string sqlFileName = FetchSqlFileNameByType<T>();
            return FetchSqlById(sqlFileName, sqlId, sqlFilePath);
        }

        /// <summary>
        /// fetch the sql file name by type
        /// </summary>
        /// <typeparam name="T">entity type</typeparam>
        /// <returns>sql file name</returns>
        private string FetchSqlFileNameByType<T>() where T : class
        {
            Type t = typeof(T);
            if (string.IsNullOrWhiteSpace(t.Name))
            {
                return null;
            }
            List<string> typeNamePart = t.Name.Split(new char[] { '_' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            if (typeNamePart == null || typeNamePart.Count <= 0)
            {
                return null;
            }
            StringBuilder sb = new StringBuilder();
            typeNamePart.ForEach(a =>
            {
                sb.Append(a.Substring(0, 1).ToUpper() + a.Substring(1).ToLower());
            });
            if (sb == null || sb.Length <= 0)
            {
                return null;
            }
            return sb.ToString();
        }
        /// <summary>
        /// convert entity to parameters
        /// </summary>
        /// <typeparam name="T">entity type</typeparam>
        /// <param name="entity">entity data</param>
        /// <returns>parameters</returns>
        public static Dictionary<string, object> ConvertEntityToParameters<T>(T entity) where T : class
        {
            Type t = typeof(T);
            if (string.IsNullOrWhiteSpace(t.Name))
            {
                return null;
            }
            PropertyInfo[] properties = t.GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            StringBuilder sb = new StringBuilder();
            Dictionary<string, object> res = new Dictionary<string, object>();
            foreach (PropertyInfo item in properties)
            {
                List<string> nameParts = item.Name.Split(new char[] { '_' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                object val = item.GetValue(entity, null);
                if (nameParts == null || nameParts.Count <= 0 || val == null)
                {
                    continue;
                }
                for (int i = 0; i < nameParts.Count; i++)
                {
                    if (i == 0)
                    {
                        sb.Append(nameParts[i].ToLower());
                    }
                    else
                    {
                        sb.Append(nameParts[i].ToLower()[0]);
                        sb.Append(nameParts[i].ToLower().Substring(1));
                    }
                }
                res.Add(sb.ToString(), val);
                sb.Clear();
            };
            return res;
        }

        /// <summary>
        /// json string convert to entity list
        /// </summary>
        /// <typeparam name="T">entity</typeparam>
        /// <param name="jsonStr">json string</param>
        /// <returns>entity list</returns>
        private List<T> ConvertJsonStringToList<T>(string jsonStr) where T : class
        {
            if (string.IsNullOrEmpty((jsonStr ?? string.Empty).Trim()))
            {
                return null;
            }
            List<T> res = null;
            JToken jToken = JToken.Parse(jsonStr);
            if (jToken is JObject)
            {
                res = new List<T>();
                T entity = JsonConvert.DeserializeObject<T>(jsonStr);
                res.Add(entity);
            }
            else if (jToken is JArray)
            {
                res = JsonConvert.DeserializeObject<List<T>>(jsonStr);
            }
            return res;
        }

        /// <summary>
        /// json string convert to entity list
        /// </summary>
        /// <param name="jsonStr">json string, dictionary source</param>
        /// <returns>entity list</returns>
        private List<DynamicParameters> ConvertJsonStringToDynamicPmsList(string jsonStr)
        {
            if (string.IsNullOrEmpty((jsonStr ?? string.Empty).Trim()))
            {
                return null;
            }
            List<DynamicParameters> res = null;
            JToken jToken = JToken.Parse(jsonStr);
            if (jToken is JObject)
            {
                res = new List<DynamicParameters>();
                Dictionary<string, object> entity = JsonConvert.DeserializeObject<Dictionary<string, object>>(jsonStr);
                if (entity != null && entity.Count > 0)
                {
                    res.Add(ConvertKeyValuePairToDynamicPms(entity));
                }
            }
            else if (jToken is JArray)
            {
                List<Dictionary<string, object>> entities = JsonConvert.DeserializeObject<List<Dictionary<string, object>>>(jsonStr);
                if (entities != null || entities.Count > 0)
                {
                    res = new List<DynamicParameters>();
                    foreach (var item in entities)
                    {
                        if (item != null && item.Count > 0)
                        {
                            res.Add(ConvertKeyValuePairToDynamicPms(item));
                        }
                    }
                }
            }
            return res;
        }

        /// <summary>
        /// json string convert to entity list
        /// </summary>
        /// <param name="jsonStr">json string, dictionary source</param>
        /// <returns>entity list</returns>
        private List<Dictionary<string, object>> ConvertJsonStringToKeyValuePairList(string jsonStr)
        {
            if (string.IsNullOrEmpty((jsonStr ?? string.Empty).Trim()))
            {
                return null;
            }
            List<Dictionary<string, object>> res = null;
            JToken jToken = JToken.Parse(jsonStr);
            if (jToken is JObject)
            {
                res = new List<Dictionary<string, object>>();
                Dictionary<string, object> entity = JsonConvert.DeserializeObject<Dictionary<string, object>>(jsonStr);
                if (entity != null && entity.Count > 0)
                {
                    res.Add(entity);
                }
            }
            else if (jToken is JArray)
            {
                List<Dictionary<string, object>> entities = JsonConvert.DeserializeObject<List<Dictionary<string, object>>>(jsonStr);
                if (entities != null || entities.Count > 0)
                {
                    res = new List<Dictionary<string, object>>();
                    foreach (var item in entities)
                    {
                        if (item != null && item.Count > 0)
                        {
                            res.Add(item);
                        }
                    }
                }
            }
            return res;
        }

        /// <summary>
        /// key_value pair list convert to dynamic parameters list
        /// </summary>
        /// <param name="pmsReflectList">key_value pair list</param>
        /// <returns>dynamic parameters list</returns>
        private List<DynamicParameters> ConvertKeyValuePairListToDynamicPmsList(List<Dictionary<string, object>> pmsReflectList)
        {
            if (pmsReflectList == null || pmsReflectList.Count <= 0)
            {
                return null;
            }
            pmsReflectList = pmsReflectList.Where(a => { return a != null && a.Count > 0; }).ToList();
            if (pmsReflectList == null || pmsReflectList.Count <= 0)
            {
                return null;
            }
            return pmsReflectList.Select(a => { return ConvertKeyValuePairToDynamicPms(a); }).ToList();
        }

        /// <summary>
        /// convert object to dynamic parameters list
        /// </summary>
        /// <param name="pmsName">parameter name</param>
        /// <param name="data">parameter data</param>
        /// <returns>dynamic parameters list</returns>
        private List<DynamicParameters> ConvertObjectToDynamicPmsList(string pmsName, object data)
        {
            if (string.IsNullOrWhiteSpace(pmsName))
            {
                return null;
            }
            if (data == null)
            {
                return null;
            }
            List<DynamicParameters> res = null;
            IEnumerable tmp = data as IEnumerable;
            if (tmp == null)
            {
                res = new List<DynamicParameters>();
                DynamicParameters record = new DynamicParameters();
                record.Add(pmsName, data, null, null, null);
                res.Add(record);
            }
            else
            {
                var obj = tmp.Cast<object>();
                if (obj == null || obj.Count<object>() <= 0)
                {
                    return null;
                }
                res = new List<DynamicParameters>();
                obj.ToList().ForEach(a =>
                {
                    DynamicParameters record = new DynamicParameters();
                    record.Add(pmsName, a, null, null, null);
                    res.Add(record);
                });
            }
            return res;
        }

        /// <summary>
        /// convert key_value pair to dynamic parameters
        /// </summary>
        /// <param name="pmsReflect">key_value pair</param>
        /// <returns>dynamic parameters</returns>
        private DynamicParameters ConvertKeyValuePairToDynamicPms(Dictionary<string, object> pmsReflect)
        {
            DynamicParameters pms = null;
            if (pmsReflect != null && pmsReflect.Count > 0)
            {
                pms = new DynamicParameters();
                foreach (var item in pmsReflect.Keys)
                {
                    if (string.IsNullOrWhiteSpace(item))
                    {
                        continue;
                    }
                    if (pmsReflect[item] == null)
                    {
                        continue;
                    }
                    pms.Add(item, pmsReflect[item], null, null, null);
                }
            }
            return pms;
        }
        #endregion basic function
    }
}
