using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.EntityModel
{
	/// <summary>
	/// ss_helpdoc_relate
	/// </summary>
	[Serializable]
	public class Ss_helpdoc_relate
	{
		/// <summary>
		/// helpdoc_relate_id
		/// </summary>
		public string helpdoc_relate_id
		{
			get;
			set;
		}
		/// <summary>
		/// helpdoc_id
		/// </summary>
		public string helpdoc_id
		{
			get;
			set;
		}
		/// <summary>
		/// relate_helpdoc_seq
		/// </summary>
		public int relate_helpdoc_seq
		{
			get;
			set;
		}
		/// <summary>
		/// relate_helpdoc_id
		/// </summary>
		public string relate_helpdoc_id
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
	}
}