using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.EntityModel
{
	/// <summary>
	/// king_oper_dispatch
	/// </summary>
	[Serializable]
	public class King_oper_dispatch
	{
		/// <summary>
		/// dispatch_id
		/// </summary>
		public string dispatch_id
		{
			get;
			set;
		}
		/// <summary>
		/// operid
		/// </summary>
		public string operid
		{
			get;
			set;
		}
		/// <summary>
		/// workid
		/// </summary>
		public string workid
		{
			get;
			set;
		}
		/// <summary>
		/// workqty
		/// </summary>
		public decimal? workqty
		{
			get;
			set;
		}
		/// <summary>
		/// eqmnumber
		/// </summary>
		public string eqmnumber
		{
			get;
			set;
		}
		/// <summary>
		/// remainratio
		/// </summary>
		public decimal? remainratio
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