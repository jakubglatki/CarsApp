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
    /// Serwis dla obiektów typu CarProduct.
    /// </summary>
    public class CarProductService : BaseGenericService<CarsDb, CarProduct>
    {
        #region Ctors

        /// <summary>
        /// Tworzy serwis dla obiektów typu CarProduct.
        /// </summary>
        public CarProductService()
        {
        }

        /// <summary>
        /// Tworzy serwis dla obiektów typu CarProduct.
        /// </summary>
        /// <param name="contextDb">Określa, czy inicjalizować nowy kontekst.</param>
        public CarProductService(CarsDb contextDb)
            : base(contextDb)
        {
        }

        /// <summary>
        /// Tworzy serwis dla obiektów typu CarProduct i inicjalizuje kontekst z serwisu nadrzędnego.
        /// </summary>
        /// <param name="parentService">Serwis nadrzędny.</param>
        public CarProductService(IService parentService)
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
            EntitySetName = "CarsDb.CarProducts";
            EntityViewSetName = "CarsDb.CarProductViewSet";
        }

        #endregion Overrides

        #endregion Protected methods

        #region Public methods

        #region Overrides

        /// <summary>
        /// Zmienia MergeOption na ObjectSet CarProduct.
        /// </summary>
        /// <param name="mergeOption">MergeOption.</param>
        public override void ChangeMergeOption(MergeOption mergeOption)
        {
            this.DB.CarProducts.MergeOption = mergeOption;
        }

        #endregion Overrides

        /// <summary>
        /// Pobiera obiekt typu CarProduct po id.
        /// </summary>
        /// <param name="id">Identyfikator.</param>
        /// <returns>Obiekt typu CarProduct.</returns>
        public CarProduct GetCarProductById(int id)
        {
            return this.GetObjectById(id);
        }

        /// <summary>
        /// Pobiera listę obiektów typu Factory.
        /// </summary>
        /// <returns>Lista obiektów typu Factory.</returns>
        public ICollection<Factory> GetFactoryCollection()
        {
            return this.DB.Factories.ToList();
        }

        /// <summary>
        /// Pobiera listę obiektów typu CarModel.
        /// </summary>
        /// <returns>Lista obiektów typu CarModel.</returns>
        public ICollection<CarModel> GetCarModelCollection()
        {
            return this.DB.CarModels.ToList();
        }

        /// <summary>
        /// Pobiera listę obiektów typu CarProduct.
        /// </summary>
        /// <returns>Lista obiektów typu CarProduct.</returns>
        public ICollection<CarProduct> GetCarProductCollection()
        {
            return this.DB.CarProducts.ToList();
        }

        /// <summary>
        /// Pobiera listę obiektów typu CarProduct.
        /// </summary>
        /// <param name="pageIndex">Indeks strony (indeksowanie od 0).</param>
        /// <param name="pageSize">Ilość elementów na stronie.</param>
        /// <param name="searchCriteria">Kryteria wyszukiwania.</param>
        /// <param name="sortExpression">Warunek sortowania.</param>
        /// <param name="allElementCount">Ilość wszystkich obiektów z uwzględnieniem filtrów.</param>
        /// <returns>Lista obiektów typu CarProduct.</returns>
        public ICollection<CarProduct> GetCarProductCollection(int pageIndex, int pageSize, CarProductSearchCriteria searchCriteria, string sortExpression, out int allElementCount)
        {
            searchCriteria = searchCriteria ?? new CarProductSearchCriteria();

            allElementCount = this.DB.CarProducts
                .AsExpandable()
                .Where(searchCriteria.GetFilterExpression())
                .Count();

            return this.DB.CarProducts
                .AsExpandable()
                .Where(searchCriteria.GetFilterExpression())
                .SortBy(sortExpression.GetColumnName(), sortExpression.GetSortDirection())
                .GetPage(pageIndex, pageSize);
        }

        /// <summary>
        /// Pobiera listę obiektów typu CarProduct.
        /// </summary>
        /// <param name="pageIndex">Indeks strony (indeksowanie od 0).</param>
        /// <param name="pageSize">Ilość elementów na stronie.</param>
        /// <param name="searchCriteria">Kryteria wyszukiwania.</param>
        /// <param name="allElementCount">Ilość wszystkich obiektów z uwzględnieniem filtrów.</param>
        /// <returns>Lista obiektów typu CarProduct.</returns>
        public ICollection<CarProduct> GetCarProductCollection(int pageIndex, int pageSize, CarProductSearchCriteria searchCriteria, out int allElementCount)
        {
            return GetCarProductCollection(pageIndex, pageSize, searchCriteria, string.Empty, out allElementCount);
        }

        #endregion Public methods
    }
}
