namespace PointOfSale
{
	// Token: 0x02000017 RID: 23
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Branches : global::System.Windows.Forms.Form
	{
		// Token: 0x06000427 RID: 1063 RVA: 0x00026C5C File Offset: 0x00024E5C
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

		// Token: 0x06000428 RID: 1064 RVA: 0x00026CAC File Offset: 0x00024EAC
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.dgvBranches = new global::System.Windows.Forms.DataGridView();
			this.lblheader = new global::System.Windows.Forms.Label();
			this.chkSelectAll = new global::System.Windows.Forms.CheckBox();
			this.GroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvBranches).BeginInit();
			base.SuspendLayout();
			this.GroupBox1.Controls.Add(this.chkSelectAll);
			this.GroupBox1.Controls.Add(this.lblheader);
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Padding = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GroupBox1.Size = new global::System.Drawing.Size(426, 114);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.Button1.BackColor = global::System.Drawing.Color.Lime;
			this.Button1.Location = new global::System.Drawing.Point(120, 69);
			this.Button1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(112, 35);
			this.Button1.TabIndex = 0;
			this.Button1.Text = "Select";
			this.Button1.UseVisualStyleBackColor = false;
			this.dgvBranches.AllowUserToAddRows = false;
			this.dgvBranches.AllowUserToDeleteRows = false;
			this.dgvBranches.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvBranches.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dgvBranches.Location = new global::System.Drawing.Point(0, 114);
			this.dgvBranches.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dgvBranches.Name = "dgvBranches";
			this.dgvBranches.Size = new global::System.Drawing.Size(426, 288);
			this.dgvBranches.TabIndex = 1;
			this.lblheader.AutoSize = true;
			this.lblheader.Location = new global::System.Drawing.Point(12, 33);
			this.lblheader.Name = "lblheader";
			this.lblheader.Size = new global::System.Drawing.Size(21, 20);
			this.lblheader.TabIndex = 1;
			this.lblheader.Text = "...";
			this.chkSelectAll.AutoSize = true;
			this.chkSelectAll.Location = new global::System.Drawing.Point(304, 75);
			this.chkSelectAll.Name = "chkSelectAll";
			this.chkSelectAll.Size = new global::System.Drawing.Size(101, 24);
			this.chkSelectAll.TabIndex = 2;
			this.chkSelectAll.Text = "Check All";
			this.chkSelectAll.UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(426, 402);
			base.Controls.Add(this.dgvBranches);
			base.Controls.Add(this.GroupBox1);
			base.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			base.Name = "Branches";
			this.Text = "Select Branches";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvBranches).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x040001EB RID: 491
		private global::System.ComponentModel.IContainer components;
	}
}
