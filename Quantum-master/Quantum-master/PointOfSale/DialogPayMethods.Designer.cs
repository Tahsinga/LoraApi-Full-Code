namespace PointOfSale
{
	// Token: 0x02000044 RID: 68
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class DialogPayMethods : global::System.Windows.Forms.Form
	{
		// Token: 0x06000EF0 RID: 3824 RVA: 0x0008E89C File Offset: 0x0008CA9C
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

		// Token: 0x06000EF1 RID: 3825 RVA: 0x0008E8EC File Offset: 0x0008CAEC
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.ListBox1 = new global::System.Windows.Forms.ListBox();
			this.txtpaymethid = new global::System.Windows.Forms.TextBox();
			this.txtpaymethdesc = new global::System.Windows.Forms.TextBox();
			base.SuspendLayout();
			this.ListBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.ListBox1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 20f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.ListBox1.FormattingEnabled = true;
			this.ListBox1.ItemHeight = 31;
			this.ListBox1.Location = new global::System.Drawing.Point(0, 0);
			this.ListBox1.Name = "ListBox1";
			this.ListBox1.Size = new global::System.Drawing.Size(284, 261);
			this.ListBox1.TabIndex = 0;
			this.txtpaymethid.Location = new global::System.Drawing.Point(113, 156);
			this.txtpaymethid.Name = "txtpaymethid";
			this.txtpaymethid.Size = new global::System.Drawing.Size(100, 20);
			this.txtpaymethid.TabIndex = 1;
			this.txtpaymethid.Visible = false;
			this.txtpaymethdesc.Location = new global::System.Drawing.Point(92, 120);
			this.txtpaymethdesc.Name = "txtpaymethdesc";
			this.txtpaymethdesc.Size = new global::System.Drawing.Size(100, 20);
			this.txtpaymethdesc.TabIndex = 2;
			this.txtpaymethdesc.Visible = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(284, 261);
			base.Controls.Add(this.txtpaymethdesc);
			base.Controls.Add(this.txtpaymethid);
			base.Controls.Add(this.ListBox1);
			base.Name = "DialogPayMethods";
			this.Text = "Select Payment Method";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000724 RID: 1828
		private global::System.ComponentModel.IContainer components;
	}
}
