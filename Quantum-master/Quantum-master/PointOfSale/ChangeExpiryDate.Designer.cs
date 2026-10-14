namespace PointOfSale
{
	// Token: 0x0200001E RID: 30
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class ChangeExpiryDate : global::System.Windows.Forms.Form
	{
		// Token: 0x0600055F RID: 1375 RVA: 0x00035358 File Offset: 0x00033558
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

		// Token: 0x06000560 RID: 1376 RVA: 0x000353A8 File Offset: 0x000335A8
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.txtProductID = new global::System.Windows.Forms.TextBox();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.txtNewBatchNumber = new global::System.Windows.Forms.TextBox();
			this.Label6 = new global::System.Windows.Forms.Label();
			this.txtCurrentBatchNumber = new global::System.Windows.Forms.TextBox();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.DTNewExpiryDate = new global::System.Windows.Forms.DateTimePicker();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.DTCurrentExpDate = new global::System.Windows.Forms.DateTimePicker();
			this.txtDesc = new global::System.Windows.Forms.TextBox();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.lblDisplay = new global::System.Windows.Forms.Label();
			this.Label5 = new global::System.Windows.Forms.Label();
			this.cboBranchFrom = new global::System.Windows.Forms.ComboBox();
			this.lblerror = new global::System.Windows.Forms.Label();
			this.txtProductCode = new global::System.Windows.Forms.TextBox();
			this.Panel2 = new global::System.Windows.Forms.Panel();
			this.DGVSearch = new global::System.Windows.Forms.DataGridView();
			this.GroupBox4 = new global::System.Windows.Forms.GroupBox();
			this.Button3 = new global::System.Windows.Forms.Button();
			this.Label19 = new global::System.Windows.Forms.Label();
			this.txtsearch = new global::System.Windows.Forms.TextBox();
			this.dgvWarehouse = new global::System.Windows.Forms.DataGridView();
			this.GroupBox1.SuspendLayout();
			this.Panel2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.DGVSearch).BeginInit();
			this.GroupBox4.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvWarehouse).BeginInit();
			base.SuspendLayout();
			this.GroupBox1.Controls.Add(this.txtProductID);
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Controls.Add(this.txtNewBatchNumber);
			this.GroupBox1.Controls.Add(this.Label6);
			this.GroupBox1.Controls.Add(this.txtCurrentBatchNumber);
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.DTNewExpiryDate);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Controls.Add(this.DTCurrentExpDate);
			this.GroupBox1.Controls.Add(this.txtDesc);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.lblDisplay);
			this.GroupBox1.Controls.Add(this.Label5);
			this.GroupBox1.Controls.Add(this.cboBranchFrom);
			this.GroupBox1.Controls.Add(this.lblerror);
			this.GroupBox1.Controls.Add(this.txtProductCode);
			this.GroupBox1.Controls.Add(this.Panel2);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new global::System.Drawing.Size(1021, 284);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.txtProductID.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtProductID.Enabled = false;
			this.txtProductID.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtProductID.ForeColor = global::System.Drawing.Color.Red;
			this.txtProductID.Location = new global::System.Drawing.Point(699, 73);
			this.txtProductID.Multiline = true;
			this.txtProductID.Name = "txtProductID";
			this.txtProductID.ReadOnly = true;
			this.txtProductID.Size = new global::System.Drawing.Size(310, 27);
			this.txtProductID.TabIndex = 49;
			this.txtProductID.TabStop = false;
			this.txtProductID.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Right;
			this.Button1.BackColor = global::System.Drawing.Color.Lime;
			this.Button1.Location = new global::System.Drawing.Point(467, 217);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(200, 23);
			this.Button1.TabIndex = 48;
			this.Button1.Text = "Change Expiry Date";
			this.Button1.UseVisualStyleBackColor = false;
			this.txtNewBatchNumber.Location = new global::System.Drawing.Point(855, 192);
			this.txtNewBatchNumber.Name = "txtNewBatchNumber";
			this.txtNewBatchNumber.Size = new global::System.Drawing.Size(154, 20);
			this.txtNewBatchNumber.TabIndex = 47;
			this.Label6.AutoSize = true;
			this.Label6.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label6.Location = new global::System.Drawing.Point(716, 193);
			this.Label6.Name = "Label6";
			this.Label6.Size = new global::System.Drawing.Size(133, 17);
			this.Label6.TabIndex = 46;
			this.Label6.Text = "New Batch Number:";
			this.txtCurrentBatchNumber.Enabled = false;
			this.txtCurrentBatchNumber.Location = new global::System.Drawing.Point(855, 164);
			this.txtCurrentBatchNumber.Name = "txtCurrentBatchNumber";
			this.txtCurrentBatchNumber.Size = new global::System.Drawing.Size(154, 20);
			this.txtCurrentBatchNumber.TabIndex = 45;
			this.Label4.AutoSize = true;
			this.Label4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label4.Location = new global::System.Drawing.Point(696, 165);
			this.Label4.Name = "Label4";
			this.Label4.Size = new global::System.Drawing.Size(153, 17);
			this.Label4.TabIndex = 44;
			this.Label4.Text = "Current Batch Number:";
			this.Label3.AutoSize = true;
			this.Label3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label3.Location = new global::System.Drawing.Point(346, 193);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(115, 17);
			this.Label3.TabIndex = 43;
			this.Label3.Text = "New Expiry Date:";
			this.DTNewExpiryDate.Location = new global::System.Drawing.Point(467, 191);
			this.DTNewExpiryDate.Name = "DTNewExpiryDate";
			this.DTNewExpiryDate.Size = new global::System.Drawing.Size(200, 20);
			this.DTNewExpiryDate.TabIndex = 42;
			this.Label1.AutoSize = true;
			this.Label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label1.Location = new global::System.Drawing.Point(326, 165);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(135, 17);
			this.Label1.TabIndex = 41;
			this.Label1.Text = "Current Expiry Date:";
			this.DTCurrentExpDate.Enabled = false;
			this.DTCurrentExpDate.Location = new global::System.Drawing.Point(467, 165);
			this.DTCurrentExpDate.Name = "DTCurrentExpDate";
			this.DTCurrentExpDate.Size = new global::System.Drawing.Size(200, 20);
			this.DTCurrentExpDate.TabIndex = 40;
			this.txtDesc.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtDesc.Enabled = false;
			this.txtDesc.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtDesc.ForeColor = global::System.Drawing.Color.Red;
			this.txtDesc.Location = new global::System.Drawing.Point(325, 107);
			this.txtDesc.Multiline = true;
			this.txtDesc.Name = "txtDesc";
			this.txtDesc.ReadOnly = true;
			this.txtDesc.Size = new global::System.Drawing.Size(684, 46);
			this.txtDesc.TabIndex = 39;
			this.txtDesc.TabStop = false;
			this.Label2.AutoSize = true;
			this.Label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label2.Location = new global::System.Drawing.Point(326, 87);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(165, 17);
			this.Label2.TabIndex = 38;
			this.Label2.Text = "View Product Description";
			this.lblDisplay.AutoSize = true;
			this.lblDisplay.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.lblDisplay.ForeColor = global::System.Drawing.Color.Blue;
			this.lblDisplay.Location = new global::System.Drawing.Point(319, 268);
			this.lblDisplay.Name = "lblDisplay";
			this.lblDisplay.Size = new global::System.Drawing.Size(95, 13);
			this.lblDisplay.TabIndex = 37;
			this.lblDisplay.Text = "Stocks for Branch:";
			this.Label5.AutoSize = true;
			this.Label5.Location = new global::System.Drawing.Point(326, 26);
			this.Label5.Name = "Label5";
			this.Label5.Size = new global::System.Drawing.Size(44, 13);
			this.Label5.TabIndex = 36;
			this.Label5.Text = "Branch:";
			this.cboBranchFrom.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboBranchFrom.FormattingEnabled = true;
			this.cboBranchFrom.Location = new global::System.Drawing.Point(376, 23);
			this.cboBranchFrom.Name = "cboBranchFrom";
			this.cboBranchFrom.Size = new global::System.Drawing.Size(188, 21);
			this.cboBranchFrom.TabIndex = 35;
			this.lblerror.AutoSize = true;
			this.lblerror.Location = new global::System.Drawing.Point(319, 59);
			this.lblerror.Name = "lblerror";
			this.lblerror.Size = new global::System.Drawing.Size(16, 13);
			this.lblerror.TabIndex = 34;
			this.lblerror.Text = "...";
			this.txtProductCode.Location = new global::System.Drawing.Point(322, 229);
			this.txtProductCode.Name = "txtProductCode";
			this.txtProductCode.Size = new global::System.Drawing.Size(100, 20);
			this.txtProductCode.TabIndex = 33;
			this.txtProductCode.Visible = false;
			this.Panel2.BackColor = global::System.Drawing.Color.FromArgb(192, 255, 255);
			this.Panel2.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.Panel2.Controls.Add(this.DGVSearch);
			this.Panel2.Controls.Add(this.GroupBox4);
			this.Panel2.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.Panel2.Location = new global::System.Drawing.Point(3, 16);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new global::System.Drawing.Size(316, 265);
			this.Panel2.TabIndex = 32;
			this.DGVSearch.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DGVSearch.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.DGVSearch.Location = new global::System.Drawing.Point(0, 69);
			this.DGVSearch.Name = "DGVSearch";
			this.DGVSearch.ReadOnly = true;
			this.DGVSearch.Size = new global::System.Drawing.Size(312, 192);
			this.DGVSearch.StandardTab = true;
			this.DGVSearch.TabIndex = 1;
			this.GroupBox4.Controls.Add(this.Button3);
			this.GroupBox4.Controls.Add(this.Label19);
			this.GroupBox4.Controls.Add(this.txtsearch);
			this.GroupBox4.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox4.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox4.Name = "GroupBox4";
			this.GroupBox4.Size = new global::System.Drawing.Size(312, 69);
			this.GroupBox4.TabIndex = 0;
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
			this.Label19.TabIndex = 9;
			this.Label19.Text = "Type in the space to search by product description:";
			this.txtsearch.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtsearch.Location = new global::System.Drawing.Point(8, 34);
			this.txtsearch.Name = "txtsearch";
			this.txtsearch.Size = new global::System.Drawing.Size(219, 29);
			this.txtsearch.TabIndex = 0;
			this.dgvWarehouse.AllowUserToAddRows = false;
			this.dgvWarehouse.AllowUserToDeleteRows = false;
			this.dgvWarehouse.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvWarehouse.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dgvWarehouse.Location = new global::System.Drawing.Point(0, 284);
			this.dgvWarehouse.Name = "dgvWarehouse";
			this.dgvWarehouse.ReadOnly = true;
			this.dgvWarehouse.Size = new global::System.Drawing.Size(1021, 328);
			this.dgvWarehouse.TabIndex = 1;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1021, 612);
			base.Controls.Add(this.dgvWarehouse);
			base.Controls.Add(this.GroupBox1);
			base.Name = "ChangeExpiryDate";
			this.Text = "Change Product Expiry Date";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.Panel2.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.DGVSearch).EndInit();
			this.GroupBox4.ResumeLayout(false);
			this.GroupBox4.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvWarehouse).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x0400026D RID: 621
		private global::System.ComponentModel.IContainer components;
	}
}
