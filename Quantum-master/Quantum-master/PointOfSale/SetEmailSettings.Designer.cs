namespace PointOfSale
{
	// Token: 0x020001DC RID: 476
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class SetEmailSettings : global::System.Windows.Forms.UserControl
	{
		// Token: 0x06005355 RID: 21333 RVA: 0x00306EF8 File Offset: 0x003050F8
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

		// Token: 0x06005356 RID: 21334 RVA: 0x00306F48 File Offset: 0x00305148
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.Label1 = new global::System.Windows.Forms.Label();
			this.Panel1 = new global::System.Windows.Forms.Panel();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.chkSSL = new global::System.Windows.Forms.CheckBox();
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.Button2 = new global::System.Windows.Forms.Button();
			this.Label7 = new global::System.Windows.Forms.Label();
			this.txtBody = new global::System.Windows.Forms.TextBox();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.txtSubject = new global::System.Windows.Forms.TextBox();
			this.txtPassword = new global::System.Windows.Forms.TextBox();
			this.Label6 = new global::System.Windows.Forms.Label();
			this.txtUsername = new global::System.Windows.Forms.TextBox();
			this.Label5 = new global::System.Windows.Forms.Label();
			this.txtEmailHost = new global::System.Windows.Forms.TextBox();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.txtEmailFrom = new global::System.Windows.Forms.TextBox();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.Label8 = new global::System.Windows.Forms.Label();
			this.txtEmailTo = new global::System.Windows.Forms.TextBox();
			this.Panel1.SuspendLayout();
			this.GroupBox1.SuspendLayout();
			base.SuspendLayout();
			this.Label1.AutoSize = true;
			this.Label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label1.Location = new global::System.Drawing.Point(22, 23);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(326, 32);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "SET EMAIL SETTINGS";
			this.Panel1.Controls.Add(this.Button1);
			this.Panel1.Controls.Add(this.chkSSL);
			this.Panel1.Controls.Add(this.GroupBox1);
			this.Panel1.Controls.Add(this.txtPassword);
			this.Panel1.Controls.Add(this.Label6);
			this.Panel1.Controls.Add(this.txtUsername);
			this.Panel1.Controls.Add(this.Label5);
			this.Panel1.Controls.Add(this.txtEmailHost);
			this.Panel1.Controls.Add(this.Label3);
			this.Panel1.Controls.Add(this.txtEmailFrom);
			this.Panel1.Controls.Add(this.Label2);
			this.Panel1.Controls.Add(this.Label1);
			this.Panel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.Panel1.Location = new global::System.Drawing.Point(0, 0);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new global::System.Drawing.Size(1115, 550);
			this.Panel1.TabIndex = 1;
			this.Button1.Location = new global::System.Drawing.Point(162, 201);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(185, 31);
			this.Button1.TabIndex = 7;
			this.Button1.Text = "Button1";
			this.Button1.UseVisualStyleBackColor = true;
			this.chkSSL.AutoSize = true;
			this.chkSSL.Location = new global::System.Drawing.Point(162, 171);
			this.chkSSL.Name = "chkSSL";
			this.chkSSL.Size = new global::System.Drawing.Size(108, 24);
			this.chkSSL.TabIndex = 12;
			this.chkSSL.Text = "Use SSL?";
			this.chkSSL.UseVisualStyleBackColor = true;
			this.GroupBox1.Controls.Add(this.Label8);
			this.GroupBox1.Controls.Add(this.txtEmailTo);
			this.GroupBox1.Controls.Add(this.Button2);
			this.GroupBox1.Controls.Add(this.Label7);
			this.GroupBox1.Controls.Add(this.txtBody);
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Controls.Add(this.txtSubject);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 238);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new global::System.Drawing.Size(1115, 312);
			this.GroupBox1.TabIndex = 11;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Test";
			this.Button2.Location = new global::System.Drawing.Point(162, 220);
			this.Button2.Name = "Button2";
			this.Button2.Size = new global::System.Drawing.Size(185, 31);
			this.Button2.TabIndex = 8;
			this.Button2.Text = "Send Email";
			this.Button2.UseVisualStyleBackColor = true;
			this.Label7.AutoSize = true;
			this.Label7.Location = new global::System.Drawing.Point(104, 106);
			this.Label7.Name = "Label7";
			this.Label7.Size = new global::System.Drawing.Size(49, 20);
			this.Label7.TabIndex = 6;
			this.Label7.Text = "Body:";
			this.txtBody.Location = new global::System.Drawing.Point(162, 103);
			this.txtBody.Multiline = true;
			this.txtBody.Name = "txtBody";
			this.txtBody.Size = new global::System.Drawing.Size(519, 111);
			this.txtBody.TabIndex = 5;
			this.Label4.AutoSize = true;
			this.Label4.Location = new global::System.Drawing.Point(86, 74);
			this.Label4.Name = "Label4";
			this.Label4.Size = new global::System.Drawing.Size(67, 20);
			this.Label4.TabIndex = 4;
			this.Label4.Text = "Subject:";
			this.txtSubject.Location = new global::System.Drawing.Point(162, 71);
			this.txtSubject.Name = "txtSubject";
			this.txtSubject.Size = new global::System.Drawing.Size(519, 26);
			this.txtSubject.TabIndex = 0;
			this.txtPassword.Location = new global::System.Drawing.Point(675, 139);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new global::System.Drawing.Size(295, 26);
			this.txtPassword.TabIndex = 10;
			this.Label6.AutoSize = true;
			this.Label6.Location = new global::System.Drawing.Point(576, 139);
			this.Label6.Name = "Label6";
			this.Label6.Size = new global::System.Drawing.Size(82, 20);
			this.Label6.TabIndex = 9;
			this.Label6.Text = "Password:";
			this.txtUsername.Location = new global::System.Drawing.Point(675, 107);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new global::System.Drawing.Size(295, 26);
			this.txtUsername.TabIndex = 8;
			this.Label5.AutoSize = true;
			this.Label5.Location = new global::System.Drawing.Point(576, 107);
			this.Label5.Name = "Label5";
			this.Label5.Size = new global::System.Drawing.Size(87, 20);
			this.Label5.TabIndex = 7;
			this.Label5.Text = "Username:";
			this.txtEmailHost.Location = new global::System.Drawing.Point(162, 139);
			this.txtEmailHost.Name = "txtEmailHost";
			this.txtEmailHost.Size = new global::System.Drawing.Size(295, 26);
			this.txtEmailHost.TabIndex = 4;
			this.Label3.AutoSize = true;
			this.Label3.Location = new global::System.Drawing.Point(63, 139);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(90, 20);
			this.Label3.TabIndex = 3;
			this.Label3.Text = "Email Host:";
			this.txtEmailFrom.Location = new global::System.Drawing.Point(162, 107);
			this.txtEmailFrom.Name = "txtEmailFrom";
			this.txtEmailFrom.Size = new global::System.Drawing.Size(295, 26);
			this.txtEmailFrom.TabIndex = 2;
			this.Label2.AutoSize = true;
			this.Label2.Location = new global::System.Drawing.Point(63, 107);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(93, 20);
			this.Label2.TabIndex = 1;
			this.Label2.Text = "Email From:";
			this.Label8.AutoSize = true;
			this.Label8.Location = new global::System.Drawing.Point(86, 42);
			this.Label8.Name = "Label8";
			this.Label8.Size = new global::System.Drawing.Size(70, 20);
			this.Label8.TabIndex = 10;
			this.Label8.Text = "Email to:";
			this.txtEmailTo.Location = new global::System.Drawing.Point(162, 39);
			this.txtEmailTo.Name = "txtEmailTo";
			this.txtEmailTo.Size = new global::System.Drawing.Size(519, 26);
			this.txtEmailTo.TabIndex = 9;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.Controls.Add(this.Panel1);
			base.Name = "SetEmailSettings";
			base.Size = new global::System.Drawing.Size(1115, 550);
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04002457 RID: 9303
		private global::System.ComponentModel.IContainer components;
	}
}
