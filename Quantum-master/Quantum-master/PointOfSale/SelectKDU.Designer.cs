namespace PointOfSale
{
	// Token: 0x020001B9 RID: 441
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class SelectKDU : global::System.Windows.Forms.Form
	{
		// Token: 0x06004FDF RID: 20447 RVA: 0x002FB65C File Offset: 0x002F985C
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

		// Token: 0x06004FE0 RID: 20448 RVA: 0x002FB6AC File Offset: 0x002F98AC
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.Label1 = new global::System.Windows.Forms.Label();
			this.cboKDUs = new global::System.Windows.Forms.ComboBox();
			this.Button1 = new global::System.Windows.Forms.Button();
			base.SuspendLayout();
			this.Label1.AutoSize = true;
			this.Label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label1.Location = new global::System.Drawing.Point(45, 9);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(398, 29);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "SELECT Kitchen Display Unit (KDU)";
			this.cboKDUs.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 20f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.cboKDUs.FormattingEnabled = true;
			this.cboKDUs.Location = new global::System.Drawing.Point(50, 66);
			this.cboKDUs.Name = "cboKDUs";
			this.cboKDUs.Size = new global::System.Drawing.Size(380, 54);
			this.cboKDUs.TabIndex = 1;
			this.Button1.BackColor = global::System.Drawing.Color.Lime;
			this.Button1.Location = new global::System.Drawing.Point(157, 159);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(138, 63);
			this.Button1.TabIndex = 2;
			this.Button1.Text = "SELECT";
			this.Button1.UseVisualStyleBackColor = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(484, 259);
			base.Controls.Add(this.Button1);
			base.Controls.Add(this.cboKDUs);
			base.Controls.Add(this.Label1);
			base.Name = "SelectKDU";
			this.Text = "Select KDU";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040023A0 RID: 9120
		private global::System.ComponentModel.IContainer components;
	}
}
