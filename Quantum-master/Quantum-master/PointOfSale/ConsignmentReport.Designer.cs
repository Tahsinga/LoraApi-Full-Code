namespace PointOfSale
{
	// Token: 0x0200002E RID: 46
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class ConsignmentReport : global::System.Windows.Forms.Form
	{
		// Token: 0x060008B2 RID: 2226 RVA: 0x000541D4 File Offset: 0x000523D4
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

		// Token: 0x060008B3 RID: 2227 RVA: 0x00054224 File Offset: 0x00052424
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.cboBranches = new global::System.Windows.Forms.ComboBox();
			this.Label20 = new global::System.Windows.Forms.Label();
			this.txtBarCode = new global::System.Windows.Forms.TextBox();
			this.Button2 = new global::System.Windows.Forms.Button();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.DTEndDate = new global::System.Windows.Forms.DateTimePicker();
			this.DTStartDate = new global::System.Windows.Forms.DateTimePicker();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.txtDesc = new global::System.Windows.Forms.TextBox();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.txtSearchProductCode = new global::System.Windows.Forms.TextBox();
			this.lblerror = new global::System.Windows.Forms.Label();
			this.Panel2 = new global::System.Windows.Forms.Panel();
			this.DGVSearch = new global::System.Windows.Forms.DataGridView();
			this.GroupBox4 = new global::System.Windows.Forms.GroupBox();
			this.Button3 = new global::System.Windows.Forms.Button();
			this.Label19 = new global::System.Windows.Forms.Label();
			this.txtsearch = new global::System.Windows.Forms.TextBox();
			this.dgvItems = new global::System.Windows.Forms.DataGridView();
			this.ProductID = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ProductCode = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ProductDesc = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.OpeningStock = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.StockPurchases = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.UnitCost = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.UnitsSold = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TotalCost = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SellingPrice = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TotalSelling = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.GrossProfit = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ClosingStock = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.GroupBox1.SuspendLayout();
			this.Panel2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.DGVSearch).BeginInit();
			this.GroupBox4.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvItems).BeginInit();
			base.SuspendLayout();
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Controls.Add(this.cboBranches);
			this.GroupBox1.Controls.Add(this.Label20);
			this.GroupBox1.Controls.Add(this.txtBarCode);
			this.GroupBox1.Controls.Add(this.Button2);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Controls.Add(this.DTEndDate);
			this.GroupBox1.Controls.Add(this.DTStartDate);
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Controls.Add(this.txtDesc);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.txtSearchProductCode);
			this.GroupBox1.Controls.Add(this.lblerror);
			this.GroupBox1.Controls.Add(this.Panel2);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new global::System.Drawing.Size(1107, 285);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.Label4.AutoSize = true;
			this.Label4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label4.Location = new global::System.Drawing.Point(356, 197);
			this.Label4.Name = "Label4";
			this.Label4.Size = new global::System.Drawing.Size(57, 17);
			this.Label4.TabIndex = 49;
			this.Label4.Text = "Branch:";
			this.cboBranches.FormattingEnabled = true;
			this.cboBranches.Location = new global::System.Drawing.Point(423, 193);
			this.cboBranches.Name = "cboBranches";
			this.cboBranches.Size = new global::System.Drawing.Size(218, 21);
			this.cboBranches.TabIndex = 48;
			this.Label20.AutoSize = true;
			this.Label20.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label20.Location = new global::System.Drawing.Point(341, 59);
			this.Label20.Name = "Label20";
			this.Label20.Size = new global::System.Drawing.Size(127, 17);
			this.Label20.TabIndex = 47;
			this.Label20.Text = "BAR CODE (F1):";
			this.txtBarCode.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtBarCode.Location = new global::System.Drawing.Point(478, 53);
			this.txtBarCode.Name = "txtBarCode";
			this.txtBarCode.Size = new global::System.Drawing.Size(163, 26);
			this.txtBarCode.TabIndex = 46;
			this.txtBarCode.TabStop = false;
			this.Button2.BackColor = global::System.Drawing.Color.Lime;
			this.Button2.Location = new global::System.Drawing.Point(647, 220);
			this.Button2.Name = "Button2";
			this.Button2.Size = new global::System.Drawing.Size(137, 46);
			this.Button2.TabIndex = 45;
			this.Button2.Text = "RUN REPORT";
			this.Button2.UseVisualStyleBackColor = false;
			this.Label3.AutoSize = true;
			this.Label3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label3.Location = new global::System.Drawing.Point(342, 247);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(71, 17);
			this.Label3.TabIndex = 44;
			this.Label3.Text = "End Date:";
			this.Label1.AutoSize = true;
			this.Label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label1.Location = new global::System.Drawing.Point(341, 220);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(76, 17);
			this.Label1.TabIndex = 43;
			this.Label1.Text = "Start Date:";
			this.DTEndDate.Location = new global::System.Drawing.Point(423, 246);
			this.DTEndDate.Name = "DTEndDate";
			this.DTEndDate.Size = new global::System.Drawing.Size(218, 20);
			this.DTEndDate.TabIndex = 42;
			this.DTStartDate.Location = new global::System.Drawing.Point(423, 220);
			this.DTStartDate.Name = "DTStartDate";
			this.DTStartDate.Size = new global::System.Drawing.Size(218, 20);
			this.DTStartDate.TabIndex = 41;
			this.Button1.Location = new global::System.Drawing.Point(647, 137);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(137, 47);
			this.Button1.TabIndex = 39;
			this.Button1.Text = "Add Product To Report";
			this.Button1.UseVisualStyleBackColor = true;
			this.txtDesc.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtDesc.Enabled = false;
			this.txtDesc.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtDesc.ForeColor = global::System.Drawing.Color.Red;
			this.txtDesc.Location = new global::System.Drawing.Point(344, 107);
			this.txtDesc.Multiline = true;
			this.txtDesc.Name = "txtDesc";
			this.txtDesc.ReadOnly = true;
			this.txtDesc.Size = new global::System.Drawing.Size(297, 77);
			this.txtDesc.TabIndex = 38;
			this.txtDesc.TabStop = false;
			this.Label2.AutoSize = true;
			this.Label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label2.Location = new global::System.Drawing.Point(342, 87);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(165, 17);
			this.Label2.TabIndex = 37;
			this.Label2.Text = "View Product Description";
			this.txtSearchProductCode.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtSearchProductCode.Location = new global::System.Drawing.Point(897, 12);
			this.txtSearchProductCode.Name = "txtSearchProductCode";
			this.txtSearchProductCode.Size = new global::System.Drawing.Size(122, 26);
			this.txtSearchProductCode.TabIndex = 35;
			this.txtSearchProductCode.TabStop = false;
			this.txtSearchProductCode.Visible = false;
			this.lblerror.AutoSize = true;
			this.lblerror.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.lblerror.Location = new global::System.Drawing.Point(319, 269);
			this.lblerror.Name = "lblerror";
			this.lblerror.Size = new global::System.Drawing.Size(16, 13);
			this.lblerror.TabIndex = 31;
			this.lblerror.Text = "...";
			this.Panel2.BackColor = global::System.Drawing.Color.FromArgb(192, 255, 255);
			this.Panel2.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.Panel2.Controls.Add(this.DGVSearch);
			this.Panel2.Controls.Add(this.GroupBox4);
			this.Panel2.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.Panel2.Location = new global::System.Drawing.Point(3, 16);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new global::System.Drawing.Size(316, 266);
			this.Panel2.TabIndex = 30;
			this.DGVSearch.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DGVSearch.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.DGVSearch.Location = new global::System.Drawing.Point(0, 69);
			this.DGVSearch.Name = "DGVSearch";
			this.DGVSearch.ReadOnly = true;
			this.DGVSearch.Size = new global::System.Drawing.Size(312, 193);
			this.DGVSearch.StandardTab = true;
			this.DGVSearch.TabIndex = 2;
			this.GroupBox4.Controls.Add(this.Button3);
			this.GroupBox4.Controls.Add(this.Label19);
			this.GroupBox4.Controls.Add(this.txtsearch);
			this.GroupBox4.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox4.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox4.Name = "GroupBox4";
			this.GroupBox4.Size = new global::System.Drawing.Size(312, 69);
			this.GroupBox4.TabIndex = 1;
			this.GroupBox4.TabStop = false;
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
			this.Label19.TabIndex = 0;
			this.Label19.Text = "Type in the space to search by product description:";
			this.txtsearch.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtsearch.Location = new global::System.Drawing.Point(8, 34);
			this.txtsearch.Name = "txtsearch";
			this.txtsearch.Size = new global::System.Drawing.Size(219, 29);
			this.txtsearch.TabIndex = 1;
			this.dgvItems.AllowUserToAddRows = false;
			this.dgvItems.AllowUserToDeleteRows = false;
			this.dgvItems.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvItems.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.ProductID, this.ProductCode, this.ProductDesc, this.OpeningStock, this.StockPurchases, this.UnitCost, this.UnitsSold, this.TotalCost, this.SellingPrice, this.TotalSelling,
				this.GrossProfit, this.ClosingStock
			});
			this.dgvItems.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dgvItems.Location = new global::System.Drawing.Point(0, 285);
			this.dgvItems.Name = "dgvItems";
			this.dgvItems.ReadOnly = true;
			this.dgvItems.Size = new global::System.Drawing.Size(1107, 227);
			this.dgvItems.TabIndex = 1;
			this.ProductID.HeaderText = "Product_ID";
			this.ProductID.Name = "ProductID";
			this.ProductID.ReadOnly = true;
			this.ProductCode.HeaderText = "Product_Code";
			this.ProductCode.Name = "ProductCode";
			this.ProductCode.ReadOnly = true;
			this.ProductDesc.HeaderText = "Product Description";
			this.ProductDesc.Name = "ProductDesc";
			this.ProductDesc.ReadOnly = true;
			this.OpeningStock.HeaderText = "Opening Stock";
			this.OpeningStock.Name = "OpeningStock";
			this.OpeningStock.ReadOnly = true;
			this.StockPurchases.HeaderText = "Stock In";
			this.StockPurchases.Name = "StockPurchases";
			this.StockPurchases.ReadOnly = true;
			this.UnitCost.HeaderText = "Unit Cost";
			this.UnitCost.Name = "UnitCost";
			this.UnitCost.ReadOnly = true;
			this.UnitsSold.HeaderText = "Units Sold";
			this.UnitsSold.Name = "UnitsSold";
			this.UnitsSold.ReadOnly = true;
			this.TotalCost.HeaderText = "TotalCost";
			this.TotalCost.Name = "TotalCost";
			this.TotalCost.ReadOnly = true;
			this.SellingPrice.HeaderText = "Selling Price";
			this.SellingPrice.Name = "SellingPrice";
			this.SellingPrice.ReadOnly = true;
			this.TotalSelling.HeaderText = "Total Selling";
			this.TotalSelling.Name = "TotalSelling";
			this.TotalSelling.ReadOnly = true;
			this.GrossProfit.HeaderText = "Gross Profit";
			this.GrossProfit.Name = "GrossProfit";
			this.GrossProfit.ReadOnly = true;
			this.ClosingStock.HeaderText = "Closing Stock";
			this.ClosingStock.Name = "ClosingStock";
			this.ClosingStock.ReadOnly = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1107, 512);
			base.Controls.Add(this.dgvItems);
			base.Controls.Add(this.GroupBox1);
			base.Name = "ConsignmentReport";
			this.Text = "ConsignmentReport";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.Panel2.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.DGVSearch).EndInit();
			this.GroupBox4.ResumeLayout(false);
			this.GroupBox4.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvItems).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000413 RID: 1043
		private global::System.ComponentModel.IContainer components;
	}
}
