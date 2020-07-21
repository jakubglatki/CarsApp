using System;
using LGBS.MVPFramework.UI;

namespace CarsApp.UI
{
	/// <summary>
	/// Fabryka widoków.
	/// </summary>
	public class CarsViewFactory : BaseViewFactory
	{
		#region Public methods

		/// <summary>
		/// Tworzy instancję widoku.
		/// </summary>
		/// <typeparam name="VT">Typ widoku.</typeparam>
		/// <param name="parentView">Widok rodzic.</param>
		/// <returns>Instancja widoku.</returns>
		public override VT CreateViewInstance<VT>(IBaseView parentView)
		{
			Type viewType = typeof(VT);

			switch (viewType.Name)
			{
				case CountryList.InterfaceName:
					return new CountryList(parentView) as VT;
				case CountryDetails.InterfaceName:
					return new CountryDetails(parentView) as VT;
				case CityList.InterfaceName:
					return new CityList(parentView) as VT;
				case CityDetails.InterfaceName:
					return new CityDetails(parentView) as VT;
				case FactoryList.InterfaceName:
					return new FactoryList(parentView) as VT;
				default:
					throw new ArgumentException("Nieobsługiwany typ widoku");
			}
		}
       

            #endregion Public methods
        }
}
