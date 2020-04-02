using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.EntityModel
{
	/// <summary>
	/// ps_order_map
	/// </summary>
	[Serializable]
	public class Ps_order_map
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
		/// mo_qty
		/// </summary>
		public decimal mo_qty
		{
			get;
			set;
		}
		/// <summary>
		/// sales_order_type
		/// </summary>
		public string sales_order_type
		{
			get;
			set;
		}
		/// <summary>
		/// sales_order_no
		/// </summary>
		public string sales_order_no
		{
			get;
			set;
		}
		/// <summary>
		/// lo_no
		/// </summary>
		public string lo_no
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
	}
}