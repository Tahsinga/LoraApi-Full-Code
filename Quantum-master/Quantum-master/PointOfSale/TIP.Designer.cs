namespace PointOfSale
{
	// Token: 0x02000203 RID: 515
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class TIP : global::System.Windows.Forms.Form
	{
		// Token: 0x06005C4C RID: 23628 RVA: 0x0035037C File Offset: 0x0034E57C
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

		// Token: 0x06005C4D RID: 23629 RVA: 0x003503CC File Offset: 0x0034E5CC
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.Label1 = new global::System.Windows.Forms.Label();
			this.lblInv = new global::System.Windows.Forms.Label();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.Label5 = new global::System.Windows.Forms.Label();
			this.txtTIP = new global::System.Windows.Forms.TextBox();
			this.txtTotPaid = new global::System.Windows.Forms.TextBox();
			this.Button7 = new global::System.Windows.Forms.Button();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.Button2 = new global::System.Windows.Forms.Button();
			this.Button3 = new global::System.Windows.Forms.Button();
			this.Label2 = new global::System.Windows.Forms.Label();
			base.SuspendLayout();
			this.Label1.AutoSize = true;
			this.Label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 16f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label1.Location = new global::System.Drawing.Point(215, 116);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(246, 37);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Invoice Amount:";
			this.lblInv.AutoSize = true;
			this.lblInv.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 16f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblInv.Location = new global::System.Drawing.Point(632, 116);
			this.lblInv.Name = "lblInv";
			this.lblInv.RightToLeft = global::System.Windows.Forms.RightToLeft.No;
			this.lblInv.Size = new global::System.Drawing.Size(35, 37);
			this.lblInv.TabIndex = 1;
			this.lblInv.Text = "0";
			this.lblInv.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.Label3.AutoSize = true;
			this.Label3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 16f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label3.Location = new global::System.Drawing.Point(265, 265);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(196, 37);
			this.Label3.TabIndex = 2;
			this.Label3.Text = "TIP Amount:";
			this.Label5.AutoSize = true;
			this.Label5.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 16f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label5.Location = new global::System.Drawing.Point(11, 192);
			this.Label5.Name = "Label5";
			this.Label5.Size = new global::System.Drawing.Size(450, 37);
			this.Label5.TabIndex = 4;
			this.Label5.Text = "Enter Total Paid including TIP:";
			this.Label5.TextAlign = global::System.Drawing.ContentAlignment.TopRight;
			this.txtTIP.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 16f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtTIP.Location = new global::System.Drawing.Point(483, 262);
			this.txtTIP.Name = "txtTIP";
			this.txtTIP.Size = new global::System.Drawing.Size(184, 44);
			this.txtTIP.TabIndex = 6;
			this.txtTotPaid.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 16f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtTotPaid.Location = new global::System.Drawing.Point(483, 185);
			this.txtTotPaid.Name = "txtTotPaid";
			this.txtTotPaid.Size = new global::System.Drawing.Size(184, 44);
			this.txtTotPaid.TabIndex = 7;
			this.Button7.Image = global::PointOfSale.My.Resources.Resources.numeric_keypad3;
			this.Button7.Location = new global::System.Drawing.Point(683, 262);
			this.Button7.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Button7.Name = "Button7";
			this.Button7.Size = new global::System.Drawing.Size(64, 49);
			this.Button7.TabIndex = 56;
			this.Button7.UseVisualStyleBackColor = true;
			this.Button1.Image = global::PointOfSale.My.Resources.Resources.numeric_keypad3;
			this.Button1.Location = new global::System.Drawing.Point(683, 185);
			this.Button1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(64, 49);
			this.Button1.TabIndex = 57;
			this.Button1.UseVisualStyleBackColor = true;
			this.Button2.BackColor = global::System.Drawing.Color.Yellow;
			this.Button2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Button2.Location = new global::System.Drawing.Point(776, 188);
			this.Button2.Name = "Button2";
			this.Button2.Size = new global::System.Drawing.Size(171, 46);
			this.Button2.TabIndex = 58;
			this.Button2.Text = "Calc TIP";
			this.Button2.UseVisualStyleBackColor = false;
			this.Button3.BackColor = global::System.Drawing.Color.Lime;
			this.Button3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Button3.Location = new global::System.Drawing.Point(483, 324);
			this.Button3.Name = "Button3";
			this.Button3.Size = new global::System.Drawing.Size(184, 46);
			this.Button3.TabIndex = 59;
			this.Button3.Text = "Save TIP";
			this.Button3.UseVisualStyleBackColor = false;
			this.Label2.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.Label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 16f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label2.Location = new global::System.Drawing.Point(0, 0);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(1122, 85);
			this.Label2.TabIndex = 60;
			this.Label2.Text = "ENTER TOTAL PAID FOR INVOICE INCLUDING TIP TO CALCULATE TIP AMOUNT OR SIMPLY ENTER THE TIP AMOUNT";
			this.Label2.TextAlign = global::System.Drawing.ContentAlignment.TopCenter;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1122, 384);
			base.Controls.Add(this.Label2);
			base.Controls.Add(this.Button3);
			base.Controls.Add(this.Button2);
			base.Controls.Add(this.Button1);
			base.Controls.Add(this.Button7);
			base.Controls.Add(this.txtTotPaid);
			base.Controls.Add(this.txtTIP);
			base.Controls.Add(this.Label5);
			base.Controls.Add(this.Label3);
			base.Controls.Add(this.lblInv);
			base.Controls.Add(this.Label1);
			base.Name = "TIP";
			this.Text = "TIP";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04002860 RID: 10336
		private global::System.ComponentModel.IContainer components;
	}
}
