using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.EntityModel
{
	/// <summary>
	/// ss_log_update
	/// </summary>
	[Serializable]
	public class Ss_log_update
	{
		/// <summary>
		/// tuid
		/// </summary>
		public string tuid
		{
			get;
			set;
		}
		/// <summary>
		/// ztable
		/// </summary>
		public string ztable
		{
			get;
			set;
		}
		/// <summary>
		/// pk_field
		/// </summary>
		public string pk_field
		{
			get;
			set;
		}
		/// <summary>
		/// pk_data
		/// </summary>
		public string pk_data
		{
			get;
			set;
		}
		/// <summary>
		/// data_field
		/// </summary>
		public string data_field
		{
			get;
			set;
		}
		/// <summary>
		/// data_before
		/// </summary>
		public string data_before
		{
			get;
			set;
		}
		/// <summary>
		/// data_after
		/// </summary>
		public string data_after
		{
			get;
			set;
		}
		/// <summary>
		/// prog_id
		/// </summary>
		public string prog_id
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