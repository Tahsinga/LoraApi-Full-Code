namespace PointOfSale
{
	// Token: 0x0200008C RID: 140
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class PerformanceReport : global::System.Windows.Forms.UserControl
	{
		// Token: 0x06001FA9 RID: 8105 RVA: 0x0011ADC0 File Offset: 0x00118FC0
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

		// Token: 0x06001FAA RID: 8106 RVA: 0x0011AE10 File Offset: 0x00119010
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.chkAll = new global::System.Windows.Forms.CheckBox();
			this.Label6 = new global::System.Windows.Forms.Label();
			this.cboBranches = new global::System.Windows.Forms.ComboBox();
			this.Label5 = new global::System.Windows.Forms.Label();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.Button2 = new global::System.Windows.Forms.Button();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.DTEnddate = new global::System.Windows.Forms.DateTimePicker();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.DTStartdate = new global::System.Windows.Forms.DateTimePicker();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.dgvResults = new global::System.Windows.Forms.DataGridView();
			this.SaveFileDialog1 = new global::System.Windows.Forms.SaveFileDialog();
			this.GroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvResults).BeginInit();
			base.SuspendLayout();
			this.GroupBox1.Controls.Add(this.chkAll);
			this.GroupBox1.Controls.Add(this.Label6);
			this.GroupBox1.Controls.Add(this.cboBranches);
			this.GroupBox1.Controls.Add(this.Label5);
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Controls.Add(this.Button2);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Controls.Add(this.DTEnddate);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.DTStartdate);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new global::System.Drawing.Size(1419, 198);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Select Period";
			this.chkAll.AutoSize = true;
			this.chkAll.Location = new global::System.Drawing.Point(1155, 118);
			this.chkAll.Name = "chkAll";
			this.chkAll.Size = new global::System.Drawing.Size(133, 24);
			this.chkAll.TabIndex = 11;
			this.chkAll.Text = "All Branches?";
			this.chkAll.UseVisualStyleBackColor = true;
			this.chkAll.Visible = false;
			this.Label6.AutoSize = true;
			this.Label6.Location = new global::System.Drawing.Point(1029, 84);
			this.Label6.Name = "Label6";
			this.Label6.Size = new global::System.Drawing.Size(113, 20);
			this.Label6.TabIndex = 10;
			this.Label6.Text = "Select Branch:";
			this.cboBranches.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboBranches.FormattingEnabled = true;
			this.cboBranches.Location = new global::System.Drawing.Point(1148, 80);
			this.cboBranches.Name = "cboBranches";
			this.cboBranches.Size = new global::System.Drawing.Size(239, 28);
			this.cboBranches.TabIndex = 9;
			this.Label5.AutoSize = true;
			this.Label5.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8f, global::System.Drawing.FontStyle.Italic, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label5.Location = new global::System.Drawing.Point(123, 116);
			this.Label5.Name = "Label5";
			this.Label5.Size = new global::System.Drawing.Size(605, 20);
			this.Label5.TabIndex = 8;
			this.Label5.Text = "*The report can get heavy. Recommended periods to use are a week or a month max";
			this.Label4.AutoSize = true;
			this.Label4.BackColor = global::System.Drawing.Color.Red;
			this.Label4.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.Label4.Location = new global::System.Drawing.Point(1367, 22);
			this.Label4.Name = "Label4";
			this.Label4.Size = new global::System.Drawing.Size(49, 20);
			this.Label4.TabIndex = 7;
			this.Label4.Text = "Close";
			this.Button2.BackColor = global::System.Drawing.Color.Yellow;
			this.Button2.Location = new global::System.Drawing.Point(589, 158);
			this.Button2.Name = "Button2";
			this.Button2.Size = new global::System.Drawing.Size(317, 34);
			this.Button2.TabIndex = 6;
			this.Button2.Text = "EXPORT TO EXCEL";
			this.Button2.UseVisualStyleBackColor = false;
			this.Label3.AutoSize = true;
			this.Label3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label3.Location = new global::System.Drawing.Point(112, 22);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(511, 32);
			this.Label3.TabIndex = 5;
			this.Label3.Text = "Performance Report for All Branches";
			this.Button1.BackColor = global::System.Drawing.Color.Lime;
			this.Button1.Location = new global::System.Drawing.Point(118, 158);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(317, 34);
			this.Button1.TabIndex = 4;
			this.Button1.Text = "RUN REPORT";
			this.Button1.UseVisualStyleBackColor = false;
			this.DTEnddate.Location = new global::System.Drawing.Point(589, 83);
			this.DTEnddate.Name = "DTEnddate";
			this.DTEnddate.Size = new global::System.Drawing.Size(317, 26);
			this.DTEnddate.TabIndex = 3;
			this.Label2.AutoSize = true;
			this.Label2.Location = new global::System.Drawing.Point(496, 88);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(87, 20);
			this.Label2.TabIndex = 2;
			this.Label2.Text = "Start Date:";
			this.DTStartdate.Location = new global::System.Drawing.Point(118, 84);
			this.DTStartdate.Name = "DTStartdate";
			this.DTStartdate.Size = new global::System.Drawing.Size(317, 26);
			this.DTStartdate.TabIndex = 1;
			this.Label1.AutoSize = true;
			this.Label1.Location = new global::System.Drawing.Point(25, 89);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(87, 20);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Start Date:";
			this.dgvResults.AllowUserToAddRows = false;
			this.dgvResults.AllowUserToDeleteRows = false;
			this.dgvResults.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvResults.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dgvResults.Location = new global::System.Drawing.Point(0, 198);
			this.dgvResults.Name = "dgvResults";
			this.dgvResults.ReadOnly = true;
			this.dgvResults.RowTemplate.Height = 28;
			this.dgvResults.Size = new global::System.Drawing.Size(1419, 258);
			this.dgvResults.TabIndex = 1;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.Controls.Add(this.dgvResults);
			base.Controls.Add(this.GroupBox1);
			base.Name = "PerformanceReport";
			base.Size = new global::System.Drawing.Size(1419, 456);
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvResults).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000F08 RID: 3848
		private global::System.ComponentModel.IContainer components;
	}
}
