using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.EntityModel
{
	/// <summary>
	/// cq_mtr
	/// </summary>
	[Serializable]
	public class Cq_mtr
	{
		/// <summary>
		/// rmh_id
		/// </summary>
		public string rmh_id
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
		/// mtr_part_id
		/// </summary>
		public string mtr_part_id
		{
			get;
			set;
		}
		/// <summary>
		/// mtr_qty
		/// </summary>
		public decimal mtr_qty
		{
			get;
			set;
		}
		/// <summary>
		/// mtr_waste_rate
		/// </summary>
		public decimal mtr_waste_rate
		{
			get;
			set;
		}
		/// <summary>
		/// mtr_waste_qty_min
		/// </summary>
		public decimal mtr_waste_qty_min
		{
			get;
			set;
		}
		/// <summary>
		/// mtr_unit_price
		/// </summary>
		public decimal mtr_unit_price
		{
			get;
			set;
		}
		/// <summary>
		/// remark1
		/// </summary>
		public string remark1
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
		public DateTime crt_time
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
		public DateTime upd_time
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
	}
}