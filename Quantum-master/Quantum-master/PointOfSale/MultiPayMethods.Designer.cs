namespace PointOfSale
{
	// Token: 0x02000071 RID: 113
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class MultiPayMethods : global::System.Windows.Forms.Form
	{
		// Token: 0x060019B7 RID: 6583 RVA: 0x000ED334 File Offset: 0x000EB534
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

		// Token: 0x060019B8 RID: 6584 RVA: 0x000ED384 File Offset: 0x000EB584
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.txtbal = new global::System.Windows.Forms.TextBox();
			this.txtamtpaid = new global::System.Windows.Forms.TextBox();
			this.txtInvTotal = new global::System.Windows.Forms.TextBox();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.lblpaymethod = new global::System.Windows.Forms.Label();
			this.dgvPay = new global::System.Windows.Forms.DataGridView();
			this.GroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvPay).BeginInit();
			base.SuspendLayout();
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.txtbal);
			this.GroupBox1.Controls.Add(this.txtamtpaid);
			this.GroupBox1.Controls.Add(this.txtInvTotal);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Controls.Add(this.lblpaymethod);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new global::System.Drawing.Size(395, 162);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.Button1.Location = new global::System.Drawing.Point(272, 133);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(75, 23);
			this.Button1.TabIndex = 8;
			this.Button1.Text = "SAVE";
			this.Button1.UseVisualStyleBackColor = true;
			this.Label4.AutoSize = true;
			this.Label4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label4.Location = new global::System.Drawing.Point(9, 16);
			this.Label4.Name = "Label4";
			this.Label4.Size = new global::System.Drawing.Size(380, 17);
			this.Label4.TabIndex = 7;
			this.Label4.Text = "ENTER MULTIPLE PAYMENT METHODS FOR SALE";
			this.Label3.AutoSize = true;
			this.Label3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Italic, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label3.ForeColor = global::System.Drawing.Color.Red;
			this.Label3.Location = new global::System.Drawing.Point(6, 39);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(349, 39);
			this.Label3.TabIndex = 6;
			this.Label3.Text = "*press ENTER to calculate how much should be paid to pay off balance.\r\n*press F5 to save and go back to sale.\r\n*press ESC to CLEAR and restart.";
			this.Label2.AutoSize = true;
			this.Label2.Location = new global::System.Drawing.Point(93, 138);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(49, 13);
			this.Label2.TabIndex = 5;
			this.Label2.Text = "Balance:";
			this.txtbal.Location = new global::System.Drawing.Point(148, 135);
			this.txtbal.Name = "txtbal";
			this.txtbal.ReadOnly = true;
			this.txtbal.Size = new global::System.Drawing.Size(118, 20);
			this.txtbal.TabIndex = 4;
			this.txtbal.TabStop = false;
			this.txtamtpaid.Location = new global::System.Drawing.Point(148, 109);
			this.txtamtpaid.Name = "txtamtpaid";
			this.txtamtpaid.ReadOnly = true;
			this.txtamtpaid.Size = new global::System.Drawing.Size(118, 20);
			this.txtamtpaid.TabIndex = 3;
			this.txtamtpaid.TabStop = false;
			this.txtInvTotal.Location = new global::System.Drawing.Point(148, 83);
			this.txtInvTotal.Name = "txtInvTotal";
			this.txtInvTotal.ReadOnly = true;
			this.txtInvTotal.Size = new global::System.Drawing.Size(118, 20);
			this.txtInvTotal.TabIndex = 2;
			this.txtInvTotal.TabStop = false;
			this.Label1.AutoSize = true;
			this.Label1.Location = new global::System.Drawing.Point(72, 113);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(70, 13);
			this.Label1.TabIndex = 1;
			this.Label1.Text = "Amount Paid:";
			this.lblpaymethod.AutoSize = true;
			this.lblpaymethod.Location = new global::System.Drawing.Point(12, 86);
			this.lblpaymethod.Name = "lblpaymethod";
			this.lblpaymethod.Size = new global::System.Drawing.Size(39, 13);
			this.lblpaymethod.TabIndex = 0;
			this.lblpaymethod.Text = "Label1";
			this.dgvPay.AllowUserToAddRows = false;
			this.dgvPay.AllowUserToDeleteRows = false;
			this.dgvPay.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvPay.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dgvPay.Location = new global::System.Drawing.Point(0, 162);
			this.dgvPay.Name = "dgvPay";
			this.dgvPay.Size = new global::System.Drawing.Size(395, 196);
			this.dgvPay.TabIndex = 1;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(395, 358);
			base.Controls.Add(this.dgvPay);
			base.Controls.Add(this.GroupBox1);
			base.Name = "MultiPayMethods";
			this.Text = "Multipe Payment Methods";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvPay).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000C6F RID: 3183
		private global::System.ComponentModel.IContainer components;
	}
}
