namespace PointOfSale
{
	// Token: 0x02000046 RID: 70
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class EcocashDetails : global::System.Windows.Forms.Form
	{
		// Token: 0x06000F21 RID: 3873 RVA: 0x0008F990 File Offset: 0x0008DB90
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

		// Token: 0x06000F22 RID: 3874 RVA: 0x0008F9E0 File Offset: 0x0008DBE0
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.dgvAmts = new global::System.Windows.Forms.DataGridView();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.txtName = new global::System.Windows.Forms.TextBox();
			this.txtMobile = new global::System.Windows.Forms.TextBox();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.txtTranCode = new global::System.Windows.Forms.TextBox();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.txtAmount = new global::System.Windows.Forms.TextBox();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.FullName = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Mobile = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Ref = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Amount = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.Label5 = new global::System.Windows.Forms.Label();
			this.lblexpected = new global::System.Windows.Forms.Label();
			this.lblactual = new global::System.Windows.Forms.Label();
			this.Label8 = new global::System.Windows.Forms.Label();
			this.Button2 = new global::System.Windows.Forms.Button();
			this.GroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvAmts).BeginInit();
			base.SuspendLayout();
			this.GroupBox1.Controls.Add(this.Button2);
			this.GroupBox1.Controls.Add(this.lblactual);
			this.GroupBox1.Controls.Add(this.Label8);
			this.GroupBox1.Controls.Add(this.lblexpected);
			this.GroupBox1.Controls.Add(this.Label5);
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Controls.Add(this.txtAmount);
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Controls.Add(this.txtTranCode);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.txtMobile);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.txtName);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new global::System.Drawing.Size(656, 196);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Persons Details";
			this.dgvAmts.AllowUserToAddRows = false;
			this.dgvAmts.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAmts.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[] { this.FullName, this.Mobile, this.Ref, this.Amount });
			this.dgvAmts.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dgvAmts.Location = new global::System.Drawing.Point(0, 196);
			this.dgvAmts.Name = "dgvAmts";
			this.dgvAmts.ReadOnly = true;
			this.dgvAmts.Size = new global::System.Drawing.Size(656, 150);
			this.dgvAmts.TabIndex = 1;
			this.Label1.AutoSize = true;
			this.Label1.Location = new global::System.Drawing.Point(58, 33);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(57, 13);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Full Name:";
			this.txtName.Location = new global::System.Drawing.Point(121, 30);
			this.txtName.Name = "txtName";
			this.txtName.Size = new global::System.Drawing.Size(171, 20);
			this.txtName.TabIndex = 1;
			this.txtMobile.Location = new global::System.Drawing.Point(121, 56);
			this.txtMobile.Name = "txtMobile";
			this.txtMobile.Size = new global::System.Drawing.Size(171, 20);
			this.txtMobile.TabIndex = 3;
			this.txtMobile.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Right;
			this.Label2.AutoSize = true;
			this.Label2.Location = new global::System.Drawing.Point(34, 59);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(81, 13);
			this.Label2.TabIndex = 2;
			this.Label2.Text = "Mobile Number:";
			this.txtTranCode.Location = new global::System.Drawing.Point(121, 82);
			this.txtTranCode.Name = "txtTranCode";
			this.txtTranCode.Size = new global::System.Drawing.Size(100, 20);
			this.txtTranCode.TabIndex = 5;
			this.Label3.AutoSize = true;
			this.Label3.Location = new global::System.Drawing.Point(55, 85);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(60, 13);
			this.Label3.TabIndex = 4;
			this.Label3.Text = "Reference:";
			this.txtAmount.Location = new global::System.Drawing.Point(121, 108);
			this.txtAmount.Name = "txtAmount";
			this.txtAmount.Size = new global::System.Drawing.Size(100, 20);
			this.txtAmount.TabIndex = 7;
			this.Label4.AutoSize = true;
			this.Label4.Location = new global::System.Drawing.Point(69, 111);
			this.Label4.Name = "Label4";
			this.Label4.Size = new global::System.Drawing.Size(46, 13);
			this.Label4.TabIndex = 6;
			this.Label4.Text = "Amount:";
			this.FullName.HeaderText = "Full Name";
			this.FullName.Name = "FullName";
			this.Mobile.HeaderText = "Mobile Number";
			this.Mobile.Name = "Mobile";
			this.Ref.HeaderText = "Transaction Code";
			this.Ref.Name = "Ref";
			this.Amount.HeaderText = "Amount";
			this.Amount.Name = "Amount";
			this.Button1.Location = new global::System.Drawing.Point(121, 134);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(75, 23);
			this.Button1.TabIndex = 8;
			this.Button1.Text = "Add";
			this.Button1.UseVisualStyleBackColor = true;
			this.Label5.AutoSize = true;
			this.Label5.Location = new global::System.Drawing.Point(389, 33);
			this.Label5.Name = "Label5";
			this.Label5.Size = new global::System.Drawing.Size(137, 13);
			this.Label5.TabIndex = 9;
			this.Label5.Text = "Ecocash amount expected:";
			this.lblexpected.AutoSize = true;
			this.lblexpected.Location = new global::System.Drawing.Point(532, 33);
			this.lblexpected.Name = "lblexpected";
			this.lblexpected.Size = new global::System.Drawing.Size(16, 13);
			this.lblexpected.TabIndex = 10;
			this.lblexpected.Text = "...";
			this.lblactual.AutoSize = true;
			this.lblactual.Location = new global::System.Drawing.Point(532, 63);
			this.lblactual.Name = "lblactual";
			this.lblactual.Size = new global::System.Drawing.Size(16, 13);
			this.lblactual.TabIndex = 12;
			this.lblactual.Text = "...";
			this.Label8.AutoSize = true;
			this.Label8.Location = new global::System.Drawing.Point(397, 63);
			this.Label8.Name = "Label8";
			this.Label8.Size = new global::System.Drawing.Size(129, 13);
			this.Label8.TabIndex = 11;
			this.Label8.Text = "Ecocash amount entered:";
			this.Button2.Location = new global::System.Drawing.Point(121, 163);
			this.Button2.Name = "Button2";
			this.Button2.Size = new global::System.Drawing.Size(75, 23);
			this.Button2.TabIndex = 13;
			this.Button2.TabStop = false;
			this.Button2.Text = "Submit";
			this.Button2.UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(656, 346);
			base.Controls.Add(this.dgvAmts);
			base.Controls.Add(this.GroupBox1);
			base.Name = "EcocashDetails";
			this.Text = "Ecocash Details";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvAmts).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x0400073D RID: 1853
		private global::System.ComponentModel.IContainer components;
	}
}
