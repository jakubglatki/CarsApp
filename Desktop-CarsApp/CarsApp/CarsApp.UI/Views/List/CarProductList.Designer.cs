namespace CarsApp.UI
{
    partial class CarProductList
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            this.CarProductCollectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainDataPager = new LGBS.MVPFramework.Controls.LGBSDataPager();
            this.CarProductCollectionGrid = new LGBS.MVPFramework.Controls.LGBSGridView();
            this.filtersGroupBox = new LGBS.MVPFramework.Controls.LGBSGroupBox();
            this.factoryComboBox = new System.Windows.Forms.ComboBox();
            this.FactoryCollectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modelComboBox = new System.Windows.Forms.ComboBox();
            this.factoryLabel = new LGBS.MVPFramework.Controls.LGBSLabel();
            this.VINLabel = new LGBS.MVPFramework.Controls.LGBSLabel();
            this.clearFilterButton = new LGBS.MVPFramework.Controls.LGBSButton();
            this.searchButton = new LGBS.MVPFramework.Controls.LGBSButton();
            this.VINTextBox = new LGBS.MVPFramework.Controls.LGBSTextBox();
            this.modelLabel = new LGBS.MVPFramework.Controls.LGBSLabel();
            this.ModelCollectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.CarProductCollectionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarProductCollectionGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarProductCollectionGrid.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filtersGroupBox)).BeginInit();
            this.filtersGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FactoryCollectionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factoryLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VINLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clearFilterButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VINTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModelCollectionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CarProductCollectionBindingSource
            // 
            this.CarProductCollectionBindingSource.DataSource = typeof(CarsApp.Data.CarProduct);
            // 
            // mainDataPager
            // 
            this.mainDataPager.AutoSize = true;
            this.mainDataPager.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mainDataPager.Location = new System.Drawing.Point(0, 319);
            this.mainDataPager.Margin = new System.Windows.Forms.Padding(0);
            this.mainDataPager.Name = "mainDataPager";
            this.mainDataPager.PageSize = 100;
            this.mainDataPager.Size = new System.Drawing.Size(629, 26);
            this.mainDataPager.TabIndex = 2;
            // 
            // CarProductCollectionGrid
            // 
            this.CarProductCollectionGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CarProductCollectionGrid.BackColor = System.Drawing.SystemColors.Control;
            this.CarProductCollectionGrid.Cursor = System.Windows.Forms.Cursors.Default;
            this.CarProductCollectionGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.CarProductCollectionGrid.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CarProductCollectionGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CarProductCollectionGrid.Location = new System.Drawing.Point(1, 99);
            // 
            // CarProductCollectionGrid
            // 
            this.CarProductCollectionGrid.MasterTemplate.AllowAddNewRow = false;
            this.CarProductCollectionGrid.MasterTemplate.AllowColumnReorder = false;
            this.CarProductCollectionGrid.MasterTemplate.AllowDeleteRow = false;
            this.CarProductCollectionGrid.MasterTemplate.AllowEditRow = false;
            this.CarProductCollectionGrid.MasterTemplate.AllowRowResize = false;
            this.CarProductCollectionGrid.MasterTemplate.AutoGenerateColumns = false;
            this.CarProductCollectionGrid.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "CarModel.Name";
            gridViewTextBoxColumn1.FormatString = "";
            gridViewTextBoxColumn1.HeaderText = "Model";
            gridViewTextBoxColumn1.Name = "Model";
            gridViewTextBoxColumn1.Width = 209;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "VIN";
            gridViewTextBoxColumn2.FormatString = "";
            gridViewTextBoxColumn2.HeaderText = "VIN";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.Name = "VIN";
            gridViewTextBoxColumn2.Width = 210;
            gridViewDecimalColumn1.DataType = typeof(short);
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "Year";
            gridViewDecimalColumn1.FormatString = "";
            gridViewDecimalColumn1.HeaderText = "Year";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.Name = "Year";
            gridViewDecimalColumn1.SortOrder = Telerik.WinControls.UI.RadSortOrder.Descending;
            gridViewDecimalColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewDecimalColumn1.Width = 210;
            this.CarProductCollectionGrid.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewDecimalColumn1});
            this.CarProductCollectionGrid.MasterTemplate.DataSource = this.CarProductCollectionBindingSource;
            this.CarProductCollectionGrid.MasterTemplate.EnableAlternatingRowColor = true;
            this.CarProductCollectionGrid.MasterTemplate.EnableFiltering = true;
            this.CarProductCollectionGrid.MasterTemplate.EnableGrouping = false;
            this.CarProductCollectionGrid.MasterTemplate.ShowRowHeaderColumn = false;
            sortDescriptor1.Direction = System.ComponentModel.ListSortDirection.Descending;
            sortDescriptor1.PropertyName = "Year";
            this.CarProductCollectionGrid.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            this.CarProductCollectionGrid.Name = "CarProductCollectionGrid";
            this.CarProductCollectionGrid.ReadOnly = true;
            this.CarProductCollectionGrid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CarProductCollectionGrid.ShowGroupPanel = false;
            this.CarProductCollectionGrid.ShowNoDataText = false;
            this.CarProductCollectionGrid.Size = new System.Drawing.Size(628, 220);
            this.CarProductCollectionGrid.TabIndex = 1;
            this.CarProductCollectionGrid.CellFormatting += new Telerik.WinControls.UI.CellFormattingEventHandler(this.CarProductCollectionGrid_CellFormatting);
            this.CarProductCollectionGrid.FilterChanged += new Telerik.WinControls.UI.GridViewCollectionChangedEventHandler(this.CarProductCollectionGrid_FilterChanged);
            // 
            // filtersGroupBox
            // 
            this.filtersGroupBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.filtersGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filtersGroupBox.Controls.Add(this.factoryComboBox);
            this.filtersGroupBox.Controls.Add(this.modelComboBox);
            this.filtersGroupBox.Controls.Add(this.factoryLabel);
            this.filtersGroupBox.Controls.Add(this.VINLabel);
            this.filtersGroupBox.Controls.Add(this.clearFilterButton);
            this.filtersGroupBox.Controls.Add(this.searchButton);
            this.filtersGroupBox.Controls.Add(this.VINTextBox);
            this.filtersGroupBox.Controls.Add(this.modelLabel);
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
            this.filtersGroupBox.Size = new System.Drawing.Size(629, 104);
            this.filtersGroupBox.TabIndex = 0;
            this.filtersGroupBox.Text = "Wyszukiwanie";
            // 
            // factoryComboBox
            // 
            this.factoryComboBox.DataSource = this.FactoryCollectionBindingSource;
            this.factoryComboBox.DisplayMember = "Name";
            this.factoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.factoryComboBox.Location = new System.Drawing.Point(82, 70);
            this.factoryComboBox.Name = "factoryComboBox";
            this.factoryComboBox.Size = new System.Drawing.Size(233, 21);
            this.factoryComboBox.TabIndex = 8;
            this.factoryComboBox.ValueMember = "Id";
            this.factoryComboBox.DropDown += new System.EventHandler(this.factoryComboBox_DropDown);
            // 
            // FactoryCollectionBindingSource
            // 
            this.FactoryCollectionBindingSource.DataSource = typeof(CarsApp.Data.Factory);
            // 
            // modelComboBox
            // 
            this.modelComboBox.DisplayMember = "Id";
            this.modelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modelComboBox.Location = new System.Drawing.Point(82, 22);
            this.modelComboBox.Name = "modelComboBox";
            this.modelComboBox.Size = new System.Drawing.Size(233, 21);
            this.modelComboBox.TabIndex = 7;
            this.modelComboBox.ValueMember = "Id";
            this.modelComboBox.DropDown += new System.EventHandler(this.modelComboBox_DropDown);
            // 
            // factoryLabel
            // 
            this.factoryLabel.Location = new System.Drawing.Point(30, 73);
            this.factoryLabel.Name = "factoryLabel";
            this.factoryLabel.Size = new System.Drawing.Size(47, 18);
            this.factoryLabel.TabIndex = 5;
            this.factoryLabel.Text = "Fabryka:";
            // 
            // VINLabel
            // 
            this.VINLabel.Location = new System.Drawing.Point(30, 49);
            this.VINLabel.Name = "VINLabel";
            this.VINLabel.Size = new System.Drawing.Size(27, 18);
            this.VINLabel.TabIndex = 4;
            this.VINLabel.Text = "VIN:";
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
            // VINTextBox
            // 
            this.VINTextBox.Location = new System.Drawing.Point(82, 47);
            this.VINTextBox.Message = null;
            this.VINTextBox.Name = "VINTextBox";
            this.VINTextBox.RegularExpressionString = null;
            this.VINTextBox.Size = new System.Drawing.Size(233, 20);
            this.VINTextBox.TabIndex = 3;
            this.VINTextBox.TabStop = false;
            // 
            // modelLabel
            // 
            this.modelLabel.Location = new System.Drawing.Point(30, 25);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(41, 18);
            this.modelLabel.TabIndex = 2;
            this.modelLabel.Text = "Model:";
            // 
            // ModelCollectionBindingSource
            // 
            this.ModelCollectionBindingSource.DataSource = typeof(CarsApp.Data.CarModel);
            // 
            // CarProductList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 345);
            this.Controls.Add(this.filtersGroupBox);
            this.Controls.Add(this.mainDataPager);
            this.Controls.Add(this.CarProductCollectionGrid);
            this.Name = "CarProductList";
            this.Text = "Produkty";
            ((System.ComponentModel.ISupportInitialize)(this.CarProductCollectionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarProductCollectionGrid.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarProductCollectionGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filtersGroupBox)).EndInit();
            this.filtersGroupBox.ResumeLayout(false);
            this.filtersGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FactoryCollectionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factoryLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VINLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clearFilterButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VINTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModelCollectionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource CarProductCollectionBindingSource;
        private LGBS.MVPFramework.Controls.LGBSGridView CarProductCollectionGrid;
        private LGBS.MVPFramework.Controls.LGBSDataPager mainDataPager;
        private LGBS.MVPFramework.Controls.LGBSGroupBox filtersGroupBox;
        private LGBS.MVPFramework.Controls.LGBSLabel VINLabel;
        private LGBS.MVPFramework.Controls.LGBSButton clearFilterButton;
        private LGBS.MVPFramework.Controls.LGBSButton searchButton;
        private LGBS.MVPFramework.Controls.LGBSTextBox VINTextBox;
        private LGBS.MVPFramework.Controls.LGBSLabel modelLabel;
        private LGBS.MVPFramework.Controls.LGBSLabel factoryLabel;
        public System.Windows.Forms.ComboBox modelComboBox;
        private System.Windows.Forms.BindingSource FactoryCollectionBindingSource;
        public System.Windows.Forms.ComboBox factoryComboBox;
        private System.Windows.Forms.BindingSource ModelCollectionBindingSource;
    }
}
