namespace PointOfSale
{
	// Token: 0x020001E8 RID: 488
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class StockByBinLoc : global::System.Windows.Forms.UserControl
	{
		// Token: 0x060055EE RID: 21998 RVA: 0x0031A478 File Offset: 0x00318678
		[global::System.Diagnostics.DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				bool flag = disposing && this.components != null;
				if (flag)
				{
					this.components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x060055EF RID: 21999 RVA: 0x0031A4C8 File Offset: 0x003186C8
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.dgvproducts = new global::System.Windows.Forms.DataGridView();
			this.lblValue = new global::System.Windows.Forms.Label();
			this.Label7 = new global::System.Windows.Forms.Label();
			this.lblCost = new global::System.Windows.Forms.Label();
			this.Label5 = new global::System.Windows.Forms.Label();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.Button3 = new global::System.Windows.Forms.Button();
			this.Label19 = new global::System.Windows.Forms.Label();
			this.txtsearch = new global::System.Windows.Forms.TextBox();
			this.DGVSearch = new global::System.Windows.Forms.DataGridView();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.Label6 = new global::System.Windows.Forms.Label();
			this.cbobins = new global::System.Windows.Forms.ComboBox();
			this.lblerror = new global::System.Windows.Forms.Label();
			this.txtProductCode = new global::System.Windows.Forms.TextBox();
			this.Panel2 = new global::System.Windows.Forms.Panel();
			this.GroupBox4 = new global::System.Windows.Forms.GroupBox();
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.lblprodcount = new global::System.Windows.Forms.Label();
			this.Label8 = new global::System.Windows.Forms.Label();
			((global::System.ComponentModel.ISupportInitialize)this.dgvproducts).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.DGVSearch).BeginInit();
			this.Panel2.SuspendLayout();
			this.GroupBox4.SuspendLayout();
			this.GroupBox1.SuspendLayout();
			base.SuspendLayout();
			this.dgvproducts.AllowUserToAddRows = false;
			this.dgvproducts.AllowUserToDeleteRows = false;
			this.dgvproducts.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvproducts.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dgvproducts.Location = new global::System.Drawing.Point(0, 178);
			this.dgvproducts.Name = "dgvproducts";
			this.dgvproducts.Size = new global::System.Drawing.Size(976, 227);
			this.dgvproducts.TabIndex = 4;
			this.lblValue.AutoSize = true;
			this.lblValue.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblValue.Location = new global::System.Drawing.Point(574, 116);
			this.lblValue.Name = "lblValue";
			this.lblValue.Size = new global::System.Drawing.Size(19, 13);
			this.lblValue.TabIndex = 11;
			this.lblValue.Text = "...";
			this.Label7.AutoSize = true;
			this.Label7.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label7.Location = new global::System.Drawing.Point(365, 116);
			this.Label7.Name = "Label7";
			this.Label7.Size = new global::System.Drawing.Size(203, 13);
			this.Label7.TabIndex = 10;
			this.Label7.Text = "TOTAL SALES VALUE OF STOCK:";
			this.lblCost.AutoSize = true;
			this.lblCost.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblCost.Location = new global::System.Drawing.Point(574, 96);
			this.lblCost.Name = "lblCost";
			this.lblCost.Size = new global::System.Drawing.Size(19, 13);
			this.lblCost.TabIndex = 9;
			this.lblCost.Text = "...";
			this.Label5.AutoSize = true;
			this.Label5.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label5.Location = new global::System.Drawing.Point(364, 96);
			this.Label5.Name = "Label5";
			this.Label5.Size = new global::System.Drawing.Size(153, 13);
			this.Label5.TabIndex = 8;
			this.Label5.Text = "TOTAL COST OF STOCK:";
			this.Label4.AutoSize = true;
			this.Label4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Italic, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label4.Location = new global::System.Drawing.Point(402, 141);
			this.Label4.Name = "Label4";
			this.Label4.Size = new global::System.Drawing.Size(240, 13);
			this.Label4.TabIndex = 7;
			this.Label4.Text = "*Product stock is now below the set reorder level.";
			this.Label2.AutoSize = true;
			this.Label2.BackColor = global::System.Drawing.Color.Yellow;
			this.Label2.Location = new global::System.Drawing.Point(365, 141);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(31, 13);
			this.Label2.TabIndex = 6;
			this.Label2.Text = "        ";
			this.Label3.AutoSize = true;
			this.Label3.BackColor = global::System.Drawing.Color.Red;
			this.Label3.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.Label3.Location = new global::System.Drawing.Point(940, 16);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(33, 13);
			this.Label3.TabIndex = 5;
			this.Label3.Text = "Close";
			this.Label1.AutoSize = true;
			this.Label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label1.Location = new global::System.Drawing.Point(363, 16);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(162, 24);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "View Stock Levels";
			this.Button3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Button3.Location = new global::System.Drawing.Point(233, 32);
			this.Button3.Name = "Button3";
			this.Button3.Size = new global::System.Drawing.Size(75, 31);
			this.Button3.TabIndex = 10;
			this.Button3.TabStop = false;
			this.Button3.Text = "Show All";
			this.Button3.UseVisualStyleBackColor = true;
			this.Label19.AutoSize = true;
			this.Label19.Location = new global::System.Drawing.Point(5, 13);
			this.Label19.Name = "Label19";
			this.Label19.Size = new global::System.Drawing.Size(249, 13);
			this.Label19.TabIndex = 9;
			this.Label19.Text = "Type in the space to search by product description:";
			this.txtsearch.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtsearch.Location = new global::System.Drawing.Point(8, 34);
			this.txtsearch.Name = "txtsearch";
			this.txtsearch.Size = new global::System.Drawing.Size(219, 29);
			this.txtsearch.TabIndex = 0;
			this.DGVSearch.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DGVSearch.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.DGVSearch.Location = new global::System.Drawing.Point(0, 69);
			this.DGVSearch.Name = "DGVSearch";
			this.DGVSearch.ReadOnly = true;
			this.DGVSearch.Size = new global::System.Drawing.Size(312, 86);
			this.DGVSearch.StandardTab = true;
			this.DGVSearch.TabIndex = 1;
			this.Button1.Location = new global::System.Drawing.Point(644, 43);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(127, 23);
			this.Button1.TabIndex = 36;
			this.Button1.Text = "View Bin Locations";
			this.Button1.UseVisualStyleBackColor = true;
			this.Label6.AutoSize = true;
			this.Label6.Location = new global::System.Drawing.Point(352, 48);
			this.Label6.Name = "Label6";
			this.Label6.Size = new global::System.Drawing.Size(102, 13);
			this.Label6.TabIndex = 35;
			this.Label6.Text = "Select Bin Location:";
			this.cbobins.FormattingEnabled = true;
			this.cbobins.Location = new global::System.Drawing.Point(456, 45);
			this.cbobins.Name = "cbobins";
			this.cbobins.Size = new global::System.Drawing.Size(182, 21);
			this.cbobins.TabIndex = 34;
			this.lblerror.AutoSize = true;
			this.lblerror.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.lblerror.Location = new global::System.Drawing.Point(319, 162);
			this.lblerror.Name = "lblerror";
			this.lblerror.Size = new global::System.Drawing.Size(16, 13);
			this.lblerror.TabIndex = 33;
			this.lblerror.Text = "...";
			this.txtProductCode.Location = new global::System.Drawing.Point(788, 13);
			this.txtProductCode.Name = "txtProductCode";
			this.txtProductCode.Size = new global::System.Drawing.Size(100, 20);
			this.txtProductCode.TabIndex = 32;
			this.txtProductCode.Visible = false;
			this.Panel2.BackColor = global::System.Drawing.Color.FromArgb(192, 255, 255);
			this.Panel2.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.Panel2.Controls.Add(this.DGVSearch);
			this.Panel2.Controls.Add(this.GroupBox4);
			this.Panel2.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.Panel2.Location = new global::System.Drawing.Point(3, 16);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new global::System.Drawing.Size(316, 159);
			this.Panel2.TabIndex = 31;
			this.GroupBox4.Controls.Add(this.Button3);
			this.GroupBox4.Controls.Add(this.Label19);
			this.GroupBox4.Controls.Add(this.txtsearch);
			this.GroupBox4.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox4.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox4.Name = "GroupBox4";
			this.GroupBox4.Size = new global::System.Drawing.Size(312, 69);
			this.GroupBox4.TabIndex = 0;
			this.GroupBox4.TabStop = false;
			this.GroupBox1.Controls.Add(this.lblprodcount);
			this.GroupBox1.Controls.Add(this.Label8);
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Controls.Add(this.Label6);
			this.GroupBox1.Controls.Add(this.cbobins);
			this.GroupBox1.Controls.Add(this.lblerror);
			this.GroupBox1.Controls.Add(this.txtProductCode);
			this.GroupBox1.Controls.Add(this.Panel2);
			this.GroupBox1.Controls.Add(this.lblValue);
			this.GroupBox1.Controls.Add(this.Label7);
			this.GroupBox1.Controls.Add(this.lblCost);
			this.GroupBox1.Controls.Add(this.Label5);
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new global::System.Drawing.Size(976, 178);
			this.GroupBox1.TabIndex = 3;
			this.GroupBox1.TabStop = false;
			this.lblprodcount.AutoSize = true;
			this.lblprodcount.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblprodcount.Location = new global::System.Drawing.Point(574, 74);
			this.lblprodcount.Name = "lblprodcount";
			this.lblprodcount.Size = new global::System.Drawing.Size(19, 13);
			this.lblprodcount.TabIndex = 38;
			this.lblprodcount.Text = "...";
			this.Label8.AutoSize = true;
			this.Label8.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label8.Location = new global::System.Drawing.Point(364, 74);
			this.Label8.Name = "Label8";
			this.Label8.Size = new global::System.Drawing.Size(149, 13);
			this.Label8.TabIndex = 37;
			this.Label8.Text = "PRODUCT LIST COUNT:";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.Controls.Add(this.dgvproducts);
			base.Controls.Add(this.GroupBox1);
			base.Name = "StockByBinLoc";
			base.Size = new global::System.Drawing.Size(976, 405);
			((global::System.ComponentModel.ISupportInitialize)this.dgvproducts).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.DGVSearch).EndInit();
			this.Panel2.ResumeLayout(false);
			this.GroupBox4.ResumeLayout(false);
			this.GroupBox4.PerformLayout();
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04002581 RID: 9601
		private global::System.ComponentModel.IContainer components;
	}
}
