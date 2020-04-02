using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.EntityModel
{
	/// <summary>
	/// cr_trans_task
	/// </summary>
	[Serializable]
	public class Cr_trans_task
	{
		/// <summary>
		/// trans_task_id
		/// </summary>
		public string trans_task_id
		{
			get;
			set;
		}
		/// <summary>
		/// trans_datetime_start
		/// </summary>
		public DateTime? trans_datetime_start
		{
			get;
			set;
		}
		/// <summary>
		/// trans_datetime_end
		/// </summary>
		public DateTime? trans_datetime_end
		{
			get;
			set;
		}
		/// <summary>
		/// trans_datetime_days
		/// </summary>
		public decimal trans_datetime_days
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
		/// trans_location_no_from
		/// </summary>
		public string trans_location_no_from
		{
			get;
			set;
		}
		/// <summary>
		/// trans_location_name_from
		/// </summary>
		public string trans_location_name_from
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
		/// trans_location_no_to
		/// </summary>
		public string trans_location_no_to
		{
			get;
			set;
		}
		/// <summary>
		/// trans_location_name_to
		/// </summary>
		public string trans_location_name_to
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
		/// trans_means_no
		/// </summary>
		public string trans_means_no
		{
			get;
			set;
		}
		/// <summary>
		/// trans_means_name
		/// </summary>
		public string trans_means_name
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
		/// part_no
		/// </summary>
		public string part_no
		{
			get;
			set;
		}
		/// <summary>
		/// part_name
		/// </summary>
		public string part_name
		{
			get;
			set;
		}
		/// <summary>
		/// part_spec
		/// </summary>
		public string part_spec
		{
			get;
			set;
		}
		/// <summary>
		/// part_unit
		/// </summary>
		public string part_unit
		{
			get;
			set;
		}
		/// <summary>
		/// part_idt
		/// </summary>
		public string part_idt
		{
			get;
			set;
		}
		/// <summary>
		/// mrp_region_no
		/// </summary>
		public string mrp_region_no
		{
			get;
			set;
		}
		/// <summary>
		/// trans_qty
		/// </summary>
		public int trans_qty
		{
			get;
			set;
		}
		/// <summary>
		/// trans_cost
		/// </summary>
		public decimal trans_cost
		{
			get;
			set;
		}
		/// <summary>
		/// trans_task_rmk1
		/// </summary>
		public string trans_task_rmk1
		{
			get;
			set;
		}
		/// <summary>
		/// trans_task_rmk2
		/// </summary>
		public string trans_task_rmk2
		{
			get;
			set;
		}
		/// <summary>
		/// trans_task_rmk3
		/// </summary>
		public string trans_task_rmk3
		{
			get;
			set;
		}
		/// <summary>
		/// trans_task_rmk4
		/// </summary>
		public string trans_task_rmk4
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