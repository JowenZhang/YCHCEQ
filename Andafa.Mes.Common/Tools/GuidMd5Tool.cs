using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Andafa.Mes.Common.Tools
{
    /// <summary>
    /// guid and md5 tool
    /// </summary>
    public static class GuidMd5Tool
    {
        /// <summary>
        /// 按时间Tick生成MD5
        /// </summary>
        /// <returns>MD5序列32位小写字符串</returns>
        public static string CreateMd5Id()
        {
            MD5 md5 = MD5.Create();
            byte[] data = Encoding.UTF8.GetBytes(((DateTime.Now.Ticks) + new Random().Next()).ToString());
            byte[] data2 = md5.ComputeHash(data);

            return GetbyteToString(data2).Replace("-", "").ToLower();
        }

        /// <summary>
        /// 生成GUID
        /// </summary>
        /// <returns>32位GUID小写字符串</returns>
        public static string CreateGuid()
        {
            byte[] guidArray = Guid.NewGuid().ToByteArray();
            return new Guid(guidArray).ToString().Replace("-", string.Empty);
        }

        /// <summary>
        /// 生成时间序列的GUID
        /// </summary>
        /// <returns>时间序列的GUID小写字符串</returns>
        public static string CreateGuidByTimeSeed()
        {
            byte[] guidArray = Guid.NewGuid().ToByteArray();
            var baseDate = new DateTime(1900, 1, 1);
            DateTime now = DateTime.Now;
            var days = new TimeSpan(now.Ticks - baseDate.Ticks);
            TimeSpan msecs = now.TimeOfDay;
            byte[] daysArray = BitConverter.GetBytes(days.Days);
            byte[] msecsArray = BitConverter.GetBytes((long)(msecs.TotalMilliseconds / 3.333333));
            Array.Reverse(daysArray);
            Array.Reverse(msecsArray);
            Array.Copy(daysArray, daysArray.Length - 2, guidArray, guidArray.Length - 6, 2);
            Array.Copy(msecsArray, msecsArray.Length - 4, guidArray, guidArray.Length - 4, 4);
            return new Guid(guidArray).ToString().Replace("-", string.Empty);
        }

        /// <summary>
        /// 通过字符串获取MD5值，返回32位小写字符串。
        /// </summary>
        /// <param name="str">原始字符串</param>
        /// <returns>32位小写字符串</returns>
        public static string GetMD5String(string str)
        {
            MD5 md5 = MD5.Create();
            byte[] data = Encoding.UTF8.GetBytes(str);
            byte[] data2 = md5.ComputeHash(data);
            return GetbyteToString(data2);
        }

        /// <summary>
        /// 获取文件的MD5值
        /// </summary>
        /// <param name="path">含路径的文件名称</param>
        /// <returns>MD5的32位小写字符串</returns>
        public static string GetMD5FromFile(string path)
        {
            MD5 md5 = MD5.Create();
            if (!File.Exists(path))
            {
                return "";
            }
            List<byte> data2 = null;
            using (FileStream stream = File.OpenRead(path))
            {
                data2 = new List<byte>();
                foreach (var item in md5.ComputeHash(stream))
                {
                    data2.Add(item);
                }
            }
            return GetbyteToString(data2.ToArray());
        }

        /// <summary>
        /// 私有函数，字节数组转小写字符串
        /// </summary>
        /// <param name="data">字节数组</param>
        /// <returns>小写字符串</returns>
        private static string GetbyteToString(byte[] data)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sb.Append(data[i].ToString("x2"));
            }
            return sb.ToString().ToLower();
        }
    }
}
