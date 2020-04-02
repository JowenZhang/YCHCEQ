using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.EntityModel
{
	/// <summary>
	/// ps_task_mr
	/// </summary>
	[Serializable]
	public class Ps_task_mr
	{
		/// <summary>
		/// mr_datetime
		/// </summary>
		public DateTime mr_datetime
		{
			get;
			set;
		}
		/// <summary>
		/// part_id
		/// </summary>
		public string part_id
		{
			get;
			set;
		}
		/// <summary>
		/// req_qty
		/// </summary>
		public decimal req_qty
		{
			get;
			set;
		}
		/// <summary>
		/// supply_qty
		/// </summary>
		public decimal supply_qty
		{
			get;
			set;
		}
		/// <summary>
		/// balance_qty
		/// </summary>
		public decimal balance_qty
		{
			get;
			set;
		}
		/// <summary>
		/// ps_task_mr_batch_no
		/// </summary>
		public string ps_task_mr_batch_no
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
	}
}