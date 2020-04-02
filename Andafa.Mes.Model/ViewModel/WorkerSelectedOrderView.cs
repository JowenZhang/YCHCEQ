using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Andafa.Mes.Model.ViewModel
{
    /// <summary>
    /// worker selected order view
    /// </summary>
    [Serializable]
    public class WorkerSelectedOrderView
    {
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
        public double has_finished { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double not_finished { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string mo_no { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string part_no { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string part_name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string part_spec { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double mo_qty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime mo_hope_start_datetime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime mo_hope_end_datetime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string mo_desc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string factory_no { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string client_name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string mo_rmk01 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string mo_rmk02 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string mo_rmk03 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string mo_rmk04 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string mo_rmk05 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string mo_rmk06 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string mo_rmk07 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string mo_rmk08 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string mo_rmk09 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string mo_rmk10 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string mo_rmk11 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string mo_rmk12 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string mo_rmk13 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string mo_rmk14 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string mo_rmk15 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string mo_rmk16 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string mo_rmk17 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string mo_rmk18 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string mo_rmk19 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string mo_rmk20 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool is_selected { get; set; }
    }
}
