namespace PointOfSale
{
	// Token: 0x02000007 RID: 7
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class AC_UserPermissions : global::System.Windows.Forms.Form
	{
		// Token: 0x0600011F RID: 287 RVA: 0x0000B22C File Offset: 0x0000942C
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

		// Token: 0x06000120 RID: 288 RVA: 0x0000B27C File Offset: 0x0000947C
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.Panel3 = new global::System.Windows.Forms.Panel();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.Panel2 = new global::System.Windows.Forms.Panel();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.Panel1 = new global::System.Windows.Forms.Panel();
			this.GroupBox3 = new global::System.Windows.Forms.GroupBox();
			this.Label5 = new global::System.Windows.Forms.Label();
			this.Button5 = new global::System.Windows.Forms.Button();
			this.Button4 = new global::System.Windows.Forms.Button();
			this.Button3 = new global::System.Windows.Forms.Button();
			this.Button2 = new global::System.Windows.Forms.Button();
			this.dgvAssignedRoles = new global::System.Windows.Forms.DataGridView();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.GroupBox2 = new global::System.Windows.Forms.GroupBox();
			this.cboRoles = new global::System.Windows.Forms.ComboBox();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.cboUsers = new global::System.Windows.Forms.ComboBox();
			this.GroupBox3.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvAssignedRoles).BeginInit();
			this.GroupBox2.SuspendLayout();
			this.GroupBox1.SuspendLayout();
			base.SuspendLayout();
			this.Panel3.BackColor = global::System.Drawing.Color.Red;
			this.Panel3.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel3.Location = new global::System.Drawing.Point(14, 109);
			this.Panel3.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Panel3.Name = "Panel3";
			this.Panel3.Size = new global::System.Drawing.Size(46, 31);
			this.Panel3.TabIndex = 12;
			this.Label4.AutoSize = true;
			this.Label4.Location = new global::System.Drawing.Point(69, 75);
			this.Label4.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label4.Name = "Label4";
			this.Label4.Size = new global::System.Drawing.Size(149, 20);
			this.Label4.TabIndex = 9;
			this.Label4.Text = "Permission Granted";
			this.Panel2.BackColor = global::System.Drawing.Color.Lime;
			this.Panel2.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel2.Location = new global::System.Drawing.Point(14, 68);
			this.Panel2.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new global::System.Drawing.Size(46, 31);
			this.Panel2.TabIndex = 10;
			this.Label3.AutoSize = true;
			this.Label3.Location = new global::System.Drawing.Point(69, 38);
			this.Label3.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(153, 20);
			this.Label3.TabIndex = 8;
			this.Label3.Text = "Menu Item IGNORE";
			this.Panel1.BackColor = global::System.Drawing.Color.Silver;
			this.Panel1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel1.Location = new global::System.Drawing.Point(14, 31);
			this.Panel1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new global::System.Drawing.Size(46, 31);
			this.Panel1.TabIndex = 8;
			this.GroupBox3.BackColor = global::System.Drawing.Color.White;
			this.GroupBox3.Controls.Add(this.Label5);
			this.GroupBox3.Controls.Add(this.Panel3);
			this.GroupBox3.Controls.Add(this.Label4);
			this.GroupBox3.Controls.Add(this.Panel2);
			this.GroupBox3.Controls.Add(this.Label3);
			this.GroupBox3.Controls.Add(this.Panel1);
			this.GroupBox3.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.GroupBox3.Location = new global::System.Drawing.Point(4, 24);
			this.GroupBox3.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GroupBox3.Name = "GroupBox3";
			this.GroupBox3.Padding = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GroupBox3.Size = new global::System.Drawing.Size(266, 165);
			this.GroupBox3.TabIndex = 7;
			this.GroupBox3.TabStop = false;
			this.GroupBox3.Text = "Key";
			this.Label5.AutoSize = true;
			this.Label5.Location = new global::System.Drawing.Point(69, 117);
			this.Label5.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label5.Name = "Label5";
			this.Label5.Size = new global::System.Drawing.Size(141, 20);
			this.Label5.TabIndex = 11;
			this.Label5.Text = "Permission Denied";
			this.Button5.BackColor = global::System.Drawing.Color.Lime;
			this.Button5.Location = new global::System.Drawing.Point(292, 134);
			this.Button5.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Button5.Name = "Button5";
			this.Button5.Size = new global::System.Drawing.Size(234, 51);
			this.Button5.TabIndex = 6;
			this.Button5.Text = "SAVE PERMISSIONS SET";
			this.Button5.UseVisualStyleBackColor = false;
			this.Button4.BackColor = global::System.Drawing.Color.Aqua;
			this.Button4.Location = new global::System.Drawing.Point(414, 92);
			this.Button4.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Button4.Name = "Button4";
			this.Button4.Size = new global::System.Drawing.Size(112, 35);
			this.Button4.TabIndex = 5;
			this.Button4.Text = "Deselect All";
			this.Button4.UseVisualStyleBackColor = false;
			this.Button3.BackColor = global::System.Drawing.Color.Aqua;
			this.Button3.Location = new global::System.Drawing.Point(292, 92);
			this.Button3.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Button3.Name = "Button3";
			this.Button3.Size = new global::System.Drawing.Size(112, 35);
			this.Button3.TabIndex = 4;
			this.Button3.Text = "Select All";
			this.Button3.UseVisualStyleBackColor = false;
			this.Button2.BackColor = global::System.Drawing.Color.Lime;
			this.Button2.Location = new global::System.Drawing.Point(536, 49);
			this.Button2.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Button2.Name = "Button2";
			this.Button2.Size = new global::System.Drawing.Size(206, 35);
			this.Button2.TabIndex = 3;
			this.Button2.Text = "Assign Role Permission";
			this.Button2.UseVisualStyleBackColor = false;
			this.dgvAssignedRoles.AllowUserToAddRows = false;
			this.dgvAssignedRoles.AllowUserToDeleteRows = false;
			this.dgvAssignedRoles.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAssignedRoles.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dgvAssignedRoles.Location = new global::System.Drawing.Point(0, 320);
			this.dgvAssignedRoles.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dgvAssignedRoles.Name = "dgvAssignedRoles";
			this.dgvAssignedRoles.ReadOnly = true;
			this.dgvAssignedRoles.Size = new global::System.Drawing.Size(759, 448);
			this.dgvAssignedRoles.TabIndex = 5;
			this.Label2.AutoSize = true;
			this.Label2.Location = new global::System.Drawing.Point(288, 26);
			this.Label2.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(140, 20);
			this.Label2.TabIndex = 1;
			this.Label2.Text = "Select Role below:";
			this.GroupBox2.Controls.Add(this.GroupBox3);
			this.GroupBox2.Controls.Add(this.Button5);
			this.GroupBox2.Controls.Add(this.Button4);
			this.GroupBox2.Controls.Add(this.Button3);
			this.GroupBox2.Controls.Add(this.Button2);
			this.GroupBox2.Controls.Add(this.Label2);
			this.GroupBox2.Controls.Add(this.cboRoles);
			this.GroupBox2.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox2.Location = new global::System.Drawing.Point(0, 126);
			this.GroupBox2.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GroupBox2.Name = "GroupBox2";
			this.GroupBox2.Padding = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GroupBox2.Size = new global::System.Drawing.Size(759, 194);
			this.GroupBox2.TabIndex = 4;
			this.GroupBox2.TabStop = false;
			this.GroupBox2.Text = "Load Role Settings";
			this.cboRoles.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboRoles.FormattingEnabled = true;
			this.cboRoles.Location = new global::System.Drawing.Point(292, 51);
			this.cboRoles.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cboRoles.Name = "cboRoles";
			this.cboRoles.Size = new global::System.Drawing.Size(232, 28);
			this.cboRoles.TabIndex = 0;
			this.Label1.AutoSize = true;
			this.Label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label1.Location = new global::System.Drawing.Point(128, 54);
			this.Label1.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(156, 29);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Select User:";
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Controls.Add(this.cboUsers);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Padding = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GroupBox1.Size = new global::System.Drawing.Size(759, 126);
			this.GroupBox1.TabIndex = 3;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Create New Role";
			this.Button1.BackColor = global::System.Drawing.Color.Lime;
			this.Button1.Location = new global::System.Drawing.Point(536, 46);
			this.Button1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(206, 35);
			this.Button1.TabIndex = 4;
			this.Button1.Text = "Load Permissions";
			this.Button1.UseVisualStyleBackColor = false;
			this.Button1.Visible = false;
			this.cboUsers.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboUsers.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.cboUsers.FormattingEnabled = true;
			this.cboUsers.Location = new global::System.Drawing.Point(292, 48);
			this.cboUsers.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cboUsers.Name = "cboUsers";
			this.cboUsers.Size = new global::System.Drawing.Size(232, 37);
			this.cboUsers.TabIndex = 3;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(759, 768);
			base.Controls.Add(this.dgvAssignedRoles);
			base.Controls.Add(this.GroupBox2);
			base.Controls.Add(this.GroupBox1);
			base.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			base.Name = "AC_UserPermissions";
			this.Text = "Set User Permissions";
			this.GroupBox3.ResumeLayout(false);
			this.GroupBox3.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvAssignedRoles).EndInit();
			this.GroupBox2.ResumeLayout(false);
			this.GroupBox2.PerformLayout();
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04000079 RID: 121
		private global::System.ComponentModel.IContainer components;
	}
}
