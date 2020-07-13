using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using LGBS.MVPFramework.Services;
using LinqKit;
using CarsApp.Data;

namespace CarsApp.Services
{
	/// <summary>
	/// Serwis dla obiektów typu Country.
	/// </summary>
	public class CityService : BaseGenericService<CarsDb, City>
	{
		#region Ctors

		/// <summary>
		/// Tworzy serwis dla obiektów typu City.
		/// </summary>
		public CityService()
		{
		}

		/// <summary>
		/// Tworzy serwis dla obiektów typu City.
		/// </summary>
		/// <param name="contextDb">Określa, czy inicjalizować nowy kontekst.</param>
		public CityService(CarsDb contextDb)
			: base(contextDb)
		{
		}

		/// <summary>
		/// Tworzy serwis dla obiektów typu City i inicjalizuje kontekst z serwisu nadrzędnego.
		/// </summary>
		/// <param name="parentService">Serwis nadrzędny.</param>
		public CityService(IService parentService)
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
			EntitySetName = "CarsDb.Cities";
			EntityViewSetName = "CarsDb.CityViewSet";
		}

		#endregion Overrides

		#endregion Protected methods

		#region Public methods

		#region Overrides

		/// <summary>
		/// Zmienia MergeOption na ObjectSet City.
		/// </summary>
		/// <param name="mergeOption">MergeOption.</param>
		public override void ChangeMergeOption(MergeOption mergeOption)
		{
			this.DB.Cities.MergeOption = mergeOption;
		}

		#endregion Overrides

		/// <summary>
		/// Pobiera obiekt typu City po id.
		/// </summary>
		/// <param name="id">Identyfikator.</param>
		/// <returns>Obiekt typu City.</returns>
		public City GetCityById(int id)
		{
			return this.GetObjectById(id);
		}

		/// <summary>
		/// Pobiera listę obiektów typu City.
		/// </summary>
		/// <returns>Lista obiektów typu City.</returns>
		public ICollection<City> GetCityCollection()
		{
			return this.DB.Cities.ToList();
		}

		/// <summary>
		/// Pobiera listę obiektów typu City.
		/// </summary>
		/// <param name="pageIndex">Indeks strony (indeksowanie od 0).</param>
		/// <param name="pageSize">Ilość elementów na stronie.</param>
		/// <param name="searchCriteria">Kryteria wyszukiwania.</param>
		/// <param name="sortExpression">Warunek sortowania.</param>
		/// <param name="allElementCount">Ilość wszystkich obiektów z uwzględnieniem filtrów.</param>
		/// <returns>Lista obiektów typu City.</returns>
		public ICollection<City> GetCityCollection(int pageIndex, int pageSize, CitySearchCriteria searchCriteria, string sortExpression, out int allElementCount)
		{
			searchCriteria = searchCriteria ?? new CitySearchCriteria();

			allElementCount = this.DB.Cities
				.AsExpandable()
				.Where(searchCriteria.GetFilterExpression())
				.Count();

			return this.DB.Cities
				.AsExpandable()
				.Where(searchCriteria.GetFilterExpression())
				.SortBy(sortExpression.GetColumnName(), sortExpression.GetSortDirection())
				.GetPage(pageIndex, pageSize);
		}

		/// <summary>
		/// Pobiera listę obiektów typu City.
		/// </summary>
		/// <param name="pageIndex">Indeks strony (indeksowanie od 0).</param>
		/// <param name="pageSize">Ilość elementów na stronie.</param>
		/// <param name="searchCriteria">Kryteria wyszukiwania.</param>
		/// <param name="allElementCount">Ilość wszystkich obiektów z uwzględnieniem filtrów.</param>
		/// <returns>Lista obiektów typu City.</returns>
		public ICollection<City> GetCityCollection(int pageIndex, int pageSize, CitySearchCriteria searchCriteria, out int allElementCount)
		{
			return GetCityCollection(pageIndex, pageSize, searchCriteria, string.Empty, out allElementCount);
		}

		#endregion Public methods
	}
}
