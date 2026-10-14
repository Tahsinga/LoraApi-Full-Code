namespace PointOfSale
{
	// Token: 0x02000087 RID: 135
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class PayDeposit : global::System.Windows.Forms.Form
	{
		// Token: 0x06001EF0 RID: 7920 RVA: 0x00113E04 File Offset: 0x00112004
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

		// Token: 0x06001EF1 RID: 7921 RVA: 0x00113E54 File Offset: 0x00112054
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.GroupBox2 = new global::System.Windows.Forms.GroupBox();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.txtBarcode = new global::System.Windows.Forms.TextBox();
			this.lblDepAmt = new global::System.Windows.Forms.Label();
			this.cboPayMeth = new global::System.Windows.Forms.ComboBox();
			this.txtamt = new global::System.Windows.Forms.TextBox();
			this.GroupBox3 = new global::System.Windows.Forms.GroupBox();
			this.cmdPay = new global::System.Windows.Forms.Button();
			this.PrintDocument1 = new global::System.Drawing.Printing.PrintDocument();
			this.GroupBox1.SuspendLayout();
			this.GroupBox2.SuspendLayout();
			this.GroupBox3.SuspendLayout();
			base.SuspendLayout();
			this.GroupBox1.Controls.Add(this.txtBarcode);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new global::System.Drawing.Size(939, 134);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Scan Barcode or Enter Code";
			this.GroupBox2.Controls.Add(this.lblDepAmt);
			this.GroupBox2.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox2.Location = new global::System.Drawing.Point(0, 134);
			this.GroupBox2.Name = "GroupBox2";
			this.GroupBox2.Size = new global::System.Drawing.Size(939, 67);
			this.GroupBox2.TabIndex = 1;
			this.GroupBox2.TabStop = false;
			this.GroupBox2.Text = "Deposit Amount";
			this.Label1.AutoSize = true;
			this.Label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label1.Location = new global::System.Drawing.Point(78, 41);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(237, 32);
			this.Label1.TabIndex = 2;
			this.Label1.Text = "Payment Method:";
			this.Label2.AutoSize = true;
			this.Label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label2.Location = new global::System.Drawing.Point(9, 104);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(306, 32);
			this.Label2.TabIndex = 3;
			this.Label2.Text = "AMOUNT RETURNED:";
			this.txtBarcode.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 18f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtBarcode.Location = new global::System.Drawing.Point(218, 50);
			this.txtBarcode.Name = "txtBarcode";
			this.txtBarcode.Size = new global::System.Drawing.Size(489, 48);
			this.txtBarcode.TabIndex = 0;
			this.txtBarcode.TabStop = false;
			this.lblDepAmt.AutoSize = true;
			this.lblDepAmt.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblDepAmt.Location = new global::System.Drawing.Point(315, 32);
			this.lblDepAmt.Name = "lblDepAmt";
			this.lblDepAmt.Size = new global::System.Drawing.Size(39, 32);
			this.lblDepAmt.TabIndex = 0;
			this.lblDepAmt.Text = "...";
			this.cboPayMeth.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.cboPayMeth.FormattingEnabled = true;
			this.cboPayMeth.Location = new global::System.Drawing.Point(321, 33);
			this.cboPayMeth.Name = "cboPayMeth";
			this.cboPayMeth.Size = new global::System.Drawing.Size(310, 40);
			this.cboPayMeth.TabIndex = 4;
			this.cboPayMeth.TabStop = false;
			this.txtamt.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 16f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtamt.Location = new global::System.Drawing.Point(321, 98);
			this.txtamt.Name = "txtamt";
			this.txtamt.Size = new global::System.Drawing.Size(310, 44);
			this.txtamt.TabIndex = 5;
			this.GroupBox3.Controls.Add(this.cmdPay);
			this.GroupBox3.Controls.Add(this.cboPayMeth);
			this.GroupBox3.Controls.Add(this.txtamt);
			this.GroupBox3.Controls.Add(this.Label1);
			this.GroupBox3.Controls.Add(this.Label2);
			this.GroupBox3.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.GroupBox3.Location = new global::System.Drawing.Point(0, 201);
			this.GroupBox3.Name = "GroupBox3";
			this.GroupBox3.Size = new global::System.Drawing.Size(939, 214);
			this.GroupBox3.TabIndex = 6;
			this.GroupBox3.TabStop = false;
			this.GroupBox3.Text = "GroupBox3";
			this.cmdPay.BackColor = global::System.Drawing.Color.Lime;
			this.cmdPay.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.cmdPay.Location = new global::System.Drawing.Point(321, 159);
			this.cmdPay.Name = "cmdPay";
			this.cmdPay.Size = new global::System.Drawing.Size(310, 43);
			this.cmdPay.TabIndex = 6;
			this.cmdPay.Text = "PAY";
			this.cmdPay.UseVisualStyleBackColor = false;
			this.cmdPay.Visible = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(939, 415);
			base.Controls.Add(this.GroupBox3);
			base.Controls.Add(this.GroupBox2);
			base.Controls.Add(this.GroupBox1);
			base.Name = "PayDeposit";
			this.Text = "Pay Back Deposit";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.GroupBox2.ResumeLayout(false);
			this.GroupBox2.PerformLayout();
			this.GroupBox3.ResumeLayout(false);
			this.GroupBox3.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04000EAC RID: 3756
		private global::System.ComponentModel.IContainer components;
	}
}
