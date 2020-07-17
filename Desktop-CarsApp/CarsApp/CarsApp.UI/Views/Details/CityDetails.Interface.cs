using CarsApp.Data;
using LGBS.MVPFramework.UI;
using System.Collections.Generic;

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


		/// <summary>
		/// Lista encji.
		/// </summary>
		ICollection<Country> CountryCollection { get; set; }

		#endregion Properties
	}
}
