namespace PointOfSale
{
	// Token: 0x0200000D RID: 13
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class ApprovalForm : global::System.Windows.Forms.Form
	{
		// Token: 0x06000260 RID: 608 RVA: 0x000151A0 File Offset: 0x000133A0
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

		// Token: 0x06000261 RID: 609 RVA: 0x000151F0 File Offset: 0x000133F0
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.Label3 = new global::System.Windows.Forms.Label();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.txtPassword = new global::System.Windows.Forms.TextBox();
			this.cboUsernames = new global::System.Windows.Forms.ComboBox();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.lblHeader = new global::System.Windows.Forms.Label();
			base.SuspendLayout();
			this.Label3.AutoSize = true;
			this.Label3.Location = new global::System.Drawing.Point(108, 156);
			this.Label3.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(82, 20);
			this.Label3.TabIndex = 5;
			this.Label3.Text = "Password:";
			this.Label2.AutoSize = true;
			this.Label2.Location = new global::System.Drawing.Point(26, 112);
			this.Label2.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(166, 20);
			this.Label2.TabIndex = 4;
			this.Label2.Text = "Supervisor Username:";
			this.txtPassword.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtPassword.Location = new global::System.Drawing.Point(198, 146);
			this.txtPassword.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new global::System.Drawing.Size(226, 35);
			this.txtPassword.TabIndex = 6;
			this.cboUsernames.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.cboUsernames.FormattingEnabled = true;
			this.cboUsernames.Location = new global::System.Drawing.Point(199, 103);
			this.cboUsernames.Name = "cboUsernames";
			this.cboUsernames.Size = new global::System.Drawing.Size(225, 37);
			this.cboUsernames.TabIndex = 7;
			this.Button1.BackColor = global::System.Drawing.Color.Lime;
			this.Button1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Button1.Location = new global::System.Drawing.Point(199, 189);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(225, 46);
			this.Button1.TabIndex = 8;
			this.Button1.Text = "APPROVE";
			this.Button1.UseVisualStyleBackColor = false;
			this.lblHeader.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.lblHeader.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblHeader.Location = new global::System.Drawing.Point(0, 0);
			this.lblHeader.Name = "lblHeader";
			this.lblHeader.Size = new global::System.Drawing.Size(493, 91);
			this.lblHeader.TabIndex = 9;
			this.lblHeader.Text = "...";
			this.lblHeader.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(493, 267);
			base.Controls.Add(this.lblHeader);
			base.Controls.Add(this.Button1);
			base.Controls.Add(this.cboUsernames);
			base.Controls.Add(this.txtPassword);
			base.Controls.Add(this.Label3);
			base.Controls.Add(this.Label2);
			base.Name = "ApprovalForm";
			this.Text = "Approval Form";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000107 RID: 263
		private global::System.ComponentModel.IContainer components;
	}
}
