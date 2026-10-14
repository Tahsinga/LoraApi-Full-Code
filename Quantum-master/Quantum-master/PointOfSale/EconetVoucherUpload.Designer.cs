namespace PointOfSale
{
	// Token: 0x02000048 RID: 72
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class EconetVoucherUpload : global::System.Windows.Forms.Form
	{
		// Token: 0x06000F74 RID: 3956 RVA: 0x000918E0 File Offset: 0x0008FAE0
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

		// Token: 0x06000F75 RID: 3957 RVA: 0x00091930 File Offset: 0x0008FB30
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.txtRate = new global::System.Windows.Forms.TextBox();
			this.Label6 = new global::System.Windows.Forms.Label();
			this.Label5 = new global::System.Windows.Forms.Label();
			this.cboCategories = new global::System.Windows.Forms.ComboBox();
			this.lblUpdate = new global::System.Windows.Forms.Label();
			this.txtRef = new global::System.Windows.Forms.TextBox();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.Button2 = new global::System.Windows.Forms.Button();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.cboBranch = new global::System.Windows.Forms.ComboBox();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.txtpath = new global::System.Windows.Forms.TextBox();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.OpenFileDialog1 = new global::System.Windows.Forms.OpenFileDialog();
			this.GroupBox1.SuspendLayout();
			base.SuspendLayout();
			this.GroupBox1.Controls.Add(this.txtRate);
			this.GroupBox1.Controls.Add(this.Label6);
			this.GroupBox1.Controls.Add(this.Label5);
			this.GroupBox1.Controls.Add(this.cboCategories);
			this.GroupBox1.Controls.Add(this.lblUpdate);
			this.GroupBox1.Controls.Add(this.txtRef);
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.Button2);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.cboBranch);
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Controls.Add(this.txtpath);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new global::System.Drawing.Size(747, 269);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.txtRate.Location = new global::System.Drawing.Point(228, 162);
			this.txtRate.Name = "txtRate";
			this.txtRate.Size = new global::System.Drawing.Size(85, 20);
			this.txtRate.TabIndex = 6;
			this.Label6.AutoSize = true;
			this.Label6.Location = new global::System.Drawing.Point(6, 165);
			this.Label6.Name = "Label6";
			this.Label6.Size = new global::System.Drawing.Size(225, 13);
			this.Label6.TabIndex = 12;
			this.Label6.Text = "Rate (to calculate base currency selling price):";
			this.Label5.AutoSize = true;
			this.Label5.Location = new global::System.Drawing.Point(65, 112);
			this.Label5.Name = "Label5";
			this.Label5.Size = new global::System.Drawing.Size(52, 13);
			this.Label5.TabIndex = 11;
			this.Label5.Text = "Category:";
			this.cboCategories.FormattingEnabled = true;
			this.cboCategories.Location = new global::System.Drawing.Point(131, 109);
			this.cboCategories.Name = "cboCategories";
			this.cboCategories.Size = new global::System.Drawing.Size(182, 21);
			this.cboCategories.TabIndex = 4;
			this.lblUpdate.AutoSize = true;
			this.lblUpdate.Location = new global::System.Drawing.Point(128, 242);
			this.lblUpdate.Name = "lblUpdate";
			this.lblUpdate.Size = new global::System.Drawing.Size(22, 13);
			this.lblUpdate.TabIndex = 9;
			this.lblUpdate.Text = ".....";
			this.txtRef.Location = new global::System.Drawing.Point(131, 136);
			this.txtRef.MaxLength = 50;
			this.txtRef.Name = "txtRef";
			this.txtRef.Size = new global::System.Drawing.Size(182, 20);
			this.txtRef.TabIndex = 5;
			this.Label4.AutoSize = true;
			this.Label4.Location = new global::System.Drawing.Point(65, 139);
			this.Label4.Name = "Label4";
			this.Label4.Size = new global::System.Drawing.Size(60, 13);
			this.Label4.TabIndex = 7;
			this.Label4.Text = "Reference:";
			this.Label3.AutoSize = true;
			this.Label3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label3.Location = new global::System.Drawing.Point(54, 16);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(285, 24);
			this.Label3.TabIndex = 6;
			this.Label3.Text = "Upload Econet Airtime Vouchers";
			this.Button2.BackColor = global::System.Drawing.Color.Lime;
			this.Button2.Location = new global::System.Drawing.Point(131, 216);
			this.Button2.Name = "Button2";
			this.Button2.Size = new global::System.Drawing.Size(182, 23);
			this.Button2.TabIndex = 7;
			this.Button2.Text = "SAVE VOUCHERS";
			this.Button2.UseVisualStyleBackColor = false;
			this.Label2.AutoSize = true;
			this.Label2.Location = new global::System.Drawing.Point(81, 85);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(44, 13);
			this.Label2.TabIndex = 4;
			this.Label2.Text = "Branch:";
			this.cboBranch.FormattingEnabled = true;
			this.cboBranch.Location = new global::System.Drawing.Point(131, 82);
			this.cboBranch.Name = "cboBranch";
			this.cboBranch.Size = new global::System.Drawing.Size(182, 21);
			this.cboBranch.TabIndex = 3;
			this.Button1.Location = new global::System.Drawing.Point(466, 54);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(137, 23);
			this.Button1.TabIndex = 2;
			this.Button1.Text = "Select Voucher File ";
			this.Button1.UseVisualStyleBackColor = true;
			this.txtpath.Location = new global::System.Drawing.Point(131, 56);
			this.txtpath.Name = "txtpath";
			this.txtpath.ReadOnly = true;
			this.txtpath.Size = new global::System.Drawing.Size(329, 20);
			this.txtpath.TabIndex = 1;
			this.Label1.AutoSize = true;
			this.Label1.Location = new global::System.Drawing.Point(54, 59);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(71, 13);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Fie to upload:";
			this.OpenFileDialog1.FileName = "OpenFileDialog1";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(747, 269);
			base.Controls.Add(this.GroupBox1);
			base.Name = "EconetVoucherUpload";
			this.Text = "Econet Voucher Upload";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04000764 RID: 1892
		private global::System.ComponentModel.IContainer components;
	}
}
