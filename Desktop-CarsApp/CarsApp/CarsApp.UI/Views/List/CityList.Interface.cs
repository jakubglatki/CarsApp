using System.Collections.Generic;
using CarsApp.Data;
using LGBS.MVPFramework.UI;

namespace CarsApp.UI
{
	/// <summary>
	/// Interfejs widoku CityList.
	/// </summary>
	public interface ICityList : IBaseWindowView
	{
		#region Properties

		/// <summary>
		/// Aktualnie wyświetlana / edytowana encja.
		/// </summary>
		City CurrentCity { get; set; }

		/// <summary>
		/// Lista encji.
		/// </summary>
		ICollection<City> CityCollection { get; set; }

		/// <summary>
		/// Lista encji.
		/// </summary>
		ICollection<Country> CountryCollection { get; set; }
		/// <summary>
		/// Prezenter widoku.
		/// </summary>
		CityListPresenter Presenter { get; }

		#region Filter

		/// <summary>
		/// Filtr.
		/// </summary>
		ICityListFilter Filter { get; }

		#endregion Filter

		#region Paging

		/// <summary>
		/// Numer bieżącej strony.
		/// </summary>
		int PageNumber { get; }

		/// <summary>
		/// Indeks bieżącej strony.
		/// </summary>
		int PageIndex { get; }

		/// <summary>
		/// Ilość elementów wyświetlanych na stronie.
		/// </summary>
		int PageSize { get; set; }

		/// <summary>
		/// Ilość wszystkich elementów do wyświetlenia.
		/// </summary>
		int RowsCount { get; set; }

		#endregion Paging

		#endregion Properties

		#region Methods

		/// <summary>
		/// Czyści wbudowane filtry grida.
		/// </summary>
		void ClearGridFilters();

		#endregion Methods
	}
}
