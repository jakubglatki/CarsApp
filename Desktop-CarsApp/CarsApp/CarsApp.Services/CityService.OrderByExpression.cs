using System.Linq;
using LGBS.MVPFramework.Services;
using CarsApp.Data;

namespace CarsApp.Services
{
	/// <summary>
	/// Klasa zawierająca rozszerzenia sortowania dla zapytań pobierających City.
	/// </summary>
	public static class CityServiceOrderByExpression
	{
		/// <summary>
		/// Sortowanie kolekcji typu City po nazwie kolumny i kierunku sortowania.
		/// </summary>
		/// <param name="source">Query.</param>
		/// <param name="columnName">Nazwa kolumny.</param>
		/// <param name="sortDirection">Kierunek sortowania.</param>
		/// <returns>Query z sortowaniem.</returns>
		public static IQueryable<City> SortBy(this IQueryable<City> source, string columnName, SortDirection sortDirection)
		{
			switch (columnName)
			{
				case "Id":
					return sortDirection == SortDirection.Ascending ? source.OrderBy(x => x.Id) : source.OrderByDescending(x => x.Id);
			}

			return source.OrderBy(x => x.Id);
		}
	}
}
