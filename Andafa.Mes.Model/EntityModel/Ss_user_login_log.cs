using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.EntityModel
{
	/// <summary>
	/// ss_user_login_log
	/// </summary>
	[Serializable]
	public class Ss_user_login_log
	{
		/// <summary>
		/// user_login_log_id
		/// </summary>
		public string user_login_log_id
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
		/// user_id
		/// </summary>
		public string user_id
		{
			get;
			set;
		}
		/// <summary>
		/// user_no
		/// </summary>
		public string user_no
		{
			get;
			set;
		}
		/// <summary>
		/// user_name
		/// </summary>
		public string user_name
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
		/// error_code
		/// </summary>
		public string error_code
		{
			get;
			set;
		}
		/// <summary>
		/// error_desc
		/// </summary>
		public string error_desc
		{
			get;
			set;
		}
	}
}