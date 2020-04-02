using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.EntityModel
{
	/// <summary>
	/// king_shift
	/// </summary>
	[Serializable]
	public class King_shift
	{
		/// <summary>
		/// shiftid
		/// </summary>
		public string shiftid
		{
			get;
			set;
		}
		/// <summary>
		/// shiftsliceid
		/// </summary>
		public string shiftsliceid
		{
			get;
			set;
		}
		/// <summary>
		/// shiftslicename
		/// </summary>
		public string shiftslicename
		{
			get;
			set;
		}
		/// <summary>
		/// starttime
		/// </summary>
		public string starttime
		{
			get;
			set;
		}
		/// <summary>
		/// endtime
		/// </summary>
		public string endtime
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