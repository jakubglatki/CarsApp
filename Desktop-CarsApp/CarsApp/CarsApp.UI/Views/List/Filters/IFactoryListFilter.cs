namespace CarsApp.UI
{
	/// <summary>
	/// Interfejs określający kryteria wyszukiwania dla widoku FactoryList.
	/// </summary>
	public interface IFactoryListFilter
	{
		#region Properties

		/// <summary>
		/// Nazwa.
		/// </summary>
		string FilterName { get; set; }

		/// <summary>
		/// Kod.
		/// </summary>
		string FilterCity { get; set; }

		/// <summary>
		/// Produkt.
		/// </summary>
		string FilterProduct { get; set; }

		#endregion Properties
	}
}
