using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.EntityModel
{
	/// <summary>
	/// ss_auth
	/// </summary>
	[Serializable]
	public class Ss_auth
	{
		/// <summary>
		/// auth_id
		/// </summary>
		public string auth_id
		{
			get;
			set;
		}
		/// <summary>
		/// auth_name
		/// </summary>
		public string auth_name
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
		/// <summary>
		/// rmk01
		/// </summary>
		public string rmk01
		{
			get;
			set;
		}
		/// <summary>
		/// rmk02
		/// </summary>
		public string rmk02
		{
			get;
			set;
		}
	}
}