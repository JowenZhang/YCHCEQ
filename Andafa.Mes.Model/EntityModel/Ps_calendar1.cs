using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.EntityModel
{
	/// <summary>
	/// ps_calendar1
	/// </summary>
	[Serializable]
	public class Ps_calendar1
	{
		/// <summary>
		/// ps_calendar_id
		/// </summary>
		public string ps_calendar_id
		{
			get;
			set;
		}
		/// <summary>
		/// calendar_type
		/// </summary>
		public string calendar_type
		{
			get;
			set;
		}
		/// <summary>
		/// calendar_type_name
		/// </summary>
		public string calendar_type_name
		{
			get;
			set;
		}
		/// <summary>
		/// shift_date
		/// </summary>
		public DateTime shift_date
		{
			get;
			set;
		}
		/// <summary>
		/// weekday
		/// </summary>
		public string weekday
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
		/// work_time_start
		/// </summary>
		public DateTime work_time_start
		{
			get;
			set;
		}
		/// <summary>
		/// work_time_end
		/// </summary>
		public DateTime work_time_end
		{
			get;
			set;
		}
		/// <summary>
		/// shift_length
		/// </summary>
		public int shift_length
		{
			get;
			set;
		}
		/// <summary>
		/// rest_length
		/// </summary>
		public int rest_length
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
		/// shift_wkc_valid_qty
		/// </summary>
		public int? shift_wkc_valid_qty
		{
			get;
			set;
		}
		/// <summary>
		/// shift_wkc_eff
		/// </summary>
		public decimal? shift_wkc_eff
		{
			get;
			set;
		}
		/// <summary>
		/// shift_worker_num
		/// </summary>
		public decimal? shift_worker_num
		{
			get;
			set;
		}
		/// <summary>
		/// shift_is_fixed
		/// </summary>
		public bool? shift_is_fixed
		{
			get;
			set;
		}
		/// <summary>
		/// shift_1day_ahead
		/// </summary>
		public bool? shift_1day_ahead
		{
			get;
			set;
		}
		/// <summary>
		/// ps_calendar1_rmk01
		/// </summary>
		public string ps_calendar1_rmk01
		{
			get;
			set;
		}
		/// <summary>
		/// ps_calendar1_rmk02
		/// </summary>
		public string ps_calendar1_rmk02
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