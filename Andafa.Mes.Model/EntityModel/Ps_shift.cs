using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.EntityModel
{
	/// <summary>
	/// ps_shift
	/// </summary>
	[Serializable]
	public class Ps_shift
	{
		/// <summary>
		/// shift_id
		/// </summary>
		public string shift_id
		{
			get;
			set;
		}
		/// <summary>
		/// shift_no
		/// </summary>
		public string shift_no
		{
			get;
			set;
		}
		/// <summary>
		/// shift_name
		/// </summary>
		public string shift_name
		{
			get;
			set;
		}
		/// <summary>
		/// begin_time
		/// </summary>
		public string begin_time
		{
			get;
			set;
		}
		/// <summary>
		/// end_time
		/// </summary>
		public string end_time
		{
			get;
			set;
		}
		/// <summary>
		/// shift_length
		/// </summary>
		public int? shift_length
		{
			get;
			set;
		}
		/// <summary>
		/// shift_1day_ahead
		/// </summary>
		public bool? shift_1day_ahead
		{
			get;
			set;
		}
		/// <summary>
		/// shift_type1
		/// </summary>
		public string shift_type1
		{
			get;
			set;
		}
		/// <summary>
		/// shift_type2
		/// </summary>
		public string shift_type2
		{
			get;
			set;
		}
		/// <summary>
		/// ps_shift_rmk01
		/// </summary>
		public string ps_shift_rmk01
		{
			get;
			set;
		}
		/// <summary>
		/// ps_shift_rmk02
		/// </summary>
		public string ps_shift_rmk02
		{
			get;
			set;
		}
		/// <summary>
		/// ps_shift_rmk03
		/// </summary>
		public string ps_shift_rmk03
		{
			get;
			set;
		}
		/// <summary>
		/// ps_shift_rmk04
		/// </summary>
		public string ps_shift_rmk04
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
		/// <summary>
		/// upd_time
		/// </summary>
		public DateTime upd_time
		{
			get;
			set;
		}
	}
}