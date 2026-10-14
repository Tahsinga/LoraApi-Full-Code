namespace PointOfSale
{
	// Token: 0x02000054 RID: 84
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class EnquiriesReport : global::System.Windows.Forms.UserControl
	{
		// Token: 0x060011C6 RID: 4550 RVA: 0x000AAF54 File Offset: 0x000A9154
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

		// Token: 0x060011C7 RID: 4551 RVA: 0x000AAFA4 File Offset: 0x000A91A4
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.DataGridView1 = new global::System.Windows.Forms.DataGridView();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.DTEnddate = new global::System.Windows.Forms.DateTimePicker();
			this.DTStartdate = new global::System.Windows.Forms.DateTimePicker();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.GroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.DataGridView1).BeginInit();
			base.SuspendLayout();
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.DTEnddate);
			this.GroupBox1.Controls.Add(this.DTStartdate);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new global::System.Drawing.Size(958, 121);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.DataGridView1.AllowUserToAddRows = false;
			this.DataGridView1.AllowUserToDeleteRows = false;
			this.DataGridView1.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridView1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.DataGridView1.Location = new global::System.Drawing.Point(0, 121);
			this.DataGridView1.Name = "DataGridView1";
			this.DataGridView1.ReadOnly = true;
			this.DataGridView1.Size = new global::System.Drawing.Size(958, 230);
			this.DataGridView1.TabIndex = 1;
			this.Label2.AutoSize = true;
			this.Label2.Location = new global::System.Drawing.Point(325, 82);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(55, 13);
			this.Label2.TabIndex = 8;
			this.Label2.Text = "End Date:";
			this.DTEnddate.Location = new global::System.Drawing.Point(386, 79);
			this.DTEnddate.Name = "DTEnddate";
			this.DTEnddate.Size = new global::System.Drawing.Size(200, 20);
			this.DTEnddate.TabIndex = 7;
			this.DTStartdate.Location = new global::System.Drawing.Point(79, 79);
			this.DTStartdate.Name = "DTStartdate";
			this.DTStartdate.Size = new global::System.Drawing.Size(200, 20);
			this.DTStartdate.TabIndex = 6;
			this.Label1.AutoSize = true;
			this.Label1.Location = new global::System.Drawing.Point(15, 82);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(58, 13);
			this.Label1.TabIndex = 5;
			this.Label1.Text = "Start Date:";
			this.Button1.BackColor = global::System.Drawing.Color.Lime;
			this.Button1.Location = new global::System.Drawing.Point(626, 76);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(128, 23);
			this.Button1.TabIndex = 9;
			this.Button1.Text = "View Enquiries";
			this.Button1.UseVisualStyleBackColor = false;
			this.Label4.AutoSize = true;
			this.Label4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label4.Location = new global::System.Drawing.Point(14, 16);
			this.Label4.Name = "Label4";
			this.Label4.Size = new global::System.Drawing.Size(176, 24);
			this.Label4.TabIndex = 10;
			this.Label4.Text = "Enquiries for Period";
			this.Label3.AutoSize = true;
			this.Label3.BackColor = global::System.Drawing.Color.Red;
			this.Label3.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.Label3.Location = new global::System.Drawing.Point(922, 16);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(33, 13);
			this.Label3.TabIndex = 11;
			this.Label3.Text = "Close";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.Controls.Add(this.DataGridView1);
			base.Controls.Add(this.GroupBox1);
			base.Name = "EnquiriesReport";
			base.Size = new global::System.Drawing.Size(958, 351);
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.DataGridView1).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000856 RID: 2134
		private global::System.ComponentModel.IContainer components;
	}
}
