using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Andafa.Mes.Common.Extensions
{
    /// <summary>
    /// object extension
    /// </summary>
    public static class ObjectExtension
    {
        /// <summary>
        /// set property value
        /// </summary>
        /// <param name="destinyObj">destiny object</param>
        /// <param name="propertyName">property name</param>
        /// <param name="propertyValue">property value</param>
        /// <returns>is set property value succeed</returns>
        private static bool SetPropertyValue(this object destinyObj, string propertyName, object propertyValue)
        {
            bool res = false;
            Type t = destinyObj.GetType();
            PropertyInfo pi = t.GetProperty(propertyName, BindingFlags.Instance | BindingFlags.Public);
            try
            {
                if (propertyValue != null && pi.PropertyType.FullName.Contains(propertyValue.GetType().FullName))
                {
                    pi.SetValue(destinyObj, propertyValue, null);
                    res = true;
                }
            }
            catch (Exception)
            {
                res = false;
            }
            return res;
        }

        /// <summary>
        /// get property value
        /// </summary>
        /// <param name="destinyObj">destiny object</param>
        /// <param name="propertyName">property name</param>
        /// <returns>property value</returns>
        public static object GetPropertyValue(this object destinyObj, string propertyName)
        {
            Type t = destinyObj.GetType();
            PropertyInfo pi = t.GetProperty(propertyName, BindingFlags.Instance | BindingFlags.Public);
            return pi.GetValue(destinyObj, null);
        }

        /// <summary>
        /// get property value
        /// </summary>
        /// <param name="destinyObj">destiny object</param>
        /// <param name="propertyName">property name</param>
        /// <returns>properties value</returns>
        public static Dictionary<string, string> GetPropertiesValue(this object destinyObj)
        {
            Type t = destinyObj.GetType();
            PropertyInfo[] pis = t.GetProperties(BindingFlags.Instance | BindingFlags.Public);
            Dictionary<string, string> res = null;
            foreach (PropertyInfo item in pis)
            {
                res.Add(item.Name, (item.GetValue(destinyObj, null) ?? string.Empty).ToString());
            }
            return res;
        }
    }
}
