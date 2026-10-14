namespace PointOfSale
{
	// Token: 0x02000049 RID: 73
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class eltratefiscaldevice : global::System.Windows.Forms.Form
	{
		// Token: 0x06000F9D RID: 3997 RVA: 0x00093160 File Offset: 0x00091360
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

		// Token: 0x06000F9E RID: 3998 RVA: 0x000931B0 File Offset: 0x000913B0
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.chkSelectAll = new global::System.Windows.Forms.CheckBox();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.lblError = new global::System.Windows.Forms.Label();
			this.Button3 = new global::System.Windows.Forms.Button();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.txtSearchProducts = new global::System.Windows.Forms.TextBox();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.dgvProducts = new global::System.Windows.Forms.DataGridView();
			this.ProgressBar1 = new global::System.Windows.Forms.ProgressBar();
			this.GroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvProducts).BeginInit();
			base.SuspendLayout();
			this.GroupBox1.Controls.Add(this.chkSelectAll);
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Controls.Add(this.lblError);
			this.GroupBox1.Controls.Add(this.Button3);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.txtSearchProducts);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Padding = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GroupBox1.Size = new global::System.Drawing.Size(1198, 288);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.chkSelectAll.AutoSize = true;
			this.chkSelectAll.Location = new global::System.Drawing.Point(764, 207);
			this.chkSelectAll.Name = "chkSelectAll";
			this.chkSelectAll.Size = new global::System.Drawing.Size(177, 24);
			this.chkSelectAll.TabIndex = 8;
			this.chkSelectAll.Text = "Select All Products?";
			this.chkSelectAll.UseVisualStyleBackColor = true;
			this.chkSelectAll.Visible = false;
			this.Button1.BackColor = global::System.Drawing.Color.Aqua;
			this.Button1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Button1.Location = new global::System.Drawing.Point(319, 181);
			this.Button1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(438, 70);
			this.Button1.TabIndex = 7;
			this.Button1.Text = "GENERATE AND SAVE NEW BARCODES FOR SELECTED PRODUCTS";
			this.Button1.UseVisualStyleBackColor = false;
			this.Button1.Visible = false;
			this.lblError.AutoSize = true;
			this.lblError.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.lblError.ForeColor = global::System.Drawing.Color.Red;
			this.lblError.Location = new global::System.Drawing.Point(4, 263);
			this.lblError.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblError.Name = "lblError";
			this.lblError.Size = new global::System.Drawing.Size(21, 20);
			this.lblError.TabIndex = 6;
			this.lblError.Text = "...";
			this.Button3.BackColor = global::System.Drawing.Color.Lime;
			this.Button3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Button3.Location = new global::System.Drawing.Point(319, 101);
			this.Button3.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Button3.Name = "Button3";
			this.Button3.Size = new global::System.Drawing.Size(438, 70);
			this.Button3.TabIndex = 5;
			this.Button3.Text = "Save All Product Codes Manually Edited";
			this.Button3.UseVisualStyleBackColor = false;
			this.Label2.AutoSize = true;
			this.Label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label2.Location = new global::System.Drawing.Point(291, 25);
			this.Label2.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(360, 29);
			this.Label2.TabIndex = 4;
			this.Label2.Text = "EDIT PRODUCT BAR CODES";
			this.txtSearchProducts.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtSearchProducts.Location = new global::System.Drawing.Point(319, 61);
			this.txtSearchProducts.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtSearchProducts.Name = "txtSearchProducts";
			this.txtSearchProducts.Size = new global::System.Drawing.Size(438, 30);
			this.txtSearchProducts.TabIndex = 1;
			this.Label1.AutoSize = true;
			this.Label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label1.Location = new global::System.Drawing.Point(7, 66);
			this.Label1.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(279, 25);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Search by product Description:";
			this.dgvProducts.AllowUserToAddRows = false;
			this.dgvProducts.AllowUserToDeleteRows = false;
			this.dgvProducts.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvProducts.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dgvProducts.Location = new global::System.Drawing.Point(0, 288);
			this.dgvProducts.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dgvProducts.Name = "dgvProducts";
			this.dgvProducts.Size = new global::System.Drawing.Size(1198, 574);
			this.dgvProducts.TabIndex = 1;
			this.ProgressBar1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.ProgressBar1.Location = new global::System.Drawing.Point(0, 288);
			this.ProgressBar1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ProgressBar1.Name = "ProgressBar1";
			this.ProgressBar1.Size = new global::System.Drawing.Size(1198, 35);
			this.ProgressBar1.TabIndex = 2;
			this.ProgressBar1.Visible = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1198, 862);
			base.Controls.Add(this.ProgressBar1);
			base.Controls.Add(this.dgvProducts);
			base.Controls.Add(this.GroupBox1);
			base.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			base.Name = "eltratefiscaldevice";
			this.Text = "Bar Codes";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvProducts).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000779 RID: 1913
		private global::System.ComponentModel.IContainer components;
	}
}
