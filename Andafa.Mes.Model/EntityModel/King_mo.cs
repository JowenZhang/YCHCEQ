using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.EntityModel
{
	/// <summary>
	/// king_mo
	/// </summary>
	[Serializable]
	public class King_mo
	{
		/// <summary>
		/// moentryid
		/// </summary>
		public string moentryid
		{
			get;
			set;
		}
		/// <summary>
		/// parentid
		/// </summary>
		public string parentid
		{
			get;
			set;
		}
		/// <summary>
		/// mobillno
		/// </summary>
		public string mobillno
		{
			get;
			set;
		}
		/// <summary>
		/// mtrlnumber
		/// </summary>
		public string mtrlnumber
		{
			get;
			set;
		}
		/// <summary>
		/// mtrlname
		/// </summary>
		public string mtrlname
		{
			get;
			set;
		}
		/// <summary>
		/// requestdate
		/// </summary>
		public string requestdate
		{
			get;
			set;
		}
		/// <summary>
		/// requestqty
		/// </summary>
		public decimal? requestqty
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