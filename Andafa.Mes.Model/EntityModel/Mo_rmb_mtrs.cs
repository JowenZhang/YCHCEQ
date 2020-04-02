using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.EntityModel
{
	/// <summary>
	/// mo_rmb_mtrs
	/// </summary>
	[Serializable]
	public class Mo_rmb_mtrs
	{
		/// <summary>
		/// unode
		/// </summary>
		public string unode
		{
			get;
			set;
		}
		/// <summary>
		/// row_num
		/// </summary>
		public int row_num
		{
			get;
			set;
		}
		/// <summary>
		/// mtrs_part_no
		/// </summary>
		public string mtrs_part_no
		{
			get;
			set;
		}
		/// <summary>
		/// mtr_part_idt
		/// </summary>
		public string mtr_part_idt
		{
			get;
			set;
		}
		/// <summary>
		/// mtrs_qty
		/// </summary>
		public decimal mtrs_qty
		{
			get;
			set;
		}
		/// <summary>
		/// mtrs_qty_d
		/// </summary>
		public int mtrs_qty_d
		{
			get;
			set;
		}
		/// <summary>
		/// mtrs_qty_unit
		/// </summary>
		public string mtrs_qty_unit
		{
			get;
			set;
		}
		/// <summary>
		/// mtrs_waste_rate
		/// </summary>
		public decimal mtrs_waste_rate
		{
			get;
			set;
		}
		/// <summary>
		/// mtrs_waste_qty_min
		/// </summary>
		public decimal mtrs_waste_qty_min
		{
			get;
			set;
		}
		/// <summary>
		/// mtrs_use_qty_min
		/// </summary>
		public decimal? mtrs_use_qty_min
		{
			get;
			set;
		}
		/// <summary>
		/// mtrs_priority
		/// </summary>
		public int mtrs_priority
		{
			get;
			set;
		}
		/// <summary>
		/// mtrs_valid_time_from
		/// </summary>
		public DateTime? mtrs_valid_time_from
		{
			get;
			set;
		}
		/// <summary>
		/// mtrs_valid_time_to
		/// </summary>
		public DateTime? mtrs_valid_time_to
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
		/// upd_user_no
		/// </summary>
		public string upd_user_no
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