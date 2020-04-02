using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.EntityModel
{
	/// <summary>
	/// ss_fold_prog
	/// </summary>
	[Serializable]
	public class Ss_fold_prog
	{
		/// <summary>
		/// fold_id
		/// </summary>
		public string fold_id
		{
			get;
			set;
		}
		/// <summary>
		/// prog_id
		/// </summary>
		public string prog_id
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
		/// sort_no
		/// </summary>
		public int sort_no
		{
			get;
			set;
		}
	}
}