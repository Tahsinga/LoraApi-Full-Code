namespace PointOfSale
{
	// Token: 0x0200008A RID: 138
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class PayMethRef : global::System.Windows.Forms.Form
	{
		// Token: 0x06001F85 RID: 8069 RVA: 0x001195A0 File Offset: 0x001177A0
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

		// Token: 0x06001F86 RID: 8070 RVA: 0x001195F0 File Offset: 0x001177F0
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.txtRef = new global::System.Windows.Forms.TextBox();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.GroupBox1.SuspendLayout();
			base.SuspendLayout();
			this.GroupBox1.Controls.Add(this.txtRef);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Padding = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GroupBox1.Size = new global::System.Drawing.Size(429, 88);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Ref";
			this.txtRef.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.txtRef.Location = new global::System.Drawing.Point(4, 57);
			this.txtRef.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtRef.Name = "txtRef";
			this.txtRef.Size = new global::System.Drawing.Size(421, 26);
			this.txtRef.TabIndex = 0;
			this.Button1.BackColor = global::System.Drawing.Color.Lime;
			this.Button1.Location = new global::System.Drawing.Point(136, 89);
			this.Button1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(138, 55);
			this.Button1.TabIndex = 1;
			this.Button1.Text = "Save Reference";
			this.Button1.UseVisualStyleBackColor = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(429, 146);
			base.Controls.Add(this.Button1);
			base.Controls.Add(this.GroupBox1);
			base.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			base.Name = "PayMethRef";
			this.Text = "Record Reference";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04000EF9 RID: 3833
		private global::System.ComponentModel.IContainer components;
	}
}
