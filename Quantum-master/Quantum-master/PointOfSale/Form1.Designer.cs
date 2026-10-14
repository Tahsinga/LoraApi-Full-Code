namespace PointOfSale
{
	// Token: 0x0200005C RID: 92
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Form1 : global::System.Windows.Forms.Form
	{
		// Token: 0x06001366 RID: 4966 RVA: 0x000B96C0 File Offset: 0x000B78C0
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

		// Token: 0x06001367 RID: 4967 RVA: 0x000B9710 File Offset: 0x000B7910
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.Label1 = new global::System.Windows.Forms.Label();
			this.txtUsername = new global::System.Windows.Forms.TextBox();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.txtPwd = new global::System.Windows.Forms.TextBox();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.Button2 = new global::System.Windows.Forms.Button();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.lblerr = new global::System.Windows.Forms.Label();
			this.cboBranch = new global::System.Windows.Forms.ComboBox();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.Label5 = new global::System.Windows.Forms.Label();
			this.cboMode = new global::System.Windows.Forms.ComboBox();
			this.Label6 = new global::System.Windows.Forms.Label();
			this.cboCompany = new global::System.Windows.Forms.ComboBox();
			this.Button3 = new global::System.Windows.Forms.Button();
			this.Label7 = new global::System.Windows.Forms.Label();
			this.Label8 = new global::System.Windows.Forms.Label();
			this.Button4 = new global::System.Windows.Forms.Button();
			this.Button5 = new global::System.Windows.Forms.Button();
			this.Button6 = new global::System.Windows.Forms.Button();
			base.SuspendLayout();
			this.Label1.AutoSize = true;
			this.Label1.Location = new global::System.Drawing.Point(52, 158);
			this.Label1.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(83, 20);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Username";
			this.txtUsername.Location = new global::System.Drawing.Point(144, 153);
			this.txtUsername.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new global::System.Drawing.Size(212, 26);
			this.txtUsername.TabIndex = 1;
			this.Button1.BackColor = global::System.Drawing.Color.Lime;
			this.Button1.Location = new global::System.Drawing.Point(146, 416);
			this.Button1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(140, 35);
			this.Button1.TabIndex = 6;
			this.Button1.Text = "Log In";
			this.Button1.UseVisualStyleBackColor = false;
			this.txtPwd.Location = new global::System.Drawing.Point(144, 224);
			this.txtPwd.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtPwd.Name = "txtPwd";
			this.txtPwd.PasswordChar = '*';
			this.txtPwd.Size = new global::System.Drawing.Size(212, 26);
			this.txtPwd.TabIndex = 2;
			this.txtPwd.UseSystemPasswordChar = true;
			this.Label2.AutoSize = true;
			this.Label2.Location = new global::System.Drawing.Point(52, 229);
			this.Label2.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(78, 20);
			this.Label2.TabIndex = 3;
			this.Label2.Text = "Password";
			this.Button2.Location = new global::System.Drawing.Point(308, 416);
			this.Button2.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Button2.Name = "Button2";
			this.Button2.Size = new global::System.Drawing.Size(140, 35);
			this.Button2.TabIndex = 7;
			this.Button2.Text = "Cancel";
			this.Button2.UseVisualStyleBackColor = true;
			this.Label3.AutoSize = true;
			this.Label3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label3.Location = new global::System.Drawing.Point(138, 108);
			this.Label3.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(93, 32);
			this.Label3.TabIndex = 6;
			this.Label3.Text = "Log In";
			this.lblerr.AutoSize = true;
			this.lblerr.ForeColor = global::System.Drawing.Color.Red;
			this.lblerr.Location = new global::System.Drawing.Point(142, 456);
			this.lblerr.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblerr.Name = "lblerr";
			this.lblerr.Size = new global::System.Drawing.Size(21, 20);
			this.lblerr.TabIndex = 7;
			this.lblerr.Text = "...";
			this.cboBranch.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboBranch.FormattingEnabled = true;
			this.cboBranch.Location = new global::System.Drawing.Point(144, 333);
			this.cboBranch.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cboBranch.Name = "cboBranch";
			this.cboBranch.Size = new global::System.Drawing.Size(212, 28);
			this.cboBranch.TabIndex = 4;
			this.Label4.AutoSize = true;
			this.Label4.Location = new global::System.Drawing.Point(66, 338);
			this.Label4.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label4.Name = "Label4";
			this.Label4.Size = new global::System.Drawing.Size(64, 20);
			this.Label4.TabIndex = 9;
			this.Label4.Text = "Branch:";
			this.Label5.AutoSize = true;
			this.Label5.Location = new global::System.Drawing.Point(76, 379);
			this.Label5.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label5.Name = "Label5";
			this.Label5.Size = new global::System.Drawing.Size(53, 20);
			this.Label5.TabIndex = 11;
			this.Label5.Text = "Mode:";
			this.cboMode.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboMode.FormattingEnabled = true;
			this.cboMode.Items.AddRange(new object[] { "Normal", "Self Service Kiosk" });
			this.cboMode.Location = new global::System.Drawing.Point(144, 375);
			this.cboMode.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cboMode.Name = "cboMode";
			this.cboMode.Size = new global::System.Drawing.Size(212, 28);
			this.cboMode.TabIndex = 5;
			this.Label6.AutoSize = true;
			this.Label6.Location = new global::System.Drawing.Point(52, 295);
			this.Label6.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label6.Name = "Label6";
			this.Label6.Size = new global::System.Drawing.Size(80, 20);
			this.Label6.TabIndex = 12;
			this.Label6.Text = "Company:";
			this.cboCompany.FormattingEnabled = true;
			this.cboCompany.Items.AddRange(new object[] { "Normal", "Self Service Kiosk" });
			this.cboCompany.Location = new global::System.Drawing.Point(144, 290);
			this.cboCompany.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cboCompany.Name = "cboCompany";
			this.cboCompany.Size = new global::System.Drawing.Size(212, 28);
			this.cboCompany.TabIndex = 3;
			this.Button3.Location = new global::System.Drawing.Point(368, 330);
			this.Button3.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Button3.Name = "Button3";
			this.Button3.Size = new global::System.Drawing.Size(156, 35);
			this.Button3.TabIndex = 13;
			this.Button3.Text = "Load Branches";
			this.Button3.UseVisualStyleBackColor = true;
			this.Label7.AutoSize = true;
			this.Label7.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.Label7.Location = new global::System.Drawing.Point(512, 0);
			this.Label7.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label7.Name = "Label7";
			this.Label7.Size = new global::System.Drawing.Size(45, 20);
			this.Label7.TabIndex = 14;
			this.Label7.Text = ".........";
			this.Label8.AutoSize = true;
			this.Label8.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label8.Location = new global::System.Drawing.Point(50, 66);
			this.Label8.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label8.Name = "Label8";
			this.Label8.Size = new global::System.Drawing.Size(462, 32);
			this.Label8.TabIndex = 15;
			this.Label8.Text = "QuantumPOS Point of Sale System";
			this.Button4.Image = global::PointOfSale.My.Resources.Resources.numeric_keypad3;
			this.Button4.Location = new global::System.Drawing.Point(368, 142);
			this.Button4.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Button4.Name = "Button4";
			this.Button4.Size = new global::System.Drawing.Size(64, 49);
			this.Button4.TabIndex = 16;
			this.Button4.UseVisualStyleBackColor = true;
			this.Button5.Image = global::PointOfSale.My.Resources.Resources.numeric_keypad3;
			this.Button5.Location = new global::System.Drawing.Point(368, 213);
			this.Button5.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Button5.Name = "Button5";
			this.Button5.Size = new global::System.Drawing.Size(64, 49);
			this.Button5.TabIndex = 17;
			this.Button5.UseVisualStyleBackColor = true;
			this.Button6.FlatAppearance.BorderColor = global::System.Drawing.Color.Black;
			this.Button6.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.Green;
			this.Button6.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.Button6.Location = new global::System.Drawing.Point(18, 16);
			this.Button6.Name = "Button6";
			this.Button6.Size = new global::System.Drawing.Size(225, 47);
			this.Button6.TabIndex = 18;
			this.Button6.TabStop = false;
			this.Button6.Text = "Contact Quantum Business Solutions";
			this.Button6.UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(557, 502);
			base.Controls.Add(this.Button6);
			base.Controls.Add(this.Button5);
			base.Controls.Add(this.Button4);
			base.Controls.Add(this.Label8);
			base.Controls.Add(this.Label7);
			base.Controls.Add(this.Button3);
			base.Controls.Add(this.cboCompany);
			base.Controls.Add(this.Label6);
			base.Controls.Add(this.Label5);
			base.Controls.Add(this.cboMode);
			base.Controls.Add(this.Label4);
			base.Controls.Add(this.cboBranch);
			base.Controls.Add(this.lblerr);
			base.Controls.Add(this.Label3);
			base.Controls.Add(this.Button2);
			base.Controls.Add(this.txtPwd);
			base.Controls.Add(this.Label2);
			base.Controls.Add(this.Button1);
			base.Controls.Add(this.txtUsername);
			base.Controls.Add(this.Label1);
			base.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			base.Name = "Form1";
			this.Text = "Log In";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040009DD RID: 2525
		private global::System.ComponentModel.IContainer components;
	}
}
