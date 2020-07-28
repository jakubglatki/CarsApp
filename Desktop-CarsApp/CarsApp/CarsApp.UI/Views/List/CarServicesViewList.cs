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
using CarsApp.UI.Properties;

namespace CarsApp.UI
{
    /// <summary>
    /// Widok lista obiektów typu CarServicesView.
    /// </summary>
    public partial class CarServicesViewList : BaseListWindow, ICarServicesViewList, ICarServicesViewListFilter
    {
        #region Consts

        /// <summary>
        /// Nazwa interfejsu widoku.
        /// </summary>
        public const string InterfaceName = "ICarServicesViewList";

        #endregion Consts

        #region Properties

        #region Common Properties

        /// <summary>
        /// Bieżący obiekt wybrany na liście w widoku.
        /// </summary>
        public override IObjectWithId CurrentObject
        {
            get { return this.CurrentCarServicesView; }
        }

        /// <summary>
        /// Prezenter widoku.
        /// </summary>
        public CarServicesViewListPresenter Presenter
        {
            get { return BasePresenter as CarServicesViewListPresenter; }
            set { BasePresenter = value; }
        }

        #endregion Common Properties

        #region View specific

        /// <summary>
        /// Bieżący obiekt wybrany na liście w widoku.
        /// </summary>
        public CarServicesView CurrentCarServicesView
        {
            get
            {
                return CarServicesViewCollectionBindingSource.Current as CarServicesView;
            }
            set
            {
                throw new InvalidOperationException();
            }
        }

        /// <summary>
        /// Lista obiektów wyświetlanych w widoku.
        /// </summary>
        public ICollection<CarServicesView> CarServicesViewCollection
        {
            get { return CarServicesViewCollectionBindingSource.DataSource as ICollection<CarServicesView>; }
            set { CarServicesViewCollectionBindingSource.DataSource = value; }
        }

        #region SearchCriteria

        // TODO [UITemplate] - optional: SearchCriteria
        // np
        //public string FilterName
        //{
        //    get { return nameTextBox.Text; }
        //    set { nameTextBox.Text = value; }
        //}

        /// <summary>
        /// Filtr (kryteria wyszukiwania).
        /// </summary>
        public ICarServicesViewListFilter Filter
        {
            get { return this as ICarServicesViewListFilter; }
        }

        #endregion SearchCriteria

        #endregion View specific

        #endregion Properties

        #region Ctors

        /// <summary>
        /// Tworzy widok CarServicesViewList.
        /// </summary>
        public CarServicesViewList()
            : base(null)
        {
        }

        /// <summary>
        /// Tworzy widok CarServicesViewList.
        /// </summary>
        /// <param name="parentView">Widok nadrzędny.</param>
        public CarServicesViewList(IBaseView parentView)
            : base(parentView)
        {
            InitializeComponent();
            AfterInitializeComponent();

            if (!VSDesignMode)
            {
                this.Presenter = new CarServicesViewListPresenter(this);

                // TODO [UITemplate] - optional: Określić możliwe operacje
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
                    CarServicesViewCollectionBindingSource.ResetBindings(false);
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
                // TODO [UITemplate] - optional: W razie potrzeby przekazać do metody własny komunikat
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
                    this.Text = Resources.CaptionCarServicesViewList;
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
            this.MainGridView = CarServicesViewCollectionGrid;
            this.MainBindingSource = CarServicesViewCollectionBindingSource;
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
    }
}
