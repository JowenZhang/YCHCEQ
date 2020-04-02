using Andafa.Mes.Dal;
using Model.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andafa.Mes.Bll.WebSiteBll
{
    /// <summary>
    /// home controller buisness
    /// </summary>
    public class HomeBll
    {
        /// <summary>
        /// get current worker
        /// </summary>
        /// <param name="worker_no">worker_no</param>
        /// <returns>current worker entity</returns>
        public Me_worker GetCurrentWorker(string worker_no)
        {
            IMainDal dal = new MainDal();
            Dictionary<string, object> pms = new Dictionary<string, object>();
            pms.Add("worker_no", worker_no);
            Me_worker tmp = dal.ReadModelByPms<Me_worker>(pms);
            return tmp;
        }
    }
}
