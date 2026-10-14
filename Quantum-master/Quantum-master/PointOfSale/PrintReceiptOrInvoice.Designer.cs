namespace PointOfSale
{
	// Token: 0x0200016D RID: 365
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class PrintReceiptOrInvoice : global::System.Windows.Forms.Form
	{
		// Token: 0x06003345 RID: 13125 RVA: 0x001BC15C File Offset: 0x001BA35C
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

		// Token: 0x06003346 RID: 13126 RVA: 0x001BC1AC File Offset: 0x001BA3AC
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.Button1 = new global::System.Windows.Forms.Button();
			this.Button2 = new global::System.Windows.Forms.Button();
			this.Button3 = new global::System.Windows.Forms.Button();
			this.Label1 = new global::System.Windows.Forms.Label();
			base.SuspendLayout();
			this.Button1.BackColor = global::System.Drawing.Color.Lime;
			this.Button1.Location = new global::System.Drawing.Point(23, 54);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(197, 23);
			this.Button1.TabIndex = 1;
			this.Button1.Text = "Print small Receipt";
			this.Button1.UseVisualStyleBackColor = false;
			this.Button2.BackColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.Button2.Location = new global::System.Drawing.Point(290, 54);
			this.Button2.Name = "Button2";
			this.Button2.Size = new global::System.Drawing.Size(197, 23);
			this.Button2.TabIndex = 2;
			this.Button2.Text = "Print A4 Invoice";
			this.Button2.UseVisualStyleBackColor = false;
			this.Button3.BackColor = global::System.Drawing.SystemColors.Control;
			this.Button3.Location = new global::System.Drawing.Point(551, 54);
			this.Button3.Name = "Button3";
			this.Button3.Size = new global::System.Drawing.Size(197, 23);
			this.Button3.TabIndex = 3;
			this.Button3.Text = "Do not print anything.";
			this.Button3.UseVisualStyleBackColor = false;
			this.Label1.AutoSize = true;
			this.Label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label1.Location = new global::System.Drawing.Point(19, 9);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(298, 24);
			this.Label1.TabIndex = 4;
			this.Label1.Text = "Select printing options for this sale.";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(780, 98);
			base.Controls.Add(this.Label1);
			base.Controls.Add(this.Button3);
			base.Controls.Add(this.Button2);
			base.Controls.Add(this.Button1);
			base.Name = "PrintReceiptOrInvoice";
			this.Text = "Print Receipt Or Invoice";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040015EE RID: 5614
		private global::System.ComponentModel.IContainer components;
	}
}
