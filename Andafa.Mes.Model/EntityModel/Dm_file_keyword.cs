using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.EntityModel
{
	/// <summary>
	/// dm_file_keyword
	/// </summary>
	[Serializable]
	public class Dm_file_keyword
	{
		/// <summary>
		/// file_keyword_id
		/// </summary>
		public string file_keyword_id
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
		/// file_keyword
		/// </summary>
		public string file_keyword
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