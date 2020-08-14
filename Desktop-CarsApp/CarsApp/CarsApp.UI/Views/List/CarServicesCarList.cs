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
using CarsApp.UI.Managers;
using Telerik.WinControls;
using System.Drawing;

namespace CarsApp.UI
{
    /// <summary>
    /// Widok lista obiektów typu CarServicesCar.
    /// </summary>
    public partial class CarServicesCarList : BaseListWindow, ICarServicesCarList, ICarServicesCarListFilter
    {
        #region Consts

        /// <summary>
        /// Nazwa interfejsu widoku.
        /// </summary>
        public const string InterfaceName = "ICarServicesCarList";

        #endregion Consts

        #region Properties

        #region Common Properties

        /// <summary>
        /// Bieżący obiekt wybrany na liście w widoku.
        /// </summary>
        public override IObjectWithId CurrentObject
        {
            get { return this.CurrentCarServicesCar; }
        }

        /// <summary>
        /// Prezenter widoku.
        /// </summary>
        public CarServicesCarListPresenter Presenter
        {
            get { return BasePresenter as CarServicesCarListPresenter; }
            set { BasePresenter = value; }
        }

        #endregion Common Properties

        #region View specific

        /// <summary>
        /// Bieżący obiekt wybrany na liście w widoku.
        /// </summary>
        public CarServicesCar CurrentCarServicesCar
        {
            get
            {
                return CarServicesCarCollectionBindingSource.Current as CarServicesCar;
            }
            set
            {
                throw new InvalidOperationException();
            }
        }

        
        public CarService CarService { get;
            set; }
        /// <summary>
        /// Lista obiektów wyświetlanych w widoku.
        /// </summary>
        public ICollection<CarServicesCar> CarServicesCarCollection
        {
            get { return CarServicesCarCollectionBindingSource.DataSource as ICollection<CarServicesCar>; }
            set { CarServicesCarCollectionBindingSource.DataSource = value; }
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
        public ICarServicesCarListFilter Filter
        {
            get { return this as ICarServicesCarListFilter; }
        }

        #endregion SearchCriteria

        #endregion View specific

        #endregion Properties

        #region Ctors

        /// <summary>
        /// Tworzy widok CarServicesCarList.
        /// </summary>
        public CarServicesCarList()
            : base(null)
        {
        }

        /// <summary>
        /// Tworzy widok CarServicesCarList.
        /// </summary>
        /// <param name="parentView">Widok nadrzędny.</param>
        public CarServicesCarList(IBaseView parentView)
            : base(parentView)
        {
            InitializeComponent();
            AfterInitializeComponent();

            if (!VSDesignMode)
            {
                if (parentView != null)
                {
                    CarServiceDetails carServiceDetails = new CarServiceDetails();
                    if (parentView.GetType() == carServiceDetails.GetType())
                    {
                        this.CarService = (CarService)parentView.CurrentObject;
                    }

                }

                this.Presenter = new CarServicesCarListPresenter(this);

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
                    CarServicesCarCollectionBindingSource.ResetBindings(false);
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
                    // TODO [UITemplate] - optional: Zmienić tytuł widoku
                    this.Text = "CarServicesCar list";
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
            this.MainGridView = CarServicesCarGridView;
            this.MainBindingSource = CarServicesCarCollectionBindingSource;
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

        private void CarServicesCarGridView_CellFormatting(object sender, CellFormattingEventArgs e)
        {

            if (e.CellElement.Value != null)
            {
                if ((CarServicesCarGridView.Rows[e.RowIndex].DataBoundItem != null) &&
                    (CarServicesCarGridView.Columns[e.ColumnIndex].FieldName.Contains(".")))
                {
                    e.CellElement.Value = PropertyBindingManager.BindProperty(
                                  CarServicesCarGridView.Rows[e.RowIndex].DataBoundItem,
                                  CarServicesCarGridView.Columns[e.ColumnIndex].FieldName
                                );
                }
            }
        }

        private void CarServicesCarGridView_RowFormatting(object sender, RowFormattingEventArgs e)
        {
            if (e.RowElement.RowInfo.Cells[CarServicesCarGridView.ColumnCount - 1].Value != null)
            {
                e.RowElement.DrawFill = true;
                e.RowElement.GradientStyle = GradientStyles.Solid;
                e.RowElement.BackColor = Color.LightGray;
                e.RowElement.Enabled = false;
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.CancelAndClose();
        }
    }
}
