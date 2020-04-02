using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.EntityModel
{
	/// <summary>
	/// inv_qty_tmp
	/// </summary>
	[Serializable]
	public class Inv_qty_tmp
	{
		/// <summary>
		/// nc_id
		/// </summary>
		public string nc_id
		{
			get;
			set;
		}
		/// <summary>
		/// mo_no
		/// </summary>
		public string mo_no
		{
			get;
			set;
		}
		/// <summary>
		/// order_no
		/// </summary>
		public string order_no
		{
			get;
			set;
		}
		/// <summary>
		/// part_no
		/// </summary>
		public string part_no
		{
			get;
			set;
		}
		/// <summary>
		/// wkc_no
		/// </summary>
		public string wkc_no
		{
			get;
			set;
		}
		/// <summary>
		/// qty_ok
		/// </summary>
		public decimal qty_ok
		{
			get;
			set;
		}
		/// <summary>
		/// fb_start_datetime
		/// </summary>
		public DateTime? fb_start_datetime
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