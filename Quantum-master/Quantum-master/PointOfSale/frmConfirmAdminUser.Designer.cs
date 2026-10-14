namespace PointOfSale
{
	// Token: 0x02000060 RID: 96
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class frmConfirmAdminUser : global::System.Windows.Forms.Form
	{
		// Token: 0x06001407 RID: 5127 RVA: 0x000BD5E0 File Offset: 0x000BB7E0
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

		// Token: 0x06001408 RID: 5128 RVA: 0x000BD630 File Offset: 0x000BB830
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.txtPwd = new global::System.Windows.Forms.TextBox();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.txtUsername = new global::System.Windows.Forms.TextBox();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.Label3 = new global::System.Windows.Forms.Label();
			base.SuspendLayout();
			this.txtPwd.Location = new global::System.Drawing.Point(86, 91);
			this.txtPwd.Name = "txtPwd";
			this.txtPwd.PasswordChar = '*';
			this.txtPwd.Size = new global::System.Drawing.Size(143, 20);
			this.txtPwd.TabIndex = 6;
			this.txtPwd.UseSystemPasswordChar = true;
			this.Label2.AutoSize = true;
			this.Label2.Location = new global::System.Drawing.Point(25, 94);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(53, 13);
			this.Label2.TabIndex = 7;
			this.Label2.Text = "Password";
			this.txtUsername.Location = new global::System.Drawing.Point(86, 65);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new global::System.Drawing.Size(143, 20);
			this.txtUsername.TabIndex = 5;
			this.Label1.AutoSize = true;
			this.Label1.Location = new global::System.Drawing.Point(25, 68);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(55, 13);
			this.Label1.TabIndex = 4;
			this.Label1.Text = "Username";
			this.Button1.BackColor = global::System.Drawing.Color.Lime;
			this.Button1.Location = new global::System.Drawing.Point(86, 117);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(143, 23);
			this.Button1.TabIndex = 8;
			this.Button1.Text = "ENABLE PRICE CHANGE";
			this.Button1.UseVisualStyleBackColor = false;
			this.Label3.AutoSize = true;
			this.Label3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label3.Location = new global::System.Drawing.Point(78, 20);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(151, 20);
			this.Label3.TabIndex = 9;
			this.Label3.Text = "Confirm Admin User";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(284, 163);
			base.Controls.Add(this.Label3);
			base.Controls.Add(this.Button1);
			base.Controls.Add(this.txtPwd);
			base.Controls.Add(this.Label2);
			base.Controls.Add(this.txtUsername);
			base.Controls.Add(this.Label1);
			base.Name = "frmConfirmAdminUser";
			this.Text = "CONFIRM ADMIN USER";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000A2A RID: 2602
		private global::System.ComponentModel.IContainer components;
	}
}
