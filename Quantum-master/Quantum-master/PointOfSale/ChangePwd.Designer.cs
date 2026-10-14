namespace PointOfSale
{
	// Token: 0x02000020 RID: 32
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class ChangePwd : global::System.Windows.Forms.Form
	{
		// Token: 0x0600067C RID: 1660 RVA: 0x00042CF8 File Offset: 0x00040EF8
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

		// Token: 0x0600067D RID: 1661 RVA: 0x00042D48 File Offset: 0x00040F48
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.Label5 = new global::System.Windows.Forms.Label();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.txtTeacherPwd2 = new global::System.Windows.Forms.TextBox();
			this.txtNewPwd = new global::System.Windows.Forms.TextBox();
			this.txtUsername = new global::System.Windows.Forms.TextBox();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.Label1 = new global::System.Windows.Forms.Label();
			base.SuspendLayout();
			this.Label5.AutoSize = true;
			this.Label5.Location = new global::System.Drawing.Point(62, 156);
			this.Label5.Name = "Label5";
			this.Label5.Size = new global::System.Drawing.Size(118, 13);
			this.Label5.TabIndex = 17;
			this.Label5.Text = "Re-type new password:";
			this.Label4.AutoSize = true;
			this.Label4.Location = new global::System.Drawing.Point(100, 130);
			this.Label4.Name = "Label4";
			this.Label4.Size = new global::System.Drawing.Size(80, 13);
			this.Label4.TabIndex = 16;
			this.Label4.Text = "New password:";
			this.Button1.Location = new global::System.Drawing.Point(186, 188);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(138, 27);
			this.Button1.TabIndex = 15;
			this.Button1.Text = "Accept Changes";
			this.Button1.UseVisualStyleBackColor = true;
			this.txtTeacherPwd2.Location = new global::System.Drawing.Point(186, 153);
			this.txtTeacherPwd2.Name = "txtTeacherPwd2";
			this.txtTeacherPwd2.PasswordChar = '*';
			this.txtTeacherPwd2.Size = new global::System.Drawing.Size(138, 20);
			this.txtTeacherPwd2.TabIndex = 14;
			this.txtNewPwd.Location = new global::System.Drawing.Point(186, 127);
			this.txtNewPwd.Name = "txtNewPwd";
			this.txtNewPwd.PasswordChar = '*';
			this.txtNewPwd.Size = new global::System.Drawing.Size(138, 20);
			this.txtNewPwd.TabIndex = 13;
			this.txtUsername.Enabled = false;
			this.txtUsername.Location = new global::System.Drawing.Point(186, 101);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new global::System.Drawing.Size(138, 20);
			this.txtUsername.TabIndex = 12;
			this.Label2.AutoSize = true;
			this.Label2.Location = new global::System.Drawing.Point(116, 104);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(58, 13);
			this.Label2.TabIndex = 11;
			this.Label2.Text = "Username:";
			this.Label1.AutoSize = true;
			this.Label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label1.Location = new global::System.Drawing.Point(62, 47);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(179, 24);
			this.Label1.TabIndex = 10;
			this.Label1.Text = "Change Password";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(396, 251);
			base.Controls.Add(this.Label5);
			base.Controls.Add(this.Label4);
			base.Controls.Add(this.Button1);
			base.Controls.Add(this.txtTeacherPwd2);
			base.Controls.Add(this.txtNewPwd);
			base.Controls.Add(this.txtUsername);
			base.Controls.Add(this.Label2);
			base.Controls.Add(this.Label1);
			base.Name = "ChangePwd";
			this.Text = "Change password";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000305 RID: 773
		private global::System.ComponentModel.IContainer components;
	}
}
