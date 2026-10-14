namespace PointOfSale
{
	// Token: 0x0200016E RID: 366
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class PrintReceipts : global::System.Windows.Forms.Form
	{
		// Token: 0x06003354 RID: 13140 RVA: 0x001BC680 File Offset: 0x001BA880
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

		// Token: 0x06003355 RID: 13141 RVA: 0x001BC6D0 File Offset: 0x001BA8D0
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.Label1 = new global::System.Windows.Forms.Label();
			this.TextBox1 = new global::System.Windows.Forms.TextBox();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.Button2 = new global::System.Windows.Forms.Button();
			this.Button3 = new global::System.Windows.Forms.Button();
			base.SuspendLayout();
			this.Label1.AutoSize = true;
			this.Label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label1.Location = new global::System.Drawing.Point(12, 29);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(354, 24);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Do you want to print receipts for this sale?";
			this.TextBox1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.TextBox1.Location = new global::System.Drawing.Point(372, 29);
			this.TextBox1.Name = "TextBox1";
			this.TextBox1.Size = new global::System.Drawing.Size(75, 29);
			this.TextBox1.TabIndex = 1;
			this.TextBox1.Text = "1";
			this.Button1.BackColor = global::System.Drawing.Color.Lime;
			this.Button1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Button1.Location = new global::System.Drawing.Point(245, 64);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(75, 32);
			this.Button1.TabIndex = 2;
			this.Button1.Text = "YES";
			this.Button1.UseVisualStyleBackColor = false;
			this.Button2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Button2.Location = new global::System.Drawing.Point(372, 64);
			this.Button2.Name = "Button2";
			this.Button2.Size = new global::System.Drawing.Size(75, 32);
			this.Button2.TabIndex = 3;
			this.Button2.Text = "NO";
			this.Button2.UseVisualStyleBackColor = true;
			this.Button3.Image = global::PointOfSale.My.Resources.Resources.numeric_keypad3;
			this.Button3.Location = new global::System.Drawing.Point(456, 29);
			this.Button3.Name = "Button3";
			this.Button3.Size = new global::System.Drawing.Size(43, 32);
			this.Button3.TabIndex = 5;
			this.Button3.UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(511, 123);
			base.Controls.Add(this.Button3);
			base.Controls.Add(this.Button2);
			base.Controls.Add(this.Button1);
			base.Controls.Add(this.TextBox1);
			base.Controls.Add(this.Label1);
			base.Name = "PrintReceipts";
			this.Text = "Print Receipts";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040015F4 RID: 5620
		private global::System.ComponentModel.IContainer components;
	}
}
