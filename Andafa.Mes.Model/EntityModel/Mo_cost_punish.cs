using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.EntityModel
{
	/// <summary>
	/// mo_cost_punish
	/// </summary>
	[Serializable]
	public class Mo_cost_punish
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
		/// mo_delay_days
		/// </summary>
		public decimal mo_delay_days
		{
			get;
			set;
		}
		/// <summary>
		/// mo_cost_punish_delay1
		/// </summary>
		public decimal mo_cost_punish_delay1
		{
			get;
			set;
		}
	}
}