using System;
using System.Collections.Generic;
using CarsApp.Data;
using LGBS.MVPFramework.UI;

namespace CarsApp.UI
{
    /// <summary>
    /// Interfejs widoku CarServiceList.
    /// </summary>
    public interface ICarServiceList : IBaseWindowView
    {
        #region Properties

        /// <summary>
        /// Aktualnie wyświetlana / edytowana encja.
        /// </summary>
        CarService CurrentCarService { get; set; }

        /// <summary>
        /// Aktualnie wyświetlana / edytowana encja.
        /// </summary>
        CarServicesView CurrentCarServicesView { get; set; }
        /// <summary>
        /// Lista encji.
        /// </summary>
        ICollection<CarService> CarServiceCollection { get; set; }

        /// <summary>
        /// Lista encji.
        /// </summary>
        ICollection<CarServicesView> CarServicesViewCollection { get; set; }
        /// <summary>
        /// Prezenter widoku.
        /// </summary>
        CarServiceListPresenter Presenter { get; }

        #region Filter	

        /// <summary>
        /// Filtr.
        /// </summary>
        ICarServiceListFilter Filter { get; }

        #endregion Filter

        #endregion Properties

        #region Methods

        /// <summary>
        /// Czyści wbudowane filtry grida.
        /// </summary>
        void ClearGridFilters();

        #endregion Methods
    }
}
