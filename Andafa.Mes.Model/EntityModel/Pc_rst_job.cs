using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.EntityModel
{
	/// <summary>
	/// pc_rst_job
	/// </summary>
	[Serializable]
	public class Pc_rst_job
	{
		/// <summary>
		/// pc_rst_job_id
		/// </summary>
		public string pc_rst_job_id
		{
			get;
			set;
		}
		/// <summary>
		/// pc_rst_h_id
		/// </summary>
		public string pc_rst_h_id
		{
			get;
			set;
		}
		/// <summary>
		/// job_no
		/// </summary>
		public string job_no
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
		/// factory_no
		/// </summary>
		public string factory_no
		{
			get;
			set;
		}
		/// <summary>
		/// factory_name
		/// </summary>
		public string factory_name
		{
			get;
			set;
		}
		/// <summary>
		/// job_valid_qty
		/// </summary>
		public int job_valid_qty
		{
			get;
			set;
		}
		/// <summary>
		/// job_valid_hour
		/// </summary>
		public int job_valid_hour
		{
			get;
			set;
		}
		/// <summary>
		/// job_require_hour
		/// </summary>
		public int job_require_hour
		{
			get;
			set;
		}
		/// <summary>
		/// job_require_qty
		/// </summary>
		public int job_require_qty
		{
			get;
			set;
		}
		/// <summary>
		/// pc_rst_job_rmk1
		/// </summary>
		public string pc_rst_job_rmk1
		{
			get;
			set;
		}
		/// <summary>
		/// pc_rst_job_rmk2
		/// </summary>
		public string pc_rst_job_rmk2
		{
			get;
			set;
		}
		/// <summary>
		/// pc_rst_job_rmk3
		/// </summary>
		public string pc_rst_job_rmk3
		{
			get;
			set;
		}
		/// <summary>
		/// pc_rst_job_rmk4
		/// </summary>
		public string pc_rst_job_rmk4
		{
			get;
			set;
		}
		/// <summary>
		/// crt_time
		/// </summary>
		public DateTime? crt_time
		{
			get;
			set;
		}
		/// <summary>
		/// crt_user
		/// </summary>
		public string crt_user
		{
			get;
			set;
		}
		/// <summary>
		/// crt_user_no
		/// </summary>
		public string crt_user_no
		{
			get;
			set;
		}
		/// <summary>
		/// crt_user_name
		/// </summary>
		public string crt_user_name
		{
			get;
			set;
		}
		/// <summary>
		/// crt_host
		/// </summary>
		public string crt_host
		{
			get;
			set;
		}
	}
}