namespace PointOfSale
{
	// Token: 0x0200021C RID: 540
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class WeightVerificationScale : global::System.Windows.Forms.Form
	{
		// Token: 0x0600619F RID: 24991 RVA: 0x003798E8 File Offset: 0x00377AE8
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

		// Token: 0x060061A0 RID: 24992 RVA: 0x00379938 File Offset: 0x00377B38
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.txtQtyWeighed = new global::System.Windows.Forms.TextBox();
			this.lblexpectedWeight = new global::System.Windows.Forms.Label();
			this.Label2 = new global::System.Windows.Forms.TextBox();
			base.SuspendLayout();
			this.txtQtyWeighed.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.txtQtyWeighed.Enabled = false;
			this.txtQtyWeighed.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 32f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtQtyWeighed.Location = new global::System.Drawing.Point(0, 0);
			this.txtQtyWeighed.Name = "txtQtyWeighed";
			this.txtQtyWeighed.Size = new global::System.Drawing.Size(581, 80);
			this.txtQtyWeighed.TabIndex = 0;
			this.lblexpectedWeight.AutoSize = true;
			this.lblexpectedWeight.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.lblexpectedWeight.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblexpectedWeight.Location = new global::System.Drawing.Point(0, 80);
			this.lblexpectedWeight.Name = "lblexpectedWeight";
			this.lblexpectedWeight.Size = new global::System.Drawing.Size(102, 32);
			this.lblexpectedWeight.TabIndex = 1;
			this.lblexpectedWeight.Text = "Label1";
			this.Label2.Location = new global::System.Drawing.Point(16, 140);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(100, 26);
			this.Label2.TabIndex = 3;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(581, 244);
			base.Controls.Add(this.Label2);
			base.Controls.Add(this.lblexpectedWeight);
			base.Controls.Add(this.txtQtyWeighed);
			base.Name = "WeightVerificationScale";
			this.Text = "Weight Verification Scale";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04002AF1 RID: 10993
		private global::System.ComponentModel.IContainer components;
	}
}
