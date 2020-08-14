namespace CarsApp.UI
{
    partial class CarServicesCarList
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.CarServicesCarCollectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CarServicesCarGridView = new LGBS.MVPFramework.Controls.LGBSGridView();
            ((System.ComponentModel.ISupportInitialize)(this.CarServicesCarCollectionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarServicesCarGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarServicesCarGridView.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // CarServicesCarCollectionBindingSource
            // 
            this.CarServicesCarCollectionBindingSource.DataSource = typeof(CarsApp.Data.CarServicesCar);
            // 
            // CarServicesCarGridView
            // 
            this.CarServicesCarGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CarServicesCarGridView.BackColor = System.Drawing.SystemColors.Control;
            this.CarServicesCarGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.CarServicesCarGridView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.CarServicesCarGridView.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CarServicesCarGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CarServicesCarGridView.Location = new System.Drawing.Point(0, 0);
            // 
            // CarServicesCarGridView
            // 
            this.CarServicesCarGridView.MasterTemplate.AllowAddNewRow = false;
            this.CarServicesCarGridView.MasterTemplate.AllowColumnReorder = false;
            this.CarServicesCarGridView.MasterTemplate.AllowDeleteRow = false;
            this.CarServicesCarGridView.MasterTemplate.AllowEditRow = false;
            this.CarServicesCarGridView.MasterTemplate.AllowRowResize = false;
            this.CarServicesCarGridView.MasterTemplate.AutoGenerateColumns = false;
            this.CarServicesCarGridView.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "CarProduct.CarModel.Name";
            gridViewTextBoxColumn1.FormatString = "";
            gridViewTextBoxColumn1.HeaderText = "Model";
            gridViewTextBoxColumn1.Name = "Model";
            gridViewTextBoxColumn1.Width = 137;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "CarProduct.VIN";
            gridViewTextBoxColumn2.FormatString = "";
            gridViewTextBoxColumn2.HeaderText = "VIN";
            gridViewTextBoxColumn2.Name = "VIN";
            gridViewTextBoxColumn2.Width = 137;
            gridViewTextBoxColumn3.DataType = typeof(short);
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "CarProduct.Year";
            gridViewTextBoxColumn3.FormatString = "";
            gridViewTextBoxColumn3.HeaderText = "Rocznik";
            gridViewTextBoxColumn3.Name = "Year";
            gridViewTextBoxColumn3.Width = 136;
            gridViewTextBoxColumn4.DataType = typeof(System.Nullable<System.DateTime>);
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "LoanDate";
            gridViewTextBoxColumn4.FormatString = "";
            gridViewTextBoxColumn4.HeaderText = "Data wypożyczenia";
            gridViewTextBoxColumn4.Name = "loanDate";
            gridViewTextBoxColumn4.Width = 137;
            gridViewTextBoxColumn5.DataType = typeof(System.Nullable<System.DateTime>);
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "ReturnDate";
            gridViewTextBoxColumn5.FormatString = "";
            gridViewTextBoxColumn5.HeaderText = "Data oddania";
            gridViewTextBoxColumn5.Name = "returnDate";
            gridViewTextBoxColumn5.Width = 136;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "Person.Name";
            gridViewTextBoxColumn6.FormatString = "";
            gridViewTextBoxColumn6.HeaderText = "Imię wypożyczającego";
            gridViewTextBoxColumn6.Name = "personName";
            gridViewTextBoxColumn6.Width = 137;
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.FieldName = "Person.Surname";
            gridViewTextBoxColumn7.FormatString = "";
            gridViewTextBoxColumn7.HeaderText = "Nazwisko wypożającego";
            gridViewTextBoxColumn7.Name = "personSurname";
            gridViewTextBoxColumn7.Width = 137;
            this.CarServicesCarGridView.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7});
            this.CarServicesCarGridView.MasterTemplate.DataSource = this.CarServicesCarCollectionBindingSource;
            this.CarServicesCarGridView.MasterTemplate.EnableAlternatingRowColor = true;
            this.CarServicesCarGridView.MasterTemplate.EnableFiltering = true;
            this.CarServicesCarGridView.MasterTemplate.EnableGrouping = false;
            this.CarServicesCarGridView.MasterTemplate.ShowRowHeaderColumn = false;
            this.CarServicesCarGridView.Name = "CarServicesCarGridView";
            this.CarServicesCarGridView.ReadOnly = true;
            this.CarServicesCarGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CarServicesCarGridView.ShowGroupPanel = false;
            this.CarServicesCarGridView.ShowNoDataText = false;
            this.CarServicesCarGridView.Size = new System.Drawing.Size(952, 506);
            this.CarServicesCarGridView.TabIndex = 1;
            this.CarServicesCarGridView.CellFormatting += new Telerik.WinControls.UI.CellFormattingEventHandler(this.CarServicesCarGridView_CellFormatting);
            this.CarServicesCarGridView.RowFormatting += new Telerik.WinControls.UI.RowFormattingEventHandler(this.CarServicesCarGridView_RowFormatting);
            // 
            // CarServicesCarList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 537);
            this.Controls.Add(this.CarServicesCarGridView);
            this.Name = "CarServicesCarList";
            this.Text = "Auta do wypożycznia";
            ((System.ComponentModel.ISupportInitialize)(this.CarServicesCarCollectionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarServicesCarGridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarServicesCarGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource CarServicesCarCollectionBindingSource;
        private LGBS.MVPFramework.Controls.LGBSGridView CarServicesCarGridView;
    }
}
