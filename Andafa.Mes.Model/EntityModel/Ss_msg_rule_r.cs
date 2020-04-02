using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.EntityModel
{
	/// <summary>
	/// ss_msg_rule_r
	/// </summary>
	[Serializable]
	public class Ss_msg_rule_r
	{
		/// <summary>
		/// msg_rule_r_id
		/// </summary>
		public string msg_rule_r_id
		{
			get;
			set;
		}
		/// <summary>
		/// msg_rule_h_id
		/// </summary>
		public string msg_rule_h_id
		{
			get;
			set;
		}
		/// <summary>
		/// msg_receiver_worker_id
		/// </summary>
		public string msg_receiver_worker_id
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