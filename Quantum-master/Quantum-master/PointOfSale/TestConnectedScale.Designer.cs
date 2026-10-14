namespace PointOfSale
{
	// Token: 0x02000202 RID: 514
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class TestConnectedScale : global::System.Windows.Forms.Form
	{
		// Token: 0x06005C3A RID: 23610 RVA: 0x0034FE64 File Offset: 0x0034E064
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

		// Token: 0x06005C3B RID: 23611 RVA: 0x0034FEB4 File Offset: 0x0034E0B4
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.TextBox1 = new global::System.Windows.Forms.TextBox();
			this.Timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.TextBox2 = new global::System.Windows.Forms.TextBox();
			this.Timer2 = new global::System.Windows.Forms.Timer(this.components);
			base.SuspendLayout();
			this.TextBox1.Location = new global::System.Drawing.Point(159, 18);
			this.TextBox1.Name = "TextBox1";
			this.TextBox1.Size = new global::System.Drawing.Size(555, 26);
			this.TextBox1.TabIndex = 0;
			this.Timer1.Interval = 300;
			this.TextBox2.Location = new global::System.Drawing.Point(234, 85);
			this.TextBox2.Name = "TextBox2";
			this.TextBox2.Size = new global::System.Drawing.Size(292, 26);
			this.TextBox2.TabIndex = 1;
			this.TextBox2.Text = "0.38";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1009, 361);
			base.Controls.Add(this.TextBox2);
			base.Controls.Add(this.TextBox1);
			base.Name = "TestConnectedScale";
			this.Text = "TestConnectedScale";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400285A RID: 10330
		private global::System.ComponentModel.IContainer components;
	}
}
