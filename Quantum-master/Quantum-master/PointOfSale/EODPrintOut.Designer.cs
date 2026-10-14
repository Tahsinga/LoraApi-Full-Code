namespace PointOfSale
{
	// Token: 0x02000056 RID: 86
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class EODPrintOut : global::System.Windows.Forms.Form
	{
		// Token: 0x060011F2 RID: 4594 RVA: 0x000AC1F8 File Offset: 0x000AA3F8
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

		// Token: 0x060011F3 RID: 4595 RVA: 0x000AC248 File Offset: 0x000AA448
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.chkShowItemsSold = new global::System.Windows.Forms.CheckBox();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.cboUser = new global::System.Windows.Forms.ComboBox();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.DTDate = new global::System.Windows.Forms.DateTimePicker();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.PrintDocument1 = new global::System.Drawing.Printing.PrintDocument();
			this.Button2 = new global::System.Windows.Forms.Button();
			this.GroupBox1.SuspendLayout();
			base.SuspendLayout();
			this.GroupBox1.Controls.Add(this.Button2);
			this.GroupBox1.Controls.Add(this.chkShowItemsSold);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.cboUser);
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Controls.Add(this.DTDate);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new global::System.Drawing.Size(439, 190);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.chkShowItemsSold.AutoSize = true;
			this.chkShowItemsSold.Location = new global::System.Drawing.Point(117, 113);
			this.chkShowItemsSold.Name = "chkShowItemsSold";
			this.chkShowItemsSold.Size = new global::System.Drawing.Size(108, 17);
			this.chkShowItemsSold.TabIndex = 6;
			this.chkShowItemsSold.Text = "Show items sold?";
			this.chkShowItemsSold.UseVisualStyleBackColor = true;
			this.Label3.AutoSize = true;
			this.Label3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label3.Location = new global::System.Drawing.Point(45, 16);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(285, 24);
			this.Label3.TabIndex = 5;
			this.Label3.Text = "PRINT END OF DAY SUMMARY";
			this.Label2.AutoSize = true;
			this.Label2.Location = new global::System.Drawing.Point(46, 86);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(65, 13);
			this.Label2.TabIndex = 4;
			this.Label2.Text = "Select User:";
			this.cboUser.FormattingEnabled = true;
			this.cboUser.Location = new global::System.Drawing.Point(117, 83);
			this.cboUser.Name = "cboUser";
			this.cboUser.Size = new global::System.Drawing.Size(200, 21);
			this.cboUser.TabIndex = 3;
			this.Button1.BackColor = global::System.Drawing.Color.Aqua;
			this.Button1.Location = new global::System.Drawing.Point(117, 136);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(200, 23);
			this.Button1.TabIndex = 2;
			this.Button1.Text = "Print Sales Summary for User";
			this.Button1.UseVisualStyleBackColor = false;
			this.DTDate.Location = new global::System.Drawing.Point(117, 57);
			this.DTDate.Name = "DTDate";
			this.DTDate.Size = new global::System.Drawing.Size(200, 20);
			this.DTDate.TabIndex = 1;
			this.Label1.AutoSize = true;
			this.Label1.Location = new global::System.Drawing.Point(78, 60);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(33, 13);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Date:";
			this.Button2.BackColor = global::System.Drawing.Color.Lime;
			this.Button2.Location = new global::System.Drawing.Point(117, 163);
			this.Button2.Name = "Button2";
			this.Button2.Size = new global::System.Drawing.Size(200, 23);
			this.Button2.TabIndex = 7;
			this.Button2.Text = "Print Sales Summary for All Users";
			this.Button2.UseVisualStyleBackColor = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(439, 190);
			base.Controls.Add(this.GroupBox1);
			base.Name = "EODPrintOut";
			this.Text = "End of Day Print Out";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x0400086D RID: 2157
		private global::System.ComponentModel.IContainer components;
	}
}
