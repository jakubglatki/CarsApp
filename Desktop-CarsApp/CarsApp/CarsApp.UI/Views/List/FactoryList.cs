﻿using System;
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
    /// Widok lista obiektów typu Factory.
    /// </summary>
    public partial class FactoryList : BaseListWindow, IFactoryList, IFactoryListFilter
    {
        #region Consts

        /// <summary>
        /// Nazwa interfejsu widoku.
        /// </summary>
        public const string InterfaceName = "IFactoryList";
        #endregion Consts

        #region Properties

        #region Common Properties

        /// <summary>
        /// Bieżący obiekt wybrany na liście w widoku.
        /// </summary>
        public override IObjectWithId CurrentObject
        {
            get { return this.CurrentFactory; }
        }

        /// <summary>
        /// Prezenter widoku.
        /// </summary>
        public FactoryListPresenter Presenter
        {
            get { return BasePresenter as FactoryListPresenter; }
            set { BasePresenter = value; }
        }

        #endregion Common Properties

        #region View specific

        /// <summary>
        /// Bieżący obiekt wybrany na liście w poprzednim widoku.
        /// </summary>
        public Factory CurrentFactory
        {
            get
            {
                return FactoryCollectionBindingSource.Current as Factory;
            }
            set
            {
                throw new InvalidOperationException();
            }
        }

        /// <summary>
        /// Szukane miasto.
        /// </summary>
        public City SearchedCity { get; set; }

        /// <summary>
        /// Szukany producent.
        /// </summary>
        public Manufacture SearchedManufacture { get; set; }

        /// <summary>
        /// Lista obiektów wyświetlanych w widoku.
        /// </summary>
        public ICollection<Factory> FactoryCollection
        {
            get { return FactoryCollectionBindingSource.DataSource as ICollection<Factory>; }
            set
            {
                FactoryCollectionBindingSource.DataSource = value;

                if (value != null)
                    SetFilteredElementsCountLabel(value.Count);
            }
        }


        /// <summary>
        /// Lista obiektów wyświetlanych w combobox.
        /// </summary>
        public ICollection<City> CityCollection
        {
            get { return CityCollectionBindingSource.DataSource as ICollection<City>; }
            set
            {
                CityCollectionBindingSource.DataSource = value;
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
        /// Nazwa miasta.
        /// </summary>
        public City FilterCity
        {
            get
            {
                return (City)this.cityComboBox.SelectedItem;
            }
            set
            {
                cityComboBox.Text = null;
                SearchedCity = value;
            }
            
        }


        /// <summary>
        /// Id produkcji.
        /// </summary>
        public Manufacture FilterManufacture
        {
            get {
                return SearchedManufacture;
            }
            set {
                 this.SearchedManufacture = value;
            }
        }

        /// <summary>
        /// Filtr (kryteria wyszukiwania).
        /// </summary>
        public IFactoryListFilter Filter
        {
            get { return this as IFactoryListFilter; }
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
        /// Tworzy widok FactoryList.
        /// </summary>
        public FactoryList()
            : base(null)
        {
            SupportsShowSubElements = false;

        }

        /// <summary>
        /// Tworzy widok FactoryList.
        /// </summary>
        /// <param name="parentView">Widok nadrzędny.</param>
        public FactoryList(IBaseView parentView)
            : base(parentView)
        {
            InitializeComponent();
            AfterInitializeComponent();
            SupportsShowSubElements = false;

            if (!VSDesignMode)
            {
                this.Presenter = new FactoryListPresenter(this);

                this.SupportsShowDetails = false;
                this.SupportsDelete = false;
                this.SupportsAddNew = false;
                this.SupportsEdit = false;
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
                    FactoryCollectionBindingSource.ResetBindings(false);
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
                    this.Text = Resources.CaptionFactoryList;
                    break;
                case ViewMode.Dictionary:
                    break;
                default:
                    break;
            }

            base.ChangeMode(mode);
        }

        /// <summary>
        /// Pokazuje SubElements.
        /// </summary>
        public override void ShowSubElements()
        {
            Presenter.ShowSubElements();
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

        /// <summary>
        /// Ustawia text productTextBox.
        /// </summary>
        /// <param name="text">Ustawiany tekst.</param>
        public void SetProductTextBoxValue(string text)
        {
            this.productTextBox.Text = text;
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
            this.MainGridView = FactoryCollectionGrid;
            this.MainBindingSource = FactoryCollectionBindingSource;

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
        private void FactoryCollectionGrid_FilterChanged(object sender, GridViewCollectionChangedEventArgs e)
        {
            SetFilteredElementsCountLabel(FactoryCollectionGrid.ChildRows.Count);
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
            this.cityComboBox.DataSource = null;
           
        }


        /// <summary>
        /// Obsługa wyznaczania atrybutów tabeli.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">CellFormattingEventArgs.</param>
        private void FactoryCollectionGrid_CellFormatting(object sender, CellFormattingEventArgs e)
        {
            if ((FactoryCollectionGrid.Rows[e.RowIndex].DataBoundItem != null) &&
                (FactoryCollectionGrid.Columns[e.ColumnIndex].FieldName.Contains(".")))
            {
                e.CellElement.Value = PropertyBindingManager.BindProperty(
                              FactoryCollectionGrid.Rows[e.RowIndex].DataBoundItem,
                              FactoryCollectionGrid.Columns[e.ColumnIndex].FieldName
                            );
            }
        }


        /// <summary>
        /// Zezwolenie na pokazanie widoku podrzędnego.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">EventArgs.</param>
        private void FactoryCollectionGrid_DoubleClick(object sender, EventArgs e)
        {
            SupportsShowSubElements = true;
        }

        /// <summary>
        /// Włączenie słownika Manufacture.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">EventArgs.</param>
        private void productButton_Click(object sender, EventArgs e)
        {
            IManufactureList view = CarsViewFactory.Factory.CreateViewInstance<IManufactureList>(this);
            view.Show(ViewMode.Dictionary);

        }

        /// <summary>
        /// Ustawia DataSource cityComboBox.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">EventArgs.</param>
        private void cityComboBox_DropDown(object sender, EventArgs e)
        {
            this.cityComboBox.DataSource = this.CityCollectionBindingSource;
            this.cityComboBox.DisplayMember = "Name";
        }

        #endregion Handlers


    }
}
