namespace PointOfSale
{
	// Token: 0x02000027 RID: 39
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class CollectionsByCustomer : global::System.Windows.Forms.Form
	{
		// Token: 0x06000768 RID: 1896 RVA: 0x0004A8F4 File Offset: 0x00048AF4
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

		// Token: 0x06000769 RID: 1897 RVA: 0x0004A944 File Offset: 0x00048B44
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.chkall = new global::System.Windows.Forms.CheckBox();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.Label18 = new global::System.Windows.Forms.Label();
			this.Button4 = new global::System.Windows.Forms.Button();
			this.cboCustomers = new global::System.Windows.Forms.ComboBox();
			this.GroupBox2 = new global::System.Windows.Forms.GroupBox();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.txtCollectedBy = new global::System.Windows.Forms.TextBox();
			this.Button2 = new global::System.Windows.Forms.Button();
			this.GroupBox3 = new global::System.Windows.Forms.GroupBox();
			this.dgvInvDetails = new global::System.Windows.Forms.DataGridView();
			this.GroupBox4 = new global::System.Windows.Forms.GroupBox();
			this.dgvInvoices = new global::System.Windows.Forms.DataGridView();
			this.txtComment = new global::System.Windows.Forms.TextBox();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.GroupBox1.SuspendLayout();
			this.GroupBox2.SuspendLayout();
			this.GroupBox3.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvInvDetails).BeginInit();
			this.GroupBox4.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvInvoices).BeginInit();
			base.SuspendLayout();
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Controls.Add(this.chkall);
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Controls.Add(this.Label18);
			this.GroupBox1.Controls.Add(this.Button4);
			this.GroupBox1.Controls.Add(this.cboCustomers);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new global::System.Drawing.Size(902, 110);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.Label1.AutoSize = true;
			this.Label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label1.Location = new global::System.Drawing.Point(6, 14);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(261, 20);
			this.Label1.TabIndex = 61;
			this.Label1.Text = "Enter Customer Product Collections";
			this.chkall.AutoSize = true;
			this.chkall.Location = new global::System.Drawing.Point(374, 80);
			this.chkall.Name = "chkall";
			this.chkall.Size = new global::System.Drawing.Size(160, 17);
			this.chkall.TabIndex = 60;
			this.chkall.Text = "View All Collections Invoices";
			this.chkall.UseVisualStyleBackColor = true;
			this.Button1.Location = new global::System.Drawing.Point(189, 76);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(179, 23);
			this.Button1.TabIndex = 59;
			this.Button1.Text = "Load Pending Collection/Delivery";
			this.Button1.UseVisualStyleBackColor = true;
			this.Label18.AutoSize = true;
			this.Label18.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label18.Location = new global::System.Drawing.Point(16, 48);
			this.Label18.Name = "Label18";
			this.Label18.Size = new global::System.Drawing.Size(167, 17);
			this.Label18.TabIndex = 57;
			this.Label18.Text = "Select Existing Customer:";
			this.Button4.Location = new global::System.Drawing.Point(535, 45);
			this.Button4.Name = "Button4";
			this.Button4.Size = new global::System.Drawing.Size(75, 23);
			this.Button4.TabIndex = 58;
			this.Button4.TabStop = false;
			this.Button4.Text = "Adv. Search";
			this.Button4.UseVisualStyleBackColor = true;
			this.cboCustomers.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.cboCustomers.FormattingEnabled = true;
			this.cboCustomers.Location = new global::System.Drawing.Point(189, 42);
			this.cboCustomers.Name = "cboCustomers";
			this.cboCustomers.Size = new global::System.Drawing.Size(338, 28);
			this.cboCustomers.TabIndex = 56;
			this.cboCustomers.TabStop = false;
			this.GroupBox2.Controls.Add(this.Label2);
			this.GroupBox2.Controls.Add(this.txtComment);
			this.GroupBox2.Controls.Add(this.Label3);
			this.GroupBox2.Controls.Add(this.txtCollectedBy);
			this.GroupBox2.Controls.Add(this.Button2);
			this.GroupBox2.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.GroupBox2.Location = new global::System.Drawing.Point(0, 360);
			this.GroupBox2.Name = "GroupBox2";
			this.GroupBox2.Size = new global::System.Drawing.Size(902, 100);
			this.GroupBox2.TabIndex = 1;
			this.GroupBox2.TabStop = false;
			this.GroupBox2.Text = "Record products collected/deliverd";
			this.Label3.AutoSize = true;
			this.Label3.Location = new global::System.Drawing.Point(103, 25);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(169, 13);
			this.Label3.TabIndex = 5;
			this.Label3.Text = "Goods Received in good order by:";
			this.txtCollectedBy.Location = new global::System.Drawing.Point(278, 22);
			this.txtCollectedBy.Name = "txtCollectedBy";
			this.txtCollectedBy.Size = new global::System.Drawing.Size(155, 20);
			this.txtCollectedBy.TabIndex = 4;
			this.Button2.BackColor = global::System.Drawing.Color.Lime;
			this.Button2.Location = new global::System.Drawing.Point(439, 22);
			this.Button2.Name = "Button2";
			this.Button2.Size = new global::System.Drawing.Size(200, 34);
			this.Button2.TabIndex = 3;
			this.Button2.Text = "SAVE COLLECTION/DELIVERY CHANGES";
			this.Button2.UseVisualStyleBackColor = false;
			this.GroupBox3.Controls.Add(this.dgvInvDetails);
			this.GroupBox3.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.GroupBox3.Location = new global::System.Drawing.Point(0, 192);
			this.GroupBox3.Name = "GroupBox3";
			this.GroupBox3.Size = new global::System.Drawing.Size(902, 168);
			this.GroupBox3.TabIndex = 2;
			this.GroupBox3.TabStop = false;
			this.GroupBox3.Text = "Invoice Items";
			this.dgvInvDetails.AllowUserToAddRows = false;
			this.dgvInvDetails.AllowUserToDeleteRows = false;
			this.dgvInvDetails.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvInvDetails.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dgvInvDetails.Location = new global::System.Drawing.Point(3, 16);
			this.dgvInvDetails.Name = "dgvInvDetails";
			this.dgvInvDetails.Size = new global::System.Drawing.Size(896, 149);
			this.dgvInvDetails.TabIndex = 0;
			this.GroupBox4.Controls.Add(this.dgvInvoices);
			this.GroupBox4.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.GroupBox4.Location = new global::System.Drawing.Point(0, 110);
			this.GroupBox4.Name = "GroupBox4";
			this.GroupBox4.Size = new global::System.Drawing.Size(902, 82);
			this.GroupBox4.TabIndex = 3;
			this.GroupBox4.TabStop = false;
			this.GroupBox4.Text = "Invoices";
			this.dgvInvoices.AllowUserToAddRows = false;
			this.dgvInvoices.AllowUserToDeleteRows = false;
			this.dgvInvoices.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvInvoices.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dgvInvoices.Location = new global::System.Drawing.Point(3, 16);
			this.dgvInvoices.Name = "dgvInvoices";
			this.dgvInvoices.ReadOnly = true;
			this.dgvInvoices.Size = new global::System.Drawing.Size(896, 63);
			this.dgvInvoices.TabIndex = 0;
			this.txtComment.Location = new global::System.Drawing.Point(278, 51);
			this.txtComment.Multiline = true;
			this.txtComment.Name = "txtComment";
			this.txtComment.Size = new global::System.Drawing.Size(155, 43);
			this.txtComment.TabIndex = 6;
			this.Label2.AutoSize = true;
			this.Label2.Location = new global::System.Drawing.Point(218, 51);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(54, 13);
			this.Label2.TabIndex = 7;
			this.Label2.Text = "Comment:";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(902, 460);
			base.Controls.Add(this.GroupBox4);
			base.Controls.Add(this.GroupBox3);
			base.Controls.Add(this.GroupBox2);
			base.Controls.Add(this.GroupBox1);
			base.Name = "CollectionsByCustomer";
			this.Text = "Collections By Customer";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.GroupBox2.ResumeLayout(false);
			this.GroupBox2.PerformLayout();
			this.GroupBox3.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.dgvInvDetails).EndInit();
			this.GroupBox4.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.dgvInvoices).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x0400037B RID: 891
		private global::System.ComponentModel.IContainer components;
	}
}
