namespace PointOfSale
{
	// Token: 0x0200020C RID: 524
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class ViewCancelledSales : global::System.Windows.Forms.UserControl
	{
		// Token: 0x06005E2E RID: 24110 RVA: 0x0035E840 File Offset: 0x0035CA40
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

		// Token: 0x06005E2F RID: 24111 RVA: 0x0035E890 File Offset: 0x0035CA90
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
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
			this.PicQRCode = new global::System.Windows.Forms.PictureBox();
			this.dgvInvoices = new global::System.Windows.Forms.DataGridView();
			this.PrintDocument1 = new global::System.Drawing.Printing.PrintDocument();
			this.dgv = new global::System.Windows.Forms.DataGridView();
			this.GroupBox1.SuspendLayout();
			this.GroupBox2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvDetails).BeginInit();
			this.GroupBox3.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.PicQRCode).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.dgvInvoices).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.dgv).BeginInit();
			base.SuspendLayout();
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
			this.GroupBox1.Size = new global::System.Drawing.Size(1634, 152);
			this.GroupBox1.TabIndex = 1;
			this.GroupBox1.TabStop = false;
			this.Label4.AutoSize = true;
			this.Label4.BackColor = global::System.Drawing.Color.Red;
			this.Label4.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.Label4.Location = new global::System.Drawing.Point(1581, 24);
			this.Label4.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label4.Name = "Label4";
			this.Label4.Size = new global::System.Drawing.Size(49, 20);
			this.Label4.TabIndex = 6;
			this.Label4.Text = "Close";
			this.Label3.AutoSize = true;
			this.Label3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label3.Location = new global::System.Drawing.Point(597, 25);
			this.Label3.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(291, 32);
			this.Label3.TabIndex = 5;
			this.Label3.Text = "View Cancelled Sales";
			this.Label2.AutoSize = true;
			this.Label2.Location = new global::System.Drawing.Point(886, 103);
			this.Label2.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(81, 20);
			this.Label2.TabIndex = 4;
			this.Label2.Text = "End Date:";
			this.Button1.Location = new global::System.Drawing.Point(1292, 92);
			this.Button1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(178, 35);
			this.Button1.TabIndex = 3;
			this.Button1.Text = "View Sales";
			this.Button1.UseVisualStyleBackColor = true;
			this.Label1.AutoSize = true;
			this.Label1.Location = new global::System.Drawing.Point(393, 103);
			this.Label1.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(87, 20);
			this.Label1.TabIndex = 2;
			this.Label1.Text = "Start Date:";
			this.DTend.Location = new global::System.Drawing.Point(982, 97);
			this.DTend.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.DTend.Name = "DTend";
			this.DTend.Size = new global::System.Drawing.Size(298, 26);
			this.DTend.TabIndex = 1;
			this.DTstart.Location = new global::System.Drawing.Point(489, 97);
			this.DTstart.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.DTstart.Name = "DTstart";
			this.DTstart.Size = new global::System.Drawing.Size(298, 26);
			this.DTstart.TabIndex = 0;
			this.GroupBox2.Controls.Add(this.PicQRCode);
			this.GroupBox2.Controls.Add(this.dgvDetails);
			this.GroupBox2.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.GroupBox2.Location = new global::System.Drawing.Point(0, 388);
			this.GroupBox2.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GroupBox2.Name = "GroupBox2";
			this.GroupBox2.Padding = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GroupBox2.Size = new global::System.Drawing.Size(1634, 380);
			this.GroupBox2.TabIndex = 2;
			this.GroupBox2.TabStop = false;
			this.dgvDetails.AllowUserToAddRows = false;
			this.dgvDetails.AllowUserToDeleteRows = false;
			this.dgvDetails.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDetails.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dgvDetails.Location = new global::System.Drawing.Point(4, 24);
			this.dgvDetails.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dgvDetails.Name = "dgvDetails";
			this.dgvDetails.ReadOnly = true;
			this.dgvDetails.Size = new global::System.Drawing.Size(1626, 351);
			this.dgvDetails.TabIndex = 0;
			this.GroupBox3.Controls.Add(this.dgv);
			this.GroupBox3.Controls.Add(this.dgvInvoices);
			this.GroupBox3.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.GroupBox3.Location = new global::System.Drawing.Point(0, 152);
			this.GroupBox3.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GroupBox3.Name = "GroupBox3";
			this.GroupBox3.Padding = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GroupBox3.Size = new global::System.Drawing.Size(1634, 236);
			this.GroupBox3.TabIndex = 3;
			this.GroupBox3.TabStop = false;
			this.PicQRCode.Location = new global::System.Drawing.Point(458, 0);
			this.PicQRCode.Name = "PicQRCode";
			this.PicQRCode.Size = new global::System.Drawing.Size(207, 164);
			this.PicQRCode.TabIndex = 77;
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
			this.dgvInvoices.Size = new global::System.Drawing.Size(1626, 207);
			this.dgvInvoices.TabIndex = 0;
			this.dgv.AllowUserToAddRows = false;
			this.dgv.AllowUserToDeleteRows = false;
			this.dgv.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv.Location = new global::System.Drawing.Point(78, 51);
			this.dgv.Name = "dgv";
			this.dgv.ReadOnly = true;
			this.dgv.RowTemplate.Height = 28;
			this.dgv.Size = new global::System.Drawing.Size(812, 154);
			this.dgv.TabIndex = 1;
			this.dgv.Visible = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.Controls.Add(this.GroupBox3);
			base.Controls.Add(this.GroupBox2);
			base.Controls.Add(this.GroupBox1);
			base.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			base.Name = "ViewCancelledSales";
			base.Size = new global::System.Drawing.Size(1634, 768);
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.GroupBox2.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.dgvDetails).EndInit();
			this.GroupBox3.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.PicQRCode).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.dgvInvoices).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.dgv).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04002932 RID: 10546
		private global::System.ComponentModel.IContainer components;
	}
}
