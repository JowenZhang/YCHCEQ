using Andafa.Mes.Common.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andafa.Mes.DbUtility
{
    /// <summary>
    /// database setting factory
    /// </summary>
    internal static class DbSettingFactory
    {
        /// <summary>
        /// private field, xml config file path
        /// </summary>
        private static string _path = AppDomain.CurrentDomain.BaseDirectory + @"Config\DbConfig.xml";


        /// <summary>
        /// private field, database style
        /// </summary>
        private static DbStyleDefine _dbStyle = DbStyleDefine.Postgres;

        /// <summary>
        /// internal property, database style
        /// </summary>
        internal static DbStyleDefine DbStyle
        {
            get { return _dbStyle; }
            set { _dbStyle = value; }
        }

        /// <summary>
        /// private field, database host
        /// </summary>
        private static string _dbHost = "localhost";

        /// <summary>
        /// internal property, database host
        /// </summary>
        internal static string DbHost
        {
            get { return _dbHost; }
            set { _dbHost = value; }
        }

        /// <summary>
        /// private field, database name
        /// </summary>
        private static string _dbName = "northwind";

        /// <summary>
        /// internal property, database name
        /// </summary>
        internal static string DbName
        {
            get { return _dbName; }
            set { _dbName = value; }
        }

        /// <summary>
        /// private field, database trust
        /// </summary>
        private static bool _dbTrusted = false;

        /// <summary>
        /// internal property, database trust
        /// </summary>
        internal static bool DbTrusted
        {
            get { return _dbTrusted; }
            set { _dbTrusted = value; }
        }

        /// <summary>
        /// private field, database user
        /// </summary>
        private static string _dbUser = "sa";

        /// <summary>
        /// internal property, database user
        /// </summary>
        internal static string DbUser
        {
            get { return _dbUser; }
            set { _dbUser = value; }
        }

        /// <summary>
        /// private field, database password
        /// </summary>
        private static string _dbPassword = "sa";

        /// <summary>
        /// internal property, database password
        /// </summary>
        internal static string DbPassword
        {
            get { return _dbPassword; }
            set { _dbPassword = value; }
        }

        /// <summary>
        /// private field, database port
        /// </summary>
        private static int _dbPort = 5432;

        /// <summary>
        /// internal property, database port
        /// </summary>
        internal static int DbPort
        {
            get { return _dbPort; }
            set { _dbPort = value; }
        }

        /// <summary>
        /// private field, database instance
        /// </summary>
        private static string _dbInstance = "dbInstance";

        /// <summary>
        /// internal property, database instance
        /// </summary>
        internal static string DbInstance
        {
            get { return _dbInstance; }
            set { _dbInstance = value; }
        }

        /// <summary>
        /// private field, database embed 
        /// </summary>
        private static bool _dbEmbed = false;

        /// <summary>
        /// internal property, database embed
        /// </summary>
        internal static bool DbEmbed
        {
            get { return _dbEmbed; }
            set { _dbEmbed = value; }
        }

        /// <summary>
        /// private field, database file position
        /// </summary>
        private static string _dbPosition = AppDomain.CurrentDomain.BaseDirectory + "Data\\Db.data";

        /// <summary>
        /// internal property, database file position
        /// </summary>
        internal static string DbPosition
        {
            get { return _dbPosition; }
            set { _dbPosition = value; }
        }

        /// <summary>
        /// private field, current basic config is loaded
        /// </summary>
        private static bool _basicConfigLoaded = false;

        /// <summary>
        /// internal property, current basic config is loaded
        /// </summary>
        internal static bool BasicConfigLoaded
        {
            get { return _basicConfigLoaded; }
            set { _basicConfigLoaded = value; }
        }

        /// <summary>
        /// load all setting
        /// </summary>
        internal static void LoadSetting()
        {
            BasicConfigLoaded = true;
            string styleXPath = "/DbConfig/DbStyle";
            string trustedXPath = "/DbConfig/DbTrusted";
            string hostXPath = "/DbConfig/DbHost";
            string userXPath = "/DbConfig/DbUser";
            string passwordXPath = "/DbConfig/DbPassword";
            string portXPath = "/DbConfig/DbPort";
            string instanceXPath = "/DbConfig/DbInstance";
            string nameXPath = "/DbConfig/DbName";
            string embedXPath = "/DbConfig/DbEmbed";
            string positionXPath = "/DbConfig/DbPosition";
            string dbStyle = XmlTool.GetNodeValueByXPath(styleXPath, _path);
            switch (dbStyle.ToLower())
            {
                case "sqlserver":
                    DbStyle = DbStyleDefine.SqlServer;
                    break;
                case "oracle":
                    DbStyle = DbStyleDefine.Oracle;
                    break;
                case "postgres":
                    DbStyle = DbStyleDefine.Postgres;
                    break;
                case "mysql":
                    DbStyle = DbStyleDefine.MySql;
                    break;
                case "firebird":
                    DbStyle = DbStyleDefine.Firebird;
                    break;
                case "sqlite":
                    DbStyle = DbStyleDefine.Sqlite;
                    break;
                case "access":
                    DbStyle = DbStyleDefine.Access;
                    break;
                default:
                    DbStyle = DbStyleDefine.MySql;
                    break;
            }
            DbTrusted = ConvertTool.GetBool(XmlTool.GetNodeValueByXPath(trustedXPath, _path));
            DbHost = XmlTool.GetNodeValueByXPath(hostXPath, _path);
            DbUser = XmlTool.GetNodeValueByXPath(userXPath, _path);
            DbPassword = XmlTool.GetNodeValueByXPath(passwordXPath, _path);
            DbPort = ConvertTool.GetInt(XmlTool.GetNodeValueByXPath(portXPath, _path));
            if (DbPort > 65535)
            {
                DbPort = 65534;
                XmlTool.SetNodeValueByXPath(portXPath, DbPort.ToString(), _path);
            }
            DbInstance = XmlTool.GetNodeValueByXPath(instanceXPath, _path);
            DbName = XmlTool.GetNodeValueByXPath(nameXPath, _path);
            DbEmbed = ConvertTool.GetBool(XmlTool.GetNodeValueByXPath(embedXPath, _path));
            DbPosition = XmlTool.GetNodeValueByXPath(positionXPath, _path);
        }
    }
}
