namespace PointOfSale
{
	// Token: 0x02000080 RID: 128
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class OtherProductDetail : global::System.Windows.Forms.Form
	{
		// Token: 0x06001DC4 RID: 7620 RVA: 0x0010ACE4 File Offset: 0x00108EE4
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

		// Token: 0x06001DC5 RID: 7621 RVA: 0x0010AD34 File Offset: 0x00108F34
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.txtdetail = new global::System.Windows.Forms.TextBox();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.GroupBox1.SuspendLayout();
			base.SuspendLayout();
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Controls.Add(this.txtdetail);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new global::System.Drawing.Size(508, 100);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.Label1.AutoSize = true;
			this.Label1.Location = new global::System.Drawing.Point(12, 16);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(155, 13);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Enter additional product details:";
			this.txtdetail.Location = new global::System.Drawing.Point(15, 32);
			this.txtdetail.MaxLength = 100;
			this.txtdetail.Name = "txtdetail";
			this.txtdetail.Size = new global::System.Drawing.Size(481, 20);
			this.txtdetail.TabIndex = 1;
			this.Button1.BackColor = global::System.Drawing.Color.Lime;
			this.Button1.Location = new global::System.Drawing.Point(15, 58);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(75, 23);
			this.Button1.TabIndex = 2;
			this.Button1.Text = "SAVE";
			this.Button1.UseVisualStyleBackColor = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(508, 100);
			base.Controls.Add(this.GroupBox1);
			base.Name = "OtherProductDetail";
			this.Text = "Additional Product Detail";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04000E2F RID: 3631
		private global::System.ComponentModel.IContainer components;
	}
}
