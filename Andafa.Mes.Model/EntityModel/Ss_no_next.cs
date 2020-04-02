using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.EntityModel
{
	/// <summary>
	/// ss_no_next
	/// </summary>
	[Serializable]
	public class Ss_no_next
	{
		/// <summary>
		/// no_rule_h_no
		/// </summary>
		public string no_rule_h_no
		{
			get;
			set;
		}
		/// <summary>
		/// no_element_str
		/// </summary>
		public string no_element_str
		{
			get;
			set;
		}
		/// <summary>
		/// no_element_sn_next
		/// </summary>
		public int no_element_sn_next
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