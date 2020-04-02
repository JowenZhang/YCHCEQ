using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andafa.Mes.Common.Tools
{
    /// <summary>
    /// log tool
    /// </summary>
    public static class LogTool
    {
        /// <summary>
        /// output information
        /// </summary>
        /// <param name="information">information</param>
        public static void Info(string information)
        {
            Logger log = LogManager.GetLogger("Info");
            log.Info(information);
        }

        /// <summary>
        /// output exception
        /// </summary>
        /// <param name="ex">exception</param>
        public static void Error(Exception ex)
        {
            Logger log = LogManager.GetLogger("Error");
            log.Error(ex);
        }
    }
}
