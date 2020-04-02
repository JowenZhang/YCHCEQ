using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.EntityModel
{
	/// <summary>
	/// pc_rst_h
	/// </summary>
	[Serializable]
	public class Pc_rst_h
	{
		/// <summary>
		/// pc_rst_h_id
		/// </summary>
		public string pc_rst_h_id
		{
			get;
			set;
		}
		/// <summary>
		/// pc_date_from
		/// </summary>
		public DateTime? pc_date_from
		{
			get;
			set;
		}
		/// <summary>
		/// pc_date_to
		/// </summary>
		public DateTime? pc_date_to
		{
			get;
			set;
		}
		/// <summary>
		/// calendar_type_name
		/// </summary>
		public string calendar_type_name
		{
			get;
			set;
		}
		/// <summary>
		/// wkt_abc_type_name
		/// </summary>
		public string wkt_abc_type_name
		{
			get;
			set;
		}
		/// <summary>
		/// pc_rst_h_rmk1
		/// </summary>
		public string pc_rst_h_rmk1
		{
			get;
			set;
		}
		/// <summary>
		/// pc_rst_h_rmk2
		/// </summary>
		public string pc_rst_h_rmk2
		{
			get;
			set;
		}
		/// <summary>
		/// pc_rst_h_rmk3
		/// </summary>
		public string pc_rst_h_rmk3
		{
			get;
			set;
		}
		/// <summary>
		/// pc_rst_h_rmk4
		/// </summary>
		public string pc_rst_h_rmk4
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
		/// <summary>
		/// pc_days_valid
		/// </summary>
		public int pc_days_valid
		{
			get;
			set;
		}
		/// <summary>
		/// pc_worker_hours_1day
		/// </summary>
		public int pc_worker_hours_1day
		{
			get;
			set;
		}
	}
}