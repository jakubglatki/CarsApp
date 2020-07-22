using CarsApp.Data;
using CarsApp.Services;
using LGBS.MVPFramework.UI;

namespace CarsApp.UI
{
	/// <summary>
	/// Prezenter widoku CityList.
	/// </summary>
	public class CityListPresenter : BaseGenericPresenter<ICityList, ICityDetails, CityService>
	{
		#region Properties

		/// <summary>
		/// Kryteria wyszukiwania wykorzystywane przy pobieraniu danych.
		/// </summary>
		public CitySearchCriteria SearchCriteria
		{
			get
			{
				if (BaseSearchCriteria == null)
					BaseSearchCriteria = new CitySearchCriteria();

				return BaseSearchCriteria as CitySearchCriteria;
			}
			set
			{
				BaseSearchCriteria = value;
			}
		}

		public CountrySearchCriteria CountrySearchCriteria
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
		/// Tworzy presenter widoku CityList.
		/// </summary>
		/// <param name="view">Obsługiwany widok.</param>
		public CityListPresenter(ICityList view)
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
					View.CountryCollection = Service.GetAllCountries();
					View.CityCollection = Service.GetCityCollection(View.PageIndex, View.PageSize, SearchCriteria, out allElementCount);
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
			SearchCriteria.CountryName = View.Filter.FilterCountryName;
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
			View.Filter.FilterCountryName = null;
			
			// wyczyszczenie wbudowanych filtrów
			View.ClearGridFilters();
		}

		#endregion Overrides

		#endregion Public methods
	}
}
