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
    /// Serwis dla obiektów typu Manufacture.
    /// </summary>
    public class ManufactureService : BaseGenericService<CarsDb, Manufacture>
    {
        #region Ctors

        /// <summary>
        /// Tworzy serwis dla obiektów typu Manufacture.
        /// </summary>
        public ManufactureService()
        {
        }

        /// <summary>
        /// Tworzy serwis dla obiektów typu Manufacture.
        /// </summary>
        /// <param name="contextDb">Określa, czy inicjalizować nowy kontekst.</param>
        public ManufactureService(CarsDb contextDb)
            : base(contextDb)
        {
        }

        /// <summary>
        /// Tworzy serwis dla obiektów typu Manufacture i inicjalizuje kontekst z serwisu nadrzędnego.
        /// </summary>
        /// <param name="parentService">Serwis nadrzędny.</param>
        public ManufactureService(IService parentService)
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
            EntitySetName = "CarsDb.Manufactures";
            EntityViewSetName = "CarsDb.ManufactureViewSet";
        }

        #endregion Overrides

        #endregion Protected methods

        #region Public methods

        #region Overrides

        /// <summary>
        /// Zmienia MergeOption na ObjectSet Manufacture.
        /// </summary>
        /// <param name="mergeOption">MergeOption.</param>
        public override void ChangeMergeOption(MergeOption mergeOption)
        {
            this.DB.Manufactures.MergeOption = mergeOption;
        }

        #endregion Overrides

        /// <summary>
        /// Pobiera obiekt typu Manufacture po id.
        /// </summary>
        /// <param name="id">Identyfikator.</param>
        /// <returns>Obiekt typu Manufacture.</returns>
        public Manufacture GetManufactureById(int id)
        {
            return this.GetObjectById(id);
        }

        /// <summary>
        /// Pobiera listę obiektów typu Manufacture.
        /// </summary>
        /// <returns>Lista obiektów typu Manufacture.</returns>
        public ICollection<Manufacture> GetManufactureCollection()
        {
            return this.DB.Manufactures.ToList();
        }

        /// <summary>
        /// Pobiera listę obiektów typu Manufacture.
        /// </summary>
        /// <param name="pageIndex">Indeks strony (indeksowanie od 0).</param>
        /// <param name="pageSize">Ilość elementów na stronie.</param>
        /// <param name="searchCriteria">Kryteria wyszukiwania.</param>
        /// <param name="sortExpression">Warunek sortowania.</param>
        /// <param name="allElementCount">Ilość wszystkich obiektów z uwzględnieniem filtrów.</param>
        /// <returns>Lista obiektów typu Manufacture.</returns>
        public ICollection<Manufacture> GetManufactureCollection(int pageIndex, int pageSize, ManufactureSearchCriteria searchCriteria, string sortExpression, out int allElementCount)
        {
            searchCriteria = searchCriteria ?? new ManufactureSearchCriteria();

            allElementCount = this.DB.Manufactures
                .AsExpandable()
                .Where(searchCriteria.GetFilterExpression())
                .Count();

            return this.DB.Manufactures
                .AsExpandable()
                .Where(searchCriteria.GetFilterExpression())
                .SortBy(sortExpression.GetColumnName(), sortExpression.GetSortDirection())
                .GetPage(pageIndex, pageSize);
        }

        /// <summary>
        /// Pobiera listę obiektów typu Manufacture.
        /// </summary>
        /// <param name="pageIndex">Indeks strony (indeksowanie od 0).</param>
        /// <param name="pageSize">Ilość elementów na stronie.</param>
        /// <param name="searchCriteria">Kryteria wyszukiwania.</param>
        /// <param name="allElementCount">Ilość wszystkich obiektów z uwzględnieniem filtrów.</param>
        /// <returns>Lista obiektów typu Manufacture.</returns>
        public ICollection<Manufacture> GetManufactureCollection(int pageIndex, int pageSize, ManufactureSearchCriteria searchCriteria, out int allElementCount)
        {
            return GetManufactureCollection(pageIndex, pageSize, searchCriteria, string.Empty, out allElementCount);
        }

        #endregion Public methods
    }
}
