using CarsApp.Data;

namespace CarsApp.UI
{
	/// <summary>
	/// Interfejs określający kryteria wyszukiwania dla widoku CountryList.
	/// </summary>
	public interface ICityListFilter
	{
		#region Properties

		/// <summary>
		/// Nazwa.
		/// </summary>
		string FilterName { get; set; }

		/// <summary>
		/// Nazwa kraju
		/// </summary>
		Country FilterCountry{ get; set; }
		#endregion Properties
	}
}
