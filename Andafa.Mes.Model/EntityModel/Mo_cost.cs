using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.EntityModel
{
	/// <summary>
	/// mo_cost
	/// </summary>
	[Serializable]
	public class Mo_cost
	{
		/// <summary>
		/// mo_no
		/// </summary>
		public string mo_no
		{
			get;
			set;
		}
		/// <summary>
		/// unit_price_standard
		/// </summary>
		public decimal? unit_price_standard
		{
			get;
			set;
		}
		/// <summary>
		/// unit_price_average
		/// </summary>
		public decimal? unit_price_average
		{
			get;
			set;
		}
		/// <summary>
		/// unit_price_manual
		/// </summary>
		public decimal? unit_price_manual
		{
			get;
			set;
		}
		/// <summary>
		/// unit_material_price
		/// </summary>
		public decimal? unit_material_price
		{
			get;
			set;
		}
		/// <summary>
		/// unit_sale_price
		/// </summary>
		public decimal? unit_sale_price
		{
			get;
			set;
		}
		/// <summary>
		/// unit_manpower_cost
		/// </summary>
		public decimal? unit_manpower_cost
		{
			get;
			set;
		}
		/// <summary>
		/// wkc_unitcost_machine
		/// </summary>
		public decimal? wkc_unitcost_machine
		{
			get;
			set;
		}
		/// <summary>
		/// manpower_cost
		/// </summary>
		public decimal? manpower_cost
		{
			get;
			set;
		}
		/// <summary>
		/// wkc_unitcost_manpower
		/// </summary>
		public decimal? wkc_unitcost_manpower
		{
			get;
			set;
		}
		/// <summary>
		/// mo_real_cost
		/// </summary>
		public decimal? mo_real_cost
		{
			get;
			set;
		}
		/// <summary>
		/// mo_mtr_real_cost
		/// </summary>
		public decimal? mo_mtr_real_cost
		{
			get;
			set;
		}
		/// <summary>
		/// mo_worker_real_cost
		/// </summary>
		public decimal? mo_worker_real_cost
		{
			get;
			set;
		}
		/// <summary>
		/// mo_wkc_real_cost
		/// </summary>
		public decimal? mo_wkc_real_cost
		{
			get;
			set;
		}
		/// <summary>
		/// mo_tools_real_cost
		/// </summary>
		public decimal? mo_tools_real_cost
		{
			get;
			set;
		}
	}
}