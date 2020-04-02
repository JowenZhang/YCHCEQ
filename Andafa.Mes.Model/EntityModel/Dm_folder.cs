using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.EntityModel
{
	/// <summary>
	/// dm_folder
	/// </summary>
	[Serializable]
	public class Dm_folder
	{
		/// <summary>
		/// folder_id
		/// </summary>
		public string folder_id
		{
			get;
			set;
		}
		/// <summary>
		/// folder_name
		/// </summary>
		public string folder_name
		{
			get;
			set;
		}
		/// <summary>
		/// folder_parent
		/// </summary>
		public string folder_parent
		{
			get;
			set;
		}
		/// <summary>
		/// folder_parent_all
		/// </summary>
		public string folder_parent_all
		{
			get;
			set;
		}
		/// <summary>
		/// folder_path_all
		/// </summary>
		public string folder_path_all
		{
			get;
			set;
		}
		/// <summary>
		/// is_inherit_rights
		/// </summary>
		public bool? is_inherit_rights
		{
			get;
			set;
		}
		/// <summary>
		/// folder_rmk01
		/// </summary>
		public string folder_rmk01
		{
			get;
			set;
		}
		/// <summary>
		/// folder_rmk02
		/// </summary>
		public string folder_rmk02
		{
			get;
			set;
		}
		/// <summary>
		/// folder_rmk03
		/// </summary>
		public string folder_rmk03
		{
			get;
			set;
		}
		/// <summary>
		/// folder_rmk04
		/// </summary>
		public string folder_rmk04
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
		/// <summary>
		/// upd_time
		/// </summary>
		public DateTime upd_time
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
		/// grid_id
		/// </summary>
		public string grid_id
		{
			get;
			set;
		}
	}
}