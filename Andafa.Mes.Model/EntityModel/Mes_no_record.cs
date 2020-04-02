using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.EntityModel
{
	/// <summary>
	/// mes_no_record
	/// </summary>
	[Serializable]
	public class Mes_no_record
	{
		/// <summary>
		/// no_record_id
		/// </summary>
		public string no_record_id
		{
			get;
			set;
		}
		/// <summary>
		/// physical_no
		/// </summary>
		public string physical_no
		{
			get;
			set;
		}
		/// <summary>
		/// sn_no
		/// </summary>
		public string sn_no
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
		/// upd_time
		/// </summary>
		public DateTime upd_time
		{
			get;
			set;
		}
		/// <summary>
		/// physical_no_status
		/// </summary>
		public string physical_no_status
		{
			get;
			set;
		}
		/// <summary>
		/// last_sn_no
		/// </summary>
		public string last_sn_no
		{
			get;
			set;
		}
	}
}