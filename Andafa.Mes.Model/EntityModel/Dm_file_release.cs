using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.EntityModel
{
	/// <summary>
	/// dm_file_release
	/// </summary>
	[Serializable]
	public class Dm_file_release
	{
		/// <summary>
		/// file_release_id
		/// </summary>
		public string file_release_id
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
		/// file_release
		/// </summary>
		public int file_release
		{
			get;
			set;
		}
		/// <summary>
		/// file_size
		/// </summary>
		public long? file_size
		{
			get;
			set;
		}
		/// <summary>
		/// file_store_path
		/// </summary>
		public string file_store_path
		{
			get;
			set;
		}
		/// <summary>
		/// file_thumb_store_path
		/// </summary>
		public string file_thumb_store_path
		{
			get;
			set;
		}
		/// <summary>
		/// file_is_compressed
		/// </summary>
		public bool? file_is_compressed
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
		public DateTime upd_time
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