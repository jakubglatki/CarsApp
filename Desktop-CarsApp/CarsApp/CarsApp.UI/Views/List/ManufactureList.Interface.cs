using System;
using System.Collections.Generic;
using CarsApp.Data;
using LGBS.MVPFramework.UI;

namespace CarsApp.UI
{
    /// <summary>
    /// Interfejs widoku ManufactureList.
    /// </summary>
    public interface IManufactureList : IBaseWindowView
    {
        #region Properties

        /// <summary>
        /// Aktualnie wyświetlana / edytowana encja.
        /// </summary>
        Manufacture CurrentManufacture { get; set; }

        /// <summary>
        /// Lista encji.
        /// </summary>
        ICollection<Manufacture> ManufactureCollection { get; set; }

        /// <summary>
        /// Prezenter widoku.
        /// </summary>
        ManufactureListPresenter Presenter { get; }

        #region Filter	

        /// <summary>
        /// Filtr.
        /// </summary>
        IManufactureListFilter Filter { get; }

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
