using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.EntityModel
{
	/// <summary>
	/// sql_features
	/// </summary>
	[Serializable]
	public class Sql_features
	{
		/// <summary>
		/// feature_id
		/// </summary>
		public string feature_id
		{
			get;
			set;
		}
		/// <summary>
		/// feature_name
		/// </summary>
		public string feature_name
		{
			get;
			set;
		}
		/// <summary>
		/// sub_feature_id
		/// </summary>
		public string sub_feature_id
		{
			get;
			set;
		}
		/// <summary>
		/// sub_feature_name
		/// </summary>
		public string sub_feature_name
		{
			get;
			set;
		}
		/// <summary>
		/// is_supported
		/// </summary>
		public string is_supported
		{
			get;
			set;
		}
		/// <summary>
		/// is_verified_by
		/// </summary>
		public string is_verified_by
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