using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.EntityModel
{
	/// <summary>
	/// ss_log_run_error
	/// </summary>
	[Serializable]
	public class Ss_log_run_error
	{
		/// <summary>
		/// log_run_id
		/// </summary>
		public string log_run_id
		{
			get;
			set;
		}
		/// <summary>
		/// log_run_error
		/// </summary>
		public string log_run_error
		{
			get;
			set;
		}
	}
}