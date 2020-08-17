using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using CarsApp.Data;
using CarsApp.Services;
using LGBS.MVPFramework.Data;
using LGBS.MVPFramework.Controls;
using LGBS.MVPFramework.UI;
using LGBS.MVPFramework.Services;
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
        /// Bieżący obiekt wybrany na liście w widoku.
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
            set { ManufactureCollectionBindingSource.DataSource = value; }
        }

        private FactoryList _factoryList;
        /// <summary>
        /// Wcześniejszy widok.
        /// </summary>
        private FactoryList factoryList
        {
            get { return _factoryList; }
            set { _factoryList = value; }
        }
        #region SearchCriteria

        /// <summary>
        /// Filtr (kryteria wyszukiwania).
        /// </summary>
        public IManufactureListFilter Filter
        {
            get { return this as IManufactureListFilter; }
        }

        #endregion SearchCriteria

        #endregion View specific

        #endregion Properties

        #region Ctors

        /// <summary>
        /// Tworzy widok ManufactureList.
        /// </summary>
        public ManufactureList()
            : base(null)
        {
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

            if (!VSDesignMode)
            {
                this.Presenter = new ManufactureListPresenter(this);

                // TODO [UITemplate] - optional: Określić możliwe operacje
                this.SupportsShowDetails = false;
                this.SupportsDelete = false;
                this.SupportsAddNew = false;
                this.SupportsEdit = false;
            }

            if (parentView != null)
            {
                if(parentView.GetType()==typeof(FactoryList))
                    this.factoryList =(FactoryList)parentView;
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
                    // TODO [UITemplate] - optional: Zmienić tytuł widoku
                    this.Text = "Manufacture list";
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
        }

        /// <summary>
        /// Zamykanie widoku.
        /// </summary>
        /// <param name="e">EventArgs.</param>
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = false;

            base.OnFormClosing(e);
            
            if (!e.Cancel)
            {
                OnCancel();
            }
        }

        #endregion Overrides

        #endregion Protected methods

        #region EventHandlers

        /// <summary>
        /// Obsługa wybrania wyrobu.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">GridViewCellEventArgs.</param>
        private void ManufactureCollectionGrid_CellDoubleClick(object sender, GridViewCellEventArgs e)
        {
            factoryList.SetProductTextBoxValue(CurrentManufacture.Name);
            factoryList.SearchedManufacture = CurrentManufacture;
        }

        /// <summary>
        /// Obsługa wybrania wyrobu.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">KeyEventArgs.</param>
        private void ManufactureCollectionGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                factoryList.SetProductTextBoxValue(CurrentManufacture.Name);
                factoryList.SearchedManufacture = CurrentManufacture;
            }
        }

        #endregion EventHandlers
    }
}
