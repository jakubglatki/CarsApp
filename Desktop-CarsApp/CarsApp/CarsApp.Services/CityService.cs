using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using LGBS.MVPFramework.Services;
using LinqKit;
using CarsApp.Data;
using System.Data.Entity;

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
                .Include("DB.Countries")
                .Where(b => b.CountryId.Equals(b.Country.Id))
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


		/// <summary>
		/// Pobiera listę wszystkich obiektów typu Country.
		/// </summary>
		/// <returns>Lista obiektów typu Country.</returns>
		public ICollection<Country> GetAllCountries()
		{
			return this.DB.Countries
				.ToList();

		}

		public void ChangeCitiesCountry(City city, string name, ICollection<Country> countries)
		{
			List<Country> listOfCountries = countries.ToList();
			for (int i = 0; i < countries.Count; i++)
			{
				if (name == listOfCountries[i].Name)
					city.Country = listOfCountries[i];
			}

		}

		public void ChangeCitiesName(City city, string name)
        {
			city.Name = name;
        }

		public void AddNewCity(string cityName, string countryName, ICollection<Country> countries)
		{
			List<Country> listOfCountries = countries.ToList();
			List<City> cityList = this.GetCityCollection().ToList();
			long Id = cityList[cityList.Count - 1].Id;
			for (int i = 0; i < countries.Count; i++)
			{
				if (Id+1 == cityList[i].Id)
					break;
				if (countryName == listOfCountries[i].Name)
				{
					City.CreateCity(Id + 1, cityName, listOfCountries[i].Id);
				}
			}
		}

		#endregion Public methods
	}
}
