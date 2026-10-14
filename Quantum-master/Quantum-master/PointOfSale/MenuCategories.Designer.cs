namespace PointOfSale
{
	// Token: 0x0200006F RID: 111
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class MenuCategories : global::System.Windows.Forms.Form
	{
		// Token: 0x060019A7 RID: 6567 RVA: 0x000EC744 File Offset: 0x000EA944
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

		// Token: 0x060019A8 RID: 6568 RVA: 0x000EC794 File Offset: 0x000EA994
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.Panel1 = new global::System.Windows.Forms.Panel();
			base.SuspendLayout();
			this.Panel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.Panel1.Location = new global::System.Drawing.Point(0, 0);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new global::System.Drawing.Size(1004, 711);
			this.Panel1.TabIndex = 0;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1004, 711);
			base.Controls.Add(this.Panel1);
			base.Name = "MenuCategories";
			this.Text = "Categories Menu";
			base.ResumeLayout(false);
		}

		// Token: 0x04000C65 RID: 3173
		private global::System.ComponentModel.IContainer components;
	}
}
