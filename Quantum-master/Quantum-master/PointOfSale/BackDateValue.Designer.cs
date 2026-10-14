namespace PointOfSale
{
	// Token: 0x02000010 RID: 16
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class BackDateValue : global::System.Windows.Forms.Form
	{
		// Token: 0x060002D2 RID: 722 RVA: 0x000199FC File Offset: 0x00017BFC
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

		// Token: 0x060002D3 RID: 723 RVA: 0x00019A4C File Offset: 0x00017C4C
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.DateTimePicker1 = new global::System.Windows.Forms.DateTimePicker();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.Button1 = new global::System.Windows.Forms.Button();
			base.SuspendLayout();
			this.DateTimePicker1.Location = new global::System.Drawing.Point(39, 69);
			this.DateTimePicker1.Name = "DateTimePicker1";
			this.DateTimePicker1.Size = new global::System.Drawing.Size(200, 20);
			this.DateTimePicker1.TabIndex = 0;
			this.Label1.AutoSize = true;
			this.Label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label1.Location = new global::System.Drawing.Point(36, 26);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(209, 20);
			this.Label1.TabIndex = 1;
			this.Label1.Text = "Select Date to Back-Date to";
			this.Button1.Location = new global::System.Drawing.Point(77, 123);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(119, 23);
			this.Button1.TabIndex = 2;
			this.Button1.Text = "Back Date Invoice";
			this.Button1.UseVisualStyleBackColor = true;
			base.AcceptButton = this.Button1;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(284, 262);
			base.Controls.Add(this.Button1);
			base.Controls.Add(this.Label1);
			base.Controls.Add(this.DateTimePicker1);
			base.Name = "BackDateValue";
			this.Text = "Back Date Value";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000138 RID: 312
		private global::System.ComponentModel.IContainer components;
	}
}
