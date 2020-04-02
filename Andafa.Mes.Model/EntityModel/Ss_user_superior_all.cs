using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.EntityModel
{
	/// <summary>
	/// ss_user_superior_all
	/// </summary>
	[Serializable]
	public class Ss_user_superior_all
	{
		/// <summary>
		/// user_superior
		/// </summary>
		public string user_superior
		{
			get;
			set;
		}
		/// <summary>
		/// user_id
		/// </summary>
		public string user_id
		{
			get;
			set;
		}
		/// <summary>
		/// origin_id
		/// </summary>
		public string origin_id
		{
			get;
			set;
		}
	}
}