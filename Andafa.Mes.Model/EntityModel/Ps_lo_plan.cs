using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.EntityModel
{
	/// <summary>
	/// ps_lo_plan
	/// </summary>
	[Serializable]
	public class Ps_lo_plan
	{
		/// <summary>
		/// lo_id
		/// </summary>
		public string lo_id
		{
			get;
			set;
		}
		/// <summary>
		/// lo_plan_status
		/// </summary>
		public bool? lo_plan_status
		{
			get;
			set;
		}
		/// <summary>
		/// lo_plan_start_datetime
		/// </summary>
		public DateTime? lo_plan_start_datetime
		{
			get;
			set;
		}
		/// <summary>
		/// lo_plan_end_datetime
		/// </summary>
		public DateTime? lo_plan_end_datetime
		{
			get;
			set;
		}
	}
}