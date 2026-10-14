namespace PointOfSale
{
	// Token: 0x02000014 RID: 20
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class BillingEnterPaymentfrm : global::System.Windows.Forms.Form
	{
		// Token: 0x06000318 RID: 792 RVA: 0x0001BC60 File Offset: 0x00019E60
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

		// Token: 0x06000319 RID: 793 RVA: 0x0001BCB0 File Offset: 0x00019EB0
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.GroupBox2 = new global::System.Windows.Forms.GroupBox();
			this.GroupBox3 = new global::System.Windows.Forms.GroupBox();
			this.dgvAccountTransactions = new global::System.Windows.Forms.DataGridView();
			this.txtAmtPaid = new global::System.Windows.Forms.TextBox();
			this.Label10 = new global::System.Windows.Forms.Label();
			this.Label6 = new global::System.Windows.Forms.Label();
			this.txtBalance = new global::System.Windows.Forms.TextBox();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.dgvAccPay = new global::System.Windows.Forms.DataGridView();
			this.Label7 = new global::System.Windows.Forms.Label();
			this.Button2 = new global::System.Windows.Forms.Button();
			this.Panel1 = new global::System.Windows.Forms.Panel();
			this.Label17 = new global::System.Windows.Forms.Label();
			this.txtEmail = new global::System.Windows.Forms.TextBox();
			this.Label16 = new global::System.Windows.Forms.Label();
			this.txtMobile = new global::System.Windows.Forms.TextBox();
			this.Label15 = new global::System.Windows.Forms.Label();
			this.txtContactName = new global::System.Windows.Forms.TextBox();
			this.Label14 = new global::System.Windows.Forms.Label();
			this.txtAddress = new global::System.Windows.Forms.TextBox();
			this.Label13 = new global::System.Windows.Forms.Label();
			this.Label12 = new global::System.Windows.Forms.Label();
			this.txtcustomer = new global::System.Windows.Forms.TextBox();
			this.GroupBox1.SuspendLayout();
			this.GroupBox2.SuspendLayout();
			this.GroupBox3.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvAccountTransactions).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.dgvAccPay).BeginInit();
			this.Panel1.SuspendLayout();
			base.SuspendLayout();
			this.GroupBox1.Controls.Add(this.Panel1);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new global::System.Drawing.Size(970, 118);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Customer Details";
			this.GroupBox2.Controls.Add(this.Button2);
			this.GroupBox2.Controls.Add(this.dgvAccPay);
			this.GroupBox2.Controls.Add(this.Label7);
			this.GroupBox2.Controls.Add(this.Label1);
			this.GroupBox2.Controls.Add(this.txtAmtPaid);
			this.GroupBox2.Controls.Add(this.Label10);
			this.GroupBox2.Controls.Add(this.Label6);
			this.GroupBox2.Controls.Add(this.txtBalance);
			this.GroupBox2.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.GroupBox2.Location = new global::System.Drawing.Point(0, 295);
			this.GroupBox2.Name = "GroupBox2";
			this.GroupBox2.Size = new global::System.Drawing.Size(970, 214);
			this.GroupBox2.TabIndex = 1;
			this.GroupBox2.TabStop = false;
			this.GroupBox2.Text = "Receive Payment";
			this.GroupBox3.Controls.Add(this.dgvAccountTransactions);
			this.GroupBox3.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.GroupBox3.Location = new global::System.Drawing.Point(0, 118);
			this.GroupBox3.Name = "GroupBox3";
			this.GroupBox3.Size = new global::System.Drawing.Size(970, 177);
			this.GroupBox3.TabIndex = 2;
			this.GroupBox3.TabStop = false;
			this.GroupBox3.Text = "Transactions";
			this.dgvAccountTransactions.AllowUserToAddRows = false;
			this.dgvAccountTransactions.AllowUserToDeleteRows = false;
			this.dgvAccountTransactions.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAccountTransactions.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dgvAccountTransactions.Location = new global::System.Drawing.Point(3, 16);
			this.dgvAccountTransactions.Name = "dgvAccountTransactions";
			this.dgvAccountTransactions.ReadOnly = true;
			this.dgvAccountTransactions.Size = new global::System.Drawing.Size(964, 158);
			this.dgvAccountTransactions.TabIndex = 0;
			this.txtAmtPaid.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtAmtPaid.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtAmtPaid.Location = new global::System.Drawing.Point(613, 69);
			this.txtAmtPaid.Name = "txtAmtPaid";
			this.txtAmtPaid.ReadOnly = true;
			this.txtAmtPaid.Size = new global::System.Drawing.Size(166, 29);
			this.txtAmtPaid.TabIndex = 21;
			this.txtAmtPaid.TabStop = false;
			this.txtAmtPaid.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Right;
			this.Label10.AutoSize = true;
			this.Label10.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label10.Location = new global::System.Drawing.Point(515, 77);
			this.Label10.Name = "Label10";
			this.Label10.Size = new global::System.Drawing.Size(92, 17);
			this.Label10.TabIndex = 22;
			this.Label10.Text = "Amount Paid:";
			this.Label6.AutoSize = true;
			this.Label6.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label6.Location = new global::System.Drawing.Point(531, 44);
			this.Label6.Name = "Label6";
			this.Label6.Size = new global::System.Drawing.Size(63, 17);
			this.Label6.TabIndex = 20;
			this.Label6.Text = "Balance:";
			this.txtBalance.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtBalance.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtBalance.Location = new global::System.Drawing.Point(613, 36);
			this.txtBalance.Name = "txtBalance";
			this.txtBalance.ReadOnly = true;
			this.txtBalance.Size = new global::System.Drawing.Size(166, 29);
			this.txtBalance.TabIndex = 19;
			this.txtBalance.TabStop = false;
			this.txtBalance.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Right;
			this.Label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Italic, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label1.Location = new global::System.Drawing.Point(785, 29);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(173, 39);
			this.Label1.TabIndex = 23;
			this.Label1.Text = "* A negative balance means that the company owes the account customer.";
			this.dgvAccPay.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAccPay.Location = new global::System.Drawing.Point(126, 36);
			this.dgvAccPay.Name = "dgvAccPay";
			this.dgvAccPay.Size = new global::System.Drawing.Size(383, 150);
			this.dgvAccPay.TabIndex = 24;
			this.dgvAccPay.TabStop = false;
			this.Label7.AutoSize = true;
			this.Label7.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label7.Location = new global::System.Drawing.Point(2, 37);
			this.Label7.Name = "Label7";
			this.Label7.Size = new global::System.Drawing.Size(118, 17);
			this.Label7.TabIndex = 25;
			this.Label7.Text = "Payment Method:";
			this.Button2.BackColor = global::System.Drawing.Color.Lime;
			this.Button2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Button2.Location = new global::System.Drawing.Point(613, 154);
			this.Button2.Name = "Button2";
			this.Button2.Size = new global::System.Drawing.Size(166, 32);
			this.Button2.TabIndex = 26;
			this.Button2.TabStop = false;
			this.Button2.Text = "CONFIRM PAYMENT";
			this.Button2.UseVisualStyleBackColor = false;
			this.Panel1.BackColor = global::System.Drawing.Color.FromArgb(192, 255, 255);
			this.Panel1.Controls.Add(this.Label17);
			this.Panel1.Controls.Add(this.txtEmail);
			this.Panel1.Controls.Add(this.Label16);
			this.Panel1.Controls.Add(this.txtMobile);
			this.Panel1.Controls.Add(this.Label15);
			this.Panel1.Controls.Add(this.txtContactName);
			this.Panel1.Controls.Add(this.Label14);
			this.Panel1.Controls.Add(this.txtAddress);
			this.Panel1.Controls.Add(this.Label13);
			this.Panel1.Controls.Add(this.Label12);
			this.Panel1.Controls.Add(this.txtcustomer);
			this.Panel1.Location = new global::System.Drawing.Point(69, 24);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new global::System.Drawing.Size(832, 71);
			this.Panel1.TabIndex = 4;
			this.Label17.AutoSize = true;
			this.Label17.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label17.Location = new global::System.Drawing.Point(610, 43);
			this.Label17.Name = "Label17";
			this.Label17.Size = new global::System.Drawing.Size(46, 17);
			this.Label17.TabIndex = 36;
			this.Label17.Text = "Email:";
			this.txtEmail.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtEmail.Location = new global::System.Drawing.Point(665, 38);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.ReadOnly = true;
			this.txtEmail.Size = new global::System.Drawing.Size(156, 26);
			this.txtEmail.TabIndex = 6;
			this.txtEmail.TabStop = false;
			this.Label16.AutoSize = true;
			this.Label16.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label16.Location = new global::System.Drawing.Point(417, 44);
			this.Label16.Name = "Label16";
			this.Label16.Size = new global::System.Drawing.Size(53, 17);
			this.Label16.TabIndex = 34;
			this.Label16.Text = "Mobile:";
			this.txtMobile.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtMobile.Location = new global::System.Drawing.Point(476, 38);
			this.txtMobile.Name = "txtMobile";
			this.txtMobile.ReadOnly = true;
			this.txtMobile.Size = new global::System.Drawing.Size(113, 26);
			this.txtMobile.TabIndex = 5;
			this.txtMobile.TabStop = false;
			this.Label15.AutoSize = true;
			this.Label15.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label15.Location = new global::System.Drawing.Point(14, 42);
			this.Label15.Name = "Label15";
			this.Label15.Size = new global::System.Drawing.Size(60, 17);
			this.Label15.TabIndex = 32;
			this.Label15.Text = "Contact:";
			this.txtContactName.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtContactName.Location = new global::System.Drawing.Point(124, 38);
			this.txtContactName.MaxLength = 50;
			this.txtContactName.Name = "txtContactName";
			this.txtContactName.ReadOnly = true;
			this.txtContactName.Size = new global::System.Drawing.Size(240, 26);
			this.txtContactName.TabIndex = 4;
			this.txtContactName.TabStop = false;
			this.Label14.AutoSize = true;
			this.Label14.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label14.Location = new global::System.Drawing.Point(406, 12);
			this.Label14.Name = "Label14";
			this.Label14.Size = new global::System.Drawing.Size(64, 17);
			this.Label14.TabIndex = 30;
			this.Label14.Text = "Address:";
			this.txtAddress.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtAddress.Location = new global::System.Drawing.Point(476, 6);
			this.txtAddress.MaxLength = 50;
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.ReadOnly = true;
			this.txtAddress.Size = new global::System.Drawing.Size(345, 26);
			this.txtAddress.TabIndex = 3;
			this.txtAddress.TabStop = false;
			this.Label13.AutoSize = true;
			this.Label13.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label13.ForeColor = global::System.Drawing.Color.Red;
			this.Label13.Location = new global::System.Drawing.Point(370, 9);
			this.Label13.Name = "Label13";
			this.Label13.Size = new global::System.Drawing.Size(16, 20);
			this.Label13.TabIndex = 28;
			this.Label13.Text = "*";
			this.Label12.AutoSize = true;
			this.Label12.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label12.Location = new global::System.Drawing.Point(5, 12);
			this.Label12.Name = "Label12";
			this.Label12.Size = new global::System.Drawing.Size(113, 17);
			this.Label12.TabIndex = 27;
			this.Label12.Text = "Customer Name:";
			this.txtcustomer.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtcustomer.Location = new global::System.Drawing.Point(124, 6);
			this.txtcustomer.MaxLength = 50;
			this.txtcustomer.Name = "txtcustomer";
			this.txtcustomer.ReadOnly = true;
			this.txtcustomer.Size = new global::System.Drawing.Size(240, 26);
			this.txtcustomer.TabIndex = 2;
			this.txtcustomer.TabStop = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(970, 509);
			base.Controls.Add(this.GroupBox3);
			base.Controls.Add(this.GroupBox2);
			base.Controls.Add(this.GroupBox1);
			base.Name = "BillingEnterPaymentfrm";
			this.Text = "Enter Payment for Account Sales";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox2.ResumeLayout(false);
			this.GroupBox2.PerformLayout();
			this.GroupBox3.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.dgvAccountTransactions).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.dgvAccPay).EndInit();
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x0400015A RID: 346
		private global::System.ComponentModel.IContainer components;
	}
}
