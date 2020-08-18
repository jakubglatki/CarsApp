using System;
using System.Linq;
using LGBS.MVPFramework.Services;
using CarsApp.Data;

namespace CarsApp.Services
{
    /// <summary>
    /// Klasa zawierająca rozszerzenia sortowania dla zapytań pobierających Manufacture.
    /// </summary>
    public static class ManufactureServiceOrderByExpression
    {
        /// <summary>
        /// Sortowanie kolekcji typu Manufacture po nazwie kolumny i kierunku sortowania.
        /// </summary>
        /// <param name="source">Query.</param>
        /// <param name="columnName">Nazwa kolumny.</param>
        /// <param name="sortDirection">Kierunek sortowania.</param>
        /// <returns>Query z sortowaniem.</returns>
        public static IQueryable<Manufacture> SortBy(this IQueryable<Manufacture> source, string columnName, SortDirection sortDirection)
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
