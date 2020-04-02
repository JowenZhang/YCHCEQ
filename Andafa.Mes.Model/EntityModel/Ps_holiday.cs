using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.EntityModel
{
	/// <summary>
	/// ps_holiday
	/// </summary>
	[Serializable]
	public class Ps_holiday
	{
		/// <summary>
		/// holiday_id
		/// </summary>
		public string holiday_id
		{
			get;
			set;
		}
		/// <summary>
		/// holiday_date
		/// </summary>
		public DateTime holiday_date
		{
			get;
			set;
		}
		/// <summary>
		/// holiday_name
		/// </summary>
		public string holiday_name
		{
			get;
			set;
		}
		/// <summary>
		/// ps_holiday_rmk1
		/// </summary>
		public string ps_holiday_rmk1
		{
			get;
			set;
		}
		/// <summary>
		/// ps_holiday_rmk2
		/// </summary>
		public string ps_holiday_rmk2
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