namespace PointOfSale
{
	// Token: 0x02000188 RID: 392
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class R_SalesReport : global::System.Windows.Forms.Form
	{
		// Token: 0x06003A7E RID: 14974 RVA: 0x001FAF10 File Offset: 0x001F9110
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

		// Token: 0x06003A7F RID: 14975 RVA: 0x001FAF60 File Offset: 0x001F9160
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.Panel1 = new global::System.Windows.Forms.Panel();
			this.Button2 = new global::System.Windows.Forms.Button();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.DTenddate = new global::System.Windows.Forms.DateTimePicker();
			this.DTstartdate = new global::System.Windows.Forms.DateTimePicker();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.dgvR = new global::System.Windows.Forms.DataGridView();
			this.FolderBrowserDialog1 = new global::System.Windows.Forms.FolderBrowserDialog();
			this.SaveFileDialog1 = new global::System.Windows.Forms.SaveFileDialog();
			this.Panel1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvR).BeginInit();
			base.SuspendLayout();
			this.Panel1.Controls.Add(this.Button2);
			this.Panel1.Controls.Add(this.Button1);
			this.Panel1.Controls.Add(this.Label3);
			this.Panel1.Controls.Add(this.Label2);
			this.Panel1.Controls.Add(this.DTenddate);
			this.Panel1.Controls.Add(this.DTstartdate);
			this.Panel1.Controls.Add(this.Label1);
			this.Panel1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.Panel1.Location = new global::System.Drawing.Point(0, 0);
			this.Panel1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new global::System.Drawing.Size(1566, 252);
			this.Panel1.TabIndex = 0;
			this.Button2.Location = new global::System.Drawing.Point(1149, 195);
			this.Button2.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Button2.Name = "Button2";
			this.Button2.Size = new global::System.Drawing.Size(250, 35);
			this.Button2.TabIndex = 9;
			this.Button2.Text = "Export to CSV File";
			this.Button2.UseVisualStyleBackColor = true;
			this.Button1.BackColor = global::System.Drawing.Color.Lime;
			this.Button1.Location = new global::System.Drawing.Point(219, 195);
			this.Button1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(300, 35);
			this.Button1.TabIndex = 7;
			this.Button1.Text = "View Report";
			this.Button1.UseVisualStyleBackColor = false;
			this.Label3.AutoSize = true;
			this.Label3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label3.Location = new global::System.Drawing.Point(122, 14);
			this.Label3.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(420, 32);
			this.Label3.TabIndex = 4;
			this.Label3.Text = "ADF SALES REPORT SPECIAL";
			this.Label2.AutoSize = true;
			this.Label2.Location = new global::System.Drawing.Point(128, 122);
			this.Label2.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(81, 20);
			this.Label2.TabIndex = 3;
			this.Label2.Text = "End Date:";
			this.DTenddate.Location = new global::System.Drawing.Point(219, 114);
			this.DTenddate.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.DTenddate.Name = "DTenddate";
			this.DTenddate.Size = new global::System.Drawing.Size(298, 26);
			this.DTenddate.TabIndex = 2;
			this.DTstartdate.Location = new global::System.Drawing.Point(219, 74);
			this.DTstartdate.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.DTstartdate.Name = "DTstartdate";
			this.DTstartdate.Size = new global::System.Drawing.Size(298, 26);
			this.DTstartdate.TabIndex = 1;
			this.Label1.AutoSize = true;
			this.Label1.Location = new global::System.Drawing.Point(123, 80);
			this.Label1.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(87, 20);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Start Date:";
			this.dgvR.AllowUserToAddRows = false;
			this.dgvR.AllowUserToDeleteRows = false;
			this.dgvR.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvR.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dgvR.Location = new global::System.Drawing.Point(0, 252);
			this.dgvR.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dgvR.Name = "dgvR";
			this.dgvR.ReadOnly = true;
			this.dgvR.Size = new global::System.Drawing.Size(1566, 470);
			this.dgvR.TabIndex = 1;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1566, 722);
			base.Controls.Add(this.dgvR);
			base.Controls.Add(this.Panel1);
			base.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			base.Name = "R_SalesReport";
			this.Text = "R_SalesReport";
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvR).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x040018EF RID: 6383
		private global::System.ComponentModel.IContainer components;
	}
}
