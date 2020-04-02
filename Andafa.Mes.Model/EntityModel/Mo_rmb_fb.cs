using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.EntityModel
{
	/// <summary>
	/// mo_rmb_fb
	/// </summary>
	[Serializable]
	public class Mo_rmb_fb
	{
		/// <summary>
		/// unode
		/// </summary>
		public string unode
		{
			get;
			set;
		}
		/// <summary>
		/// wkn_waiting_transferout_qty
		/// </summary>
		public decimal? wkn_waiting_transferout_qty
		{
			get;
			set;
		}
		/// <summary>
		/// wkn_waiting_finished_qty
		/// </summary>
		public decimal wkn_waiting_finished_qty
		{
			get;
			set;
		}
		/// <summary>
		/// wkn_finished_qty_ok
		/// </summary>
		public decimal wkn_finished_qty_ok
		{
			get;
			set;
		}
		/// <summary>
		/// wkn_finished_qty_ng
		/// </summary>
		public decimal wkn_finished_qty_ng
		{
			get;
			set;
		}
		/// <summary>
		/// wkn_finished_qty_scrap
		/// </summary>
		public decimal wkn_finished_qty_scrap
		{
			get;
			set;
		}
		/// <summary>
		/// wkn_finished_qty_other
		/// </summary>
		public decimal wkn_finished_qty_other
		{
			get;
			set;
		}
		/// <summary>
		/// wkn_rework_qty_ok
		/// </summary>
		public decimal wkn_rework_qty_ok
		{
			get;
			set;
		}
		/// <summary>
		/// wkn_rework_qty_ng
		/// </summary>
		public decimal wkn_rework_qty_ng
		{
			get;
			set;
		}
		/// <summary>
		/// wkn_rework_qty_scrap
		/// </summary>
		public decimal wkn_rework_qty_scrap
		{
			get;
			set;
		}
		/// <summary>
		/// wkn_rework_qty_other
		/// </summary>
		public decimal wkn_rework_qty_other
		{
			get;
			set;
		}
		/// <summary>
		/// wkn_first_start_datetime
		/// </summary>
		public DateTime? wkn_first_start_datetime
		{
			get;
			set;
		}
		/// <summary>
		/// wkn_last_end_datetime
		/// </summary>
		public DateTime? wkn_last_end_datetime
		{
			get;
			set;
		}
		/// <summary>
		/// wkn_fb_time_length
		/// </summary>
		public int wkn_fb_time_length
		{
			get;
			set;
		}
		/// <summary>
		/// wkn_fb_ex_time_length
		/// </summary>
		public int wkn_fb_ex_time_length
		{
			get;
			set;
		}
		/// <summary>
		/// wkn_fb_rest_time_length
		/// </summary>
		public int wkn_fb_rest_time_length
		{
			get;
			set;
		}
		/// <summary>
		/// wkn_fb_wkc_time_length
		/// </summary>
		public int wkn_fb_wkc_time_length
		{
			get;
			set;
		}
		/// <summary>
		/// wkn_fb_manpower_time_length
		/// </summary>
		public int wkn_fb_manpower_time_length
		{
			get;
			set;
		}
		/// <summary>
		/// wkn_is_closed
		/// </summary>
		public bool? wkn_is_closed
		{
			get;
			set;
		}
		/// <summary>
		/// crt_time
		/// </summary>
		public DateTime crt_time
		{
			get;
			set;
		}
		/// <summary>
		/// crt_user
		/// </summary>
		public string crt_user
		{
			get;
			set;
		}
		/// <summary>
		/// crt_user_no
		/// </summary>
		public string crt_user_no
		{
			get;
			set;
		}
		/// <summary>
		/// crt_user_name
		/// </summary>
		public string crt_user_name
		{
			get;
			set;
		}
		/// <summary>
		/// crt_host
		/// </summary>
		public string crt_host
		{
			get;
			set;
		}
		/// <summary>
		/// upd_time
		/// </summary>
		public DateTime upd_time
		{
			get;
			set;
		}
		/// <summary>
		/// upd_user
		/// </summary>
		public string upd_user
		{
			get;
			set;
		}
		/// <summary>
		/// upd_user_no
		/// </summary>
		public string upd_user_no
		{
			get;
			set;
		}
		/// <summary>
		/// upd_user_name
		/// </summary>
		public string upd_user_name
		{
			get;
			set;
		}
		/// <summary>
		/// upd_host
		/// </summary>
		public string upd_host
		{
			get;
			set;
		}
	}
}