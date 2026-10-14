namespace PointOfSale
{
	// Token: 0x02000200 RID: 512
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class TellerDisbursements : global::System.Windows.Forms.Form
	{
		// Token: 0x06005C0C RID: 23564 RVA: 0x0034ECEC File Offset: 0x0034CEEC
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

		// Token: 0x06005C0D RID: 23565 RVA: 0x0034ED3C File Offset: 0x0034CF3C
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.cboPaymentMethods = new global::System.Windows.Forms.ComboBox();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.Label5 = new global::System.Windows.Forms.Label();
			this.txtAmount = new global::System.Windows.Forms.TextBox();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.txtreason = new global::System.Windows.Forms.TextBox();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.lblBalance = new global::System.Windows.Forms.Label();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.cboSource = new global::System.Windows.Forms.ComboBox();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.GroupBox1.SuspendLayout();
			base.SuspendLayout();
			this.GroupBox1.Controls.Add(this.cboPaymentMethods);
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Controls.Add(this.Label5);
			this.GroupBox1.Controls.Add(this.txtAmount);
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Controls.Add(this.txtreason);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.lblBalance);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.cboSource);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new global::System.Drawing.Size(464, 302);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.cboPaymentMethods.FormattingEnabled = true;
			this.cboPaymentMethods.Location = new global::System.Drawing.Point(94, 102);
			this.cboPaymentMethods.Name = "cboPaymentMethods";
			this.cboPaymentMethods.Size = new global::System.Drawing.Size(212, 21);
			this.cboPaymentMethods.TabIndex = 11;
			this.Button1.BackColor = global::System.Drawing.Color.Lime;
			this.Button1.Location = new global::System.Drawing.Point(94, 180);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(75, 23);
			this.Button1.TabIndex = 10;
			this.Button1.Text = "DISBURSE";
			this.Button1.UseVisualStyleBackColor = false;
			this.Label5.AutoSize = true;
			this.Label5.Location = new global::System.Drawing.Point(-2, 102);
			this.Label5.Name = "Label5";
			this.Label5.Size = new global::System.Drawing.Size(90, 13);
			this.Label5.TabIndex = 9;
			this.Label5.Text = "Payment Method:";
			this.txtAmount.Location = new global::System.Drawing.Point(94, 154);
			this.txtAmount.Name = "txtAmount";
			this.txtAmount.Size = new global::System.Drawing.Size(98, 20);
			this.txtAmount.TabIndex = 7;
			this.Label4.AutoSize = true;
			this.Label4.Location = new global::System.Drawing.Point(42, 157);
			this.Label4.Name = "Label4";
			this.Label4.Size = new global::System.Drawing.Size(46, 13);
			this.Label4.TabIndex = 6;
			this.Label4.Text = "Amount:";
			this.txtreason.Location = new global::System.Drawing.Point(94, 128);
			this.txtreason.Name = "txtreason";
			this.txtreason.Size = new global::System.Drawing.Size(212, 20);
			this.txtreason.TabIndex = 5;
			this.Label3.AutoSize = true;
			this.Label3.Location = new global::System.Drawing.Point(41, 131);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(47, 13);
			this.Label3.TabIndex = 4;
			this.Label3.Text = "Reason:";
			this.lblBalance.AutoSize = true;
			this.lblBalance.Location = new global::System.Drawing.Point(312, 110);
			this.lblBalance.Name = "lblBalance";
			this.lblBalance.Size = new global::System.Drawing.Size(16, 13);
			this.lblBalance.TabIndex = 3;
			this.lblBalance.Text = "...";
			this.Label2.AutoSize = true;
			this.Label2.Location = new global::System.Drawing.Point(11, 78);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(77, 13);
			this.Label2.TabIndex = 2;
			this.Label2.Text = "Select Source:";
			this.cboSource.FormattingEnabled = true;
			this.cboSource.Items.AddRange(new object[] { "Cash Sales", "Accounts Payments" });
			this.cboSource.Location = new global::System.Drawing.Point(94, 75);
			this.cboSource.Name = "cboSource";
			this.cboSource.Size = new global::System.Drawing.Size(212, 21);
			this.cboSource.TabIndex = 1;
			this.Label1.AutoSize = true;
			this.Label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label1.Location = new global::System.Drawing.Point(6, 16);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(298, 24);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Disburse Funds (Issue Funds Out)";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(464, 302);
			base.Controls.Add(this.GroupBox1);
			base.Name = "TellerDisbursements";
			this.Text = "Teller Disbursements";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04002846 RID: 10310
		private global::System.ComponentModel.IContainer components;
	}
}
