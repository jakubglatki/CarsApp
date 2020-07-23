using System;
using System.Collections.Generic;
using System.Linq;
using CarsApp.Data;
using CarsApp.Services;
using LGBS.MVPFramework.UI;

namespace CarsApp.UI
{
    // TODO [UITemplate] - optional: Zweryfikować
    // jeśli z widokiem typu lista jest powiązany widok typu details, 
    // wówczas prezeter musi implementować interfejs ICarProductDetails zamiast INoDetailsView

    /// <summary>
    /// Prezenter widoku CarProductList.
    /// </summary>
    public class CarProductListPresenter : BaseGenericPresenter<ICarProductList, INoDetailsView, CarProductService>
    {
        #region Properties

        /// <summary>
        /// Kryteria wyszukiwania wykorzystywane przy pobieraniu danych.
        /// </summary>
        public CarProductSearchCriteria SearchCriteria
        {
            get
            {
                if (BaseSearchCriteria == null)
                    BaseSearchCriteria = new CarProductSearchCriteria();

                return BaseSearchCriteria as CarProductSearchCriteria;
            }
            set
            {
                BaseSearchCriteria = value;
            }
        }

        #endregion Properties

        #region Ctors

        /// <summary>
        /// Tworzy presenter widoku CarProductList.
        /// </summary>
        /// <param name="view">Obsługiwany widok.</param>
        public CarProductListPresenter(ICarProductList view)
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
                    View.CarModelCollection = Service.GetCarModelCollection();
                    View.FactoryCollection = Service.GetFactoryCollection();
                    View.CarProductCollection = Service.GetCarProductCollection(View.PageIndex, View.PageSize, SearchCriteria, out allElementCount);
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
            SearchCriteria.Model = View.Filter.FilterModel;
            SearchCriteria.VIN = View.Filter.FilterVIN;
            SearchCriteria.Factory = View.Filter.FilterFactory;
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
            SearchCriteria.Model = null;
            SearchCriteria.VIN = string.Empty;
            SearchCriteria.Model = null;
            // wyczyszczenie wbudowanych filtrów
            View.ClearGridFilters();
        }

        #endregion Overrides

        #endregion Public methods
    }
}
