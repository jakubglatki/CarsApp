using System;
using System.Windows.Forms;
using CarsApp.UI.Managers;
using LGBS.MVPFramework.UI;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace CarsApp.UI
{
	public partial class MainForm : Form
	{
		#region Properties

		/// <summary>
		/// Bieżący widok.
		/// </summary>
		public IBaseWindowView CurrentView
		{
			get { return CarsViewManager.Manager.CurrentView; }
		}

		/// <summary>
		/// Manager widoków.
		/// </summary>
		public CarsViewManager ViewManager
		{
			get { return CarsViewManager.Manager; }
		}

		/// <summary>
		/// WindowsManager.
		/// </summary>
		public WindowsManager WindowsManager
		{
			get { return WindowsManager.Manager; }
		}

		#endregion Properties

		#region Ctrs

		/// <summary>
		/// Konstruktor.
		/// </summary>
		public MainForm()
		{
			InitializeComponent();

			WindowsManager.Manager.Initialize(this, this.mainDock);
			CarsViewFactory.InitializeFactory(new CarsViewFactory());

			// ustawienie początkowego stanu ribbon bar'a
			InitRibbonBar();

			// zdarzenia
			ViewManager.CurrentViewChanged += new EventHandler<ViewChangedEventArgs>(ViewManager_CurrentViewChanged);
			ViewManager.CurrentViewModeChanged += new EventHandler<ViewModeChangedEventArgs>(ViewManager_CurrentViewModeChanged);
			ViewManager.CurrentViewCurrentObjectChanged += new EventHandler<EventArgs>(ViewManager_CurrentViewCurrentObjectChanged);
		}

		#endregion Ctrs

		#region Private methods

		/// <summary>
		/// Ustawia stan początkowy ribbon bara.
		/// </summary>
		private void InitRibbonBar()
		{
			// ukrycie defaultowych menu itemów quick access toolbara
			mainRibbonBar.RibbonBarElement.QuickAccessToolBar.ToolbarPositionMenuItem.Visibility = ElementVisibility.Collapsed;
			mainRibbonBar.RibbonBarElement.QuickAccessToolBar.MinimizeRibonMenuItem.Visibility = ElementVisibility.Collapsed;

			// ukrycie całego quick access toolbara
			mainRibbonBar.RibbonBarElement.QuickAccessToolBar.Visibility = ElementVisibility.Collapsed;

			// ukrycie tab do zarządzania
			managementContextualTabGroup.Visibility = ElementVisibility.Collapsed;

			ResetRibbonBar();
		}

		/// <summary>
		/// Ustawia stan początkowy ribbon bara.
		/// </summary>
		private void ResetRibbonBar()
		{
			// usunięcie tabów z contextual tabów
			for (int i = 0; i < mainRibbonBar.ContextualTabGroups.Count; i++)
			{
				if (mainRibbonBar.ContextualTabGroups[i] is ContextualTabGroup)
				{
					ContextualTabGroup ctg = mainRibbonBar.ContextualTabGroups[i] as ContextualTabGroup;

					if (ctg != managementContextualTabGroup)
					{
						for (int ii = 0; ii < ctg.TabItems.Count; ii++)
						{
							ctg.TabItems.RemoveAt(ii);
							ii--;
						}
					}
				}
			}

			// usunięcie contextual tabów
			for (int i = 0; i < mainRibbonBar.ContextualTabGroups.Count; i++)
			{
				if (this.mainRibbonBar.ContextualTabGroups[i] != managementContextualTabGroup)
				{
					this.mainRibbonBar.ContextualTabGroups.RemoveAt(i);
					i--;
				}
			}

			// usunięcie tabów
			for (int i = 0; i < mainRibbonBar.CommandTabs.Count; i++)
			{
				if (this.mainRibbonBar.CommandTabs[i] != mainWindowsRibbonTab && this.mainRibbonBar.CommandTabs[i] != managementContextualTabGroup.TabItems[0])
				{
					this.mainRibbonBar.CommandTabs.RemoveAt(i);
					i--;
				}
			}

			mainWindowsRibbonTab.IsSelected = true;
		}

		/// <summary>
		/// Ustawia stan formatki odpowiedni dla okien typu lista.
		/// </summary>
		private void SetListWindowMode()
		{
			managementContextualTabGroup.Visibility = ElementVisibility.Visible;
			managementRibbonTab.IsSelected = true;

			SetListWindowButtons();
		}

		/// <summary>
		/// Ustawia dostępność przycisków dla okien typu lista.
		/// </summary>
		private void SetListWindowButtons()
		{
			bool currentObjectExists = CurrentView.CurrentObject != null;

			addButtonElement.Enabled = CurrentView.SupportsAddNew;
			editButtonElement.Enabled = CurrentView.SupportsEdit && currentObjectExists;
			deleteButtonElement.Enabled = CurrentView.SupportsDelete && currentObjectExists;
			showDetailsButtonElement.Enabled = CurrentView.SupportsShowDetails && currentObjectExists;
		}

		#endregion Private methods

		#region Event handlers

		/// <summary>
		/// Obsługa zmiany trybu pracy bieżącego okna.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">EventArgs.</param>
		private void ViewManager_CurrentViewModeChanged(object sender, ViewModeChangedEventArgs e)
		{
			if (CurrentView != null)
			{
			}
		}

		/// <summary>
		/// Obsługa zmiany bieżącego widoku
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">EventArgs.</param>
		private void ViewManager_CurrentViewChanged(object sender, ViewChangedEventArgs e)
		{
			if (e.CurrentView != null)
			{
				if (CurrentView is BaseListWindow)
				{
					ResetRibbonBar();


					SetListWindowMode();
				}
				else if (CurrentView is BaseDetailsWindow)
				{
					managementContextualTabGroup.Visibility = ElementVisibility.Collapsed;
					ResetRibbonBar();
				}
			}
			else
			{
				managementContextualTabGroup.Visibility = ElementVisibility.Collapsed;
				ResetRibbonBar();
			}
		}

		/// <summary>
		/// Obsługa zmiany bieżącego obiektu na oknie typu lista.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">EventArgs.</param>
		private void ViewManager_CurrentViewCurrentObjectChanged(object sender, EventArgs e)
		{
		}

        #endregion Event handlers

       
    }
}
