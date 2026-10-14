namespace PointOfSale
{
	// Token: 0x0200002A RID: 42
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class CollectionsProductBals : global::System.Windows.Forms.UserControl
	{
		// Token: 0x060007CC RID: 1996 RVA: 0x0004DFD0 File Offset: 0x0004C1D0
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

		// Token: 0x060007CD RID: 1997 RVA: 0x0004E020 File Offset: 0x0004C220
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.dgvProducts = new global::System.Windows.Forms.DataGridView();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.GroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvProducts).BeginInit();
			base.SuspendLayout();
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new global::System.Drawing.Size(899, 100);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.dgvProducts.AllowUserToAddRows = false;
			this.dgvProducts.AllowUserToDeleteRows = false;
			this.dgvProducts.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvProducts.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dgvProducts.Location = new global::System.Drawing.Point(0, 100);
			this.dgvProducts.Name = "dgvProducts";
			this.dgvProducts.ReadOnly = true;
			this.dgvProducts.Size = new global::System.Drawing.Size(899, 291);
			this.dgvProducts.TabIndex = 1;
			this.Button1.BackColor = global::System.Drawing.Color.Lime;
			this.Button1.Location = new global::System.Drawing.Point(290, 43);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(319, 23);
			this.Button1.TabIndex = 0;
			this.Button1.Text = "View Product Balances for Collection/Delivery";
			this.Button1.UseVisualStyleBackColor = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.Controls.Add(this.dgvProducts);
			base.Controls.Add(this.GroupBox1);
			base.Name = "CollectionsProductBals";
			base.Size = new global::System.Drawing.Size(899, 391);
			this.GroupBox1.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.dgvProducts).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x040003AA RID: 938
		private global::System.ComponentModel.IContainer components;
	}
}
