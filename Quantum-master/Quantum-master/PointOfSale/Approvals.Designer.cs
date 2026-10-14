namespace PointOfSale
{
	// Token: 0x0200000E RID: 14
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Approvals : global::System.Windows.Forms.UserControl
	{
		// Token: 0x06000273 RID: 627 RVA: 0x00015B34 File Offset: 0x00013D34
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

		// Token: 0x06000274 RID: 628 RVA: 0x00015B84 File Offset: 0x00013D84
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.Button2 = new global::System.Windows.Forms.Button();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.dgvApprovals = new global::System.Windows.Forms.DataGridView();
			this.lblinfor = new global::System.Windows.Forms.Label();
			this.dgvSummary = new global::System.Windows.Forms.DataGridView();
			this.Label6 = new global::System.Windows.Forms.Label();
			this.cboBranch = new global::System.Windows.Forms.ComboBox();
			this.GroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvApprovals).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.dgvSummary).BeginInit();
			base.SuspendLayout();
			this.GroupBox1.Controls.Add(this.Label6);
			this.GroupBox1.Controls.Add(this.cboBranch);
			this.GroupBox1.Controls.Add(this.dgvSummary);
			this.GroupBox1.Controls.Add(this.lblinfor);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Controls.Add(this.Button2);
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new global::System.Drawing.Size(820, 121);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Price Change Approvals";
			this.Label2.AutoSize = true;
			this.Label2.BackColor = global::System.Drawing.Color.Red;
			this.Label2.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.Label2.Location = new global::System.Drawing.Point(784, 16);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(33, 13);
			this.Label2.TabIndex = 3;
			this.Label2.Text = "Close";
			this.Label1.AutoSize = true;
			this.Label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label1.Location = new global::System.Drawing.Point(360, 16);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(259, 24);
			this.Label1.TabIndex = 2;
			this.Label1.Text = "APPROVE PRICE CHANGES";
			this.Button2.BackColor = global::System.Drawing.Color.Red;
			this.Button2.Location = new global::System.Drawing.Point(627, 82);
			this.Button2.Name = "Button2";
			this.Button2.Size = new global::System.Drawing.Size(179, 23);
			this.Button2.TabIndex = 1;
			this.Button2.Text = "Deny Selected Lines";
			this.Button2.UseVisualStyleBackColor = false;
			this.Button1.BackColor = global::System.Drawing.Color.Lime;
			this.Button1.Location = new global::System.Drawing.Point(444, 82);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(172, 23);
			this.Button1.TabIndex = 0;
			this.Button1.Text = "Approve Selected Lines";
			this.Button1.UseVisualStyleBackColor = false;
			this.dgvApprovals.AllowUserToAddRows = false;
			this.dgvApprovals.AllowUserToDeleteRows = false;
			this.dgvApprovals.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvApprovals.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dgvApprovals.Location = new global::System.Drawing.Point(0, 121);
			this.dgvApprovals.Name = "dgvApprovals";
			this.dgvApprovals.Size = new global::System.Drawing.Size(820, 260);
			this.dgvApprovals.TabIndex = 1;
			this.lblinfor.AutoSize = true;
			this.lblinfor.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.lblinfor.ForeColor = global::System.Drawing.Color.FromArgb(0, 0, 192);
			this.lblinfor.Location = new global::System.Drawing.Point(3, 105);
			this.lblinfor.Name = "lblinfor";
			this.lblinfor.Size = new global::System.Drawing.Size(63, 13);
			this.lblinfor.TabIndex = 4;
			this.lblinfor.Text = "VIEWING...";
			this.dgvSummary.AllowUserToAddRows = false;
			this.dgvSummary.AllowUserToDeleteRows = false;
			this.dgvSummary.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSummary.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.dgvSummary.Location = new global::System.Drawing.Point(3, 16);
			this.dgvSummary.Name = "dgvSummary";
			this.dgvSummary.Size = new global::System.Drawing.Size(351, 89);
			this.dgvSummary.TabIndex = 5;
			this.Label6.AutoSize = true;
			this.Label6.Location = new global::System.Drawing.Point(361, 58);
			this.Label6.Name = "Label6";
			this.Label6.Size = new global::System.Drawing.Size(77, 13);
			this.Label6.TabIndex = 44;
			this.Label6.Text = "Select Branch:";
			this.cboBranch.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboBranch.FormattingEnabled = true;
			this.cboBranch.Location = new global::System.Drawing.Point(444, 55);
			this.cboBranch.Name = "cboBranch";
			this.cboBranch.Size = new global::System.Drawing.Size(172, 21);
			this.cboBranch.TabIndex = 43;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.Controls.Add(this.dgvApprovals);
			base.Controls.Add(this.GroupBox1);
			base.Name = "Approvals";
			base.Size = new global::System.Drawing.Size(820, 381);
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvApprovals).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.dgvSummary).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000110 RID: 272
		private global::System.ComponentModel.IContainer components;
	}
}
