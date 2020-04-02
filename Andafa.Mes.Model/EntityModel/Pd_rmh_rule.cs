using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.EntityModel
{
	/// <summary>
	/// pd_rmh_rule
	/// </summary>
	[Serializable]
	public class Pd_rmh_rule
	{
		/// <summary>
		/// rmh_rule_id
		/// </summary>
		public string rmh_rule_id
		{
			get;
			set;
		}
		/// <summary>
		/// rmh_rule_status
		/// </summary>
		public string rmh_rule_status
		{
			get;
			set;
		}
		/// <summary>
		/// rmh_rule_seq
		/// </summary>
		public decimal rmh_rule_seq
		{
			get;
			set;
		}
		/// <summary>
		/// rmh_rule_name
		/// </summary>
		public string rmh_rule_name
		{
			get;
			set;
		}
		/// <summary>
		/// rmh_rule_condation_sql
		/// </summary>
		public string rmh_rule_condation_sql
		{
			get;
			set;
		}
		/// <summary>
		/// rmh_rule_last_handle_time
		/// </summary>
		public DateTime? rmh_rule_last_handle_time
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