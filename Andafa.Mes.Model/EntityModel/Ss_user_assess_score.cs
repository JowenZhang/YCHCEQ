using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.EntityModel
{
	/// <summary>
	/// ss_user_assess_score
	/// </summary>
	[Serializable]
	public class Ss_user_assess_score
	{
		/// <summary>
		/// assess_score_id
		/// </summary>
		public string assess_score_id
		{
			get;
			set;
		}
		/// <summary>
		/// assess_date
		/// </summary>
		public DateTime assess_date
		{
			get;
			set;
		}
		/// <summary>
		/// assess_user
		/// </summary>
		public string assess_user
		{
			get;
			set;
		}
		/// <summary>
		/// is_manual
		/// </summary>
		public bool? is_manual
		{
			get;
			set;
		}
		/// <summary>
		/// assess_rule_name
		/// </summary>
		public string assess_rule_name
		{
			get;
			set;
		}
		/// <summary>
		/// assess_qty_real
		/// </summary>
		public int? assess_qty_real
		{
			get;
			set;
		}
		/// <summary>
		/// assess_score_real
		/// </summary>
		public int assess_score_real
		{
			get;
			set;
		}
		/// <summary>
		/// rmk1
		/// </summary>
		public string rmk1
		{
			get;
			set;
		}
		/// <summary>
		/// rmk2
		/// </summary>
		public string rmk2
		{
			get;
			set;
		}
		/// <summary>
		/// rmk3
		/// </summary>
		public string rmk3
		{
			get;
			set;
		}
		/// <summary>
		/// assess_rule_id
		/// </summary>
		public string assess_rule_id
		{
			get;
			set;
		}
		/// <summary>
		/// assess_qty_standard
		/// </summary>
		public int? assess_qty_standard
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
		/// upd_user
		/// </summary>
		public string upd_user
		{
			get;
			set;
		}
		/// <summary>
		/// upd_time
		/// </summary>
		public DateTime upd_time
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