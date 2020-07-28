using System;
using System.Linq;
using LGBS.MVPFramework.Services;
using CarsApp.Data;

namespace CarsApp.Services
{
    /// <summary>
    /// Klasa zawierająca rozszerzenia sortowania dla zapytań pobierających CarServicesView.
    /// </summary>
    public static class CarServicesViewServiceOrderByExpression
    {
        /// <summary>
        /// Sortowanie kolekcji typu CarServicesView po nazwie kolumny i kierunku sortowania.
        /// </summary>
        /// <param name="source">Query.</param>
        /// <param name="columnName">Nazwa kolumny.</param>
        /// <param name="sortDirection">Kierunek sortowania.</param>
        /// <returns>Query z sortowaniem.</returns>
        public static IQueryable<CarServicesView> SortBy(this IQueryable<CarServicesView> source, string columnName, SortDirection sortDirection)
        {
            switch (columnName)
            {
                case "Id":
                    return sortDirection == SortDirection.Ascending ? source.OrderBy(x => x.Id) : source.OrderByDescending(x => x.Id);

                    // TODO [ServiceTemplate] - optional: Sortowanie (określić kolejne warunki)
            }

            return source.OrderBy(x => x.Id);
        }
    }
}
