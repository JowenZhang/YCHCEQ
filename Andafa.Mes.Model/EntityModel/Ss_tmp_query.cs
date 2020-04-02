using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.EntityModel
{
	/// <summary>
	/// ss_tmp_query
	/// </summary>
	[Serializable]
	public class Ss_tmp_query
	{
		/// <summary>
		/// batch_no
		/// </summary>
		public string batch_no
		{
			get;
			set;
		}
		/// <summary>
		/// data_id
		/// </summary>
		public string data_id
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
	}
}