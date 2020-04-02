using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.EntityModel
{
	/// <summary>
	/// ss_grid_ub
	/// </summary>
	[Serializable]
	public class Ss_grid_ub
	{
		/// <summary>
		/// grid_id
		/// </summary>
		public string grid_id
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
		/// column_id
		/// </summary>
		public string column_id
		{
			get;
			set;
		}
		/// <summary>
		/// column_sequence
		/// </summary>
		public int column_sequence
		{
			get;
			set;
		}
		/// <summary>
		/// column_visible
		/// </summary>
		public bool column_visible
		{
			get;
			set;
		}
		/// <summary>
		/// column_width
		/// </summary>
		public int column_width
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
		/// crt_time
		/// </summary>
		public DateTime crt_time
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
		/// <summary>
		/// upd_time
		/// </summary>
		public DateTime upd_time
		{
			get;
			set;
		}
		/// <summary>
		/// column_is_frozen
		/// </summary>
		public bool? column_is_frozen
		{
			get;
			set;
		}
		/// <summary>
		/// grid_ub_id
		/// </summary>
		public string grid_ub_id
		{
			get;
			set;
		}
	}
}