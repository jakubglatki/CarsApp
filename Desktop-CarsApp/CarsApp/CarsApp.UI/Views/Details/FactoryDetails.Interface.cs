using CarsApp.Data;
using LGBS.MVPFramework.UI;

namespace CarsApp.UI
{
	/// <summary>
	/// Interfejs widoku FactoryDetails.
	/// </summary>
	public interface IFactoryDetails : IBaseWindowView
	{
		#region Properties

		/// <summary>
		/// Aktualnie wyświetlana / edytowana encja.
		/// </summary>
		Factory CurrentFactory { get; set; }

		#endregion Properties
	}
}
