namespace PointOfSale
{
	// Token: 0x02000034 RID: 52
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class CSVSales : global::System.Windows.Forms.UserControl
	{
		// Token: 0x06000B4A RID: 2890 RVA: 0x00071CA4 File Offset: 0x0006FEA4
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

		// Token: 0x06000B4B RID: 2891 RVA: 0x00071CF4 File Offset: 0x0006FEF4
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.txtConsultant = new global::System.Windows.Forms.Label();
			this.cboConsultant = new global::System.Windows.Forms.ComboBox();
			this.Label6 = new global::System.Windows.Forms.Label();
			this.GroupBox2 = new global::System.Windows.Forms.GroupBox();
			this.dgvPay = new global::System.Windows.Forms.DataGridView();
			this.GroupBox3 = new global::System.Windows.Forms.GroupBox();
			this.Label5 = new global::System.Windows.Forms.Label();
			this.Label7 = new global::System.Windows.Forms.Label();
			this.txtbal = new global::System.Windows.Forms.TextBox();
			this.txtamtpaid = new global::System.Windows.Forms.TextBox();
			this.txtInvTotal = new global::System.Windows.Forms.TextBox();
			this.Label8 = new global::System.Windows.Forms.Label();
			this.lblpaymethod = new global::System.Windows.Forms.Label();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.lblPath = new global::System.Windows.Forms.Label();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.txtref = new global::System.Windows.Forms.TextBox();
			this.DTDate = new global::System.Windows.Forms.DateTimePicker();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.cboBranches = new global::System.Windows.Forms.ComboBox();
			this.dgvSales = new global::System.Windows.Forms.DataGridView();
			this.OpenFileDialog1 = new global::System.Windows.Forms.OpenFileDialog();
			this.Button2 = new global::System.Windows.Forms.Button();
			this.GroupBox1.SuspendLayout();
			this.GroupBox2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvPay).BeginInit();
			this.GroupBox3.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvSales).BeginInit();
			base.SuspendLayout();
			this.GroupBox1.BackColor = global::System.Drawing.Color.FromArgb(192, 255, 255);
			this.GroupBox1.Controls.Add(this.Button2);
			this.GroupBox1.Controls.Add(this.txtConsultant);
			this.GroupBox1.Controls.Add(this.cboConsultant);
			this.GroupBox1.Controls.Add(this.Label6);
			this.GroupBox1.Controls.Add(this.GroupBox2);
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.lblPath);
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Controls.Add(this.txtref);
			this.GroupBox1.Controls.Add(this.DTDate);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Controls.Add(this.cboBranches);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new global::System.Drawing.Size(1271, 465);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Details";
			this.txtConsultant.AutoSize = true;
			this.txtConsultant.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtConsultant.Location = new global::System.Drawing.Point(16, 182);
			this.txtConsultant.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.txtConsultant.Name = "txtConsultant";
			this.txtConsultant.Size = new global::System.Drawing.Size(90, 20);
			this.txtConsultant.TabIndex = 68;
			this.txtConsultant.Text = "Consultant:";
			this.cboConsultant.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboConsultant.FormattingEnabled = true;
			this.cboConsultant.Location = new global::System.Drawing.Point(114, 179);
			this.cboConsultant.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cboConsultant.Name = "cboConsultant";
			this.cboConsultant.Size = new global::System.Drawing.Size(285, 28);
			this.cboConsultant.TabIndex = 67;
			this.cboConsultant.TabStop = false;
			this.Label6.AutoSize = true;
			this.Label6.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label6.Location = new global::System.Drawing.Point(7, 44);
			this.Label6.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label6.Name = "Label6";
			this.Label6.Size = new global::System.Drawing.Size(343, 25);
			this.Label6.TabIndex = 10;
			this.Label6.Text = "IMPORT SALES FROM CSV FILE";
			this.GroupBox2.Controls.Add(this.dgvPay);
			this.GroupBox2.Controls.Add(this.GroupBox3);
			this.GroupBox2.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.GroupBox2.Location = new global::System.Drawing.Point(636, 22);
			this.GroupBox2.Name = "GroupBox2";
			this.GroupBox2.Size = new global::System.Drawing.Size(578, 400);
			this.GroupBox2.TabIndex = 9;
			this.GroupBox2.TabStop = false;
			this.dgvPay.AllowUserToAddRows = false;
			this.dgvPay.AllowUserToDeleteRows = false;
			this.dgvPay.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvPay.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dgvPay.Location = new global::System.Drawing.Point(3, 206);
			this.dgvPay.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dgvPay.Name = "dgvPay";
			this.dgvPay.Size = new global::System.Drawing.Size(572, 191);
			this.dgvPay.TabIndex = 2;
			this.GroupBox3.Controls.Add(this.Label5);
			this.GroupBox3.Controls.Add(this.Label7);
			this.GroupBox3.Controls.Add(this.txtbal);
			this.GroupBox3.Controls.Add(this.txtamtpaid);
			this.GroupBox3.Controls.Add(this.txtInvTotal);
			this.GroupBox3.Controls.Add(this.Label8);
			this.GroupBox3.Controls.Add(this.lblpaymethod);
			this.GroupBox3.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox3.Location = new global::System.Drawing.Point(3, 22);
			this.GroupBox3.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GroupBox3.Name = "GroupBox3";
			this.GroupBox3.Padding = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GroupBox3.Size = new global::System.Drawing.Size(572, 184);
			this.GroupBox3.TabIndex = 1;
			this.GroupBox3.TabStop = false;
			this.Label5.AutoSize = true;
			this.Label5.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label5.Location = new global::System.Drawing.Point(14, 25);
			this.Label5.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label5.Name = "Label5";
			this.Label5.Size = new global::System.Drawing.Size(530, 25);
			this.Label5.TabIndex = 7;
			this.Label5.Text = "ENTER MULTIPLE PAYMENT METHODS FOR SALE";
			this.Label7.AutoSize = true;
			this.Label7.Location = new global::System.Drawing.Point(140, 149);
			this.Label7.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label7.Name = "Label7";
			this.Label7.Size = new global::System.Drawing.Size(71, 20);
			this.Label7.TabIndex = 5;
			this.Label7.Text = "Balance:";
			this.txtbal.Location = new global::System.Drawing.Point(222, 145);
			this.txtbal.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtbal.Name = "txtbal";
			this.txtbal.ReadOnly = true;
			this.txtbal.Size = new global::System.Drawing.Size(175, 26);
			this.txtbal.TabIndex = 4;
			this.txtbal.TabStop = false;
			this.txtamtpaid.Location = new global::System.Drawing.Point(222, 105);
			this.txtamtpaid.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtamtpaid.Name = "txtamtpaid";
			this.txtamtpaid.ReadOnly = true;
			this.txtamtpaid.Size = new global::System.Drawing.Size(175, 26);
			this.txtamtpaid.TabIndex = 3;
			this.txtamtpaid.TabStop = false;
			this.txtInvTotal.Location = new global::System.Drawing.Point(222, 65);
			this.txtInvTotal.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtInvTotal.Name = "txtInvTotal";
			this.txtInvTotal.ReadOnly = true;
			this.txtInvTotal.Size = new global::System.Drawing.Size(175, 26);
			this.txtInvTotal.TabIndex = 2;
			this.txtInvTotal.TabStop = false;
			this.Label8.AutoSize = true;
			this.Label8.Location = new global::System.Drawing.Point(108, 111);
			this.Label8.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label8.Name = "Label8";
			this.Label8.Size = new global::System.Drawing.Size(104, 20);
			this.Label8.TabIndex = 1;
			this.Label8.Text = "Amount Paid:";
			this.lblpaymethod.AutoSize = true;
			this.lblpaymethod.Location = new global::System.Drawing.Point(132, 68);
			this.lblpaymethod.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblpaymethod.Name = "lblpaymethod";
			this.lblpaymethod.Size = new global::System.Drawing.Size(82, 20);
			this.lblpaymethod.TabIndex = 0;
			this.lblpaymethod.Text = "Total Due:";
			this.Label4.AutoSize = true;
			this.Label4.BackColor = global::System.Drawing.Color.Red;
			this.Label4.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.Label4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label4.Location = new global::System.Drawing.Point(1214, 22);
			this.Label4.Name = "Label4";
			this.Label4.Size = new global::System.Drawing.Size(54, 20);
			this.Label4.TabIndex = 8;
			this.Label4.Text = "Close";
			this.Label3.AutoSize = true;
			this.Label3.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.Label3.Location = new global::System.Drawing.Point(3, 422);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(396, 40);
			this.Label3.TabIndex = 7;
			this.Label3.Text = "FORMAT: \r\nProductCode --- QTY --- Unit Selling Price Including Tax";
			this.lblPath.AutoSize = true;
			this.lblPath.Location = new global::System.Drawing.Point(405, 302);
			this.lblPath.Name = "lblPath";
			this.lblPath.Size = new global::System.Drawing.Size(21, 20);
			this.lblPath.TabIndex = 6;
			this.lblPath.Text = "...";
			this.Button1.BackColor = global::System.Drawing.Color.FromArgb(255, 255, 192);
			this.Button1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Button1.Location = new global::System.Drawing.Point(114, 281);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(285, 41);
			this.Button1.TabIndex = 5;
			this.Button1.Text = "Select .csv Sales File";
			this.Button1.UseVisualStyleBackColor = false;
			this.txtref.Location = new global::System.Drawing.Point(114, 249);
			this.txtref.Name = "txtref";
			this.txtref.Size = new global::System.Drawing.Size(285, 26);
			this.txtref.TabIndex = 4;
			this.DTDate.Location = new global::System.Drawing.Point(114, 114);
			this.DTDate.Name = "DTDate";
			this.DTDate.Size = new global::System.Drawing.Size(285, 26);
			this.DTDate.TabIndex = 3;
			this.Label2.AutoSize = true;
			this.Label2.Location = new global::System.Drawing.Point(20, 252);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(88, 20);
			this.Label2.TabIndex = 2;
			this.Label2.Text = "Reference:";
			this.Label1.AutoSize = true;
			this.Label1.Location = new global::System.Drawing.Point(44, 218);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(64, 20);
			this.Label1.TabIndex = 1;
			this.Label1.Text = "Branch:";
			this.cboBranches.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboBranches.FormattingEnabled = true;
			this.cboBranches.Location = new global::System.Drawing.Point(114, 215);
			this.cboBranches.Name = "cboBranches";
			this.cboBranches.Size = new global::System.Drawing.Size(285, 28);
			this.cboBranches.TabIndex = 0;
			this.dgvSales.AllowUserToAddRows = false;
			this.dgvSales.AllowUserToDeleteRows = false;
			this.dgvSales.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSales.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dgvSales.Location = new global::System.Drawing.Point(0, 465);
			this.dgvSales.Name = "dgvSales";
			this.dgvSales.ReadOnly = true;
			this.dgvSales.RowTemplate.Height = 28;
			this.dgvSales.Size = new global::System.Drawing.Size(1271, 151);
			this.dgvSales.TabIndex = 1;
			this.OpenFileDialog1.FileName = "OpenFileDialog1";
			this.Button2.BackColor = global::System.Drawing.Color.Lime;
			this.Button2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Button2.Location = new global::System.Drawing.Point(114, 328);
			this.Button2.Name = "Button2";
			this.Button2.Size = new global::System.Drawing.Size(285, 41);
			this.Button2.TabIndex = 70;
			this.Button2.Text = "CONFIRM SALE";
			this.Button2.UseVisualStyleBackColor = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.Controls.Add(this.dgvSales);
			base.Controls.Add(this.GroupBox1);
			base.Name = "CSVSales";
			base.Size = new global::System.Drawing.Size(1271, 616);
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.GroupBox2.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.dgvPay).EndInit();
			this.GroupBox3.ResumeLayout(false);
			this.GroupBox3.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvSales).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000558 RID: 1368
		private global::System.ComponentModel.IContainer components;
	}
}
