using System;
using System.Collections.Generic;
using System.ComponentModel;
using CarsApp.Data;
using LGBS.MVPFramework.Data;
using LGBS.MVPFramework.Controls;
using LGBS.MVPFramework.UI;
using Telerik.WinControls.UI;
using CarsApp.UI.Managers;
using System.Windows.Forms;

namespace CarsApp.UI
{
    /// <summary>
    /// Widok szczegółówy obiektu typu CarService.
    /// </summary>
    public partial class CarServiceDetails : BaseDetailsWindow, ICarServiceDetails
    {
        #region Consts

        /// <summary>
        /// Nazwa interfejsu widoku.
        /// </summary>
        public const string InterfaceName = "ICarServiceDetails";

        /// <summary>
        /// Tryby pracy widoku <see cref="CarServiceDetails"/>.
        /// </summary>
        public class WorkModes : BaseWorkModes
        {
            // TODO [UITemplate] - optional: Zdefiniowanć niestandardowe tryby pracy
            // np.
            //public const int SampleWorkMode = 1;
        }

        #endregion Consts

        #region Properties

        #region Common Properties

        /// <summary>
        /// Bieżący obiekt wyświetlany w widoku.
        /// </summary>
        public override IObjectWithId CurrentObject
        {
            get { return this.CurrentCarService; }
        }

        /// <summary>
        /// Prezenter widoku.
        /// </summary>
        public CarServiceDetailsPresenter Presenter
        {
            get { return BasePresenter as CarServiceDetailsPresenter; }
            set { BasePresenter = value; }
        }

        #endregion Common Properties

        #region View Specific

        /// <summary>
        /// Bieżący obiekt wyświetlany w widoku.
        /// </summary>
        public CarService CurrentCarService
        {
            get { return CarServiceBindingSource.DataSource as CarService; }
            set { CarServiceBindingSource.DataSource = value; }
        }

        /// <summary>
        /// Bieżący obiekt wyświetlany w widoku.
        /// </summary>
        public HandledCarProduct CurrentHandledCarProduct
        {
            get { return HandledCarBindingSource.Current as HandledCarProduct; }
            set { HandledCarBindingSource.DataSource = value; }
        }


        private CarProduct _carProductToAdd;
        /// <summary>
        /// CarProduct do dodania.
        /// </summary>
        public CarProduct CarProductToAdd
        {
            get
            {
                return this._carProductToAdd;
            }
            set 
            {
                _carProductToAdd = value;
              Presenter.AddCarProduct();
            }
        }

        /// <summary>
        /// Bieżący obiekt wyświetlany w widoku.
        /// </summary>
        public ICollection<HandledCarProduct> HandledCarProductsCollection
        {
            get { return HandledCarBindingSource.DataSource as ICollection<HandledCarProduct>; }
            set { HandledCarBindingSource.DataSource = value; }
        }

        #endregion View Specific

        #endregion Properties

        #region Ctors

        /// <summary>
        /// Tworzy widok CarServiceDetails.
        /// </summary>
        public CarServiceDetails()
            : base(null)
        {
        }

        /// <summary>
        /// Tworzy widok CarServiceDetails.
        /// </summary>
        /// <param name="parentView">Widok nadrzędny.</param>
        public CarServiceDetails(IBaseView parentView)
            : base(parentView)
        {
            InitializeComponent();
            AfterInitializeComponent();
            if (!VSDesignMode)
                this.Presenter = new CarServiceDetailsPresenter(this);


            if (parentView != null)
            {
                CarServiceList carService = new CarServiceList();
                if (parentView.GetType() == carService.GetType())
                {
                    carService = (CarServiceList)parentView;
                    this.SetCurrentCarService(carService.CurrentCarServicesView);
                }

            }
        }

        #endregion Ctors

        #region Private methods

        /// <summary>
        /// Ustawia obecny CarService.
        /// </summary>
        private void SetCurrentCarService(CarServicesView view)
        {
            Presenter.SetCurrentCarService(view);
        }

        /// <summary>
        /// Inicjalizuje walidatory.
        /// </summary>
        private void InitializeValidators()
        {
        }

        /// <summary>
        /// Inicjalizuje ribbon bar.
        /// </summary>
        private void InitializeRibbonBar()
        {
            // zablokowanie minimalizacji ribbon bar'a
            mainRadRibbonBar.CollapseRibbonOnTabDoubleClick = false;
            // zablokowanie pojawianie się key map po naciśnięciu Alt
            mainRadRibbonBar.EnableKeyMap = false;
        }

        /// <summary>
        /// Przygotowuje okno do pracy w trybie New.
        /// </summary>
        private void SetWindowStateForNewMode()
        {
            // tytuł okna
            // TODO [UITemplate] - optional: Zmienić tytuł widoku
            this.Text = "CarService - new";

            // ukrycie tab'a Zarządzanie
            managementRibbonTab.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            // pokazanie tab'a Edycja
            editRibbonTab.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // ukrycie grupy z przyciskiem Usuń
            objectDetailsActionsRadRibbonBarGroup.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            // zaznaczenie tab'a Edycja
            editRibbonTab.IsSelected = true;

            // ukrycie przycisku Zamknij
            closeButton.Visible = false;

            // włączenie wszystkich kontrolek w tryb edycji
            EnableControls(true);
        }

        /// <summary>
        /// Przygotowuje okno do pracy w trybie Edit.
        /// </summary>
        private void SetWindowStateForEditMode()
        {
            // tytuł okna
            // TODO [UITemplate] - optional: Zmienić tytuł widoku
            this.Text = "CarService - edit";

            // ukrycie tab'a Zarządzanie
            managementRibbonTab.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            // pokazanie tab'a Edycja
            editRibbonTab.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // pokazanie grupy z przyciskiem Usuń
            objectDetailsActionsRadRibbonBarGroup.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // zaznaczenie tab'a Edycja
            editRibbonTab.IsSelected = true;

            // ustawienie dostępności btn Usuń
            if (ParentView != null)
                deleteObjectRadButtonElement.Enabled = ParentView.SupportsDelete;

            // ukrycie przycisku Zamknij
            closeButton.Visible = false;

            // włączenie wszystkich kontrolek w tryb edycji
            EnableControls(true);
        }

        /// <summary>
        /// Przygotowuje okno do pracy w trybie ReadOnly.
        /// </summary>
        private void SetWindowStateForReadOnlyMode()
        {
            // tytuł okna
            // TODO [UITemplate] - optional: Zmienić tytuł widoku
            this.Text = "Szczegóły serwisu";

            // pokazanie tab'a Zarządzanie
            managementRibbonTab.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // ukrycie tab'a Edycja
            editRibbonTab.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            // zaznaczenie tab'a Zarządzanie
            managementRibbonTab.IsSelected = true;

            // ustawienie dostępności btn Usuń i Edytuj
            if (ParentView != null)
            {
                deleteRadButtonElement.Enabled = ParentView.SupportsDelete;
                editRadButtonElement.Enabled = ParentView.SupportsEdit;
            }

            // pokazanie przycisku Zamknij
            closeButton.Visible = true;

            // ustawienie wszystkich kontrolek tylko do odczytu
            EnableControls(false);
        }

        /// <summary>
        /// Aktywuje / deaktywuje wszystkie kontrolki na formatce.
        /// </summary>
        /// <param name="enable">True - wszystkie kontrolki są edytowalne.</param>
        private void EnableControls(bool enable)
        {
            nameTextBox.ReadOnly = !enable;
            streetTextBox.ReadOnly = !enable;
            postCodeTextBox.ReadOnly = !enable;
            if (!enable)
                cityComboBox.Enabled = false;
            else
                cityComboBox.Enabled = true;
        }

        #endregion Private methods

        #region Protected methods

        #region Overrides

        /// <summary>
        /// Inicjalizuje kontrolki.
        /// </summary>
        protected override void InitializeControls()
        {
            this.MainBindingSource = CarServiceBindingSource;

            // inicjalizacja walidatorów
            InitializeValidators();

            // inicjalizacja ribbon bar'a
            InitializeRibbonBar();
        }

        #endregion Overrides

        #endregion Protected methods

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
        /// Zmienia tryb widoku.
        /// </summary>
        /// <param name="mode">Tryb widoku.</param>
        public override void ChangeMode(ViewMode mode)
        {
            switch (mode)
            {
                case ViewMode.New:
                    SetWindowStateForNewMode();
                    break;
                case ViewMode.Edit:
                    SetWindowStateForEditMode();
                    break;
                case ViewMode.ReadOnly:
                    SetWindowStateForReadOnlyMode();
                    break;
                default:
                    throw new ViewModeNotSupportedException();
            }

            base.ChangeMode(mode);
        }

        #endregion Overrides

        #endregion Public methods

        #region Handlers

        #region From buttons

        #region Zatwierdzanie ribbon bar group

        /// <summary>
        /// Obsługa naciśnięcia btn OK.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">EventArgs.</param>
        private void okRadButtonElement_Click(object sender, EventArgs e)
        {
            if (CurrentCarService != null)
            {
                AcceptAndClose();
            }
        }

        /// <summary>
        /// Obsługa naciśnięcia btn Anuluj.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">EventArgs.</param>
        private void cancelRadButtonElement_Click(object sender, EventArgs e)
        {
            base.CancelAndClose();
        }

        #endregion Zatwierdzanie ribbon bar group

        #region Schowek ribbon bar group

        /// <summary>
        /// Obsługa naciśnięcia btn Wklej.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">EventArgs.</param>
        private void pasteRadButtonElement_Click(object sender, EventArgs e)
        {
            base.Paste();
        }

        /// <summary>
        /// Obsługa naciśnięcia btn Wytnij.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">EventArgs.</param>
        private void cutRadButtonElement_Click(object sender, EventArgs e)
        {
            base.Cut();
        }

        /// <summary>
        /// Obsługa naciśnięcia btn Kopiuj.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">EventArgs.</param>
        private void copyRadButtonElement_Click(object sender, EventArgs e)
        {
            base.Copy();
        }

        #endregion Schowek ribbon bar group

        #region Akcje ribbon bar group

        /// <summary>
        /// Obsługa naciśnięcia btn Edytuj.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">EventArgs.</param>
        private void editRadButtonElement_Click(object sender, EventArgs e)
        {
            ChangeMode(ViewMode.Edit);
        }

        /// <summary>
        /// Obsługa naciśnięcia btn Usuń.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">EventArgs.</param>
        private void deleteRadButtonElement_Click(object sender, EventArgs e)
        {
            if (CurrentCarService != null)
            {
                base.Delete();
            }
        }

        #endregion Akcje ribbon bar group

        #endregion From buttons

        #region From view

        /// <summary>
        /// Obsługa zdarzenia Shown.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">EventArgs.</param>
        private void CarServiceDetails_Shown(object sender, EventArgs e)
        {
            // TODO [UITemplate] - optional: Ustawić focus na odpowiednią kontrolkę w trybie ViewMode.New
            //if (Mode == ViewMode.New)
            //	textBox.Focus();
            if (Mode != ViewMode.New)
                this.SetComboBoxValue();
        }


        /// <summary>
        /// Ustawia kraj pokazywanego miasta.
        /// </summary>
        private void SetComboBoxValue()
        {
            if (this.CurrentCarService != null)
            {
                this.cityComboBox.Items.Add(this.CurrentCarService.City.Name);
                this.cityComboBox.SelectedIndex = 0;
            }
        }

        #endregion From view

        #endregion Handlers

        private void deleteCarButton_Click(object sender, EventArgs e)
        {
            Presenter.DeleteHandledCarProduct(CurrentHandledCarProduct);
        }

        private void CarProductCollectionGrid_CellFormating(object sender, CellFormattingEventArgs e)
        {
            if (e.CellElement.Value != null)
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
        }

        private void CarProductCollectionGrid_SelectionChanged(object sender, EventArgs e)
        {

            if (CurrentHandledCarProduct.IsFixed == false)
                this.isFixedCheckBox.Checked = false;

            else if (CurrentHandledCarProduct.IsFixed == true)
                this.isFixedCheckBox.Checked = true;
        }

        private void isFixedCheckBox_Click(object sender, EventArgs e)
        {
            if (CurrentHandledCarProduct.IsFixed == false)
            {
                CurrentHandledCarProduct.IsFixed = true;
                CurrentHandledCarProduct.FixDate = DateTime.Now;
                Presenter.SaveData();
            }
            else if (CurrentHandledCarProduct.IsFixed == true)
            {
                CurrentHandledCarProduct.IsFixed = false;
                CurrentHandledCarProduct.FixDate = DateTime.MaxValue;
                Presenter.SaveData();
            }
        }

        private void addCarButton_Click(object sender, EventArgs e)
        {
            Presenter.ShowCarProductsInDictionaryMode();
            this.Hide();
        }
    }
}
