using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.EntityModel
{
	/// <summary>
	/// mo_finish_total
	/// </summary>
	[Serializable]
	public class Mo_finish_total
	{
		/// <summary>
		/// mo_no
		/// </summary>
		public string mo_no
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
		/// qty_ng
		/// </summary>
		public decimal qty_ng
		{
			get;
			set;
		}
		/// <summary>
		/// qty_scrap
		/// </summary>
		public decimal qty_scrap
		{
			get;
			set;
		}
		/// <summary>
		/// qty_other
		/// </summary>
		public decimal qty_other
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