using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.EntityModel
{
	/// <summary>
	/// sql_sizing_profiles
	/// </summary>
	[Serializable]
	public class Sql_sizing_profiles
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
		/// profile_id
		/// </summary>
		public string profile_id
		{
			get;
			set;
		}
		/// <summary>
		/// required_value
		/// </summary>
		public int? required_value
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