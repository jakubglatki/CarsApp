using System;
using System.Linq.Expressions;
using LGBS.MVPFramework.Services;
using LinqKit;
using CarsApp.Data;

namespace CarsApp.Services
{
	/// <summary>
	/// Kryteria wyszukiwania obiektów typu Country.
	/// </summary>
	public class CountrySearchCriteria : SearchCriteria
	{
		#region Properties

		/// <summary>
		/// Nazwa.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Kod.
		/// </summary>
		public string Code { get; set; }	

		#endregion Properties

		#region Public methods

		/// <summary>
		/// Tworzy Expression na podstawie danych search criteria.
		/// </summary>
		/// <returns>Expression.</returns>
		public Expression<Func<Country, bool>> GetFilterExpression()
		{
			Expression<Func<Country, bool>> filter = PredicateBuilder.True<Country>();

			if (!string.IsNullOrEmpty(Name))
				filter = filter.And(x => x.Name.Contains(this.Name));

            if (!string.IsNullOrEmpty(Code))
                filter = filter.And(x => x.Code.Contains(this.Code));

            return filter;
		}

		#endregion Public methods
	}
}
