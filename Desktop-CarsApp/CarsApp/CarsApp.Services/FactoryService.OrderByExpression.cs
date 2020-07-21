using System.Linq;
using LGBS.MVPFramework.Services;
using CarsApp.Data;

namespace CarsApp.Services
{
	/// <summary>
	/// Klasa zawierająca rozszerzenia sortowania dla zapytań pobierających Factory.
	/// </summary>
	public static class FactoryServiceOrderByExpression
	{
		/// <summary>
		/// Sortowanie kolekcji typu Factory po nazwie kolumny i kierunku sortowania.
		/// </summary>
		/// <param name="source">Query.</param>
		/// <param name="columnName">Nazwa kolumny.</param>
		/// <param name="sortDirection">Kierunek sortowania.</param>
		/// <returns>Query z sortowaniem.</returns>
		public static IQueryable<Factory> SortBy(this IQueryable<Factory> source, string columnName, SortDirection sortDirection)
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
