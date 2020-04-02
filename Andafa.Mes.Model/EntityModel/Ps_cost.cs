using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.EntityModel
{
	/// <summary>
	/// ps_cost
	/// </summary>
	[Serializable]
	public class Ps_cost
	{
		/// <summary>
		/// cost_date
		/// </summary>
		public DateTime cost_date
		{
			get;
			set;
		}
		/// <summary>
		/// wkc_cost_produce
		/// </summary>
		public decimal wkc_cost_produce
		{
			get;
			set;
		}
		/// <summary>
		/// wkc_cost_before
		/// </summary>
		public decimal wkc_cost_before
		{
			get;
			set;
		}
		/// <summary>
		/// wkc_cost_after
		/// </summary>
		public decimal wkc_cost_after
		{
			get;
			set;
		}
		/// <summary>
		/// wkc_cost_worker
		/// </summary>
		public decimal wkc_cost_worker
		{
			get;
			set;
		}
		/// <summary>
		/// wkc_cost_idle
		/// </summary>
		public decimal wkc_cost_idle
		{
			get;
			set;
		}
		/// <summary>
		/// tools_cost_produce
		/// </summary>
		public decimal tools_cost_produce
		{
			get;
			set;
		}
		/// <summary>
		/// tools_cost_before
		/// </summary>
		public decimal tools_cost_before
		{
			get;
			set;
		}
		/// <summary>
		/// tools_cost_after
		/// </summary>
		public decimal tools_cost_after
		{
			get;
			set;
		}
		/// <summary>
		/// tools_cost_idle
		/// </summary>
		public decimal tools_cost_idle
		{
			get;
			set;
		}
	}
}