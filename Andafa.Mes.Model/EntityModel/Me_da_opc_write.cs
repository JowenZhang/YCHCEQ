using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.EntityModel
{
	/// <summary>
	/// me_da_opc_write
	/// </summary>
	[Serializable]
	public class Me_da_opc_write
	{
		/// <summary>
		/// da_opc_write_id
		/// </summary>
		public string da_opc_write_id
		{
			get;
			set;
		}
		/// <summary>
		/// dt_no
		/// </summary>
		public string dt_no
		{
			get;
			set;
		}
		/// <summary>
		/// dt_data
		/// </summary>
		public string dt_data
		{
			get;
			set;
		}
		/// <summary>
		/// is_already_execute
		/// </summary>
		public bool? is_already_execute
		{
			get;
			set;
		}
		/// <summary>
		/// is_execute_successful
		/// </summary>
		public bool? is_execute_successful
		{
			get;
			set;
		}
		/// <summary>
		/// execute_log
		/// </summary>
		public string execute_log
		{
			get;
			set;
		}
		/// <summary>
		/// is_renewed_execute
		/// </summary>
		public bool? is_renewed_execute
		{
			get;
			set;
		}
		/// <summary>
		/// opc_write_rmk01
		/// </summary>
		public string opc_write_rmk01
		{
			get;
			set;
		}
		/// <summary>
		/// opc_write_rmk02
		/// </summary>
		public string opc_write_rmk02
		{
			get;
			set;
		}
		/// <summary>
		/// crt_time
		/// </summary>
		public DateTime crt_time
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