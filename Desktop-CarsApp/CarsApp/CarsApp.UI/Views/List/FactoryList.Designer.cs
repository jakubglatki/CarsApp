namespace CarsApp.UI
{
    partial class FactoryList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">True if managed resources should be disposed; otherwise, false.</param>
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor2 = new Telerik.WinControls.Data.SortDescriptor();
            this.FactoryCollectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainDataPager = new LGBS.MVPFramework.Controls.LGBSDataPager();
            this.FactoryCollectionGrid = new LGBS.MVPFramework.Controls.LGBSGridView();
            this.filtersGroupBox = new LGBS.MVPFramework.Controls.LGBSGroupBox();
            this.cityComboBox = new System.Windows.Forms.ComboBox();
            this.CityCollectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productButton = new System.Windows.Forms.Button();
            this.productLabel = new LGBS.MVPFramework.Controls.LGBSLabel();
            this.manufactureTextBox = new LGBS.MVPFramework.Controls.LGBSTextBox();
            this.cityLabel = new LGBS.MVPFramework.Controls.LGBSLabel();
            this.clearFilterButton = new LGBS.MVPFramework.Controls.LGBSButton();
            this.searchButton = new LGBS.MVPFramework.Controls.LGBSButton();
            this.nameTextBox = new LGBS.MVPFramework.Controls.LGBSTextBox();
            this.nameLabel = new LGBS.MVPFramework.Controls.LGBSLabel();
            ((System.ComponentModel.ISupportInitialize)(this.FactoryCollectionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FactoryCollectionGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FactoryCollectionGrid.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filtersGroupBox)).BeginInit();
            this.filtersGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CityCollectionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufactureTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clearFilterButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameLabel)).BeginInit();
            this.SuspendLayout();
            // 
            // FactoryCollectionBindingSource
            // 
            this.FactoryCollectionBindingSource.DataSource = typeof(CarsApp.Data.Factory);
            // 
            // mainDataPager
            // 
            this.mainDataPager.AutoSize = true;
            this.mainDataPager.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mainDataPager.Location = new System.Drawing.Point(0, 511);
            this.mainDataPager.Margin = new System.Windows.Forms.Padding(0);
            this.mainDataPager.Name = "mainDataPager";
            this.mainDataPager.PageSize = 100;
            this.mainDataPager.Size = new System.Drawing.Size(951, 26);
            this.mainDataPager.TabIndex = 2;
            // 
            // FactoryCollectionGrid
            // 
            this.FactoryCollectionGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FactoryCollectionGrid.BackColor = System.Drawing.SystemColors.Control;
            this.FactoryCollectionGrid.Cursor = System.Windows.Forms.Cursors.Default;
            this.FactoryCollectionGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FactoryCollectionGrid.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FactoryCollectionGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.FactoryCollectionGrid.Location = new System.Drawing.Point(1, 99);
            // 
            // FactoryCollectionGrid
            // 
            this.FactoryCollectionGrid.MasterTemplate.AllowAddNewRow = false;
            this.FactoryCollectionGrid.MasterTemplate.AllowColumnReorder = false;
            this.FactoryCollectionGrid.MasterTemplate.AllowDeleteRow = false;
            this.FactoryCollectionGrid.MasterTemplate.AllowEditRow = false;
            this.FactoryCollectionGrid.MasterTemplate.AllowRowResize = false;
            this.FactoryCollectionGrid.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "Name";
            gridViewTextBoxColumn4.FormatString = "";
            gridViewTextBoxColumn4.HeaderText = "Nazwa";
            gridViewTextBoxColumn4.IsAutoGenerated = true;
            gridViewTextBoxColumn4.Name = "Name";
            gridViewTextBoxColumn4.Width = 317;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "City.Name";
            gridViewTextBoxColumn5.FormatString = "";
            gridViewTextBoxColumn5.HeaderText = "Miasto";
            gridViewTextBoxColumn5.Name = "City";
            gridViewTextBoxColumn5.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending;
            gridViewTextBoxColumn5.Width = 317;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "Manufacture.Name";
            gridViewTextBoxColumn6.FormatString = "";
            gridViewTextBoxColumn6.HeaderText = "Wyrób";
            gridViewTextBoxColumn6.Name = "Manufacture";
            gridViewTextBoxColumn6.Width = 317;
            this.FactoryCollectionGrid.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6});
            this.FactoryCollectionGrid.MasterTemplate.DataSource = this.FactoryCollectionBindingSource;
            this.FactoryCollectionGrid.MasterTemplate.EnableAlternatingRowColor = true;
            this.FactoryCollectionGrid.MasterTemplate.EnableFiltering = true;
            this.FactoryCollectionGrid.MasterTemplate.EnableGrouping = false;
            this.FactoryCollectionGrid.MasterTemplate.ShowRowHeaderColumn = false;
            sortDescriptor2.PropertyName = "City";
            this.FactoryCollectionGrid.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor2});
            this.FactoryCollectionGrid.Name = "FactoryCollectionGrid";
            this.FactoryCollectionGrid.ReadOnly = true;
            this.FactoryCollectionGrid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FactoryCollectionGrid.ShowGroupPanel = false;
            this.FactoryCollectionGrid.ShowNoDataText = false;
            this.FactoryCollectionGrid.Size = new System.Drawing.Size(950, 412);
            this.FactoryCollectionGrid.TabIndex = 1;
            this.FactoryCollectionGrid.CellFormatting += new Telerik.WinControls.UI.CellFormattingEventHandler(this.FactoryCollectionGrid_CellFormatting);
            this.FactoryCollectionGrid.FilterChanged += new Telerik.WinControls.UI.GridViewCollectionChangedEventHandler(this.FactoryCollectionGrid_FilterChanged);
            // 
            // filtersGroupBox
            // 
            this.filtersGroupBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.filtersGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filtersGroupBox.Controls.Add(this.cityComboBox);
            this.filtersGroupBox.Controls.Add(this.productButton);
            this.filtersGroupBox.Controls.Add(this.productLabel);
            this.filtersGroupBox.Controls.Add(this.manufactureTextBox);
            this.filtersGroupBox.Controls.Add(this.cityLabel);
            this.filtersGroupBox.Controls.Add(this.clearFilterButton);
            this.filtersGroupBox.Controls.Add(this.searchButton);
            this.filtersGroupBox.Controls.Add(this.nameTextBox);
            this.filtersGroupBox.Controls.Add(this.nameLabel);
            this.filtersGroupBox.FooterImageIndex = -1;
            this.filtersGroupBox.FooterImageKey = "";
            this.filtersGroupBox.HeaderImageIndex = -1;
            this.filtersGroupBox.HeaderImageKey = "";
            this.filtersGroupBox.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.filtersGroupBox.HeaderText = "Wyszukiwanie";
            this.filtersGroupBox.Location = new System.Drawing.Point(0, 0);
            this.filtersGroupBox.Name = "filtersGroupBox";
            this.filtersGroupBox.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            // 
            // 
            // 
            this.filtersGroupBox.RootElement.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.filtersGroupBox.Size = new System.Drawing.Size(951, 104);
            this.filtersGroupBox.TabIndex = 0;
            this.filtersGroupBox.Text = "Wyszukiwanie";
            // 
            // cityComboBox
            // 
            this.cityComboBox.DataSource = this.CityCollectionBindingSource;
            this.cityComboBox.DisplayMember = "Name";
            this.cityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cityComboBox.Location = new System.Drawing.Point(82, 49);
            this.cityComboBox.Name = "cityComboBox";
            this.cityComboBox.Size = new System.Drawing.Size(233, 21);
            this.cityComboBox.TabIndex = 7;
            this.cityComboBox.ValueMember = "Id";
            // 
            // CityCollectionBindingSource
            // 
            this.CityCollectionBindingSource.DataSource = typeof(CarsApp.Data.City);
            // 
            // productButton
            // 
            this.productButton.Location = new System.Drawing.Point(255, 73);
            this.productButton.Name = "productButton";
            this.productButton.Size = new System.Drawing.Size(25, 20);
            this.productButton.TabIndex = 6;
            this.productButton.Text = "...";
            this.productButton.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.productButton.UseVisualStyleBackColor = true;
            // 
            // productLabel
            // 
            this.productLabel.Location = new System.Drawing.Point(30, 73);
            this.productLabel.Name = "productLabel";
            this.productLabel.Size = new System.Drawing.Size(42, 18);
            this.productLabel.TabIndex = 5;
            this.productLabel.Text = "Wyrób:";
            // 
            // manufactureTextBox
            // 
            this.manufactureTextBox.Location = new System.Drawing.Point(82, 73);
            this.manufactureTextBox.Message = null;
            this.manufactureTextBox.Name = "manufactureTextBox";
            this.manufactureTextBox.RegularExpressionString = null;
            this.manufactureTextBox.Size = new System.Drawing.Size(167, 20);
            this.manufactureTextBox.TabIndex = 5;
            this.manufactureTextBox.TabStop = false;
            // 
            // cityLabel
            // 
            this.cityLabel.Location = new System.Drawing.Point(30, 49);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(43, 18);
            this.cityLabel.TabIndex = 4;
            this.cityLabel.Text = "Miasto:";
            // 
            // clearFilterButton
            // 
            this.clearFilterButton.Image = global::CarsApp.UI.Properties.Resources.ImgClear16x16;
            this.clearFilterButton.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.clearFilterButton.Location = new System.Drawing.Point(4, 45);
            this.clearFilterButton.Name = "clearFilterButton";
            this.clearFilterButton.Size = new System.Drawing.Size(20, 20);
            this.clearFilterButton.TabIndex = 1;
            this.clearFilterButton.Click += new System.EventHandler(this.clearFilterButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Image = global::CarsApp.UI.Properties.Resources.ImgSearch16x16;
            this.searchButton.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.searchButton.Location = new System.Drawing.Point(4, 23);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(20, 20);
            this.searchButton.TabIndex = 0;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(82, 23);
            this.nameTextBox.Message = null;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.RegularExpressionString = null;
            this.nameTextBox.Size = new System.Drawing.Size(292, 20);
            this.nameTextBox.TabIndex = 3;
            this.nameTextBox.TabStop = false;
            // 
            // nameLabel
            // 
            this.nameLabel.Location = new System.Drawing.Point(30, 23);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(42, 18);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Nazwa:";
            // 
            // FactoryList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 537);
            this.Controls.Add(this.filtersGroupBox);
            this.Controls.Add(this.mainDataPager);
            this.Controls.Add(this.FactoryCollectionGrid);
            this.Name = "FactoryList";
            this.Text = "Fabryki";
            ((System.ComponentModel.ISupportInitialize)(this.FactoryCollectionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FactoryCollectionGrid.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FactoryCollectionGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filtersGroupBox)).EndInit();
            this.filtersGroupBox.ResumeLayout(false);
            this.filtersGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CityCollectionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufactureTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clearFilterButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameLabel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource FactoryCollectionBindingSource;
        private LGBS.MVPFramework.Controls.LGBSGridView FactoryCollectionGrid;
        private LGBS.MVPFramework.Controls.LGBSDataPager mainDataPager;
        private LGBS.MVPFramework.Controls.LGBSGroupBox filtersGroupBox;
        private LGBS.MVPFramework.Controls.LGBSTextBox manufactureTextBox;
        private LGBS.MVPFramework.Controls.LGBSLabel cityLabel;
        private LGBS.MVPFramework.Controls.LGBSButton clearFilterButton;
        private LGBS.MVPFramework.Controls.LGBSButton searchButton;
        private LGBS.MVPFramework.Controls.LGBSTextBox nameTextBox;
        private LGBS.MVPFramework.Controls.LGBSLabel nameLabel;
        private LGBS.MVPFramework.Controls.LGBSLabel productLabel;
        private System.Windows.Forms.Button productButton;
        public System.Windows.Forms.ComboBox cityComboBox;
        private System.Windows.Forms.BindingSource CityCollectionBindingSource;
    }
}
