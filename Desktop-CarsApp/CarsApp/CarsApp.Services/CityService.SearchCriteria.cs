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
		/// Nazwa kraju
		/// </summary>
		public Country Country { get; set; }

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

			if (Country!=null)
				filter = filter.And(y => y.Country.Id.Equals(this.Country.Id));
			
			
            return filter;
		}

		#endregion Public methods
	}
}
