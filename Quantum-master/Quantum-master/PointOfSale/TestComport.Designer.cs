namespace PointOfSale
{
	// Token: 0x02000201 RID: 513
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class TestComport : global::System.Windows.Forms.Form
	{
		// Token: 0x06005C2D RID: 23597 RVA: 0x0034F914 File Offset: 0x0034DB14
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

		// Token: 0x06005C2E RID: 23598 RVA: 0x0034F964 File Offset: 0x0034DB64
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.TextBox1 = new global::System.Windows.Forms.TextBox();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.TextBox2 = new global::System.Windows.Forms.TextBox();
			base.SuspendLayout();
			this.TextBox1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.TextBox1.Location = new global::System.Drawing.Point(29, 32);
			this.TextBox1.Multiline = true;
			this.TextBox1.Name = "TextBox1";
			this.TextBox1.Size = new global::System.Drawing.Size(899, 217);
			this.TextBox1.TabIndex = 0;
			this.Button1.Location = new global::System.Drawing.Point(29, 297);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(135, 42);
			this.Button1.TabIndex = 1;
			this.Button1.Text = "Button1";
			this.Button1.UseVisualStyleBackColor = true;
			this.TextBox2.Location = new global::System.Drawing.Point(29, 265);
			this.TextBox2.Name = "TextBox2";
			this.TextBox2.Size = new global::System.Drawing.Size(100, 26);
			this.TextBox2.TabIndex = 2;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(955, 425);
			base.Controls.Add(this.TextBox2);
			base.Controls.Add(this.Button1);
			base.Controls.Add(this.TextBox1);
			base.Name = "TestComport";
			this.Text = "TestComport";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04002854 RID: 10324
		private global::System.ComponentModel.IContainer components;
	}
}
