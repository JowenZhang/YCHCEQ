using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.EntityModel
{
	/// <summary>
	/// cr_trans_part
	/// </summary>
	[Serializable]
	public class Cr_trans_part
	{
		/// <summary>
		/// trans_part_id
		/// </summary>
		public string trans_part_id
		{
			get;
			set;
		}
		/// <summary>
		/// part_id
		/// </summary>
		public string part_id
		{
			get;
			set;
		}
		/// <summary>
		/// trans_location_id_from
		/// </summary>
		public string trans_location_id_from
		{
			get;
			set;
		}
		/// <summary>
		/// trans_location_id_to
		/// </summary>
		public string trans_location_id_to
		{
			get;
			set;
		}
		/// <summary>
		/// trans_means_id
		/// </summary>
		public string trans_means_id
		{
			get;
			set;
		}
		/// <summary>
		/// trans_means_priority
		/// </summary>
		public int trans_means_priority
		{
			get;
			set;
		}
		/// <summary>
		/// trans_means_qty_min
		/// </summary>
		public int trans_means_qty_min
		{
			get;
			set;
		}
		/// <summary>
		/// trans_means_qty_add
		/// </summary>
		public int trans_means_qty_add
		{
			get;
			set;
		}
		/// <summary>
		/// trans_means_cost
		/// </summary>
		public decimal trans_means_cost
		{
			get;
			set;
		}
		/// <summary>
		/// trans_means_rmk1
		/// </summary>
		public string trans_means_rmk1
		{
			get;
			set;
		}
		/// <summary>
		/// trans_means_rmk2
		/// </summary>
		public string trans_means_rmk2
		{
			get;
			set;
		}
		/// <summary>
		/// trans_means_rmk3
		/// </summary>
		public string trans_means_rmk3
		{
			get;
			set;
		}
		/// <summary>
		/// trans_means_rmk4
		/// </summary>
		public string trans_means_rmk4
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
		/// crt_time
		/// </summary>
		public DateTime? crt_time
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
		/// <summary>
		/// upd_time
		/// </summary>
		public DateTime? upd_time
		{
			get;
			set;
		}
	}
}