namespace PointOfSale
{
	// Token: 0x020001BD RID: 445
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class SelectUserForm : global::System.Windows.Forms.Form
	{
		// Token: 0x0600504D RID: 20557 RVA: 0x002FEB78 File Offset: 0x002FCD78
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

		// Token: 0x0600504E RID: 20558 RVA: 0x002FEBC8 File Offset: 0x002FCDC8
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.Label1 = new global::System.Windows.Forms.Label();
			this.cboUsernames = new global::System.Windows.Forms.ComboBox();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.Button2 = new global::System.Windows.Forms.Button();
			base.SuspendLayout();
			this.Label1.AutoSize = true;
			this.Label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label1.Location = new global::System.Drawing.Point(181, 87);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(179, 29);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "SELECT USER";
			this.cboUsernames.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboUsernames.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.cboUsernames.FormattingEnabled = true;
			this.cboUsernames.Location = new global::System.Drawing.Point(109, 119);
			this.cboUsernames.Name = "cboUsernames";
			this.cboUsernames.Size = new global::System.Drawing.Size(362, 37);
			this.cboUsernames.TabIndex = 1;
			this.Button1.BackColor = global::System.Drawing.Color.Lime;
			this.Button1.Location = new global::System.Drawing.Point(109, 162);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(155, 48);
			this.Button1.TabIndex = 2;
			this.Button1.Text = "SELECT";
			this.Button1.UseVisualStyleBackColor = false;
			this.Button2.BackColor = global::System.Drawing.Color.FromArgb(255, 128, 128);
			this.Button2.Location = new global::System.Drawing.Point(316, 162);
			this.Button2.Name = "Button2";
			this.Button2.Size = new global::System.Drawing.Size(155, 48);
			this.Button2.TabIndex = 3;
			this.Button2.Text = "CANCEL";
			this.Button2.UseVisualStyleBackColor = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(565, 250);
			base.Controls.Add(this.Button2);
			base.Controls.Add(this.Button1);
			base.Controls.Add(this.cboUsernames);
			base.Controls.Add(this.Label1);
			base.Name = "SelectUserForm";
			this.Text = "SelectUserForm";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040023DD RID: 9181
		private global::System.ComponentModel.IContainer components;
	}
}
