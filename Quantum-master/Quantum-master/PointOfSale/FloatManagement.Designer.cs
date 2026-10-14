namespace PointOfSale
{
	// Token: 0x0200005B RID: 91
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class FloatManagement : global::System.Windows.Forms.Form
	{
		// Token: 0x060012FC RID: 4860 RVA: 0x000B5270 File Offset: 0x000B3470
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

		// Token: 0x060012FD RID: 4861 RVA: 0x000B52C0 File Offset: 0x000B34C0
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.Label14 = new global::System.Windows.Forms.Label();
			this.cboBranches = new global::System.Windows.Forms.ComboBox();
			this.Label10 = new global::System.Windows.Forms.Label();
			this.dtTranDate = new global::System.Windows.Forms.DateTimePicker();
			this.Panel1 = new global::System.Windows.Forms.Panel();
			this.chkAll = new global::System.Windows.Forms.CheckBox();
			this.Label7 = new global::System.Windows.Forms.Label();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.Label5 = new global::System.Windows.Forms.Label();
			this.DTEndDate = new global::System.Windows.Forms.DateTimePicker();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.DTStartDate = new global::System.Windows.Forms.DateTimePicker();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.cboTeller = new global::System.Windows.Forms.ComboBox();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.Label13 = new global::System.Windows.Forms.Label();
			this.cboTranType = new global::System.Windows.Forms.ComboBox();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.txtComment = new global::System.Windows.Forms.TextBox();
			this.Button2 = new global::System.Windows.Forms.Button();
			this.lblEffectiveAmtPaid = new global::System.Windows.Forms.Label();
			this.Label12 = new global::System.Windows.Forms.Label();
			this.txtAmtPaid = new global::System.Windows.Forms.TextBox();
			this.Label11 = new global::System.Windows.Forms.Label();
			this.lblRate = new global::System.Windows.Forms.Label();
			this.Label9 = new global::System.Windows.Forms.Label();
			this.cboPaymentMethods = new global::System.Windows.Forms.ComboBox();
			this.Label8 = new global::System.Windows.Forms.Label();
			this.GroupBox2 = new global::System.Windows.Forms.GroupBox();
			this.dgvFloat = new global::System.Windows.Forms.DataGridView();
			this.GroupBox1.SuspendLayout();
			this.Panel1.SuspendLayout();
			this.GroupBox2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvFloat).BeginInit();
			base.SuspendLayout();
			this.GroupBox1.Controls.Add(this.Label14);
			this.GroupBox1.Controls.Add(this.cboBranches);
			this.GroupBox1.Controls.Add(this.Label10);
			this.GroupBox1.Controls.Add(this.dtTranDate);
			this.GroupBox1.Controls.Add(this.Panel1);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.cboTeller);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Controls.Add(this.Label13);
			this.GroupBox1.Controls.Add(this.cboTranType);
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Controls.Add(this.txtComment);
			this.GroupBox1.Controls.Add(this.Button2);
			this.GroupBox1.Controls.Add(this.lblEffectiveAmtPaid);
			this.GroupBox1.Controls.Add(this.Label12);
			this.GroupBox1.Controls.Add(this.txtAmtPaid);
			this.GroupBox1.Controls.Add(this.Label11);
			this.GroupBox1.Controls.Add(this.lblRate);
			this.GroupBox1.Controls.Add(this.Label9);
			this.GroupBox1.Controls.Add(this.cboPaymentMethods);
			this.GroupBox1.Controls.Add(this.Label8);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new global::System.Drawing.Size(912, 311);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.Label14.AutoSize = true;
			this.Label14.Location = new global::System.Drawing.Point(125, 71);
			this.Label14.Name = "Label14";
			this.Label14.Size = new global::System.Drawing.Size(44, 13);
			this.Label14.TabIndex = 62;
			this.Label14.Text = "Branch:";
			this.cboBranches.FormattingEnabled = true;
			this.cboBranches.Location = new global::System.Drawing.Point(175, 66);
			this.cboBranches.Name = "cboBranches";
			this.cboBranches.Size = new global::System.Drawing.Size(200, 21);
			this.cboBranches.TabIndex = 61;
			this.Label10.AutoSize = true;
			this.Label10.Location = new global::System.Drawing.Point(77, 97);
			this.Label10.Name = "Label10";
			this.Label10.Size = new global::System.Drawing.Size(92, 13);
			this.Label10.TabIndex = 60;
			this.Label10.Text = "Transaction Date:";
			this.dtTranDate.Location = new global::System.Drawing.Point(175, 93);
			this.dtTranDate.Name = "dtTranDate";
			this.dtTranDate.Size = new global::System.Drawing.Size(200, 20);
			this.dtTranDate.TabIndex = 59;
			this.Panel1.Controls.Add(this.chkAll);
			this.Panel1.Controls.Add(this.Label7);
			this.Panel1.Controls.Add(this.Button1);
			this.Panel1.Controls.Add(this.Label5);
			this.Panel1.Controls.Add(this.DTEndDate);
			this.Panel1.Controls.Add(this.Label3);
			this.Panel1.Controls.Add(this.DTStartDate);
			this.Panel1.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.Panel1.Location = new global::System.Drawing.Point(579, 16);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new global::System.Drawing.Size(330, 292);
			this.Panel1.TabIndex = 57;
			this.chkAll.AutoSize = true;
			this.chkAll.Location = new global::System.Drawing.Point(114, 238);
			this.chkAll.Name = "chkAll";
			this.chkAll.Size = new global::System.Drawing.Size(165, 17);
			this.chkAll.TabIndex = 59;
			this.chkAll.Text = "Include Deleted Transactions";
			this.chkAll.UseVisualStyleBackColor = true;
			this.Label7.AutoSize = true;
			this.Label7.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label7.Location = new global::System.Drawing.Point(38, 100);
			this.Label7.Name = "Label7";
			this.Label7.Size = new global::System.Drawing.Size(277, 24);
			this.Label7.TabIndex = 58;
			this.Label7.Text = "VIEW FLOAT TRANSACTIONS";
			this.Button1.BackColor = global::System.Drawing.Color.Lime;
			this.Button1.Location = new global::System.Drawing.Point(112, 192);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(200, 34);
			this.Button1.TabIndex = 10;
			this.Button1.Text = "VIEW FLOAT TRANSACTIONS FOR PERIOD";
			this.Button1.UseVisualStyleBackColor = false;
			this.Label5.AutoSize = true;
			this.Label5.Location = new global::System.Drawing.Point(48, 170);
			this.Label5.Name = "Label5";
			this.Label5.Size = new global::System.Drawing.Size(55, 13);
			this.Label5.TabIndex = 9;
			this.Label5.Text = "End Date:";
			this.DTEndDate.Location = new global::System.Drawing.Point(112, 166);
			this.DTEndDate.Name = "DTEndDate";
			this.DTEndDate.Size = new global::System.Drawing.Size(200, 20);
			this.DTEndDate.TabIndex = 8;
			this.Label3.AutoSize = true;
			this.Label3.Location = new global::System.Drawing.Point(48, 144);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(58, 13);
			this.Label3.TabIndex = 7;
			this.Label3.Text = "Start Date:";
			this.DTStartDate.Location = new global::System.Drawing.Point(112, 140);
			this.DTStartDate.Name = "DTStartDate";
			this.DTStartDate.Size = new global::System.Drawing.Size(200, 20);
			this.DTStartDate.TabIndex = 1;
			this.Label2.AutoSize = true;
			this.Label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label2.Location = new global::System.Drawing.Point(51, 25);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(425, 24);
			this.Label2.TabIndex = 56;
			this.Label2.Text = "ENTER FLOAT MANAGEMENT TRANSACTION";
			this.cboTeller.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboTeller.FormattingEnabled = true;
			this.cboTeller.Location = new global::System.Drawing.Point(175, 146);
			this.cboTeller.Name = "cboTeller";
			this.cboTeller.Size = new global::System.Drawing.Size(200, 21);
			this.cboTeller.TabIndex = 55;
			this.Label1.AutoSize = true;
			this.Label1.Location = new global::System.Drawing.Point(81, 149);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(78, 13);
			this.Label1.TabIndex = 54;
			this.Label1.Text = "TILL/TELLER:";
			this.Label13.AutoSize = true;
			this.Label13.Location = new global::System.Drawing.Point(51, 122);
			this.Label13.Name = "Label13";
			this.Label13.Size = new global::System.Drawing.Size(118, 13);
			this.Label13.TabIndex = 53;
			this.Label13.Text = "TRANSACTION TYPE:";
			this.cboTranType.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboTranType.FormattingEnabled = true;
			this.cboTranType.Items.AddRange(new object[] { "FLOAT COLLECTION", "NEW FLOAT IN" });
			this.cboTranType.Location = new global::System.Drawing.Point(175, 119);
			this.cboTranType.Name = "cboTranType";
			this.cboTranType.Size = new global::System.Drawing.Size(200, 21);
			this.cboTranType.TabIndex = 52;
			this.Label4.AutoSize = true;
			this.Label4.Location = new global::System.Drawing.Point(115, 261);
			this.Label4.Name = "Label4";
			this.Label4.Size = new global::System.Drawing.Size(54, 13);
			this.Label4.TabIndex = 51;
			this.Label4.Text = "Comment:";
			this.txtComment.Location = new global::System.Drawing.Point(175, 258);
			this.txtComment.Name = "txtComment";
			this.txtComment.Size = new global::System.Drawing.Size(301, 20);
			this.txtComment.TabIndex = 47;
			this.Button2.BackColor = global::System.Drawing.Color.Lime;
			this.Button2.Location = new global::System.Drawing.Point(175, 281);
			this.Button2.Name = "Button2";
			this.Button2.Size = new global::System.Drawing.Size(200, 23);
			this.Button2.TabIndex = 49;
			this.Button2.Text = "ACCEPT PAYMENT";
			this.Button2.UseVisualStyleBackColor = false;
			this.lblEffectiveAmtPaid.AutoSize = true;
			this.lblEffectiveAmtPaid.Location = new global::System.Drawing.Point(175, 232);
			this.lblEffectiveAmtPaid.Name = "lblEffectiveAmtPaid";
			this.lblEffectiveAmtPaid.Size = new global::System.Drawing.Size(22, 13);
			this.lblEffectiveAmtPaid.TabIndex = 50;
			this.lblEffectiveAmtPaid.Text = ".....";
			this.Label12.AutoSize = true;
			this.Label12.Location = new global::System.Drawing.Point(6, 232);
			this.Label12.Name = "Label12";
			this.Label12.Size = new global::System.Drawing.Size(163, 13);
			this.Label12.TabIndex = 48;
			this.Label12.Text = "Effective Base Currency Amount:";
			this.txtAmtPaid.Location = new global::System.Drawing.Point(175, 202);
			this.txtAmtPaid.Name = "txtAmtPaid";
			this.txtAmtPaid.Size = new global::System.Drawing.Size(100, 20);
			this.txtAmtPaid.TabIndex = 46;
			this.Label11.AutoSize = true;
			this.Label11.Location = new global::System.Drawing.Point(123, 205);
			this.Label11.Name = "Label11";
			this.Label11.Size = new global::System.Drawing.Size(46, 13);
			this.Label11.TabIndex = 44;
			this.Label11.Text = "Amount:";
			this.lblRate.AutoSize = true;
			this.lblRate.Location = new global::System.Drawing.Point(417, 183);
			this.lblRate.Name = "lblRate";
			this.lblRate.Size = new global::System.Drawing.Size(0, 13);
			this.lblRate.TabIndex = 43;
			this.Label9.AutoSize = true;
			this.Label9.Location = new global::System.Drawing.Point(378, 178);
			this.Label9.Name = "Label9";
			this.Label9.Size = new global::System.Drawing.Size(33, 13);
			this.Label9.TabIndex = 42;
			this.Label9.Text = "Rate:";
			this.cboPaymentMethods.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboPaymentMethods.FormattingEnabled = true;
			this.cboPaymentMethods.Location = new global::System.Drawing.Point(175, 175);
			this.cboPaymentMethods.Name = "cboPaymentMethods";
			this.cboPaymentMethods.Size = new global::System.Drawing.Size(200, 21);
			this.cboPaymentMethods.TabIndex = 45;
			this.Label8.AutoSize = true;
			this.Label8.Location = new global::System.Drawing.Point(46, 178);
			this.Label8.Name = "Label8";
			this.Label8.Size = new global::System.Drawing.Size(123, 13);
			this.Label8.TabIndex = 41;
			this.Label8.Text = "Select Payment Method:";
			this.GroupBox2.Controls.Add(this.dgvFloat);
			this.GroupBox2.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.GroupBox2.Location = new global::System.Drawing.Point(0, 311);
			this.GroupBox2.Name = "GroupBox2";
			this.GroupBox2.Size = new global::System.Drawing.Size(912, 158);
			this.GroupBox2.TabIndex = 1;
			this.GroupBox2.TabStop = false;
			this.dgvFloat.AllowUserToAddRows = false;
			this.dgvFloat.AllowUserToDeleteRows = false;
			this.dgvFloat.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvFloat.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dgvFloat.Location = new global::System.Drawing.Point(3, 16);
			this.dgvFloat.Name = "dgvFloat";
			this.dgvFloat.ReadOnly = true;
			this.dgvFloat.Size = new global::System.Drawing.Size(906, 139);
			this.dgvFloat.TabIndex = 2;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(912, 469);
			base.Controls.Add(this.GroupBox2);
			base.Controls.Add(this.GroupBox1);
			base.Name = "FloatManagement";
			this.Text = "Float Management";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.GroupBox2.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.dgvFloat).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x040008E7 RID: 2279
		private global::System.ComponentModel.IContainer components;
	}
}
