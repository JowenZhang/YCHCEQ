using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.EntityModel
{
	/// <summary>
	/// ss_augrpu
	/// </summary>
	[Serializable]
	public class Ss_augrpu
	{
		/// <summary>
		/// augrp_id
		/// </summary>
		public string augrp_id
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
		public DateTime? crt_time
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