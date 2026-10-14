namespace PointOfSale
{
	// Token: 0x020001F3 RID: 499
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class StockTake1Item : global::System.Windows.Forms.Form
	{
		// Token: 0x06005828 RID: 22568 RVA: 0x0032AD94 File Offset: 0x00328F94
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

		// Token: 0x06005829 RID: 22569 RVA: 0x0032ADE4 File Offset: 0x00328FE4
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.DataGridView1 = new global::System.Windows.Forms.DataGridView();
			this.lblStockBal = new global::System.Windows.Forms.Label();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.DTdate = new global::System.Windows.Forms.DateTimePicker();
			this.chkViewAll = new global::System.Windows.Forms.CheckBox();
			this.txtSearchProductCode = new global::System.Windows.Forms.TextBox();
			this.Label9 = new global::System.Windows.Forms.Label();
			this.txtBarCode = new global::System.Windows.Forms.TextBox();
			this.Label15 = new global::System.Windows.Forms.Label();
			this.Button2 = new global::System.Windows.Forms.Button();
			this.Button8 = new global::System.Windows.Forms.Button();
			this.lblDesc = new global::System.Windows.Forms.Label();
			this.lblerror = new global::System.Windows.Forms.Label();
			this.Panel4 = new global::System.Windows.Forms.Panel();
			this.DGVSearch = new global::System.Windows.Forms.DataGridView();
			this.GroupBox4 = new global::System.Windows.Forms.GroupBox();
			this.Label10 = new global::System.Windows.Forms.Label();
			this.Button4 = new global::System.Windows.Forms.Button();
			this.Label16 = new global::System.Windows.Forms.Label();
			this.txtsearch = new global::System.Windows.Forms.TextBox();
			this.dgvProducts = new global::System.Windows.Forms.DataGridView();
			this.ProgressBar1 = new global::System.Windows.Forms.ProgressBar();
			this.chkRecordAll = new global::System.Windows.Forms.CheckBox();
			this.GroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.DataGridView1).BeginInit();
			this.Panel4.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.DGVSearch).BeginInit();
			this.GroupBox4.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvProducts).BeginInit();
			base.SuspendLayout();
			this.GroupBox1.Controls.Add(this.chkRecordAll);
			this.GroupBox1.Controls.Add(this.DataGridView1);
			this.GroupBox1.Controls.Add(this.lblStockBal);
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Controls.Add(this.DTdate);
			this.GroupBox1.Controls.Add(this.chkViewAll);
			this.GroupBox1.Controls.Add(this.txtSearchProductCode);
			this.GroupBox1.Controls.Add(this.Label9);
			this.GroupBox1.Controls.Add(this.txtBarCode);
			this.GroupBox1.Controls.Add(this.Label15);
			this.GroupBox1.Controls.Add(this.Button2);
			this.GroupBox1.Controls.Add(this.Button8);
			this.GroupBox1.Controls.Add(this.lblDesc);
			this.GroupBox1.Controls.Add(this.lblerror);
			this.GroupBox1.Controls.Add(this.Panel4);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new global::System.Drawing.Size(1343, 388);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.DataGridView1.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridView1.Location = new global::System.Drawing.Point(1060, 276);
			this.DataGridView1.Name = "DataGridView1";
			this.DataGridView1.RowTemplate.Height = 28;
			this.DataGridView1.Size = new global::System.Drawing.Size(213, 89);
			this.DataGridView1.TabIndex = 62;
			this.DataGridView1.Visible = false;
			this.lblStockBal.AutoSize = true;
			this.lblStockBal.Location = new global::System.Drawing.Point(708, 240);
			this.lblStockBal.Name = "lblStockBal";
			this.lblStockBal.Size = new global::System.Drawing.Size(21, 20);
			this.lblStockBal.TabIndex = 61;
			this.lblStockBal.Text = "...";
			this.Button1.Location = new global::System.Drawing.Point(1057, 202);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(286, 58);
			this.Button1.TabIndex = 60;
			this.Button1.Text = "Set Quick Stock Bal for this Product Only";
			this.Button1.UseVisualStyleBackColor = true;
			this.DTdate.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.DTdate.Location = new global::System.Drawing.Point(1042, 145);
			this.DTdate.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.DTdate.Name = "DTdate";
			this.DTdate.Size = new global::System.Drawing.Size(298, 26);
			this.DTdate.TabIndex = 59;
			this.chkViewAll.AutoSize = true;
			this.chkViewAll.Location = new global::System.Drawing.Point(952, 202);
			this.chkViewAll.Name = "chkViewAll";
			this.chkViewAll.Size = new global::System.Drawing.Size(99, 24);
			this.chkViewAll.TabIndex = 58;
			this.chkViewAll.Text = "View All?";
			this.chkViewAll.UseVisualStyleBackColor = true;
			this.txtSearchProductCode.Location = new global::System.Drawing.Point(525, 206);
			this.txtSearchProductCode.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtSearchProductCode.Name = "txtSearchProductCode";
			this.txtSearchProductCode.Size = new global::System.Drawing.Size(148, 26);
			this.txtSearchProductCode.TabIndex = 57;
			this.txtSearchProductCode.TabStop = false;
			this.txtSearchProductCode.Visible = false;
			this.Label9.AutoSize = true;
			this.Label9.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 7.5f, global::System.Drawing.FontStyle.Italic, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label9.ForeColor = global::System.Drawing.Color.Red;
			this.Label9.Location = new global::System.Drawing.Point(954, 165);
			this.Label9.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label9.Name = "Label9";
			this.Label9.Size = new global::System.Drawing.Size(25, 18);
			this.Label9.TabIndex = 56;
			this.Label9.Text = "F1";
			this.txtBarCode.Location = new global::System.Drawing.Point(712, 161);
			this.txtBarCode.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtBarCode.Name = "txtBarCode";
			this.txtBarCode.Size = new global::System.Drawing.Size(234, 26);
			this.txtBarCode.TabIndex = 54;
			this.Label15.AutoSize = true;
			this.Label15.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label15.Location = new global::System.Drawing.Point(480, 164);
			this.Label15.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label15.Name = "Label15";
			this.Label15.Size = new global::System.Drawing.Size(224, 20);
			this.Label15.TabIndex = 55;
			this.Label15.Text = "SEARCH BY BAR CODE:";
			this.Button2.BackColor = global::System.Drawing.Color.Lime;
			this.Button2.Location = new global::System.Drawing.Point(481, 308);
			this.Button2.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Button2.Name = "Button2";
			this.Button2.Size = new global::System.Drawing.Size(264, 35);
			this.Button2.TabIndex = 53;
			this.Button2.Text = "Adjust Stock Quantities";
			this.Button2.UseVisualStyleBackColor = false;
			this.Button8.Location = new global::System.Drawing.Point(712, 195);
			this.Button8.Name = "Button8";
			this.Button8.Size = new global::System.Drawing.Size(234, 37);
			this.Button8.TabIndex = 52;
			this.Button8.Text = "View Stock Balance";
			this.Button8.UseVisualStyleBackColor = true;
			this.lblDesc.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblDesc.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.lblDesc.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblDesc.Location = new global::System.Drawing.Point(475, 22);
			this.lblDesc.Name = "lblDesc";
			this.lblDesc.Size = new global::System.Drawing.Size(865, 123);
			this.lblDesc.TabIndex = 37;
			this.lblDesc.Text = "...";
			this.lblerror.AutoSize = true;
			this.lblerror.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.lblerror.Location = new global::System.Drawing.Point(475, 365);
			this.lblerror.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblerror.Name = "lblerror";
			this.lblerror.Size = new global::System.Drawing.Size(21, 20);
			this.lblerror.TabIndex = 36;
			this.lblerror.Text = "...";
			this.Panel4.BackColor = global::System.Drawing.Color.FromArgb(192, 255, 255);
			this.Panel4.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.Panel4.Controls.Add(this.DGVSearch);
			this.Panel4.Controls.Add(this.GroupBox4);
			this.Panel4.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.Panel4.Location = new global::System.Drawing.Point(3, 22);
			this.Panel4.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Panel4.Name = "Panel4";
			this.Panel4.Size = new global::System.Drawing.Size(472, 363);
			this.Panel4.TabIndex = 35;
			this.DGVSearch.AllowUserToAddRows = false;
			this.DGVSearch.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DGVSearch.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.DGVSearch.Location = new global::System.Drawing.Point(0, 106);
			this.DGVSearch.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.DGVSearch.Name = "DGVSearch";
			this.DGVSearch.ReadOnly = true;
			this.DGVSearch.Size = new global::System.Drawing.Size(468, 253);
			this.DGVSearch.TabIndex = 3;
			this.GroupBox4.Controls.Add(this.Label10);
			this.GroupBox4.Controls.Add(this.Button4);
			this.GroupBox4.Controls.Add(this.Label16);
			this.GroupBox4.Controls.Add(this.txtsearch);
			this.GroupBox4.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox4.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox4.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GroupBox4.Name = "GroupBox4";
			this.GroupBox4.Padding = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GroupBox4.Size = new global::System.Drawing.Size(468, 106);
			this.GroupBox4.TabIndex = 0;
			this.GroupBox4.TabStop = false;
			this.Label10.AutoSize = true;
			this.Label10.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 7.5f, global::System.Drawing.FontStyle.Italic, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label10.ForeColor = global::System.Drawing.Color.Red;
			this.Label10.Location = new global::System.Drawing.Point(388, 20);
			this.Label10.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label10.Name = "Label10";
			this.Label10.Size = new global::System.Drawing.Size(65, 18);
			this.Label10.TabIndex = 48;
			this.Label10.Text = "Page Up";
			this.Button4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Button4.Location = new global::System.Drawing.Point(350, 49);
			this.Button4.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Button4.Name = "Button4";
			this.Button4.Size = new global::System.Drawing.Size(112, 48);
			this.Button4.TabIndex = 10;
			this.Button4.TabStop = false;
			this.Button4.Text = "Show All";
			this.Button4.UseVisualStyleBackColor = true;
			this.Label16.AutoSize = true;
			this.Label16.Location = new global::System.Drawing.Point(8, 20);
			this.Label16.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label16.Name = "Label16";
			this.Label16.Size = new global::System.Drawing.Size(366, 20);
			this.Label16.TabIndex = 9;
			this.Label16.Text = "Type in the space to search by product description:";
			this.txtsearch.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtsearch.Location = new global::System.Drawing.Point(12, 52);
			this.txtsearch.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtsearch.Name = "txtsearch";
			this.txtsearch.Size = new global::System.Drawing.Size(326, 39);
			this.txtsearch.TabIndex = 3;
			this.dgvProducts.AllowUserToAddRows = false;
			this.dgvProducts.AllowUserToDeleteRows = false;
			this.dgvProducts.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvProducts.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dgvProducts.Location = new global::System.Drawing.Point(0, 388);
			this.dgvProducts.Name = "dgvProducts";
			this.dgvProducts.RowTemplate.Height = 28;
			this.dgvProducts.Size = new global::System.Drawing.Size(1343, 314);
			this.dgvProducts.TabIndex = 1;
			this.ProgressBar1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.ProgressBar1.Location = new global::System.Drawing.Point(0, 388);
			this.ProgressBar1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ProgressBar1.Name = "ProgressBar1";
			this.ProgressBar1.Size = new global::System.Drawing.Size(1343, 35);
			this.ProgressBar1.TabIndex = 4;
			this.ProgressBar1.Visible = false;
			this.chkRecordAll.AutoSize = true;
			this.chkRecordAll.Location = new global::System.Drawing.Point(752, 314);
			this.chkRecordAll.Name = "chkRecordAll";
			this.chkRecordAll.Size = new global::System.Drawing.Size(465, 24);
			this.chkRecordAll.TabIndex = 63;
			this.chkRecordAll.Text = "Record no change transactions? (necessary for multi branch)";
			this.chkRecordAll.UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1343, 702);
			base.Controls.Add(this.ProgressBar1);
			base.Controls.Add(this.dgvProducts);
			base.Controls.Add(this.GroupBox1);
			base.Name = "StockTake1Item";
			this.Text = "Stock Take for 1 Item";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.DataGridView1).EndInit();
			this.Panel4.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.DGVSearch).EndInit();
			this.GroupBox4.ResumeLayout(false);
			this.GroupBox4.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvProducts).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x0400267B RID: 9851
		private global::System.ComponentModel.IContainer components;
	}
}
