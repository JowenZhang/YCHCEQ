using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.EntityModel
{
	/// <summary>
	/// me_da_raw
	/// </summary>
	[Serializable]
	public class Me_da_raw
	{
		/// <summary>
		/// crt_time
		/// </summary>
		public string crt_time
		{
			get;
			set;
		}
		/// <summary>
		/// name
		/// </summary>
		public string name
		{
			get;
			set;
		}
		/// <summary>
		/// quality
		/// </summary>
		public string quality
		{
			get;
			set;
		}
		/// <summary>
		/// value
		/// </summary>
		public float? value
		{
			get;
			set;
		}
		/// <summary>
		/// variable_description
		/// </summary>
		public string variable_description
		{
			get;
			set;
		}
		/// <summary>
		/// variable_name
		/// </summary>
		public string variable_name
		{
			get;
			set;
		}
	}
}