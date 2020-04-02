using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.EntityModel
{
	/// <summary>
	/// cr_so_b_ext
	/// </summary>
	[Serializable]
	public class Cr_so_b_ext
	{
		/// <summary>
		/// so_b_id
		/// </summary>
		public string so_b_id
		{
			get;
			set;
		}
		/// <summary>
		/// so_plan_status
		/// </summary>
		public bool? so_plan_status
		{
			get;
			set;
		}
		/// <summary>
		/// so_plan_start_datetime
		/// </summary>
		public DateTime? so_plan_start_datetime
		{
			get;
			set;
		}
		/// <summary>
		/// so_plan_end_datetime
		/// </summary>
		public DateTime? so_plan_end_datetime
		{
			get;
			set;
		}
		/// <summary>
		/// so_dlv_qty_real
		/// </summary>
		public decimal? so_dlv_qty_real
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