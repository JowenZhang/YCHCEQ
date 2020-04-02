using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.EntityModel
{
	/// <summary>
	/// me_worker_clockinout
	/// </summary>
	[Serializable]
	public class Me_worker_clockinout
	{
		/// <summary>
		/// me_worker_clockinout_id
		/// </summary>
		public string me_worker_clockinout_id
		{
			get;
			set;
		}
		/// <summary>
		/// worker_clockinout_datetime
		/// </summary>
		public DateTime worker_clockinout_datetime
		{
			get;
			set;
		}
		/// <summary>
		/// worker_card_no
		/// </summary>
		public string worker_card_no
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