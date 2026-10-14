namespace PointOfSale
{
	// Token: 0x02000031 RID: 49
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class CreditNote : global::System.Windows.Forms.UserControl
	{
		// Token: 0x060009DE RID: 2526 RVA: 0x0005CEC8 File Offset: 0x0005B0C8
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

		// Token: 0x060009DF RID: 2527 RVA: 0x0005CF18 File Offset: 0x0005B118
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.GroupBox4 = new global::System.Windows.Forms.GroupBox();
			this.Button3 = new global::System.Windows.Forms.Button();
			this.Button2 = new global::System.Windows.Forms.Button();
			this.txtinvnum = new global::System.Windows.Forms.TextBox();
			this.Label5 = new global::System.Windows.Forms.Label();
			this.Label6 = new global::System.Windows.Forms.Label();
			this.cboBranch = new global::System.Windows.Forms.ComboBox();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.DTend = new global::System.Windows.Forms.DateTimePicker();
			this.DTstart = new global::System.Windows.Forms.DateTimePicker();
			this.GroupBox2 = new global::System.Windows.Forms.GroupBox();
			this.dgvDetails = new global::System.Windows.Forms.DataGridView();
			this.GroupBox3 = new global::System.Windows.Forms.GroupBox();
			this.PictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.PicQRCode = new global::System.Windows.Forms.PictureBox();
			this.dgvInvoices = new global::System.Windows.Forms.DataGridView();
			this.PrintDocument1 = new global::System.Drawing.Printing.PrintDocument();
			this.SaveFileDialog1 = new global::System.Windows.Forms.SaveFileDialog();
			this.GroupBox1.SuspendLayout();
			this.GroupBox4.SuspendLayout();
			this.GroupBox2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvDetails).BeginInit();
			this.GroupBox3.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.PicQRCode).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.dgvInvoices).BeginInit();
			base.SuspendLayout();
			this.GroupBox1.Controls.Add(this.GroupBox4);
			this.GroupBox1.Controls.Add(this.Label6);
			this.GroupBox1.Controls.Add(this.cboBranch);
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Controls.Add(this.DTend);
			this.GroupBox1.Controls.Add(this.DTstart);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Padding = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GroupBox1.Size = new global::System.Drawing.Size(1574, 186);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.GroupBox4.BackColor = global::System.Drawing.Color.FromArgb(255, 255, 192);
			this.GroupBox4.Controls.Add(this.Button3);
			this.GroupBox4.Controls.Add(this.Button2);
			this.GroupBox4.Controls.Add(this.txtinvnum);
			this.GroupBox4.Controls.Add(this.Label5);
			this.GroupBox4.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.GroupBox4.Location = new global::System.Drawing.Point(4, 103);
			this.GroupBox4.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GroupBox4.Name = "GroupBox4";
			this.GroupBox4.Padding = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GroupBox4.Size = new global::System.Drawing.Size(1517, 78);
			this.GroupBox4.TabIndex = 43;
			this.GroupBox4.TabStop = false;
			this.GroupBox4.Text = "Search by Invoice Number";
			this.Button3.BackColor = global::System.Drawing.Color.Aqua;
			this.Button3.Location = new global::System.Drawing.Point(524, 29);
			this.Button3.Name = "Button3";
			this.Button3.Size = new global::System.Drawing.Size(298, 34);
			this.Button3.TabIndex = 49;
			this.Button3.Text = "Export to Excel";
			this.Button3.UseVisualStyleBackColor = false;
			this.Button2.Location = new global::System.Drawing.Point(315, 28);
			this.Button2.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Button2.Name = "Button2";
			this.Button2.Size = new global::System.Drawing.Size(112, 35);
			this.Button2.TabIndex = 48;
			this.Button2.Text = "Search";
			this.Button2.UseVisualStyleBackColor = true;
			this.txtinvnum.Location = new global::System.Drawing.Point(140, 29);
			this.txtinvnum.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtinvnum.Name = "txtinvnum";
			this.txtinvnum.Size = new global::System.Drawing.Size(164, 26);
			this.txtinvnum.TabIndex = 47;
			this.Label5.AutoSize = true;
			this.Label5.Location = new global::System.Drawing.Point(6, 35);
			this.Label5.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label5.Name = "Label5";
			this.Label5.Size = new global::System.Drawing.Size(121, 20);
			this.Label5.TabIndex = 46;
			this.Label5.Text = "Invoice number:";
			this.Label6.AutoSize = true;
			this.Label6.Location = new global::System.Drawing.Point(3, 66);
			this.Label6.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label6.Name = "Label6";
			this.Label6.Size = new global::System.Drawing.Size(113, 20);
			this.Label6.TabIndex = 42;
			this.Label6.Text = "Select Branch:";
			this.cboBranch.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboBranch.FormattingEnabled = true;
			this.cboBranch.Location = new global::System.Drawing.Point(128, 62);
			this.cboBranch.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cboBranch.Name = "cboBranch";
			this.cboBranch.Size = new global::System.Drawing.Size(256, 28);
			this.cboBranch.TabIndex = 41;
			this.Label4.AutoSize = true;
			this.Label4.BackColor = global::System.Drawing.Color.Red;
			this.Label4.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.Label4.Location = new global::System.Drawing.Point(1521, 24);
			this.Label4.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label4.Name = "Label4";
			this.Label4.Size = new global::System.Drawing.Size(49, 20);
			this.Label4.TabIndex = 6;
			this.Label4.Text = "Close";
			this.Label3.AutoSize = true;
			this.Label3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label3.Location = new global::System.Drawing.Point(9, 15);
			this.Label3.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(496, 32);
			this.Label3.TabIndex = 5;
			this.Label3.Text = "View Reprint or Cancel Invoiced Sales";
			this.Label2.AutoSize = true;
			this.Label2.Location = new global::System.Drawing.Point(888, 69);
			this.Label2.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(81, 20);
			this.Label2.TabIndex = 4;
			this.Label2.Text = "End Date:";
			this.Button1.BackColor = global::System.Drawing.Color.Lime;
			this.Button1.Location = new global::System.Drawing.Point(1293, 58);
			this.Button1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(178, 35);
			this.Button1.TabIndex = 3;
			this.Button1.Text = "View Sales";
			this.Button1.UseVisualStyleBackColor = false;
			this.Label1.AutoSize = true;
			this.Label1.Location = new global::System.Drawing.Point(432, 69);
			this.Label1.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(87, 20);
			this.Label1.TabIndex = 2;
			this.Label1.Text = "Start Date:";
			this.DTend.Location = new global::System.Drawing.Point(984, 63);
			this.DTend.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.DTend.Name = "DTend";
			this.DTend.Size = new global::System.Drawing.Size(298, 26);
			this.DTend.TabIndex = 1;
			this.DTstart.Location = new global::System.Drawing.Point(528, 63);
			this.DTstart.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.DTstart.Name = "DTstart";
			this.DTstart.Size = new global::System.Drawing.Size(298, 26);
			this.DTstart.TabIndex = 0;
			this.GroupBox2.Controls.Add(this.dgvDetails);
			this.GroupBox2.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.GroupBox2.Location = new global::System.Drawing.Point(0, 576);
			this.GroupBox2.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GroupBox2.Name = "GroupBox2";
			this.GroupBox2.Padding = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GroupBox2.Size = new global::System.Drawing.Size(1574, 438);
			this.GroupBox2.TabIndex = 1;
			this.GroupBox2.TabStop = false;
			this.dgvDetails.AllowUserToAddRows = false;
			this.dgvDetails.AllowUserToDeleteRows = false;
			this.dgvDetails.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDetails.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dgvDetails.Location = new global::System.Drawing.Point(4, 24);
			this.dgvDetails.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dgvDetails.Name = "dgvDetails";
			this.dgvDetails.ReadOnly = true;
			this.dgvDetails.Size = new global::System.Drawing.Size(1566, 409);
			this.dgvDetails.TabIndex = 0;
			this.GroupBox3.Controls.Add(this.PictureBox1);
			this.GroupBox3.Controls.Add(this.PicQRCode);
			this.GroupBox3.Controls.Add(this.dgvInvoices);
			this.GroupBox3.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.GroupBox3.Location = new global::System.Drawing.Point(0, 186);
			this.GroupBox3.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GroupBox3.Name = "GroupBox3";
			this.GroupBox3.Padding = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GroupBox3.Size = new global::System.Drawing.Size(1574, 390);
			this.GroupBox3.TabIndex = 2;
			this.GroupBox3.TabStop = false;
			this.PictureBox1.Location = new global::System.Drawing.Point(266, 94);
			this.PictureBox1.Name = "PictureBox1";
			this.PictureBox1.Size = new global::System.Drawing.Size(100, 50);
			this.PictureBox1.TabIndex = 77;
			this.PictureBox1.TabStop = false;
			this.PictureBox1.Visible = false;
			this.PicQRCode.Location = new global::System.Drawing.Point(920, 43);
			this.PicQRCode.Name = "PicQRCode";
			this.PicQRCode.Size = new global::System.Drawing.Size(292, 245);
			this.PicQRCode.TabIndex = 76;
			this.PicQRCode.TabStop = false;
			this.PicQRCode.Visible = false;
			this.dgvInvoices.AllowUserToAddRows = false;
			this.dgvInvoices.AllowUserToDeleteRows = false;
			this.dgvInvoices.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvInvoices.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dgvInvoices.Location = new global::System.Drawing.Point(4, 24);
			this.dgvInvoices.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dgvInvoices.Name = "dgvInvoices";
			this.dgvInvoices.ReadOnly = true;
			this.dgvInvoices.Size = new global::System.Drawing.Size(1566, 361);
			this.dgvInvoices.TabIndex = 0;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.Controls.Add(this.GroupBox3);
			base.Controls.Add(this.GroupBox2);
			base.Controls.Add(this.GroupBox1);
			base.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			base.Name = "CreditNote";
			base.Size = new global::System.Drawing.Size(1574, 1014);
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.GroupBox4.ResumeLayout(false);
			this.GroupBox4.PerformLayout();
			this.GroupBox2.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.dgvDetails).EndInit();
			this.GroupBox3.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.PicQRCode).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.dgvInvoices).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x0400049D RID: 1181
		private global::System.ComponentModel.IContainer components;
	}
}
