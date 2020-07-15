namespace CarsApp.UI
{
	partial class CountryList
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
            this.CountryCollectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainDataPager = new LGBS.MVPFramework.Controls.LGBSDataPager();
            this.CountryCollectionGrid = new LGBS.MVPFramework.Controls.LGBSGridView();
            this.filtersGroupBox = new LGBS.MVPFramework.Controls.LGBSGroupBox();
            this.codeTextBox = new LGBS.MVPFramework.Controls.LGBSTextBox();
            this.codeLabel = new LGBS.MVPFramework.Controls.LGBSLabel();
            this.clearFilterButton = new LGBS.MVPFramework.Controls.LGBSButton();
            this.searchButton = new LGBS.MVPFramework.Controls.LGBSButton();
            this.nameTextBox = new LGBS.MVPFramework.Controls.LGBSTextBox();
            this.nameLabel = new LGBS.MVPFramework.Controls.LGBSLabel();
            ((System.ComponentModel.ISupportInitialize)(this.CountryCollectionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountryCollectionGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountryCollectionGrid.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filtersGroupBox)).BeginInit();
            this.filtersGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codeTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clearFilterButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameLabel)).BeginInit();
            this.SuspendLayout();
            // 
            // CountryCollectionBindingSource
            // 
            this.CountryCollectionBindingSource.DataSource = typeof(CarsApp.Data.Country);
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
            // CountryCollectionGrid
            // 
            this.CountryCollectionGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CountryCollectionGrid.BackColor = System.Drawing.SystemColors.Control;
            this.CountryCollectionGrid.Cursor = System.Windows.Forms.Cursors.Default;
            this.CountryCollectionGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.CountryCollectionGrid.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CountryCollectionGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CountryCollectionGrid.Location = new System.Drawing.Point(1, 84);
            // 
            // CountryCollectionGrid
            // 
            this.CountryCollectionGrid.MasterTemplate.AllowAddNewRow = false;
            this.CountryCollectionGrid.MasterTemplate.AllowColumnReorder = false;
            this.CountryCollectionGrid.MasterTemplate.AllowDeleteRow = false;
            this.CountryCollectionGrid.MasterTemplate.AllowEditRow = false;
            this.CountryCollectionGrid.MasterTemplate.AllowRowResize = false;
            this.CountryCollectionGrid.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.FieldName = "Name";
            gridViewTextBoxColumn1.FormatString = "";
            gridViewTextBoxColumn1.HeaderText = "Nazwa";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "Name";
            gridViewTextBoxColumn1.Width = 475;
            gridViewTextBoxColumn2.FieldName = "Code";
            gridViewTextBoxColumn2.FormatString = "";
            gridViewTextBoxColumn2.HeaderText = "Kod";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.Name = "Code";
            gridViewTextBoxColumn2.Width = 475;
            this.CountryCollectionGrid.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2});
            this.CountryCollectionGrid.MasterTemplate.DataSource = this.CountryCollectionBindingSource;
            this.CountryCollectionGrid.MasterTemplate.EnableAlternatingRowColor = true;
            this.CountryCollectionGrid.MasterTemplate.EnableFiltering = true;
            this.CountryCollectionGrid.MasterTemplate.EnableGrouping = false;
            this.CountryCollectionGrid.MasterTemplate.ShowRowHeaderColumn = false;
            this.CountryCollectionGrid.Name = "CountryCollectionGrid";
            this.CountryCollectionGrid.ReadOnly = true;
            this.CountryCollectionGrid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CountryCollectionGrid.ShowGroupPanel = false;
            this.CountryCollectionGrid.ShowNoDataText = false;
            this.CountryCollectionGrid.Size = new System.Drawing.Size(950, 427);
            this.CountryCollectionGrid.TabIndex = 1;
            this.CountryCollectionGrid.FilterChanged += new Telerik.WinControls.UI.GridViewCollectionChangedEventHandler(this.CountryCollectionGrid_FilterChanged);
            // 
            // filtersGroupBox
            // 
            this.filtersGroupBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.filtersGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filtersGroupBox.Controls.Add(this.codeTextBox);
            this.filtersGroupBox.Controls.Add(this.codeLabel);
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
            this.filtersGroupBox.Size = new System.Drawing.Size(951, 78);
            this.filtersGroupBox.TabIndex = 0;
            this.filtersGroupBox.Text = "Wyszukiwanie";
            // 
            // codeTextBox
            // 
            this.codeTextBox.Location = new System.Drawing.Point(82, 49);
            this.codeTextBox.Message = null;
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.RegularExpressionString = null;
            this.codeTextBox.Size = new System.Drawing.Size(127, 20);
            this.codeTextBox.TabIndex = 5;
            this.codeTextBox.TabStop = false;
            // 
            // codeLabel
            // 
            this.codeLabel.Location = new System.Drawing.Point(30, 49);
            this.codeLabel.Name = "codeLabel";
            this.codeLabel.Size = new System.Drawing.Size(29, 18);
            this.codeLabel.TabIndex = 4;
            this.codeLabel.Text = "Kod:";
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
            // CountryList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 537);
            this.Controls.Add(this.filtersGroupBox);
            this.Controls.Add(this.mainDataPager);
            this.Controls.Add(this.CountryCollectionGrid);
            this.Name = "CountryList";
            this.Text = "Kraje";
            ((System.ComponentModel.ISupportInitialize)(this.CountryCollectionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountryCollectionGrid.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountryCollectionGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filtersGroupBox)).EndInit();
            this.filtersGroupBox.ResumeLayout(false);
            this.filtersGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codeTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clearFilterButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameLabel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.BindingSource CountryCollectionBindingSource;
		private LGBS.MVPFramework.Controls.LGBSGridView CountryCollectionGrid;
		private LGBS.MVPFramework.Controls.LGBSDataPager mainDataPager;
		private LGBS.MVPFramework.Controls.LGBSGroupBox filtersGroupBox;
		private LGBS.MVPFramework.Controls.LGBSTextBox codeTextBox;
		private LGBS.MVPFramework.Controls.LGBSLabel codeLabel;
		private LGBS.MVPFramework.Controls.LGBSButton clearFilterButton;
		private LGBS.MVPFramework.Controls.LGBSButton searchButton;
		private LGBS.MVPFramework.Controls.LGBSTextBox nameTextBox;
		private LGBS.MVPFramework.Controls.LGBSLabel nameLabel;
	}
}
