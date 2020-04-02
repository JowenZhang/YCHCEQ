using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.EntityModel
{
	/// <summary>
	/// ss_log_object
	/// </summary>
	[Serializable]
	public class Ss_log_object
	{
		/// <summary>
		/// log_object_id
		/// </summary>
		public string log_object_id
		{
			get;
			set;
		}
		/// <summary>
		/// log_sort
		/// </summary>
		public string log_sort
		{
			get;
			set;
		}
		/// <summary>
		/// log_object_name
		/// </summary>
		public string log_object_name
		{
			get;
			set;
		}
		/// <summary>
		/// log_object_auth
		/// </summary>
		public string log_object_auth
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