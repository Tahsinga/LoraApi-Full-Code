namespace PointOfSale
{
	// Token: 0x0200003B RID: 59
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class DeletedProducts : global::System.Windows.Forms.UserControl
	{
		// Token: 0x06000D19 RID: 3353 RVA: 0x0008041C File Offset: 0x0007E61C
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

		// Token: 0x06000D1A RID: 3354 RVA: 0x0008046C File Offset: 0x0007E66C
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.dgvDeletedProducts = new global::System.Windows.Forms.DataGridView();
			this.GroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvDeletedProducts).BeginInit();
			base.SuspendLayout();
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new global::System.Drawing.Size(1333, 139);
			this.GroupBox1.TabIndex = 1;
			this.GroupBox1.TabStop = false;
			this.Label2.AutoSize = true;
			this.Label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 16f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label2.Location = new global::System.Drawing.Point(6, 22);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(534, 37);
			this.Label2.TabIndex = 2;
			this.Label2.Text = "VIEW ALL DELETED PRODUCTS";
			this.Label1.AutoSize = true;
			this.Label1.BackColor = global::System.Drawing.Color.Red;
			this.Label1.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.Label1.Location = new global::System.Drawing.Point(1281, 22);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(49, 20);
			this.Label1.TabIndex = 1;
			this.Label1.Text = "Close";
			this.dgvDeletedProducts.AllowUserToAddRows = false;
			this.dgvDeletedProducts.AllowUserToDeleteRows = false;
			this.dgvDeletedProducts.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDeletedProducts.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dgvDeletedProducts.Location = new global::System.Drawing.Point(0, 139);
			this.dgvDeletedProducts.Name = "dgvDeletedProducts";
			this.dgvDeletedProducts.ReadOnly = true;
			this.dgvDeletedProducts.RowTemplate.Height = 28;
			this.dgvDeletedProducts.Size = new global::System.Drawing.Size(1333, 516);
			this.dgvDeletedProducts.TabIndex = 2;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.Controls.Add(this.dgvDeletedProducts);
			base.Controls.Add(this.GroupBox1);
			base.Name = "DeletedProducts";
			base.Size = new global::System.Drawing.Size(1333, 655);
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvDeletedProducts).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000622 RID: 1570
		private global::System.ComponentModel.IContainer components;
	}
}
