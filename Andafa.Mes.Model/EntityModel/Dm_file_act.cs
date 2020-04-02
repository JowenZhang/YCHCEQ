using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.EntityModel
{
	/// <summary>
	/// dm_file_act
	/// </summary>
	[Serializable]
	public class Dm_file_act
	{
		/// <summary>
		/// file_act_id
		/// </summary>
		public string file_act_id
		{
			get;
			set;
		}
		/// <summary>
		/// file_act_datetime
		/// </summary>
		public DateTime file_act_datetime
		{
			get;
			set;
		}
		/// <summary>
		/// act_id
		/// </summary>
		public string act_id
		{
			get;
			set;
		}
		/// <summary>
		/// act_name
		/// </summary>
		public string act_name
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
		/// file_name
		/// </summary>
		public string file_name
		{
			get;
			set;
		}
		/// <summary>
		/// file_release
		/// </summary>
		public int file_release
		{
			get;
			set;
		}
		/// <summary>
		/// file_version
		/// </summary>
		public string file_version
		{
			get;
			set;
		}
		/// <summary>
		/// file_act_desc
		/// </summary>
		public string file_act_desc
		{
			get;
			set;
		}
		/// <summary>
		/// file_release_after
		/// </summary>
		public int file_release_after
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