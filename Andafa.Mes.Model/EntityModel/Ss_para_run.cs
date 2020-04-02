using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.EntityModel
{
	/// <summary>
	/// ss_para_run
	/// </summary>
	[Serializable]
	public class Ss_para_run
	{
		/// <summary>
		/// para_id
		/// </summary>
		public string para_id
		{
			get;
			set;
		}
		/// <summary>
		/// para_value
		/// </summary>
		public string para_value
		{
			get;
			set;
		}
		/// <summary>
		/// para_desc
		/// </summary>
		public string para_desc
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