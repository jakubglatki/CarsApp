using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Text;
using LGBS.MVPFramework.Services;
using LinqKit;
using CarsApp.Data;

namespace CarsApp.Services
{
    /// <summary>
    /// Serwis dla obiektów typu CarService.
    /// </summary>
    public class CarServiceService : BaseGenericService<CarsDb, CarService>
    {
        #region Ctors

        /// <summary>
        /// Tworzy serwis dla obiektów typu CarService.
        /// </summary>
        public CarServiceService()
        {
        }

        /// <summary>
        /// Tworzy serwis dla obiektów typu CarService.
        /// </summary>
        /// <param name="contextDb">Określa, czy inicjalizować nowy kontekst.</param>
        public CarServiceService(CarsDb contextDb)
            : base(contextDb)
        {
        }

        /// <summary>
        /// Tworzy serwis dla obiektów typu CarService i inicjalizuje kontekst z serwisu nadrzędnego.
        /// </summary>
        /// <param name="parentService">Serwis nadrzędny.</param>
        public CarServiceService(IService parentService)
            : base(parentService)
        {
        }

        #endregion Ctors

        #region Protected methods

        #region Overrides

        /// <summary>
        /// Inicjalizuje serwis.
        /// </summary>
        protected override void Initialize()
        {
            // TODO [ServiceTemplate] - optional: Zweryfikuj
            EntitySetName = "CarsDb.CarServices";
            EntityViewSetName = "CarsDb.CarServiceViewSet";
        }

        #endregion Overrides

        #endregion Protected methods

        #region Public methods

        #region Overrides

        /// <summary>
        /// Zmienia MergeOption na ObjectSet CarService.
        /// </summary>
        /// <param name="mergeOption">MergeOption.</param>
        public override void ChangeMergeOption(MergeOption mergeOption)
        {
            this.DB.CarServices.MergeOption = mergeOption;
        }

        #endregion Overrides

        /// <summary>
        /// Pobiera obiekt typu CarService po id.
        /// </summary>
        /// <param name="id">Identyfikator.</param>
        /// <returns>Obiekt typu CarService.</returns>
        public CarService GetCarServiceById(int id)
        {
            return this.GetObjectById(id);
        }

        /// <summary>
        /// Pobiera listę obiektów typu CarService.
        /// </summary>
        /// <returns>Lista obiektów typu CarService.</returns>
        public ICollection<CarService> GetCarServiceCollection()
        {
            return this.DB.CarServices.ToList();
        }

        /// <summary>
        /// Pobiera listę obiektów typu CarService.
        /// </summary>
        /// <returns>Lista obiektów typu CarService.</returns>
        public ICollection<CarServicesView> GetCarServicesViewCollection()
        {
            return this.DB.CarServicesViews.ToList();
        }
        /// <summary>
        /// Pobiera listę obiektów typu CarService.
        /// </summary>
        /// <param name="pageIndex">Indeks strony (indeksowanie od 0).</param>
        /// <param name="pageSize">Ilość elementów na stronie.</param>
        /// <param name="searchCriteria">Kryteria wyszukiwania.</param>
        /// <param name="sortExpression">Warunek sortowania.</param>
        /// <param name="allElementCount">Ilość wszystkich obiektów z uwzględnieniem filtrów.</param>
        /// <returns>Lista obiektów typu CarService.</returns>
        public ICollection<CarService> GetCarServiceCollection(int pageIndex, int pageSize, CarServiceSearchCriteria searchCriteria, string sortExpression, out int allElementCount)
        {
            searchCriteria = searchCriteria ?? new CarServiceSearchCriteria();

            allElementCount = this.DB.CarServices
                .AsExpandable()
                .Where(searchCriteria.GetFilterExpression())
                .Count();

            return this.DB.CarServices
                .AsExpandable()
                .Where(searchCriteria.GetFilterExpression())
                .SortBy(sortExpression.GetColumnName(), sortExpression.GetSortDirection())
                .GetPage(pageIndex, pageSize);
        }

        /// <summary>
        /// Pobiera listę obiektów typu CarService.
        /// </summary>
        /// <param name="pageIndex">Indeks strony (indeksowanie od 0).</param>
        /// <param name="pageSize">Ilość elementów na stronie.</param>
        /// <param name="searchCriteria">Kryteria wyszukiwania.</param>
        /// <param name="allElementCount">Ilość wszystkich obiektów z uwzględnieniem filtrów.</param>
        /// <returns>Lista obiektów typu CarService.</returns>
        public ICollection<CarService> GetCarServiceCollection(int pageIndex, int pageSize, CarServiceSearchCriteria searchCriteria, out int allElementCount)
        {
            return GetCarServiceCollection(pageIndex, pageSize, searchCriteria, string.Empty, out allElementCount);
        }

        /// <summary>
        /// Pobiera listę obiektów typu HandledCarProduct dla wybranego serwisu.
        /// </summary>
        /// <param name="carService">Szukany serwis.</param>
        public ICollection<HandledCarProduct> GetHandledCarProductCollection(CarService carService)
        {
            CarServiceSearchCriteria searchCriteria = new CarServiceSearchCriteria();
            return  this.DB.HandledCarProducts
                .AsExpandable()
                .Where(searchCriteria.GetFilterExpressionForHandledCarProduct(carService))
                .ToList();
        }

        /// <summary>
        /// Pobiera listę obiektów typu CarServicesCar dla wybranego serwisu.
        /// </summary>
        /// <param name="carService">Szukany serwis.</param>
        public ICollection<CarServicesCar> GetCarServicesCarCollection(CarService carService)
        {
            CarServiceSearchCriteria searchCriteria = new CarServiceSearchCriteria();

            return this.DB.CarServicesCars
                .AsExpandable()
                .Where(searchCriteria.GetFilterExpressionForCarServicesCar(carService))
                .ToList();

        }

        /// <summary>
        /// Dodaje nowy obiekt do HandledCarProduct.
        /// </summary>
        /// <param name="carService">Serwis do dodania.</param>
        /// <param name="carProduct">Samochód do dodania.</param>
        public void AddToHandledCarProductCollection(CarService carService, CarProduct carProduct)
        {
            HandledCarProduct handledCarProduct = HandledCarProduct.CreateHandledCarProduct(carService.Id, carProduct.Id, DateTime.Now, false);
            this.DB.HandledCarProducts.AddObject(handledCarProduct);
            this.DB.SaveChanges();
        }

        /// <summary>
        /// Dodaje nowy obiekt do CarServicesCar.
        /// </summary>
        /// <param name="carService">Serwis do dodania.</param>
        /// <param name="carProduct">Samochód do dodania.</param>
        public void AddToCarServicesCarCollection(CarService carService, CarProduct carProduct)
        {
            ICollection<CarServicesCar> carServicesCarsList = GetCarServicesCarCollection(carService);
            long Id = carServicesCarsList.OrderByDescending(x => x.Id).First().Id + 1;
            CarServicesCar carServicesCar = CarServicesCar.CreateCarServicesCar(Id, carService.Id, carProduct.Id);
            this.DB.CarServicesCars.AddObject(carServicesCar);
            this.DB.SaveChanges();
        }

        /// <summary>
        /// Wywołuje procedurę FixCarProduct.
        /// </summary>
        /// <param name="carService">Szukany serwis.</param>
        /// <param name="carProduct">Szukany samochód.</param>
        public void CallFixCarProductProcedure(CarService carService, CarProduct carProduct)
        {
            this.DB.FixCarProduct(carService.Id, carProduct.Id);
            this.DB.Refresh( RefreshMode.StoreWins, this.DB.HandledCarProducts);
        }
        #endregion Public methods
    }
}
