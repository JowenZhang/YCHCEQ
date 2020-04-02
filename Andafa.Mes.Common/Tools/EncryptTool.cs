using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Andafa.Mes.Common.Tools
{
    /// <summary>
    /// encrypt and decrypt tool
    /// </summary>
    public static class EncryptTool
    {
        //初始默认密码
        private static string AESKey = "KQncmSOFT_*e.1;]";//"[45/*YUIdse..e;]";
        private static string DESKey = "KQncm_7]";//"[&HdN72]";

        /// <summary>
        /// AES加密
        /// </summary>
        /// <param name="value">原文</param>
        /// <param name="_aeskey">AES密钥</param>
        /// <returns>密文</returns>
        public static string AESEncrypt(string value, string _aeskey = null)
        {
            if (string.IsNullOrEmpty(_aeskey))
            {
                _aeskey = AESKey;
            }

            byte[] keyArray = Encoding.UTF8.GetBytes(_aeskey);
            byte[] toEncryptArray = Encoding.UTF8.GetBytes(value);

            RijndaelManaged rDel = new RijndaelManaged();
            rDel.Key = keyArray;
            rDel.Mode = CipherMode.ECB;
            rDel.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = rDel.CreateEncryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }

        /// <summary>
        /// AES解密
        /// </summary>
        /// <param name="value">密文</param>
        /// <param name="_aeskey">AES密钥</param>
        /// <returns>原文</returns>
        public static string AESDecrypt(string value, string _aeskey = null)
        {
            try
            {
                if (string.IsNullOrEmpty(_aeskey))
                {
                    _aeskey = AESKey;
                }
                byte[] keyArray = Encoding.UTF8.GetBytes(_aeskey);
                byte[] toEncryptArray = Convert.FromBase64String(value);

                RijndaelManaged rDel = new RijndaelManaged();
                rDel.Key = keyArray;
                rDel.Mode = CipherMode.ECB;
                rDel.Padding = PaddingMode.PKCS7;

                ICryptoTransform cTransform = rDel.CreateDecryptor();
                byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

                return Encoding.UTF8.GetString(resultArray);
            }
            catch
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// DES加密
        /// </summary>
        /// <param name="value">原文</param>
        /// <param name="_deskey">DES密钥</param>
        /// <returns>密文</returns>
        public static string DESEncrypt(string value, string _deskey = null)
        {
            if (string.IsNullOrEmpty(_deskey))
            {
                _deskey = DESKey;
            }

            byte[] keyArray = Encoding.UTF8.GetBytes(_deskey);
            byte[] toEncryptArray = Encoding.UTF8.GetBytes(value);

            DESCryptoServiceProvider rDel = new DESCryptoServiceProvider();
            rDel.Key = keyArray;
            rDel.Mode = CipherMode.ECB;
            rDel.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = rDel.CreateEncryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }

        /// <summary>
        /// DES解密
        /// </summary>
        /// <param name="value">密文</param>
        /// <param name="_deskey">DES密钥</param>
        /// <returns>原文</returns>
        public static string DESDecrypt(string value, string _deskey = null)
        {
            try
            {
                if (string.IsNullOrEmpty(_deskey))
                {
                    _deskey = DESKey;
                }
                byte[] keyArray = Encoding.UTF8.GetBytes(_deskey);
                byte[] toEncryptArray = Convert.FromBase64String(value);

                DESCryptoServiceProvider rDel = new DESCryptoServiceProvider();
                rDel.Key = keyArray;
                rDel.Mode = CipherMode.ECB;
                rDel.Padding = PaddingMode.PKCS7;

                ICryptoTransform cTransform = rDel.CreateDecryptor();
                byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

                return Encoding.UTF8.GetString(resultArray);
            }
            catch
            {
                return string.Empty;
            }
        }
        /// <summary>
        /// base64编码
        /// </summary>
        /// <param name="value">编码原文</param>
        /// <returns>编码密文</returns>
        public static string Base64Encode(string value)
        {
            string result = Convert.ToBase64String(Encoding.Default.GetBytes(value));
            return result;
        }

        /// <summary>
        /// base64解码
        /// </summary>
        /// <param name="value">编码密文</param>
        /// <returns>编码原文</returns>
        public static string Base64Decode(string value)
        {
            string result = Encoding.Default.GetString(Convert.FromBase64String(value));
            return result;
        }

        /// <summary>
        /// 对Url进行编码
        /// </summary>
        /// <param name="url">url</param>
        /// <param name="isUpper">编码字符是否转成大写,范例,"http://"转成"http%3A%2F%2F"</param>
        public static string UrlEncode(string url, bool isUpper = false)
        {
            return UrlEncode(url, Encoding.UTF8, isUpper);
        }

        /// <summary>
        /// URL编码
        /// </summary>
        /// <param name="url">URL原文</param>
        /// <param name="encoding">URL编码方式</param>
        /// <param name="isUpper">编码结果是否字母转大写，默认转大写</param>
        /// <returns>URL编码后的字符</returns>
        public static string UrlEncode(string url, Encoding encoding, bool isUpper = true)
        {
            var result = HttpUtility.UrlEncode(url, encoding);
            if (isUpper)
            {
                return GetUpperEncode(result);
            }
            return result;
        }

        /// <summary>
        /// URL编码，返回值字母大写
        /// </summary>
        /// <param name="encode">编码方式</param>
        /// <returns>URL编码后的字符</returns>
        private static string GetUpperEncode(string encode)
        {
            var result = new StringBuilder();
            int index = int.MinValue;
            for (int i = 0; i < encode.Length; i++)
            {
                string character = encode[i].ToString();
                if (character == "%")
                    index = i;
                if (i - index == 1 || i - index == 2)
                    character = character.ToUpper();
                result.Append(character);
            }
            return result.ToString();
        }

        /// <summary>
        /// URL解码,对于javascript的encodeURIComponent函数编码参数,应使用utf-8字符编码来解码
        /// </summary>
        /// <param name="urlEn">URL密文</param>
        /// <returns>URL解码后的原文</returns>
        public static string UrlDecode(string urlEn)
        {
            return UrlDecode(urlEn, Encoding.UTF8);
        }

        /// <summary>
        /// 对Url进行解码,对于javascript的encodeURIComponent函数编码参数,应使用utf-8字符编码来解码
        /// </summary>
        /// <param name="urlEn">URL密文</param>
        /// <param name="encoding">字符编码,对于javascript的encodeURIComponent函数编码参数,应使用utf-8字符编码来解码</param>
        /// <returns>URL解码后的原文</returns>
        public static string UrlDecode(string urlEn, Encoding encoding)
        {
            return HttpUtility.UrlDecode(urlEn, encoding);
        }
    }
}
