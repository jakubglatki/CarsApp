using CarsApp.Data;
using CarsApp.Services;
using LGBS.MVPFramework.UI;

namespace CarsApp.UI
{
	/// <summary>
	/// Prezenter widoku CountryList.
	/// </summary>
	public class CountryListPresenter : BaseGenericPresenter<ICountryList, ICountryDetails, CountryService>
	{
		#region Properties

		/// <summary>
		/// Kryteria wyszukiwania wykorzystywane przy pobieraniu danych.
		/// </summary>
		public CountrySearchCriteria SearchCriteria
		{
			get
			{
				if (BaseSearchCriteria == null)
					BaseSearchCriteria = new CountrySearchCriteria();

				return BaseSearchCriteria as CountrySearchCriteria;
			}
			set
			{
				BaseSearchCriteria = value;
			}
		}

		#endregion Properties

		#region Ctors

		/// <summary>
		/// Tworzy presenter widoku CountryList.
		/// </summary>
		/// <param name="view">Obsługiwany widok.</param>
		public CountryListPresenter(ICountryList view)
			: base(view, true)
		{
			// ustawienie widoku jako źródło danych dla widoku typu lista
			Service.UseViewAsMainDataSource = false;
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
					View.CountryCollection = Service.GetCountryCollection(View.PageIndex, View.PageSize, SearchCriteria, out allElementCount);
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
			SearchCriteria.Code = View.Filter.FilterCode;

			// wyczyszczenie wbudowanych filtrów
			View.ClearGridFilters();
		}



		public void ShowSubElements()
		{
			ICityList view = CarsViewFactory.Factory.CreateViewInstance<ICityList>(View);
			view.Show(ViewMode.ReadOnly);
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
			View.Filter.FilterCode = string.Empty;

			// wyczyszczenie wbudowanych filtrów
			View.ClearGridFilters();
		}


		#endregion Overrides

		#endregion Public methods
	}
}
