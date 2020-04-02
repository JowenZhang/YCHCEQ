using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.EntityModel
{
	/// <summary>
	/// ps_task_tools
	/// </summary>
	[Serializable]
	public class Ps_task_tools
	{
		/// <summary>
		/// task_id
		/// </summary>
		public string task_id
		{
			get;
			set;
		}
		/// <summary>
		/// tools_id
		/// </summary>
		public string tools_id
		{
			get;
			set;
		}
		/// <summary>
		/// tools_used_qty
		/// </summary>
		public decimal tools_used_qty
		{
			get;
			set;
		}
		/// <summary>
		/// cost_run
		/// </summary>
		public decimal cost_run
		{
			get;
			set;
		}
		/// <summary>
		/// cost_work
		/// </summary>
		public decimal cost_work
		{
			get;
			set;
		}
	}
}