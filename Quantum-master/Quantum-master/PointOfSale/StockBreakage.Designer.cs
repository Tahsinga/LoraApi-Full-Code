namespace PointOfSale
{
	// Token: 0x020001E7 RID: 487
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class StockBreakage : global::System.Windows.Forms.UserControl
	{
		// Token: 0x060055A6 RID: 21926 RVA: 0x00318168 File Offset: 0x00316368
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

		// Token: 0x060055A7 RID: 21927 RVA: 0x003181B8 File Offset: 0x003163B8
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.Label5 = new global::System.Windows.Forms.Label();
			this.cboBranch = new global::System.Windows.Forms.ComboBox();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.DTdate = new global::System.Windows.Forms.DateTimePicker();
			this.GroupBox2 = new global::System.Windows.Forms.GroupBox();
			this.Button2 = new global::System.Windows.Forms.Button();
			this.txtQty = new global::System.Windows.Forms.TextBox();
			this.Label8 = new global::System.Windows.Forms.Label();
			this.txtDetail = new global::System.Windows.Forms.TextBox();
			this.Label7 = new global::System.Windows.Forms.Label();
			this.cboAnomalyTypes = new global::System.Windows.Forms.ComboBox();
			this.Label6 = new global::System.Windows.Forms.Label();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.txtStockAvail = new global::System.Windows.Forms.TextBox();
			this.txtDesc = new global::System.Windows.Forms.TextBox();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.Panel2 = new global::System.Windows.Forms.Panel();
			this.DGVSearch = new global::System.Windows.Forms.DataGridView();
			this.GroupBox4 = new global::System.Windows.Forms.GroupBox();
			this.Button3 = new global::System.Windows.Forms.Button();
			this.Label19 = new global::System.Windows.Forms.Label();
			this.txtsearch = new global::System.Windows.Forms.TextBox();
			this.txtProductCode = new global::System.Windows.Forms.TextBox();
			this.lblerror = new global::System.Windows.Forms.Label();
			this.GroupBox1.SuspendLayout();
			this.GroupBox2.SuspendLayout();
			this.Panel2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.DGVSearch).BeginInit();
			this.GroupBox4.SuspendLayout();
			base.SuspendLayout();
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.Label5);
			this.GroupBox1.Controls.Add(this.cboBranch);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Controls.Add(this.DTdate);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new global::System.Drawing.Size(1035, 104);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.Label3.AutoSize = true;
			this.Label3.BackColor = global::System.Drawing.Color.Red;
			this.Label3.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.Label3.Location = new global::System.Drawing.Point(999, 16);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(33, 13);
			this.Label3.TabIndex = 37;
			this.Label3.Text = "Close";
			this.Label5.AutoSize = true;
			this.Label5.Location = new global::System.Drawing.Point(19, 53);
			this.Label5.Name = "Label5";
			this.Label5.Size = new global::System.Drawing.Size(77, 13);
			this.Label5.TabIndex = 12;
			this.Label5.Text = "Select Branch:";
			this.cboBranch.FormattingEnabled = true;
			this.cboBranch.Location = new global::System.Drawing.Point(102, 50);
			this.cboBranch.Name = "cboBranch";
			this.cboBranch.Size = new global::System.Drawing.Size(172, 21);
			this.cboBranch.TabIndex = 11;
			this.Label1.AutoSize = true;
			this.Label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label1.Location = new global::System.Drawing.Point(285, 16);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(382, 20);
			this.Label1.TabIndex = 3;
			this.Label1.Text = "Record Stock Breakages and Other Anomalies";
			this.DTdate.Location = new global::System.Drawing.Point(829, 50);
			this.DTdate.Name = "DTdate";
			this.DTdate.Size = new global::System.Drawing.Size(200, 20);
			this.DTdate.TabIndex = 0;
			this.GroupBox2.Controls.Add(this.Button2);
			this.GroupBox2.Controls.Add(this.txtQty);
			this.GroupBox2.Controls.Add(this.Label8);
			this.GroupBox2.Controls.Add(this.txtDetail);
			this.GroupBox2.Controls.Add(this.Label7);
			this.GroupBox2.Controls.Add(this.cboAnomalyTypes);
			this.GroupBox2.Controls.Add(this.Label6);
			this.GroupBox2.Controls.Add(this.Label4);
			this.GroupBox2.Controls.Add(this.txtStockAvail);
			this.GroupBox2.Controls.Add(this.txtDesc);
			this.GroupBox2.Controls.Add(this.Label2);
			this.GroupBox2.Controls.Add(this.Panel2);
			this.GroupBox2.Controls.Add(this.txtProductCode);
			this.GroupBox2.Controls.Add(this.lblerror);
			this.GroupBox2.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.GroupBox2.Location = new global::System.Drawing.Point(0, 104);
			this.GroupBox2.Name = "GroupBox2";
			this.GroupBox2.Size = new global::System.Drawing.Size(1035, 469);
			this.GroupBox2.TabIndex = 1;
			this.GroupBox2.TabStop = false;
			this.Button2.BackColor = global::System.Drawing.Color.Lime;
			this.Button2.Location = new global::System.Drawing.Point(328, 293);
			this.Button2.Name = "Button2";
			this.Button2.Size = new global::System.Drawing.Size(252, 23);
			this.Button2.TabIndex = 46;
			this.Button2.Text = "Record Anomaly and Reduce Stock";
			this.Button2.UseVisualStyleBackColor = false;
			this.txtQty.Location = new global::System.Drawing.Point(465, 267);
			this.txtQty.Name = "txtQty";
			this.txtQty.Size = new global::System.Drawing.Size(78, 20);
			this.txtQty.TabIndex = 45;
			this.Label8.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label8.Location = new global::System.Drawing.Point(325, 268);
			this.Label8.Name = "Label8";
			this.Label8.Size = new global::System.Drawing.Size(137, 22);
			this.Label8.TabIndex = 44;
			this.Label8.Text = "Quantity Affected:";
			this.txtDetail.Location = new global::System.Drawing.Point(465, 233);
			this.txtDetail.Name = "txtDetail";
			this.txtDetail.Size = new global::System.Drawing.Size(281, 20);
			this.txtDetail.TabIndex = 43;
			this.Label7.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label7.Location = new global::System.Drawing.Point(322, 234);
			this.Label7.Name = "Label7";
			this.Label7.Size = new global::System.Drawing.Size(137, 22);
			this.Label7.TabIndex = 42;
			this.Label7.Text = "Detail:";
			this.cboAnomalyTypes.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboAnomalyTypes.FormattingEnabled = true;
			this.cboAnomalyTypes.Location = new global::System.Drawing.Point(465, 198);
			this.cboAnomalyTypes.Name = "cboAnomalyTypes";
			this.cboAnomalyTypes.Size = new global::System.Drawing.Size(163, 21);
			this.cboAnomalyTypes.TabIndex = 41;
			this.Label6.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label6.Location = new global::System.Drawing.Point(323, 199);
			this.Label6.Name = "Label6";
			this.Label6.Size = new global::System.Drawing.Size(158, 22);
			this.Label6.TabIndex = 40;
			this.Label6.Text = "Stock Anomaly Type:";
			this.Label4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label4.Location = new global::System.Drawing.Point(325, 158);
			this.Label4.Name = "Label4";
			this.Label4.Size = new global::System.Drawing.Size(134, 22);
			this.Label4.TabIndex = 39;
			this.Label4.Text = "Stock Available";
			this.txtStockAvail.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtStockAvail.Enabled = false;
			this.txtStockAvail.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtStockAvail.ForeColor = global::System.Drawing.Color.Red;
			this.txtStockAvail.Location = new global::System.Drawing.Point(465, 158);
			this.txtStockAvail.Name = "txtStockAvail";
			this.txtStockAvail.ReadOnly = true;
			this.txtStockAvail.Size = new global::System.Drawing.Size(78, 26);
			this.txtStockAvail.TabIndex = 38;
			this.txtStockAvail.TabStop = false;
			this.txtDesc.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtDesc.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtDesc.ForeColor = global::System.Drawing.Color.Red;
			this.txtDesc.Location = new global::System.Drawing.Point(325, 87);
			this.txtDesc.Multiline = true;
			this.txtDesc.Name = "txtDesc";
			this.txtDesc.ReadOnly = true;
			this.txtDesc.Size = new global::System.Drawing.Size(567, 59);
			this.txtDesc.TabIndex = 37;
			this.txtDesc.TabStop = false;
			this.Label2.AutoSize = true;
			this.Label2.Location = new global::System.Drawing.Point(330, 59);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(91, 13);
			this.Label2.TabIndex = 36;
			this.Label2.Text = "Search Bar Code:";
			this.Label2.Visible = false;
			this.Panel2.BackColor = global::System.Drawing.Color.FromArgb(192, 255, 255);
			this.Panel2.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.Panel2.Controls.Add(this.DGVSearch);
			this.Panel2.Controls.Add(this.GroupBox4);
			this.Panel2.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.Panel2.Location = new global::System.Drawing.Point(3, 16);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new global::System.Drawing.Size(316, 437);
			this.Panel2.TabIndex = 30;
			this.DGVSearch.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DGVSearch.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.DGVSearch.Location = new global::System.Drawing.Point(0, 69);
			this.DGVSearch.Name = "DGVSearch";
			this.DGVSearch.ReadOnly = true;
			this.DGVSearch.Size = new global::System.Drawing.Size(312, 364);
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
			this.txtProductCode.Location = new global::System.Drawing.Point(427, 56);
			this.txtProductCode.Name = "txtProductCode";
			this.txtProductCode.Size = new global::System.Drawing.Size(210, 20);
			this.txtProductCode.TabIndex = 35;
			this.txtProductCode.Visible = false;
			this.lblerror.AutoSize = true;
			this.lblerror.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.lblerror.Location = new global::System.Drawing.Point(3, 453);
			this.lblerror.Name = "lblerror";
			this.lblerror.Size = new global::System.Drawing.Size(16, 13);
			this.lblerror.TabIndex = 34;
			this.lblerror.Text = "...";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.Controls.Add(this.GroupBox2);
			base.Controls.Add(this.GroupBox1);
			base.Name = "StockBreakage";
			base.Size = new global::System.Drawing.Size(1035, 573);
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.GroupBox2.ResumeLayout(false);
			this.GroupBox2.PerformLayout();
			this.Panel2.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.DGVSearch).EndInit();
			this.GroupBox4.ResumeLayout(false);
			this.GroupBox4.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04002563 RID: 9571
		private global::System.ComponentModel.IContainer components;
	}
}
