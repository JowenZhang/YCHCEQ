using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.EntityModel
{
	/// <summary>
	/// mes_ua_recv
	/// </summary>
	[Serializable]
	public class Mes_ua_recv
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
		/// trig_time
		/// </summary>
		public DateTime? trig_time
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
		/// operator_name
		/// </summary>
		public string operator_name
		{
			get;
			set;
		}
		/// <summary>
		/// order_no
		/// </summary>
		public string order_no
		{
			get;
			set;
		}
		/// <summary>
		/// batch_no
		/// </summary>
		public string batch_no
		{
			get;
			set;
		}
		/// <summary>
		/// steel_no
		/// </summary>
		public string steel_no
		{
			get;
			set;
		}
		/// <summary>
		/// steel_spec
		/// </summary>
		public string steel_spec
		{
			get;
			set;
		}
		/// <summary>
		/// steel_width
		/// </summary>
		public float? steel_width
		{
			get;
			set;
		}
		/// <summary>
		/// prod_order
		/// </summary>
		public string prod_order
		{
			get;
			set;
		}
		/// <summary>
		/// prod_brand
		/// </summary>
		public string prod_brand
		{
			get;
			set;
		}
		/// <summary>
		/// prod_spec
		/// </summary>
		public string prod_spec
		{
			get;
			set;
		}
		/// <summary>
		/// prod_batch
		/// </summary>
		public string prod_batch
		{
			get;
			set;
		}
		/// <summary>
		/// fill
		/// </summary>
		public float? fill
		{
			get;
			set;
		}
		/// <summary>
		/// steel_no_u
		/// </summary>
		public string steel_no_u
		{
			get;
			set;
		}
		/// <summary>
		/// steel_spec_u
		/// </summary>
		public string steel_spec_u
		{
			get;
			set;
		}
		/// <summary>
		/// p_weight
		/// </summary>
		public float? p_weight
		{
			get;
			set;
		}
		/// <summary>
		/// net_check
		/// </summary>
		public int? net_check
		{
			get;
			set;
		}
		/// <summary>
		/// material_check
		/// </summary>
		public int? material_check
		{
			get;
			set;
		}
		/// <summary>
		/// steel_check
		/// </summary>
		public int? steel_check
		{
			get;
			set;
		}
		/// <summary>
		/// process_check
		/// </summary>
		public int? process_check
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