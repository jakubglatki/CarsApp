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
	public class CountryService : BaseGenericService<CarsDb, Country>
	{
		#region Ctors

		/// <summary>
		/// Tworzy serwis dla obiektów typu Country.
		/// </summary>
		public CountryService()
		{
		}

		/// <summary>
		/// Tworzy serwis dla obiektów typu Country.
		/// </summary>
		/// <param name="contextDb">Określa, czy inicjalizować nowy kontekst.</param>
		public CountryService(CarsDb contextDb)
			: base(contextDb)
		{
		}

		/// <summary>
		/// Tworzy serwis dla obiektów typu Country i inicjalizuje kontekst z serwisu nadrzędnego.
		/// </summary>
		/// <param name="parentService">Serwis nadrzędny.</param>
		public CountryService(IService parentService)
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
			EntitySetName = "CarsDb.Countries";
			EntityViewSetName = "CarsDb.CountryViewSet";
		}

		#endregion Overrides

		#endregion Protected methods

		#region Public methods

		#region Overrides

		/// <summary>
		/// Zmienia MergeOption na ObjectSet Country.
		/// </summary>
		/// <param name="mergeOption">MergeOption.</param>
		public override void ChangeMergeOption(MergeOption mergeOption)
		{
			this.DB.Countries.MergeOption = mergeOption;
		}

		#endregion Overrides

		/// <summary>
		/// Pobiera obiekt typu Country po id.
		/// </summary>
		/// <param name="id">Identyfikator.</param>
		/// <returns>Obiekt typu Country.</returns>
		public Country GetCountryById(int id)
		{
			return this.GetObjectById(id);
		}

		/// <summary>
		/// Pobiera listę obiektów typu Country.
		/// </summary>
		/// <returns>Lista obiektów typu Country.</returns>
		public ICollection<Country> GetCountryCollection()
		{
			return this.DB.Countries.ToList();
		}

		/// <summary>
		/// Pobiera listę obiektów typu Country.
		/// </summary>
		/// <param name="pageIndex">Indeks strony (indeksowanie od 0).</param>
		/// <param name="pageSize">Ilość elementów na stronie.</param>
		/// <param name="searchCriteria">Kryteria wyszukiwania.</param>
		/// <param name="sortExpression">Warunek sortowania.</param>
		/// <param name="allElementCount">Ilość wszystkich obiektów z uwzględnieniem filtrów.</param>
		/// <returns>Lista obiektów typu Country.</returns>
		public ICollection<Country> GetCountryCollection(int pageIndex, int pageSize, CountrySearchCriteria searchCriteria, string sortExpression, out int allElementCount)
		{
			searchCriteria = searchCriteria ?? new CountrySearchCriteria();

			allElementCount = this.DB.Countries
				.AsExpandable()
				.Where(searchCriteria.GetFilterExpression())
				.Count();

			return this.DB.Countries
				.AsExpandable()
				.Where(searchCriteria.GetFilterExpression())
				.SortBy(sortExpression.GetColumnName(), sortExpression.GetSortDirection())
				.GetPage(pageIndex, pageSize);
		}

		/// <summary>
		/// Pobiera listę obiektów typu Country.
		/// </summary>
		/// <param name="pageIndex">Indeks strony (indeksowanie od 0).</param>
		/// <param name="pageSize">Ilość elementów na stronie.</param>
		/// <param name="searchCriteria">Kryteria wyszukiwania.</param>
		/// <param name="allElementCount">Ilość wszystkich obiektów z uwzględnieniem filtrów.</param>
		/// <returns>Lista obiektów typu Country.</returns>
		public ICollection<Country> GetCountryCollection(int pageIndex, int pageSize, CountrySearchCriteria searchCriteria, out int allElementCount)
		{
			return GetCountryCollection(pageIndex, pageSize, searchCriteria, string.Empty, out allElementCount);
		}

		#endregion Public methods
	}
}
