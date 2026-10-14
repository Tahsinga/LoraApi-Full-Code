namespace PointOfSale
{
	// Token: 0x02000070 RID: 112
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class MenuProducts : global::System.Windows.Forms.Form
	{
		// Token: 0x060019AF RID: 6575 RVA: 0x000ECD10 File Offset: 0x000EAF10
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

		// Token: 0x060019B0 RID: 6576 RVA: 0x000ECD60 File Offset: 0x000EAF60
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.PanelProducts = new global::System.Windows.Forms.Panel();
			base.SuspendLayout();
			this.PanelProducts.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.PanelProducts.Location = new global::System.Drawing.Point(0, 0);
			this.PanelProducts.Name = "PanelProducts";
			this.PanelProducts.Size = new global::System.Drawing.Size(1004, 711);
			this.PanelProducts.TabIndex = 0;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1004, 711);
			base.Controls.Add(this.PanelProducts);
			base.Name = "MenuProducts";
			this.Text = "MenuProducts";
			base.ResumeLayout(false);
		}

		// Token: 0x04000C6A RID: 3178
		private global::System.ComponentModel.IContainer components;
	}
}
