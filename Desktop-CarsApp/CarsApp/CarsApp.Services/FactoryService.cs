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
    /// Serwis dla obiektów typu Factory.
    /// </summary>
    public class FactoryService : BaseGenericService<CarsDb, Factory>
    {
        #region Ctors

        /// <summary>
        /// Tworzy serwis dla obiektów typu Factory.
        /// </summary>
        public FactoryService()
        {
        }

        /// <summary>
        /// Tworzy serwis dla obiektów typu Factory.
        /// </summary>
        /// <param name="contextDb">Określa, czy inicjalizować nowy kontekst.</param>
        public FactoryService(CarsDb contextDb)
            : base(contextDb)
        {
        }

        /// <summary>
        /// Tworzy serwis dla obiektów typu Factory i inicjalizuje kontekst z serwisu nadrzędnego.
        /// </summary>
        /// <param name="parentService">Serwis nadrzędny.</param>
        public FactoryService(IService parentService)
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
            EntitySetName = "CarsDb.Factories";
            EntityViewSetName = "CarsDb.FactoryViewSet";
        }

        #endregion Overrides

        #endregion Protected methods

        #region Public methods

        #region Overrides

        /// <summary>
        /// Zmienia MergeOption na ObjectSet Factory.
        /// </summary>
        /// <param name="mergeOption">MergeOption.</param>
        public override void ChangeMergeOption(MergeOption mergeOption)
        {
            this.DB.Factories.MergeOption = mergeOption;
        }

        #endregion Overrides

        /// <summary>
        /// Pobiera obiekt typu Factory po id.
        /// </summary>
        /// <param name="id">Identyfikator.</param>
        /// <returns>Obiekt typu Factory.</returns>
        public Factory GetFactoryById(int id)
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
        /// Pobiera listę obiektów typu City.
        /// </summary>
        /// <returns>Lista obiektów typu Factory.</returns>
        public ICollection<City> GetCityCollection()
        {
            return this.DB.Cities.ToList();
        }
        /// <summary>
        /// Pobiera listę obiektów typu Factory.
        /// </summary>
        /// <param name="pageIndex">Indeks strony (indeksowanie od 0).</param>
        /// <param name="pageSize">Ilość elementów na stronie.</param>
        /// <param name="searchCriteria">Kryteria wyszukiwania.</param>
        /// <param name="sortExpression">Warunek sortowania.</param>
        /// <param name="allElementCount">Ilość wszystkich obiektów z uwzględnieniem filtrów.</param>
        /// <returns>Lista obiektów typu Factory.</returns>
        public ICollection<Factory> GetFactoryCollection(int pageIndex, int pageSize, FactorySearchCriteria searchCriteria, string sortExpression, out int allElementCount)
        {
            searchCriteria = searchCriteria ?? new FactorySearchCriteria();

            allElementCount = this.DB.Factories
                .AsExpandable()
                .Where(searchCriteria.GetFilterExpression())
                .Count();

            return this.DB.Factories
                .AsExpandable()
                .Where(searchCriteria.GetFilterExpression())
                .SortBy(sortExpression.GetColumnName(), sortExpression.GetSortDirection())
                .GetPage(pageIndex, pageSize);
        }

        /// <summary>
        /// Pobiera listę obiektów typu Factory.
        /// </summary>
        /// <param name="pageIndex">Indeks strony (indeksowanie od 0).</param>
        /// <param name="pageSize">Ilość elementów na stronie.</param>
        /// <param name="searchCriteria">Kryteria wyszukiwania.</param>
        /// <param name="allElementCount">Ilość wszystkich obiektów z uwzględnieniem filtrów.</param>
        /// <returns>Lista obiektów typu Factory.</returns>
        public ICollection<Factory> GetFactoryCollection(int pageIndex, int pageSize, FactorySearchCriteria searchCriteria, out int allElementCount)
        {
            return GetFactoryCollection(pageIndex, pageSize, searchCriteria, string.Empty, out allElementCount);
        }

        #endregion Public methods
    }
}
