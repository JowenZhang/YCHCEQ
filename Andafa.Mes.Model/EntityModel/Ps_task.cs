using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.EntityModel
{
	/// <summary>
	/// ps_task
	/// </summary>
	[Serializable]
	public class Ps_task
	{
		/// <summary>
		/// task_id
		/// </summary>
		public string task_id
		{
			get;
			set;
		}
		/// <summary>
		/// ps_batch_id
		/// </summary>
		public string ps_batch_id
		{
			get;
			set;
		}
		/// <summary>
		/// task_no
		/// </summary>
		public string task_no
		{
			get;
			set;
		}
		/// <summary>
		/// task_shift_date
		/// </summary>
		public DateTime? task_shift_date
		{
			get;
			set;
		}
		/// <summary>
		/// task_shift_no
		/// </summary>
		public string task_shift_no
		{
			get;
			set;
		}
		/// <summary>
		/// task_shift_name
		/// </summary>
		public string task_shift_name
		{
			get;
			set;
		}
		/// <summary>
		/// task_datetime_start
		/// </summary>
		public DateTime task_datetime_start
		{
			get;
			set;
		}
		/// <summary>
		/// task_datetime_end
		/// </summary>
		public DateTime task_datetime_end
		{
			get;
			set;
		}
		/// <summary>
		/// task_datetime_type
		/// </summary>
		public string task_datetime_type
		{
			get;
			set;
		}
		/// <summary>
		/// task_datetime_type_name
		/// </summary>
		public string task_datetime_type_name
		{
			get;
			set;
		}
		/// <summary>
		/// factory_no
		/// </summary>
		public string factory_no
		{
			get;
			set;
		}
		/// <summary>
		/// factory_name
		/// </summary>
		public string factory_name
		{
			get;
			set;
		}
		/// <summary>
		/// dept_no
		/// </summary>
		public string dept_no
		{
			get;
			set;
		}
		/// <summary>
		/// dept_name
		/// </summary>
		public string dept_name
		{
			get;
			set;
		}
		/// <summary>
		/// line_no
		/// </summary>
		public string line_no
		{
			get;
			set;
		}
		/// <summary>
		/// line_name
		/// </summary>
		public string line_name
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
		/// wkc_name
		/// </summary>
		public string wkc_name
		{
			get;
			set;
		}
		/// <summary>
		/// order_type
		/// </summary>
		public string order_type
		{
			get;
			set;
		}
		/// <summary>
		/// order_type_name
		/// </summary>
		public string order_type_name
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
		/// order_qty
		/// </summary>
		public decimal? order_qty
		{
			get;
			set;
		}
		/// <summary>
		/// order_rmh_no
		/// </summary>
		public string order_rmh_no
		{
			get;
			set;
		}
		/// <summary>
		/// order_hope_start_datetime
		/// </summary>
		public DateTime? order_hope_start_datetime
		{
			get;
			set;
		}
		/// <summary>
		/// order_hope_end_datetime
		/// </summary>
		public DateTime? order_hope_end_datetime
		{
			get;
			set;
		}
		/// <summary>
		/// order_plan_start_datetime
		/// </summary>
		public DateTime? order_plan_start_datetime
		{
			get;
			set;
		}
		/// <summary>
		/// order_plan_end_datetime
		/// </summary>
		public DateTime? order_plan_end_datetime
		{
			get;
			set;
		}
		/// <summary>
		/// order_part_no
		/// </summary>
		public string order_part_no
		{
			get;
			set;
		}
		/// <summary>
		/// order_part_name
		/// </summary>
		public string order_part_name
		{
			get;
			set;
		}
		/// <summary>
		/// order_part_spec
		/// </summary>
		public string order_part_spec
		{
			get;
			set;
		}
		/// <summary>
		/// order_part_unit_name
		/// </summary>
		public string order_part_unit_name
		{
			get;
			set;
		}
		/// <summary>
		/// order_part_type1
		/// </summary>
		public string order_part_type1
		{
			get;
			set;
		}
		/// <summary>
		/// order_part_type1_name
		/// </summary>
		public string order_part_type1_name
		{
			get;
			set;
		}
		/// <summary>
		/// order_part_type2_name
		/// </summary>
		public string order_part_type2_name
		{
			get;
			set;
		}
		/// <summary>
		/// order_part_type3_name
		/// </summary>
		public string order_part_type3_name
		{
			get;
			set;
		}
		/// <summary>
		/// order_part_type4_name
		/// </summary>
		public string order_part_type4_name
		{
			get;
			set;
		}
		/// <summary>
		/// order_part_type5_name
		/// </summary>
		public string order_part_type5_name
		{
			get;
			set;
		}
		/// <summary>
		/// order_part_type6_name
		/// </summary>
		public string order_part_type6_name
		{
			get;
			set;
		}
		/// <summary>
		/// unode
		/// </summary>
		public string unode
		{
			get;
			set;
		}
		/// <summary>
		/// unode_next
		/// </summary>
		public string unode_next
		{
			get;
			set;
		}
		/// <summary>
		/// unode_wkn
		/// </summary>
		public string unode_wkn
		{
			get;
			set;
		}
		/// <summary>
		/// unode_wkn_desc
		/// </summary>
		public string unode_wkn_desc
		{
			get;
			set;
		}
		/// <summary>
		/// unode_wkp_no
		/// </summary>
		public string unode_wkp_no
		{
			get;
			set;
		}
		/// <summary>
		/// unode_wkp_name
		/// </summary>
		public string unode_wkp_name
		{
			get;
			set;
		}
		/// <summary>
		/// unode_qty_assigned
		/// </summary>
		public decimal unode_qty_assigned
		{
			get;
			set;
		}
		/// <summary>
		/// unode_capability_assigned
		/// </summary>
		public decimal unode_capability_assigned
		{
			get;
			set;
		}
		/// <summary>
		/// task_datetime_length
		/// </summary>
		public int task_datetime_length
		{
			get;
			set;
		}
		/// <summary>
		/// task_resttime_length
		/// </summary>
		public int? task_resttime_length
		{
			get;
			set;
		}
		/// <summary>
		/// task_is_twin
		/// </summary>
		public bool? task_is_twin
		{
			get;
			set;
		}
		/// <summary>
		/// task_is_manual
		/// </summary>
		public bool? task_is_manual
		{
			get;
			set;
		}
		/// <summary>
		/// task_is_fixed
		/// </summary>
		public bool? task_is_fixed
		{
			get;
			set;
		}
		/// <summary>
		/// task_is_closed
		/// </summary>
		public bool? task_is_closed
		{
			get;
			set;
		}
		/// <summary>
		/// order_type1
		/// </summary>
		public string order_type1
		{
			get;
			set;
		}
		/// <summary>
		/// order_no1
		/// </summary>
		public string order_no1
		{
			get;
			set;
		}
		/// <summary>
		/// order_delivery_datetime
		/// </summary>
		public DateTime? order_delivery_datetime
		{
			get;
			set;
		}
		/// <summary>
		/// task_version
		/// </summary>
		public string task_version
		{
			get;
			set;
		}
		/// <summary>
		/// plan_type
		/// </summary>
		public string plan_type
		{
			get;
			set;
		}
		/// <summary>
		/// p_id
		/// </summary>
		public string p_id
		{
			get;
			set;
		}
		/// <summary>
		/// ps_task_rmk11
		/// </summary>
		public string ps_task_rmk11
		{
			get;
			set;
		}
		/// <summary>
		/// ps_task_rmk12
		/// </summary>
		public string ps_task_rmk12
		{
			get;
			set;
		}
		/// <summary>
		/// ps_task_rmk13
		/// </summary>
		public string ps_task_rmk13
		{
			get;
			set;
		}
		/// <summary>
		/// ps_task_rmk14
		/// </summary>
		public string ps_task_rmk14
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
		public DateTime? upd_time
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