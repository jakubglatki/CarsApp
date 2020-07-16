using System;
using LGBS.MVPFramework.UI;

namespace CarsApp.UI
{
	public partial class MainForm
	{
		#region Main contextual tab

		#region Zarządzanie

		#region Akcje

		/// <summary>
		/// Obsługa naciśnięcia btn Dodaj.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">EventArgs.</param>
		private void addButtonElement_Click(object sender, EventArgs e)
		{
			if (CurrentView != null && CurrentView is BaseListWindow)
			{
				CurrentView.AddNew();
			}
		}

		/// <summary>
		/// Obsługa naciśnięcia btn Usuń.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">EventArgs.</param>
		private void deleteButtonElement_Click(object sender, EventArgs e)
		{
			if (CurrentView != null && CurrentView is BaseListWindow)
			{
				CurrentView.Delete();
			}
		}

		/// <summary>
		/// Obsługa naciśnięcia btn Edytuj.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">EventArgs.</param>
		private void editButtonElement_Click(object sender, EventArgs e)
		{
			if (CurrentView != null && CurrentView is BaseListWindow)
			{
				CurrentView.Edit();
			}
		}

		/// <summary>
		/// Obsługa naciśnięcia btn Wyświetl.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">EventArgs.</param>
		private void showDetailsButtonElement_Click(object sender, EventArgs e)
		{
			if (CurrentView != null && CurrentView is BaseListWindow)
			{
               
				CurrentView.ShowDetails();
			}
		}

		#endregion Akcje

		#region Wyszukiwanie

		/// <summary>
		/// Obsługa naciśnięcia btn Szukaj.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">EventArgs.</param>
		private void searchButtonElement_Click(object sender, EventArgs e)
		{
			if (CurrentView != null && CurrentView is BaseListWindow)
			{
				CurrentView.BasePresenter.Search();
			}
		}

		/// <summary>
		/// Obsługa naciśnięcia btn Wyczyść.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">EventArgs.</param>
		private void clearFilterButtonElement_Click(object sender, EventArgs e)
		{
			if (CurrentView != null && CurrentView is BaseListWindow)
			{
				CurrentView.BasePresenter.ClearSearchCriteria();
			}
		}

		#endregion Wyszukiwanie

		#endregion Zarządzanie

		#endregion Main contextual tab

		#region Okna

		/// <summary>
		/// Obsługa wyświetlania listy krajów.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">EventArgs.</param>
		private void countriesButtonElement_Click(object sender, EventArgs e)
		{
			ICountryList view = CarsViewFactory.Factory.CreateViewInstance<ICountryList>();
			view.Show(ViewMode.ReadOnly);
		}

		/// <summary>
		/// Obsługa wyświetlania listy miast.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">EventArgs.</param>
		private void citiesButtonElement_Click(object sender, EventArgs e)
		{
			ICityList view = CarsViewFactory.Factory.CreateViewInstance<ICityList>();
			view.Show(ViewMode.ReadOnly);
		}

		#endregion Okna
	}
}
