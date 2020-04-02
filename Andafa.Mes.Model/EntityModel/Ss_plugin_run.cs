using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.EntityModel
{
	/// <summary>
	/// ss_plugin_run
	/// </summary>
	[Serializable]
	public class Ss_plugin_run
	{
		/// <summary>
		/// plugin_run_id
		/// </summary>
		public string plugin_run_id
		{
			get;
			set;
		}
		/// <summary>
		/// plugin_run_batch
		/// </summary>
		public string plugin_run_batch
		{
			get;
			set;
		}
		/// <summary>
		/// plugin_run_pluginid
		/// </summary>
		public string plugin_run_pluginid
		{
			get;
			set;
		}
		/// <summary>
		/// plugin_run_finish
		/// </summary>
		public int? plugin_run_finish
		{
			get;
			set;
		}
		/// <summary>
		/// plugin_run_success
		/// </summary>
		public int? plugin_run_success
		{
			get;
			set;
		}
		/// <summary>
		/// plugin_run_message
		/// </summary>
		public string plugin_run_message
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
		public DateTime? crt_time
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
	}
}