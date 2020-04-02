using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Andafa.Mes.Common.Tools
{
    /// <summary>
    /// xml tool
    /// </summary>
    public static class XmlTool
    {
        /// <summary>
        /// default xml file path
        /// </summary>
        private static string _defaultXmlPath = AppDomain.CurrentDomain.BaseDirectory + @"\Config\XmlConfig.xml";

        /// <summary>
        /// get node value from the xml file by xpath
        /// </summary>
        /// <param name="xpath">xml xpath</param>
        /// <param name="targetXml">xml file full path or xml content</param>
        /// <param name="useCache">is use the cache</param>
        /// <param name="updateForce">force update the cache</param>
        /// <returns>node value</returns>
        public static string GetNodeValueByXPath(string xpath, string targetXml = null, bool useCache = true, bool updateForce = true)
        {
            if (string.IsNullOrEmpty(xpath))
            {
                LogTool.Info("xpath is not defined");
                return string.Empty;
            }
            targetXml = string.IsNullOrEmpty(targetXml) ? _defaultXmlPath : targetXml;
            string res = string.Empty;
            StringBuilder sbCombine = new StringBuilder();
            sbCombine.Append(xpath);
            sbCombine.Append(targetXml);
            string cacheKey = sbCombine.ToString().GetHashCode().ToString();
            try
            {
                if (useCache)
                {
                    if (CacheTool.Exists(cacheKey))
                    {
                        if (updateForce)
                        {
                            res = GetValueByXPath(xpath, targetXml);
                            CacheTool.SetCache(cacheKey, res, 30);
                        }
                        else
                        {
                            res = ConvertTool.GetString(CacheTool.GetCache(cacheKey));
                        }
                    }
                    else
                    {
                        res = GetValueByXPath(xpath, targetXml);
                        CacheTool.SetCache(cacheKey, res, 30);
                    }
                }
                else
                {
                    res = GetValueByXPath(xpath, targetXml);
                }
            }
            catch (Exception ex)
            {
                LogTool.Error(ex);
            }
            return res;
        }

        /// <summary>
        /// get node value string by Xml xpath with out check
        /// </summary>
        /// <param name="xpath">xpath string</param>
        /// <param name="targetXml">xml file full path or xml content</param>
        /// <returns>node value string</returns>
        private static string GetValueByXPath(string xpath, string targetXml)
        {
            string res = string.Empty;
            XmlDocument xmlDoc = new XmlDocument();
            try
            {
                xmlDoc.Load(targetXml);
                if (xmlDoc == null)
                {
                    xmlDoc.LoadXml(targetXml);
                    if (xmlDoc == null)
                    {
                        res = string.Empty;
                    }
                }
                XmlNode node = xmlDoc.SelectSingleNode(xpath);
                if (node == null)
                {
                    res = string.Empty;
                }
                string[] tmp = node.InnerText.Split(new char[] { '\t', '\r', '\n', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (tmp != null && tmp.Length > 0)
                {
                    res = string.Join(" ", tmp);
                }
                else
                {
                    res = null;
                }
            }
            catch (Exception exLoad)
            {
                LogTool.Error(exLoad);
            }
            return res;
        }

        /// <summary>
        /// get node value by Xml xpath from the xml source text with out check
        /// </summary>
        /// <param name="xpath">xml path</param>
        /// <param name="xmlSourceText">xml source text</param>
        /// <returns>node value string</returns>
        private static string GetValueByXPathInSource(string xpath, string xmlSourceText)
        {
            string res = string.Empty;
            XmlDocument xmlDoc = new XmlDocument();
            try
            {
                xmlDoc.LoadXml(xmlSourceText);
                if (xmlDoc == null)
                {
                    res = string.Empty;
                }
                XmlNode node = xmlDoc.SelectSingleNode(xpath);
                if (node == null)
                {
                    res = string.Empty;
                }
                res = node.InnerText.Replace("\t", "").Replace("\r", "").Replace("\n", "").Trim();
            }
            catch (Exception exLoad)
            {
                LogTool.Error(exLoad);
            }
            return res;
        }

        /// <summary>
        /// set the node value by Xml xpath with out check
        /// </summary>
        /// <param name="xpath">xpath string</param>
        /// <param name="xmlPath">xml file path</param>
        /// <param name="nodeValue">xml node value</param>
        /// <returns>is set value succeed</returns>
        private static bool SetValueByXPath(string xpath, string xmlPath, string nodeValue)
        {
            bool res = false;
            XmlDocument xmlDoc = new XmlDocument();
            try
            {
                xmlDoc.Load(xmlPath);
                if (xmlDoc == null)
                {
                    return res;
                }
                XmlNode node = xmlDoc.SelectSingleNode(xpath);
                if (node == null)
                {
                    return res;
                }
                node.InnerText = nodeValue;
                res = true;
            }
            catch (Exception exLoad)
            {
                LogTool.Error(exLoad);
            }
            return res;
        }

        /// <summary>
        /// set the node value by xml xpath
        /// </summary>
        /// <param name="xpath">xpath string</param>
        /// <param name="nodeValue">xml node value</param>
        /// <param name="xmlFullPath">xml file path</param>
        /// <param name="useCache">is use the cache</param>
        public static void SetNodeValueByXPath(string xpath, string nodeValue, string xmlFullPath = null, bool useCache = true)
        {
            if (string.IsNullOrEmpty(xpath))
            {
                LogTool.Info("xpath is not defined");
                return;
            }
            string xmlPath = string.IsNullOrEmpty(xmlFullPath.Trim()) ? _defaultXmlPath : xmlFullPath;
            if (!File.Exists(xmlPath))
            {
                LogTool.Info("xml is not exist");
                return;
            }
            if (useCache)
            {
                StringBuilder sbCombine = new StringBuilder();
                sbCombine.Append(xpath);
                sbCombine.Append(xmlFullPath);
                string cacheKey = sbCombine.ToString().GetHashCode().ToString();
                CacheTool.SetCache(cacheKey, nodeValue, 30);
            }
            SetValueByXPath(xpath, xmlPath, nodeValue);
        }
    }
}
