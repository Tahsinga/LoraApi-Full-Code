namespace PointOfSale
{
	// Token: 0x020001FA RID: 506
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class SupervisorApproval : global::System.Windows.Forms.Form
	{
		// Token: 0x06005A9E RID: 23198 RVA: 0x003441F4 File Offset: 0x003423F4
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

		// Token: 0x06005A9F RID: 23199 RVA: 0x00344244 File Offset: 0x00342444
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.Label1 = new global::System.Windows.Forms.Label();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.txtPassword = new global::System.Windows.Forms.TextBox();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.Button2 = new global::System.Windows.Forms.Button();
			this.cboDiscount = new global::System.Windows.Forms.ComboBox();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.chkLimitPayMethods = new global::System.Windows.Forms.CheckBox();
			this.cboPayMethods = new global::System.Windows.Forms.ComboBox();
			this.Label5 = new global::System.Windows.Forms.Label();
			this.Label6 = new global::System.Windows.Forms.Label();
			this.txtDiscAmount = new global::System.Windows.Forms.TextBox();
			this.chkPerc = new global::System.Windows.Forms.CheckBox();
			this.Button3 = new global::System.Windows.Forms.Button();
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.Label8 = new global::System.Windows.Forms.Label();
			this.Label7 = new global::System.Windows.Forms.Label();
			this.lblSelling = new global::System.Windows.Forms.Label();
			this.lblCost = new global::System.Windows.Forms.Label();
			this.lblProduct = new global::System.Windows.Forms.Label();
			this.Panel1 = new global::System.Windows.Forms.Panel();
			this.radIncrease = new global::System.Windows.Forms.RadioButton();
			this.radReduce = new global::System.Windows.Forms.RadioButton();
			this.Button5 = new global::System.Windows.Forms.Button();
			this.cboUsername = new global::System.Windows.Forms.ComboBox();
			this.GroupBox1.SuspendLayout();
			this.Panel1.SuspendLayout();
			base.SuspendLayout();
			this.Label1.AutoSize = true;
			this.Label1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.Label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label1.Location = new global::System.Drawing.Point(0, 0);
			this.Label1.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(271, 32);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Supervisor Approval";
			this.Label2.AutoSize = true;
			this.Label2.Location = new global::System.Drawing.Point(18, 131);
			this.Label2.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(166, 20);
			this.Label2.TabIndex = 1;
			this.Label2.Text = "Supervisor Username:";
			this.txtPassword.Location = new global::System.Drawing.Point(194, 166);
			this.txtPassword.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new global::System.Drawing.Size(226, 26);
			this.txtPassword.TabIndex = 2;
			this.Label3.AutoSize = true;
			this.Label3.Location = new global::System.Drawing.Point(100, 173);
			this.Label3.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(82, 20);
			this.Label3.TabIndex = 3;
			this.Label3.Text = "Password:";
			this.Button1.BackColor = global::System.Drawing.Color.Lime;
			this.Button1.Location = new global::System.Drawing.Point(189, 442);
			this.Button1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(112, 35);
			this.Button1.TabIndex = 9;
			this.Button1.Text = "Approve";
			this.Button1.UseVisualStyleBackColor = false;
			this.Button2.BackColor = global::System.Drawing.Color.FromArgb(255, 128, 128);
			this.Button2.Location = new global::System.Drawing.Point(308, 442);
			this.Button2.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Button2.Name = "Button2";
			this.Button2.Size = new global::System.Drawing.Size(112, 35);
			this.Button2.TabIndex = 10;
			this.Button2.Text = "Cancel";
			this.Button2.UseVisualStyleBackColor = false;
			this.cboDiscount.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboDiscount.FormattingEnabled = true;
			this.cboDiscount.Location = new global::System.Drawing.Point(194, 294);
			this.cboDiscount.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cboDiscount.Name = "cboDiscount";
			this.cboDiscount.Size = new global::System.Drawing.Size(226, 28);
			this.cboDiscount.TabIndex = 5;
			this.cboDiscount.Visible = false;
			this.Label4.AutoSize = true;
			this.Label4.Location = new global::System.Drawing.Point(40, 298);
			this.Label4.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label4.Name = "Label4";
			this.Label4.Size = new global::System.Drawing.Size(143, 20);
			this.Label4.TabIndex = 8;
			this.Label4.Text = "Select Discount %:";
			this.Label4.Visible = false;
			this.chkLimitPayMethods.AutoSize = true;
			this.chkLimitPayMethods.Location = new global::System.Drawing.Point(194, 369);
			this.chkLimitPayMethods.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.chkLimitPayMethods.Name = "chkLimitPayMethods";
			this.chkLimitPayMethods.Size = new global::System.Drawing.Size(209, 24);
			this.chkLimitPayMethods.TabIndex = 6;
			this.chkLimitPayMethods.Text = "Limit Payment Methods?";
			this.chkLimitPayMethods.UseVisualStyleBackColor = true;
			this.cboPayMethods.FormattingEnabled = true;
			this.cboPayMethods.Location = new global::System.Drawing.Point(194, 404);
			this.cboPayMethods.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cboPayMethods.Name = "cboPayMethods";
			this.cboPayMethods.Size = new global::System.Drawing.Size(226, 28);
			this.cboPayMethods.TabIndex = 8;
			this.cboPayMethods.Visible = false;
			this.Label5.AutoSize = true;
			this.Label5.Location = new global::System.Drawing.Point(50, 410);
			this.Label5.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label5.Name = "Label5";
			this.Label5.Size = new global::System.Drawing.Size(133, 20);
			this.Label5.TabIndex = 12;
			this.Label5.Text = "Payment Method:";
			this.Label5.Visible = false;
			this.Label6.AutoSize = true;
			this.Label6.Location = new global::System.Drawing.Point(6, 340);
			this.Label6.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label6.Name = "Label6";
			this.Label6.Size = new global::System.Drawing.Size(179, 20);
			this.Label6.TabIndex = 14;
			this.Label6.Text = "Enter Discount Amount:";
			this.txtDiscAmount.Location = new global::System.Drawing.Point(194, 333);
			this.txtDiscAmount.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtDiscAmount.Name = "txtDiscAmount";
			this.txtDiscAmount.Size = new global::System.Drawing.Size(226, 26);
			this.txtDiscAmount.TabIndex = 4;
			this.chkPerc.AutoSize = true;
			this.chkPerc.Location = new global::System.Drawing.Point(194, 258);
			this.chkPerc.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.chkPerc.Name = "chkPerc";
			this.chkPerc.Size = new global::System.Drawing.Size(143, 24);
			this.chkPerc.TabIndex = 3;
			this.chkPerc.Text = "Is Percentage?";
			this.chkPerc.UseVisualStyleBackColor = true;
			this.Button3.Location = new global::System.Drawing.Point(191, 497);
			this.Button3.Name = "Button3";
			this.Button3.Size = new global::System.Drawing.Size(229, 38);
			this.Button3.TabIndex = 11;
			this.Button3.Text = "Clear Discount";
			this.Button3.UseVisualStyleBackColor = true;
			this.GroupBox1.BackColor = global::System.Drawing.Color.FromArgb(255, 255, 192);
			this.GroupBox1.Controls.Add(this.Label8);
			this.GroupBox1.Controls.Add(this.Label7);
			this.GroupBox1.Controls.Add(this.lblSelling);
			this.GroupBox1.Controls.Add(this.lblCost);
			this.GroupBox1.Controls.Add(this.lblProduct);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 32);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new global::System.Drawing.Size(538, 86);
			this.GroupBox1.TabIndex = 15;
			this.GroupBox1.TabStop = false;
			this.Label8.AutoSize = true;
			this.Label8.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label8.Location = new global::System.Drawing.Point(257, 48);
			this.Label8.Name = "Label8";
			this.Label8.Size = new global::System.Drawing.Size(94, 29);
			this.Label8.TabIndex = 4;
			this.Label8.Text = "Selling:";
			this.Label7.AutoSize = true;
			this.Label7.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label7.Location = new global::System.Drawing.Point(6, 48);
			this.Label7.Name = "Label7";
			this.Label7.Size = new global::System.Drawing.Size(68, 29);
			this.Label7.TabIndex = 3;
			this.Label7.Text = "Cost:";
			this.lblSelling.AutoSize = true;
			this.lblSelling.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblSelling.Location = new global::System.Drawing.Point(357, 48);
			this.lblSelling.Name = "lblSelling";
			this.lblSelling.Size = new global::System.Drawing.Size(31, 29);
			this.lblSelling.TabIndex = 2;
			this.lblSelling.Text = "...";
			this.lblCost.AutoSize = true;
			this.lblCost.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblCost.Location = new global::System.Drawing.Point(75, 48);
			this.lblCost.Name = "lblCost";
			this.lblCost.Size = new global::System.Drawing.Size(31, 29);
			this.lblCost.TabIndex = 1;
			this.lblCost.Text = "...";
			this.lblProduct.AutoSize = true;
			this.lblProduct.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblProduct.Location = new global::System.Drawing.Point(12, 15);
			this.lblProduct.Name = "lblProduct";
			this.lblProduct.Size = new global::System.Drawing.Size(31, 29);
			this.lblProduct.TabIndex = 0;
			this.lblProduct.Text = "...";
			this.Panel1.BackColor = global::System.Drawing.Color.FromArgb(128, 255, 255);
			this.Panel1.Controls.Add(this.radIncrease);
			this.Panel1.Controls.Add(this.radReduce);
			this.Panel1.Location = new global::System.Drawing.Point(0, 196);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new global::System.Drawing.Size(537, 47);
			this.Panel1.TabIndex = 16;
			this.radIncrease.AutoSize = true;
			this.radIncrease.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.radIncrease.Location = new global::System.Drawing.Point(302, 15);
			this.radIncrease.Name = "radIncrease";
			this.radIncrease.Size = new global::System.Drawing.Size(184, 24);
			this.radIncrease.TabIndex = 1;
			this.radIncrease.Text = "INCREASE PRICE";
			this.radIncrease.UseVisualStyleBackColor = true;
			this.radReduce.AutoSize = true;
			this.radReduce.Checked = true;
			this.radReduce.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.radReduce.Location = new global::System.Drawing.Point(54, 15);
			this.radReduce.Name = "radReduce";
			this.radReduce.Size = new global::System.Drawing.Size(168, 24);
			this.radReduce.TabIndex = 0;
			this.radReduce.TabStop = true;
			this.radReduce.Text = "REDUCE PRICE";
			this.radReduce.UseVisualStyleBackColor = true;
			this.Button5.Image = global::PointOfSale.My.Resources.Resources.numeric_keypad3;
			this.Button5.Location = new global::System.Drawing.Point(428, 331);
			this.Button5.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Button5.Name = "Button5";
			this.Button5.Size = new global::System.Drawing.Size(58, 34);
			this.Button5.TabIndex = 17;
			this.Button5.UseVisualStyleBackColor = true;
			this.cboUsername.FormattingEnabled = true;
			this.cboUsername.Location = new global::System.Drawing.Point(194, 131);
			this.cboUsername.Name = "cboUsername";
			this.cboUsername.Size = new global::System.Drawing.Size(226, 28);
			this.cboUsername.TabIndex = 18;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(538, 583);
			base.Controls.Add(this.cboUsername);
			base.Controls.Add(this.Button5);
			base.Controls.Add(this.Panel1);
			base.Controls.Add(this.GroupBox1);
			base.Controls.Add(this.Button3);
			base.Controls.Add(this.chkPerc);
			base.Controls.Add(this.txtDiscAmount);
			base.Controls.Add(this.Label6);
			base.Controls.Add(this.Label5);
			base.Controls.Add(this.cboPayMethods);
			base.Controls.Add(this.chkLimitPayMethods);
			base.Controls.Add(this.Label4);
			base.Controls.Add(this.cboDiscount);
			base.Controls.Add(this.Button2);
			base.Controls.Add(this.Button1);
			base.Controls.Add(this.txtPassword);
			base.Controls.Add(this.Label3);
			base.Controls.Add(this.Label2);
			base.Controls.Add(this.Label1);
			base.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			base.Name = "SupervisorApproval";
			this.Text = "Supervisor Approval";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04002790 RID: 10128
		private global::System.ComponentModel.IContainer components;
	}
}
