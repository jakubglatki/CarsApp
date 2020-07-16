using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CarsApp.Common.Utils;
using CarsApp.Data;
using CarsApp.UI.Properties;
using LGBS.MVPFramework.Controls;
using LGBS.MVPFramework.Data;
using LGBS.MVPFramework.UI;
using Telerik.WinControls.UI;

namespace CarsApp.UI
{
	/// <summary>
	/// Widok lista obiektów typu Country.
	/// </summary>
	public partial class CountryList : BaseListWindow, ICountryList, ICountryListFilter
	{
		#region Consts

		/// <summary>
		/// Nazwa interfejsu widoku.
		/// </summary>
		public const string InterfaceName = "ICountryList";
		#endregion Consts

		#region Properties

		#region Common Properties

		/// <summary>
		/// Bieżący obiekt wybrany na liście w widoku.
		/// </summary>
		public override IObjectWithId CurrentObject
		{
			get { return this.CurrentCountry; }
		}

		/// <summary>
		/// Prezenter widoku.
		/// </summary>
		public CountryListPresenter Presenter
		{
			get { return BasePresenter as CountryListPresenter; }
			set { BasePresenter = value; }
		}

		#endregion Common Properties

		#region View specific

		/// <summary>
		/// Bieżący obiekt wybrany na liście w poprzednim widoku.
		/// </summary>
		public Country CurrentCountry
		{
			get
			{
				return CountryCollectionBindingSource.Current as Country;
			}
			set
			{
				throw new InvalidOperationException();
			}
		}


		/// <summary>
		/// Lista obiektów wyświetlanych w widoku.
		/// </summary>
		public ICollection<Country> CountryCollection
		{
			get { return CountryCollectionBindingSource.DataSource as ICollection<Country>; }
			set
			{
				CountryCollectionBindingSource.DataSource = value;

				if (value != null)
					SetFilteredElementsCountLabel(value.Count);
			}
		}

		#region SearchCriteria

		/// <summary>
		/// Nazwa.
		/// </summary>
		public string FilterName
		{
			get { return nameTextBox.Text; }
			set { nameTextBox.Text = value; }
		}

        /// <summary>
        /// Kod.
        /// </summary>
        public string FilterCode
        {
            get { return codeTextBox.Text; }
            set { codeTextBox.Text = value; }
        }

        /// <summary>
        /// Filtr (kryteria wyszukiwania).
        /// </summary>
        public ICountryListFilter Filter
		{
			get { return this as ICountryListFilter; }
		}

		#endregion SearchCriteria

		#region Paging

		/// <summary>
		/// Numer bieżącej strony.
		/// </summary>
		public int PageNumber
		{
			get { return mainDataPager.PageNumber; }
		}

		/// <summary>
		/// Indeks bieżącej strony.
		/// </summary>
		public int PageIndex
		{
			get { return mainDataPager.PageNumber - 1; }
		}

		/// <summary>
		/// Ilość elementów wyświetlanych na stronie.
		/// </summary>
		public int PageSize
		{
			get { return mainDataPager.PageSize; }
			set { mainDataPager.PageSize = value; }
		}

		/// <summary>
		/// Ilość wszystkich elementów do wyświetlenia.
		/// </summary>
		public int RowsCount
		{
			get { return mainDataPager.RowsCount; }
			set { mainDataPager.RowsCount = value; }
		}

		#endregion Paging

		#endregion View specific

		#endregion Properties

		#region Ctors

		/// <summary>
		/// Tworzy widok CountryList.
		/// </summary>
		public CountryList()
			: base(null)
		{
            SupportsShowSubElements = false;

        }

        /// <summary>
        /// Tworzy widok CountryList.
        /// </summary>
        /// <param name="parentView">Widok nadrzędny.</param>
        public CountryList(IBaseView parentView)
			: base(parentView)
		{
			InitializeComponent();
			AfterInitializeComponent();
            SupportsShowSubElements = false;

            if (!VSDesignMode)
			{
				this.Presenter = new CountryListPresenter(this);

				this.SupportsShowDetails = true;
				this.SupportsDelete = true;
				this.SupportsAddNew = true;
				this.SupportsEdit = true;
			}
		}

		#endregion Ctors

		#region Public methods

		#region Overrides

		/// <summary>
		/// Zwraca nazwę interfejsu widoku.
		/// </summary>
		/// <returns>Nazwa interfejsu widoku.</returns>
		public override string GetInterfaceName()
		{
			return InterfaceName;
		}

		/// <summary>
		/// Odświeża widok.
		/// </summary>
		/// <param name="type">Typ odświeżenia.</param>
		public override void RefreshView(RefreshViewType type)
		{
			switch (type)
			{
				case RefreshViewType.AllObjectsView:
				case RefreshViewType.CurrentObjectView:
					CountryCollectionBindingSource.ResetBindings(false);
					break;
				case RefreshViewType.ViewOnly:
					break;
			}
		}

		/// <summary>
		/// Umożliwia usuwanie elementu. 
		/// </summary>
		public override void Delete()
		{
			if (CurrentObject != null)
			{
				base.Delete();
			}
		}

		/// <summary>
		/// Zmiana trybu widoku.
		/// </summary>
		/// <param name="mode">Tryb widoku.</param>
		public override void ChangeMode(ViewMode mode)
		{
			switch (mode)
			{
				case ViewMode.New:
					break;
				case ViewMode.Edit:
					break;
				case ViewMode.ReadOnly:
					this.Text = Resources.CaptionCountryList;
					break;
				case ViewMode.Dictionary:
					break;
				default:
					break;
			}

			base.ChangeMode(mode);
		}
		
        #endregion Overrides

        #region View specific

        /// <summary>
        /// Czyści wbudowane filtry grida.
        /// </summary>
        public void ClearGridFilters()
		{
			base.ClearMainGridViewFilters();
		}

		#endregion View specific

		#endregion Public methods

		#region Protected methods

		#region Overrides

		/// <summary>
		/// Inicjalizuje kontrolki.
		/// </summary>
		protected override void InitializeControls()
		{
			this.MainGridView = CountryCollectionGrid;
			this.MainBindingSource = CountryCollectionBindingSource;

			// paging
			this.mainDataPager.PageChanged += new EventHandler<PageChangeEventArgs>(mainDataPager_PageChanged);
			PageSize = ConfigurationHelper.PageSize;
		}

		/// <summary>
		/// Zamykanie widoku.
		/// </summary>
		/// <param name="e">EventArgs.</param>
		protected override void OnFormClosing(FormClosingEventArgs e)
		{
			this.mainDataPager.PageChanged -= mainDataPager_PageChanged;

			e.Cancel = false;

			base.OnFormClosing(e);

			if (!e.Cancel)
			{
				OnCancel();
			}
		}

		#endregion Overrides

		#endregion Protected methods

		#region Private methods

		/// <summary>
		/// Ustawia ilość wyfiltrowanych elementów.
		/// </summary>
		/// <param name="count">Ilość wyfiltrowanych elementów.</param>
		private void SetFilteredElementsCountLabel(int count)
		{
			mainDataPager.SetFilteredElementsCountLabel(count);
		}

		#endregion Private methods

		#region Handlers

		/// <summary>
		/// Obsługa zmiany bieżącej strony.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">EventArgs.</param>
		private void mainDataPager_PageChanged(object sender, PageChangeEventArgs e)
		{
			Presenter.Search();
		}

		/// <summary>
		/// Obsługa filtrowania inline w gridzie.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">EventArgs.</param>
		private void CountryCollectionGrid_FilterChanged(object sender, GridViewCollectionChangedEventArgs e)
		{
			SetFilteredElementsCountLabel(CountryCollectionGrid.ChildRows.Count);
		}

		/// <summary>
		/// Obsługa wyszukiwania danych.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">EventArgs.</param>
		private void searchButton_Click(object sender, EventArgs e)
		{
			Presenter.Search();
		}

		/// <summary>
		/// Obsługa czyszczenia kryteriów wyszukiwania.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">EventArgs.</param>
		private void clearFilterButton_Click(object sender, EventArgs e)
		{
			Presenter.ClearSearchCriteria();
		}


        #endregion Handlers

    }
}
