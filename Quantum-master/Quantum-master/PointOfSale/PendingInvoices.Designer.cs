namespace PointOfSale
{
	// Token: 0x0200008B RID: 139
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class PendingInvoices : global::System.Windows.Forms.Form
	{
		// Token: 0x06001F90 RID: 8080 RVA: 0x001199FC File Offset: 0x00117BFC
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

		// Token: 0x06001F91 RID: 8081 RVA: 0x00119A4C File Offset: 0x00117C4C
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.Button2 = new global::System.Windows.Forms.Button();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.dtDate = new global::System.Windows.Forms.DateTimePicker();
			this.GroupBox2 = new global::System.Windows.Forms.GroupBox();
			this.dgvPending = new global::System.Windows.Forms.DataGridView();
			this.Button3 = new global::System.Windows.Forms.Button();
			this.GroupBox1.SuspendLayout();
			this.GroupBox2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvPending).BeginInit();
			base.SuspendLayout();
			this.GroupBox1.Controls.Add(this.Button3);
			this.GroupBox1.Controls.Add(this.Button2);
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Controls.Add(this.dtDate);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Padding = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GroupBox1.Size = new global::System.Drawing.Size(1202, 86);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Select Date";
			this.Button2.Location = new global::System.Drawing.Point(941, 16);
			this.Button2.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Button2.Name = "Button2";
			this.Button2.Size = new global::System.Drawing.Size(233, 57);
			this.Button2.TabIndex = 2;
			this.Button2.Text = "Show All Quotations Processed and Unprocessed";
			this.Button2.UseVisualStyleBackColor = true;
			this.Button1.BackColor = global::System.Drawing.Color.Lime;
			this.Button1.Location = new global::System.Drawing.Point(314, 16);
			this.Button1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(271, 57);
			this.Button1.TabIndex = 1;
			this.Button1.Text = "View Saved Quotations Unprocessed for You";
			this.Button1.UseVisualStyleBackColor = false;
			this.dtDate.Location = new global::System.Drawing.Point(8, 29);
			this.dtDate.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dtDate.Name = "dtDate";
			this.dtDate.Size = new global::System.Drawing.Size(298, 26);
			this.dtDate.TabIndex = 0;
			this.GroupBox2.Controls.Add(this.dgvPending);
			this.GroupBox2.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.GroupBox2.Location = new global::System.Drawing.Point(0, 86);
			this.GroupBox2.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GroupBox2.Name = "GroupBox2";
			this.GroupBox2.Padding = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GroupBox2.Size = new global::System.Drawing.Size(1202, 496);
			this.GroupBox2.TabIndex = 1;
			this.GroupBox2.TabStop = false;
			this.GroupBox2.Text = "Detail";
			this.dgvPending.AllowUserToAddRows = false;
			this.dgvPending.AllowUserToDeleteRows = false;
			this.dgvPending.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvPending.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dgvPending.Location = new global::System.Drawing.Point(4, 24);
			this.dgvPending.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dgvPending.Name = "dgvPending";
			this.dgvPending.Size = new global::System.Drawing.Size(1194, 467);
			this.dgvPending.TabIndex = 1;
			this.Button3.BackColor = global::System.Drawing.Color.DodgerBlue;
			this.Button3.Location = new global::System.Drawing.Point(629, 16);
			this.Button3.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Button3.Name = "Button3";
			this.Button3.Size = new global::System.Drawing.Size(271, 57);
			this.Button3.TabIndex = 3;
			this.Button3.Text = "View Saved Quotations Unprocessed for All Users";
			this.Button3.UseVisualStyleBackColor = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1202, 582);
			base.Controls.Add(this.GroupBox2);
			base.Controls.Add(this.GroupBox1);
			base.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			base.Name = "PendingInvoices";
			this.Text = "Pending Invoices";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox2.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.dgvPending).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000EFE RID: 3838
		private global::System.ComponentModel.IContainer components;
	}
}
