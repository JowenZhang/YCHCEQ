using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.EntityModel
{
	/// <summary>
	/// ss_rpt_param
	/// </summary>
	[Serializable]
	public class Ss_rpt_param
	{
		/// <summary>
		/// rpt_id
		/// </summary>
		public string rpt_id
		{
			get;
			set;
		}
		/// <summary>
		/// param_name
		/// </summary>
		public string param_name
		{
			get;
			set;
		}
		/// <summary>
		/// param_value
		/// </summary>
		public string param_value
		{
			get;
			set;
		}
	}
}