using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Andafa.Mes.Model.ViewModel
{
    /// <summary>
    /// worker selected wka view
    /// </summary>
    [Serializable]
    public class WorkerSelectedWkaView
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
        public string wka_no { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string wka_name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool is_selected { get; set; }
    }
}
