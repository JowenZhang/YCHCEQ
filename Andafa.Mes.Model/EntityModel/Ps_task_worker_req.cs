using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.EntityModel
{
	/// <summary>
	/// ps_task_worker_req
	/// </summary>
	[Serializable]
	public class Ps_task_worker_req
	{
		/// <summary>
		/// worker_req_datetime
		/// </summary>
		public DateTime worker_req_datetime
		{
			get;
			set;
		}
		/// <summary>
		/// job_id
		/// </summary>
		public string job_id
		{
			get;
			set;
		}
		/// <summary>
		/// job_name
		/// </summary>
		public string job_name
		{
			get;
			set;
		}
		/// <summary>
		/// req_qty
		/// </summary>
		public int req_qty
		{
			get;
			set;
		}
	}
}