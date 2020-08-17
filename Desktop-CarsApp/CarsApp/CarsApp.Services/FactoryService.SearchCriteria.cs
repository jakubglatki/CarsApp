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
        /// Miasto.
        /// </summary>
        public City City{ get; set; }




        /// <summary>
        /// Produkcja.
        /// </summary>
        public Manufacture Manufacture { get; set; }

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

            if (this.City!=null)
                filter = filter.And(x => x.City.Id.Equals(this.City.Id));


            if (this.Manufacture!=null)
                filter = filter.And(x => x.Manufacture.Id.Equals(this.Manufacture.Id));

            return filter;
        }

        #endregion Public methods
    }
}
