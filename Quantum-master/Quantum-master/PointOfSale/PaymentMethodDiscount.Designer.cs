namespace PointOfSale
{
	// Token: 0x02000088 RID: 136
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class PaymentMethodDiscount : global::System.Windows.Forms.UserControl
	{
		// Token: 0x06001F16 RID: 7958 RVA: 0x001153FC File Offset: 0x001135FC
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

		// Token: 0x06001F17 RID: 7959 RVA: 0x0011544C File Offset: 0x0011364C
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.chkIsPercentage = new global::System.Windows.Forms.CheckBox();
			this.Label7 = new global::System.Windows.Forms.Label();
			this.Label6 = new global::System.Windows.Forms.Label();
			this.txtPrice = new global::System.Windows.Forms.TextBox();
			this.Label5 = new global::System.Windows.Forms.Label();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.cboBranch = new global::System.Windows.Forms.ComboBox();
			this.lblerror = new global::System.Windows.Forms.Label();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.txtDiscount = new global::System.Windows.Forms.TextBox();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.cboPaymentMethods = new global::System.Windows.Forms.ComboBox();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.lblDesc = new global::System.Windows.Forms.TextBox();
			this.GroupBox4 = new global::System.Windows.Forms.GroupBox();
			this.DGVSearch = new global::System.Windows.Forms.DataGridView();
			this.Panel1 = new global::System.Windows.Forms.Panel();
			this.Button3 = new global::System.Windows.Forms.Button();
			this.Label19 = new global::System.Windows.Forms.Label();
			this.txtsearch = new global::System.Windows.Forms.TextBox();
			this.dgvDiscounts = new global::System.Windows.Forms.DataGridView();
			this.GroupBox1.SuspendLayout();
			this.GroupBox4.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.DGVSearch).BeginInit();
			this.Panel1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvDiscounts).BeginInit();
			base.SuspendLayout();
			this.GroupBox1.Controls.Add(this.chkIsPercentage);
			this.GroupBox1.Controls.Add(this.Label7);
			this.GroupBox1.Controls.Add(this.Label6);
			this.GroupBox1.Controls.Add(this.txtPrice);
			this.GroupBox1.Controls.Add(this.Label5);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.cboBranch);
			this.GroupBox1.Controls.Add(this.lblerror);
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.txtDiscount);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Controls.Add(this.cboPaymentMethods);
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Controls.Add(this.lblDesc);
			this.GroupBox1.Controls.Add(this.GroupBox4);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new global::System.Drawing.Size(1020, 267);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.chkIsPercentage.AutoSize = true;
			this.chkIsPercentage.Location = new global::System.Drawing.Point(524, 200);
			this.chkIsPercentage.Name = "chkIsPercentage";
			this.chkIsPercentage.Size = new global::System.Drawing.Size(181, 17);
			this.chkIsPercentage.TabIndex = 16;
			this.chkIsPercentage.Text = "Discount Amount is Percentage?";
			this.chkIsPercentage.UseVisualStyleBackColor = true;
			this.Label7.AutoSize = true;
			this.Label7.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Italic, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label7.ForeColor = global::System.Drawing.Color.Red;
			this.Label7.Location = new global::System.Drawing.Point(637, 177);
			this.Label7.Name = "Label7";
			this.Label7.Size = new global::System.Drawing.Size(365, 13);
			this.Label7.TabIndex = 39;
			this.Label7.Text = "(*Negative -ve value will reduce price, Positive +ve value will increase price)";
			this.Label6.AutoSize = true;
			this.Label6.Location = new global::System.Drawing.Point(457, 123);
			this.Label6.Name = "Label6";
			this.Label6.Size = new global::System.Drawing.Size(61, 13);
			this.Label6.TabIndex = 38;
			this.Label6.Text = "Base Price:";
			this.txtPrice.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtPrice.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtPrice.ForeColor = global::System.Drawing.Color.Red;
			this.txtPrice.Location = new global::System.Drawing.Point(524, 117);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.ReadOnly = true;
			this.txtPrice.Size = new global::System.Drawing.Size(190, 24);
			this.txtPrice.TabIndex = 37;
			this.txtPrice.TabStop = false;
			this.Label5.AutoSize = true;
			this.Label5.BackColor = global::System.Drawing.Color.Red;
			this.Label5.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.Label5.Location = new global::System.Drawing.Point(984, 16);
			this.Label5.Name = "Label5";
			this.Label5.Size = new global::System.Drawing.Size(33, 13);
			this.Label5.TabIndex = 36;
			this.Label5.Text = "Close";
			this.Label3.AutoSize = true;
			this.Label3.Location = new global::System.Drawing.Point(442, 28);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(77, 13);
			this.Label3.TabIndex = 35;
			this.Label3.Text = "Select Branch:";
			this.cboBranch.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboBranch.FormattingEnabled = true;
			this.cboBranch.Location = new global::System.Drawing.Point(524, 24);
			this.cboBranch.Name = "cboBranch";
			this.cboBranch.Size = new global::System.Drawing.Size(190, 21);
			this.cboBranch.TabIndex = 13;
			this.lblerror.AutoSize = true;
			this.lblerror.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.lblerror.Location = new global::System.Drawing.Point(315, 251);
			this.lblerror.Name = "lblerror";
			this.lblerror.Size = new global::System.Drawing.Size(16, 13);
			this.lblerror.TabIndex = 33;
			this.lblerror.Text = "...";
			this.Button1.BackColor = global::System.Drawing.Color.Lime;
			this.Button1.Location = new global::System.Drawing.Point(524, 223);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(107, 23);
			this.Button1.TabIndex = 17;
			this.Button1.Text = "Set Discount";
			this.Button1.UseVisualStyleBackColor = false;
			this.Label2.AutoSize = true;
			this.Label2.Location = new global::System.Drawing.Point(428, 177);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(91, 13);
			this.Label2.TabIndex = 28;
			this.Label2.Text = "Discount Amount:";
			this.txtDiscount.Location = new global::System.Drawing.Point(524, 174);
			this.txtDiscount.Name = "txtDiscount";
			this.txtDiscount.Size = new global::System.Drawing.Size(107, 20);
			this.txtDiscount.TabIndex = 27;
			this.Label1.AutoSize = true;
			this.Label1.Location = new global::System.Drawing.Point(326, 155);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(193, 13);
			this.Label1.TabIndex = 26;
			this.Label1.Text = "Payment Method Required for Discount";
			this.cboPaymentMethods.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboPaymentMethods.FormattingEnabled = true;
			this.cboPaymentMethods.Location = new global::System.Drawing.Point(524, 147);
			this.cboPaymentMethods.Name = "cboPaymentMethods";
			this.cboPaymentMethods.Size = new global::System.Drawing.Size(190, 21);
			this.cboPaymentMethods.TabIndex = 14;
			this.Label4.AutoSize = true;
			this.Label4.Location = new global::System.Drawing.Point(455, 57);
			this.Label4.Name = "Label4";
			this.Label4.Size = new global::System.Drawing.Size(63, 13);
			this.Label4.TabIndex = 24;
			this.Label4.Text = "Description:";
			this.lblDesc.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblDesc.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblDesc.ForeColor = global::System.Drawing.Color.Red;
			this.lblDesc.Location = new global::System.Drawing.Point(524, 51);
			this.lblDesc.Multiline = true;
			this.lblDesc.Name = "lblDesc";
			this.lblDesc.ReadOnly = true;
			this.lblDesc.Size = new global::System.Drawing.Size(430, 60);
			this.lblDesc.TabIndex = 23;
			this.lblDesc.TabStop = false;
			this.GroupBox4.Controls.Add(this.DGVSearch);
			this.GroupBox4.Controls.Add(this.Panel1);
			this.GroupBox4.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.GroupBox4.Location = new global::System.Drawing.Point(3, 16);
			this.GroupBox4.Name = "GroupBox4";
			this.GroupBox4.Size = new global::System.Drawing.Size(312, 248);
			this.GroupBox4.TabIndex = 21;
			this.GroupBox4.TabStop = false;
			this.DGVSearch.AllowUserToAddRows = false;
			this.DGVSearch.AllowUserToDeleteRows = false;
			this.DGVSearch.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DGVSearch.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.DGVSearch.Location = new global::System.Drawing.Point(3, 80);
			this.DGVSearch.Name = "DGVSearch";
			this.DGVSearch.ReadOnly = true;
			this.DGVSearch.Size = new global::System.Drawing.Size(306, 165);
			this.DGVSearch.TabIndex = 12;
			this.Panel1.Controls.Add(this.Button3);
			this.Panel1.Controls.Add(this.Label19);
			this.Panel1.Controls.Add(this.txtsearch);
			this.Panel1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.Panel1.Location = new global::System.Drawing.Point(3, 16);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new global::System.Drawing.Size(306, 64);
			this.Panel1.TabIndex = 11;
			this.Button3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Button3.Location = new global::System.Drawing.Point(230, 26);
			this.Button3.Name = "Button3";
			this.Button3.Size = new global::System.Drawing.Size(75, 31);
			this.Button3.TabIndex = 13;
			this.Button3.TabStop = false;
			this.Button3.Text = "Show All";
			this.Button3.UseVisualStyleBackColor = true;
			this.Label19.AutoSize = true;
			this.Label19.Location = new global::System.Drawing.Point(2, 7);
			this.Label19.Name = "Label19";
			this.Label19.Size = new global::System.Drawing.Size(249, 13);
			this.Label19.TabIndex = 12;
			this.Label19.Text = "Type in the space to search by product description:";
			this.txtsearch.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtsearch.Location = new global::System.Drawing.Point(5, 28);
			this.txtsearch.Name = "txtsearch";
			this.txtsearch.Size = new global::System.Drawing.Size(219, 29);
			this.txtsearch.TabIndex = 11;
			this.dgvDiscounts.AllowUserToAddRows = false;
			this.dgvDiscounts.AllowUserToDeleteRows = false;
			this.dgvDiscounts.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDiscounts.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dgvDiscounts.Location = new global::System.Drawing.Point(0, 267);
			this.dgvDiscounts.Name = "dgvDiscounts";
			this.dgvDiscounts.ReadOnly = true;
			this.dgvDiscounts.Size = new global::System.Drawing.Size(1020, 293);
			this.dgvDiscounts.TabIndex = 1;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.Controls.Add(this.dgvDiscounts);
			base.Controls.Add(this.GroupBox1);
			base.Name = "PaymentMethodDiscount";
			base.Size = new global::System.Drawing.Size(1020, 560);
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.GroupBox4.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.DGVSearch).EndInit();
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvDiscounts).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000EC5 RID: 3781
		private global::System.ComponentModel.IContainer components;
	}
}
