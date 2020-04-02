using Andafa.Mes.Common.Tools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Andafa.Mes.MainWebSite.Tools
{
    /// <summary>
    /// controller tool
    /// </summary>
    public static class ControllerTool
    {
        /// <summary>
        /// add cookie
        /// </summary>
        /// <param name="key">cookie key</param>
        /// <param name="val">cookie value</param>
        public static void AddCookie(string key, object val)
        {
            HttpCookie cookie = new HttpCookie(key);
            cookie.Value = EncryptTool.Base64Encode(JsonConvert.SerializeObject(val));
            if (System.Web.HttpContext.Current.Request.Cookies.AllKeys.Contains(key))
            {
                HttpCookie cookieExist = System.Web.HttpContext.Current.Request.Cookies[key];
                cookieExist.Expires = DateTime.Now.AddDays(-3);
            }
            System.Web.HttpContext.Current.Response.Cookies.Add(cookie);
        }

        /// <summary>
        /// get cookie
        /// </summary>
        /// <typeparam name="T">value type</typeparam>
        /// <param name="key">cookie key</param>
        /// <returns>cookie value</returns>
        public static T GetCookie<T>(string key)
        {
            if (System.Web.HttpContext.Current.Request.Cookies.AllKeys.Contains(key))
            {
                string val = System.Web.HttpContext.Current.Request.Cookies[key].Value;
                if (string.IsNullOrWhiteSpace(val))
                {
                    return default(T);
                }
                else
                {
                    try
                    {
                        val = EncryptTool.Base64Decode(val);
                        return JsonConvert.DeserializeObject<T>(val);
                    }
                    catch (Exception ex)
                    {
                        LogTool.Error(ex);
                        return default(T);
                    }
                }
            }
            else
            {
                System.Web.HttpContext.Current.Response.Redirect("/");
                System.Web.HttpContext.Current.Response.End();
                return default(T);
            }
        }

        /// <summary>
        /// convert parameter string into key value
        /// </summary>
        /// <param name="pmsStr">parameter string</param>
        /// <returns>parameter key value</returns>
        public static Dictionary<string, object> ConvertPms(string pmsStr)
        {
            if (string.IsNullOrWhiteSpace(pmsStr))
            {
                return null;
            }
            try
            {
                return JsonConvert.DeserializeObject<Dictionary<string, object>>(EncryptTool.UrlDecode(pmsStr));
            }
            catch
            {
                return null;
            }
        }
    }
}