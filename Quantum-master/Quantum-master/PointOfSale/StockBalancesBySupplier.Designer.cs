namespace PointOfSale
{
	// Token: 0x020001E6 RID: 486
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class StockBalancesBySupplier : global::System.Windows.Forms.UserControl
	{
		// Token: 0x06005561 RID: 21857 RVA: 0x00315D94 File Offset: 0x00313F94
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

		// Token: 0x06005562 RID: 21858 RVA: 0x00315DE4 File Offset: 0x00313FE4
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.Button2 = new global::System.Windows.Forms.Button();
			this.lblprodcount = new global::System.Windows.Forms.Label();
			this.Label8 = new global::System.Windows.Forms.Label();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.Label6 = new global::System.Windows.Forms.Label();
			this.cboSupplier = new global::System.Windows.Forms.ComboBox();
			this.lblerror = new global::System.Windows.Forms.Label();
			this.txtProductCode = new global::System.Windows.Forms.TextBox();
			this.Panel2 = new global::System.Windows.Forms.Panel();
			this.DGVSearch = new global::System.Windows.Forms.DataGridView();
			this.GroupBox4 = new global::System.Windows.Forms.GroupBox();
			this.Button3 = new global::System.Windows.Forms.Button();
			this.Label19 = new global::System.Windows.Forms.Label();
			this.txtsearch = new global::System.Windows.Forms.TextBox();
			this.lblValue = new global::System.Windows.Forms.Label();
			this.Label7 = new global::System.Windows.Forms.Label();
			this.lblCost = new global::System.Windows.Forms.Label();
			this.Label5 = new global::System.Windows.Forms.Label();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.dgvproducts = new global::System.Windows.Forms.DataGridView();
			this.SaveFileDialog1 = new global::System.Windows.Forms.SaveFileDialog();
			this.GroupBox1.SuspendLayout();
			this.Panel2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.DGVSearch).BeginInit();
			this.GroupBox4.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvproducts).BeginInit();
			base.SuspendLayout();
			this.GroupBox1.Controls.Add(this.Button2);
			this.GroupBox1.Controls.Add(this.lblprodcount);
			this.GroupBox1.Controls.Add(this.Label8);
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Controls.Add(this.Label6);
			this.GroupBox1.Controls.Add(this.cboSupplier);
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
			this.GroupBox1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Padding = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GroupBox1.Size = new global::System.Drawing.Size(1464, 274);
			this.GroupBox1.TabIndex = 2;
			this.GroupBox1.TabStop = false;
			this.Button2.BackColor = global::System.Drawing.Color.Yellow;
			this.Button2.Location = new global::System.Drawing.Point(1166, 62);
			this.Button2.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Button2.Name = "Button2";
			this.Button2.Size = new global::System.Drawing.Size(267, 35);
			this.Button2.TabIndex = 41;
			this.Button2.Text = "EXPORT TO EXCEL";
			this.Button2.UseVisualStyleBackColor = false;
			this.lblprodcount.AutoSize = true;
			this.lblprodcount.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblprodcount.Location = new global::System.Drawing.Point(861, 114);
			this.lblprodcount.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblprodcount.Name = "lblprodcount";
			this.lblprodcount.Size = new global::System.Drawing.Size(24, 20);
			this.lblprodcount.TabIndex = 40;
			this.lblprodcount.Text = "...";
			this.Label8.AutoSize = true;
			this.Label8.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label8.Location = new global::System.Drawing.Point(546, 114);
			this.Label8.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label8.Name = "Label8";
			this.Label8.Size = new global::System.Drawing.Size(220, 20);
			this.Label8.TabIndex = 39;
			this.Label8.Text = "PRODUCT LIST COUNT:";
			this.Button1.BackColor = global::System.Drawing.Color.Lime;
			this.Button1.Location = new global::System.Drawing.Point(966, 62);
			this.Button1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(190, 35);
			this.Button1.TabIndex = 36;
			this.Button1.Text = "View Stock Balances";
			this.Button1.UseVisualStyleBackColor = false;
			this.Label6.AutoSize = true;
			this.Label6.Location = new global::System.Drawing.Point(548, 71);
			this.Label6.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label6.Name = "Label6";
			this.Label6.Size = new global::System.Drawing.Size(120, 20);
			this.Label6.TabIndex = 35;
			this.Label6.Text = "Select Supplier:";
			this.cboSupplier.FormattingEnabled = true;
			this.cboSupplier.Location = new global::System.Drawing.Point(684, 65);
			this.cboSupplier.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cboSupplier.Name = "cboSupplier";
			this.cboSupplier.Size = new global::System.Drawing.Size(271, 28);
			this.cboSupplier.TabIndex = 34;
			this.lblerror.AutoSize = true;
			this.lblerror.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.lblerror.Location = new global::System.Drawing.Point(476, 249);
			this.lblerror.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblerror.Name = "lblerror";
			this.lblerror.Size = new global::System.Drawing.Size(21, 20);
			this.lblerror.TabIndex = 33;
			this.lblerror.Text = "...";
			this.txtProductCode.Location = new global::System.Drawing.Point(1182, 20);
			this.txtProductCode.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtProductCode.Name = "txtProductCode";
			this.txtProductCode.Size = new global::System.Drawing.Size(148, 26);
			this.txtProductCode.TabIndex = 32;
			this.txtProductCode.Visible = false;
			this.Panel2.BackColor = global::System.Drawing.Color.FromArgb(192, 255, 255);
			this.Panel2.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.Panel2.Controls.Add(this.DGVSearch);
			this.Panel2.Controls.Add(this.GroupBox4);
			this.Panel2.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.Panel2.Location = new global::System.Drawing.Point(4, 24);
			this.Panel2.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new global::System.Drawing.Size(472, 245);
			this.Panel2.TabIndex = 31;
			this.DGVSearch.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DGVSearch.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.DGVSearch.Location = new global::System.Drawing.Point(0, 106);
			this.DGVSearch.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.DGVSearch.Name = "DGVSearch";
			this.DGVSearch.ReadOnly = true;
			this.DGVSearch.Size = new global::System.Drawing.Size(468, 135);
			this.DGVSearch.StandardTab = true;
			this.DGVSearch.TabIndex = 1;
			this.GroupBox4.Controls.Add(this.Button3);
			this.GroupBox4.Controls.Add(this.Label19);
			this.GroupBox4.Controls.Add(this.txtsearch);
			this.GroupBox4.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox4.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox4.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GroupBox4.Name = "GroupBox4";
			this.GroupBox4.Padding = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GroupBox4.Size = new global::System.Drawing.Size(468, 106);
			this.GroupBox4.TabIndex = 0;
			this.GroupBox4.TabStop = false;
			this.Button3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Button3.Location = new global::System.Drawing.Point(350, 49);
			this.Button3.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Button3.Name = "Button3";
			this.Button3.Size = new global::System.Drawing.Size(112, 48);
			this.Button3.TabIndex = 10;
			this.Button3.TabStop = false;
			this.Button3.Text = "Show All";
			this.Button3.UseVisualStyleBackColor = true;
			this.Label19.AutoSize = true;
			this.Label19.Location = new global::System.Drawing.Point(8, 20);
			this.Label19.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label19.Name = "Label19";
			this.Label19.Size = new global::System.Drawing.Size(366, 20);
			this.Label19.TabIndex = 9;
			this.Label19.Text = "Type in the space to search by product description:";
			this.txtsearch.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtsearch.Location = new global::System.Drawing.Point(12, 52);
			this.txtsearch.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtsearch.Name = "txtsearch";
			this.txtsearch.Size = new global::System.Drawing.Size(326, 39);
			this.txtsearch.TabIndex = 0;
			this.lblValue.AutoSize = true;
			this.lblValue.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblValue.Location = new global::System.Drawing.Point(861, 177);
			this.lblValue.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblValue.Name = "lblValue";
			this.lblValue.Size = new global::System.Drawing.Size(24, 20);
			this.lblValue.TabIndex = 11;
			this.lblValue.Text = "...";
			this.Label7.AutoSize = true;
			this.Label7.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label7.Location = new global::System.Drawing.Point(548, 177);
			this.Label7.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label7.Name = "Label7";
			this.Label7.Size = new global::System.Drawing.Size(304, 20);
			this.Label7.TabIndex = 10;
			this.Label7.Text = "TOTAL SALES VALUE OF STOCK:";
			this.lblCost.AutoSize = true;
			this.lblCost.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblCost.Location = new global::System.Drawing.Point(861, 146);
			this.lblCost.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblCost.Name = "lblCost";
			this.lblCost.Size = new global::System.Drawing.Size(24, 20);
			this.lblCost.TabIndex = 9;
			this.lblCost.Text = "...";
			this.Label5.AutoSize = true;
			this.Label5.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label5.Location = new global::System.Drawing.Point(546, 146);
			this.Label5.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label5.Name = "Label5";
			this.Label5.Size = new global::System.Drawing.Size(229, 20);
			this.Label5.TabIndex = 8;
			this.Label5.Text = "TOTAL COST OF STOCK:";
			this.Label4.AutoSize = true;
			this.Label4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Italic, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label4.Location = new global::System.Drawing.Point(603, 217);
			this.Label4.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label4.Name = "Label4";
			this.Label4.Size = new global::System.Drawing.Size(377, 20);
			this.Label4.TabIndex = 7;
			this.Label4.Text = "*Product stock is now below the set reorder level.";
			this.Label2.AutoSize = true;
			this.Label2.BackColor = global::System.Drawing.Color.Yellow;
			this.Label2.Location = new global::System.Drawing.Point(548, 217);
			this.Label2.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(41, 20);
			this.Label2.TabIndex = 6;
			this.Label2.Text = "        ";
			this.Label3.AutoSize = true;
			this.Label3.BackColor = global::System.Drawing.Color.Red;
			this.Label3.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.Label3.Location = new global::System.Drawing.Point(1411, 24);
			this.Label3.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(49, 20);
			this.Label3.TabIndex = 5;
			this.Label3.Text = "Close";
			this.Label1.AutoSize = true;
			this.Label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label1.Location = new global::System.Drawing.Point(544, 20);
			this.Label1.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(395, 32);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "View Stock Levels by Supplier";
			this.dgvproducts.AllowUserToAddRows = false;
			this.dgvproducts.AllowUserToDeleteRows = false;
			this.dgvproducts.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvproducts.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dgvproducts.Location = new global::System.Drawing.Point(0, 274);
			this.dgvproducts.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dgvproducts.Name = "dgvproducts";
			this.dgvproducts.Size = new global::System.Drawing.Size(1464, 349);
			this.dgvproducts.TabIndex = 3;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.Controls.Add(this.dgvproducts);
			base.Controls.Add(this.GroupBox1);
			base.Name = "StockBalancesBySupplier";
			base.Size = new global::System.Drawing.Size(1464, 623);
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.Panel2.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.DGVSearch).EndInit();
			this.GroupBox4.ResumeLayout(false);
			this.GroupBox4.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvproducts).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04002546 RID: 9542
		private global::System.ComponentModel.IContainer components;
	}
}
