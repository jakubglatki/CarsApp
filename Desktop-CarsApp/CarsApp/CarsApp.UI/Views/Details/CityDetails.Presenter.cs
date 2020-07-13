using CarsApp.Services;
using LGBS.MVPFramework.UI;

namespace CarsApp.UI
{
	/// <summary>
	/// Prezenter widoku CityDetails.
	/// </summary>
	public class CityDetailsPresenter : BaseGenericPresenter<ICityDetails, INoDetailsView, CityService>
	{
		#region Ctors

		/// <summary>
		/// Tworzy presenter widoku CityList.
		/// </summary>
		/// <param name="view">Obsługiwany widok.</param>
		public CityDetailsPresenter(ICityDetails view)
			: base(view, true)
		{
		}

		#endregion Ctors

		#region Protected methods

		#region Overrides

		/// <summary>
		/// Pobiera dane i wyświetla w widoku.
		/// </summary>
		/// <param name="type">Tryb pokazywania danych.</param>
		protected override void LoadData(RefreshDataType type)
		{
			switch (type)
			{
				case RefreshDataType.Full:
					LoadData(RefreshDataType.DictionaryValues);
					LoadData(RefreshDataType.CurrentObjectData);
					break;
				case RefreshDataType.DictionaryValues:
					break;
				case RefreshDataType.CurrentObjectData:
					switch (View.Mode)
					{
						case ViewMode.New:
							View.CurrentCity = Service.AddNew();
							break;
						case ViewMode.Edit:
						case ViewMode.ReadOnly:
							View.CurrentCity = Service.GetObjectById(this.ObjectId);
							break;
						default:
							throw new ViewModeNotSupportedException();
					}

					break;

				default:
					throw new RefreshTypeNotSupportedException();
			}
		}

		/// <summary>
		/// Wykonuje dodatkowe (opcjonalne) operacje przez zapisem danych.
		/// </summary>
		protected override void PreSaveChanges()
		{
		}

		#endregion Overrides

		#endregion Protected methods
	}
}
