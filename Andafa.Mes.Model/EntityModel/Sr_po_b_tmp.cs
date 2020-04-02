using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.EntityModel
{
	/// <summary>
	/// sr_po_b_tmp
	/// </summary>
	[Serializable]
	public class Sr_po_b_tmp
	{
		/// <summary>
		/// po_b_id
		/// </summary>
		public string po_b_id
		{
			get;
			set;
		}
		/// <summary>
		/// po_req_dlv_datetime
		/// </summary>
		public DateTime? po_req_dlv_datetime
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
		/// po_req_qty
		/// </summary>
		public decimal? po_req_qty
		{
			get;
			set;
		}
		/// <summary>
		/// po_hid
		/// </summary>
		public string po_hid
		{
			get;
			set;
		}
	}
}