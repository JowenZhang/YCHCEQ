using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.EntityModel
{
	/// <summary>
	/// mes_no_next
	/// </summary>
	[Serializable]
	public class Mes_no_next
	{
		/// <summary>
		/// no_next_id
		/// </summary>
		public string no_next_id
		{
			get;
			set;
		}
		/// <summary>
		/// no_next_title
		/// </summary>
		public string no_next_title
		{
			get;
			set;
		}
		/// <summary>
		/// no_next_no
		/// </summary>
		public int no_next_no
		{
			get;
			set;
		}
		/// <summary>
		/// no_next_flag
		/// </summary>
		public DateTime no_next_flag
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
	}
}