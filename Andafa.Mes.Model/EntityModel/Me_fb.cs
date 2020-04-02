using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.EntityModel
{
	/// <summary>
	/// me_fb
	/// </summary>
	[Serializable]
	public class Me_fb
	{
		/// <summary>
		/// fb_id
		/// </summary>
		public string fb_id
		{
			get;
			set;
		}
		/// <summary>
		/// fb_status
		/// </summary>
		public string fb_status
		{
			get;
			set;
		}
		/// <summary>
		/// fb_start_datetime
		/// </summary>
		public DateTime fb_start_datetime
		{
			get;
			set;
		}
		/// <summary>
		/// fb_end_datetime
		/// </summary>
		public DateTime? fb_end_datetime
		{
			get;
			set;
		}
		/// <summary>
		/// dt_no
		/// </summary>
		public string dt_no
		{
			get;
			set;
		}
		/// <summary>
		/// da_count_begin
		/// </summary>
		public int? da_count_begin
		{
			get;
			set;
		}
		/// <summary>
		/// da_count_last
		/// </summary>
		public int? da_count_last
		{
			get;
			set;
		}
		/// <summary>
		/// da_count_diff
		/// </summary>
		public int? da_count_diff
		{
			get;
			set;
		}
		/// <summary>
		/// fb_end_qty_ok
		/// </summary>
		public decimal fb_end_qty_ok
		{
			get;
			set;
		}
		/// <summary>
		/// fb_end_qty_ng
		/// </summary>
		public decimal fb_end_qty_ng
		{
			get;
			set;
		}
		/// <summary>
		/// fb_end_qty_scrap
		/// </summary>
		public decimal fb_end_qty_scrap
		{
			get;
			set;
		}
		/// <summary>
		/// fb_end_qty_other
		/// </summary>
		public decimal fb_end_qty_other
		{
			get;
			set;
		}
		/// <summary>
		/// lot_no
		/// </summary>
		public string lot_no
		{
			get;
			set;
		}
		/// <summary>
		/// unode
		/// </summary>
		public string unode
		{
			get;
			set;
		}
		/// <summary>
		/// wkn
		/// </summary>
		public string wkn
		{
			get;
			set;
		}
		/// <summary>
		/// wkp_no
		/// </summary>
		public string wkp_no
		{
			get;
			set;
		}
		/// <summary>
		/// wkp_name
		/// </summary>
		public string wkp_name
		{
			get;
			set;
		}
		/// <summary>
		/// wks_no
		/// </summary>
		public string wks_no
		{
			get;
			set;
		}
		/// <summary>
		/// wks_name
		/// </summary>
		public string wks_name
		{
			get;
			set;
		}
		/// <summary>
		/// wks_unit_price
		/// </summary>
		public decimal? wks_unit_price
		{
			get;
			set;
		}
		/// <summary>
		/// wkc_no
		/// </summary>
		public string wkc_no
		{
			get;
			set;
		}
		/// <summary>
		/// wkc_name
		/// </summary>
		public string wkc_name
		{
			get;
			set;
		}
		/// <summary>
		/// shift_date
		/// </summary>
		public DateTime? shift_date
		{
			get;
			set;
		}
		/// <summary>
		/// shift_no
		/// </summary>
		public string shift_no
		{
			get;
			set;
		}
		/// <summary>
		/// shift_name
		/// </summary>
		public string shift_name
		{
			get;
			set;
		}
		/// <summary>
		/// worker_no
		/// </summary>
		public string worker_no
		{
			get;
			set;
		}
		/// <summary>
		/// worker_name
		/// </summary>
		public string worker_name
		{
			get;
			set;
		}
		/// <summary>
		/// me_fb_rmk01
		/// </summary>
		public string me_fb_rmk01
		{
			get;
			set;
		}
		/// <summary>
		/// me_fb_rmk02
		/// </summary>
		public string me_fb_rmk02
		{
			get;
			set;
		}
		/// <summary>
		/// me_fb_rmk03
		/// </summary>
		public string me_fb_rmk03
		{
			get;
			set;
		}
		/// <summary>
		/// me_fb_rmk04
		/// </summary>
		public string me_fb_rmk04
		{
			get;
			set;
		}
		/// <summary>
		/// me_fb_rmk05
		/// </summary>
		public string me_fb_rmk05
		{
			get;
			set;
		}
		/// <summary>
		/// me_fb_rmk06
		/// </summary>
		public string me_fb_rmk06
		{
			get;
			set;
		}
		/// <summary>
		/// me_fb_rmk07
		/// </summary>
		public string me_fb_rmk07
		{
			get;
			set;
		}
		/// <summary>
		/// me_fb_rmk08
		/// </summary>
		public string me_fb_rmk08
		{
			get;
			set;
		}
		/// <summary>
		/// me_fb_rmk09
		/// </summary>
		public string me_fb_rmk09
		{
			get;
			set;
		}
		/// <summary>
		/// me_fb_rmk10
		/// </summary>
		public string me_fb_rmk10
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
		/// <summary>
		/// fb_cfm_end_qty_ok
		/// </summary>
		public decimal fb_cfm_end_qty_ok
		{
			get;
			set;
		}
		/// <summary>
		/// fb_cfm_end_qty_ng
		/// </summary>
		public decimal fb_cfm_end_qty_ng
		{
			get;
			set;
		}
		/// <summary>
		/// fb_cfm_end_qty_scrap
		/// </summary>
		public decimal fb_cfm_end_qty_scrap
		{
			get;
			set;
		}
		/// <summary>
		/// fb_cfm_end_qty_other
		/// </summary>
		public decimal fb_cfm_end_qty_other
		{
			get;
			set;
		}
		/// <summary>
		/// me_fb_cfm_rmk01
		/// </summary>
		public string me_fb_cfm_rmk01
		{
			get;
			set;
		}
		/// <summary>
		/// me_fb_cfm_rmk02
		/// </summary>
		public string me_fb_cfm_rmk02
		{
			get;
			set;
		}
		/// <summary>
		/// me_fb_cfm_rmk03
		/// </summary>
		public string me_fb_cfm_rmk03
		{
			get;
			set;
		}
		/// <summary>
		/// me_fb_cfm_rmk04
		/// </summary>
		public string me_fb_cfm_rmk04
		{
			get;
			set;
		}
		/// <summary>
		/// cfm_time
		/// </summary>
		public DateTime? cfm_time
		{
			get;
			set;
		}
		/// <summary>
		/// cfm_user
		/// </summary>
		public string cfm_user
		{
			get;
			set;
		}
		/// <summary>
		/// cfm_user_no
		/// </summary>
		public string cfm_user_no
		{
			get;
			set;
		}
		/// <summary>
		/// cfm_user_name
		/// </summary>
		public string cfm_user_name
		{
			get;
			set;
		}
		/// <summary>
		/// cfm_host
		/// </summary>
		public string cfm_host
		{
			get;
			set;
		}
		/// <summary>
		/// io_is_sucessed
		/// </summary>
		public bool? io_is_sucessed
		{
			get;
			set;
		}
		/// <summary>
		/// io_times
		/// </summary>
		public int? io_times
		{
			get;
			set;
		}
		/// <summary>
		/// io_last_time
		/// </summary>
		public DateTime? io_last_time
		{
			get;
			set;
		}
		/// <summary>
		/// me_sn_part_id
		/// </summary>
		public string me_sn_part_id
		{
			get;
			set;
		}
		/// <summary>
		/// scada_id
		/// </summary>
		public int? scada_id
		{
			get;
			set;
		}
		/// <summary>
		/// is_manual
		/// </summary>
		public string is_manual
		{
			get;
			set;
		}
	}
}