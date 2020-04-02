using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Andafa.Mes.DataService
{
    /// <summary>
    /// andafa data service
    /// </summary>
    partial class AndafaDataService : ServiceBase
    {
        /// <summary>
        /// constructor
        /// </summary>
        public AndafaDataService()
        {
            InitializeComponent();
        }

        /// <summary>
        /// private field, data sync timer
        /// </summary>
        private Timer _timer = null;

        /// <summary>
        /// service start
        /// </summary>
        /// <param name="args">start parameter array</param>
        protected override void OnStart(string[] args)
        {
            // TODO: 在此处添加代码以启动服务。
            SyncData(null);
            //_timer = new Timer(SyncData, null, 0, 5000);
        }

        /// <summary>
        /// sync data
        /// </summary>
        /// <param name="state">parameter</param>
        private void SyncData(object state)
        {
            //DataSyncBll bll = new DataSyncBll();
            //bll.SyncData();
        }

        /// <summary>
        /// service stop
        /// </summary>
        protected override void OnStop()
        {
            // TODO: 在此处添加代码以执行停止服务所需的关闭操作。
            _timer.Change(Timeout.Infinite, 5000);
        }
    }
}
