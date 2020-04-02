using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.EntityModel
{
	/// <summary>
	/// ss_task
	/// </summary>
	[Serializable]
	public class Ss_task
	{
		/// <summary>
		/// task_id
		/// </summary>
		public string task_id
		{
			get;
			set;
		}
		/// <summary>
		/// task_status
		/// </summary>
		public string task_status
		{
			get;
			set;
		}
		/// <summary>
		/// task_subject
		/// </summary>
		public string task_subject
		{
			get;
			set;
		}
		/// <summary>
		/// task_content
		/// </summary>
		public string task_content
		{
			get;
			set;
		}
		/// <summary>
		/// task_user_no
		/// </summary>
		public string task_user_no
		{
			get;
			set;
		}
		/// <summary>
		/// task_user_name
		/// </summary>
		public string task_user_name
		{
			get;
			set;
		}
		/// <summary>
		/// task_hope_time_start
		/// </summary>
		public DateTime task_hope_time_start
		{
			get;
			set;
		}
		/// <summary>
		/// task_hope_time_end
		/// </summary>
		public DateTime task_hope_time_end
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
		public DateTime? upd_time
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