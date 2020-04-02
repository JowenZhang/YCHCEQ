using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.EntityModel
{
	/// <summary>
	/// ss_log_run
	/// </summary>
	[Serializable]
	public class Ss_log_run
	{
		/// <summary>
		/// log_run_id
		/// </summary>
		public string log_run_id
		{
			get;
			set;
		}
		/// <summary>
		/// log_run_batch
		/// </summary>
		public string log_run_batch
		{
			get;
			set;
		}
		/// <summary>
		/// log_start_time
		/// </summary>
		public DateTime log_start_time
		{
			get;
			set;
		}
		/// <summary>
		/// log_end_time
		/// </summary>
		public DateTime log_end_time
		{
			get;
			set;
		}
		/// <summary>
		/// log_object_id
		/// </summary>
		public string log_object_id
		{
			get;
			set;
		}
		/// <summary>
		/// log_type_id
		/// </summary>
		public string log_type_id
		{
			get;
			set;
		}
		/// <summary>
		/// log_action
		/// </summary>
		public string log_action
		{
			get;
			set;
		}
		/// <summary>
		/// has_error
		/// </summary>
		public bool? has_error
		{
			get;
			set;
		}
		/// <summary>
		/// log_summary
		/// </summary>
		public string log_summary
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
	}
}