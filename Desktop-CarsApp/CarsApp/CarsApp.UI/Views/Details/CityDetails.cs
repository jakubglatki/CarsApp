using System;
using CarsApp.Data;
using CarsApp.UI.Properties;
using LGBS.MVPFramework.Data;
using LGBS.MVPFramework.UI;

namespace CarsApp.UI
{
	/// <summary>
	/// Widok szczegółówy obiektu typu City.
	/// </summary>
	public partial class CityDetails : BaseDetailsWindow, ICityDetails
	{
		#region Consts

		/// <summary>
		/// Nazwa interfejsu widoku.
		/// </summary>
		public const string InterfaceName = "ICityDetails";

		/// <summary>
		/// Tryby pracy widoku <see cref="CityDetails"/>.
		/// </summary>
		public class WorkModes : BaseWorkModes
		{
		}

		#endregion Consts

		#region Properties

		#region Common Properties

		/// <summary>
		/// Bieżący obiekt wyświetlany w widoku.
		/// </summary>
		public override IObjectWithId CurrentObject
		{
			get { return this.CurrentCity; }
		}

		/// <summary>
		/// Prezenter widoku.
		/// </summary>
		public CityDetailsPresenter Presenter
		{
			get { return BasePresenter as CityDetailsPresenter; }
			set { BasePresenter = value; }
		}

		#endregion Common Properties

		#region View Specific

		/// <summary>
		/// Bieżący obiekt wyświetlany w widoku.
		/// </summary>
		public City CurrentCity
		{
			get { return CityBindingSource.DataSource as City; }
			set { CityBindingSource.DataSource = value; }
		}

		#endregion View Specific

		#endregion Properties

		#region Ctors

		/// <summary>
		/// Tworzy widok CityDetails.
		/// </summary>
		public CityDetails()
			: base(null)
		{
		}

		/// <summary>
		/// Tworzy widok CityDetails.
		/// </summary>
		/// <param name="parentView">Widok nadrzędny.</param>
		public CityDetails(IBaseView parentView)
			: base(parentView)
		{
			InitializeComponent();
			AfterInitializeComponent();

			if (!VSDesignMode)
				this.Presenter = new CityDetailsPresenter(this);
		}

		#endregion Ctors

		#region Private methods

		/// <summary>
		/// Inicjalizuje walidatory.
		/// </summary>
		private void InitializeValidators()
		{
			nameTextBox.InitializeValidator(errorProvider);
			codeTextBox.InitializeValidator(errorProvider);
		}

		/// <summary>
		/// Inicjalizuje ribbon bar.
		/// </summary>
		private void InitializeRibbonBar()
		{
			// zablokowanie minimalizacji ribbon bar'a
			mainRadRibbonBar.CollapseRibbonOnTabDoubleClick = false;
			// zablokowanie pojawianie się key map po naciśnięciu Alt
			mainRadRibbonBar.EnableKeyMap = false;
		}

		/// <summary>
		/// Przygotowuje okno do pracy w trybie New.
		/// </summary>
		private void SetWindowStateForNewMode()
		{
			// tytuł okna
			this.Text = Resources.CaptionAddCity;

			// ukrycie tab'a Zarządzanie
			managementRibbonTab.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
			// pokazanie tab'a Edycja
			editRibbonTab.Visibility = Telerik.WinControls.ElementVisibility.Visible;
			// ukrycie grupy z przyciskiem Usuń
			objectDetailsActionsRadRibbonBarGroup.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
			// zaznaczenie tab'a Edycja
			editRibbonTab.IsSelected = true;

			// ukrycie przycisku Zamknij
			closeButton.Visible = false;

			// włączenie wszystkich kontrolek w tryb edycji
			EnableControls(true);
		}

		/// <summary>
		/// Przygotowuje okno do pracy w trybie Edit.
		/// </summary>
		private void SetWindowStateForEditMode()
		{
			// tytuł okna
			this.Text = Resources.CaptionEditCity;

			// ukrycie tab'a Zarządzanie
			managementRibbonTab.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
			// pokazanie tab'a Edycja
			editRibbonTab.Visibility = Telerik.WinControls.ElementVisibility.Visible;
			// pokazanie grupy z przyciskiem Usuń
			objectDetailsActionsRadRibbonBarGroup.Visibility = Telerik.WinControls.ElementVisibility.Visible;
			// zaznaczenie tab'a Edycja
			editRibbonTab.IsSelected = true;

			// ustawienie dostępności btn Usuń
			if (ParentView != null)
				deleteObjectRadButtonElement.Enabled = ParentView.SupportsDelete;

			// ukrycie przycisku Zamknij
			closeButton.Visible = false;

			// włączenie wszystkich kontrolek w tryb edycji
			EnableControls(true);
		}

		/// <summary>
		/// Przygotowuje okno do pracy w trybie ReadOnly.
		/// </summary>
		private void SetWindowStateForReadOnlyMode()
		{
			// tytuł okna
			this.Text = Resources.CaptionCityDetails;

			// pokazanie tab'a Zarządzanie
			managementRibbonTab.Visibility = Telerik.WinControls.ElementVisibility.Visible;
			// ukrycie tab'a Edycja
			editRibbonTab.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
			// zaznaczenie tab'a Zarządzanie
			managementRibbonTab.IsSelected = true;

			// ustawienie dostępności btn Usuń i Edytuj
			if (ParentView != null)
			{
				deleteRadButtonElement.Enabled = ParentView.SupportsDelete;
				editRadButtonElement.Enabled = ParentView.SupportsEdit;
			}

			// pokazanie przycisku Zamknij
			closeButton.Visible = true;

			// ustawienie wszystkich kontrolek tylko do odczytu
			EnableControls(false);
		}

		/// <summary>
		/// Aktywuje / deaktywuje wszystkie kontrolki na formatce.
		/// </summary>
		/// <param name="enable">True - wszystkie kontrolki są edytowalne.</param>
		private void EnableControls(bool enable)
		{
			nameTextBox.ReadOnly = !enable;
			codeTextBox.ReadOnly = !enable;
		}

		#endregion Private methods

		#region Protected methods

		#region Overrides

		/// <summary>
		/// Inicjalizuje kontrolki.
		/// </summary>
		protected override void InitializeControls()
		{
			this.MainBindingSource = CityBindingSource;

			// inicjalizacja walidatorów
			InitializeValidators();

			// inicjalizacja ribbon bar'a
			InitializeRibbonBar();
		}

		#endregion Overrides

		#endregion Protected methods

		#region Public methods

		#region Overrides

		/// <summary>
		/// Zwraca nazwę interfejsu widoku.
		/// </summary>
		/// <returns>Nazwa interfejsu widoku.</returns>
		public override string GetInterfaceName()
		{
			return InterfaceName;
		}

		/// <summary>
		/// Zmienia tryb widoku.
		/// </summary>
		/// <param name="mode">Tryb widoku.</param>
		public override void ChangeMode(ViewMode mode)
		{
			switch (mode)
			{
				case ViewMode.New:
					SetWindowStateForNewMode();
					break;
				case ViewMode.Edit:
					SetWindowStateForEditMode();
					break;
				case ViewMode.ReadOnly:
					SetWindowStateForReadOnlyMode();
					break;
				default:
					throw new ViewModeNotSupportedException();
			}

			base.ChangeMode(mode);
		}

		#endregion Overrides

		#endregion Public methods

		#region Handlers

		#region From buttons

		#region Zatwierdzanie ribbon bar group

		/// <summary>
		/// Obsługa naciśnięcia btn OK.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">EventArgs.</param>
		private void okRadButtonElement_Click(object sender, EventArgs e)
		{
			if (CurrentCity != null)
			{
				AcceptAndClose();
			}
		}

		/// <summary>
		/// Obsługa naciśnięcia btn Anuluj.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">EventArgs.</param>
		private void cancelRadButtonElement_Click(object sender, EventArgs e)
		{
			base.CancelAndClose();
		}

		#endregion Zatwierdzanie ribbon bar group

		#region Schowek ribbon bar group

		/// <summary>
		/// Obsługa naciśnięcia btn Wklej.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">EventArgs.</param>
		private void pasteRadButtonElement_Click(object sender, EventArgs e)
		{
			base.Paste();
		}

		/// <summary>
		/// Obsługa naciśnięcia btn Wytnij.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">EventArgs.</param>
		private void cutRadButtonElement_Click(object sender, EventArgs e)
		{
			base.Cut();
		}

		/// <summary>
		/// Obsługa naciśnięcia btn Kopiuj.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">EventArgs.</param>
		private void copyRadButtonElement_Click(object sender, EventArgs e)
		{
			base.Copy();
		}

		#endregion Schowek ribbon bar group

		#region Akcje ribbon bar group

		/// <summary>
		/// Obsługa naciśnięcia btn Edytuj.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">EventArgs.</param>
		private void editRadButtonElement_Click(object sender, EventArgs e)
		{
			ChangeMode(ViewMode.Edit);
		}

		/// <summary>
		/// Obsługa naciśnięcia btn Usuń.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">EventArgs.</param>
		private void deleteRadButtonElement_Click(object sender, EventArgs e)
		{
			if (CurrentCity != null)
			{
				base.Delete();
			}
		}

		#endregion Akcje ribbon bar group

		#endregion From buttons

		#region From view

		/// <summary>
		/// Obsługa zdarzenia Shown.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">EventArgs.</param>
		private void CityDetails_Shown(object sender, EventArgs e)
		{
			if (Mode == ViewMode.New)
				nameTextBox.Focus();
		}

		#endregion From view

		#endregion Handlers
	}
}

