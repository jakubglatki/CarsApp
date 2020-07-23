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
    /// Kryteria wyszukiwania obiektów typu CarProduct.
    /// </summary>
    public class CarProductSearchCriteria : SearchCriteria
    {
        #region Properties

        /// <summary>
        /// Nazwa modelu.
        /// </summary>
        public string Model { get; set; }

        /// <summary>
        /// Numer VIN.
        /// </summary>
        public string VIN { get; set; }


        /// <summary>
        /// Nazwa fabryki.
        /// </summary>
        public string Factory { get; set; }

        #endregion Properties

        #region Public methods

        /// <summary>
        /// Tworzy Expression na podstawie danych search criteria.
        /// </summary>
        /// <returns>Expression.</returns>
        public Expression<Func<CarProduct, bool>> GetFilterExpression()
        {
            Expression<Func<CarProduct, bool>> filter = PredicateBuilder.True<CarProduct>();

            if (!string.IsNullOrEmpty(Model))
                filter = filter.And(x => x.CarModel.Name.Contains(this.Model));

            if (!string.IsNullOrEmpty(VIN))
                filter = filter.And(x => x.VIN.Contains(this.VIN));

            if (!string.IsNullOrEmpty(Factory))
                filter = filter.And(x => x.Factory.Name.Contains(this.Factory));

            return filter;
        }

        #endregion Public methods
    }
}
