using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Andafa.Mes.DbUtility
{
    /// <summary>
    /// defined database style
    /// </summary>
    internal enum DbStyleDefine
    {
        /// <summary>
        /// sql server
        /// </summary>
        SqlServer,
        /// <summary>
        /// oracle
        /// </summary>
        Oracle,
        /// <summary>
        /// postgres
        /// </summary>
        Postgres,
        /// <summary>
        /// mysql
        /// </summary>
        MySql,
        /// <summary>
        /// firebird
        /// </summary>
        Firebird,
        /// <summary>
        /// sqlite
        /// </summary>
        Sqlite,
        /// <summary>
        /// access
        /// </summary>
        Access
    }
}