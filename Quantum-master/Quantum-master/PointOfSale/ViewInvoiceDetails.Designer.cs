namespace PointOfSale
{
	// Token: 0x0200020F RID: 527
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class ViewInvoiceDetails : global::System.Windows.Forms.Form
	{
		// Token: 0x06005EAC RID: 24236 RVA: 0x00364034 File Offset: 0x00362234
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

		// Token: 0x06005EAD RID: 24237 RVA: 0x00364084 File Offset: 0x00362284
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.DataGridView1 = new global::System.Windows.Forms.DataGridView();
			((global::System.ComponentModel.ISupportInitialize)this.DataGridView1).BeginInit();
			base.SuspendLayout();
			this.DataGridView1.AllowUserToAddRows = false;
			this.DataGridView1.AllowUserToDeleteRows = false;
			this.DataGridView1.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridView1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.DataGridView1.Location = new global::System.Drawing.Point(0, 0);
			this.DataGridView1.Name = "DataGridView1";
			this.DataGridView1.ReadOnly = true;
			this.DataGridView1.Size = new global::System.Drawing.Size(801, 323);
			this.DataGridView1.TabIndex = 0;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(801, 323);
			base.Controls.Add(this.DataGridView1);
			base.Name = "ViewInvoiceDetails";
			this.Text = "View Invoice Details";
			((global::System.ComponentModel.ISupportInitialize)this.DataGridView1).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x0400298D RID: 10637
		private global::System.ComponentModel.IContainer components;
	}
}
