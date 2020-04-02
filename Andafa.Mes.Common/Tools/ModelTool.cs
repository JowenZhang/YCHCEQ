using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Andafa.Mes.Common.Tools
{
    /// <summary>
    /// model tool
    /// </summary>
    public static class ModelTool
    {
        /// <summary>
        /// convert key-value pair to model
        /// </summary>
        /// <typeparam name="T">model type</typeparam>
        /// <param name="source">key-value pair</param>
        /// <returns>model</returns>
        public static T GetModel<T>(Dictionary<string, object> source) where T : class
        {
            if (source == null || source.Count <= 0)
            {
                return null;
            }
            Type type = typeof(T);
            PropertyInfo[] propertyInfos = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            if (propertyInfos == null || propertyInfos.Length <= 0)
            {
                return null;
            }
            T res = Activator.CreateInstance<T>();
            try
            {
                foreach (PropertyInfo item in propertyInfos)
                {
                    if (item == null || string.IsNullOrWhiteSpace(item.Name.ToLower()) || !source.Keys.Contains(item.Name.ToLower()))
                    {
                        continue;
                    }
                    SetPropertyValue(item, res, source[item.Name.ToLower()]);
                }
            }
            catch (Exception ex)
            {
                LogTool.Error(ex);
                return null;
            }
            return res.Equals(Activator.CreateInstance<T>()) ? null : res;
        }

        /// <summary>
        /// convert key-value pair list to model
        /// </summary>
        /// <typeparam name="T">model type</typeparam>
        /// <param name="source">key-value pair list</param>
        /// <returns>model in first</returns>
        public static T GetModel<T>(List<Dictionary<string, object>> source) where T : class
        {
            if (source == null || source.Count <= 0)
            {
                return null;
            }
            if (source[0] == null || source[0].Count <= 0)
            {
                return null;
            }
            Type type = typeof(T);
            PropertyInfo[] propertyInfos = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            if (propertyInfos == null || propertyInfos.Length <= 0)
            {
                return null;
            }
            T res = Activator.CreateInstance<T>();
            try
            {
                foreach (PropertyInfo item in propertyInfos)
                {
                    if (item == null || string.IsNullOrWhiteSpace(item.Name.ToLower()) || !source[0].Keys.Contains(item.Name.ToLower()))
                    {
                        continue;
                    }
                    SetPropertyValue(item, res, source[0][item.Name.ToLower()]);
                }
            }
            catch (Exception ex)
            {
                LogTool.Error(ex);
                return null;
            }
            return res.Equals(Activator.CreateInstance<T>()) ? null : res;
        }

        /// <summary>
        /// convert key-value pair to model
        /// </summary>
        /// <typeparam name="T">model type</typeparam>
        /// <param name="source">key-value pair</param>
        /// <returns>model</returns>
        public static List<T> GetModelList<T>(Dictionary<string, object> source) where T : class
        {
            if (source == null || source.Count <= 0)
            {
                return null;
            }
            Type type = typeof(T);
            PropertyInfo[] propertyInfos = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            if (propertyInfos == null || propertyInfos.Length <= 0)
            {
                return null;
            }
            T tmp = Activator.CreateInstance<T>();
            try
            {
                foreach (PropertyInfo item in propertyInfos)
                {
                    if (item == null || string.IsNullOrWhiteSpace(item.Name.ToLower()) || !source.Keys.Contains(item.Name.ToLower()))
                    {
                        continue;
                    }
                    SetPropertyValue(item, tmp, source[item.Name.ToLower()]);
                }
            }
            catch (Exception ex)
            {
                LogTool.Error(ex);
                return null;
            }
            List<T> res = new List<T>();
            if (!res.Contains(tmp) && !res.Equals(Activator.CreateInstance<T>()))
            {
                res.Add(tmp);
            }
            return res.Count <= 0 ? null : res;
        }

        /// <summary>
        /// convert key-value pair to model
        /// </summary>
        /// <typeparam name="T">model type</typeparam>
        /// <param name="source">key-value pair list</param>
        /// <returns>model</returns>
        public static List<T> GetModelList<T>(List<Dictionary<string, object>> source) where T : class
        {
            if (source == null || source.Count <= 0)
            {
                return null;
            }
            Type type = typeof(T);
            PropertyInfo[] propertyInfos = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            if (propertyInfos == null || propertyInfos.Length <= 0)
            {
                return null;
            }
            List<T> res = new List<T>();
            try
            {
                foreach (Dictionary<string, object> itemSource in source)
                {
                    if (itemSource == null || itemSource.Count <= 0)
                    {
                        continue;
                    }
                    foreach (PropertyInfo item in propertyInfos)
                    {
                        T tmp = Activator.CreateInstance<T>();
                        if (item == null || string.IsNullOrWhiteSpace(item.Name.ToLower()) || !itemSource.Keys.Contains(item.Name.ToLower()))
                        {
                            continue;
                        }
                        SetPropertyValue(item, tmp, itemSource[item.Name.ToLower()]);
                        if (!res.Contains(tmp) && !res.Equals(Activator.CreateInstance<T>()))
                        {
                            res.Add(tmp);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LogTool.Error(ex);
                return null;
            }
            return res.Count <= 0 ? null : res;
        }

        /// <summary>
        /// set property value to destiny object
        /// </summary>
        /// <param name="pi">prpperty info</param>
        /// <param name="destiny">destiny object</param>
        /// <param name="value">value</param>
        private static void SetPropertyValue(PropertyInfo pi, object destiny, object value)
        {
            if (pi == null || destiny == null)
            {
                return;
            }
            string type = pi.PropertyType.ToString();
            type = Regex.Match(type, type.IndexOf("[") > -1 ? @"(?<=\[\w+\.)[^\]]+" : @"(?<=\.)\w+").Value;
            switch (type)
            {
                case "Boolean": pi.SetValue(destiny, Boolean.Parse(ConvertTool.GetString(value)), null); break;
                case "Byte": pi.SetValue(destiny, Byte.Parse(ConvertTool.GetString(value)), null); break;
                case "Decimal": pi.SetValue(destiny, Decimal.Parse(ConvertTool.GetString(value)), null); break;
                case "Double": pi.SetValue(destiny, Double.Parse(ConvertTool.GetString(value)), null); break;
                case "DateTime": pi.SetValue(destiny, DateTime.Parse(ConvertTool.GetString(value)), null); break;
                case "Int16": pi.SetValue(destiny, Int16.Parse(ConvertTool.GetString(value)), null); break;
                case "Int32": pi.SetValue(destiny, Int32.Parse(ConvertTool.GetString(value)), null); break;
                case "Int64": pi.SetValue(destiny, Int64.Parse(ConvertTool.GetString(value)), null); break;
                case "Single": pi.SetValue(destiny, Single.Parse(ConvertTool.GetString(value)), null); break;
                //case "Entity":; break;
                default: pi.SetValue(destiny, value, null); break;
            }
        }

        /// <summary>
        /// compare model property value equal or not
        /// </summary>
        /// <typeparam name="T">model type</typeparam>
        /// <param name="a">value 1</param>
        /// <param name="b">value 2</param>
        /// <returns>compare result</returns>
        public static bool ACompareB<T>(T a, T b) where T : class
        {
            if (a == null && b == null)
            {
                return true;
            }
            if ((a == null && b != null) || (a != null && b == null))
            {
                return false;
            }
            Type type = typeof(T);
            PropertyInfo[] propertyInfos = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            if (propertyInfos == null || propertyInfos.Length <= 0)
            {
                return false;
            }
            try
            {
                foreach (PropertyInfo pi in propertyInfos)
                {
                    object tmpA = pi.GetValue(a, null);
                    object tmpB = pi.GetValue(b, null);
                    if (CompareValue(tmpA, tmpB, pi))
                    {
                        continue;
                    }
                    else
                    {
                        return false;
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                LogTool.Error(ex);
                return false;
            }
        }

        /// <summary>
        /// compare property object value
        /// </summary>
        /// <param name="tmpA">property value 1</param>
        /// <param name="tmpB">property value 1</param>
        /// <param name="pi">property info</param>
        /// <returns>compare result</returns>
        private static bool CompareValue(object tmpA, object tmpB, PropertyInfo pi)
        {
            if (tmpA == null || tmpB == null)
            {
                return false;
            }
            if (pi == null)
            {
                return false;
            }
            string type = pi.PropertyType.ToString();
            type = Regex.Match(type, type.IndexOf("[") > -1 ? @"(?<=\[\w+\.)[^\]]+" : @"(?<=\.)\w+").Value;
            switch (type)
            {
                case "Boolean":
                    return ConvertTool.GetBool(tmpA) == ConvertTool.GetBool(tmpB);
                case "Byte":
                    return ConvertTool.GetByte(tmpA) == ConvertTool.GetByte(tmpB);
                case "Decimal": return ConvertTool.GetDecimal(tmpA) == ConvertTool.GetDecimal(tmpB);
                case "Double": return ConvertTool.GetDouble(tmpA) == ConvertTool.GetDouble(tmpB);
                case "DateTime": return ConvertTool.GetDateTime(tmpA) == ConvertTool.GetDateTime(tmpB);
                case "Int16": return ConvertTool.GetShort(tmpA) == ConvertTool.GetShort(tmpB);
                case "Int32": return ConvertTool.GetInt(tmpA) == ConvertTool.GetInt(tmpB);
                case "Int64": return ConvertTool.GetLong(tmpA) == ConvertTool.GetLong(tmpB);
                case "Single": return ConvertTool.GetFloat(tmpA) == ConvertTool.GetFloat(tmpB);
                case "String": return ConvertTool.GetString(tmpA) == ConvertTool.GetString(tmpB);
                //case "Entity":; break;
                default: return false;
            }
        }

        /// <summary>
        /// get same element into list by model
        /// </summary>
        /// <typeparam name="T">model type</typeparam>
        /// <param name="listA">model list 1</param>
        /// <param name="listB">model list 2</param>
        /// <returns>same element list</returns>
        public static List<T> GetJoin<T>(List<T> listA, List<T> listB) where T : class
        {
            if (listA == null || listA.Count <= 0)
            {
                return null;
            }
            if (listB == null || listB.Count <= 0)
            {
                return null;
            }
            List<T> res = new List<T>();
            listB.ForEach(a =>
            {
                foreach (T item in listA)
                {
                    if (ModelTool.ACompareB(a, item))
                    {
                        res.Add(a);
                        break;
                    }
                }
            });
            return res.Count == 0 ? null : res;
        }

        /// <summary>
        /// get minus element into list by model
        /// </summary>
        /// <typeparam name="T">model type</typeparam>
        /// <param name="listA">model list 1</param>
        /// <param name="listB">model list 2</param>
        /// <returns>minus element list</returns>
        public static List<T> GetMinus<T>(List<T> listA, List<T> listB) where T : class
        {
            if (listA == null || listA.Count <= 0)
            {
                return null;
            }
            if (listB == null || listB.Count <= 0)
            {
                return listA;
            }
            List<T> res = new List<T>();
            listA.ForEach(a =>
            {
                bool flag = true;
                foreach (T item in listB)
                {
                    if (ModelTool.ACompareB(a, item))
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    res.Add(a);
                }
            });
            return res.Count == 0 ? null : res;
        }

        /// <summary>
        /// change object value to list
        /// </summary>
        /// <typeparam name="T">list element type</typeparam>
        /// <param name="val">object val</param>
        /// <returns>list</returns>
        public static List<T> ChangeObjectToList<T>(object val)
        {
            List<T> modelList = null;
            if (val is List<T>)
            {
                modelList = (List<T>)val;
            }
            if (modelList == null || modelList.Count <= 0)
            {
                if (val is T)
                {
                    modelList.Add((T)val);
                }
                else
                {
                    return null;
                }
            }
            return modelList.Distinct().ToList();
        }
    }
}
