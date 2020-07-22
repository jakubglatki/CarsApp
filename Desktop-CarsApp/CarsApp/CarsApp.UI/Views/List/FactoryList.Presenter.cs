﻿using System;
using System.Collections.Generic;
using System.Linq;
using CarsApp.Data;
using CarsApp.Services;
using LGBS.MVPFramework.UI;

namespace CarsApp.UI
{
    // TODO [UITemplate] - optional: Zweryfikować
    // jeśli z widokiem typu lista jest powiązany widok typu details, 
    // wówczas prezeter musi implementować interfejs IFactoryDetails zamiast INoDetailsView

    /// <summary>
    /// Prezenter widoku FactoryList.
    /// </summary>
    public class FactoryListPresenter : BaseGenericPresenter<IFactoryList, INoDetailsView, FactoryService>
    {
        #region Properties

        /// <summary>
        /// Kryteria wyszukiwania wykorzystywane przy pobieraniu danych.
        /// </summary>
        public FactorySearchCriteria SearchCriteria
        {
            get
            {
                if (BaseSearchCriteria == null)
                    BaseSearchCriteria = new FactorySearchCriteria();

                return BaseSearchCriteria as FactorySearchCriteria;
            }
            set
            {
                BaseSearchCriteria = value;
            }
        }

        #endregion Properties

        #region Ctors

        /// <summary>
        /// Tworzy presenter widoku FactoryList.
        /// </summary>
        /// <param name="view">Obsługiwany widok.</param>
        public FactoryListPresenter(IFactoryList view)
            : base(view, true)
        {
            // TODO [UITemplate] - optional: Zweryfikować
            // ustawienie widoku jako źródło danych dla widoku typu lista
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
                    int allElementCount;
                    View.CityCollection = Service.GetCityCollection();
                    View.FactoryCollection = Service.GetFactoryCollection(View.PageIndex, View.PageSize, SearchCriteria, out allElementCount);
                    View.RowsCount = allElementCount;
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
            SearchCriteria.Name = View.Filter.FilterName;
            SearchCriteria.CityName = View.Filter.FilterCityName;
            SearchCriteria.ManufactureName = View.Filter.FilterManufactureName;

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
            View.Filter.FilterName = string.Empty;
            View.Filter.FilterCityName = null;
            View.Filter.FilterManufactureName = string.Empty;

            // wyczyszczenie wbudowanych filtrów
            View.ClearGridFilters();
        }

        #endregion Overrides

        #endregion Public methods
    }
}
