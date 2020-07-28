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
    /// Serwis dla obiektów typu CarServicesView.
    /// </summary>
    public class CarServicesViewService : BaseGenericService<CarsDb, CarServicesView>
    {
        #region Ctors

        /// <summary>
        /// Tworzy serwis dla obiektów typu CarServicesView.
        /// </summary>
        public CarServicesViewService()
        {
        }

        /// <summary>
        /// Tworzy serwis dla obiektów typu CarServicesView.
        /// </summary>
        /// <param name="contextDb">Określa, czy inicjalizować nowy kontekst.</param>
        public CarServicesViewService(CarsDb contextDb)
            : base(contextDb)
        {
        }

        /// <summary>
        /// Tworzy serwis dla obiektów typu CarServicesView i inicjalizuje kontekst z serwisu nadrzędnego.
        /// </summary>
        /// <param name="parentService">Serwis nadrzędny.</param>
        public CarServicesViewService(IService parentService)
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
            EntitySetName = "CarsDb.CarServicesViews";
            EntityViewSetName = "CarsDb.CarServicesViewViewSet";
        }

        #endregion Overrides

        #endregion Protected methods

        #region Public methods

        #region Overrides

        /// <summary>
        /// Zmienia MergeOption na ObjectSet CarServicesView.
        /// </summary>
        /// <param name="mergeOption">MergeOption.</param>
        public override void ChangeMergeOption(MergeOption mergeOption)
        {
            this.DB.CarServicesViews.MergeOption = mergeOption;
        }

        #endregion Overrides

        /// <summary>
        /// Pobiera obiekt typu CarServicesView po id.
        /// </summary>
        /// <param name="id">Identyfikator.</param>
        /// <returns>Obiekt typu CarServicesView.</returns>
        public CarServicesView GetCarServicesViewById(int id)
        {
            return this.GetObjectById(id);
        }

        /// <summary>
        /// Pobiera listę obiektów typu CarServicesView.
        /// </summary>
        /// <returns>Lista obiektów typu CarServicesView.</returns>
        public ICollection<CarServicesView> GetCarServicesViewCollection()
        {
            return this.DB.CarServicesViews.ToList();
        }

        /// <summary>
        /// Pobiera listę obiektów typu CarServicesView.
        /// </summary>
        /// <param name="pageIndex">Indeks strony (indeksowanie od 0).</param>
        /// <param name="pageSize">Ilość elementów na stronie.</param>
        /// <param name="searchCriteria">Kryteria wyszukiwania.</param>
        /// <param name="sortExpression">Warunek sortowania.</param>
        /// <param name="allElementCount">Ilość wszystkich obiektów z uwzględnieniem filtrów.</param>
        /// <returns>Lista obiektów typu CarServicesView.</returns>
        public ICollection<CarServicesView> GetCarServicesViewCollection(int pageIndex, int pageSize, CarServicesViewSearchCriteria searchCriteria, string sortExpression, out int allElementCount)
        {
            searchCriteria = searchCriteria ?? new CarServicesViewSearchCriteria();

            allElementCount = this.DB.CarServicesViews
                .AsExpandable()
                .Where(searchCriteria.GetFilterExpression())
                .Count();

            return this.DB.CarServicesViews
                .AsExpandable()
                .Where(searchCriteria.GetFilterExpression())
                .SortBy(sortExpression.GetColumnName(), sortExpression.GetSortDirection())
                .GetPage(pageIndex, pageSize);
        }

        /// <summary>
        /// Pobiera listę obiektów typu CarServicesView.
        /// </summary>
        /// <param name="pageIndex">Indeks strony (indeksowanie od 0).</param>
        /// <param name="pageSize">Ilość elementów na stronie.</param>
        /// <param name="searchCriteria">Kryteria wyszukiwania.</param>
        /// <param name="allElementCount">Ilość wszystkich obiektów z uwzględnieniem filtrów.</param>
        /// <returns>Lista obiektów typu CarServicesView.</returns>
        public ICollection<CarServicesView> GetCarServicesViewCollection(int pageIndex, int pageSize, CarServicesViewSearchCriteria searchCriteria, out int allElementCount)
        {
            return GetCarServicesViewCollection(pageIndex, pageSize, searchCriteria, string.Empty, out allElementCount);
        }

        #endregion Public methods
    }
}
