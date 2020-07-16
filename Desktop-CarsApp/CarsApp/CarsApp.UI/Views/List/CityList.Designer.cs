using CarsApp.Data;
using System.Windows.Forms;

namespace CarsApp.UI
{
    partial class CityList
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
            this.CityCollectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainDataPager = new LGBS.MVPFramework.Controls.LGBSDataPager();
            this.CityCollectionGrid = new LGBS.MVPFramework.Controls.LGBSGridView();
            this.filtersGroupBox = new LGBS.MVPFramework.Controls.LGBSGroupBox();
            this.countryLabel = new LGBS.MVPFramework.Controls.LGBSLabel();
            this.countryComboBox = new System.Windows.Forms.ComboBox();
            this.countryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clearFilterButton = new LGBS.MVPFramework.Controls.LGBSButton();
            this.searchButton = new LGBS.MVPFramework.Controls.LGBSButton();
            this.nameTextBox = new LGBS.MVPFramework.Controls.LGBSTextBox();
            this.nameLabel = new LGBS.MVPFramework.Controls.LGBSLabel();
            ((System.ComponentModel.ISupportInitialize)(this.CityCollectionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CityCollectionGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CityCollectionGrid.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filtersGroupBox)).BeginInit();
            this.filtersGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countryLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clearFilterButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameLabel)).BeginInit();
            this.SuspendLayout();
            // 
            // CityCollectionBindingSource
            // 
            this.CityCollectionBindingSource.DataSource = typeof(CarsApp.Data.City);
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
            // CityCollectionGrid
            // 
            this.CityCollectionGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CityCollectionGrid.BackColor = System.Drawing.SystemColors.Control;
            this.CityCollectionGrid.Cursor = System.Windows.Forms.Cursors.Default;
            this.CityCollectionGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.CityCollectionGrid.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CityCollectionGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CityCollectionGrid.Location = new System.Drawing.Point(1, 84);
            // 
            // CityCollectionGrid
            // 
            this.CityCollectionGrid.MasterTemplate.AllowAddNewRow = false;
            this.CityCollectionGrid.MasterTemplate.AllowColumnReorder = false;
            this.CityCollectionGrid.MasterTemplate.AllowDeleteRow = false;
            this.CityCollectionGrid.MasterTemplate.AllowEditRow = false;
            this.CityCollectionGrid.MasterTemplate.AllowRowResize = false;
            this.CityCollectionGrid.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.FieldName = "Name";
            gridViewTextBoxColumn1.FormatString = "";
            gridViewTextBoxColumn1.HeaderText = "Nazwa";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "Name";
            gridViewTextBoxColumn1.Width = 949;
            this.CityCollectionGrid.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1});
            this.CityCollectionGrid.MasterTemplate.DataSource = this.CityCollectionBindingSource;
            this.CityCollectionGrid.MasterTemplate.EnableAlternatingRowColor = true;
            this.CityCollectionGrid.MasterTemplate.EnableFiltering = true;
            this.CityCollectionGrid.MasterTemplate.EnableGrouping = false;
            this.CityCollectionGrid.MasterTemplate.ShowRowHeaderColumn = false;
            this.CityCollectionGrid.Name = "CityCollectionGrid";
            this.CityCollectionGrid.ReadOnly = true;
            this.CityCollectionGrid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CityCollectionGrid.ShowGroupPanel = false;
            this.CityCollectionGrid.ShowNoDataText = false;
            this.CityCollectionGrid.Size = new System.Drawing.Size(950, 427);
            this.CityCollectionGrid.TabIndex = 1;
            this.CityCollectionGrid.FilterChanged += new Telerik.WinControls.UI.GridViewCollectionChangedEventHandler(this.CityCollectionGrid_FilterChanged);
            // 
            // filtersGroupBox
            // 
            this.filtersGroupBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.filtersGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filtersGroupBox.Controls.Add(this.countryLabel);
            this.filtersGroupBox.Controls.Add(this.countryComboBox);
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
            // countryLabel
            // 
            this.countryLabel.Location = new System.Drawing.Point(30, 52);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(28, 18);
            this.countryLabel.TabIndex = 3;
            this.countryLabel.Text = "Kraj:";
            // 
            // countryComboBox
            // 
            this.countryComboBox.DataSource = this.CityCollectionBindingSource;
            this.countryComboBox.DisplayMember = "Name";
            this.countryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.countryComboBox.Location = new System.Drawing.Point(78, 52);
            this.countryComboBox.Name = "countryComboBox";
            this.countryComboBox.Size = new System.Drawing.Size(175, 21);
            this.countryComboBox.TabIndex = 4;
            // 
            // countryBindingSource
            // 
            this.countryBindingSource.DataSource = typeof(CarsApp.Data.Country);
            // 
            // clearFilterButton
            // 
            this.clearFilterButton.Image = global::CarsApp.UI.Properties.Resources.ImgClear16x16;
            this.clearFilterButton.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.clearFilterButton.Location = new System.Drawing.Point(4, 49);
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
            this.nameTextBox.Location = new System.Drawing.Point(78, 23);
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
            // CityList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 537);
            this.Controls.Add(this.filtersGroupBox);
            this.Controls.Add(this.mainDataPager);
            this.Controls.Add(this.CityCollectionGrid);
            this.Name = "CityList";
            this.Text = "Miasta";
            ((System.ComponentModel.ISupportInitialize)(this.CityCollectionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CityCollectionGrid.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CityCollectionGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filtersGroupBox)).EndInit();
            this.filtersGroupBox.ResumeLayout(false);
            this.filtersGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countryLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clearFilterButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameLabel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource CityCollectionBindingSource;
        private LGBS.MVPFramework.Controls.LGBSGridView CityCollectionGrid;
        private LGBS.MVPFramework.Controls.LGBSDataPager mainDataPager;
        private LGBS.MVPFramework.Controls.LGBSGroupBox filtersGroupBox;
        private LGBS.MVPFramework.Controls.LGBSButton clearFilterButton;
        private LGBS.MVPFramework.Controls.LGBSButton searchButton;
        private LGBS.MVPFramework.Controls.LGBSTextBox nameTextBox;
        private LGBS.MVPFramework.Controls.LGBSLabel nameLabel;
        private LGBS.MVPFramework.Controls.LGBSLabel countryLabel;
        private System.Windows.Forms.ComboBox countryComboBox;
        private BindingSource countryBindingSource;
    }
}
