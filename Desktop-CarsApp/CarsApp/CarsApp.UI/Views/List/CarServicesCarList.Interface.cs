using System;
using System.Collections.Generic;
using CarsApp.Data;
using LGBS.MVPFramework.UI;

namespace CarsApp.UI
{
    /// <summary>
    /// Interfejs widoku CarServicesCarList.
    /// </summary>
    public interface ICarServicesCarList : IBaseWindowView
    {
        #region Properties

        /// <summary>
        /// Aktualnie wyświetlana / edytowana encja.
        /// </summary>
        CarServicesCar CurrentCarServicesCar { get; set; }

        /// <summary>
        /// Aktualnie wyświetlana / edytowana encja.
        /// </summary>
        CarService CarService { get; set; }
        /// <summary>
        /// Lista encji.
        /// </summary>
        ICollection<CarServicesCar> CarServicesCarCollection { get; set; }

        /// <summary>
        /// Prezenter widoku.
        /// </summary>
        CarServicesCarListPresenter Presenter { get; }

        #region Filter	

        /// <summary>
        /// Filtr.
        /// </summary>
        ICarServicesCarListFilter Filter { get; }

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
