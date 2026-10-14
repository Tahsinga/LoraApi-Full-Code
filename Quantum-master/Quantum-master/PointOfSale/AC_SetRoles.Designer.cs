namespace PointOfSale
{
	// Token: 0x02000006 RID: 6
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class AC_SetRoles : global::System.Windows.Forms.Form
	{
		// Token: 0x060000E7 RID: 231 RVA: 0x0000966C File Offset: 0x0000786C
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

		// Token: 0x060000E8 RID: 232 RVA: 0x000096BC File Offset: 0x000078BC
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.txtRoleName = new global::System.Windows.Forms.TextBox();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.GroupBox2 = new global::System.Windows.Forms.GroupBox();
			this.GroupBox3 = new global::System.Windows.Forms.GroupBox();
			this.Label5 = new global::System.Windows.Forms.Label();
			this.Panel3 = new global::System.Windows.Forms.Panel();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.Panel2 = new global::System.Windows.Forms.Panel();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.Panel1 = new global::System.Windows.Forms.Panel();
			this.Button5 = new global::System.Windows.Forms.Button();
			this.Button4 = new global::System.Windows.Forms.Button();
			this.Button3 = new global::System.Windows.Forms.Button();
			this.Button2 = new global::System.Windows.Forms.Button();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.cboRoles = new global::System.Windows.Forms.ComboBox();
			this.dgvAssignedRoles = new global::System.Windows.Forms.DataGridView();
			this.GroupBox1.SuspendLayout();
			this.GroupBox2.SuspendLayout();
			this.GroupBox3.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvAssignedRoles).BeginInit();
			base.SuspendLayout();
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Controls.Add(this.txtRoleName);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new global::System.Drawing.Size(525, 82);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Create New Role";
			this.Button1.BackColor = global::System.Drawing.Color.Lime;
			this.Button1.Location = new global::System.Drawing.Point(400, 32);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(99, 23);
			this.Button1.TabIndex = 2;
			this.Button1.Text = "Save Role";
			this.Button1.UseVisualStyleBackColor = false;
			this.txtRoleName.Location = new global::System.Drawing.Point(259, 34);
			this.txtRoleName.Name = "txtRoleName";
			this.txtRoleName.Size = new global::System.Drawing.Size(135, 20);
			this.txtRoleName.TabIndex = 1;
			this.Label1.AutoSize = true;
			this.Label1.Location = new global::System.Drawing.Point(134, 37);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(119, 13);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Enter  New Role Name:";
			this.GroupBox2.Controls.Add(this.GroupBox3);
			this.GroupBox2.Controls.Add(this.Button5);
			this.GroupBox2.Controls.Add(this.Button4);
			this.GroupBox2.Controls.Add(this.Button3);
			this.GroupBox2.Controls.Add(this.Button2);
			this.GroupBox2.Controls.Add(this.Label2);
			this.GroupBox2.Controls.Add(this.cboRoles);
			this.GroupBox2.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox2.Location = new global::System.Drawing.Point(0, 82);
			this.GroupBox2.Name = "GroupBox2";
			this.GroupBox2.Size = new global::System.Drawing.Size(525, 126);
			this.GroupBox2.TabIndex = 1;
			this.GroupBox2.TabStop = false;
			this.GroupBox2.Text = "Load Role Settings";
			this.GroupBox3.BackColor = global::System.Drawing.Color.White;
			this.GroupBox3.Controls.Add(this.Label5);
			this.GroupBox3.Controls.Add(this.Panel3);
			this.GroupBox3.Controls.Add(this.Label4);
			this.GroupBox3.Controls.Add(this.Panel2);
			this.GroupBox3.Controls.Add(this.Label3);
			this.GroupBox3.Controls.Add(this.Panel1);
			this.GroupBox3.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.GroupBox3.Location = new global::System.Drawing.Point(3, 16);
			this.GroupBox3.Name = "GroupBox3";
			this.GroupBox3.Size = new global::System.Drawing.Size(177, 107);
			this.GroupBox3.TabIndex = 7;
			this.GroupBox3.TabStop = false;
			this.GroupBox3.Text = "Key";
			this.Label5.AutoSize = true;
			this.Label5.Location = new global::System.Drawing.Point(46, 76);
			this.Label5.Name = "Label5";
			this.Label5.Size = new global::System.Drawing.Size(94, 13);
			this.Label5.TabIndex = 11;
			this.Label5.Text = "Permission Denied";
			this.Panel3.BackColor = global::System.Drawing.Color.Red;
			this.Panel3.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel3.Location = new global::System.Drawing.Point(9, 71);
			this.Panel3.Name = "Panel3";
			this.Panel3.Size = new global::System.Drawing.Size(31, 21);
			this.Panel3.TabIndex = 12;
			this.Label4.AutoSize = true;
			this.Label4.Location = new global::System.Drawing.Point(46, 49);
			this.Label4.Name = "Label4";
			this.Label4.Size = new global::System.Drawing.Size(98, 13);
			this.Label4.TabIndex = 9;
			this.Label4.Text = "Permission Granted";
			this.Panel2.BackColor = global::System.Drawing.Color.Lime;
			this.Panel2.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel2.Location = new global::System.Drawing.Point(9, 44);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new global::System.Drawing.Size(31, 21);
			this.Panel2.TabIndex = 10;
			this.Label3.AutoSize = true;
			this.Label3.Location = new global::System.Drawing.Point(46, 25);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(102, 13);
			this.Label3.TabIndex = 8;
			this.Label3.Text = "Menu Item IGNORE";
			this.Panel1.BackColor = global::System.Drawing.Color.Silver;
			this.Panel1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel1.Location = new global::System.Drawing.Point(9, 20);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new global::System.Drawing.Size(31, 21);
			this.Panel1.TabIndex = 8;
			this.Button5.BackColor = global::System.Drawing.Color.Lime;
			this.Button5.Location = new global::System.Drawing.Point(248, 97);
			this.Button5.Name = "Button5";
			this.Button5.Size = new global::System.Drawing.Size(156, 23);
			this.Button5.TabIndex = 6;
			this.Button5.Text = "SAVE ROLE";
			this.Button5.UseVisualStyleBackColor = false;
			this.Button4.BackColor = global::System.Drawing.Color.Aqua;
			this.Button4.Location = new global::System.Drawing.Point(329, 65);
			this.Button4.Name = "Button4";
			this.Button4.Size = new global::System.Drawing.Size(75, 23);
			this.Button4.TabIndex = 5;
			this.Button4.Text = "Deselect All";
			this.Button4.UseVisualStyleBackColor = false;
			this.Button3.BackColor = global::System.Drawing.Color.Aqua;
			this.Button3.Location = new global::System.Drawing.Point(248, 65);
			this.Button3.Name = "Button3";
			this.Button3.Size = new global::System.Drawing.Size(75, 23);
			this.Button3.TabIndex = 4;
			this.Button3.Text = "Select All";
			this.Button3.UseVisualStyleBackColor = false;
			this.Button2.BackColor = global::System.Drawing.Color.Lime;
			this.Button2.Location = new global::System.Drawing.Point(398, 31);
			this.Button2.Name = "Button2";
			this.Button2.Size = new global::System.Drawing.Size(99, 23);
			this.Button2.TabIndex = 3;
			this.Button2.Text = "Load";
			this.Button2.UseVisualStyleBackColor = false;
			this.Label2.AutoSize = true;
			this.Label2.Location = new global::System.Drawing.Point(186, 36);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(65, 13);
			this.Label2.TabIndex = 1;
			this.Label2.Text = "Select Role:";
			this.cboRoles.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboRoles.FormattingEnabled = true;
			this.cboRoles.Location = new global::System.Drawing.Point(257, 33);
			this.cboRoles.Name = "cboRoles";
			this.cboRoles.Size = new global::System.Drawing.Size(135, 21);
			this.cboRoles.TabIndex = 0;
			this.dgvAssignedRoles.AllowUserToAddRows = false;
			this.dgvAssignedRoles.AllowUserToDeleteRows = false;
			this.dgvAssignedRoles.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAssignedRoles.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dgvAssignedRoles.Location = new global::System.Drawing.Point(0, 208);
			this.dgvAssignedRoles.Name = "dgvAssignedRoles";
			this.dgvAssignedRoles.ReadOnly = true;
			this.dgvAssignedRoles.Size = new global::System.Drawing.Size(525, 370);
			this.dgvAssignedRoles.TabIndex = 2;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(525, 578);
			base.Controls.Add(this.dgvAssignedRoles);
			base.Controls.Add(this.GroupBox2);
			base.Controls.Add(this.GroupBox1);
			base.Name = "AC_SetRoles";
			this.Text = "User Roles Management";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.GroupBox2.ResumeLayout(false);
			this.GroupBox2.PerformLayout();
			this.GroupBox3.ResumeLayout(false);
			this.GroupBox3.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvAssignedRoles).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000063 RID: 99
		private global::System.ComponentModel.IContainer components;
	}
}
