namespace PointOfSale
{
	// Token: 0x0200017E RID: 382
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Quotations_Invoices_Report : global::System.Windows.Forms.UserControl
	{
		// Token: 0x06003834 RID: 14388 RVA: 0x001E9910 File Offset: 0x001E7B10
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

		// Token: 0x06003835 RID: 14389 RVA: 0x001E9960 File Offset: 0x001E7B60
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.chkAllUsers = new global::System.Windows.Forms.CheckBox();
			this.cboUsers = new global::System.Windows.Forms.ComboBox();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.Button2 = new global::System.Windows.Forms.Button();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.cboBranch = new global::System.Windows.Forms.ComboBox();
			this.Label8 = new global::System.Windows.Forms.Label();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.DTend = new global::System.Windows.Forms.DateTimePicker();
			this.DTstart = new global::System.Windows.Forms.DateTimePicker();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.dgvTrans = new global::System.Windows.Forms.DataGridView();
			this.SaveFileDialog1 = new global::System.Windows.Forms.SaveFileDialog();
			this.Label5 = new global::System.Windows.Forms.Label();
			this.GroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvTrans).BeginInit();
			base.SuspendLayout();
			this.GroupBox1.Controls.Add(this.Label5);
			this.GroupBox1.Controls.Add(this.chkAllUsers);
			this.GroupBox1.Controls.Add(this.cboUsers);
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Controls.Add(this.Button2);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Controls.Add(this.cboBranch);
			this.GroupBox1.Controls.Add(this.Label8);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.DTend);
			this.GroupBox1.Controls.Add(this.DTstart);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new global::System.Drawing.Size(1300, 202);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.chkAllUsers.AutoSize = true;
			this.chkAllUsers.Location = new global::System.Drawing.Point(1014, 120);
			this.chkAllUsers.Name = "chkAllUsers";
			this.chkAllUsers.Size = new global::System.Drawing.Size(107, 24);
			this.chkAllUsers.TabIndex = 45;
			this.chkAllUsers.Text = "All Users?";
			this.chkAllUsers.UseVisualStyleBackColor = true;
			this.cboUsers.FormattingEnabled = true;
			this.cboUsers.Location = new global::System.Drawing.Point(709, 119);
			this.cboUsers.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cboUsers.Name = "cboUsers";
			this.cboUsers.Size = new global::System.Drawing.Size(298, 28);
			this.cboUsers.TabIndex = 44;
			this.Label4.AutoSize = true;
			this.Label4.Location = new global::System.Drawing.Point(604, 123);
			this.Label4.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label4.Name = "Label4";
			this.Label4.Size = new global::System.Drawing.Size(96, 20);
			this.Label4.TabIndex = 43;
			this.Label4.Text = "Select User:";
			this.Button2.Location = new global::System.Drawing.Point(709, 155);
			this.Button2.Name = "Button2";
			this.Button2.Size = new global::System.Drawing.Size(190, 28);
			this.Button2.TabIndex = 42;
			this.Button2.Text = "EXPORT TO EXCEL";
			this.Button2.UseVisualStyleBackColor = true;
			this.Label2.AutoSize = true;
			this.Label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label2.Location = new global::System.Drawing.Point(152, 22);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(565, 32);
			this.Label2.TabIndex = 41;
			this.Label2.Text = "Quotations Converted to Invoices Report";
			this.Button1.Location = new global::System.Drawing.Point(156, 155);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(193, 28);
			this.Button1.TabIndex = 40;
			this.Button1.Text = "RUN REPORT";
			this.Button1.UseVisualStyleBackColor = true;
			this.cboBranch.FormattingEnabled = true;
			this.cboBranch.Location = new global::System.Drawing.Point(156, 119);
			this.cboBranch.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cboBranch.Name = "cboBranch";
			this.cboBranch.Size = new global::System.Drawing.Size(298, 28);
			this.cboBranch.TabIndex = 39;
			this.Label8.AutoSize = true;
			this.Label8.Location = new global::System.Drawing.Point(81, 123);
			this.Label8.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label8.Name = "Label8";
			this.Label8.Size = new global::System.Drawing.Size(64, 20);
			this.Label8.TabIndex = 38;
			this.Label8.Text = "Branch:";
			this.Label3.AutoSize = true;
			this.Label3.Location = new global::System.Drawing.Point(617, 82);
			this.Label3.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(81, 20);
			this.Label3.TabIndex = 37;
			this.Label3.Text = "End Date:";
			this.DTend.Location = new global::System.Drawing.Point(709, 77);
			this.DTend.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.DTend.Name = "DTend";
			this.DTend.Size = new global::System.Drawing.Size(298, 26);
			this.DTend.TabIndex = 36;
			this.DTstart.Location = new global::System.Drawing.Point(156, 74);
			this.DTstart.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.DTstart.Name = "DTstart";
			this.DTstart.Size = new global::System.Drawing.Size(298, 26);
			this.DTstart.TabIndex = 35;
			this.Label1.AutoSize = true;
			this.Label1.Location = new global::System.Drawing.Point(60, 77);
			this.Label1.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(87, 20);
			this.Label1.TabIndex = 34;
			this.Label1.Text = "Start Date:";
			this.dgvTrans.AllowUserToAddRows = false;
			this.dgvTrans.AllowUserToDeleteRows = false;
			this.dgvTrans.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvTrans.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dgvTrans.Location = new global::System.Drawing.Point(0, 202);
			this.dgvTrans.Name = "dgvTrans";
			this.dgvTrans.ReadOnly = true;
			this.dgvTrans.RowTemplate.Height = 28;
			this.dgvTrans.Size = new global::System.Drawing.Size(1300, 565);
			this.dgvTrans.TabIndex = 1;
			this.Label5.AutoSize = true;
			this.Label5.BackColor = global::System.Drawing.Color.Red;
			this.Label5.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.Label5.Location = new global::System.Drawing.Point(1248, 22);
			this.Label5.Name = "Label5";
			this.Label5.Size = new global::System.Drawing.Size(49, 20);
			this.Label5.TabIndex = 46;
			this.Label5.Text = "Close";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.Controls.Add(this.dgvTrans);
			base.Controls.Add(this.GroupBox1);
			base.Name = "Quotations_Invoices_Report";
			base.Size = new global::System.Drawing.Size(1300, 767);
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvTrans).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x040017DA RID: 6106
		private global::System.ComponentModel.IContainer components;
	}
}
