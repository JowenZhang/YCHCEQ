using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.EntityModel
{
	/// <summary>
	/// mo
	/// </summary>
	[Serializable]
	public class Mo
	{
		/// <summary>
		/// mo_id
		/// </summary>
		public string mo_id
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
		/// mo_status
		/// </summary>
		public string mo_status
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
		/// rmh_no
		/// </summary>
		public string rmh_no
		{
			get;
			set;
		}
		/// <summary>
		/// rmh_version
		/// </summary>
		public string rmh_version
		{
			get;
			set;
		}
		/// <summary>
		/// mo_qty
		/// </summary>
		public decimal mo_qty
		{
			get;
			set;
		}
		/// <summary>
		/// mo_hope_start_datetime
		/// </summary>
		public DateTime mo_hope_start_datetime
		{
			get;
			set;
		}
		/// <summary>
		/// mo_hope_end_datetime
		/// </summary>
		public DateTime mo_hope_end_datetime
		{
			get;
			set;
		}
		/// <summary>
		/// mo_lot_no
		/// </summary>
		public string mo_lot_no
		{
			get;
			set;
		}
		/// <summary>
		/// mo_desc
		/// </summary>
		public string mo_desc
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
		/// workshop_no
		/// </summary>
		public string workshop_no
		{
			get;
			set;
		}
		/// <summary>
		/// mo_type
		/// </summary>
		public string mo_type
		{
			get;
			set;
		}
		/// <summary>
		/// mo_priority
		/// </summary>
		public int mo_priority
		{
			get;
			set;
		}
		/// <summary>
		/// mo_priority2
		/// </summary>
		public int? mo_priority2
		{
			get;
			set;
		}
		/// <summary>
		/// mo_need_aps
		/// </summary>
		public bool? mo_need_aps
		{
			get;
			set;
		}
		/// <summary>
		/// mo_aps_direction
		/// </summary>
		public string mo_aps_direction
		{
			get;
			set;
		}
		/// <summary>
		/// mo_cannot_earlier
		/// </summary>
		public bool? mo_cannot_earlier
		{
			get;
			set;
		}
		/// <summary>
		/// mo_cannot_earlier_than
		/// </summary>
		public DateTime? mo_cannot_earlier_than
		{
			get;
			set;
		}
		/// <summary>
		/// mo_reply_finish_time
		/// </summary>
		public DateTime? mo_reply_finish_time
		{
			get;
			set;
		}
		/// <summary>
		/// client_no
		/// </summary>
		public string client_no
		{
			get;
			set;
		}
		/// <summary>
		/// client_name
		/// </summary>
		public string client_name
		{
			get;
			set;
		}
		/// <summary>
		/// mo_splited_from1
		/// </summary>
		public string mo_splited_from1
		{
			get;
			set;
		}
		/// <summary>
		/// mo_splited_from2
		/// </summary>
		public string mo_splited_from2
		{
			get;
			set;
		}
		/// <summary>
		/// mo_parent
		/// </summary>
		public string mo_parent
		{
			get;
			set;
		}
		/// <summary>
		/// mo_parent_top
		/// </summary>
		public string mo_parent_top
		{
			get;
			set;
		}
		/// <summary>
		/// mo_parent_all
		/// </summary>
		public string mo_parent_all
		{
			get;
			set;
		}
		/// <summary>
		/// unode_mo_parent
		/// </summary>
		public string unode_mo_parent
		{
			get;
			set;
		}
		/// <summary>
		/// mo_cost_to
		/// </summary>
		public string mo_cost_to
		{
			get;
			set;
		}
		/// <summary>
		/// order_id1
		/// </summary>
		public string order_id1
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
		/// order_type_name1
		/// </summary>
		public string order_type_name1
		{
			get;
			set;
		}
		/// <summary>
		/// order_mrp_region_no1
		/// </summary>
		public string order_mrp_region_no1
		{
			get;
			set;
		}
		/// <summary>
		/// order_id2
		/// </summary>
		public string order_id2
		{
			get;
			set;
		}
		/// <summary>
		/// order_type2
		/// </summary>
		public string order_type2
		{
			get;
			set;
		}
		/// <summary>
		/// order_no2
		/// </summary>
		public string order_no2
		{
			get;
			set;
		}
		/// <summary>
		/// order_type_name2
		/// </summary>
		public string order_type_name2
		{
			get;
			set;
		}
		/// <summary>
		/// order_mrp_region_no2
		/// </summary>
		public string order_mrp_region_no2
		{
			get;
			set;
		}
		/// <summary>
		/// mo_rmk01
		/// </summary>
		public string mo_rmk01
		{
			get;
			set;
		}
		/// <summary>
		/// mo_rmk02
		/// </summary>
		public string mo_rmk02
		{
			get;
			set;
		}
		/// <summary>
		/// mo_rmk03
		/// </summary>
		public string mo_rmk03
		{
			get;
			set;
		}
		/// <summary>
		/// mo_rmk04
		/// </summary>
		public string mo_rmk04
		{
			get;
			set;
		}
		/// <summary>
		/// mo_rmk05
		/// </summary>
		public string mo_rmk05
		{
			get;
			set;
		}
		/// <summary>
		/// mo_rmk06
		/// </summary>
		public string mo_rmk06
		{
			get;
			set;
		}
		/// <summary>
		/// mo_rmk07
		/// </summary>
		public string mo_rmk07
		{
			get;
			set;
		}
		/// <summary>
		/// mo_rmk08
		/// </summary>
		public string mo_rmk08
		{
			get;
			set;
		}
		/// <summary>
		/// mo_rmk09
		/// </summary>
		public string mo_rmk09
		{
			get;
			set;
		}
		/// <summary>
		/// mo_rmk10
		/// </summary>
		public string mo_rmk10
		{
			get;
			set;
		}
		/// <summary>
		/// mo_rmk11
		/// </summary>
		public string mo_rmk11
		{
			get;
			set;
		}
		/// <summary>
		/// mo_rmk12
		/// </summary>
		public string mo_rmk12
		{
			get;
			set;
		}
		/// <summary>
		/// mo_rmk13
		/// </summary>
		public string mo_rmk13
		{
			get;
			set;
		}
		/// <summary>
		/// mo_rmk14
		/// </summary>
		public string mo_rmk14
		{
			get;
			set;
		}
		/// <summary>
		/// mo_rmk15
		/// </summary>
		public string mo_rmk15
		{
			get;
			set;
		}
		/// <summary>
		/// mo_rmk16
		/// </summary>
		public string mo_rmk16
		{
			get;
			set;
		}
		/// <summary>
		/// mo_rmk17
		/// </summary>
		public string mo_rmk17
		{
			get;
			set;
		}
		/// <summary>
		/// mo_rmk18
		/// </summary>
		public string mo_rmk18
		{
			get;
			set;
		}
		/// <summary>
		/// mo_rmk19
		/// </summary>
		public string mo_rmk19
		{
			get;
			set;
		}
		/// <summary>
		/// mo_rmk20
		/// </summary>
		public string mo_rmk20
		{
			get;
			set;
		}
		/// <summary>
		/// mo_bit1
		/// </summary>
		public bool? mo_bit1
		{
			get;
			set;
		}
		/// <summary>
		/// mo_bit2
		/// </summary>
		public bool? mo_bit2
		{
			get;
			set;
		}
		/// <summary>
		/// mo_bit3
		/// </summary>
		public bool? mo_bit3
		{
			get;
			set;
		}
		/// <summary>
		/// mo_bit4
		/// </summary>
		public bool? mo_bit4
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
		/// <summary>
		/// mo_is_launch
		/// </summary>
		public bool? mo_is_launch
		{
			get;
			set;
		}
		/// <summary>
		/// mo_launch_time
		/// </summary>
		public DateTime? mo_launch_time
		{
			get;
			set;
		}
		/// <summary>
		/// mo_launch_user
		/// </summary>
		public string mo_launch_user
		{
			get;
			set;
		}
		/// <summary>
		/// mo_launch_host
		/// </summary>
		public string mo_launch_host
		{
			get;
			set;
		}
		/// <summary>
		/// mo_confirm_user
		/// </summary>
		public string mo_confirm_user
		{
			get;
			set;
		}
		/// <summary>
		/// mo_confirm_host
		/// </summary>
		public string mo_confirm_host
		{
			get;
			set;
		}
		/// <summary>
		/// mo_confirm_time
		/// </summary>
		public DateTime? mo_confirm_time
		{
			get;
			set;
		}
		/// <summary>
		/// mo_sign_user
		/// </summary>
		public string mo_sign_user
		{
			get;
			set;
		}
		/// <summary>
		/// mo_sign_host
		/// </summary>
		public string mo_sign_host
		{
			get;
			set;
		}
		/// <summary>
		/// mo_sign_time
		/// </summary>
		public DateTime? mo_sign_time
		{
			get;
			set;
		}
		/// <summary>
		/// mo_pause_user
		/// </summary>
		public string mo_pause_user
		{
			get;
			set;
		}
		/// <summary>
		/// mo_pause_host
		/// </summary>
		public string mo_pause_host
		{
			get;
			set;
		}
		/// <summary>
		/// mo_pause_time
		/// </summary>
		public DateTime? mo_pause_time
		{
			get;
			set;
		}
		/// <summary>
		/// mo_close_user
		/// </summary>
		public string mo_close_user
		{
			get;
			set;
		}
		/// <summary>
		/// mo_close_host
		/// </summary>
		public string mo_close_host
		{
			get;
			set;
		}
		/// <summary>
		/// mo_close_time
		/// </summary>
		public DateTime? mo_close_time
		{
			get;
			set;
		}
		/// <summary>
		/// order_qty1
		/// </summary>
		public decimal? order_qty1
		{
			get;
			set;
		}
	}
}