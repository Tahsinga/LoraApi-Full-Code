namespace PointOfSale
{
	// Token: 0x020001F5 RID: 501
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class StockTakeExcel : global::System.Windows.Forms.Form
	{
		// Token: 0x0600593A RID: 22842 RVA: 0x00336E20 File Offset: 0x00335020
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

		// Token: 0x0600593B RID: 22843 RVA: 0x00336E70 File Offset: 0x00335070
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.ProgressBar1 = new global::System.Windows.Forms.ProgressBar();
			this.Label5 = new global::System.Windows.Forms.Label();
			this.lblinfor = new global::System.Windows.Forms.Label();
			this.Panel2 = new global::System.Windows.Forms.Panel();
			this.DGVSearch = new global::System.Windows.Forms.DataGridView();
			this.GroupBox4 = new global::System.Windows.Forms.GroupBox();
			this.Button3 = new global::System.Windows.Forms.Button();
			this.Label19 = new global::System.Windows.Forms.Label();
			this.txtsearch = new global::System.Windows.Forms.TextBox();
			this.DataGridView1 = new global::System.Windows.Forms.DataGridView();
			this.txtProductCode = new global::System.Windows.Forms.TextBox();
			this.lblerror = new global::System.Windows.Forms.Label();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.DTdate = new global::System.Windows.Forms.DateTimePicker();
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.cboIncStockBal = new global::System.Windows.Forms.CheckBox();
			this.chkRecordAll = new global::System.Windows.Forms.CheckBox();
			this.DataGridView2 = new global::System.Windows.Forms.DataGridView();
			this.Button4 = new global::System.Windows.Forms.Button();
			this.TextBox2 = new global::System.Windows.Forms.TextBox();
			this.Button2 = new global::System.Windows.Forms.Button();
			this.OpenFileDialog1 = new global::System.Windows.Forms.OpenFileDialog();
			this.SaveFileDialog1 = new global::System.Windows.Forms.SaveFileDialog();
			this.chkCostPrice = new global::System.Windows.Forms.CheckBox();
			this.Panel2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.DGVSearch).BeginInit();
			this.GroupBox4.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.DataGridView1).BeginInit();
			this.GroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.DataGridView2).BeginInit();
			base.SuspendLayout();
			this.ProgressBar1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.ProgressBar1.Location = new global::System.Drawing.Point(0, 430);
			this.ProgressBar1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ProgressBar1.Name = "ProgressBar1";
			this.ProgressBar1.Size = new global::System.Drawing.Size(1343, 35);
			this.ProgressBar1.TabIndex = 5;
			this.ProgressBar1.Visible = false;
			this.Label5.AutoSize = true;
			this.Label5.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label5.Location = new global::System.Drawing.Point(488, 208);
			this.Label5.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label5.Name = "Label5";
			this.Label5.Size = new global::System.Drawing.Size(662, 22);
			this.Label5.TabIndex = 37;
			this.Label5.Text = "*Rows highlighted in blue are vouchers and that stock cannot be edited from here.";
			this.lblinfor.AutoSize = true;
			this.lblinfor.Location = new global::System.Drawing.Point(498, 383);
			this.lblinfor.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblinfor.Name = "lblinfor";
			this.lblinfor.Size = new global::System.Drawing.Size(29, 20);
			this.lblinfor.TabIndex = 36;
			this.lblinfor.Text = ".....";
			this.Panel2.BackColor = global::System.Drawing.Color.FromArgb(192, 255, 255);
			this.Panel2.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.Panel2.Controls.Add(this.DGVSearch);
			this.Panel2.Controls.Add(this.GroupBox4);
			this.Panel2.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.Panel2.Location = new global::System.Drawing.Point(4, 24);
			this.Panel2.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new global::System.Drawing.Size(472, 381);
			this.Panel2.TabIndex = 30;
			this.DGVSearch.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DGVSearch.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.DGVSearch.Location = new global::System.Drawing.Point(0, 106);
			this.DGVSearch.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.DGVSearch.Name = "DGVSearch";
			this.DGVSearch.ReadOnly = true;
			this.DGVSearch.Size = new global::System.Drawing.Size(468, 271);
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
			this.DataGridView1.AllowUserToAddRows = false;
			this.DataGridView1.AllowUserToDeleteRows = false;
			this.DataGridView1.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridView1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.DataGridView1.Location = new global::System.Drawing.Point(0, 430);
			this.DataGridView1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.DataGridView1.Name = "DataGridView1";
			this.DataGridView1.Size = new global::System.Drawing.Size(1343, 432);
			this.DataGridView1.TabIndex = 4;
			this.txtProductCode.Location = new global::System.Drawing.Point(492, 300);
			this.txtProductCode.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtProductCode.Name = "txtProductCode";
			this.txtProductCode.Size = new global::System.Drawing.Size(148, 26);
			this.txtProductCode.TabIndex = 35;
			this.txtProductCode.Visible = false;
			this.lblerror.AutoSize = true;
			this.lblerror.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.lblerror.Location = new global::System.Drawing.Point(4, 405);
			this.lblerror.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblerror.Name = "lblerror";
			this.lblerror.Size = new global::System.Drawing.Size(21, 20);
			this.lblerror.TabIndex = 34;
			this.lblerror.Text = "...";
			this.Label4.AutoSize = true;
			this.Label4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label4.Location = new global::System.Drawing.Point(488, 174);
			this.Label4.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label4.Name = "Label4";
			this.Label4.Size = new global::System.Drawing.Size(560, 22);
			this.Label4.TabIndex = 5;
			this.Label4.Text = "*Blanks on the Physical Stock count column will be considered zeros.";
			this.Label3.AutoSize = true;
			this.Label3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label3.Location = new global::System.Drawing.Point(488, 145);
			this.Label3.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(617, 22);
			this.Label3.TabIndex = 4;
			this.Label3.Text = "*Stock reduced will be considered a loss and will NOT be considered a sale.";
			this.Label2.AutoSize = true;
			this.Label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label2.Location = new global::System.Drawing.Point(488, 108);
			this.Label2.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(539, 25);
			this.Label2.TabIndex = 3;
			this.Label2.Text = "Enter physical stock count and adjust system stock quantities";
			this.Label1.AutoSize = true;
			this.Label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label1.Location = new global::System.Drawing.Point(488, 72);
			this.Label1.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(268, 29);
			this.Label1.TabIndex = 2;
			this.Label1.Text = "Conduct a Stock Take";
			this.Button1.BackColor = global::System.Drawing.Color.Lime;
			this.Button1.Location = new global::System.Drawing.Point(501, 348);
			this.Button1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(264, 35);
			this.Button1.TabIndex = 1;
			this.Button1.Text = "Adjust Stock Quantities";
			this.Button1.UseVisualStyleBackColor = false;
			this.DTdate.Location = new global::System.Drawing.Point(1034, 18);
			this.DTdate.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.DTdate.Name = "DTdate";
			this.DTdate.Size = new global::System.Drawing.Size(298, 26);
			this.DTdate.TabIndex = 0;
			this.GroupBox1.Controls.Add(this.chkCostPrice);
			this.GroupBox1.Controls.Add(this.cboIncStockBal);
			this.GroupBox1.Controls.Add(this.chkRecordAll);
			this.GroupBox1.Controls.Add(this.DataGridView2);
			this.GroupBox1.Controls.Add(this.Button4);
			this.GroupBox1.Controls.Add(this.TextBox2);
			this.GroupBox1.Controls.Add(this.Button2);
			this.GroupBox1.Controls.Add(this.Label5);
			this.GroupBox1.Controls.Add(this.lblinfor);
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
			this.GroupBox1.Size = new global::System.Drawing.Size(1343, 430);
			this.GroupBox1.TabIndex = 3;
			this.GroupBox1.TabStop = false;
			this.cboIncStockBal.AutoSize = true;
			this.cboIncStockBal.Location = new global::System.Drawing.Point(776, 261);
			this.cboIncStockBal.Name = "cboIncStockBal";
			this.cboIncStockBal.Size = new global::System.Drawing.Size(211, 24);
			this.cboIncStockBal.TabIndex = 43;
			this.cboIncStockBal.Text = "Include Stock Balances?";
			this.cboIncStockBal.UseVisualStyleBackColor = true;
			this.chkRecordAll.AutoSize = true;
			this.chkRecordAll.Location = new global::System.Drawing.Point(776, 352);
			this.chkRecordAll.Name = "chkRecordAll";
			this.chkRecordAll.Size = new global::System.Drawing.Size(553, 24);
			this.chkRecordAll.TabIndex = 42;
			this.chkRecordAll.Text = "Record all including no change transactions? (Necessary for Multi-branch)";
			this.chkRecordAll.UseVisualStyleBackColor = true;
			this.DataGridView2.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridView2.Location = new global::System.Drawing.Point(526, -28);
			this.DataGridView2.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.DataGridView2.Name = "DataGridView2";
			this.DataGridView2.Size = new global::System.Drawing.Size(360, 231);
			this.DataGridView2.TabIndex = 41;
			this.DataGridView2.Visible = false;
			this.Button4.Location = new global::System.Drawing.Point(501, 250);
			this.Button4.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Button4.Name = "Button4";
			this.Button4.Size = new global::System.Drawing.Size(262, 35);
			this.Button4.TabIndex = 40;
			this.Button4.Text = "Download TXT Stock file";
			this.Button4.UseVisualStyleBackColor = true;
			this.TextBox2.Location = new global::System.Drawing.Point(776, 303);
			this.TextBox2.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.TextBox2.Name = "TextBox2";
			this.TextBox2.Size = new global::System.Drawing.Size(492, 26);
			this.TextBox2.TabIndex = 39;
			this.Button2.BackColor = global::System.Drawing.Color.Cyan;
			this.Button2.Location = new global::System.Drawing.Point(502, 289);
			this.Button2.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Button2.Name = "Button2";
			this.Button2.Size = new global::System.Drawing.Size(264, 55);
			this.Button2.TabIndex = 38;
			this.Button2.Text = "Upload TXT file with balances (remove cost/selling prices)";
			this.Button2.UseVisualStyleBackColor = false;
			this.OpenFileDialog1.FileName = "OpenFileDialog1";
			this.chkCostPrice.AutoSize = true;
			this.chkCostPrice.Location = new global::System.Drawing.Point(1005, 261);
			this.chkCostPrice.Name = "chkCostPrice";
			this.chkCostPrice.Size = new global::System.Drawing.Size(254, 24);
			this.chkCostPrice.TabIndex = 44;
			this.chkCostPrice.Text = "Include Cost and Selling Price?";
			this.chkCostPrice.UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1343, 862);
			base.Controls.Add(this.ProgressBar1);
			base.Controls.Add(this.DataGridView1);
			base.Controls.Add(this.GroupBox1);
			base.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			base.Name = "StockTakeExcel";
			this.Text = "StockTakeExcel";
			this.Panel2.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.DGVSearch).EndInit();
			this.GroupBox4.ResumeLayout(false);
			this.GroupBox4.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.DataGridView1).EndInit();
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.DataGridView2).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x040026EE RID: 9966
		private global::System.ComponentModel.IContainer components;
	}
}
