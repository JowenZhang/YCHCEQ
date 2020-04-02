using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.EntityModel
{
	/// <summary>
	/// ss_sql
	/// </summary>
	[Serializable]
	public class Ss_sql
	{
		/// <summary>
		/// sql_id
		/// </summary>
		public string sql_id
		{
			get;
			set;
		}
		/// <summary>
		/// sql_danger_level
		/// </summary>
		public int? sql_danger_level
		{
			get;
			set;
		}
		/// <summary>
		/// sql_name
		/// </summary>
		public string sql_name
		{
			get;
			set;
		}
		/// <summary>
		/// sql_content
		/// </summary>
		public string sql_content
		{
			get;
			set;
		}
		/// <summary>
		/// rmk9001
		/// </summary>
		public string rmk9001
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