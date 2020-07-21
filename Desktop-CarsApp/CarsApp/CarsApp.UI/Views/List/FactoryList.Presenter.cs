using CarsApp.Data;
using CarsApp.Services;
using LGBS.MVPFramework.UI;

namespace CarsApp.UI
{
	/// <summary>
	/// Prezenter widoku FactoryList.
	/// </summary>
	public class FactoryListPresenter : BaseGenericPresenter<IFactoryList, IFactoryDetails, FactoryService>
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
			SearchCriteria.CityName = View.Filter.FilterCity;

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
			View.Filter.FilterCity = string.Empty;

			// wyczyszczenie wbudowanych filtrów
			View.ClearGridFilters();
		}


		#endregion Overrides

		#endregion Public methods
	}
}
