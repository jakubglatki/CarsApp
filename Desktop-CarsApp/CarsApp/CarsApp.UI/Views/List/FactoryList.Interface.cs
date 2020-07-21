﻿using System.Collections.Generic;
using CarsApp.Data;
using LGBS.MVPFramework.UI;

namespace CarsApp.UI
{
	/// <summary>
	/// Interfejs widoku FactoryList.
	/// </summary>
	public interface IFactoryList : IBaseWindowView
	{
		#region Properties

		/// <summary>
		/// Aktualnie wyświetlana / edytowana encja.
		/// </summary>
		Factory CurrentFactory { get; set; }

		/// <summary>
		/// Lista encji.
		/// </summary>
		ICollection<Factory> FactoryCollection { get; set; }

		/// <summary>
		/// Prezenter widoku.
		/// </summary>
		FactoryListPresenter Presenter { get; }

		#region Filter

		/// <summary>
		/// Filtr.
		/// </summary>
		IFactoryListFilter Filter { get; }

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
