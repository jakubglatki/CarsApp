using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
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
        /// Nazwa miasta.
        /// </summary>
        public string CityName { get; set; }


        /// <summary>
        /// Nazwa produkcji.
        /// </summary>
        public string ManufactureName { get; set; }
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

            if (!string.IsNullOrEmpty(ManufactureName))
                filter = filter.And(x => x.Manufacture.Name.Contains(this.ManufactureName));
            return filter;
        }

        #endregion Public methods
    }
}
