using Andafa.Mes.Common.Tools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;

namespace Andafa.Mes.WebApiUtility
{
    /// <summary>
    /// web api utility
    /// </summary>
    public class ApiUtility:IApiUtility
    {
        /// <summary>
        /// read model list
        /// </summary>
        /// <typeparam name="T">model type</typeparam>
        /// <param name="pms">query parameter</param>
        /// <returns>model list</returns>
        public List<T> GetAny<T>(Dictionary<string, object> pms = null) where T : class
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    //clear http request header
                    client.DefaultRequestHeaders.Clear();
                    //add http request header media type
                    client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                    //add http request text type
                    client.DefaultRequestHeaders.AcceptCharset.Add(new StringWithQualityHeaderValue("utf-8"));
                    //create http request url
                    string url = string.Empty;
                    if (pms == null || pms.Count <= 0)
                    {
                        url = string.Format("http://{0}:{1}/api/{2}", WebApiHost, WebApiPort, typeof(T).Name.ToLower());//api/{controller}
                    }
                    else
                    {
                        string tmp = JsonConvert.SerializeObject(pms);
                        url = string.Format("http://{0}:{1}/api/{2}/getlist?pmsStr={3}", WebApiHost, WebApiPort, typeof(T).Name.ToLower(), tmp);//api/{controller}/getlist/{pmsStr}
                    }
                    //send request
                    HttpResponseMessage response = client.GetAsync(url).Result;
                    //get response
                    int statusCode = (int)response.StatusCode;
                    //result analysis
                    if (response.IsSuccessStatusCode)
                    {
                        return response.Content.ReadAsAsync<List<T>>().Result;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                LogTool.Error(ex);
                return null;
            }
        }

        /// <summary>
        /// read model
        /// </summary>
        /// <typeparam name="T">model type</typeparam>
        /// <param name="pms">query parameter</param>
        /// <returns>model</returns>
        public T GetOne<T>(Dictionary<string, object> pms) where T : class
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    //clear http request header
                    client.DefaultRequestHeaders.Clear();
                    //add http request header media type
                    client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                    //add http request text type
                    client.DefaultRequestHeaders.AcceptCharset.Add(new StringWithQualityHeaderValue("utf-8"));
                    string tmp = JsonConvert.SerializeObject(pms);
                    //create http request url
                    string url = string.Format("http://{0}:{1}/api/{2}/getsingle?pmsStr={3}", WebApiHost, WebApiPort, typeof(T).Name.ToLower(), tmp);//api/{controller}/getsingle/{PmsStr}
                    //send request
                    HttpResponseMessage response = client.GetAsync(url).Result;
                    //get response
                    int statusCode = (int)response.StatusCode;
                    //result analysis
                    if (response.IsSuccessStatusCode)
                    {
                        return response.Content.ReadAsAsync<T>().Result;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                LogTool.Error(ex);
                return null;
            }
        }

        /// <summary>
        /// create model
        /// </summary>
        /// <typeparam name="T">model type</typeparam>
        /// <param name="model">model value</param>
        /// <returns>create resut</returns>
        public bool Post<T>(T model) where T : class
        {
            return Post(new List<T>() { model });
        }

        /// <summary>
        /// create model list
        /// </summary>
        /// <typeparam name="T">model type</typeparam>
        /// <param name="modelList">model list value</param>
        /// <returns>create resut</returns>
        public bool Post<T>(List<T> modelList) where T : class
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    //clear http request header
                    client.DefaultRequestHeaders.Clear();
                    //add http request header media type
                    client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                    //add http request text type
                    client.DefaultRequestHeaders.AcceptCharset.Add(new StringWithQualityHeaderValue("utf-8"));
                    //create http request url
                    string url = string.Format("http://{0}:{1}/api/{2}", WebApiHost, WebApiPort, typeof(T).Name.ToLower());//api/{controller}
                    //send request
                    HttpResponseMessage response = client.PostAsJsonAsync(url, modelList).Result;
                    //get response
                    int statusCode = (int)response.StatusCode;
                    return response.IsSuccessStatusCode;
                }
            }
            catch (Exception ex)
            {
                LogTool.Error(ex);
                return false;
            }
        }

        /// <summary>
        /// update model
        /// </summary>
        /// <typeparam name="T">model type</typeparam>
        /// <param name="model">model data</param>
        /// <returns>update result</returns>
        public bool Put<T>(T model) where T : class
        {
            return Put(new List<T>() { model });
        }

        /// <summary>
        /// update model List
        /// </summary>
        /// <typeparam name="T">model type</typeparam>
        /// <param name="modelList">model list data</param>
        /// <returns>update result</returns>
        public bool Put<T>(List<T> modelList) where T : class
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    //clear http request header
                    client.DefaultRequestHeaders.Clear();
                    //add http request header media type
                    client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                    //add http request text type
                    client.DefaultRequestHeaders.AcceptCharset.Add(new StringWithQualityHeaderValue("utf-8"));
                    //create http request url
                    string url = string.Format("http://{0}:{1}/api/{2}", WebApiHost, WebApiPort, typeof(T).Name.ToLower());//api/{controller}
                    //send request
                    HttpResponseMessage response = client.PutAsJsonAsync(url, modelList).Result;
                    //get response
                    int statusCode = (int)response.StatusCode;
                    return response.IsSuccessStatusCode;
                }
            }
            catch (Exception ex)
            {
                LogTool.Error(ex);
                return false;
            }
        }

        /// <summary>
        /// delete record
        /// </summary>
        /// <typeparam name="T">model type</typeparam>
        /// <param name="pms">query parameter</param>
        /// <returns>delete result</returns>
        public bool Delete<T>(Dictionary<string, object> pms) where T : class
        {
            return Delete<T>(new List<Dictionary<string, object>>() { pms });
        }

        /// <summary>
        /// delete records
        /// </summary>
        /// <typeparam name="T">model type</typeparam>
        /// <param name="pmsList">query parameter list</param>
        /// <returns>delete result</returns>
        public bool Delete<T>(List<Dictionary<string, object>> pmsList) where T : class
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    //clear http request header
                    client.DefaultRequestHeaders.Clear();
                    //add http request header media type
                    client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                    //add http request text type
                    client.DefaultRequestHeaders.AcceptCharset.Add(new StringWithQualityHeaderValue("utf-8"));
                    //create http request url
                    string url = string.Format("http://{0}:{1}/api/{2}", WebApiHost, WebApiPort, typeof(T).Name.ToLower());//api/{controller}
                    //create content
                    ObjectContent<List<Dictionary<string, object>>> content = new ObjectContent<List<Dictionary<string, object>>>(pmsList, new JsonMediaTypeFormatter());
                    //send request
                    HttpResponseMessage response = client.SendAsync(new HttpRequestMessage(HttpMethod.Delete, url) { Content = content }, CancellationToken.None).Result;
                    //get response
                    int statusCode = (int)response.StatusCode;
                    return response.IsSuccessStatusCode;
                }
            }
            catch (Exception ex)
            {
                LogTool.Error(ex);
                return false;
            }
        }

        /// <summary>
        /// page
        /// </summary>
        /// <typeparam name="T">model type</typeparam>
        /// <param name="pageIndex">page index</param>
        /// <param name="pageSize">page size</param>
        /// <returns>page result</returns>
        public Tuple<int, List<T>> Page<T>(int pageIndex, int pageSize) where T : class
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    //clear http request header
                    client.DefaultRequestHeaders.Clear();
                    //add http request header media type
                    client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                    //add http request text type
                    client.DefaultRequestHeaders.AcceptCharset.Add(new StringWithQualityHeaderValue("utf-8"));
                    //create http request url
                    string url = string.Format("http://{0}:{1}/api/{2}?pageindex={3}&pagesize={4}", WebApiHost, WebApiPort, typeof(T).Name.ToLower(), pageIndex.ToString(), pageSize.ToString());
                    //send request
                    HttpResponseMessage response = client.GetAsync(url).Result;
                    //get response
                    int statusCode = (int)response.StatusCode;
                    //result analysis
                    if (response.IsSuccessStatusCode)
                    {
                        return response.Content.ReadAsAsync<Tuple<int, List<T>>>().Result;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                LogTool.Error(ex);
                return null;
            }
        }

        /// <summary>
        /// is web api exist
        /// </summary>
        /// <returns>web api exist result</returns>
        public bool GetExist()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    //clear http request header
                    client.DefaultRequestHeaders.Clear();
                    //add http request header media type
                    client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                    //add http request text type
                    client.DefaultRequestHeaders.AcceptCharset.Add(new StringWithQualityHeaderValue("utf-8"));
                    //create http request url
                    string url = string.Format("http://{0}:{1}/api/basic", WebApiHost, WebApiPort);
                    //send request
                    HttpResponseMessage response = client.GetAsync(url).Result;
                    //get response
                    int statusCode = (int)response.StatusCode;
                    //result analysis
                    if (response.IsSuccessStatusCode)
                    {
                        return response.Content.ReadAsAsync<bool>().Result;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                LogTool.Error(ex);
                return false;
            }
        }

        /// <summary>
        /// run sql to get int by post
        /// </summary>
        /// <param name="sqlFileName">sql file name</param>
        /// <param name="sqlId">sql id</param>
        /// <param name="pms">qurey parameter</param>
        /// <returns>int result</returns>
        public int Post(string sqlFileName, string sqlId, Dictionary<string, object> pms)
        {
            return Post(sqlFileName, sqlId, new List<Dictionary<string, object>>() { pms });
        }

        /// <summary>
        /// run sql to get int by post
        /// </summary>
        /// <param name="sqlFileName">sql file name</param>
        /// <param name="sqlId">sql id</param>
        /// <param name="pmsList">qurey parameter list</param>
        /// <returns>int result</returns>
        public int Post(string sqlFileName, string sqlId, List<Dictionary<string, object>> pmsList)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    //clear http request header
                    client.DefaultRequestHeaders.Clear();
                    //add http request header media type
                    client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                    //add http request text type
                    client.DefaultRequestHeaders.AcceptCharset.Add(new StringWithQualityHeaderValue("utf-8"));
                    //create http request url
                    string url = string.Format("http://{0}:{1}/api/ado/post/{2}/{3}", WebApiHost, WebApiPort, sqlFileName, sqlId);//api/{sqlFileName}/{sqlId}
                    //send request
                    HttpResponseMessage response = client.PostAsJsonAsync(url, pmsList).Result;
                    //get response
                    int statusCode = (int)response.StatusCode;
                    //result analysis
                    if (response.IsSuccessStatusCode)
                    {
                        return response.Content.ReadAsAsync<int>().Result;
                    }
                    return 0;
                }
            }
            catch (Exception ex)
            {
                LogTool.Error(ex);
                return 0;
            }
        }

        /// <summary>
        /// run sql in record by get
        /// </summary>
        /// <param name="sqlFileName">sql file name</param>
        /// <param name="sqlId">sql id</param>
        /// <param name="pms">query parameters</param>
        /// <returns>record</returns>
        public Dictionary<string, object> GetDict(string sqlFileName, string sqlId, Dictionary<string, object> pms)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    //clear http request header
                    client.DefaultRequestHeaders.Clear();
                    //add http request header media type
                    client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                    //add http request text type
                    client.DefaultRequestHeaders.AcceptCharset.Add(new StringWithQualityHeaderValue("utf-8"));
                    string tmp = JsonConvert.SerializeObject(pms);
                    //create http request url
                    string url = string.Format("http://{0}:{1}/api/ado/getdict/{2}/{3}?pmsStr={4}", WebApiHost, WebApiPort, sqlFileName, sqlId, tmp);//api/{sqlFileName}/{sqlId}/one/{pmsStr}
                    //send request
                    HttpResponseMessage response = client.GetAsync(url).Result;
                    //get response
                    int statusCode = (int)response.StatusCode;
                    //result analysis
                    if (response.IsSuccessStatusCode)
                    {
                        return response.Content.ReadAsAsync<Dictionary<string, object>>().Result;
                    }
                    return null;
                }
            }
            catch (Exception ex)
            {
                LogTool.Error(ex);
                return null;
            }
        }

        /// <summary>
        /// run sql in record list by get
        /// </summary>
        /// <param name="sqlFileName">sql file name</param>
        /// <param name="sqlId">sql id</param>
        /// <param name="pms">query parameters</param>
        /// <returns>record list</returns>
        public List<Dictionary<string, object>> GetDictList(string sqlFileName, string sqlId, Dictionary<string, object> pms)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    //clear http request header
                    client.DefaultRequestHeaders.Clear();
                    //add http request header media type
                    client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                    //add http request text type
                    client.DefaultRequestHeaders.AcceptCharset.Add(new StringWithQualityHeaderValue("utf-8"));
                    string tmp = JsonConvert.SerializeObject(pms);
                    //create http request url
                    string url = string.Format("http://{0}:{1}/api/ado/getdictlist/{2}/{3}?pmsStr={4}", WebApiHost, WebApiPort, sqlFileName, sqlId, tmp);//api/{sqlFileName}/{sqlId}/any/{pmsStr}
                    //send request
                    HttpResponseMessage response = client.GetAsync(url).Result;
                    //get response
                    int statusCode = (int)response.StatusCode;
                    //result analysis
                    if (response.IsSuccessStatusCode)
                    {
                        return response.Content.ReadAsAsync<List<Dictionary<string, object>>>().Result;
                    }
                    return null;
                }
            }
            catch (Exception ex)
            {
                LogTool.Error(ex);
                return null;
            }
        }

        /// <summary>
        /// run sql in object by get
        /// </summary>
        /// <param name="sqlFileName">sql file name</param>
        /// <param name="sqlId">sql id</param>
        /// <param name="pms">query parameters</param>
        /// <returns>object</returns>
        public object GetObj(string sqlFileName, string sqlId, Dictionary<string, object> pms)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    //clear http request header
                    client.DefaultRequestHeaders.Clear();
                    //add http request header media type
                    client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                    //add http request text type
                    client.DefaultRequestHeaders.AcceptCharset.Add(new StringWithQualityHeaderValue("utf-8"));
                    string tmp = JsonConvert.SerializeObject(pms);
                    //create http request url
                    string url = string.Format("http://{0}:{1}/api/ado/getobj/{2}/{3}?pmsStr={4}", WebApiHost, WebApiPort, sqlFileName, sqlId, tmp);//api/{sqlFileName}/{sqlId}/obj/{pmsStr}
                    //send request
                    HttpResponseMessage response = client.GetAsync(url).Result;
                    //get response
                    int statusCode = (int)response.StatusCode;
                    //result analysis
                    if (response.IsSuccessStatusCode)
                    {
                        return response.Content.ReadAsAsync<object>().Result;
                    }
                    return null;
                }
            }
            catch (Exception ex)
            {
                LogTool.Error(ex);
                return null;
            }
        }

        /// <summary>
        /// get webapi host
        /// </summary>
        private string WebApiHost
        {
            get
            {
                string path = AppDomain.CurrentDomain.BaseDirectory + "Config\\WebApiConfig.xml";
                string xPath = "/appSet/WebApiHost";
                string res = XmlTool.GetNodeValueByXPath(xPath, path);
                return string.IsNullOrWhiteSpace(res) ? "localhost" : res;
            }
        }

        /// <summary>
        /// get webapi port
        /// </summary>
        private string WebApiPort
        {
            get
            {
                string path = AppDomain.CurrentDomain.BaseDirectory + "Config\\WebApiConfig.xml";
                string xPath = "/appSet/WebApiPort";
                string res = XmlTool.GetNodeValueByXPath(xPath, path);
                return string.IsNullOrWhiteSpace(res) ? "54800" : res;
            }
        }
    }
}
