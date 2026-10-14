namespace PointOfSale
{
	// Token: 0x02000187 RID: 391
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class RunningBalReport : global::System.Windows.Forms.UserControl
	{
		// Token: 0x06003A62 RID: 14946 RVA: 0x001FA418 File Offset: 0x001F8618
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

		// Token: 0x06003A63 RID: 14947 RVA: 0x001FA468 File Offset: 0x001F8668
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.DTStartDate = new global::System.Windows.Forms.DateTimePicker();
			this.DTEndDate = new global::System.Windows.Forms.DateTimePicker();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.DataGridView1 = new global::System.Windows.Forms.DataGridView();
			this.Button2 = new global::System.Windows.Forms.Button();
			this.SaveFileDialog1 = new global::System.Windows.Forms.SaveFileDialog();
			this.GroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.DataGridView1).BeginInit();
			base.SuspendLayout();
			this.GroupBox1.Controls.Add(this.Button2);
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Controls.Add(this.DTEndDate);
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Controls.Add(this.DTStartDate);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new global::System.Drawing.Size(1231, 252);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Details";
			this.Label1.AutoSize = true;
			this.Label1.BackColor = global::System.Drawing.Color.Red;
			this.Label1.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.Label1.Location = new global::System.Drawing.Point(1179, 22);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(49, 20);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Close";
			this.Label2.AutoSize = true;
			this.Label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label2.Location = new global::System.Drawing.Point(51, 37);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(429, 32);
			this.Label2.TabIndex = 1;
			this.Label2.Text = "RUNNING BALANCE REPORT";
			this.Label3.AutoSize = true;
			this.Label3.Location = new global::System.Drawing.Point(53, 104);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(87, 20);
			this.Label3.TabIndex = 2;
			this.Label3.Text = "Start Date:";
			this.DTStartDate.Location = new global::System.Drawing.Point(160, 104);
			this.DTStartDate.Name = "DTStartDate";
			this.DTStartDate.Size = new global::System.Drawing.Size(301, 26);
			this.DTStartDate.TabIndex = 3;
			this.DTEndDate.Location = new global::System.Drawing.Point(160, 136);
			this.DTEndDate.Name = "DTEndDate";
			this.DTEndDate.Size = new global::System.Drawing.Size(301, 26);
			this.DTEndDate.TabIndex = 5;
			this.Label4.AutoSize = true;
			this.Label4.Location = new global::System.Drawing.Point(53, 136);
			this.Label4.Name = "Label4";
			this.Label4.Size = new global::System.Drawing.Size(81, 20);
			this.Label4.TabIndex = 4;
			this.Label4.Text = "End Date:";
			this.Button1.BackColor = global::System.Drawing.Color.Lime;
			this.Button1.Location = new global::System.Drawing.Point(160, 168);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(160, 36);
			this.Button1.TabIndex = 6;
			this.Button1.Text = "RUN REPORT";
			this.Button1.UseVisualStyleBackColor = false;
			this.DataGridView1.AllowUserToAddRows = false;
			this.DataGridView1.AllowUserToDeleteRows = false;
			this.DataGridView1.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridView1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.DataGridView1.Location = new global::System.Drawing.Point(0, 252);
			this.DataGridView1.Name = "DataGridView1";
			this.DataGridView1.ReadOnly = true;
			this.DataGridView1.RowTemplate.Height = 28;
			this.DataGridView1.Size = new global::System.Drawing.Size(1231, 307);
			this.DataGridView1.TabIndex = 1;
			this.Button2.BackColor = global::System.Drawing.Color.Yellow;
			this.Button2.Location = new global::System.Drawing.Point(160, 210);
			this.Button2.Name = "Button2";
			this.Button2.Size = new global::System.Drawing.Size(160, 36);
			this.Button2.TabIndex = 7;
			this.Button2.Text = "Export to Excel";
			this.Button2.UseVisualStyleBackColor = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.Controls.Add(this.DataGridView1);
			base.Controls.Add(this.GroupBox1);
			base.Name = "RunningBalReport";
			base.Size = new global::System.Drawing.Size(1231, 559);
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.DataGridView1).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x040018E1 RID: 6369
		private global::System.ComponentModel.IContainer components;
	}
}
