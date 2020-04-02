using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.EntityModel
{
	/// <summary>
	/// pd_part_para
	/// </summary>
	[Serializable]
	public class Pd_part_para
	{
		/// <summary>
		/// part_no
		/// </summary>
		public string part_no
		{
			get;
			set;
		}
		/// <summary>
		/// part_para_name
		/// </summary>
		public string part_para_name
		{
			get;
			set;
		}
		/// <summary>
		/// part_para_desc
		/// </summary>
		public string part_para_desc
		{
			get;
			set;
		}
		/// <summary>
		/// part_para_value
		/// </summary>
		public string part_para_value
		{
			get;
			set;
		}
	}
}