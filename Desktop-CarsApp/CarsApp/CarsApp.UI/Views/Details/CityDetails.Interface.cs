using CarsApp.Data;
using LGBS.MVPFramework.UI;

namespace CarsApp.UI
{
	/// <summary>
	/// Interfejs widoku CountryDetails.
	/// </summary>
	public interface ICityDetails : IBaseWindowView
	{
		#region Properties

		/// <summary>
		/// Aktualnie wyświetlana / edytowana encja.
		/// </summary>
		City CurrentCity { get; set; }


        #endregion Properties
    }
}
