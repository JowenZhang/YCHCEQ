using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.EntityModel
{
	/// <summary>
	/// ss_augrp
	/// </summary>
	[Serializable]
	public class Ss_augrp
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
		/// augrp_no
		/// </summary>
		public string augrp_no
		{
			get;
			set;
		}
		/// <summary>
		/// augrp_name
		/// </summary>
		public string augrp_name
		{
			get;
			set;
		}
		/// <summary>
		/// upd_time
		/// </summary>
		public DateTime? upd_time
		{
			get;
			set;
		}
		/// <summary>
		/// upd_user
		/// </summary>
		public string upd_user
		{
			get;
			set;
		}
		/// <summary>
		/// upd_user_no
		/// </summary>
		public string upd_user_no
		{
			get;
			set;
		}
		/// <summary>
		/// upd_user_name
		/// </summary>
		public string upd_user_name
		{
			get;
			set;
		}
		/// <summary>
		/// upd_host
		/// </summary>
		public string upd_host
		{
			get;
			set;
		}
	}
}