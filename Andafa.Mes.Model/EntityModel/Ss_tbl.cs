using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.EntityModel
{
	/// <summary>
	/// ss_tbl
	/// </summary>
	[Serializable]
	public class Ss_tbl
	{
		/// <summary>
		/// ztable
		/// </summary>
		public string ztable
		{
			get;
			set;
		}
		/// <summary>
		/// ztable_name
		/// </summary>
		public string ztable_name
		{
			get;
			set;
		}
		/// <summary>
		/// ztable_type
		/// </summary>
		public string ztable_type
		{
			get;
			set;
		}
		/// <summary>
		/// data_log
		/// </summary>
		public bool? data_log
		{
			get;
			set;
		}
		/// <summary>
		/// auto_load_data
		/// </summary>
		public bool? auto_load_data
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
		/// ztable_source
		/// </summary>
		public string ztable_source
		{
			get;
			set;
		}
	}
}