using System;
using System.Collections.Generic;
using System.Reflection;
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
	/// Widok lista obiektów typu Manufacture.
	/// </summary>
	public partial class ManufactureList : BaseListWindow, IManufactureList, IManufactureListFilter
	{
		#region Consts

		/// <summary>
		/// Nazwa interfejsu widoku.
		/// </summary>
		public const string InterfaceName = "IManufactureList";
		#endregion Consts

		#region Properties

		#region Common Properties

		/// <summary>
		/// Bieżący obiekt wybrany na liście w widoku.
		/// </summary>
		public override IObjectWithId CurrentObject
		{
			get { return this.CurrentManufacture; }
		}

		/// <summary>
		/// Prezenter widoku.
		/// </summary>
		public ManufactureListPresenter Presenter
		{
			get { return BasePresenter as ManufactureListPresenter; }
			set { BasePresenter = value; }
		}

		#endregion Common Properties

		#region View specific

		/// <summary>
		/// Bieżący obiekt wybrany na liście w poprzednim widoku.
		/// </summary>
		public Manufacture CurrentManufacture
		{
			get
			{
				return ManufactureCollectionBindingSource.Current as Manufacture;
			}
			set
			{
				throw new InvalidOperationException();
			}
		}


		/// <summary>
		/// Lista obiektów wyświetlanych w widoku.
		/// </summary>
		public ICollection<Manufacture> ManufactureCollection
		{
			get { return ManufactureCollectionBindingSource.DataSource as ICollection<Manufacture>; }
			set
			{
				ManufactureCollectionBindingSource.DataSource = value;

				if (value != null)
					SetFilteredElementsCountLabel(value.Count);
			}
		}


		/// <summary>
		/// Lista obiektów wyświetlanych w combobox.
		/// </summary>
		public ICollection<City> CityCollection
		{
			get { return FactoryCollectionBindingSource.DataSource as ICollection<City>; }
			set
			{
				FactoryCollectionBindingSource.DataSource = value;
			}
		}
		#region SearchCriteria

		/// <summary>
		/// Nazwa.
		/// </summary>
		public string FilterName
		{
			get { return VINTextBox.Text; }
			set { VINTextBox.Text = value; }
		}

		/// <summary>
		/// Nazwa miasta.
		/// </summary>
		public string FilterCityName
		{
			get { return modelComboBox.Text; }
			set { modelComboBox.Text = value; }
		}

		/// <summary>
		/// Nazwa produkcji.
		/// </summary>
		public string FilterManufactureName
		{
			get { return manufactureTextBox.Text; }
			set { manufactureTextBox.Text = value; }
		}

		/// <summary>
		/// Filtr (kryteria wyszukiwania).
		/// </summary>
		public IManufactureListFilter Filter
		{
			get { return this as IManufactureListFilter; }
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
		/// Tworzy widok ManufactureList.
		/// </summary>
		public ManufactureList()
			: base(null)
		{
			SupportsShowSubElements = false;

		}

		/// <summary>
		/// Tworzy widok ManufactureList.
		/// </summary>
		/// <param name="parentView">Widok nadrzędny.</param>
		public ManufactureList(IBaseView parentView)
			: base(parentView)
		{
			InitializeComponent();
			AfterInitializeComponent();
			SupportsShowSubElements = false;

			if (!VSDesignMode)
			{
				this.Presenter = new ManufactureListPresenter(this);

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
					ManufactureCollectionBindingSource.ResetBindings(false);
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
					this.Text = Resources.CaptionManufactureList;
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
			this.MainGridView = ManufactureCollectionGrid;
			this.MainBindingSource = ManufactureCollectionBindingSource;

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
		private void ManufactureCollectionGrid_FilterChanged(object sender, GridViewCollectionChangedEventArgs e)
		{
			SetFilteredElementsCountLabel(ManufactureCollectionGrid.ChildRows.Count);
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
			this.modelComboBox.Text = null;
		}


		/// <summary>
		/// Obsługa czyszczenia kryteriów wyszukiwania.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">CellFormattingEventArgs.</param>
		private void ManufactureCollectionGrid_CellFormatting(object sender, CellFormattingEventArgs e)
		{
			if ((ManufactureCollectionGrid.Rows[e.RowIndex].DataBoundItem != null) &&
				(ManufactureCollectionGrid.Columns[e.ColumnIndex].FieldName.Contains(".")))
			{
				e.CellElement.Value = BindProperty(
							  ManufactureCollectionGrid.Rows[e.RowIndex].DataBoundItem,
							  ManufactureCollectionGrid.Columns[e.ColumnIndex].FieldName
							);
			}
		}
		#endregion Handlers

		private string BindProperty(object property, string propertyName)
		{
			string retValue;

			retValue = "";

			if (propertyName.Contains("."))
			{
				PropertyInfo[] arrayProperties;
				string leftPropertyName;

				leftPropertyName = propertyName.Substring(0, propertyName.IndexOf("."));
				arrayProperties = property.GetType().GetProperties();

				foreach (PropertyInfo propertyInfo in arrayProperties)
				{
					if (propertyInfo.Name == leftPropertyName)
					{
						retValue = BindProperty(propertyInfo.GetValue(property, null), propertyName.Substring(propertyName.IndexOf(".") + 1));
						break;
					}
				}
			}
			else
			{
				Type propertyType;
				PropertyInfo propertyInfo;

				propertyType = property.GetType();
				propertyInfo = propertyType.GetProperty(propertyName);
				retValue = propertyInfo.GetValue(property, null).ToString();
			}

			return retValue;
		}

	}
}
