﻿namespace CarsApp.UI
{
    partial class CarServicesViewList
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
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            this.CarServicesViewCollectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CarServicesViewCollectionGrid = new LGBS.MVPFramework.Controls.LGBSGridView();
            ((System.ComponentModel.ISupportInitialize)(this.CarServicesViewCollectionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarServicesViewCollectionGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarServicesViewCollectionGrid.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // CarServicesViewCollectionBindingSource
            // 
            this.CarServicesViewCollectionBindingSource.DataSource = typeof(CarsApp.Data.CarServicesView);
            // 
            // CarServicesViewCollectionGrid
            // 
            this.CarServicesViewCollectionGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CarServicesViewCollectionGrid.BackColor = System.Drawing.SystemColors.Control;
            this.CarServicesViewCollectionGrid.Cursor = System.Windows.Forms.Cursors.Default;
            this.CarServicesViewCollectionGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.CarServicesViewCollectionGrid.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CarServicesViewCollectionGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CarServicesViewCollectionGrid.Location = new System.Drawing.Point(1, 1);
            // 
            // CarServicesViewCollectionGrid
            // 
            this.CarServicesViewCollectionGrid.MasterTemplate.AllowAddNewRow = false;
            this.CarServicesViewCollectionGrid.MasterTemplate.AllowColumnReorder = false;
            this.CarServicesViewCollectionGrid.MasterTemplate.AllowDeleteRow = false;
            this.CarServicesViewCollectionGrid.MasterTemplate.AllowEditRow = false;
            this.CarServicesViewCollectionGrid.MasterTemplate.AllowRowResize = false;
            this.CarServicesViewCollectionGrid.MasterTemplate.AutoGenerateColumns = false;
            this.CarServicesViewCollectionGrid.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "Name";
            gridViewTextBoxColumn1.FormatString = "";
            gridViewTextBoxColumn1.HeaderText = "Nazwa";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "Name";
            gridViewTextBoxColumn1.Width = 474;
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "NumberOfServicedCars";
            gridViewDecimalColumn1.FormatString = "";
            gridViewDecimalColumn1.HeaderText = "Ilość serwisowanych samochodów";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.Name = "NumberOfServicedCars";
            gridViewDecimalColumn1.Width = 476;
            this.CarServicesViewCollectionGrid.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewDecimalColumn1});
            this.CarServicesViewCollectionGrid.MasterTemplate.DataSource = this.CarServicesViewCollectionBindingSource;
            this.CarServicesViewCollectionGrid.MasterTemplate.EnableAlternatingRowColor = true;
            this.CarServicesViewCollectionGrid.MasterTemplate.EnableFiltering = true;
            this.CarServicesViewCollectionGrid.MasterTemplate.EnableGrouping = false;
            this.CarServicesViewCollectionGrid.MasterTemplate.ShowRowHeaderColumn = false;
            this.CarServicesViewCollectionGrid.Name = "CarServicesViewCollectionGrid";
            this.CarServicesViewCollectionGrid.ReadOnly = true;
            this.CarServicesViewCollectionGrid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CarServicesViewCollectionGrid.ShowGroupPanel = false;
            this.CarServicesViewCollectionGrid.ShowNoDataText = false;
            this.CarServicesViewCollectionGrid.Size = new System.Drawing.Size(950, 510);
            this.CarServicesViewCollectionGrid.TabIndex = 1;
            // 
            // CarServicesViewList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 537);
            this.Controls.Add(this.CarServicesViewCollectionGrid);
            this.Name = "CarServicesViewList";
            this.Text = "Lista TODO: ustawić tytuł";
            ((System.ComponentModel.ISupportInitialize)(this.CarServicesViewCollectionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarServicesViewCollectionGrid.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarServicesViewCollectionGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource CarServicesViewCollectionBindingSource;
        private LGBS.MVPFramework.Controls.LGBSGridView CarServicesViewCollectionGrid;
    }
}
