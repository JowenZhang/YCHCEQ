using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.EntityModel
{
	/// <summary>
	/// king_calendar
	/// </summary>
	[Serializable]
	public class King_calendar
	{
		/// <summary>
		/// calid
		/// </summary>
		public string calid
		{
			get;
			set;
		}
		/// <summary>
		/// day
		/// </summary>
		public string day
		{
			get;
			set;
		}
		/// <summary>
		/// shiftid
		/// </summary>
		public string shiftid
		{
			get;
			set;
		}
		/// <summary>
		/// iswork
		/// </summary>
		public bool? iswork
		{
			get;
			set;
		}
		/// <summary>
		/// sessionid
		/// </summary>
		public string sessionid
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
		/// crt_user
		/// </summary>
		public string crt_user
		{
			get;
			set;
		}
		/// <summary>
		/// crt_user_no
		/// </summary>
		public string crt_user_no
		{
			get;
			set;
		}
		/// <summary>
		/// crt_user_name
		/// </summary>
		public string crt_user_name
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
	}
}