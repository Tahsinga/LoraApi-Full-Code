namespace PointOfSale
{
	// Token: 0x0200020E RID: 526
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class ViewEditTips : global::System.Windows.Forms.UserControl
	{
		// Token: 0x06005E89 RID: 24201 RVA: 0x00363210 File Offset: 0x00361410
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

		// Token: 0x06005E8A RID: 24202 RVA: 0x00363260 File Offset: 0x00361460
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.dgvTips = new global::System.Windows.Forms.DataGridView();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.cboUsers = new global::System.Windows.Forms.ComboBox();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.DTStartDate = new global::System.Windows.Forms.DateTimePicker();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.DTEndDate = new global::System.Windows.Forms.DateTimePicker();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.Label5 = new global::System.Windows.Forms.Label();
			this.lblinfo = new global::System.Windows.Forms.Label();
			this.chkIncDeleted = new global::System.Windows.Forms.CheckBox();
			this.GroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvTips).BeginInit();
			base.SuspendLayout();
			this.GroupBox1.Controls.Add(this.chkIncDeleted);
			this.GroupBox1.Controls.Add(this.lblinfo);
			this.GroupBox1.Controls.Add(this.Label5);
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Controls.Add(this.DTEndDate);
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Controls.Add(this.DTStartDate);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.cboUsers);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new global::System.Drawing.Size(1017, 162);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.dgvTips.AllowUserToAddRows = false;
			this.dgvTips.AllowUserToDeleteRows = false;
			this.dgvTips.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvTips.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dgvTips.Location = new global::System.Drawing.Point(0, 162);
			this.dgvTips.Name = "dgvTips";
			this.dgvTips.Size = new global::System.Drawing.Size(1017, 292);
			this.dgvTips.TabIndex = 1;
			this.Label1.AutoSize = true;
			this.Label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label1.Location = new global::System.Drawing.Point(16, 16);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(100, 24);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Tips Given";
			this.Label2.AutoSize = true;
			this.Label2.Location = new global::System.Drawing.Point(17, 58);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(75, 13);
			this.Label2.TabIndex = 1;
			this.Label2.Text = "User given tip:";
			this.cboUsers.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboUsers.FormattingEnabled = true;
			this.cboUsers.Location = new global::System.Drawing.Point(98, 55);
			this.cboUsers.Name = "cboUsers";
			this.cboUsers.Size = new global::System.Drawing.Size(200, 21);
			this.cboUsers.TabIndex = 2;
			this.Label3.AutoSize = true;
			this.Label3.Location = new global::System.Drawing.Point(34, 85);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(58, 13);
			this.Label3.TabIndex = 3;
			this.Label3.Text = "Start Date:";
			this.DTStartDate.Location = new global::System.Drawing.Point(98, 82);
			this.DTStartDate.Name = "DTStartDate";
			this.DTStartDate.Size = new global::System.Drawing.Size(200, 20);
			this.DTStartDate.TabIndex = 4;
			this.Label4.AutoSize = true;
			this.Label4.Location = new global::System.Drawing.Point(337, 86);
			this.Label4.Name = "Label4";
			this.Label4.Size = new global::System.Drawing.Size(55, 13);
			this.Label4.TabIndex = 5;
			this.Label4.Text = "End Date:";
			this.DTEndDate.Location = new global::System.Drawing.Point(398, 82);
			this.DTEndDate.Name = "DTEndDate";
			this.DTEndDate.Size = new global::System.Drawing.Size(200, 20);
			this.DTEndDate.TabIndex = 6;
			this.Button1.Location = new global::System.Drawing.Point(98, 132);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(118, 23);
			this.Button1.TabIndex = 7;
			this.Button1.Text = "View";
			this.Button1.UseVisualStyleBackColor = true;
			this.Label5.AutoSize = true;
			this.Label5.BackColor = global::System.Drawing.Color.Red;
			this.Label5.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.Label5.Location = new global::System.Drawing.Point(1000, 16);
			this.Label5.Name = "Label5";
			this.Label5.Size = new global::System.Drawing.Size(14, 13);
			this.Label5.TabIndex = 8;
			this.Label5.Text = "X";
			this.lblinfo.AutoSize = true;
			this.lblinfo.Location = new global::System.Drawing.Point(222, 142);
			this.lblinfo.Name = "lblinfo";
			this.lblinfo.Size = new global::System.Drawing.Size(22, 13);
			this.lblinfo.TabIndex = 9;
			this.lblinfo.Text = ".....";
			this.chkIncDeleted.AutoSize = true;
			this.chkIncDeleted.Location = new global::System.Drawing.Point(98, 108);
			this.chkIncDeleted.Name = "chkIncDeleted";
			this.chkIncDeleted.Size = new global::System.Drawing.Size(171, 17);
			this.chkIncDeleted.TabIndex = 10;
			this.chkIncDeleted.Text = "Include Deleted Transactions?";
			this.chkIncDeleted.UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.Controls.Add(this.dgvTips);
			base.Controls.Add(this.GroupBox1);
			base.Name = "ViewEditTips";
			base.Size = new global::System.Drawing.Size(1017, 454);
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvTips).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x0400297D RID: 10621
		private global::System.ComponentModel.IContainer components;
	}
}
