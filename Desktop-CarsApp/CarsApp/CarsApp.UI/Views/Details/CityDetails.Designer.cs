using System.Drawing;

namespace CarsApp.UI
{
    partial class CityDetails
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CityDetails));
            this.CityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainGroupBox = new LGBS.MVPFramework.Controls.LGBSGroupBox();
            this.codeLabel = new LGBS.MVPFramework.Controls.LGBSLabel();
            this.nameLabel = new LGBS.MVPFramework.Controls.LGBSLabel();
            this.nameTextBox = new LGBS.MVPFramework.Controls.LGBSTextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.mainPanel = new System.Windows.Forms.Panel();
            this.downPanel = new System.Windows.Forms.Panel();
            this.closeButton = new LGBS.MVPFramework.Controls.LGBSButton();
            this.mainRadRibbonBar = new Telerik.WinControls.UI.RadRibbonBar();
            this.managementRibbonTab = new Telerik.WinControls.UI.RibbonTab();
            this.actionsRadRibbonBarGroup = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.editRadButtonElement = new Telerik.WinControls.UI.RadButtonElement();
            this.deleteRadButtonElement = new Telerik.WinControls.UI.RadButtonElement();
            this.editRibbonTab = new Telerik.WinControls.UI.RibbonTab();
            this.commitRadRibbonBarGroup = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.okRadButtonElement = new Telerik.WinControls.UI.RadButtonElement();
            this.cancelRadButtonElement = new Telerik.WinControls.UI.RadButtonElement();
            this.clipboardRadRibbonBarGroup = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.pasteRadButtonElement = new Telerik.WinControls.UI.RadButtonElement();
            this.clipboardRadRibbonBarButtonGroup = new Telerik.WinControls.UI.RadRibbonBarButtonGroup();
            this.cutRadButtonElement = new Telerik.WinControls.UI.RadButtonElement();
            this.copyRadButtonElement = new Telerik.WinControls.UI.RadButtonElement();
            this.objectDetailsActionsRadRibbonBarGroup = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.deleteObjectRadButtonElement = new Telerik.WinControls.UI.RadButtonElement();
            ((System.ComponentModel.ISupportInitialize)(this.CityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainGroupBox)).BeginInit();
            this.mainGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codeLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.mainPanel.SuspendLayout();
            this.downPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainRadRibbonBar)).BeginInit();
            this.SuspendLayout();
            // 
            // CityBindingSource
            // 
            this.CityBindingSource.DataSource = typeof(CarsApp.Data.City);
            // 
            // mainGroupBox
            // 
            this.mainGroupBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.mainGroupBox.Controls.Add(this.codeLabel);
            this.mainGroupBox.Controls.Add(this.nameLabel);
            this.mainGroupBox.Controls.Add(this.nameTextBox);
            this.mainGroupBox.FooterImageIndex = -1;
            this.mainGroupBox.FooterImageKey = "";
            this.mainGroupBox.HeaderImageIndex = -1;
            this.mainGroupBox.HeaderImageKey = "";
            this.mainGroupBox.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.mainGroupBox.HeaderText = "Kraj";
            this.mainGroupBox.Location = new System.Drawing.Point(3, 3);
            this.mainGroupBox.Name = "mainGroupBox";
            this.mainGroupBox.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            // 
            // 
            // 
            this.mainGroupBox.RootElement.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.mainGroupBox.Size = new System.Drawing.Size(514, 89);
            this.mainGroupBox.TabIndex = 0;
            this.mainGroupBox.Text = "Kraj";
            // 
            // codeLabel
            // 
            this.codeLabel.BackColor = System.Drawing.Color.Transparent;
            this.codeLabel.Location = new System.Drawing.Point(13, 49);
            this.codeLabel.Name = "codeLabel";
            this.codeLabel.Size = new System.Drawing.Size(29, 18);
            this.codeLabel.TabIndex = 2;
            this.codeLabel.Text = "Kod:";
            // 
            // nameLabel
            // 
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.Location = new System.Drawing.Point(13, 23);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(42, 18);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Nazwa:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CityBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(87, 23);
            this.nameTextBox.Message = "Nazwa miasta nie może być pusta";
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.RegularExpressionString = null;
            this.nameTextBox.Size = new System.Drawing.Size(343, 20);
            this.nameTextBox.TabIndex = 1;
            this.nameTextBox.TabStop = false;
            this.nameTextBox.ValidationType = LGBS.MVPFramework.Controls.TextBoxDataValidator.TextBoxValidationType.NotNullValidation;
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.mainGroupBox);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 124);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(520, 127);
            this.mainPanel.TabIndex = 1;
            // 
            // downPanel
            // 
            this.downPanel.Controls.Add(this.closeButton);
            this.downPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.downPanel.Location = new System.Drawing.Point(0, 219);
            this.downPanel.Name = "downPanel";
            this.downPanel.Size = new System.Drawing.Size(520, 32);
            this.downPanel.TabIndex = 2;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(433, 3);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 24);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "Zamknij";
            this.closeButton.Click += new System.EventHandler(this.cancelRadButtonElement_Click);
            // 
            // mainRadRibbonBar
            // 
            this.mainRadRibbonBar.AutoSize = true;
            this.mainRadRibbonBar.CommandTabs.AddRange(new Telerik.WinControls.RadItem[] {
            this.managementRibbonTab,
            this.editRibbonTab});
            this.mainRadRibbonBar.Dock = System.Windows.Forms.DockStyle.Top;
            // 
            // 
            // 
            this.mainRadRibbonBar.ExitButton.AccessibleDescription = "Exit";
            this.mainRadRibbonBar.ExitButton.AccessibleName = "Exit";
            // 
            // 
            // 
            this.mainRadRibbonBar.ExitButton.ButtonElement.AccessibleDescription = "Exit";
            this.mainRadRibbonBar.ExitButton.ButtonElement.AccessibleName = "Exit";
            this.mainRadRibbonBar.ExitButton.Text = "Exit";
            this.mainRadRibbonBar.Location = new System.Drawing.Point(0, 0);
            this.mainRadRibbonBar.Name = "mainRadRibbonBar";
            // 
            // 
            // 
            this.mainRadRibbonBar.OptionsButton.AccessibleDescription = "Options";
            this.mainRadRibbonBar.OptionsButton.AccessibleName = "Options";
            // 
            // 
            // 
            this.mainRadRibbonBar.OptionsButton.ButtonElement.AccessibleDescription = "Options";
            this.mainRadRibbonBar.OptionsButton.ButtonElement.AccessibleName = "Options";
            this.mainRadRibbonBar.OptionsButton.Text = "Options";
            this.mainRadRibbonBar.QuickAccessToolBarHeight = 0;
            this.mainRadRibbonBar.ShowExpandButton = false;
            this.mainRadRibbonBar.Size = new System.Drawing.Size(520, 124);
            this.mainRadRibbonBar.StartButtonImage = ((System.Drawing.Image)(resources.GetObject("mainRadRibbonBar.StartButtonImage")));
            this.mainRadRibbonBar.TabIndex = 0;
            ((Telerik.WinControls.UI.RadRibbonBarElement)(this.mainRadRibbonBar.GetChildAt(0))).QuickAccessMenuHeight = 0;
            ((Telerik.WinControls.UI.RadRibbonBarElement)(this.mainRadRibbonBar.GetChildAt(0))).Text = "";
            ((Telerik.WinControls.UI.RadRibbonBarElement)(this.mainRadRibbonBar.GetChildAt(0))).AutoSize = true;
            ((Telerik.WinControls.UI.RadRibbonBarElement)(this.mainRadRibbonBar.GetChildAt(0))).ShouldPaint = false;
            ((Telerik.WinControls.UI.RadQuickAccessToolBar)(this.mainRadRibbonBar.GetChildAt(0).GetChildAt(0))).Enabled = true;
            ((Telerik.WinControls.UI.RadQuickAccessToolBar)(this.mainRadRibbonBar.GetChildAt(0).GetChildAt(0))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.UI.RadRibbonBarCaption)(this.mainRadRibbonBar.GetChildAt(0).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.UI.RadApplicationMenuButtonElement)(this.mainRadRibbonBar.GetChildAt(0).GetChildAt(3))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            // 
            // managementRibbonTab
            // 
            this.managementRibbonTab.AccessibleDescription = "Zarządzanie";
            this.managementRibbonTab.AccessibleName = "Zarządzanie";
            this.managementRibbonTab.Alignment = System.Drawing.ContentAlignment.BottomLeft;
            this.managementRibbonTab.Class = "RibbonTab";
            this.managementRibbonTab.IsSelected = false;
            this.managementRibbonTab.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.actionsRadRibbonBarGroup});
            this.managementRibbonTab.Name = "managementRibbonTab";
            this.managementRibbonTab.StretchHorizontally = false;
            this.managementRibbonTab.Text = "Zarządzanie";
            this.managementRibbonTab.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // actionsRadRibbonBarGroup
            // 
            this.actionsRadRibbonBarGroup.AccessibleDescription = "Akcje";
            this.actionsRadRibbonBarGroup.AccessibleName = "Akcje";
            this.actionsRadRibbonBarGroup.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.editRadButtonElement,
            this.deleteRadButtonElement});
            this.actionsRadRibbonBarGroup.Name = "actionsRadRibbonBarGroup";
            this.actionsRadRibbonBarGroup.Text = "Akcje";
            this.actionsRadRibbonBarGroup.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // editRadButtonElement
            // 
            this.editRadButtonElement.AccessibleDescription = "Edytuj";
            this.editRadButtonElement.AccessibleName = "Edytuj";
            this.editRadButtonElement.Class = "RibbonBarButtonElement";
            this.editRadButtonElement.Image = global::CarsApp.UI.Properties.Resources.ImgEdit;
            this.editRadButtonElement.ImageAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.editRadButtonElement.Name = "editRadButtonElement";
            this.editRadButtonElement.Text = "Edytuj";
            this.editRadButtonElement.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.editRadButtonElement.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.editRadButtonElement.Click += new System.EventHandler(this.editRadButtonElement_Click);
            // 
            // deleteRadButtonElement
            // 
            this.deleteRadButtonElement.AccessibleDescription = "Usuń";
            this.deleteRadButtonElement.AccessibleName = "Usuń";
            this.deleteRadButtonElement.Class = "RibbonBarButtonElement";
            this.deleteRadButtonElement.Image = global::CarsApp.UI.Properties.Resources.ImgDelete;
            this.deleteRadButtonElement.ImageAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.deleteRadButtonElement.Name = "deleteRadButtonElement";
            this.deleteRadButtonElement.Text = "Usuń";
            this.deleteRadButtonElement.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.deleteRadButtonElement.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.deleteRadButtonElement.Click += new System.EventHandler(this.deleteRadButtonElement_Click);
            // 
            // editRibbonTab
            // 
            this.editRibbonTab.AccessibleDescription = "Edycja";
            this.editRibbonTab.AccessibleName = "Edycja";
            this.editRibbonTab.Alignment = System.Drawing.ContentAlignment.BottomLeft;
            this.editRibbonTab.Class = "RibbonTab";
            this.editRibbonTab.IsSelected = true;
            this.editRibbonTab.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.commitRadRibbonBarGroup,
            this.clipboardRadRibbonBarGroup,
            this.objectDetailsActionsRadRibbonBarGroup});
            this.editRibbonTab.Name = "editRibbonTab";
            this.editRibbonTab.StretchHorizontally = false;
            this.editRibbonTab.Text = "Edycja";
            this.editRibbonTab.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // commitRadRibbonBarGroup
            // 
            this.commitRadRibbonBarGroup.AccessibleDescription = "Zatwierdzanie";
            this.commitRadRibbonBarGroup.AccessibleName = "Zatwierdzanie";
            this.commitRadRibbonBarGroup.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.okRadButtonElement,
            this.cancelRadButtonElement});
            this.commitRadRibbonBarGroup.Name = "commitRadRibbonBarGroup";
            this.commitRadRibbonBarGroup.Text = "Zatwierdzanie";
            this.commitRadRibbonBarGroup.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // okRadButtonElement
            // 
            this.okRadButtonElement.AccessibleDescription = "OK";
            this.okRadButtonElement.AccessibleName = "OK";
            this.okRadButtonElement.Class = "RibbonBarButtonElement";
            this.okRadButtonElement.Image = global::CarsApp.UI.Properties.Resources.ImgSave;
            this.okRadButtonElement.ImageAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.okRadButtonElement.Name = "okRadButtonElement";
            this.okRadButtonElement.Text = "OK";
            this.okRadButtonElement.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.okRadButtonElement.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.okRadButtonElement.Click += new System.EventHandler(this.okRadButtonElement_Click);
            // 
            // cancelRadButtonElement
            // 
            this.cancelRadButtonElement.AccessibleDescription = "Anuluj";
            this.cancelRadButtonElement.AccessibleName = "Anuluj";
            this.cancelRadButtonElement.Class = "RibbonBarButtonElement";
            this.cancelRadButtonElement.Image = global::CarsApp.UI.Properties.Resources.ImgCancel;
            this.cancelRadButtonElement.ImageAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.cancelRadButtonElement.Name = "cancelRadButtonElement";
            this.cancelRadButtonElement.Text = "Anuluj";
            this.cancelRadButtonElement.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.cancelRadButtonElement.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.cancelRadButtonElement.Click += new System.EventHandler(this.cancelRadButtonElement_Click);
            // 
            // clipboardRadRibbonBarGroup
            // 
            this.clipboardRadRibbonBarGroup.AccessibleDescription = "Schowek";
            this.clipboardRadRibbonBarGroup.AccessibleName = "Schowek";
            this.clipboardRadRibbonBarGroup.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.pasteRadButtonElement,
            this.clipboardRadRibbonBarButtonGroup});
            this.clipboardRadRibbonBarGroup.Name = "clipboardRadRibbonBarGroup";
            this.clipboardRadRibbonBarGroup.Text = "Schowek";
            this.clipboardRadRibbonBarGroup.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // pasteRadButtonElement
            // 
            this.pasteRadButtonElement.AccessibleDescription = "Wklej";
            this.pasteRadButtonElement.AccessibleName = "Wklej";
            this.pasteRadButtonElement.Class = "RibbonBarButtonElement";
            this.pasteRadButtonElement.Image = global::CarsApp.UI.Properties.Resources.ImgPaste;
            this.pasteRadButtonElement.ImageAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.pasteRadButtonElement.Name = "pasteRadButtonElement";
            this.pasteRadButtonElement.Text = "Wklej";
            this.pasteRadButtonElement.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.pasteRadButtonElement.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.pasteRadButtonElement.Click += new System.EventHandler(this.pasteRadButtonElement_Click);
            // 
            // clipboardRadRibbonBarButtonGroup
            // 
            this.clipboardRadRibbonBarButtonGroup.AccessibleDescription = "radRibbonBarButtonGroup1";
            this.clipboardRadRibbonBarButtonGroup.AccessibleName = "radRibbonBarButtonGroup1";
            this.clipboardRadRibbonBarButtonGroup.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.cutRadButtonElement,
            this.copyRadButtonElement});
            this.clipboardRadRibbonBarButtonGroup.Name = "clipboardRadRibbonBarButtonGroup";
            this.clipboardRadRibbonBarButtonGroup.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.clipboardRadRibbonBarButtonGroup.Text = "radRibbonBarButtonGroup1";
            this.clipboardRadRibbonBarButtonGroup.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // cutRadButtonElement
            // 
            this.cutRadButtonElement.AccessibleDescription = " Wytnij";
            this.cutRadButtonElement.AccessibleName = " Wytnij";
            this.cutRadButtonElement.Class = "ButtonElement";
            this.cutRadButtonElement.Image = ((System.Drawing.Image)(resources.GetObject("cutRadButtonElement.Image")));
            this.cutRadButtonElement.Name = "cutRadButtonElement";
            this.cutRadButtonElement.ShowBorder = false;
            this.cutRadButtonElement.Text = " Wytnij";
            this.cutRadButtonElement.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.cutRadButtonElement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cutRadButtonElement.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.cutRadButtonElement.Click += new System.EventHandler(this.cutRadButtonElement_Click);
            // 
            // copyRadButtonElement
            // 
            this.copyRadButtonElement.AccessibleDescription = " Kopiuj";
            this.copyRadButtonElement.AccessibleName = " Kopiuj";
            this.copyRadButtonElement.Class = "ButtonElement";
            this.copyRadButtonElement.Image = global::CarsApp.UI.Properties.Resources.ImgCopy15x15;
            this.copyRadButtonElement.Name = "copyRadButtonElement";
            this.copyRadButtonElement.ShowBorder = false;
            this.copyRadButtonElement.Text = " Kopiuj";
            this.copyRadButtonElement.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.copyRadButtonElement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.copyRadButtonElement.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.copyRadButtonElement.Click += new System.EventHandler(this.copyRadButtonElement_Click);
            // 
            // objectDetailsActionsRadRibbonBarGroup
            // 
            this.objectDetailsActionsRadRibbonBarGroup.AccessibleDescription = "Akcje";
            this.objectDetailsActionsRadRibbonBarGroup.AccessibleName = "Akcje";
            this.objectDetailsActionsRadRibbonBarGroup.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.deleteObjectRadButtonElement});
            this.objectDetailsActionsRadRibbonBarGroup.Name = "objectDetailsActionsRadRibbonBarGroup";
            this.objectDetailsActionsRadRibbonBarGroup.Text = "Akcje";
            this.objectDetailsActionsRadRibbonBarGroup.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // deleteObjectRadButtonElement
            // 
            this.deleteObjectRadButtonElement.AccessibleDescription = "Usuń";
            this.deleteObjectRadButtonElement.AccessibleName = "Usuń";
            this.deleteObjectRadButtonElement.Class = "RibbonBarButtonElement";
            this.deleteObjectRadButtonElement.Image = global::CarsApp.UI.Properties.Resources.ImgDelete;
            this.deleteObjectRadButtonElement.ImageAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.deleteObjectRadButtonElement.Name = "deleteObjectRadButtonElement";
            this.deleteObjectRadButtonElement.Text = "Usuń";
            this.deleteObjectRadButtonElement.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.deleteObjectRadButtonElement.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.deleteObjectRadButtonElement.Click += new System.EventHandler(this.deleteRadButtonElement_Click);
            // 
            // CityDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 251);
            this.Controls.Add(this.downPanel);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.mainRadRibbonBar);
            this.EnableDataValidation = true;
            this.Name = "CityDetails";
            this.ShowInTaskbar = false;
            this.Shown += new System.EventHandler(this.CityDetails_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.CityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainGroupBox)).EndInit();
            this.mainGroupBox.ResumeLayout(false);
            this.mainGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codeLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.downPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainRadRibbonBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource CityBindingSource;
        private LGBS.MVPFramework.Controls.LGBSGroupBox mainGroupBox;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private Telerik.WinControls.UI.RadRibbonBar mainRadRibbonBar;
        private Telerik.WinControls.UI.RibbonTab managementRibbonTab;
        private Telerik.WinControls.UI.RadRibbonBarGroup actionsRadRibbonBarGroup;
        private Telerik.WinControls.UI.RadButtonElement editRadButtonElement;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel downPanel;
        private LGBS.MVPFramework.Controls.LGBSButton closeButton;
        private Telerik.WinControls.UI.RadButtonElement deleteRadButtonElement;
        private Telerik.WinControls.UI.RibbonTab editRibbonTab;
        private Telerik.WinControls.UI.RadRibbonBarGroup commitRadRibbonBarGroup;
        private Telerik.WinControls.UI.RadButtonElement okRadButtonElement;
        private Telerik.WinControls.UI.RadButtonElement cancelRadButtonElement;
        private Telerik.WinControls.UI.RadRibbonBarGroup clipboardRadRibbonBarGroup;
        private Telerik.WinControls.UI.RadButtonElement pasteRadButtonElement;
        private Telerik.WinControls.UI.RadRibbonBarButtonGroup clipboardRadRibbonBarButtonGroup;
        private Telerik.WinControls.UI.RadButtonElement cutRadButtonElement;
        private Telerik.WinControls.UI.RadButtonElement copyRadButtonElement;
        private Telerik.WinControls.UI.RadRibbonBarGroup objectDetailsActionsRadRibbonBarGroup;
        private Telerik.WinControls.UI.RadButtonElement deleteObjectRadButtonElement;
        private LGBS.MVPFramework.Controls.LGBSLabel codeLabel;
        private LGBS.MVPFramework.Controls.LGBSLabel nameLabel;
        private LGBS.MVPFramework.Controls.LGBSTextBox nameTextBox;

    }
}