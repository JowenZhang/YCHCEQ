using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.EntityModel
{
	/// <summary>
	/// tool_peijian
	/// </summary>
	[Serializable]
	public class Tool_peijian
	{
		/// <summary>
		/// tool_peijian_id
		/// </summary>
		public string tool_peijian_id
		{
			get;
			set;
		}
		/// <summary>
		/// tool_id
		/// </summary>
		public string tool_id
		{
			get;
			set;
		}
		/// <summary>
		/// tool_peijian_no
		/// </summary>
		public string tool_peijian_no
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