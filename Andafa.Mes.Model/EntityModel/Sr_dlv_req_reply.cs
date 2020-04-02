using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.EntityModel
{
	/// <summary>
	/// sr_dlv_req_reply
	/// </summary>
	[Serializable]
	public class Sr_dlv_req_reply
	{
		/// <summary>
		/// dlv_req_reply_id
		/// </summary>
		public string dlv_req_reply_id
		{
			get;
			set;
		}
		/// <summary>
		/// dlv_req_h_id
		/// </summary>
		public string dlv_req_h_id
		{
			get;
			set;
		}
		/// <summary>
		/// dlv_req_date
		/// </summary>
		public DateTime dlv_req_date
		{
			get;
			set;
		}
		/// <summary>
		/// dlv_req_time
		/// </summary>
		public string dlv_req_time
		{
			get;
			set;
		}
		/// <summary>
		/// dlv_req_reply_qty
		/// </summary>
		public decimal dlv_req_reply_qty
		{
			get;
			set;
		}
		/// <summary>
		/// is_locked
		/// </summary>
		public bool? is_locked
		{
			get;
			set;
		}
		/// <summary>
		/// dlv_req_reply_rmk01
		/// </summary>
		public string dlv_req_reply_rmk01
		{
			get;
			set;
		}
		/// <summary>
		/// dlv_req_reply_rmk02
		/// </summary>
		public string dlv_req_reply_rmk02
		{
			get;
			set;
		}
		/// <summary>
		/// dlv_req_reply_rmk03
		/// </summary>
		public string dlv_req_reply_rmk03
		{
			get;
			set;
		}
		/// <summary>
		/// dlv_req_reply_rmk04
		/// </summary>
		public string dlv_req_reply_rmk04
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