namespace CarsApp.UI
{
	/// <summary>
	/// Interfejs określający kryteria wyszukiwania dla widoku CountryList.
	/// </summary>
	public interface ICountryListFilter
	{
		#region Properties

		/// <summary>
		/// Nazwa.
		/// </summary>
		string FilterName { get; set; }

		/// <summary>
		/// Kod.
		/// </summary>
		string FilterCode { get; set; }

		#endregion Properties
	}
}
