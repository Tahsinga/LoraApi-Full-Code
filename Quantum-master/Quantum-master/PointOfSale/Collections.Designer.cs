namespace PointOfSale
{
	// Token: 0x02000026 RID: 38
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Collections : global::System.Windows.Forms.Form
	{
		// Token: 0x06000737 RID: 1847 RVA: 0x0004887C File Offset: 0x00046A7C
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

		// Token: 0x06000738 RID: 1848 RVA: 0x000488CC File Offset: 0x00046ACC
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.DTEnddate = new global::System.Windows.Forms.DateTimePicker();
			this.Label5 = new global::System.Windows.Forms.Label();
			this.DTStartdate = new global::System.Windows.Forms.DateTimePicker();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.cboBranch = new global::System.Windows.Forms.ComboBox();
			this.GroupBox2 = new global::System.Windows.Forms.GroupBox();
			this.dgvInvoices = new global::System.Windows.Forms.DataGridView();
			this.GroupBox3 = new global::System.Windows.Forms.GroupBox();
			this.dgvInvDetails = new global::System.Windows.Forms.DataGridView();
			this.GroupBox4 = new global::System.Windows.Forms.GroupBox();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.txtCollectedBy = new global::System.Windows.Forms.TextBox();
			this.Button2 = new global::System.Windows.Forms.Button();
			this.chkCollectionsOnly = new global::System.Windows.Forms.CheckBox();
			this.GroupBox1.SuspendLayout();
			this.GroupBox2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvInvoices).BeginInit();
			this.GroupBox3.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvInvDetails).BeginInit();
			this.GroupBox4.SuspendLayout();
			base.SuspendLayout();
			this.GroupBox1.Controls.Add(this.chkCollectionsOnly);
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Controls.Add(this.DTEnddate);
			this.GroupBox1.Controls.Add(this.Label5);
			this.GroupBox1.Controls.Add(this.DTStartdate);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Controls.Add(this.cboBranch);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Padding = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GroupBox1.Size = new global::System.Drawing.Size(1365, 152);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.Button1.BackColor = global::System.Drawing.Color.Lime;
			this.Button1.Location = new global::System.Drawing.Point(1038, 96);
			this.Button1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(164, 35);
			this.Button1.TabIndex = 14;
			this.Button1.Text = "VIEW SALES";
			this.Button1.UseVisualStyleBackColor = false;
			this.DTEnddate.Location = new global::System.Drawing.Point(904, 60);
			this.DTEnddate.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.DTEnddate.Name = "DTEnddate";
			this.DTEnddate.Size = new global::System.Drawing.Size(298, 26);
			this.DTEnddate.TabIndex = 13;
			this.Label5.AutoSize = true;
			this.Label5.Location = new global::System.Drawing.Point(813, 65);
			this.Label5.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label5.Name = "Label5";
			this.Label5.Size = new global::System.Drawing.Size(81, 20);
			this.Label5.TabIndex = 12;
			this.Label5.Text = "End Date:";
			this.DTStartdate.Location = new global::System.Drawing.Point(468, 60);
			this.DTStartdate.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.DTStartdate.Name = "DTStartdate";
			this.DTStartdate.Size = new global::System.Drawing.Size(298, 26);
			this.DTStartdate.TabIndex = 11;
			this.Label2.AutoSize = true;
			this.Label2.Location = new global::System.Drawing.Point(363, 65);
			this.Label2.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(94, 20);
			this.Label2.TabIndex = 10;
			this.Label2.Text = "Select date:";
			this.Label1.AutoSize = true;
			this.Label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label1.Location = new global::System.Drawing.Point(15, 14);
			this.Label1.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(299, 29);
			this.Label1.TabIndex = 9;
			this.Label1.Text = "Select Invoices to Check";
			this.Label4.AutoSize = true;
			this.Label4.Location = new global::System.Drawing.Point(16, 65);
			this.Label4.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label4.Name = "Label4";
			this.Label4.Size = new global::System.Drawing.Size(60, 20);
			this.Label4.TabIndex = 8;
			this.Label4.Text = "Branch";
			this.cboBranch.FormattingEnabled = true;
			this.cboBranch.Location = new global::System.Drawing.Point(87, 60);
			this.cboBranch.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cboBranch.Name = "cboBranch";
			this.cboBranch.Size = new global::System.Drawing.Size(256, 28);
			this.cboBranch.TabIndex = 7;
			this.GroupBox2.Controls.Add(this.dgvInvoices);
			this.GroupBox2.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox2.Location = new global::System.Drawing.Point(0, 152);
			this.GroupBox2.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GroupBox2.Name = "GroupBox2";
			this.GroupBox2.Padding = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GroupBox2.Size = new global::System.Drawing.Size(1365, 306);
			this.GroupBox2.TabIndex = 1;
			this.GroupBox2.TabStop = false;
			this.GroupBox2.Text = "Invoices For Period";
			this.dgvInvoices.AllowUserToAddRows = false;
			this.dgvInvoices.AllowUserToDeleteRows = false;
			this.dgvInvoices.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvInvoices.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dgvInvoices.Location = new global::System.Drawing.Point(4, 24);
			this.dgvInvoices.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dgvInvoices.Name = "dgvInvoices";
			this.dgvInvoices.ReadOnly = true;
			this.dgvInvoices.Size = new global::System.Drawing.Size(1357, 277);
			this.dgvInvoices.TabIndex = 0;
			this.GroupBox3.Controls.Add(this.dgvInvDetails);
			this.GroupBox3.Controls.Add(this.GroupBox4);
			this.GroupBox3.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.GroupBox3.Location = new global::System.Drawing.Point(0, 458);
			this.GroupBox3.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GroupBox3.Name = "GroupBox3";
			this.GroupBox3.Padding = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GroupBox3.Size = new global::System.Drawing.Size(1365, 425);
			this.GroupBox3.TabIndex = 2;
			this.GroupBox3.TabStop = false;
			this.GroupBox3.Text = "Invoice Details";
			this.dgvInvDetails.AllowUserToAddRows = false;
			this.dgvInvDetails.AllowUserToDeleteRows = false;
			this.dgvInvDetails.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvInvDetails.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dgvInvDetails.Location = new global::System.Drawing.Point(4, 24);
			this.dgvInvDetails.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dgvInvDetails.Name = "dgvInvDetails";
			this.dgvInvDetails.Size = new global::System.Drawing.Size(1357, 242);
			this.dgvInvDetails.TabIndex = 3;
			this.GroupBox4.Controls.Add(this.Label3);
			this.GroupBox4.Controls.Add(this.txtCollectedBy);
			this.GroupBox4.Controls.Add(this.Button2);
			this.GroupBox4.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.GroupBox4.Location = new global::System.Drawing.Point(4, 266);
			this.GroupBox4.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GroupBox4.Name = "GroupBox4";
			this.GroupBox4.Padding = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GroupBox4.Size = new global::System.Drawing.Size(1357, 154);
			this.GroupBox4.TabIndex = 0;
			this.GroupBox4.TabStop = false;
			this.Label3.AutoSize = true;
			this.Label3.Location = new global::System.Drawing.Point(42, 34);
			this.Label3.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(248, 20);
			this.Label3.TabIndex = 2;
			this.Label3.Text = "Goods Received in good order by:";
			this.txtCollectedBy.Location = new global::System.Drawing.Point(304, 29);
			this.txtCollectedBy.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtCollectedBy.Name = "txtCollectedBy";
			this.txtCollectedBy.Size = new global::System.Drawing.Size(230, 26);
			this.txtCollectedBy.TabIndex = 1;
			this.Button2.BackColor = global::System.Drawing.Color.Lime;
			this.Button2.Location = new global::System.Drawing.Point(546, 29);
			this.Button2.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Button2.Name = "Button2";
			this.Button2.Size = new global::System.Drawing.Size(300, 52);
			this.Button2.TabIndex = 0;
			this.Button2.Text = "SAVE COLLECTION/DELIVERY CHANGES";
			this.Button2.UseVisualStyleBackColor = false;
			this.chkCollectionsOnly.AutoSize = true;
			this.chkCollectionsOnly.Location = new global::System.Drawing.Point(742, 102);
			this.chkCollectionsOnly.Name = "chkCollectionsOnly";
			this.chkCollectionsOnly.Size = new global::System.Drawing.Size(288, 24);
			this.chkCollectionsOnly.TabIndex = 15;
			this.chkCollectionsOnly.Text = "View Collections/Delivery Sales Only";
			this.chkCollectionsOnly.UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1365, 883);
			base.Controls.Add(this.GroupBox3);
			base.Controls.Add(this.GroupBox2);
			base.Controls.Add(this.GroupBox1);
			base.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			base.Name = "Collections";
			this.Text = "Collections and Deliveries";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.GroupBox2.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.dgvInvoices).EndInit();
			this.GroupBox3.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.dgvInvDetails).EndInit();
			this.GroupBox4.ResumeLayout(false);
			this.GroupBox4.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04000365 RID: 869
		private global::System.ComponentModel.IContainer components;
	}
}
