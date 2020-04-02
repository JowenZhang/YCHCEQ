using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.EntityModel
{
	/// <summary>
	/// ss_grid_bc
	/// </summary>
	[Serializable]
	public class Ss_grid_bc
	{
		/// <summary>
		/// grid_bc_id
		/// </summary>
		public string grid_bc_id
		{
			get;
			set;
		}
		/// <summary>
		/// grid_bb_id
		/// </summary>
		public string grid_bb_id
		{
			get;
			set;
		}
		/// <summary>
		/// cell_sql_where
		/// </summary>
		public string cell_sql_where
		{
			get;
			set;
		}
		/// <summary>
		/// cell_color_background
		/// </summary>
		public string cell_color_background
		{
			get;
			set;
		}
		/// <summary>
		/// cell_font_color
		/// </summary>
		public string cell_font_color
		{
			get;
			set;
		}
		/// <summary>
		/// cell_style_to_row
		/// </summary>
		public bool? cell_style_to_row
		{
			get;
			set;
		}
		/// <summary>
		/// ss_grid_bc_rmk01
		/// </summary>
		public string ss_grid_bc_rmk01
		{
			get;
			set;
		}
		/// <summary>
		/// ss_grid_bc_rmk02
		/// </summary>
		public string ss_grid_bc_rmk02
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
	}
}