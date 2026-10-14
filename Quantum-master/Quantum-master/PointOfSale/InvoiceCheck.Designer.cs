namespace PointOfSale
{
	// Token: 0x02000066 RID: 102
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class InvoiceCheck : global::System.Windows.Forms.UserControl
	{
		// Token: 0x060015C4 RID: 5572 RVA: 0x000CB76C File Offset: 0x000C996C
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

		// Token: 0x060015C5 RID: 5573 RVA: 0x000CB7BC File Offset: 0x000C99BC
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.Panel1 = new global::System.Windows.Forms.Panel();
			this.lblInvTime = new global::System.Windows.Forms.Label();
			this.lblDoneBY = new global::System.Windows.Forms.Label();
			this.lblInvTotal = new global::System.Windows.Forms.Label();
			this.lblPayMethod = new global::System.Windows.Forms.Label();
			this.lblInvDate = new global::System.Windows.Forms.Label();
			this.lblInvNum = new global::System.Windows.Forms.Label();
			this.PanelStatus = new global::System.Windows.Forms.Panel();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.lblStatus = new global::System.Windows.Forms.Label();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.txtInvoiceNumber = new global::System.Windows.Forms.TextBox();
			this.Panel2 = new global::System.Windows.Forms.Panel();
			this.dgvInvoices = new global::System.Windows.Forms.DataGridView();
			this.lblinfo = new global::System.Windows.Forms.Label();
			this.Panel1.SuspendLayout();
			this.PanelStatus.SuspendLayout();
			this.Panel2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvInvoices).BeginInit();
			base.SuspendLayout();
			this.Panel1.Controls.Add(this.lblinfo);
			this.Panel1.Controls.Add(this.lblInvTime);
			this.Panel1.Controls.Add(this.lblDoneBY);
			this.Panel1.Controls.Add(this.lblInvTotal);
			this.Panel1.Controls.Add(this.lblPayMethod);
			this.Panel1.Controls.Add(this.lblInvDate);
			this.Panel1.Controls.Add(this.lblInvNum);
			this.Panel1.Controls.Add(this.PanelStatus);
			this.Panel1.Controls.Add(this.Label3);
			this.Panel1.Controls.Add(this.Label2);
			this.Panel1.Controls.Add(this.Label1);
			this.Panel1.Controls.Add(this.txtInvoiceNumber);
			this.Panel1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.Panel1.Location = new global::System.Drawing.Point(0, 0);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new global::System.Drawing.Size(1476, 275);
			this.Panel1.TabIndex = 0;
			this.lblInvTime.AutoSize = true;
			this.lblInvTime.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblInvTime.Location = new global::System.Drawing.Point(986, 147);
			this.lblInvTime.Name = "lblInvTime";
			this.lblInvTime.Size = new global::System.Drawing.Size(39, 32);
			this.lblInvTime.TabIndex = 10;
			this.lblInvTime.Text = "...";
			this.lblInvTime.TextAlign = global::System.Drawing.ContentAlignment.TopRight;
			this.lblDoneBY.AutoSize = true;
			this.lblDoneBY.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblDoneBY.Location = new global::System.Drawing.Point(986, 103);
			this.lblDoneBY.Name = "lblDoneBY";
			this.lblDoneBY.Size = new global::System.Drawing.Size(39, 32);
			this.lblDoneBY.TabIndex = 9;
			this.lblDoneBY.Text = "...";
			this.lblDoneBY.TextAlign = global::System.Drawing.ContentAlignment.TopRight;
			this.lblInvTotal.AutoSize = true;
			this.lblInvTotal.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblInvTotal.Location = new global::System.Drawing.Point(986, 235);
			this.lblInvTotal.Name = "lblInvTotal";
			this.lblInvTotal.Size = new global::System.Drawing.Size(39, 32);
			this.lblInvTotal.TabIndex = 8;
			this.lblInvTotal.Text = "...";
			this.lblInvTotal.TextAlign = global::System.Drawing.ContentAlignment.TopRight;
			this.lblPayMethod.AutoSize = true;
			this.lblPayMethod.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblPayMethod.Location = new global::System.Drawing.Point(986, 192);
			this.lblPayMethod.Name = "lblPayMethod";
			this.lblPayMethod.Size = new global::System.Drawing.Size(39, 32);
			this.lblPayMethod.TabIndex = 7;
			this.lblPayMethod.Text = "...";
			this.lblPayMethod.TextAlign = global::System.Drawing.ContentAlignment.TopRight;
			this.lblInvDate.AutoSize = true;
			this.lblInvDate.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblInvDate.Location = new global::System.Drawing.Point(986, 52);
			this.lblInvDate.Name = "lblInvDate";
			this.lblInvDate.Size = new global::System.Drawing.Size(39, 32);
			this.lblInvDate.TabIndex = 6;
			this.lblInvDate.Text = "...";
			this.lblInvDate.TextAlign = global::System.Drawing.ContentAlignment.TopRight;
			this.lblInvNum.AutoSize = true;
			this.lblInvNum.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblInvNum.Location = new global::System.Drawing.Point(986, 11);
			this.lblInvNum.Name = "lblInvNum";
			this.lblInvNum.Size = new global::System.Drawing.Size(39, 32);
			this.lblInvNum.TabIndex = 5;
			this.lblInvNum.Text = "...";
			this.lblInvNum.TextAlign = global::System.Drawing.ContentAlignment.TopRight;
			this.PanelStatus.BackColor = global::System.Drawing.Color.White;
			this.PanelStatus.Controls.Add(this.Label4);
			this.PanelStatus.Controls.Add(this.lblStatus);
			this.PanelStatus.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.PanelStatus.Location = new global::System.Drawing.Point(1072, 0);
			this.PanelStatus.Name = "PanelStatus";
			this.PanelStatus.Size = new global::System.Drawing.Size(404, 275);
			this.PanelStatus.TabIndex = 4;
			this.Label4.AutoSize = true;
			this.Label4.BackColor = global::System.Drawing.Color.Red;
			this.Label4.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.Label4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label4.Location = new global::System.Drawing.Point(310, 0);
			this.Label4.Name = "Label4";
			this.Label4.Size = new global::System.Drawing.Size(94, 29);
			this.Label4.TabIndex = 6;
			this.Label4.Text = "CLOSE";
			this.Label4.TextAlign = global::System.Drawing.ContentAlignment.TopRight;
			this.lblStatus.AutoSize = true;
			this.lblStatus.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 18f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblStatus.Location = new global::System.Drawing.Point(81, 112);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new global::System.Drawing.Size(57, 40);
			this.lblStatus.TabIndex = 5;
			this.lblStatus.Text = "....";
			this.Label3.AutoSize = true;
			this.Label3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 18f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label3.Location = new global::System.Drawing.Point(3, 9);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(471, 40);
			this.Label3.TabIndex = 3;
			this.Label3.Text = "CHECK INVOICE STATUS";
			this.Label2.AutoSize = true;
			this.Label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Italic, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label2.Location = new global::System.Drawing.Point(3, 120);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(633, 29);
			this.Label2.TabIndex = 2;
			this.Label2.Text = "(alternatively type receipt/invoice number and press Enter)";
			this.Label1.AutoSize = true;
			this.Label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 18f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label1.Location = new global::System.Drawing.Point(11, 71);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(109, 40);
			this.Label1.TabIndex = 1;
			this.Label1.Text = "Scan:";
			this.txtInvoiceNumber.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 20f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtInvoiceNumber.Location = new global::System.Drawing.Point(126, 64);
			this.txtInvoiceNumber.Name = "txtInvoiceNumber";
			this.txtInvoiceNumber.Size = new global::System.Drawing.Size(392, 53);
			this.txtInvoiceNumber.TabIndex = 0;
			this.Panel2.Controls.Add(this.dgvInvoices);
			this.Panel2.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.Panel2.Location = new global::System.Drawing.Point(0, 275);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new global::System.Drawing.Size(1476, 384);
			this.Panel2.TabIndex = 3;
			this.dgvInvoices.AllowUserToAddRows = false;
			this.dgvInvoices.AllowUserToDeleteRows = false;
			this.dgvInvoices.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvInvoices.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dgvInvoices.Location = new global::System.Drawing.Point(0, 0);
			this.dgvInvoices.Name = "dgvInvoices";
			this.dgvInvoices.ReadOnly = true;
			this.dgvInvoices.RowTemplate.Height = 28;
			this.dgvInvoices.Size = new global::System.Drawing.Size(1476, 384);
			this.dgvInvoices.TabIndex = 0;
			this.lblinfo.AutoSize = true;
			this.lblinfo.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.lblinfo.Location = new global::System.Drawing.Point(0, 255);
			this.lblinfo.Name = "lblinfo";
			this.lblinfo.Size = new global::System.Drawing.Size(21, 20);
			this.lblinfo.TabIndex = 11;
			this.lblinfo.Text = "...";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.Controls.Add(this.Panel2);
			base.Controls.Add(this.Panel1);
			base.Name = "InvoiceCheck";
			base.Size = new global::System.Drawing.Size(1476, 659);
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.PanelStatus.ResumeLayout(false);
			this.PanelStatus.PerformLayout();
			this.Panel2.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.dgvInvoices).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000AE6 RID: 2790
		private global::System.ComponentModel.IContainer components;
	}
}
