using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.EntityModel
{
	/// <summary>
	/// pd_part_pack
	/// </summary>
	[Serializable]
	public class Pd_part_pack
	{
		/// <summary>
		/// part_pack_id
		/// </summary>
		public string part_pack_id
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
		/// client_no
		/// </summary>
		public string client_no
		{
			get;
			set;
		}
		/// <summary>
		/// supplier_no
		/// </summary>
		public string supplier_no
		{
			get;
			set;
		}
		/// <summary>
		/// pack_type
		/// </summary>
		public string pack_type
		{
			get;
			set;
		}
		/// <summary>
		/// parent_pack_type
		/// </summary>
		public string parent_pack_type
		{
			get;
			set;
		}
		/// <summary>
		/// pack_qty
		/// </summary>
		public decimal pack_qty
		{
			get;
			set;
		}
		/// <summary>
		/// pack_length
		/// </summary>
		public int? pack_length
		{
			get;
			set;
		}
		/// <summary>
		/// pack_width
		/// </summary>
		public int? pack_width
		{
			get;
			set;
		}
		/// <summary>
		/// pack_height
		/// </summary>
		public int? pack_height
		{
			get;
			set;
		}
		/// <summary>
		/// pack_weight_gross
		/// </summary>
		public decimal? pack_weight_gross
		{
			get;
			set;
		}
		/// <summary>
		/// pack_weight_net
		/// </summary>
		public decimal? pack_weight_net
		{
			get;
			set;
		}
		/// <summary>
		/// ischeck_parent_pack_type
		/// </summary>
		public bool? ischeck_parent_pack_type
		{
			get;
			set;
		}
		/// <summary>
		/// is_pack_test_ok
		/// </summary>
		public bool? is_pack_test_ok
		{
			get;
			set;
		}
		/// <summary>
		/// pack_rule
		/// </summary>
		public string pack_rule
		{
			get;
			set;
		}
		/// <summary>
		/// part_pack_rmk01
		/// </summary>
		public string part_pack_rmk01
		{
			get;
			set;
		}
		/// <summary>
		/// part_pack_rmk02
		/// </summary>
		public string part_pack_rmk02
		{
			get;
			set;
		}
		/// <summary>
		/// part_pack_rmk03
		/// </summary>
		public string part_pack_rmk03
		{
			get;
			set;
		}
		/// <summary>
		/// part_pack_rmk04
		/// </summary>
		public string part_pack_rmk04
		{
			get;
			set;
		}
		/// <summary>
		/// part_pack_rmk05
		/// </summary>
		public string part_pack_rmk05
		{
			get;
			set;
		}
		/// <summary>
		/// part_pack_rmk06
		/// </summary>
		public string part_pack_rmk06
		{
			get;
			set;
		}
		/// <summary>
		/// part_pack_rmk07
		/// </summary>
		public string part_pack_rmk07
		{
			get;
			set;
		}
		/// <summary>
		/// part_pack_rmk08
		/// </summary>
		public string part_pack_rmk08
		{
			get;
			set;
		}
		/// <summary>
		/// part_pack_rmk09
		/// </summary>
		public string part_pack_rmk09
		{
			get;
			set;
		}
		/// <summary>
		/// part_pack_rmk10
		/// </summary>
		public string part_pack_rmk10
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