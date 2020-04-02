using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.EntityModel
{
	/// <summary>
	/// sql_implementation_info
	/// </summary>
	[Serializable]
	public class Sql_implementation_info
	{
		/// <summary>
		/// implementation_info_id
		/// </summary>
		public string implementation_info_id
		{
			get;
			set;
		}
		/// <summary>
		/// implementation_info_name
		/// </summary>
		public string implementation_info_name
		{
			get;
			set;
		}
		/// <summary>
		/// integer_value
		/// </summary>
		public int? integer_value
		{
			get;
			set;
		}
		/// <summary>
		/// character_value
		/// </summary>
		public string character_value
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