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

        #endregion Properties

        #region Public methods

        /// <summary>
        /// Tworzy Expression na podstawie danych search criteria.
        /// </summary>
        /// <returns>Expression.</returns>
        public Expression<Func<Factory, bool>> GetFilterExpression()
        {
            Expression<Func<Factory, bool>> filter = PredicateBuilder.True<Factory>();

            // TODO [ServiceTemplate] - optional: SearchCriteria (dodać składowe wyrażenia filtrującego)
            //if (!string.IsNullOrEmpty(PropertyName))
            //    filter = filter.And(x => x.PropertyName.Contains(this.PropertyName));

            return filter;
        }

        #endregion Public methods
    }
}
