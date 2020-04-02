using Andafa.Mes.Common.Tools;
using Andafa.Mes.Dal;
using Andafa.Mes.WebApiUtility;
using Model.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andafa.Mes.Bll.ScadaBll
{
    /// <summary>
    /// data synchronize bll
    /// </summary>
    public class DataSyncBll
    {
        /// <summary>
        /// get submit source data from mes
        /// </summary>
        /// <returns>mes submit source data</returns>
        private List<Mes_ua_submit> GetSubmitSourceDataFromMes()
        {
            IApiUtility utility = new ApiUtility();
            List<Mes_ua_submit> res = utility.GetAny<Mes_ua_submit>();
            return res;
        }

        /// <summary>
        /// get submit source data from scada server
        /// </summary>
        /// <returns></returns>
        public List<Mes_ua_submit> GetSubmitSourceDataFromScada()
        {
            IMainDal dal = new MainDal();
            return dal.ReadModelListByPms<Mes_ua_submit>("Scada", "GetSubmitSourceDataFromScada");
        }

        /// <summary>
        /// sync data
        /// </summary>
        /// <returns>sync result</returns>
        public bool SyncData()
        {
            try
            {
                List<Mes_ua_submit> listFromScada = GetSubmitSourceDataFromScada();
                List<Mes_ua_submit> listFromMes = GetSubmitSourceDataFromMes();
                List<Mes_ua_submit> listSame = ModelTool.GetJoin(listFromScada, listFromMes);
                List<Mes_ua_submit> listAdd = ModelTool.GetMinus(listFromScada, listSame);
                List<Mes_ua_submit> listDelete = ModelTool.GetMinus(listFromMes, listSame);
                AddDataIntoMes(listAdd);
                RemoveDataFromMes(listDelete);
                return true;
            }
            catch (Exception ex)
            {
                LogTool.Error(ex);
                return false;
            }
        }

        /// <summary>
        /// remove the old data from mes
        /// </summary>
        /// <param name="dataToRemove">data need to remove</param>
        /// <returns>remove result</returns>
        private bool RemoveDataFromMes(List<Mes_ua_submit> dataToRemove)
        {
            try
            {
                if (dataToRemove == null || dataToRemove.Count <= 0)
                {
                    return false;
                }
                List<Dictionary<string, object>> pmsList = new List<Dictionary<string, object>>();
                dataToRemove.ForEach(a =>
                {
                    Dictionary<string, object> tmp = new Dictionary<string, object>();
                    tmp.Add("Id", a.id);
                    pmsList.Add(tmp);
                });
                IApiUtility utility = new ApiUtility();
                return utility.Delete<Mes_ua_submit>(pmsList);
                //utility.Post("Ado","RemoveOldDataFromMesUaSubmit", pmsList);
                //return true;
            }
            catch (Exception ex)
            {
                LogTool.Error(ex);
                return false;
            }
        }

        /// <summary>
        /// add data into mes
        /// </summary>
        /// <param name="dataToAdd">data need to add</param>
        /// <returns>add result</returns>
        private bool AddDataIntoMes(List<Mes_ua_submit> dataToAdd)
        {
            try
            {
                if (dataToAdd == null || dataToAdd.Count <= 0)
                {
                    return false;
                }
                List<Mes_ua_submit_auto> pmsList = new List<Mes_ua_submit_auto>();
                dataToAdd.ForEach(a =>
                {
                    pmsList.Add(new Mes_ua_submit_auto() {
                        fingerprint=a.fingerprint,
                        id = a.id,
                        m_id=a.m_id,
                        p_id=a.p_id,
                        prod_id=a.prod_id,
                        prod_weight=a.prod_weight,
                        sub_time=a.sub_time, 
                        ws_no=a.ws_no
                    });
                });
                IApiUtility utility = new ApiUtility();
                utility.Post(dataToAdd);
                utility.Post(pmsList);
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
