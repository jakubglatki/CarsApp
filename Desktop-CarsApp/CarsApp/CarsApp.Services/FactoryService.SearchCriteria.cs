using System;
using System.Linq.Expressions;
using LGBS.MVPFramework.Services;
using LinqKit;
using CarsApp.Data;

namespace CarsApp.Services
{
	/// <summary>
	/// Kryteria wyszukiwania obiektów typu Factory.
	/// </summary>
	public class FactorySearchCriteria : SearchCriteria
	{
		#region Properties

		/// <summary>
		/// Nazwa.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Kod.
		/// </summary>
		public string CityName { get; set; }

		#endregion Properties

		#region Public methods

		/// <summary>
		/// Tworzy Expression na podstawie danych search criteria.
		/// </summary>
		/// <returns>Expression.</returns>
		public Expression<Func<Factory, bool>> GetFilterExpression()
		{
			Expression<Func<Factory, bool>> filter = PredicateBuilder.True<Factory>();

			if (!string.IsNullOrEmpty(Name))
				filter = filter.And(x => x.Name.Contains(this.Name));

			if (!string.IsNullOrEmpty(CityName))
				filter = filter.And(x => x.City.Name.Contains(this.CityName));

			return filter;
		}

		#endregion Public methods
	}
}
