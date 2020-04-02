using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.EntityModel
{
	/// <summary>
	/// ss_user_prog_favorite
	/// </summary>
	[Serializable]
	public class Ss_user_prog_favorite
	{
		/// <summary>
		/// user_id
		/// </summary>
		public string user_id
		{
			get;
			set;
		}
		/// <summary>
		/// prog_id
		/// </summary>
		public string prog_id
		{
			get;
			set;
		}
		/// <summary>
		/// crt_host
		/// </summary>
		public string crt_host
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
	}
}