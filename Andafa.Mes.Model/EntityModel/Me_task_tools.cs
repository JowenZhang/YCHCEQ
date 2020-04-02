using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.EntityModel
{
	/// <summary>
	/// me_task_tools
	/// </summary>
	[Serializable]
	public class Me_task_tools
	{
		/// <summary>
		/// me_task_tools_id
		/// </summary>
		public string me_task_tools_id
		{
			get;
			set;
		}
		/// <summary>
		/// me_task_id
		/// </summary>
		public string me_task_id
		{
			get;
			set;
		}
		/// <summary>
		/// tools_no
		/// </summary>
		public string tools_no
		{
			get;
			set;
		}
		/// <summary>
		/// tools_name
		/// </summary>
		public string tools_name
		{
			get;
			set;
		}
		/// <summary>
		/// tools_qty
		/// </summary>
		public int? tools_qty
		{
			get;
			set;
		}
		/// <summary>
		/// tools_cavity_qty
		/// </summary>
		public int? tools_cavity_qty
		{
			get;
			set;
		}
		/// <summary>
		/// me_task_tools_rmk01
		/// </summary>
		public string me_task_tools_rmk01
		{
			get;
			set;
		}
		/// <summary>
		/// me_task_tools_rmk02
		/// </summary>
		public string me_task_tools_rmk02
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
		/// upd_time
		/// </summary>
		public DateTime? upd_time
		{
			get;
			set;
		}
		/// <summary>
		/// upd_user
		/// </summary>
		public string upd_user
		{
			get;
			set;
		}
		/// <summary>
		/// upd_user_no
		/// </summary>
		public string upd_user_no
		{
			get;
			set;
		}
		/// <summary>
		/// upd_user_name
		/// </summary>
		public string upd_user_name
		{
			get;
			set;
		}
		/// <summary>
		/// upd_host
		/// </summary>
		public string upd_host
		{
			get;
			set;
		}
	}
}