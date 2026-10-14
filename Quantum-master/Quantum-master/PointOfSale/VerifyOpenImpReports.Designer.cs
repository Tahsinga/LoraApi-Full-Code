namespace PointOfSale
{
	// Token: 0x02000209 RID: 521
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class VerifyOpenImpReports : global::System.Windows.Forms.Form
	{
		// Token: 0x06005DEB RID: 24043 RVA: 0x0035CFBC File Offset: 0x0035B1BC
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

		// Token: 0x06005DEC RID: 24044 RVA: 0x0035D00C File Offset: 0x0035B20C
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.TextBox1 = new global::System.Windows.Forms.TextBox();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.Label1 = new global::System.Windows.Forms.Label();
			base.SuspendLayout();
			this.TextBox1.Location = new global::System.Drawing.Point(162, 44);
			this.TextBox1.Name = "TextBox1";
			this.TextBox1.Size = new global::System.Drawing.Size(100, 20);
			this.TextBox1.TabIndex = 0;
			this.TextBox1.UseSystemPasswordChar = true;
			this.Button1.BackColor = global::System.Drawing.Color.Lime;
			this.Button1.Location = new global::System.Drawing.Point(162, 70);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(100, 23);
			this.Button1.TabIndex = 1;
			this.Button1.Text = "Verify";
			this.Button1.UseVisualStyleBackColor = false;
			this.Label1.AutoSize = true;
			this.Label1.Location = new global::System.Drawing.Point(12, 47);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(144, 13);
			this.Label1.TabIndex = 2;
			this.Label1.Text = "Enter Your Special Password";
			base.AcceptButton = this.Button1;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(284, 129);
			base.Controls.Add(this.Label1);
			base.Controls.Add(this.Button1);
			base.Controls.Add(this.TextBox1);
			base.Name = "VerifyOpenImpReports";
			this.Text = "User Authentication";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04002914 RID: 10516
		private global::System.ComponentModel.IContainer components;
	}
}
