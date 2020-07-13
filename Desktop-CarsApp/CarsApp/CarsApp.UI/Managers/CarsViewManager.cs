using LGBS.MVPFramework.UI;

namespace CarsApp.UI.Managers
{
	public class CarsViewManager : ViewManager
	{
		#region Properties

		/// <summary>
		/// Instancja managera widoków.
		/// </summary>
		public static new CarsViewManager Manager
		{
			get
			{
				if (manager == null)
					manager = new CarsViewManager();

				return manager as CarsViewManager;
			}
		}

		#endregion Properties
	}
}
