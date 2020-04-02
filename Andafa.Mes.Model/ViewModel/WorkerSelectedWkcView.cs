using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Andafa.Mes.Model.ViewModel
{
    /// <summary>
    /// worker selected wkc view
    /// </summary>
    [Serializable]
    public class WorkerSelectedWkcView
    {
        /// <summary>
        /// 
        /// </summary>
        public string wkp_name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string wkp_no { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string wkc_no { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string wkc_name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool is_selected { get; set; }
    }
}
