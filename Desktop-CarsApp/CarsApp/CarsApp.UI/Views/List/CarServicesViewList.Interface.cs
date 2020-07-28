using System;
using System.Collections.Generic;
using CarsApp.Data;
using LGBS.MVPFramework.UI;

namespace CarsApp.UI
{
    /// <summary>
    /// Interfejs widoku CarServicesViewList.
    /// </summary>
    public interface ICarServicesViewList : IBaseWindowView
    {
        #region Properties

        /// <summary>
        /// Aktualnie wyświetlana / edytowana encja.
        /// </summary>
        CarServicesView CurrentCarServicesView { get; set; }

        /// <summary>
        /// Lista encji.
        /// </summary>
        ICollection<CarServicesView> CarServicesViewCollection { get; set; }

        /// <summary>
        /// Prezenter widoku.
        /// </summary>
        CarServicesViewListPresenter Presenter { get; }

        #region Filter	

        /// <summary>
        /// Filtr.
        /// </summary>
        ICarServicesViewListFilter Filter { get; }

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
