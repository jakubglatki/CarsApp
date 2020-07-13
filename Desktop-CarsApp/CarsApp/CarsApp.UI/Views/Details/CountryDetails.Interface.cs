using CarsApp.Data;
using LGBS.MVPFramework.UI;

namespace CarsApp.UI
{
	/// <summary>
	/// Interfejs widoku CountryDetails.
	/// </summary>
	public interface ICountryDetails : IBaseWindowView
	{
		#region Properties

		/// <summary>
		/// Aktualnie wyświetlana / edytowana encja.
		/// </summary>
		Country CurrentCountry { get; set; }

		#endregion Properties
	}
}
