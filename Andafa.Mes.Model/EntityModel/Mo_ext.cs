using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.EntityModel
{
	/// <summary>
	/// mo_ext
	/// </summary>
	[Serializable]
	public class Mo_ext
	{
		/// <summary>
		/// mo_no
		/// </summary>
		public string mo_no
		{
			get;
			set;
		}
		/// <summary>
		/// routing_print_times
		/// </summary>
		public int routing_print_times
		{
			get;
			set;
		}
		/// <summary>
		/// routing_last_print_datetime
		/// </summary>
		public DateTime? routing_last_print_datetime
		{
			get;
			set;
		}
		/// <summary>
		/// routing_last_print_user
		/// </summary>
		public string routing_last_print_user
		{
			get;
			set;
		}
	}
}