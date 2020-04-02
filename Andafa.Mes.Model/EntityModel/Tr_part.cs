using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.EntityModel
{
	/// <summary>
	/// tr_part
	/// </summary>
	[Serializable]
	public class Tr_part
	{
		/// <summary>
		/// tr_part_id
		/// </summary>
		public string tr_part_id
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
		/// tr_location_id_from
		/// </summary>
		public string tr_location_id_from
		{
			get;
			set;
		}
		/// <summary>
		/// tr_location_id_to
		/// </summary>
		public string tr_location_id_to
		{
			get;
			set;
		}
		/// <summary>
		/// tr_mode_id
		/// </summary>
		public string tr_mode_id
		{
			get;
			set;
		}
		/// <summary>
		/// tr_mode_priority
		/// </summary>
		public int tr_mode_priority
		{
			get;
			set;
		}
		/// <summary>
		/// tr_mode_qty_min
		/// </summary>
		public int tr_mode_qty_min
		{
			get;
			set;
		}
		/// <summary>
		/// tr_mode_qty_add
		/// </summary>
		public int tr_mode_qty_add
		{
			get;
			set;
		}
		/// <summary>
		/// tr_mode_cost
		/// </summary>
		public decimal tr_mode_cost
		{
			get;
			set;
		}
		/// <summary>
		/// tr_mode_rmk01
		/// </summary>
		public string tr_mode_rmk01
		{
			get;
			set;
		}
		/// <summary>
		/// tr_mode_rmk02
		/// </summary>
		public string tr_mode_rmk02
		{
			get;
			set;
		}
		/// <summary>
		/// tr_mode_rmk03
		/// </summary>
		public string tr_mode_rmk03
		{
			get;
			set;
		}
		/// <summary>
		/// tr_mode_rmk04
		/// </summary>
		public string tr_mode_rmk04
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