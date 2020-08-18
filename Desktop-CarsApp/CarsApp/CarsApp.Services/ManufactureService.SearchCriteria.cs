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
    /// Kryteria wyszukiwania obiektów typu Manufacture.
    /// </summary>
    public class ManufactureSearchCriteria : SearchCriteria
    {
        #region Properties

        #endregion Properties

        #region Public methods

        /// <summary>
        /// Tworzy Expression na podstawie danych search criteria.
        /// </summary>
        /// <returns>Expression.</returns>
        public Expression<Func<Manufacture, bool>> GetFilterExpression()
        {
            Expression<Func<Manufacture, bool>> filter = PredicateBuilder.True<Manufacture>();


            return filter;
        }

        #endregion Public methods
    }
}
