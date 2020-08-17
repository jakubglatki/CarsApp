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
    /// Serwis dla obiektów typu CarServicesCar.
    /// </summary>
    public class CarServicesCarService : BaseGenericService<CarsDb, CarServicesCar>
    {
        #region Ctors

        /// <summary>
        /// Tworzy serwis dla obiektów typu CarServicesCar.
        /// </summary>
        public CarServicesCarService()
        {
        }

        /// <summary>
        /// Tworzy serwis dla obiektów typu CarServicesCar.
        /// </summary>
        /// <param name="contextDb">Określa, czy inicjalizować nowy kontekst.</param>
        public CarServicesCarService(CarsDb contextDb)
            : base(contextDb)
        {
        }

        /// <summary>
        /// Tworzy serwis dla obiektów typu CarServicesCar i inicjalizuje kontekst z serwisu nadrzędnego.
        /// </summary>
        /// <param name="parentService">Serwis nadrzędny.</param>
        public CarServicesCarService(IService parentService)
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
            EntitySetName = "CarsDb.CarServicesCars";
            EntityViewSetName = "CarsDb.CarServicesCarViewSet";
        }

        #endregion Overrides

        #endregion Protected methods

        #region Public methods

        #region Overrides

        /// <summary>
        /// Zmienia MergeOption na ObjectSet CarServicesCar.
        /// </summary>
        /// <param name="mergeOption">MergeOption.</param>
        public override void ChangeMergeOption(MergeOption mergeOption)
        {
            this.DB.CarServicesCars.MergeOption = mergeOption;
        }

        #endregion Overrides

        /// <summary>
        /// Pobiera obiekt typu CarServicesCar po id.
        /// </summary>
        /// <param name="id">Identyfikator.</param>
        /// <returns>Obiekt typu CarServicesCar.</returns>
        public CarServicesCar GetCarServicesCarById(int id)
        {
            return this.GetObjectById(id);
        }

        /// <summary>
        /// Pobiera listę obiektów typu CarServicesCar.
        /// </summary>
        /// <returns>Lista obiektów typu CarServicesCar.</returns>
        public ICollection<CarServicesCar> GetCarServicesCarCollection()
        {
            return this.DB.CarServicesCars.ToList();
        }

        /// <summary>
        /// Pobiera listę obiektów typu CarServicesCar.
        /// </summary>
        /// <param name="pageIndex">Indeks strony (indeksowanie od 0).</param>
        /// <param name="pageSize">Ilość elementów na stronie.</param>
        /// <param name="searchCriteria">Kryteria wyszukiwania.</param>
        /// <param name="sortExpression">Warunek sortowania.</param>
        /// <param name="allElementCount">Ilość wszystkich obiektów z uwzględnieniem filtrów.</param>
        /// <returns>Lista obiektów typu CarServicesCar.</returns>
        public ICollection<CarServicesCar> GetCarServicesCarCollection(int pageIndex, int pageSize, CarServicesCarSearchCriteria searchCriteria, string sortExpression, out int allElementCount)
        {
            searchCriteria = searchCriteria ?? new CarServicesCarSearchCriteria();

            allElementCount = this.DB.CarServicesCars
                .AsExpandable()
                .Where(searchCriteria.GetFilterExpression())
                .Count();

            return this.DB.CarServicesCars
                .AsExpandable()
                .Where(searchCriteria.GetFilterExpression())
                .SortBy(sortExpression.GetColumnName(), sortExpression.GetSortDirection())
                .GetPage(pageIndex, pageSize);
        }

        /// <summary>
        /// Pobiera listę obiektów typu CarServicesCar.
        /// </summary>
        /// <param name="pageIndex">Indeks strony (indeksowanie od 0).</param>
        /// <param name="pageSize">Ilość elementów na stronie.</param>
        /// <param name="searchCriteria">Kryteria wyszukiwania.</param>
        /// <param name="allElementCount">Ilość wszystkich obiektów z uwzględnieniem filtrów.</param>
        /// <returns>Lista obiektów typu CarServicesCar.</returns>
        public ICollection<CarServicesCar> GetCarServicesCarCollection(int pageIndex, int pageSize, CarServicesCarSearchCriteria searchCriteria, out int allElementCount)
        {
            return GetCarServicesCarCollection(pageIndex, pageSize, searchCriteria, string.Empty, out allElementCount);
        }


        /// <summary>
        /// Pobiera listę obiektów typu CarServicesCar dla określonego serwisu.
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
        #endregion Public methods
    }
}
