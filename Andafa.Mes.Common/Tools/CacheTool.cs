using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Caching;

namespace Andafa.Mes.Common.Tools
{
    /// <summary>
    /// cache tool
    /// </summary>
    public static class CacheTool
    {
        /// <summary>
        /// private field, cache
        /// </summary>
        private static Cache _cacheEntity = null;

        /// <summary>
        /// private field, lock
        /// </summary>
        private static object _lock = new object();


        /// <summary>
        /// private property, cache entity
        /// </summary>
        private static Cache CacheEntity
        {
            get
            {
                if (_cacheEntity == null)
                {
                    lock (_lock)
                    {
                        if (_cacheEntity == null)
                        {
                            _cacheEntity = new Cache();
                        }
                    }
                }
                return _cacheEntity;
            }
        }

        /// <summary>
        /// check the key exists in memory cache
        /// </summary>
        /// <param name="key">key</param>
        /// <returns>the check result</returns>
        public static bool Exists(string key)
        {
            try
            {
                return CacheEntity.Get(key) == null;
            }
            catch (Exception ex)
            {
                LogTool.Error(ex);
                return false;
            }
        }

        /// <summary>
        /// set cache
        /// </summary>
        /// <param name="key">cache key</param>
        /// <param name="value">cache value</param>
        /// <param name="minutes">cache expiration</param>
        /// <returns>set result</returns>
        public static bool SetCache(string key, object value, int? minutes = 20)
        {
            try
            {
                RemoveCache(key);
                if (minutes == null)
                {
                    CacheEntity.Insert(key, value, null, System.Web.Caching.Cache.NoAbsoluteExpiration, System.Web.Caching.Cache.NoSlidingExpiration);
                }
                else
                {
                    CacheEntity.Insert(key, value, null, System.Web.Caching.Cache.NoAbsoluteExpiration, new TimeSpan(0, minutes.Value, 0));
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
        /// get cache value
        /// </summary>
        /// <param name="key">cache key</param>
        /// <returns>cache value</returns>
        public static object GetCache(string key)
        {
            if (string.IsNullOrEmpty(key.Trim()))
            {
                return null;
            }
            try
            {
                return CacheEntity.Get(key);
            }
            catch (Exception ex)
            {
                LogTool.Error(ex);
                return null;
            }
        }

        /// <summary>
        /// get cache value
        /// </summary>
        /// <typeparam name="T">cache value type</typeparam>
        /// <param name="key">cache key</param>
        /// <returns>cache value</returns>
        public static T GetCache<T>(string key) where T : class
        {
            if (string.IsNullOrEmpty(key.Trim()))
            {
                return null;
            }
            try
            {
                return CacheEntity.Get(key) as T;
            }
            catch (Exception ex)
            {
                LogTool.Error(ex);
                return null;
            }
        }

        /// <summary>
        /// get cache value
        /// </summary>
        /// <typeparam name="T">cache value type</typeparam>
        /// <param name="key">cache key</param>
        /// <returns>cache value</returns>
        public static List<T> GetCacheList<T>(string key) where T : class
        {
            if (string.IsNullOrEmpty(key.Trim()))
            {
                return null;
            }
            try
            {
                return CacheEntity.Get(key) as List<T>;
            }
            catch (Exception ex)
            {
                LogTool.Error(ex);
                return null;
            }
        }

        /// <summary>
        /// remove the value from the cache by the key
        /// </summary>
        /// <param name="key">key</param>
        public static void RemoveCache(string key)
        {
            try
            {
                if (Exists(key))
                {
                    CacheEntity.Remove(key);
                }
            }
            catch (Exception ex)
            {
                LogTool.Error(ex);
                return;
            }
        }
    }
}
