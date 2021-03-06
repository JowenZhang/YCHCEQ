using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.EntityModel
{
	/// <summary>
	/// sr_inquiry_b
	/// </summary>
	[Serializable]
	public class Sr_inquiry_b
	{
		/// <summary>
		/// inquiry_b_id
		/// </summary>
		public string inquiry_b_id
		{
			get;
			set;
		}
		/// <summary>
		/// inquiry_h_id
		/// </summary>
		public string inquiry_h_id
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
		/// part_unit
		/// </summary>
		public string part_unit
		{
			get;
			set;
		}
		/// <summary>
		/// unit_price_with_tax
		/// </summary>
		public decimal unit_price_with_tax
		{
			get;
			set;
		}
		/// <summary>
		/// unit_price_no_tax
		/// </summary>
		public decimal unit_price_no_tax
		{
			get;
			set;
		}
		/// <summary>
		/// purchase_qty_min
		/// </summary>
		public decimal? purchase_qty_min
		{
			get;
			set;
		}
		/// <summary>
		/// purchase_qty_add
		/// </summary>
		public decimal? purchase_qty_add
		{
			get;
			set;
		}
		/// <summary>
		/// purchase_lead_time
		/// </summary>
		public int? purchase_lead_time
		{
			get;
			set;
		}
		/// <summary>
		/// inquiry_valid_time_from
		/// </summary>
		public DateTime? inquiry_valid_time_from
		{
			get;
			set;
		}
		/// <summary>
		/// inquiry_valid_time_to
		/// </summary>
		public DateTime? inquiry_valid_time_to
		{
			get;
			set;
		}
		/// <summary>
		/// inquiry_b_rmk1
		/// </summary>
		public string inquiry_b_rmk1
		{
			get;
			set;
		}
		/// <summary>
		/// inquiry_b_rmk2
		/// </summary>
		public string inquiry_b_rmk2
		{
			get;
			set;
		}
		/// <summary>
		/// inquiry_b_rmk3
		/// </summary>
		public string inquiry_b_rmk3
		{
			get;
			set;
		}
		/// <summary>
		/// inquiry_b_rmk4
		/// </summary>
		public string inquiry_b_rmk4
		{
			get;
			set;
		}
		/// <summary>
		/// inquiry_b_rmk5
		/// </summary>
		public string inquiry_b_rmk5
		{
			get;
			set;
		}
		/// <summary>
		/// inquiry_b_rmk6
		/// </summary>
		public string inquiry_b_rmk6
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