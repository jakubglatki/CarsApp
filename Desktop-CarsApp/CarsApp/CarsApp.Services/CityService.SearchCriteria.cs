using System;
using System.Linq.Expressions;
using LGBS.MVPFramework.Services;
using LinqKit;
using CarsApp.Data;

namespace CarsApp.Services
{
	/// <summary>
	/// Kryteria wyszukiwania obiektów typu City.
	/// </summary>
	public class CitySearchCriteria : SearchCriteria
	{
		#region Properties

		/// <summary>
		/// Nazwa.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Kod.
		/// </summary>
		public string CountryName { get; set; }

		#endregion Properties

		#region Public methods

		/// <summary>
		/// Tworzy Expression na podstawie danych search criteria.
		/// </summary>
		/// <returns>Expression.</returns>
		public Expression<Func<City, bool>> GetFilterExpression()
		{
			Expression<Func<City, bool>> filter = PredicateBuilder.True<City>();

			if (!string.IsNullOrEmpty(Name))
				filter = filter.And(x => x.Name.Contains(this.Name));

			//if (!string.IsNullOrEmpty(CountryName))
			//	filter = filter.And(x => x.CountryId.Contains(this.CountryId));

			return filter;
		}

		#endregion Public methods
	}
}
