using Andafa.Mes.Common.Tools;
using Andafa.Mes.Dal;
using Andafa.Mes.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andafa.Mes.Bll.WebSiteBll
{
    /// <summary>
    /// operator bll
    /// </summary>
    public class OperatorBll
    {
        /// <summary>
        /// get all wkc has been selected by worker
        /// </summary>
        /// <param name="worker_no">current worker no</param>
        /// <returns>all wkc has been selected by this worker</returns>
        public List<WorkerSelectedWkcView> GetWorkerSelectedWkc(string worker_no)
        {
            IMainDal dal = new MainDal();
            Dictionary<string, object> pms = new Dictionary<string, object>();
            pms.Add("worker_no", string.Format("%{0}%", worker_no));
            return dal.ReadModelListByPms<WorkerSelectedWkcView>("Operator", "GetWorkerSelectedWkc", pms);
        }

        /// <summary>
        /// post all wkc has been selected by worker
        /// </summary>
        /// <param name="worker_no">current worker no</param>
        /// <param name="wkcNos">wkc has been selected</param>
        /// <returns>is post action success</returns>
        public bool PostWorkerSelectedWkc(string worker_no, List<string> wkcNos)
        {
            IMainDal dal = new MainDal();
            Dictionary<string, object> pms = new Dictionary<string, object>();
            pms.Add("worker_no", worker_no);
            pms.Add("wkc_no", wkcNos);
            return dal.CUDByPms("Operator", "PostWorkerSelectedWkc", pms) > 0;
        }

        /// <summary>
        /// get all wkc has been selected by worker
        /// </summary>
        /// <param name="worker_no">current worker no</param>
        /// <returns>all wkc has been selected by this worker</returns>
        public List<WorkerSelectedWkaView> GetWorkerSelectedWka(string worker_no)
        {
            IMainDal dal = new MainDal();
            Dictionary<string, object> pms = new Dictionary<string, object>();
            pms.Add("worker_no", worker_no);
            return dal.ReadModelListByPms<WorkerSelectedWkaView>("Operator", "GetWorkerSelectedWka", pms);
        }

        /// <summary>
        /// post all wkc has been selected by worker
        /// </summary>
        /// <param name="worker_no">current worker no</param>
        /// <param name="wkaNos">wka has been selected</param>
        /// <returns>is post action success</returns>
        public bool PostWorkerSelectedWka(string worker_no, List<string> wkaNos)
        {
            IMainDal dal = new MainDal();
            Dictionary<string, object> pms = new Dictionary<string, object>();
            pms.Add("worker_no", worker_no);
            pms.Add("wka_no", wkaNos);
            return dal.CUDByPms("Operator", "PostWorkerSelectedWka", pms) > 0;
        }


        /// <summary>
        /// get worker selected order data
        /// </summary>
        /// <param name="worker_no">worker no</param>
        /// <returns>worker selected order data</returns>
        public List<WorkerSelectedOrderView> GetWorkerSelectedOrderData(string worker_no)
        {
            IMainDal dal = new MainDal();
            Dictionary<string, object> pms = new Dictionary<string, object>();
            pms.Add("worker_no", worker_no);
            return dal.ReadModelListByPms<WorkerSelectedOrderView>("Operator", "GetWorkerSelectedOrderData", pms);
        }

        /// <summary>
        /// post worker selected order data
        /// </summary>
        /// <param name="worker_no">worker_no</param>
        /// <param name="wkaOrders">order which match to the order</param>
        /// <returns>worker selected order data</returns>
        public bool PostWorkerSelectedOrderData(string worker_no, List<Dictionary<string, string>> wkaOrders)
        {
            IMainDal dal = new MainDal();
            if (string.IsNullOrWhiteSpace(worker_no))
            {
                return false;
            }
            if (wkaOrders == null || wkaOrders.Count == 0)
            {
                return false;
            }
            try
            {
                wkaOrders.ForEach(a =>
                {
                    Dictionary<string, object> pms = new Dictionary<string, object>();
                    pms.Add("wka_no", a.Keys.Contains("wka_no") ? a["wka_no"] : string.Empty);
                    pms.Add("mo_no", a.Keys.Contains("mo_no") ? a["mo_no"] : string.Empty);
                    pms.Add("worker_no", worker_no);
                    dal.CUDByPms("Operator", "PostWorkerSelectedOrderData", pms);
                });
                return true;
            }
            catch (Exception ex)
            {
                LogTool.Error(ex);
                return false;
            }
        }
    }
}
