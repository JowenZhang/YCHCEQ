using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.EntityModel
{
	/// <summary>
	/// ss_fold
	/// </summary>
	[Serializable]
	public class Ss_fold
	{
		/// <summary>
		/// fold_id
		/// </summary>
		public string fold_id
		{
			get;
			set;
		}
		/// <summary>
		/// fold_no
		/// </summary>
		public string fold_no
		{
			get;
			set;
		}
		/// <summary>
		/// fold_name
		/// </summary>
		public string fold_name
		{
			get;
			set;
		}
		/// <summary>
		/// parent_fold_id
		/// </summary>
		public string parent_fold_id
		{
			get;
			set;
		}
		/// <summary>
		/// lang_str_id
		/// </summary>
		public string lang_str_id
		{
			get;
			set;
		}
		/// <summary>
		/// sort_no
		/// </summary>
		public int? sort_no
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
	}
}