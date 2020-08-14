using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CarsApp.Data;
using CarsApp.Services;
using LGBS.MVPFramework.Controls;
using LGBS.MVPFramework.Data;
using LGBS.MVPFramework.UI;

namespace CarsApp.UI
{
    /// <summary>
    /// Prezenter widoku CarServiceDetails.
    /// </summary>
    public class CarServiceDetailsPresenter : BaseGenericPresenter<ICarServiceDetails, INoDetailsView, CarServiceService>
    {
        #region Ctors

        /// <summary>
        /// Tworzy presenter widoku CarServiceList.
        /// </summary>
        /// <param name="view">Obsługiwany widok.</param>
        public CarServiceDetailsPresenter(ICarServiceDetails view)
            : base(view, true)
        {
        }

        #endregion Ctors

        #region Protected methods

        #region Overrides

        /// <summary>
        /// Pobiera dane i wyświetla w widoku.
        /// </summary>
        /// <param name="type">Tryb pokazywania danych.</param>
        protected override void LoadData(RefreshDataType type)
        {
            switch (type)
            {
                case RefreshDataType.Full:
                    LoadData(RefreshDataType.DictionaryValues);
                    LoadData(RefreshDataType.CurrentObjectData);
                    break;
                case RefreshDataType.DictionaryValues:
                    break;
                case RefreshDataType.CurrentObjectData:
                    switch (View.Mode)
                    {
                        case ViewMode.New:
                            View.CurrentCarService = Service.AddNew();
                            break;
                        case ViewMode.Edit:
                        case ViewMode.ReadOnly:
                            View.HandledCarProductsCollection = Service.GetHandledCarProductCollection(View.CurrentCarService);
                            View.CarServicesCarsCollection = Service.GetCarServicesCarCollection(View.CurrentCarService);
                            break;
                        default:
                            throw new ViewModeNotSupportedException();
                    }

                    break;

                default:
                    throw new RefreshTypeNotSupportedException();
            }
        }

        /// <summary>
        /// Wykonuje dodatkowe (opcjonalne) operacje przez zapisem danych.
        /// </summary>
        protected override void PreSaveChanges()
        {
        }

        protected override void DeleteObject(IObjectWithId obj)
        {
            if (obj != null)
            {
                base.DeleteObject(obj);
                View.RefreshData();
            }
        }
        #endregion Overrides

        #endregion Protected methods

        #region Public methods

        public void DeleteHandledCarProduct(HandledCarProduct handledCarProduct)
        {
            this.DeleteObject(handledCarProduct);
        }


        public void ShowCarProductsInDictionaryMode()
        {
            ICarProductList view = CarsViewFactory.Factory.CreateViewInstance<ICarProductList>(View);
            view.Show(ViewMode.Dictionary);
        }

        public void AddCarProduct()
        {
            if (View.CurrentObject == null)
                return;
            if (View.HandledCarProductsCollection != null)
            {
                foreach (HandledCarProduct carProduct in View.HandledCarProductsCollection)
                {
                    if (carProduct.CarServiceId == View.CurrentCarService.Id && carProduct.CarProductId == View.CarProductToAdd.Id)
                    {
                        View.CarProductList.Close();
                        this.ShowCarInServiceMessageWindow();
                        return;
                    }
                }
                Service.AddToHandledCarProductCollection(View.CurrentCarService, View.CarProductToAdd);
                this.ShowCarToLoanMessageWindow();
                View.RefreshData();
            }
        }

        public void SetCurrentCarService(CarServicesView view)
        {
            foreach (CarService carService in Service.GetCarServiceCollection())
            {
                if (carService.Name == view.Name)
                {
                    View.CurrentCarService = carService;
                    break;
                }
            }
        }

        public void FixCarProduct()
        {
            Service.CallFixCarProductProcedure(View.CurrentCarService, View.CurrentHandledCarProduct.CarProduct);
        }

        public void ShowCarServicesCarDictionary()
        {
            
        }
            #endregion Public methods

            #region Private methods

        private void ShowCarInServiceMessageWindow()
        {

            string message = "Wybrany samochód już się znajduje w tym serwisie";
            string caption = "Błąd";
            MessageBoxButtons buttons = MessageBoxButtons.OK;

            System.Windows.Forms.DialogResult result;
            result = LGBSMessageBox.Show(message, caption, buttons);
        }

        private void ShowCarToLoanMessageWindow()
        {
            string message = "Czy klient dostał auto zastępcze?";
            string caption = "Auto zastępcze";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;

            System.Windows.Forms.DialogResult result;
            result = LGBSMessageBox.Show(message, caption, buttons);

            if(result== System.Windows.Forms.DialogResult.Yes)
            {
                GiveClientTempCar();
            }
        }

        private void GiveClientTempCar()
        {
            ICarServicesCarList dict = CarsViewFactory.Factory.CreateViewInstance<ICarServicesCarList>(View);
            LGBS.MVPFramework.UI.DialogResult dialogResult = dict.ShowDialog(ViewMode.Dictionary);
            if (dialogResult == LGBS.MVPFramework.UI.DialogResult.OK)
            {
                foreach (CarServicesCar car in View.CarServicesCarsCollection)
                {
                    if (car.CarProductId == dict.CurrentCarServicesCar.CarProductId)
                    {
                        car.PersonId = View.CarProductToAdd.PersonId;
                        car.LoanDate = DateTime.Now;
                        View.RefreshData();
                        break;
                    }
                }
            }
        }
            #endregion Private methods
        
    }
}