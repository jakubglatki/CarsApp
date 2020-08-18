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
    /// Kryteria wyszukiwania obiektów typu CarServicesCar.
    /// </summary>
    public class CarServicesCarSearchCriteria : SearchCriteria
    {
        #region Properties

        #endregion Properties

        #region Public methods

        /// <summary>
        /// Tworzy Expression na podstawie danych search criteria.
        /// </summary>
        /// <returns>Expression.</returns>
        public Expression<Func<CarServicesCar, bool>> GetFilterExpression()
        {
            Expression<Func<CarServicesCar, bool>> filter = PredicateBuilder.True<CarServicesCar>();


            return filter;
        }

        #endregion Public methods
    }
}
