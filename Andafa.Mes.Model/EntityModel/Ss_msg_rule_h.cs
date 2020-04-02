using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.EntityModel
{
	/// <summary>
	/// ss_msg_rule_h
	/// </summary>
	[Serializable]
	public class Ss_msg_rule_h
	{
		/// <summary>
		/// msg_rule_h_id
		/// </summary>
		public string msg_rule_h_id
		{
			get;
			set;
		}
		/// <summary>
		/// msg_rule_status
		/// </summary>
		public string msg_rule_status
		{
			get;
			set;
		}
		/// <summary>
		/// msg_name
		/// </summary>
		public string msg_name
		{
			get;
			set;
		}
		/// <summary>
		/// msg_condation_sql
		/// </summary>
		public string msg_condation_sql
		{
			get;
			set;
		}
		/// <summary>
		/// msg_time_length
		/// </summary>
		public int msg_time_length
		{
			get;
			set;
		}
		/// <summary>
		/// msg_time_unit
		/// </summary>
		public string msg_time_unit
		{
			get;
			set;
		}
		/// <summary>
		/// msg_body
		/// </summary>
		public string msg_body
		{
			get;
			set;
		}
		/// <summary>
		/// msg_send_type
		/// </summary>
		public string msg_send_type
		{
			get;
			set;
		}
		/// <summary>
		/// msg_type
		/// </summary>
		public string msg_type
		{
			get;
			set;
		}
		/// <summary>
		/// msg_send_interval_time_length
		/// </summary>
		public int? msg_send_interval_time_length
		{
			get;
			set;
		}
		/// <summary>
		/// msg_send_interval_time_unit
		/// </summary>
		public string msg_send_interval_time_unit
		{
			get;
			set;
		}
		/// <summary>
		/// msg_uid
		/// </summary>
		public string msg_uid
		{
			get;
			set;
		}
		/// <summary>
		/// msg_rule_last_handle_time
		/// </summary>
		public DateTime? msg_rule_last_handle_time
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