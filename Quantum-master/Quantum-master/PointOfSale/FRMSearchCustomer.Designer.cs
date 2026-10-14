namespace PointOfSale
{
	// Token: 0x02000061 RID: 97
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class FRMSearchCustomer : global::System.Windows.Forms.Form
	{
		// Token: 0x06001419 RID: 5145 RVA: 0x000BDC84 File Offset: 0x000BBE84
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

		// Token: 0x0600141A RID: 5146 RVA: 0x000BDCD4 File Offset: 0x000BBED4
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.lblcount = new global::System.Windows.Forms.Label();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.txtSearch = new global::System.Windows.Forms.TextBox();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.dgvList = new global::System.Windows.Forms.DataGridView();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.GroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvList).BeginInit();
			base.SuspendLayout();
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.lblcount);
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Controls.Add(this.txtSearch);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new global::System.Drawing.Size(1024, 80);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.lblcount.AutoSize = true;
			this.lblcount.Location = new global::System.Drawing.Point(6, 64);
			this.lblcount.Name = "lblcount";
			this.lblcount.Size = new global::System.Drawing.Size(16, 13);
			this.lblcount.TabIndex = 3;
			this.lblcount.Text = "...";
			this.Button1.Location = new global::System.Drawing.Point(394, 27);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(75, 23);
			this.Button1.TabIndex = 2;
			this.Button1.Text = "Search";
			this.Button1.UseVisualStyleBackColor = true;
			this.txtSearch.Location = new global::System.Drawing.Point(206, 30);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new global::System.Drawing.Size(182, 20);
			this.txtSearch.TabIndex = 1;
			this.Label1.AutoSize = true;
			this.Label1.Location = new global::System.Drawing.Point(6, 33);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(197, 13);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Customer Name or any part of the name:";
			this.dgvList.AllowUserToAddRows = false;
			this.dgvList.AllowUserToDeleteRows = false;
			this.dgvList.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvList.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dgvList.Location = new global::System.Drawing.Point(0, 80);
			this.dgvList.Name = "dgvList";
			this.dgvList.Size = new global::System.Drawing.Size(1024, 182);
			this.dgvList.TabIndex = 1;
			this.Label2.AutoSize = true;
			this.Label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Italic, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label2.Location = new global::System.Drawing.Point(203, 53);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(325, 13);
			this.Label2.TabIndex = 4;
			this.Label2.Text = "*Clear the search area and leave it blank to search for all customers";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1024, 262);
			base.Controls.Add(this.dgvList);
			base.Controls.Add(this.GroupBox1);
			base.Name = "FRMSearchCustomer";
			this.Text = "Search for Customer";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvList).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000A33 RID: 2611
		private global::System.ComponentModel.IContainer components;
	}
}
