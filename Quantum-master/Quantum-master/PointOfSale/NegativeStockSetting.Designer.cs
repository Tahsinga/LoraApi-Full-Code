namespace PointOfSale
{
	// Token: 0x02000078 RID: 120
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class NegativeStockSetting : global::System.Windows.Forms.Form
	{
		// Token: 0x060019F9 RID: 6649 RVA: 0x000EEEEC File Offset: 0x000ED0EC
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

		// Token: 0x060019FA RID: 6650 RVA: 0x000EEF3C File Offset: 0x000ED13C
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.CheckBox1 = new global::System.Windows.Forms.CheckBox();
			this.Button1 = new global::System.Windows.Forms.Button();
			base.SuspendLayout();
			this.CheckBox1.AutoSize = true;
			this.CheckBox1.Location = new global::System.Drawing.Point(65, 83);
			this.CheckBox1.Name = "CheckBox1";
			this.CheckBox1.Size = new global::System.Drawing.Size(163, 17);
			this.CheckBox1.TabIndex = 2;
			this.CheckBox1.Text = "Allow Negative Stock Values";
			this.CheckBox1.UseVisualStyleBackColor = true;
			this.Button1.Location = new global::System.Drawing.Point(65, 152);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(149, 23);
			this.Button1.TabIndex = 3;
			this.Button1.Text = "SAVE SETTINGS";
			this.Button1.UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(284, 262);
			base.Controls.Add(this.Button1);
			base.Controls.Add(this.CheckBox1);
			base.Name = "NegativeStockSetting";
			this.Text = "Negative Stock Setting";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000C89 RID: 3209
		private global::System.ComponentModel.IContainer components;
	}
}
