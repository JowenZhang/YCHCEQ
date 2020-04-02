using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.EntityModel
{
	/// <summary>
	/// ps_lo_aps
	/// </summary>
	[Serializable]
	public class Ps_lo_aps
	{
		/// <summary>
		/// lo_id
		/// </summary>
		public string lo_id
		{
			get;
			set;
		}
		/// <summary>
		/// lo_plan_start_datetime
		/// </summary>
		public DateTime? lo_plan_start_datetime
		{
			get;
			set;
		}
		/// <summary>
		/// lo_plan_end_datetime
		/// </summary>
		public DateTime? lo_plan_end_datetime
		{
			get;
			set;
		}
		/// <summary>
		/// lo_ps_qty
		/// </summary>
		public decimal? lo_ps_qty
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
		/// upd_host
		/// </summary>
		public string upd_host
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
	}
}