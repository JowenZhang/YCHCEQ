using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.EntityModel
{
	/// <summary>
	/// proc_temp
	/// </summary>
	[Serializable]
	public class Proc_temp
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
		/// values
		/// </summary>
		public string values
		{
			get;
			set;
		}
	}
}