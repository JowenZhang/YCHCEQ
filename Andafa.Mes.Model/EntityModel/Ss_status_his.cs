using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.EntityModel
{
	/// <summary>
	/// ss_status_his
	/// </summary>
	[Serializable]
	public class Ss_status_his
	{
		/// <summary>
		/// ss_status_his_id
		/// </summary>
		public string ss_status_his_id
		{
			get;
			set;
		}
		/// <summary>
		/// table_no
		/// </summary>
		public string table_no
		{
			get;
			set;
		}
		/// <summary>
		/// field_no
		/// </summary>
		public string field_no
		{
			get;
			set;
		}
		/// <summary>
		/// field_value_before
		/// </summary>
		public string field_value_before
		{
			get;
			set;
		}
		/// <summary>
		/// field_value_now
		/// </summary>
		public string field_value_now
		{
			get;
			set;
		}
		/// <summary>
		/// ss_status_his_rmk1
		/// </summary>
		public string ss_status_his_rmk1
		{
			get;
			set;
		}
		/// <summary>
		/// ss_status_his_rmk2
		/// </summary>
		public string ss_status_his_rmk2
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