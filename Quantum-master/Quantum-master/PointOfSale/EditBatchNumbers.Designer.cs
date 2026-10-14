namespace PointOfSale
{
	// Token: 0x0200004B RID: 75
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class EditBatchNumbers : global::System.Windows.Forms.Form
	{
		// Token: 0x06000FD9 RID: 4057 RVA: 0x00095CB4 File Offset: 0x00093EB4
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

		// Token: 0x06000FDA RID: 4058 RVA: 0x00095D04 File Offset: 0x00093F04
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.lblproductcount = new global::System.Windows.Forms.Label();
			this.Panel2 = new global::System.Windows.Forms.Panel();
			this.DGVSearch = new global::System.Windows.Forms.DataGridView();
			this.GroupBox4 = new global::System.Windows.Forms.GroupBox();
			this.Button3 = new global::System.Windows.Forms.Button();
			this.Label19 = new global::System.Windows.Forms.Label();
			this.txtsearch = new global::System.Windows.Forms.TextBox();
			this.txtProductCode = new global::System.Windows.Forms.TextBox();
			this.lblerror = new global::System.Windows.Forms.Label();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.DTdate = new global::System.Windows.Forms.DateTimePicker();
			this.dgvProducts = new global::System.Windows.Forms.DataGridView();
			this.ProgressBar1 = new global::System.Windows.Forms.ProgressBar();
			this.txtsearchproductcode = new global::System.Windows.Forms.TextBox();
			this.GroupBox1.SuspendLayout();
			this.Panel2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.DGVSearch).BeginInit();
			this.GroupBox4.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvProducts).BeginInit();
			base.SuspendLayout();
			this.GroupBox1.Controls.Add(this.txtsearchproductcode);
			this.GroupBox1.Controls.Add(this.lblproductcount);
			this.GroupBox1.Controls.Add(this.Panel2);
			this.GroupBox1.Controls.Add(this.txtProductCode);
			this.GroupBox1.Controls.Add(this.lblerror);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Controls.Add(this.DTdate);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new global::System.Drawing.Size(976, 234);
			this.GroupBox1.TabIndex = 2;
			this.GroupBox1.TabStop = false;
			this.lblproductcount.AutoSize = true;
			this.lblproductcount.Location = new global::System.Drawing.Point(329, 218);
			this.lblproductcount.Name = "lblproductcount";
			this.lblproductcount.Size = new global::System.Drawing.Size(16, 13);
			this.lblproductcount.TabIndex = 36;
			this.lblproductcount.Text = "...";
			this.Panel2.BackColor = global::System.Drawing.Color.FromArgb(192, 255, 255);
			this.Panel2.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.Panel2.Controls.Add(this.DGVSearch);
			this.Panel2.Controls.Add(this.GroupBox4);
			this.Panel2.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.Panel2.Location = new global::System.Drawing.Point(3, 16);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new global::System.Drawing.Size(316, 202);
			this.Panel2.TabIndex = 30;
			this.DGVSearch.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DGVSearch.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.DGVSearch.Location = new global::System.Drawing.Point(0, 69);
			this.DGVSearch.Name = "DGVSearch";
			this.DGVSearch.ReadOnly = true;
			this.DGVSearch.Size = new global::System.Drawing.Size(312, 129);
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
			this.txtProductCode.Location = new global::System.Drawing.Point(328, 189);
			this.txtProductCode.Name = "txtProductCode";
			this.txtProductCode.Size = new global::System.Drawing.Size(100, 20);
			this.txtProductCode.TabIndex = 35;
			this.txtProductCode.Visible = false;
			this.lblerror.AutoSize = true;
			this.lblerror.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.lblerror.Location = new global::System.Drawing.Point(3, 218);
			this.lblerror.Name = "lblerror";
			this.lblerror.Size = new global::System.Drawing.Size(16, 13);
			this.lblerror.TabIndex = 34;
			this.lblerror.Text = "...";
			this.Label1.AutoSize = true;
			this.Label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label1.Location = new global::System.Drawing.Point(328, 41);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(310, 20);
			this.Label1.TabIndex = 2;
			this.Label1.Text = "Edit Batch Numbers and Expiry Dates";
			this.Button1.BackColor = global::System.Drawing.Color.Lime;
			this.Button1.Location = new global::System.Drawing.Point(325, 160);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(158, 23);
			this.Button1.TabIndex = 1;
			this.Button1.Text = "Save Changes";
			this.Button1.UseVisualStyleBackColor = false;
			this.DTdate.Location = new global::System.Drawing.Point(689, 12);
			this.DTdate.Name = "DTdate";
			this.DTdate.Size = new global::System.Drawing.Size(200, 20);
			this.DTdate.TabIndex = 0;
			this.dgvProducts.AllowUserToAddRows = false;
			this.dgvProducts.AllowUserToDeleteRows = false;
			this.dgvProducts.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvProducts.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dgvProducts.Location = new global::System.Drawing.Point(0, 234);
			this.dgvProducts.Name = "dgvProducts";
			this.dgvProducts.Size = new global::System.Drawing.Size(976, 208);
			this.dgvProducts.TabIndex = 3;
			this.ProgressBar1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.ProgressBar1.Location = new global::System.Drawing.Point(0, 234);
			this.ProgressBar1.Name = "ProgressBar1";
			this.ProgressBar1.Size = new global::System.Drawing.Size(976, 23);
			this.ProgressBar1.TabIndex = 4;
			this.ProgressBar1.Visible = false;
			this.txtsearchproductcode.Location = new global::System.Drawing.Point(434, 189);
			this.txtsearchproductcode.Name = "txtsearchproductcode";
			this.txtsearchproductcode.Size = new global::System.Drawing.Size(100, 20);
			this.txtsearchproductcode.TabIndex = 37;
			this.txtsearchproductcode.Visible = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(976, 442);
			base.Controls.Add(this.ProgressBar1);
			base.Controls.Add(this.dgvProducts);
			base.Controls.Add(this.GroupBox1);
			base.Name = "EditBatchNumbers";
			this.Text = "EditBatchNumbers";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.Panel2.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.DGVSearch).EndInit();
			this.GroupBox4.ResumeLayout(false);
			this.GroupBox4.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvProducts).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000797 RID: 1943
		private global::System.ComponentModel.IContainer components;
	}
}
