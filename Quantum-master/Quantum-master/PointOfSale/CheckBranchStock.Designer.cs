namespace PointOfSale
{
	// Token: 0x02000022 RID: 34
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class CheckBranchStock : global::System.Windows.Forms.Form
	{
		// Token: 0x060006B0 RID: 1712 RVA: 0x00043FE4 File Offset: 0x000421E4
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

		// Token: 0x060006B1 RID: 1713 RVA: 0x00044034 File Offset: 0x00042234
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.dgvPrices = new global::System.Windows.Forms.DataGridView();
			this.lblProductDesc = new global::System.Windows.Forms.Label();
			this.lblProductCode = new global::System.Windows.Forms.Label();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.GroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvPrices).BeginInit();
			base.SuspendLayout();
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Controls.Add(this.lblProductCode);
			this.GroupBox1.Controls.Add(this.lblProductDesc);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new global::System.Drawing.Size(477, 81);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.dgvPrices.AllowUserToAddRows = false;
			this.dgvPrices.AllowUserToDeleteRows = false;
			this.dgvPrices.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvPrices.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dgvPrices.Location = new global::System.Drawing.Point(0, 81);
			this.dgvPrices.Name = "dgvPrices";
			this.dgvPrices.ReadOnly = true;
			this.dgvPrices.Size = new global::System.Drawing.Size(477, 180);
			this.dgvPrices.TabIndex = 1;
			this.lblProductDesc.AutoSize = true;
			this.lblProductDesc.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.lblProductDesc.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblProductDesc.Location = new global::System.Drawing.Point(3, 16);
			this.lblProductDesc.Name = "lblProductDesc";
			this.lblProductDesc.Size = new global::System.Drawing.Size(21, 20);
			this.lblProductDesc.TabIndex = 0;
			this.lblProductDesc.Text = "...";
			this.lblProductCode.AutoSize = true;
			this.lblProductCode.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblProductCode.Location = new global::System.Drawing.Point(84, 33);
			this.lblProductCode.Name = "lblProductCode";
			this.lblProductCode.Size = new global::System.Drawing.Size(21, 20);
			this.lblProductCode.TabIndex = 1;
			this.lblProductCode.Text = "...";
			this.Label1.AutoSize = true;
			this.Label1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.Label1.Location = new global::System.Drawing.Point(3, 36);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(75, 13);
			this.Label1.TabIndex = 2;
			this.Label1.Text = "Product Code:";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(477, 261);
			base.Controls.Add(this.dgvPrices);
			base.Controls.Add(this.GroupBox1);
			base.Name = "CheckBranchStock";
			this.Text = "Check Branch Stock Balances";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvPrices).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000319 RID: 793
		private global::System.ComponentModel.IContainer components;
	}
}
