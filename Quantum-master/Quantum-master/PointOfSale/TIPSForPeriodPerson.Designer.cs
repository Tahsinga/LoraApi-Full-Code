namespace PointOfSale
{
	// Token: 0x02000204 RID: 516
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class TIPSForPeriodPerson : global::System.Windows.Forms.UserControl
	{
		// Token: 0x06005C6E RID: 23662 RVA: 0x00351234 File Offset: 0x0034F434
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

		// Token: 0x06005C6F RID: 23663 RVA: 0x00351284 File Offset: 0x0034F484
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.cboUsers = new global::System.Windows.Forms.ComboBox();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.Label5 = new global::System.Windows.Forms.Label();
			this.cboBranch = new global::System.Windows.Forms.ComboBox();
			this.DTEnd = new global::System.Windows.Forms.DateTimePicker();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.DTStart = new global::System.Windows.Forms.DateTimePicker();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.dgvTips = new global::System.Windows.Forms.DataGridView();
			this.Button4 = new global::System.Windows.Forms.Button();
			this.SaveFileDialog1 = new global::System.Windows.Forms.SaveFileDialog();
			this.Label6 = new global::System.Windows.Forms.Label();
			this.lbltiptot = new global::System.Windows.Forms.Label();
			this.GroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvTips).BeginInit();
			base.SuspendLayout();
			this.GroupBox1.Controls.Add(this.lbltiptot);
			this.GroupBox1.Controls.Add(this.Label6);
			this.GroupBox1.Controls.Add(this.Button4);
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Controls.Add(this.cboUsers);
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Controls.Add(this.Label5);
			this.GroupBox1.Controls.Add(this.cboBranch);
			this.GroupBox1.Controls.Add(this.DTEnd);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.DTStart);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new global::System.Drawing.Size(1184, 203);
			this.GroupBox1.TabIndex = 1;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Select Period";
			this.Button1.BackColor = global::System.Drawing.Color.Lime;
			this.Button1.Location = new global::System.Drawing.Point(161, 139);
			this.Button1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(207, 35);
			this.Button1.TabIndex = 14;
			this.Button1.Text = "VIEW TIPS";
			this.Button1.UseVisualStyleBackColor = false;
			this.Label1.AutoSize = true;
			this.Label1.BackColor = global::System.Drawing.Color.Red;
			this.Label1.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.Label1.Location = new global::System.Drawing.Point(1132, 22);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(49, 20);
			this.Label1.TabIndex = 13;
			this.Label1.Text = "Close";
			this.cboUsers.FormattingEnabled = true;
			this.cboUsers.Location = new global::System.Drawing.Point(161, 101);
			this.cboUsers.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cboUsers.Name = "cboUsers";
			this.cboUsers.Size = new global::System.Drawing.Size(323, 28);
			this.cboUsers.TabIndex = 12;
			this.Label4.AutoSize = true;
			this.Label4.Location = new global::System.Drawing.Point(56, 105);
			this.Label4.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label4.Name = "Label4";
			this.Label4.Size = new global::System.Drawing.Size(96, 20);
			this.Label4.TabIndex = 11;
			this.Label4.Text = "Select User:";
			this.Label5.AutoSize = true;
			this.Label5.Location = new global::System.Drawing.Point(545, 101);
			this.Label5.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label5.Name = "Label5";
			this.Label5.Size = new global::System.Drawing.Size(64, 20);
			this.Label5.TabIndex = 10;
			this.Label5.Text = "Branch:";
			this.cboBranch.FormattingEnabled = true;
			this.cboBranch.Location = new global::System.Drawing.Point(620, 97);
			this.cboBranch.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cboBranch.Name = "cboBranch";
			this.cboBranch.Size = new global::System.Drawing.Size(323, 28);
			this.cboBranch.TabIndex = 9;
			this.DTEnd.Location = new global::System.Drawing.Point(620, 63);
			this.DTEnd.Name = "DTEnd";
			this.DTEnd.Size = new global::System.Drawing.Size(323, 26);
			this.DTEnd.TabIndex = 3;
			this.Label3.AutoSize = true;
			this.Label3.Location = new global::System.Drawing.Point(527, 66);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(81, 20);
			this.Label3.TabIndex = 2;
			this.Label3.Text = "End Date:";
			this.DTStart.Location = new global::System.Drawing.Point(161, 63);
			this.DTStart.Name = "DTStart";
			this.DTStart.Size = new global::System.Drawing.Size(323, 26);
			this.DTStart.TabIndex = 1;
			this.Label2.AutoSize = true;
			this.Label2.Location = new global::System.Drawing.Point(68, 66);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(87, 20);
			this.Label2.TabIndex = 0;
			this.Label2.Text = "Start Date:";
			this.dgvTips.AllowUserToAddRows = false;
			this.dgvTips.AllowUserToDeleteRows = false;
			this.dgvTips.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvTips.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dgvTips.Location = new global::System.Drawing.Point(0, 203);
			this.dgvTips.Name = "dgvTips";
			this.dgvTips.ReadOnly = true;
			this.dgvTips.RowTemplate.Height = 28;
			this.dgvTips.Size = new global::System.Drawing.Size(1184, 292);
			this.dgvTips.TabIndex = 2;
			this.Button4.BackColor = global::System.Drawing.Color.FromArgb(255, 128, 0);
			this.Button4.Location = new global::System.Drawing.Point(753, 135);
			this.Button4.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Button4.Name = "Button4";
			this.Button4.Size = new global::System.Drawing.Size(190, 35);
			this.Button4.TabIndex = 15;
			this.Button4.Text = "Export to Excel";
			this.Button4.UseVisualStyleBackColor = false;
			this.Label6.AutoSize = true;
			this.Label6.Location = new global::System.Drawing.Point(157, 179);
			this.Label6.Name = "Label6";
			this.Label6.Size = new global::System.Drawing.Size(87, 20);
			this.Label6.TabIndex = 16;
			this.Label6.Text = "TIPS Total:";
			this.lbltiptot.AutoSize = true;
			this.lbltiptot.Location = new global::System.Drawing.Point(250, 179);
			this.lbltiptot.Name = "lbltiptot";
			this.lbltiptot.Size = new global::System.Drawing.Size(18, 20);
			this.lbltiptot.TabIndex = 17;
			this.lbltiptot.Text = "0";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.Controls.Add(this.dgvTips);
			base.Controls.Add(this.GroupBox1);
			base.Name = "TIPSForPeriodPerson";
			base.Size = new global::System.Drawing.Size(1184, 495);
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvTips).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x0400286D RID: 10349
		private global::System.ComponentModel.IContainer components;
	}
}
