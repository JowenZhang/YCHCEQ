using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.EntityModel
{
	/// <summary>
	/// sql_languages
	/// </summary>
	[Serializable]
	public class Sql_languages
	{
		/// <summary>
		/// sql_language_source
		/// </summary>
		public string sql_language_source
		{
			get;
			set;
		}
		/// <summary>
		/// sql_language_year
		/// </summary>
		public string sql_language_year
		{
			get;
			set;
		}
		/// <summary>
		/// sql_language_conformance
		/// </summary>
		public string sql_language_conformance
		{
			get;
			set;
		}
		/// <summary>
		/// sql_language_integrity
		/// </summary>
		public string sql_language_integrity
		{
			get;
			set;
		}
		/// <summary>
		/// sql_language_implementation
		/// </summary>
		public string sql_language_implementation
		{
			get;
			set;
		}
		/// <summary>
		/// sql_language_binding_style
		/// </summary>
		public string sql_language_binding_style
		{
			get;
			set;
		}
		/// <summary>
		/// sql_language_programming_language
		/// </summary>
		public string sql_language_programming_language
		{
			get;
			set;
		}
	}
}