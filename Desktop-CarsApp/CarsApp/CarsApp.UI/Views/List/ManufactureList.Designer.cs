namespace CarsApp.UI
{
    partial class ManufactureList
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.ManufactureCollectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainDataPager = new LGBS.MVPFramework.Controls.LGBSDataPager();
            this.ManufactureCollectionGrid = new LGBS.MVPFramework.Controls.LGBSGridView();
            this.filtersGroupBox = new LGBS.MVPFramework.Controls.LGBSGroupBox();
            this.modelComboBox = new System.Windows.Forms.ComboBox();
            this.FactoryCollectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.factoryLabel = new LGBS.MVPFramework.Controls.LGBSLabel();
            this.VINLabel = new LGBS.MVPFramework.Controls.LGBSLabel();
            this.clearFilterButton = new LGBS.MVPFramework.Controls.LGBSButton();
            this.searchButton = new LGBS.MVPFramework.Controls.LGBSButton();
            this.VINTextBox = new LGBS.MVPFramework.Controls.LGBSTextBox();
            this.modelLabel = new LGBS.MVPFramework.Controls.LGBSLabel();
            this.factoryComboBox = new System.Windows.Forms.ComboBox();
            this.ModelCollectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ManufactureCollectionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManufactureCollectionGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManufactureCollectionGrid.MasterTemplate)).BeginInit();
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
            // ManufactureCollectionBindingSource
            // 
            this.ManufactureCollectionBindingSource.DataSource = typeof(CarsApp.Data.Manufacture);
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
            // ManufactureCollectionGrid
            // 
            this.ManufactureCollectionGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ManufactureCollectionGrid.BackColor = System.Drawing.SystemColors.Control;
            this.ManufactureCollectionGrid.Cursor = System.Windows.Forms.Cursors.Default;
            this.ManufactureCollectionGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ManufactureCollectionGrid.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ManufactureCollectionGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ManufactureCollectionGrid.Location = new System.Drawing.Point(1, 99);
            // 
            // ManufactureCollectionGrid
            // 
            this.ManufactureCollectionGrid.MasterTemplate.AllowAddNewRow = false;
            this.ManufactureCollectionGrid.MasterTemplate.AllowColumnReorder = false;
            this.ManufactureCollectionGrid.MasterTemplate.AllowDeleteRow = false;
            this.ManufactureCollectionGrid.MasterTemplate.AllowEditRow = false;
            this.ManufactureCollectionGrid.MasterTemplate.AllowRowResize = false;
            this.ManufactureCollectionGrid.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "Model.Name";
            gridViewTextBoxColumn1.FormatString = "";
            gridViewTextBoxColumn1.HeaderText = "Model";
            gridViewTextBoxColumn1.Name = "Model";
            gridViewTextBoxColumn1.Width = 297;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "Manufacture.Name";
            gridViewTextBoxColumn2.FormatString = "";
            gridViewTextBoxColumn2.HeaderText = "Wyrób";
            gridViewTextBoxColumn2.Name = "Manufacture";
            gridViewTextBoxColumn2.Width = 294;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FormatString = "";
            gridViewTextBoxColumn3.HeaderText = "column1";
            gridViewTextBoxColumn3.Name = "column1";
            gridViewTextBoxColumn3.Width = 38;
            this.ManufactureCollectionGrid.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3});
            this.ManufactureCollectionGrid.MasterTemplate.DataSource = this.ManufactureCollectionBindingSource;
            this.ManufactureCollectionGrid.MasterTemplate.EnableAlternatingRowColor = true;
            this.ManufactureCollectionGrid.MasterTemplate.EnableFiltering = true;
            this.ManufactureCollectionGrid.MasterTemplate.EnableGrouping = false;
            this.ManufactureCollectionGrid.MasterTemplate.ShowRowHeaderColumn = false;
            this.ManufactureCollectionGrid.Name = "ManufactureCollectionGrid";
            this.ManufactureCollectionGrid.ReadOnly = true;
            this.ManufactureCollectionGrid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ManufactureCollectionGrid.ShowGroupPanel = false;
            this.ManufactureCollectionGrid.ShowNoDataText = false;
            this.ManufactureCollectionGrid.Size = new System.Drawing.Size(628, 220);
            this.ManufactureCollectionGrid.TabIndex = 1;
            this.ManufactureCollectionGrid.CellFormatting += new Telerik.WinControls.UI.CellFormattingEventHandler(this.ManufactureCollectionGrid_CellFormatting);
            this.ManufactureCollectionGrid.FilterChanged += new Telerik.WinControls.UI.GridViewCollectionChangedEventHandler(this.ManufactureCollectionGrid_FilterChanged);
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
            // modelComboBox
            // 
            this.modelComboBox.DataSource = this.ModelCollectionBindingSource;
            this.modelComboBox.DisplayMember = "Name";
            this.modelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modelComboBox.Location = new System.Drawing.Point(82, 22);
            this.modelComboBox.Name = "modelComboBox";
            this.modelComboBox.Size = new System.Drawing.Size(233, 21);
            this.modelComboBox.TabIndex = 7;
            this.modelComboBox.ValueMember = "Id";
            // 
            // FactoryCollectionBindingSource
            // 
            this.FactoryCollectionBindingSource.DataSource = typeof(CarsApp.Data.Factory);
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
            // 
            // ModelCollectionBindingSource
            // 
            this.ModelCollectionBindingSource.DataSource = typeof(CarsApp.Data.CarModel);
            // 
            // ManufactureList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 345);
            this.Controls.Add(this.filtersGroupBox);
            this.Controls.Add(this.mainDataPager);
            this.Controls.Add(this.ManufactureCollectionGrid);
            this.Name = "ManufactureList";
            this.Text = "Produkty";
            ((System.ComponentModel.ISupportInitialize)(this.ManufactureCollectionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManufactureCollectionGrid.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManufactureCollectionGrid)).EndInit();
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

        private System.Windows.Forms.BindingSource ManufactureCollectionBindingSource;
        private LGBS.MVPFramework.Controls.LGBSGridView ManufactureCollectionGrid;
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
