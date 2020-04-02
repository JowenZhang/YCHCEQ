using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.EntityModel
{
	/// <summary>
	/// dm_file_link
	/// </summary>
	[Serializable]
	public class Dm_file_link
	{
		/// <summary>
		/// file_link_id
		/// </summary>
		public string file_link_id
		{
			get;
			set;
		}
		/// <summary>
		/// link_target_type
		/// </summary>
		public string link_target_type
		{
			get;
			set;
		}
		/// <summary>
		/// link_target_id
		/// </summary>
		public string link_target_id
		{
			get;
			set;
		}
		/// <summary>
		/// file_id
		/// </summary>
		public string file_id
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