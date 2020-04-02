using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.EntityModel
{
	/// <summary>
	/// mo_fb
	/// </summary>
	[Serializable]
	public class Mo_fb
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
		/// mo_fb_status
		/// </summary>
		public string mo_fb_status
		{
			get;
			set;
		}
		/// <summary>
		/// mo_real_first_start_datetime
		/// </summary>
		public DateTime? mo_real_first_start_datetime
		{
			get;
			set;
		}
		/// <summary>
		/// mo_real_last_end_datetime
		/// </summary>
		public DateTime? mo_real_last_end_datetime
		{
			get;
			set;
		}
		/// <summary>
		/// mo_finished_qty_ok_total
		/// </summary>
		public decimal mo_finished_qty_ok_total
		{
			get;
			set;
		}
		/// <summary>
		/// mo_finished_qty_ng_total
		/// </summary>
		public decimal mo_finished_qty_ng_total
		{
			get;
			set;
		}
		/// <summary>
		/// mo_finished_qty_scrap_total
		/// </summary>
		public decimal mo_finished_qty_scrap_total
		{
			get;
			set;
		}
		/// <summary>
		/// mo_finished_qty_other_total
		/// </summary>
		public decimal mo_finished_qty_other_total
		{
			get;
			set;
		}
		/// <summary>
		/// mo_stock_in_qty_total
		/// </summary>
		public decimal mo_stock_in_qty_total
		{
			get;
			set;
		}
		/// <summary>
		/// mo_fb_time_length
		/// </summary>
		public int? mo_fb_time_length
		{
			get;
			set;
		}
		/// <summary>
		/// mo_fb_ex_time_length
		/// </summary>
		public int? mo_fb_ex_time_length
		{
			get;
			set;
		}
		/// <summary>
		/// mo_fb_rest_time_length
		/// </summary>
		public int? mo_fb_rest_time_length
		{
			get;
			set;
		}
	}
}