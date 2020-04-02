using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.EntityModel
{
	/// <summary>
	/// dm_file_last
	/// </summary>
	[Serializable]
	public class Dm_file_last
	{
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
		/// file_is_lock
		/// </summary>
		public bool? file_is_lock
		{
			get;
			set;
		}
		/// <summary>
		/// last_lock_time
		/// </summary>
		public DateTime last_lock_time
		{
			get;
			set;
		}
		/// <summary>
		/// last_lock_user
		/// </summary>
		public string last_lock_user
		{
			get;
			set;
		}
		/// <summary>
		/// last_lock_host
		/// </summary>
		public string last_lock_host
		{
			get;
			set;
		}
		/// <summary>
		/// file_is_unlock
		/// </summary>
		public bool? file_is_unlock
		{
			get;
			set;
		}
		/// <summary>
		/// last_unlock_time
		/// </summary>
		public DateTime last_unlock_time
		{
			get;
			set;
		}
		/// <summary>
		/// last_unlock_user
		/// </summary>
		public string last_unlock_user
		{
			get;
			set;
		}
		/// <summary>
		/// last_unlock_host
		/// </summary>
		public string last_unlock_host
		{
			get;
			set;
		}
		/// <summary>
		/// file_is_checkout
		/// </summary>
		public bool? file_is_checkout
		{
			get;
			set;
		}
		/// <summary>
		/// file_checkout_path
		/// </summary>
		public string file_checkout_path
		{
			get;
			set;
		}
		/// <summary>
		/// last_checkout_time
		/// </summary>
		public DateTime last_checkout_time
		{
			get;
			set;
		}
		/// <summary>
		/// last_checkout_user
		/// </summary>
		public string last_checkout_user
		{
			get;
			set;
		}
		/// <summary>
		/// last_checkout_host
		/// </summary>
		public string last_checkout_host
		{
			get;
			set;
		}
		/// <summary>
		/// file_is_checkin
		/// </summary>
		public bool? file_is_checkin
		{
			get;
			set;
		}
		/// <summary>
		/// last_checkin_time
		/// </summary>
		public DateTime last_checkin_time
		{
			get;
			set;
		}
		/// <summary>
		/// last_checkin_user
		/// </summary>
		public string last_checkin_user
		{
			get;
			set;
		}
		/// <summary>
		/// last_checkin_host
		/// </summary>
		public string last_checkin_host
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
		/// crt_host
		/// </summary>
		public string crt_host
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
	}
}