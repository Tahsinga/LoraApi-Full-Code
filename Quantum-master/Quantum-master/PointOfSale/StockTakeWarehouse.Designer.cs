namespace PointOfSale
{
	// Token: 0x020001F6 RID: 502
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class StockTakeWarehouse : global::System.Windows.Forms.Form
	{
		// Token: 0x0600597E RID: 22910 RVA: 0x0033A114 File Offset: 0x00338314
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

		// Token: 0x0600597F RID: 22911 RVA: 0x0033A164 File Offset: 0x00338364
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.Button7 = new global::System.Windows.Forms.Button();
			this.Button6 = new global::System.Windows.Forms.Button();
			this.Button5 = new global::System.Windows.Forms.Button();
			this.Button4 = new global::System.Windows.Forms.Button();
			this.Button2 = new global::System.Windows.Forms.Button();
			this.lblproductcount = new global::System.Windows.Forms.Label();
			this.Panel2 = new global::System.Windows.Forms.Panel();
			this.DGVSearch = new global::System.Windows.Forms.DataGridView();
			this.GroupBox4 = new global::System.Windows.Forms.GroupBox();
			this.Button3 = new global::System.Windows.Forms.Button();
			this.Label19 = new global::System.Windows.Forms.Label();
			this.txtsearch = new global::System.Windows.Forms.TextBox();
			this.txtProductCode = new global::System.Windows.Forms.TextBox();
			this.lblerror = new global::System.Windows.Forms.Label();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.DTdate = new global::System.Windows.Forms.DateTimePicker();
			this.dgvProducts = new global::System.Windows.Forms.DataGridView();
			this.ProgressBar1 = new global::System.Windows.Forms.ProgressBar();
			this.GroupBox1.SuspendLayout();
			this.Panel2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.DGVSearch).BeginInit();
			this.GroupBox4.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvProducts).BeginInit();
			base.SuspendLayout();
			this.GroupBox1.Controls.Add(this.Button7);
			this.GroupBox1.Controls.Add(this.Button6);
			this.GroupBox1.Controls.Add(this.Button5);
			this.GroupBox1.Controls.Add(this.Button4);
			this.GroupBox1.Controls.Add(this.Button2);
			this.GroupBox1.Controls.Add(this.lblproductcount);
			this.GroupBox1.Controls.Add(this.Panel2);
			this.GroupBox1.Controls.Add(this.txtProductCode);
			this.GroupBox1.Controls.Add(this.lblerror);
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Controls.Add(this.DTdate);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Padding = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GroupBox1.Size = new global::System.Drawing.Size(1534, 360);
			this.GroupBox1.TabIndex = 1;
			this.GroupBox1.TabStop = false;
			this.Button7.Location = new global::System.Drawing.Point(1218, 66);
			this.Button7.Name = "Button7";
			this.Button7.Size = new global::System.Drawing.Size(304, 37);
			this.Button7.TabIndex = 41;
			this.Button7.Text = "REDO QUICK STOCK BAL";
			this.Button7.UseVisualStyleBackColor = true;
			this.Button6.BackColor = global::System.Drawing.Color.BlueViolet;
			this.Button6.Location = new global::System.Drawing.Point(1218, 181);
			this.Button6.Name = "Button6";
			this.Button6.Size = new global::System.Drawing.Size(304, 66);
			this.Button6.TabIndex = 40;
			this.Button6.Text = "Show Products with a non zero Balance";
			this.Button6.UseVisualStyleBackColor = false;
			this.Button5.BackColor = global::System.Drawing.Color.SpringGreen;
			this.Button5.Location = new global::System.Drawing.Point(1218, 109);
			this.Button5.Name = "Button5";
			this.Button5.Size = new global::System.Drawing.Size(304, 66);
			this.Button5.TabIndex = 39;
			this.Button5.Text = "Show All Products including zero Balances";
			this.Button5.UseVisualStyleBackColor = false;
			this.Button4.BackColor = global::System.Drawing.Color.Aqua;
			this.Button4.Location = new global::System.Drawing.Point(1218, 277);
			this.Button4.Name = "Button4";
			this.Button4.Size = new global::System.Drawing.Size(304, 32);
			this.Button4.TabIndex = 38;
			this.Button4.Text = "Put Zero on Selected Product Balances";
			this.Button4.UseVisualStyleBackColor = false;
			this.Button2.BackColor = global::System.Drawing.Color.Yellow;
			this.Button2.Location = new global::System.Drawing.Point(1218, 315);
			this.Button2.Name = "Button2";
			this.Button2.Size = new global::System.Drawing.Size(304, 37);
			this.Button2.TabIndex = 37;
			this.Button2.Text = "Put Zero on all Physical Stock Balances";
			this.Button2.UseVisualStyleBackColor = false;
			this.lblproductcount.AutoSize = true;
			this.lblproductcount.Location = new global::System.Drawing.Point(494, 335);
			this.lblproductcount.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblproductcount.Name = "lblproductcount";
			this.lblproductcount.Size = new global::System.Drawing.Size(21, 20);
			this.lblproductcount.TabIndex = 36;
			this.lblproductcount.Text = "...";
			this.Panel2.BackColor = global::System.Drawing.Color.FromArgb(192, 255, 255);
			this.Panel2.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.Panel2.Controls.Add(this.DGVSearch);
			this.Panel2.Controls.Add(this.GroupBox4);
			this.Panel2.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.Panel2.Location = new global::System.Drawing.Point(4, 24);
			this.Panel2.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new global::System.Drawing.Size(472, 311);
			this.Panel2.TabIndex = 30;
			this.DGVSearch.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DGVSearch.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.DGVSearch.Location = new global::System.Drawing.Point(0, 106);
			this.DGVSearch.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.DGVSearch.Name = "DGVSearch";
			this.DGVSearch.ReadOnly = true;
			this.DGVSearch.Size = new global::System.Drawing.Size(468, 201);
			this.DGVSearch.StandardTab = true;
			this.DGVSearch.TabIndex = 2;
			this.GroupBox4.Controls.Add(this.Button3);
			this.GroupBox4.Controls.Add(this.Label19);
			this.GroupBox4.Controls.Add(this.txtsearch);
			this.GroupBox4.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox4.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox4.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GroupBox4.Name = "GroupBox4";
			this.GroupBox4.Padding = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GroupBox4.Size = new global::System.Drawing.Size(468, 106);
			this.GroupBox4.TabIndex = 1;
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
			this.Label19.TabIndex = 0;
			this.Label19.Text = "Type in the space to search by product description:";
			this.txtsearch.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtsearch.Location = new global::System.Drawing.Point(12, 52);
			this.txtsearch.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtsearch.Name = "txtsearch";
			this.txtsearch.Size = new global::System.Drawing.Size(326, 39);
			this.txtsearch.TabIndex = 1;
			this.txtProductCode.Location = new global::System.Drawing.Point(492, 291);
			this.txtProductCode.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtProductCode.Name = "txtProductCode";
			this.txtProductCode.Size = new global::System.Drawing.Size(148, 26);
			this.txtProductCode.TabIndex = 35;
			this.txtProductCode.Visible = false;
			this.lblerror.AutoSize = true;
			this.lblerror.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.lblerror.Location = new global::System.Drawing.Point(4, 335);
			this.lblerror.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblerror.Name = "lblerror";
			this.lblerror.Size = new global::System.Drawing.Size(21, 20);
			this.lblerror.TabIndex = 34;
			this.lblerror.Text = "...";
			this.Label4.AutoSize = true;
			this.Label4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label4.Location = new global::System.Drawing.Point(488, 194);
			this.Label4.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label4.Name = "Label4";
			this.Label4.Size = new global::System.Drawing.Size(560, 22);
			this.Label4.TabIndex = 5;
			this.Label4.Text = "*Blanks on the Physical Stock count column will be considered zeros.";
			this.Label3.AutoSize = true;
			this.Label3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label3.Location = new global::System.Drawing.Point(488, 165);
			this.Label3.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(617, 22);
			this.Label3.TabIndex = 4;
			this.Label3.Text = "*Stock reduced will be considered a loss and will NOT be considered a sale.";
			this.Label2.AutoSize = true;
			this.Label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label2.Location = new global::System.Drawing.Point(488, 128);
			this.Label2.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(539, 25);
			this.Label2.TabIndex = 3;
			this.Label2.Text = "Enter physical stock count and adjust system stock quantities";
			this.Label1.AutoSize = true;
			this.Label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label1.Location = new global::System.Drawing.Point(492, 63);
			this.Label1.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(445, 29);
			this.Label1.TabIndex = 2;
			this.Label1.Text = "Conduct a Stock Take for Warehouse";
			this.Button1.Location = new global::System.Drawing.Point(648, 315);
			this.Button1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(360, 35);
			this.Button1.TabIndex = 1;
			this.Button1.Text = "Adjust Stock Quantities by Batch Numbers";
			this.Button1.UseVisualStyleBackColor = true;
			this.DTdate.Location = new global::System.Drawing.Point(1034, 18);
			this.DTdate.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.DTdate.Name = "DTdate";
			this.DTdate.Size = new global::System.Drawing.Size(298, 26);
			this.DTdate.TabIndex = 0;
			this.dgvProducts.AllowUserToAddRows = false;
			this.dgvProducts.AllowUserToDeleteRows = false;
			this.dgvProducts.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvProducts.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dgvProducts.Location = new global::System.Drawing.Point(0, 360);
			this.dgvProducts.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dgvProducts.Name = "dgvProducts";
			this.dgvProducts.Size = new global::System.Drawing.Size(1534, 386);
			this.dgvProducts.TabIndex = 2;
			this.ProgressBar1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.ProgressBar1.Location = new global::System.Drawing.Point(0, 360);
			this.ProgressBar1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ProgressBar1.Name = "ProgressBar1";
			this.ProgressBar1.Size = new global::System.Drawing.Size(1534, 35);
			this.ProgressBar1.TabIndex = 3;
			this.ProgressBar1.Visible = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1534, 746);
			base.Controls.Add(this.ProgressBar1);
			base.Controls.Add(this.dgvProducts);
			base.Controls.Add(this.GroupBox1);
			base.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			base.Name = "StockTakeWarehouse";
			this.Text = "StockTakeWarehouse";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.Panel2.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.DGVSearch).EndInit();
			this.GroupBox4.ResumeLayout(false);
			this.GroupBox4.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvProducts).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x0400270F RID: 9999
		private global::System.ComponentModel.IContainer components;
	}
}
