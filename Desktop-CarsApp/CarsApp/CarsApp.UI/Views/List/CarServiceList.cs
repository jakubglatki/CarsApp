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
    /// Widok lista obiektów typu CarService.
    /// </summary>
    public partial class CarServiceList : BaseListWindow, ICarServiceList, ICarServiceListFilter
    {
        #region Consts

        /// <summary>
        /// Nazwa interfejsu widoku.
        /// </summary>
        public const string InterfaceName = "ICarServiceList";

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
        public CarServiceListPresenter Presenter
        {
            get { return BasePresenter as CarServiceListPresenter; }
            set { BasePresenter = value; }
        }

        #endregion Common Properties

        #region View specific

        /// <summary>
        /// Bieżący obiekt wybrany na liście w widoku.
        /// </summary>
        public CarService CurrentCarService
        {
            get
            {
                return CarServiceCollectionBindingSource.Current as CarService;
            }
            set
            {
                      CarServiceCollectionBindingSource.DataSource = value; 
            }
        }

        /// <summary>
        /// Bieżący obiekt wybrany na liście w widoku.
        /// </summary>
        public CarServicesView CurrentCarServicesView
        {
            get
            {
                return CarServiceCollectionBindingSource.Current as CarServicesView;
            }
            set
            {
               // CarServiceCollectionBindingSource.DataSource = value;
            }
        }

        /// <summary>
        /// Lista obiektów wyświetlanych w widoku.
        /// </summary>
        public ICollection<CarService> CarServiceCollection
        {
            get { return CarServiceCollectionBindingSource.DataSource as ICollection<CarService>; }
            set { CarServiceCollectionBindingSource.DataSource = value; }
        }

        /// <summary>
        /// Lista obiektów wyświetlanych w widoku.
        /// </summary>
        public ICollection<CarServicesView> CarServicesViewCollection
        {
            get { return CarServiceCollectionBindingSource.DataSource as ICollection<CarServicesView>; }
            set { CarServiceCollectionBindingSource.DataSource = value; }
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
        public ICarServiceListFilter Filter
        {
            get { return this as ICarServiceListFilter; }
        }

        #endregion SearchCriteria

        #endregion View specific

        #endregion Properties

        #region Ctors

        /// <summary>
        /// Tworzy widok CarServiceList.
        /// </summary>
        public CarServiceList()
            : base(null)
        {
        }

        /// <summary>
        /// Tworzy widok CarServiceList.
        /// </summary>
        /// <param name="parentView">Widok nadrzędny.</param>
        public CarServiceList(IBaseView parentView)
            : base(parentView)
        {
            InitializeComponent();
            AfterInitializeComponent();

            if (!VSDesignMode)
            {
                this.Presenter = new CarServiceListPresenter(this);

                // TODO [UITemplate] - optional: Określić możliwe operacje
                this.SupportsShowDetails = true;
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
                    CarServiceCollectionBindingSource.ResetBindings(false);
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
            this.MainGridView = CarServiceCollectionGrid;
            this.MainBindingSource = CarServiceCollectionBindingSource;
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
