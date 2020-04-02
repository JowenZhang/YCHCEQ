using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.EntityModel
{
	/// <summary>
	/// me_da_opc
	/// </summary>
	[Serializable]
	public class Me_da_opc
	{
		/// <summary>
		/// da_opc_id
		/// </summary>
		public string da_opc_id
		{
			get;
			set;
		}
		/// <summary>
		/// dt_no
		/// </summary>
		public string dt_no
		{
			get;
			set;
		}
		/// <summary>
		/// dt_data
		/// </summary>
		public string dt_data
		{
			get;
			set;
		}
		/// <summary>
		/// da_opc_rmk01
		/// </summary>
		public string da_opc_rmk01
		{
			get;
			set;
		}
		/// <summary>
		/// da_opc_rmk02
		/// </summary>
		public string da_opc_rmk02
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
		/// crt_host
		/// </summary>
		public string crt_host
		{
			get;
			set;
		}
	}
}