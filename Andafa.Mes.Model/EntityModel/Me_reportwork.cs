using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.EntityModel
{
	/// <summary>
	/// me_reportwork
	/// </summary>
	[Serializable]
	public class Me_reportwork
	{
		/// <summary>
		/// reportwork_id
		/// </summary>
		public string reportwork_id
		{
			get;
			set;
		}
		/// <summary>
		/// mo_no
		/// </summary>
		public string mo_no
		{
			get;
			set;
		}
		/// <summary>
		/// part_no
		/// </summary>
		public string part_no
		{
			get;
			set;
		}
		/// <summary>
		/// wkn
		/// </summary>
		public string wkn
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
		/// wkc_no
		/// </summary>
		public string wkc_no
		{
			get;
			set;
		}
		/// <summary>
		/// worker_no
		/// </summary>
		public string worker_no
		{
			get;
			set;
		}
		/// <summary>
		/// qty_ok
		/// </summary>
		public decimal qty_ok
		{
			get;
			set;
		}
		/// <summary>
		/// preparetime
		/// </summary>
		public decimal preparetime
		{
			get;
			set;
		}
		/// <summary>
		/// machinetime
		/// </summary>
		public decimal machinetime
		{
			get;
			set;
		}
		/// <summary>
		/// mantime
		/// </summary>
		public decimal mantime
		{
			get;
			set;
		}
		/// <summary>
		/// stoptime
		/// </summary>
		public decimal stoptime
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
		/// <summary>
		/// me_reportwork_shijian
		/// </summary>
		public DateTime? me_reportwork_shijian
		{
			get;
			set;
		}
		/// <summary>
		/// me_reportwork_rmk01
		/// </summary>
		public string me_reportwork_rmk01
		{
			get;
			set;
		}
	}
}