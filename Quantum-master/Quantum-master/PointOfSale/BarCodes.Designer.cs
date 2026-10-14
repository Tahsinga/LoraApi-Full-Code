namespace PointOfSale
{
	// Token: 0x02000012 RID: 18
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class BarCodes : global::System.Windows.Forms.Form
	{
		// Token: 0x060002F9 RID: 761 RVA: 0x0001A7DC File Offset: 0x000189DC
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

		// Token: 0x060002FA RID: 762 RVA: 0x0001A82C File Offset: 0x00018A2C
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.chkBarCodes = new global::System.Windows.Forms.CheckBox();
			this.Button1 = new global::System.Windows.Forms.Button();
			base.SuspendLayout();
			this.chkBarCodes.AutoSize = true;
			this.chkBarCodes.Location = new global::System.Drawing.Point(76, 51);
			this.chkBarCodes.Name = "chkBarCodes";
			this.chkBarCodes.Size = new global::System.Drawing.Size(111, 17);
			this.chkBarCodes.TabIndex = 7;
			this.chkBarCodes.Text = "Using Bar Codes?";
			this.chkBarCodes.UseVisualStyleBackColor = true;
			this.Button1.Location = new global::System.Drawing.Point(76, 84);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(75, 23);
			this.Button1.TabIndex = 8;
			this.Button1.Text = "Save";
			this.Button1.UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(284, 262);
			base.Controls.Add(this.Button1);
			base.Controls.Add(this.chkBarCodes);
			base.Name = "BarCodes";
			this.Text = "BarCodes";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000148 RID: 328
		private global::System.ComponentModel.IContainer components;
	}
}
