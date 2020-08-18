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
using System.Web.UI.WebControls;
using System.Data.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using Telerik.WinControls;
using CarsApp.UI.Properties;

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



        /// <summary>
        /// Bieżący obiekt wyświetlany w widoku.
        /// </summary>
        public CarServicesCar CurrentCarServicesCar
        {
            get { return CarServicesCarBindingSource.Current as CarServicesCar; }
            set { CarServicesCarBindingSource.DataSource = value; }
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
                if (this.loanButton.Text.Contains("wypożyczenia"))
                    Presenter.AddCarProduct(true);
                else
                    Presenter.AddCarProduct(false);

                ParentView.Close();
            }
        }


        /// <summary>
        /// CarProductList.
        /// </summary>
        public CarProductList CarProductList
        {
            get; set;
        }

        /// <summary>
        /// Bieżący obiekt wyświetlany w widoku.
        /// </summary>
        public ICollection<HandledCarProduct> HandledCarProductsCollection
        {
            get { return HandledCarBindingSource.DataSource as ICollection<HandledCarProduct>; }
            set { HandledCarBindingSource.DataSource = value; }
        }

        /// <summary>
        /// Bieżący obiekt wyświetlany w widoku.
        /// </summary>
        public ICollection<CarServicesCar> CarServicesCarsCollection
        {
            get { return CarServicesCarBindingSource.DataSource as ICollection<CarServicesCar>; }
            set { CarServicesCarBindingSource.DataSource = value; }
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
            if (ParentView.GetType() == typeof(CarProductList))
                ParentView.Hide();
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

        /// <summary>
        /// Usuwa dany samochód.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">EventArgs.</param>
        private void deleteCarButton_Click(object sender, EventArgs e)
        {
            if (loanButton.Text.Contains(Resources.CarServicesCarButton))
            {
                Presenter.DeleteHandledCarProduct(CurrentHandledCarProduct);
            }
            else
            {
                Presenter.DeleteCarServicesCar(CurrentCarServicesCar);
            }
            ParentView.Close();
        }

        /// <summary>
        /// Dodaje nowy samochód.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">EventArgs.</param>
        private void addCarButton_Click(object sender, EventArgs e)
        {
            Presenter.ShowCarProductsInDictionaryMode();
            this.Hide();
        }

        /// <summary>
        /// Ustawia samochód jako naprawiony/nie naprawiony.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">EventArgs.</param>
        private void isFixedCheckBox_Click(object sender, EventArgs e)
        {

            if (CurrentHandledCarProduct.IsFixed == false)
            {
                Presenter.FixCarProduct();

            }
            else if (CurrentHandledCarProduct.IsFixed == true)
            {
                CurrentHandledCarProduct.IsFixed = false;
                CurrentHandledCarProduct.FixDate = null;
                Presenter.SaveData();
            }
        }

        /// <summary>
        /// Zmienia tekst przycisku i widoczność.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">EventArgs.</param>
        private void loanButton_Click(object sender, EventArgs e)
        {
            if (loanButton.Text.Contains(Resources.CarServicesCarButton))
            {
                loanButton.Text = Resources.HandledCarProuctButton;
                SetVisibility(false);
            }
            else
            {
                loanButton.Text = Resources.CarServicesCarButton;
                SetVisibility(true);
            }
        }


        /// <summary>
        /// Ustawia komórki grida.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">CellFormattingEventArgs.</param>
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

        /// <summary>
        /// Zmienia zaznaczenie isFixedCheckBox.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">EventArgs.</param>
        private void CarProductCollectionGrid_SelectionChanged(object sender, EventArgs e)
        {

            if (CurrentHandledCarProduct.IsFixed == false)
                this.isFixedCheckBox.Checked = false;

            else if (CurrentHandledCarProduct.IsFixed == true)
                this.isFixedCheckBox.Checked = true;
        }


        /// <summary>
        /// Ustawia komórki grida.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">CellFormattingEventArgs.</param>
        private void CarServicesCarCollectionGrid_CellFormatting(object sender, CellFormattingEventArgs e)
        {

            if (e.CellElement.Value != null)
            {
                if ((CarServicesCarCollectionGrid.Rows[e.RowIndex].DataBoundItem != null) &&
                    (CarServicesCarCollectionGrid.Columns[e.ColumnIndex].FieldName.Contains(".")))
                {
                    e.CellElement.Value = PropertyBindingManager.BindProperty(
                                  CarServicesCarCollectionGrid.Rows[e.RowIndex].DataBoundItem,
                                  CarServicesCarCollectionGrid.Columns[e.ColumnIndex].FieldName
                                );
                }
            }

        }

        #endregion Handlers

        #region Private methods
        /// <summary>
        /// Ustawia widoczność.
        /// </summary>
        /// <param name="isVisiblie">Ustawia widoczność.</param>
        private void SetVisibility(bool isVisiblie)
        {

            CarServicesCarCollectionGrid.Visible = !isVisiblie;
            CarProductCollectionGrid.Visible = isVisiblie;
            isFixedCheckBox.Visible = isVisiblie;
            checkBoxLabel.Visible = isVisiblie;
        }
        #endregion Private methods

    }
}