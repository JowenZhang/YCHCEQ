using MySql.Data.MySqlClient;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andafa.Mes.DbUtility
{
    /// <summary>
    /// database connection interface factory
    /// </summary>
    public static class DbConnectionFactory
    {
        /// <summary>
        /// public property, read only, database connection
        /// </summary>
        public static IDbConnection Con
        {
            get
            {
                DbSettingFactory.LoadSetting();
                switch (DbSettingFactory.DbStyle)
                {
                    case DbStyleDefine.SqlServer:
                        return CreateSqlConnection();
                    case DbStyleDefine.Postgres:
                        return CreatePgSqlConnection();
                    case DbStyleDefine.MySql:
                        return CreateMySqlConnection();
                    case DbStyleDefine.Sqlite:
                        return CreateSqliteConnection();
                    case DbStyleDefine.Oracle:
                    case DbStyleDefine.Firebird:                    
                    case DbStyleDefine.Access:
                    default:
                        return CreatePgSqlConnection();
                }
            }
        }

        /// <summary>
        /// postgres connection string creator
        /// </summary>
        /// <returns>connection string</returns>
        private static IDbConnection CreatePgSqlConnection()
        {
            string dbHost = string.IsNullOrWhiteSpace(DbSettingFactory.DbHost) ? "localhost" : DbSettingFactory.DbHost;
            string dbUser = string.IsNullOrWhiteSpace(DbSettingFactory.DbUser) ? "postgres" : DbSettingFactory.DbUser;
            string dbPassword = string.IsNullOrWhiteSpace(DbSettingFactory.DbPassword) ? "root" : DbSettingFactory.DbPassword;
            string dbName = string.IsNullOrWhiteSpace(DbSettingFactory.DbName) ? "dbName" : DbSettingFactory.DbName;
            string dbPort = DbSettingFactory.DbPort >= 65535 ? "65534" : DbSettingFactory.DbPort.ToString();
            string conStr = string.Format("Server={0};Port={1};UserId={2};Password={3};Database={4};", dbHost, dbPort, dbUser, dbPassword, dbName);
            return new NpgsqlConnection(conStr);
        }

        /// <summary>
        /// sqlserver connection string creator
        /// </summary>
        /// <returns>connection string</returns>
        private static IDbConnection CreateSqlConnection()
        {
            string dbHost = string.IsNullOrWhiteSpace(DbSettingFactory.DbHost) ? "localhost" : DbSettingFactory.DbHost;
            string dbUser = string.IsNullOrWhiteSpace(DbSettingFactory.DbUser) ? "sa" : DbSettingFactory.DbUser;
            string dbPassword = string.IsNullOrWhiteSpace(DbSettingFactory.DbPassword) ? "sa" : DbSettingFactory.DbPassword;
            string dbName = string.IsNullOrWhiteSpace(DbSettingFactory.DbName) ? "northwind" : DbSettingFactory.DbName;
            string dbInstance = string.IsNullOrWhiteSpace(DbSettingFactory.DbInstance) ? "sqlexpress" : DbSettingFactory.DbInstance;
            string conStr = string.Empty;
            if (DbSettingFactory.DbTrusted)
            {
                conStr = string.Format(@"Data source={0}\{1}; Initial Catalog={2};Integrated Security=true;", dbHost, dbInstance, dbName);
            }
            else
            {
                conStr = string.Format(@"Data source={0}\{1}; Initial Catalog={2}; User Id={3}; Password={4};", dbHost, dbInstance, dbName, dbUser, dbPassword);
            }
            return new SqlConnection(conStr);
        }

        /// <summary>
        /// sqlite connection string creator
        /// </summary>
        /// <returns>connection string</returns>
        private static IDbConnection CreateSqliteConnection()
        {
            string dbPosition = string.IsNullOrWhiteSpace(DbSettingFactory.DbPosition) ? string.Format("{0}\\data.db",AppDomain.CurrentDomain.BaseDirectory ):DbSettingFactory.DbPosition;
            string conStr = string.Format("DataSource={0};version=3.0;", AppDomain.CurrentDomain.BaseDirectory);
            return new SQLiteConnection(conStr);
        }

        /// <summary>
        /// mysql connection string creator
        /// </summary>
        /// <returns>connection string</returns>
        private static IDbConnection CreateMySqlConnection()
        {
            string dbHost = string.IsNullOrWhiteSpace(DbSettingFactory.DbHost) ? "localhost" : DbSettingFactory.DbHost;
            string dbUser = string.IsNullOrWhiteSpace(DbSettingFactory.DbUser) ? "postgres" : DbSettingFactory.DbUser;
            string dbPassword = string.IsNullOrWhiteSpace(DbSettingFactory.DbPassword) ? "root" : DbSettingFactory.DbPassword;
            string dbName = string.IsNullOrWhiteSpace(DbSettingFactory.DbName) ? "dbName" : DbSettingFactory.DbName;
            string conStr = string.Format("server={0};user id={1};password={2};database={3};", dbHost, dbUser, dbPassword, dbName);
            return new MySqlConnection(conStr);
        }

    }
}
