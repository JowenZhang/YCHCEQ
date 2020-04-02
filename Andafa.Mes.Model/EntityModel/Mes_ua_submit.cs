using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.EntityModel
{
	/// <summary>
	/// mes_ua_submit
	/// </summary>
	[Serializable]
	public class Mes_ua_submit
	{
		/// <summary>
		/// id
		/// </summary>
		public int id
		{
			get;
			set;
		}
		/// <summary>
		/// ws_no
		/// </summary>
		public string ws_no
		{
			get;
			set;
		}
		/// <summary>
		/// sub_time
		/// </summary>
		public DateTime? sub_time
		{
			get;
			set;
		}
		/// <summary>
		/// m_id
		/// </summary>
		public string m_id
		{
			get;
			set;
		}
		/// <summary>
		/// p_id
		/// </summary>
		public string p_id
		{
			get;
			set;
		}
		/// <summary>
		/// prod_id
		/// </summary>
		public string prod_id
		{
			get;
			set;
		}
		/// <summary>
		/// prod_weight
		/// </summary>
		public float? prod_weight
		{
			get;
			set;
		}
		/// <summary>
		/// fingerprint
		/// </summary>
		public string fingerprint
		{
			get;
			set;
		}
	}
}