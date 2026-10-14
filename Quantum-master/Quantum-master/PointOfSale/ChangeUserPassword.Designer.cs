namespace PointOfSale
{
	// Token: 0x02000021 RID: 33
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class ChangeUserPassword : global::System.Windows.Forms.Form
	{
		// Token: 0x06000695 RID: 1685 RVA: 0x00043634 File Offset: 0x00041834
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

		// Token: 0x06000696 RID: 1686 RVA: 0x00043684 File Offset: 0x00041884
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.Label5 = new global::System.Windows.Forms.Label();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.txtTeacherPwd2 = new global::System.Windows.Forms.TextBox();
			this.txtNewPwd = new global::System.Windows.Forms.TextBox();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.txtUsername = new global::System.Windows.Forms.ComboBox();
			base.SuspendLayout();
			this.Label5.AutoSize = true;
			this.Label5.Location = new global::System.Drawing.Point(101, 189);
			this.Label5.Name = "Label5";
			this.Label5.Size = new global::System.Drawing.Size(118, 13);
			this.Label5.TabIndex = 25;
			this.Label5.Text = "Re-type new password:";
			this.Label4.AutoSize = true;
			this.Label4.Location = new global::System.Drawing.Point(139, 163);
			this.Label4.Name = "Label4";
			this.Label4.Size = new global::System.Drawing.Size(80, 13);
			this.Label4.TabIndex = 24;
			this.Label4.Text = "New password:";
			this.Button1.Location = new global::System.Drawing.Point(225, 221);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(138, 27);
			this.Button1.TabIndex = 23;
			this.Button1.Text = "Accept Changes";
			this.Button1.UseVisualStyleBackColor = true;
			this.txtTeacherPwd2.Location = new global::System.Drawing.Point(225, 186);
			this.txtTeacherPwd2.Name = "txtTeacherPwd2";
			this.txtTeacherPwd2.PasswordChar = '*';
			this.txtTeacherPwd2.Size = new global::System.Drawing.Size(138, 20);
			this.txtTeacherPwd2.TabIndex = 22;
			this.txtNewPwd.Location = new global::System.Drawing.Point(225, 160);
			this.txtNewPwd.Name = "txtNewPwd";
			this.txtNewPwd.PasswordChar = '*';
			this.txtNewPwd.Size = new global::System.Drawing.Size(138, 20);
			this.txtNewPwd.TabIndex = 21;
			this.Label2.AutoSize = true;
			this.Label2.Location = new global::System.Drawing.Point(155, 137);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(58, 13);
			this.Label2.TabIndex = 19;
			this.Label2.Text = "Username:";
			this.Label1.AutoSize = true;
			this.Label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label1.Location = new global::System.Drawing.Point(101, 80);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(179, 24);
			this.Label1.TabIndex = 18;
			this.Label1.Text = "Change Password";
			this.txtUsername.FormattingEnabled = true;
			this.txtUsername.Location = new global::System.Drawing.Point(225, 134);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new global::System.Drawing.Size(138, 21);
			this.txtUsername.TabIndex = 26;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(524, 332);
			base.Controls.Add(this.txtUsername);
			base.Controls.Add(this.Label5);
			base.Controls.Add(this.Label4);
			base.Controls.Add(this.Button1);
			base.Controls.Add(this.txtTeacherPwd2);
			base.Controls.Add(this.txtNewPwd);
			base.Controls.Add(this.Label2);
			base.Controls.Add(this.Label1);
			base.Name = "ChangeUserPassword";
			this.Text = "ChangeUserPassword";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400030F RID: 783
		private global::System.ComponentModel.IContainer components;
	}
}
