using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.EntityModel
{
	/// <summary>
	/// sql_sizing
	/// </summary>
	[Serializable]
	public class Sql_sizing
	{
		/// <summary>
		/// sizing_id
		/// </summary>
		public int? sizing_id
		{
			get;
			set;
		}
		/// <summary>
		/// sizing_name
		/// </summary>
		public string sizing_name
		{
			get;
			set;
		}
		/// <summary>
		/// supported_value
		/// </summary>
		public int? supported_value
		{
			get;
			set;
		}
		/// <summary>
		/// comments
		/// </summary>
		public string comments
		{
			get;
			set;
		}
	}
}