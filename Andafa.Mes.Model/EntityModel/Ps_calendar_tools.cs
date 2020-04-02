using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.EntityModel
{
	/// <summary>
	/// ps_calendar_tools
	/// </summary>
	[Serializable]
	public class Ps_calendar_tools
	{
		/// <summary>
		/// work_date
		/// </summary>
		public DateTime work_date
		{
			get;
			set;
		}
		/// <summary>
		/// tools_id
		/// </summary>
		public string tools_id
		{
			get;
			set;
		}
		/// <summary>
		/// calendar_is_fixed
		/// </summary>
		public bool? calendar_is_fixed
		{
			get;
			set;
		}
		/// <summary>
		/// remark1
		/// </summary>
		public string remark1
		{
			get;
			set;
		}
		/// <summary>
		/// remark2
		/// </summary>
		public string remark2
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
		/// crt_host
		/// </summary>
		public string crt_host
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