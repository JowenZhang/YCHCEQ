using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.EntityModel
{
	/// <summary>
	/// ss_user_prog_log
	/// </summary>
	[Serializable]
	public class Ss_user_prog_log
	{
		/// <summary>
		/// tuid
		/// </summary>
		public string tuid
		{
			get;
			set;
		}
		/// <summary>
		/// start_time
		/// </summary>
		public DateTime start_time
		{
			get;
			set;
		}
		/// <summary>
		/// user_id
		/// </summary>
		public string user_id
		{
			get;
			set;
		}
		/// <summary>
		/// user_no
		/// </summary>
		public string user_no
		{
			get;
			set;
		}
		/// <summary>
		/// user_name
		/// </summary>
		public string user_name
		{
			get;
			set;
		}
		/// <summary>
		/// prog_id
		/// </summary>
		public string prog_id
		{
			get;
			set;
		}
		/// <summary>
		/// prog_no
		/// </summary>
		public string prog_no
		{
			get;
			set;
		}
		/// <summary>
		/// prog_name
		/// </summary>
		public string prog_name
		{
			get;
			set;
		}
		/// <summary>
		/// prog_cmd
		/// </summary>
		public string prog_cmd
		{
			get;
			set;
		}
		/// <summary>
		/// prog_para
		/// </summary>
		public string prog_para
		{
			get;
			set;
		}
		/// <summary>
		/// end_time
		/// </summary>
		public DateTime? end_time
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