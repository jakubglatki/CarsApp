namespace CarsApp.UI
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainDock = new LGBS.MVPFramework.Controls.LGBSDock();
            this.mainDocumentContainer = new Telerik.WinControls.UI.Docking.DocumentContainer();
            this.mainRibbonBar = new LGBS.MVPFramework.Controls.LGBSRibbonBar();
            this.mainWindowsRibbonTab = new Telerik.WinControls.UI.RibbonTab();
            this.windowsRibbonBarGroup = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.countriesButtonElement = new Telerik.WinControls.UI.RadButtonElement();
            this.citiesButtonElement = new Telerik.WinControls.UI.RadButtonElement();
            this.factoriesButtonElement = new Telerik.WinControls.UI.RadButtonElement();
            this.servicesButtonElement = new Telerik.WinControls.UI.RadButtonElement();
            this.managementRibbonTab = new Telerik.WinControls.UI.RibbonTab();
            this.actionsRibbonBarGroup = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.addButtonElement = new Telerik.WinControls.UI.RadButtonElement();
            this.deleteButtonElement = new Telerik.WinControls.UI.RadButtonElement();
            this.editButtonElement = new Telerik.WinControls.UI.RadButtonElement();
            this.showDetailsButtonElement = new Telerik.WinControls.UI.RadButtonElement();
            this.searchRibbonBarGroup = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.searchButtonElement = new Telerik.WinControls.UI.RadButtonElement();
            this.clearFilterButtonElement = new Telerik.WinControls.UI.RadButtonElement();
            this.managementContextualTabGroup = new Telerik.WinControls.UI.ContextualTabGroup();
            this.radRibbonBarButtonGroup2 = new Telerik.WinControls.UI.RadRibbonBarButtonGroup();
            this.radButtonElement1 = new Telerik.WinControls.UI.RadButtonElement();
            this.radButtonElement2 = new Telerik.WinControls.UI.RadButtonElement();
            ((System.ComponentModel.ISupportInitialize)(this.mainDock)).BeginInit();
            this.mainDock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainDocumentContainer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonBar)).BeginInit();
            this.SuspendLayout();
            // 
            // mainDock
            // 
            this.mainDock.AutoDetectMdiChildren = true;
            this.mainDock.Controls.Add(this.mainDocumentContainer);
            this.mainDock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainDock.DocumentManager.DocumentInsertOrder = Telerik.WinControls.UI.Docking.DockWindowInsertOrder.InFront;
            this.mainDock.IsCleanUpTarget = true;
            this.mainDock.Location = new System.Drawing.Point(0, 157);
            this.mainDock.MainDocumentContainer = this.mainDocumentContainer;
            this.mainDock.Name = "mainDock";
            this.mainDock.Padding = new System.Windows.Forms.Padding(5);
            // 
            // 
            // 
            this.mainDock.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.mainDock.RootElement.Padding = new System.Windows.Forms.Padding(5);
            this.mainDock.ShowDocumentCloseButton = true;
            this.mainDock.ShowToolCloseButton = true;
            this.mainDock.Size = new System.Drawing.Size(849, 312);
            this.mainDock.SplitterWidth = 4;
            this.mainDock.TabIndex = 1;
            this.mainDock.TabStop = false;
            // 
            // mainDocumentContainer
            // 
            this.mainDocumentContainer.Location = new System.Drawing.Point(5, 5);
            this.mainDocumentContainer.Name = "mainDocumentContainer";
            this.mainDocumentContainer.Padding = new System.Windows.Forms.Padding(5);
            // 
            // 
            // 
            this.mainDocumentContainer.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.mainDocumentContainer.RootElement.Padding = new System.Windows.Forms.Padding(5);
            this.mainDocumentContainer.Size = new System.Drawing.Size(839, 302);
            this.mainDocumentContainer.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill;
            this.mainDocumentContainer.SplitterWidth = 4;
            this.mainDocumentContainer.TabIndex = 0;
            this.mainDocumentContainer.TabStop = false;
            // 
            // mainRibbonBar
            // 
            this.mainRibbonBar.ActivityBorder = null;
            this.mainRibbonBar.AllowOnEnterStyling = false;
            this.mainRibbonBar.AutoSize = true;
            this.mainRibbonBar.CloseButton = false;
            this.mainRibbonBar.CommandTabs.AddRange(new Telerik.WinControls.RadItem[] {
            this.mainWindowsRibbonTab,
            this.managementRibbonTab});
            this.mainRibbonBar.ContextualTabGroups.AddRange(new Telerik.WinControls.RadItem[] {
            this.managementContextualTabGroup});
            this.mainRibbonBar.Dock = System.Windows.Forms.DockStyle.Top;
            // 
            // 
            // 
            this.mainRibbonBar.ExitButton.AccessibleDescription = "Exit";
            this.mainRibbonBar.ExitButton.AccessibleName = "Exit";
            // 
            // 
            // 
            this.mainRibbonBar.ExitButton.ButtonElement.AccessibleDescription = "Exit";
            this.mainRibbonBar.ExitButton.ButtonElement.AccessibleName = "Exit";
            this.mainRibbonBar.ExitButton.Text = "Exit";
            this.mainRibbonBar.Location = new System.Drawing.Point(0, 0);
            this.mainRibbonBar.MaximizeButton = false;
            this.mainRibbonBar.MinimizeButton = false;
            this.mainRibbonBar.Name = "mainRibbonBar";
            // 
            // 
            // 
            this.mainRibbonBar.OptionsButton.AccessibleDescription = "Options";
            this.mainRibbonBar.OptionsButton.AccessibleName = "Options";
            // 
            // 
            // 
            this.mainRibbonBar.OptionsButton.ButtonElement.AccessibleDescription = "Options";
            this.mainRibbonBar.OptionsButton.ButtonElement.AccessibleName = "Options";
            this.mainRibbonBar.OptionsButton.Text = "Options";
            this.mainRibbonBar.ShowExpandButton = false;
            this.mainRibbonBar.Size = new System.Drawing.Size(849, 157);
            this.mainRibbonBar.StartButtonImage = ((System.Drawing.Image)(resources.GetObject("mainRibbonBar.StartButtonImage")));
            this.mainRibbonBar.TabIndex = 0;
            this.mainRibbonBar.Text = "CarsApp";
            // 
            // mainWindowsRibbonTab
            // 
            this.mainWindowsRibbonTab.AccessibleDescription = "Okna główne";
            this.mainWindowsRibbonTab.AccessibleName = "Okna główne";
            this.mainWindowsRibbonTab.Class = "RibbonTab";
            this.mainWindowsRibbonTab.IsSelected = true;
            this.mainWindowsRibbonTab.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.windowsRibbonBarGroup});
            this.mainWindowsRibbonTab.Name = "mainWindowsRibbonTab";
            this.mainWindowsRibbonTab.Text = "Okna główne";
            this.mainWindowsRibbonTab.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // windowsRibbonBarGroup
            // 
            this.windowsRibbonBarGroup.AccessibleDescription = "Okna";
            this.windowsRibbonBarGroup.AccessibleName = "Okna";
            this.windowsRibbonBarGroup.AutoSize = true;
            this.windowsRibbonBarGroup.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.countriesButtonElement,
            this.citiesButtonElement,
            this.factoriesButtonElement,
            this.servicesButtonElement});
            this.windowsRibbonBarGroup.Name = "windowsRibbonBarGroup";
            this.windowsRibbonBarGroup.Text = "Okna";
            this.windowsRibbonBarGroup.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // countriesButtonElement
            // 
            this.countriesButtonElement.AccessibleDescription = "Firmy";
            this.countriesButtonElement.AccessibleName = "Firmy";
            this.countriesButtonElement.Class = "ButtonElement";
            this.countriesButtonElement.Image = global::CarsApp.UI.Properties.Resources.ImgCompany;
            this.countriesButtonElement.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.countriesButtonElement.Name = "countriesButtonElement";
            this.countriesButtonElement.Text = "Kraje";
            this.countriesButtonElement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.countriesButtonElement.ToolTipText = "Kraje";
            this.countriesButtonElement.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.countriesButtonElement.Click += new System.EventHandler(this.countriesButtonElement_Click);
            // 
            // citiesButtonElement
            // 
            this.citiesButtonElement.AccessibleDescription = "Firmy";
            this.citiesButtonElement.AccessibleName = "Firmy";
            this.citiesButtonElement.Class = "ButtonElement";
            this.citiesButtonElement.Image = global::CarsApp.UI.Properties.Resources.ImgCompany;
            this.citiesButtonElement.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.citiesButtonElement.Name = "citiesButtonElement";
            this.citiesButtonElement.Text = "Miasta";
            this.citiesButtonElement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.citiesButtonElement.ToolTipText = "Miasta";
            this.citiesButtonElement.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.citiesButtonElement.Click += new System.EventHandler(this.citiesButtonElement_Click);
            // 
            // factoriesButtonElement
            // 
            this.factoriesButtonElement.AccessibleDescription = "Fabryki";
            this.factoriesButtonElement.AccessibleName = "Fabryki";
            this.factoriesButtonElement.Class = "ButtonElement";
            this.factoriesButtonElement.Image = global::CarsApp.UI.Properties.Resources.ImgCompany;
            this.factoriesButtonElement.ImageAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.factoriesButtonElement.Name = "factoriesButtonElement";
            this.factoriesButtonElement.Text = "Fabryki";
            this.factoriesButtonElement.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.factoriesButtonElement.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.factoriesButtonElement.Click += new System.EventHandler(this.factoriesButtonElement_Click);
            // 
            // servicesButtonElement
            // 
            this.servicesButtonElement.AccessibleDescription = "Serwisy";
            this.servicesButtonElement.AccessibleName = "Serwisy";
            this.servicesButtonElement.Class = "ButtonElement";
            this.servicesButtonElement.Image = global::CarsApp.UI.Properties.Resources.ImgCompany;
            this.servicesButtonElement.ImageAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.servicesButtonElement.Name = "servicesButtonElement";
            this.servicesButtonElement.Text = "Serwisy";
            this.servicesButtonElement.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.servicesButtonElement.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.servicesButtonElement.Click += new System.EventHandler(this.servicesButtonElement_Click);
            // 
            // managementRibbonTab
            // 
            this.managementRibbonTab.AccessibleDescription = "Zarządzanie";
            this.managementRibbonTab.AccessibleName = "Zarządzanie";
            this.managementRibbonTab.Class = "RibbonTab";
            this.managementRibbonTab.IsSelected = false;
            this.managementRibbonTab.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.actionsRibbonBarGroup,
            this.searchRibbonBarGroup});
            this.managementRibbonTab.Name = "managementRibbonTab";
            this.managementRibbonTab.Text = "Zarządzanie";
            this.managementRibbonTab.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // actionsRibbonBarGroup
            // 
            this.actionsRibbonBarGroup.AccessibleDescription = "Akcje";
            this.actionsRibbonBarGroup.AccessibleName = "Akcje";
            this.actionsRibbonBarGroup.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.addButtonElement,
            this.deleteButtonElement,
            this.editButtonElement,
            this.showDetailsButtonElement});
            this.actionsRibbonBarGroup.Name = "actionsRibbonBarGroup";
            this.actionsRibbonBarGroup.Text = "Akcje";
            this.actionsRibbonBarGroup.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // addButtonElement
            // 
            this.addButtonElement.AccessibleDescription = "Dodaj";
            this.addButtonElement.AccessibleName = "Dodaj";
            this.addButtonElement.Class = "RibbonBarButtonElement";
            this.addButtonElement.Image = global::CarsApp.UI.Properties.Resources.ImgAdd;
            this.addButtonElement.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.addButtonElement.Name = "addButtonElement";
            this.addButtonElement.Text = "Dodaj";
            this.addButtonElement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.addButtonElement.ToolTipText = "Dodawanie nowego elementu";
            this.addButtonElement.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.addButtonElement.Click += new System.EventHandler(this.addButtonElement_Click);
            // 
            // deleteButtonElement
            // 
            this.deleteButtonElement.AccessibleDescription = "Usuń";
            this.deleteButtonElement.AccessibleName = "Usuń";
            this.deleteButtonElement.Class = "RibbonBarButtonElement";
            this.deleteButtonElement.Image = global::CarsApp.UI.Properties.Resources.ImgDelete;
            this.deleteButtonElement.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.deleteButtonElement.Name = "deleteButtonElement";
            this.deleteButtonElement.Text = "Usuń";
            this.deleteButtonElement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.deleteButtonElement.ToolTipText = "Usuwanie elementu";
            this.deleteButtonElement.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.deleteButtonElement.Click += new System.EventHandler(this.deleteButtonElement_Click);
            // 
            // editButtonElement
            // 
            this.editButtonElement.AccessibleDescription = "Edytuj";
            this.editButtonElement.AccessibleName = "Edytuj";
            this.editButtonElement.Class = "RibbonBarButtonElement";
            this.editButtonElement.Image = global::CarsApp.UI.Properties.Resources.ImgEdit;
            this.editButtonElement.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.editButtonElement.Name = "editButtonElement";
            this.editButtonElement.Text = "Edytuj";
            this.editButtonElement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.editButtonElement.ToolTipText = "Edycja elementu";
            this.editButtonElement.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.editButtonElement.Click += new System.EventHandler(this.editButtonElement_Click);
            // 
            // showDetailsButtonElement
            // 
            this.showDetailsButtonElement.AccessibleDescription = "Wyświetl";
            this.showDetailsButtonElement.AccessibleName = "Wyświetl";
            this.showDetailsButtonElement.Class = "RibbonBarButtonElement";
            this.showDetailsButtonElement.Image = global::CarsApp.UI.Properties.Resources.ImgDetails;
            this.showDetailsButtonElement.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.showDetailsButtonElement.Name = "showDetailsButtonElement";
            this.showDetailsButtonElement.Text = "Wyświetl";
            this.showDetailsButtonElement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.showDetailsButtonElement.ToolTipText = "Wyświetlanie danych szczegółowych elementu";
            this.showDetailsButtonElement.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.showDetailsButtonElement.Click += new System.EventHandler(this.showDetailsButtonElement_Click);
            // 
            // searchRibbonBarGroup
            // 
            this.searchRibbonBarGroup.AccessibleDescription = "Wyszukiwanie";
            this.searchRibbonBarGroup.AccessibleName = "Wyszukiwanie";
            this.searchRibbonBarGroup.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.searchButtonElement,
            this.clearFilterButtonElement});
            this.searchRibbonBarGroup.Name = "searchRibbonBarGroup";
            this.searchRibbonBarGroup.Text = "Wyszukiwanie";
            this.searchRibbonBarGroup.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // searchButtonElement
            // 
            this.searchButtonElement.AccessibleDescription = "Szukaj";
            this.searchButtonElement.AccessibleName = "Szukaj";
            this.searchButtonElement.Class = "RibbonBarButtonElement";
            this.searchButtonElement.Image = global::CarsApp.UI.Properties.Resources.ImgSearch;
            this.searchButtonElement.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.searchButtonElement.Name = "searchButtonElement";
            this.searchButtonElement.Text = "Szukaj";
            this.searchButtonElement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.searchButtonElement.ToolTipText = "Wyszukiwanie elementów";
            this.searchButtonElement.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.searchButtonElement.Click += new System.EventHandler(this.searchButtonElement_Click);
            // 
            // clearFilterButtonElement
            // 
            this.clearFilterButtonElement.AccessibleDescription = "Wyczyść";
            this.clearFilterButtonElement.AccessibleName = "Wyczyść";
            this.clearFilterButtonElement.Class = "RibbonBarButtonElement";
            this.clearFilterButtonElement.Image = global::CarsApp.UI.Properties.Resources.ImgClear;
            this.clearFilterButtonElement.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.clearFilterButtonElement.Name = "clearFilterButtonElement";
            this.clearFilterButtonElement.Text = "Wyczyść";
            this.clearFilterButtonElement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.clearFilterButtonElement.ToolTipText = "Wyczyszczenie filtra";
            this.clearFilterButtonElement.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.clearFilterButtonElement.Click += new System.EventHandler(this.clearFilterButtonElement_Click);
            // 
            // managementContextualTabGroup
            // 
            this.managementContextualTabGroup.AccessibleDescription = "Zarządzanie";
            this.managementContextualTabGroup.AccessibleName = "Zarządzanie";
            this.managementContextualTabGroup.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(235)))), ((int)(((byte)(219)))), ((int)(((byte)(130)))));
            this.managementContextualTabGroup.Name = "managementContextualTabGroup";
            this.managementContextualTabGroup.TabItems.AddRange(new Telerik.WinControls.RadItem[] {
            this.managementRibbonTab});
            this.managementContextualTabGroup.Text = "Zarządzanie";
            this.managementContextualTabGroup.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radRibbonBarButtonGroup2
            // 
            this.radRibbonBarButtonGroup2.Name = "radRibbonBarButtonGroup2";
            this.radRibbonBarButtonGroup2.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radButtonElement1
            // 
            this.radButtonElement1.AccessibleDescription = "Fabryki";
            this.radButtonElement1.AccessibleName = "Fabryki";
            this.radButtonElement1.Class = "ButtonElement";
            this.radButtonElement1.Image = global::CarsApp.UI.Properties.Resources.ImgCompany;
            this.radButtonElement1.ImageAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.radButtonElement1.Name = "radButtonElement1";
            this.radButtonElement1.Text = "Fabryki";
            this.radButtonElement1.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.radButtonElement1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radButtonElement2
            // 
            this.radButtonElement2.AccessibleDescription = "Fabryki";
            this.radButtonElement2.AccessibleName = "Fabryki";
            this.radButtonElement2.Class = "ButtonElement";
            this.radButtonElement2.Image = global::CarsApp.UI.Properties.Resources.ImgCompany;
            this.radButtonElement2.ImageAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.radButtonElement2.Name = "radButtonElement2";
            this.radButtonElement2.Text = "Fabryki";
            this.radButtonElement2.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.radButtonElement2.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 469);
            this.Controls.Add(this.mainDock);
            this.Controls.Add(this.mainRibbonBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CarsApp";
            ((System.ComponentModel.ISupportInitialize)(this.mainDock)).EndInit();
            this.mainDock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainDocumentContainer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private LGBS.MVPFramework.Controls.LGBSRibbonBar mainRibbonBar;
		private LGBS.MVPFramework.Controls.LGBSDock mainDock;
		private Telerik.WinControls.UI.Docking.DocumentContainer mainDocumentContainer;
		private Telerik.WinControls.UI.RibbonTab managementRibbonTab;
		private Telerik.WinControls.UI.RadRibbonBarGroup actionsRibbonBarGroup;
		private Telerik.WinControls.UI.RadRibbonBarGroup searchRibbonBarGroup;
		private Telerik.WinControls.UI.RadButtonElement addButtonElement;
		private Telerik.WinControls.UI.RadButtonElement deleteButtonElement;
		private Telerik.WinControls.UI.RadButtonElement editButtonElement;
		private Telerik.WinControls.UI.RadButtonElement showDetailsButtonElement;
		private Telerik.WinControls.UI.RadButtonElement searchButtonElement;
		private Telerik.WinControls.UI.RadButtonElement clearFilterButtonElement;
		private Telerik.WinControls.UI.RibbonTab mainWindowsRibbonTab;
		private Telerik.WinControls.UI.RadRibbonBarGroup windowsRibbonBarGroup;
		private Telerik.WinControls.UI.RadButtonElement countriesButtonElement;
        private Telerik.WinControls.UI.RadButtonElement citiesButtonElement;
        private Telerik.WinControls.UI.ContextualTabGroup managementContextualTabGroup;
        private Telerik.WinControls.UI.RadRibbonBarButtonGroup radRibbonBarButtonGroup2;
        private Telerik.WinControls.UI.RadButtonElement factoriesButtonElement;
        private Telerik.WinControls.UI.RadButtonElement servicesButtonElement;
        private Telerik.WinControls.UI.RadButtonElement radButtonElement1;
        private Telerik.WinControls.UI.RadButtonElement radButtonElement2;
    }
}