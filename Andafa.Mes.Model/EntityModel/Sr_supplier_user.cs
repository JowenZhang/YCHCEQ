using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.EntityModel
{
	/// <summary>
	/// sr_supplier_user
	/// </summary>
	[Serializable]
	public class Sr_supplier_user
	{
		/// <summary>
		/// supplier_user_id
		/// </summary>
		public string supplier_user_id
		{
			get;
			set;
		}
		/// <summary>
		/// supplier_id
		/// </summary>
		public string supplier_id
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