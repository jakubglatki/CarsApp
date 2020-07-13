using System.Linq;
using LGBS.MVPFramework.Services;
using CarsApp.Data;

namespace CarsApp.Services
{
	/// <summary>
	/// Klasa zawierająca rozszerzenia sortowania dla zapytań pobierających Country.
	/// </summary>
	public static class CountryServiceOrderByExpression
	{
		/// <summary>
		/// Sortowanie kolekcji typu Country po nazwie kolumny i kierunku sortowania.
		/// </summary>
		/// <param name="source">Query.</param>
		/// <param name="columnName">Nazwa kolumny.</param>
		/// <param name="sortDirection">Kierunek sortowania.</param>
		/// <returns>Query z sortowaniem.</returns>
		public static IQueryable<Country> SortBy(this IQueryable<Country> source, string columnName, SortDirection sortDirection)
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
