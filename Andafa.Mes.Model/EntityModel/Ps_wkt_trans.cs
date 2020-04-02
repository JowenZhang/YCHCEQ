using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.EntityModel
{
	/// <summary>
	/// ps_wkt_trans
	/// </summary>
	[Serializable]
	public class Ps_wkt_trans
	{
		/// <summary>
		/// wkt_trans_id
		/// </summary>
		public string wkt_trans_id
		{
			get;
			set;
		}
		/// <summary>
		/// wkt_trans_no
		/// </summary>
		public string wkt_trans_no
		{
			get;
			set;
		}
		/// <summary>
		/// wkt_trans_name
		/// </summary>
		public string wkt_trans_name
		{
			get;
			set;
		}
		/// <summary>
		/// wkt_trans_time
		/// </summary>
		public decimal wkt_trans_time
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