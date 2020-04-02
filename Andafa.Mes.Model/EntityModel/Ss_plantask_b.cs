using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.EntityModel
{
	/// <summary>
	/// ss_plantask_b
	/// </summary>
	[Serializable]
	public class Ss_plantask_b
	{
		/// <summary>
		/// plan_id
		/// </summary>
		public string plan_id
		{
			get;
			set;
		}
		/// <summary>
		/// task_id
		/// </summary>
		public string task_id
		{
			get;
			set;
		}
		/// <summary>
		/// frequency_type
		/// </summary>
		public string frequency_type
		{
			get;
			set;
		}
		/// <summary>
		/// erery_range
		/// </summary>
		public int erery_range
		{
			get;
			set;
		}
		/// <summary>
		/// start_time
		/// </summary>
		public DateTime? start_time
		{
			get;
			set;
		}
		/// <summary>
		/// donot_run_before
		/// </summary>
		public DateTime? donot_run_before
		{
			get;
			set;
		}
		/// <summary>
		/// donot_run_onthisday
		/// </summary>
		public string donot_run_onthisday
		{
			get;
			set;
		}
		/// <summary>
		/// remark
		/// </summary>
		public string remark
		{
			get;
			set;
		}
		/// <summary>
		/// plan_status
		/// </summary>
		public string plan_status
		{
			get;
			set;
		}
		/// <summary>
		/// current_run_status
		/// </summary>
		public string current_run_status
		{
			get;
			set;
		}
		/// <summary>
		/// last_run_status
		/// </summary>
		public string last_run_status
		{
			get;
			set;
		}
		/// <summary>
		/// last_run_time
		/// </summary>
		public DateTime? last_run_time
		{
			get;
			set;
		}
		/// <summary>
		/// next_run_time
		/// </summary>
		public DateTime? next_run_time
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
		public DateTime? upd_time
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