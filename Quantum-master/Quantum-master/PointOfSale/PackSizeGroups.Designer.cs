namespace PointOfSale
{
	// Token: 0x02000086 RID: 134
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class PackSizeGroups : global::System.Windows.Forms.UserControl
	{
		// Token: 0x06001EC6 RID: 7878 RVA: 0x001128F0 File Offset: 0x00110AF0
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

		// Token: 0x06001EC7 RID: 7879 RVA: 0x00112940 File Offset: 0x00110B40
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.txtPSGroupName = new global::System.Windows.Forms.TextBox();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.GroupBox2 = new global::System.Windows.Forms.GroupBox();
			this.dgvPSGroups = new global::System.Windows.Forms.DataGridView();
			this.GroupBox3 = new global::System.Windows.Forms.GroupBox();
			this.Button2 = new global::System.Windows.Forms.Button();
			this.cboPackSizes = new global::System.Windows.Forms.ComboBox();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.lblpsgrpID = new global::System.Windows.Forms.Label();
			this.lblPSgroupname = new global::System.Windows.Forms.Label();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.dgvPSGroupDetails = new global::System.Windows.Forms.DataGridView();
			this.GroupBox1.SuspendLayout();
			this.GroupBox2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvPSGroups).BeginInit();
			this.GroupBox3.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvPSGroupDetails).BeginInit();
			base.SuspendLayout();
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Controls.Add(this.txtPSGroupName);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new global::System.Drawing.Size(1231, 113);
			this.GroupBox1.TabIndex = 1;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Create Pack Size Group";
			this.Button1.Location = new global::System.Drawing.Point(384, 48);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(105, 31);
			this.Button1.TabIndex = 4;
			this.Button1.Text = "SAVE";
			this.Button1.UseVisualStyleBackColor = true;
			this.txtPSGroupName.Location = new global::System.Drawing.Point(278, 50);
			this.txtPSGroupName.MaxLength = 50;
			this.txtPSGroupName.Name = "txtPSGroupName";
			this.txtPSGroupName.Size = new global::System.Drawing.Size(100, 26);
			this.txtPSGroupName.TabIndex = 3;
			this.Label2.AutoSize = true;
			this.Label2.Location = new global::System.Drawing.Point(94, 52);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(178, 20);
			this.Label2.TabIndex = 2;
			this.Label2.Text = "Pack Size Group Name:";
			this.Label1.AutoSize = true;
			this.Label1.BackColor = global::System.Drawing.Color.Red;
			this.Label1.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.Label1.Location = new global::System.Drawing.Point(1179, 22);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(49, 20);
			this.Label1.TabIndex = 1;
			this.Label1.Text = "Close";
			this.GroupBox2.Controls.Add(this.dgvPSGroups);
			this.GroupBox2.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox2.Location = new global::System.Drawing.Point(0, 113);
			this.GroupBox2.Name = "GroupBox2";
			this.GroupBox2.Size = new global::System.Drawing.Size(1231, 206);
			this.GroupBox2.TabIndex = 2;
			this.GroupBox2.TabStop = false;
			this.GroupBox2.Text = "View Pack Size Groups";
			this.dgvPSGroups.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvPSGroups.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dgvPSGroups.Location = new global::System.Drawing.Point(3, 22);
			this.dgvPSGroups.Name = "dgvPSGroups";
			this.dgvPSGroups.RowTemplate.Height = 28;
			this.dgvPSGroups.Size = new global::System.Drawing.Size(1225, 181);
			this.dgvPSGroups.TabIndex = 0;
			this.GroupBox3.Controls.Add(this.Button2);
			this.GroupBox3.Controls.Add(this.cboPackSizes);
			this.GroupBox3.Controls.Add(this.Label4);
			this.GroupBox3.Controls.Add(this.lblpsgrpID);
			this.GroupBox3.Controls.Add(this.lblPSgroupname);
			this.GroupBox3.Controls.Add(this.Label3);
			this.GroupBox3.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox3.Location = new global::System.Drawing.Point(0, 319);
			this.GroupBox3.Name = "GroupBox3";
			this.GroupBox3.Size = new global::System.Drawing.Size(1231, 158);
			this.GroupBox3.TabIndex = 3;
			this.GroupBox3.TabStop = false;
			this.GroupBox3.Text = "Add Pack Sizes to Pack Size Group";
			this.Button2.Location = new global::System.Drawing.Point(278, 76);
			this.Button2.Name = "Button2";
			this.Button2.Size = new global::System.Drawing.Size(241, 35);
			this.Button2.TabIndex = 5;
			this.Button2.Text = "Add Pack Size to Group";
			this.Button2.UseVisualStyleBackColor = true;
			this.cboPackSizes.FormattingEnabled = true;
			this.cboPackSizes.Location = new global::System.Drawing.Point(90, 80);
			this.cboPackSizes.Name = "cboPackSizes";
			this.cboPackSizes.Size = new global::System.Drawing.Size(181, 28);
			this.cboPackSizes.TabIndex = 4;
			this.Label4.AutoSize = true;
			this.Label4.Location = new global::System.Drawing.Point(460, 48);
			this.Label4.Name = "Label4";
			this.Label4.Size = new global::System.Drawing.Size(79, 20);
			this.Label4.TabIndex = 3;
			this.Label4.Text = "Group ID:";
			this.lblpsgrpID.AutoSize = true;
			this.lblpsgrpID.Location = new global::System.Drawing.Point(545, 49);
			this.lblpsgrpID.Name = "lblpsgrpID";
			this.lblpsgrpID.Size = new global::System.Drawing.Size(21, 20);
			this.lblpsgrpID.TabIndex = 2;
			this.lblpsgrpID.Text = "...";
			this.lblPSgroupname.AutoSize = true;
			this.lblPSgroupname.Location = new global::System.Drawing.Point(277, 48);
			this.lblPSgroupname.Name = "lblPSgroupname";
			this.lblPSgroupname.Size = new global::System.Drawing.Size(21, 20);
			this.lblPSgroupname.TabIndex = 1;
			this.lblPSgroupname.Text = "...";
			this.Label3.AutoSize = true;
			this.Label3.Location = new global::System.Drawing.Point(93, 48);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(178, 20);
			this.Label3.TabIndex = 0;
			this.Label3.Text = "Pack Size Group Name:";
			this.dgvPSGroupDetails.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvPSGroupDetails.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dgvPSGroupDetails.Location = new global::System.Drawing.Point(0, 477);
			this.dgvPSGroupDetails.Name = "dgvPSGroupDetails";
			this.dgvPSGroupDetails.RowTemplate.Height = 28;
			this.dgvPSGroupDetails.Size = new global::System.Drawing.Size(1231, 77);
			this.dgvPSGroupDetails.TabIndex = 4;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.Controls.Add(this.dgvPSGroupDetails);
			base.Controls.Add(this.GroupBox3);
			base.Controls.Add(this.GroupBox2);
			base.Controls.Add(this.GroupBox1);
			base.Name = "PackSizeGroups";
			base.Size = new global::System.Drawing.Size(1231, 554);
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.GroupBox2.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.dgvPSGroups).EndInit();
			this.GroupBox3.ResumeLayout(false);
			this.GroupBox3.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvPSGroupDetails).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000E9A RID: 3738
		private global::System.ComponentModel.IContainer components;
	}
}
