using System;
using System.Collections.Generic;
using System.Linq;
using CarsApp.Data;
using CarsApp.Services;
using LGBS.MVPFramework.UI;

namespace CarsApp.UI
{

    /// <summary>
    /// Prezenter widoku ManufactureList.
    /// </summary>
    public class ManufactureListPresenter : BaseGenericPresenter<IManufactureList, INoDetailsView, ManufactureService>
    {
        #region Properties

        /// <summary>
        /// Kryteria wyszukiwania wykorzystywane przy pobieraniu danych.
        /// </summary>
        public ManufactureSearchCriteria SearchCriteria
        {
            get
            {
                if (BaseSearchCriteria == null)
                    BaseSearchCriteria = new ManufactureSearchCriteria();

                return BaseSearchCriteria as ManufactureSearchCriteria;
            }
            set
            {
                BaseSearchCriteria = value;
            }
        }

        #endregion Properties

        #region Ctors

        /// <summary>
        /// Tworzy presenter widoku ManufactureList.
        /// </summary>
        /// <param name="view">Obsługiwany widok.</param>
        public ManufactureListPresenter(IManufactureList view)
            : base(view, true)
        {
            Service.UseViewAsMainDataSource = true;
        }

        #endregion Ctors

        #region Protected methods

        #region Overrides

        /// <summary>
        /// Pobiera dane i wyświetla w widoku.
        /// </summary>
        /// <param name="type">Tryb odświeżania danych.</param>
        protected override void LoadData(RefreshDataType type)
        {
            switch (type)
            {
                case RefreshDataType.Full:
                    LoadData(RefreshDataType.DictionaryValues);
                    LoadData(RefreshDataType.ObjectListData);
                    break;
                case RefreshDataType.ObjectListData:
                    View.ManufactureCollection = Service.GetManufactureCollection();
                    break;
                case RefreshDataType.DictionaryValues:
                    break;
                default:
                    throw new RefreshTypeNotSupportedException();
            }
        }

        /// <summary>
        /// Ustawia kryteria wyszukiwania.
        /// </summary>
        protected override void SetSearchCriteria()
        {

            // wyczyszczenie wbudowanych filtrów
            View.ClearGridFilters();
        }

        #endregion Overrides

        #endregion Protected methods

        #region Public methods

        #region Overrides

        /// <summary>
        /// Czyści parametry wyszukiwania.
        /// </summary>
        public override void ClearSearchCriteria()
        {

            // wyczyszczenie wbudowanych filtrów
            View.ClearGridFilters();
        }

        #endregion Overrides

        #endregion Public methods
    }
}
