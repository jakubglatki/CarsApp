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
            this.ManufactureCollectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ManufactureCollectionGrid = new LGBS.MVPFramework.Controls.LGBSGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ManufactureCollectionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManufactureCollectionGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManufactureCollectionGrid.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // ManufactureCollectionBindingSource
            // 
            this.ManufactureCollectionBindingSource.DataSource = typeof(CarsApp.Data.Manufacture);
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
            this.ManufactureCollectionGrid.Location = new System.Drawing.Point(1, 1);
            // 
            // ManufactureCollectionGrid
            // 
            this.ManufactureCollectionGrid.MasterTemplate.AllowAddNewRow = false;
            this.ManufactureCollectionGrid.MasterTemplate.AllowColumnReorder = false;
            this.ManufactureCollectionGrid.MasterTemplate.AllowDeleteRow = false;
            this.ManufactureCollectionGrid.MasterTemplate.AllowEditRow = false;
            this.ManufactureCollectionGrid.MasterTemplate.AllowRowResize = false;
            this.ManufactureCollectionGrid.MasterTemplate.AutoGenerateColumns = false;
            this.ManufactureCollectionGrid.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "Name";
            gridViewTextBoxColumn1.FormatString = "";
            gridViewTextBoxColumn1.HeaderText = "Nazwa";
            gridViewTextBoxColumn1.Name = "Manufacture";
            gridViewTextBoxColumn1.Width = 949;
            this.ManufactureCollectionGrid.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1});
            this.ManufactureCollectionGrid.MasterTemplate.DataSource = this.ManufactureCollectionBindingSource;
            this.ManufactureCollectionGrid.MasterTemplate.EnableAlternatingRowColor = true;
            this.ManufactureCollectionGrid.MasterTemplate.EnableFiltering = true;
            this.ManufactureCollectionGrid.MasterTemplate.EnableGrouping = false;
            this.ManufactureCollectionGrid.MasterTemplate.ShowRowHeaderColumn = false;
            this.ManufactureCollectionGrid.Name = "ManufactureCollectionGrid";
            this.ManufactureCollectionGrid.NewRowEnterKeyMode = Telerik.WinControls.UI.RadGridViewNewRowEnterKeyMode.None;
            this.ManufactureCollectionGrid.ReadOnly = true;
            this.ManufactureCollectionGrid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ManufactureCollectionGrid.ShowGroupPanel = false;
            this.ManufactureCollectionGrid.ShowNoDataText = false;
            this.ManufactureCollectionGrid.Size = new System.Drawing.Size(950, 510);
            this.ManufactureCollectionGrid.TabIndex = 1;
            this.ManufactureCollectionGrid.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.ManufactureCollectionGrid_CellDoubleClick);
            this.ManufactureCollectionGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ManufactureCollectionGrid_KeyDown);
            // 
            // ManufactureList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 537);
            this.Controls.Add(this.ManufactureCollectionGrid);
            this.Name = "ManufactureList";
            this.Text = "Producenci";
            ((System.ComponentModel.ISupportInitialize)(this.ManufactureCollectionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManufactureCollectionGrid.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManufactureCollectionGrid)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.BindingSource ManufactureCollectionBindingSource;
		private LGBS.MVPFramework.Controls.LGBSGridView ManufactureCollectionGrid;
	}
}
