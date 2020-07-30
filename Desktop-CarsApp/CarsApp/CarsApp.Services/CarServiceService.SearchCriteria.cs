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
    /// Kryteria wyszukiwania obiektów typu CarService.
    /// </summary>
    public class CarServiceSearchCriteria : SearchCriteria
    {
        #region Properties

        #endregion Properties

        #region Public methods

        /// <summary>
        /// Tworzy Expression na podstawie danych search criteria.
        /// </summary>
        /// <returns>Expression.</returns>
        public Expression<Func<CarService, bool>> GetFilterExpression()
        {
            Expression<Func<CarService, bool>> filter = PredicateBuilder.True<CarService>();

            // TODO [ServiceTemplate] - optional: SearchCriteria (dodać składowe wyrażenia filtrującego)
            //if (!string.IsNullOrEmpty(PropertyName))
            //    filter = filter.And(x => x.PropertyName.Contains(this.PropertyName));

            return filter;
        }


        /// <summary>
        /// Tworzy Expression na podstawie danych search criteria.
        /// </summary>
        /// <returns>Expression.</returns>
        public Expression<Func<HandledCarProduct, bool>> GetFilterExpressionForHandledCarProduct(CarService carService)
        {
            Expression<Func<HandledCarProduct, bool>> filter = PredicateBuilder.True<HandledCarProduct>();

            // TODO [ServiceTemplate] - optional: SearchCriteria (dodać składowe wyrażenia filtrującego)
                filter = filter.And(x => x.CarServiceId.Equals(carService.Id));

            return filter;
        }
        #endregion Public methods
    }
}
