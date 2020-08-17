using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;
using CarsApp.Common.Utils;
using CarsApp.Data;
using CarsApp.UI.Managers;
using CarsApp.UI.Properties;
using LGBS.MVPFramework.Controls;
using LGBS.MVPFramework.Data;
using LGBS.MVPFramework.UI;
using Telerik.WinControls.UI;

namespace CarsApp.UI
{
	/// <summary>
	/// Widok lista obiektów typu CarProduct.
	/// </summary>
	public partial class CarProductList : BaseListWindow, ICarProductList, ICarProductListFilter
	{
		#region Consts

		/// <summary>
		/// Nazwa interfejsu widoku.
		/// </summary>
		public const string InterfaceName = "ICarProductList";
		#endregion Consts

		#region Properties

		#region Common Properties

		/// <summary>
		/// Bieżący obiekt wybrany na liście w widoku.
		/// </summary>
		public override IObjectWithId CurrentObject
		{
			get { return this.CurrentCarProduct; }
		}

		/// <summary>
		/// Prezenter widoku.
		/// </summary>
		public CarProductListPresenter Presenter
		{
			get { return BasePresenter as CarProductListPresenter; }
			set { BasePresenter = value; }
		}

		#endregion Common Properties

		#region View specific

		/// <summary>
		/// Bieżący obiekt wybrany na liście w poprzednim widoku.
		/// </summary>
		public CarProduct CurrentCarProduct
		{
			get
			{
				return CarProductCollectionBindingSource.Current as CarProduct;
			}
			set
			{
				throw new InvalidOperationException();
			}
		}


		/// <summary>
		/// Lista obiektów wyświetlanych w widoku.
		/// </summary>
		public ICollection<CarProduct> CarProductCollection
		{
			get { return CarProductCollectionBindingSource.DataSource as ICollection<CarProduct>; }
			set
			{
				CarProductCollectionBindingSource.DataSource = value;

				if (value != null)
					SetFilteredElementsCountLabel(value.Count);
			}
		}


		/// <summary>
		/// Lista obiektów wyświetlanych w combobox.
		/// </summary>
		public ICollection<CarModel> CarModelCollection
		{
			get { return ModelCollectionBindingSource.DataSource as ICollection<CarModel>; }
			set
			{
				ModelCollectionBindingSource.DataSource = value;
			}
		}


		/// <summary>
		/// Lista obiektów wyświetlanych w combobox.
		/// </summary>
		public ICollection<Factory> FactoryCollection
		{
			get { return FactoryCollectionBindingSource.DataSource as ICollection<Factory>; }
			set
			{
				FactoryCollectionBindingSource.DataSource = value;
			}
		}

		#region SearchCriteria

		/// <summary>
		/// Nazwa.
		/// </summary>
		public string FilterModel
		{
			get { return modelComboBox.Text; }
			set { modelComboBox.Text = value; }
		}

		/// <summary>
		/// Nazwa miasta.
		/// </summary>
		public string FilterVIN
		{
			get { return VINTextBox.Text; }
			set { VINTextBox.Text = value; }
		}

		/// <summary>
		/// Nazwa produkcji.
		/// </summary>
		public string FilterFactory
		{
			get { return factoryComboBox.Text; }
			set { factoryComboBox.Text = value; }
		}

		/// <summary>
		/// Filtr (kryteria wyszukiwania).
		/// </summary>
		public ICarProductListFilter Filter
		{
			get { return this as ICarProductListFilter; }
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
		/// Tworzy widok CarProductList.
		/// </summary>
		public CarProductList()
			: base(null)
		{
			SupportsShowSubElements = false;

		}

		/// <summary>
		/// Tworzy widok CarProductList.
		/// </summary>
		/// <param name="parentView">Widok nadrzędny.</param>
		public CarProductList(IBaseView parentView)
			: base(parentView)
		{
			InitializeComponent();
			AfterInitializeComponent();
			SupportsShowSubElements = false;

			if (!VSDesignMode)
			{
				this.Presenter = new CarProductListPresenter(this);

				this.SupportsShowDetails = false;
				this.SupportsDelete = false;
				this.SupportsAddNew = false;
				this.SupportsEdit = false;

				this.TopMost = true;
			}


			if (parentView != null)
			{
				FactoryList factory = new FactoryList();
				if (parentView.GetType() == factory.GetType())
				{
					factory = (FactoryList)parentView;
					this.SetViewForOneFactoryMode(factory.CurrentFactory);
				}
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
					CarProductCollectionBindingSource.ResetBindings(false);
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
					this.Text = Resources.CaptionCarProductList;
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
			this.MainGridView = CarProductCollectionGrid;
			this.MainBindingSource = CarProductCollectionBindingSource;

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


		/// <summary>
		/// Obsługa listy dla widoku fabryki.
		/// </summary>
		/// <param name="factory">Wyświetlana fabryka.</param>
		private void SetViewForOneFactoryMode(Factory factory)
		{
			List<string> factoryName = new List<string>();
			factoryName.Add(factory.Name);
		    this.factoryComboBox.DataSource = factoryName;
			this.modelComboBox.Text = null;
			Presenter.Search();
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
		private void CarProductCollectionGrid_FilterChanged(object sender, GridViewCollectionChangedEventArgs e)
		{
			SetFilteredElementsCountLabel(CarProductCollectionGrid.ChildRows.Count);
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
			this.factoryComboBox.Text = null;
		}


		/// <summary>
		/// Obsługa czyszczenia kryteriów wyszukiwania.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">CellFormattingEventArgs.</param>
		private void CarProductCollectionGrid_CellFormatting(object sender, CellFormattingEventArgs e)
		{
			if ((CarProductCollectionGrid.Rows[e.RowIndex].DataBoundItem != null) &&
				(CarProductCollectionGrid.Columns[e.ColumnIndex].FieldName.Contains(".")))
			{
				e.CellElement.Value = PropertyBindingManager.BindProperty(
							  CarProductCollectionGrid.Rows[e.RowIndex].DataBoundItem,
							  CarProductCollectionGrid.Columns[e.ColumnIndex].FieldName
							);
			}
		}


		/// <summary>
		/// Odpowiada za powrót do domyślengo DataSource.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">EventArgs.</param>
		private void factoryComboBox_DropDown(object sender, EventArgs e)
		{
			this.factoryComboBox.DataSource = this.FactoryCollectionBindingSource;
			this.factoryComboBox.DisplayMember = "Name";
		}


		/// <summary>
		/// Odpowiada za powrót do domyślengo DataSource.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">EventArgs.</param>
		private void modelComboBox_DropDown(object sender, EventArgs e)
		{

			this.modelComboBox.DataSource = this.ModelCollectionBindingSource;
			this.modelComboBox.DisplayMember = "Name";
		}
		#endregion Handlers



		/// <summary>
		/// Odpowiada za powrót do domyślengo DataSource.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">GridViewCellEventArgs.</param>
		private void CarProductCollectionGrid_CellDoubleClick(object sender, GridViewCellEventArgs e)
        {
			CarServiceDetails carService = new CarServiceDetails();
			if (ParentView.GetType() == carService.GetType())
			{
				carService = (CarServiceDetails)ParentView;
				if (ParentView.CurrentObject != null)
				{
					carService.CarProductList = this;
					carService.CarProductToAdd = this.CurrentCarProduct;
					ParentView.ShowDialog();
				}
			}
		}
    }
}
