using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.EntityModel
{
	/// <summary>
	/// mo_rmb_cost
	/// </summary>
	[Serializable]
	public class Mo_rmb_cost
	{
		/// <summary>
		/// unode
		/// </summary>
		public string unode
		{
			get;
			set;
		}
		/// <summary>
		/// wkn_status
		/// </summary>
		public string wkn_status
		{
			get;
			set;
		}
		/// <summary>
		/// wkn_status_name
		/// </summary>
		public string wkn_status_name
		{
			get;
			set;
		}
		/// <summary>
		/// wkn_start_worker_id
		/// </summary>
		public string wkn_start_worker_id
		{
			get;
			set;
		}
		/// <summary>
		/// wkn_start_worker_no
		/// </summary>
		public bool? wkn_start_worker_no
		{
			get;
			set;
		}
		/// <summary>
		/// wkn_start_worker_name
		/// </summary>
		public bool? wkn_start_worker_name
		{
			get;
			set;
		}
		/// <summary>
		/// wkn_real_cost
		/// </summary>
		public decimal? wkn_real_cost
		{
			get;
			set;
		}
		/// <summary>
		/// wkn_mtr_real_cost
		/// </summary>
		public decimal? wkn_mtr_real_cost
		{
			get;
			set;
		}
		/// <summary>
		/// wkn_worker_real_cost
		/// </summary>
		public decimal? wkn_worker_real_cost
		{
			get;
			set;
		}
		/// <summary>
		/// wkn_wkc_real_cost
		/// </summary>
		public decimal? wkn_wkc_real_cost
		{
			get;
			set;
		}
		/// <summary>
		/// wkn_tools_real_cost
		/// </summary>
		public decimal? wkn_tools_real_cost
		{
			get;
			set;
		}
	}
}