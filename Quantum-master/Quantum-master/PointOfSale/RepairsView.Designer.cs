namespace PointOfSale
{
	// Token: 0x02000183 RID: 387
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class RepairsView : global::System.Windows.Forms.UserControl
	{
		// Token: 0x06003998 RID: 14744 RVA: 0x001F4F6C File Offset: 0x001F316C
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

		// Token: 0x06003999 RID: 14745 RVA: 0x001F4FBC File Offset: 0x001F31BC
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.Button2 = new global::System.Windows.Forms.Button();
			this.GroupBox2 = new global::System.Windows.Forms.GroupBox();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.DTEnd = new global::System.Windows.Forms.DateTimePicker();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.DTStart = new global::System.Windows.Forms.DateTimePicker();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.lblinfo = new global::System.Windows.Forms.Label();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.dgvRepairs = new global::System.Windows.Forms.DataGridView();
			this.GroupBox1.SuspendLayout();
			this.GroupBox2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvRepairs).BeginInit();
			base.SuspendLayout();
			this.GroupBox1.Controls.Add(this.Button2);
			this.GroupBox1.Controls.Add(this.GroupBox2);
			this.GroupBox1.Controls.Add(this.lblinfo);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new global::System.Drawing.Size(1273, 244);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.Button2.BackColor = global::System.Drawing.Color.Yellow;
			this.Button2.Location = new global::System.Drawing.Point(552, 98);
			this.Button2.Name = "Button2";
			this.Button2.Size = new global::System.Drawing.Size(187, 60);
			this.Button2.TabIndex = 4;
			this.Button2.Text = "View All Repairs including Checked Out";
			this.Button2.UseVisualStyleBackColor = false;
			this.GroupBox2.Controls.Add(this.Button1);
			this.GroupBox2.Controls.Add(this.DTEnd);
			this.GroupBox2.Controls.Add(this.Label4);
			this.GroupBox2.Controls.Add(this.DTStart);
			this.GroupBox2.Controls.Add(this.Label3);
			this.GroupBox2.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.GroupBox2.Location = new global::System.Drawing.Point(3, 59);
			this.GroupBox2.Name = "GroupBox2";
			this.GroupBox2.Size = new global::System.Drawing.Size(531, 162);
			this.GroupBox2.TabIndex = 3;
			this.GroupBox2.TabStop = false;
			this.GroupBox2.Text = "Filter";
			this.Button1.BackColor = global::System.Drawing.Color.Lime;
			this.Button1.Location = new global::System.Drawing.Point(201, 105);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(312, 33);
			this.Button1.TabIndex = 4;
			this.Button1.Text = "View Repairs for period";
			this.Button1.UseVisualStyleBackColor = false;
			this.DTEnd.Location = new global::System.Drawing.Point(201, 73);
			this.DTEnd.Name = "DTEnd";
			this.DTEnd.Size = new global::System.Drawing.Size(312, 26);
			this.DTEnd.TabIndex = 3;
			this.Label4.AutoSize = true;
			this.Label4.Location = new global::System.Drawing.Point(18, 78);
			this.Label4.Name = "Label4";
			this.Label4.Size = new global::System.Drawing.Size(154, 20);
			this.Label4.TabIndex = 2;
			this.Label4.Text = "Check In Start Date:";
			this.DTStart.Location = new global::System.Drawing.Point(201, 41);
			this.DTStart.Name = "DTStart";
			this.DTStart.Size = new global::System.Drawing.Size(312, 26);
			this.DTStart.TabIndex = 1;
			this.Label3.AutoSize = true;
			this.Label3.Location = new global::System.Drawing.Point(18, 46);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(154, 20);
			this.Label3.TabIndex = 0;
			this.Label3.Text = "Check In Start Date:";
			this.lblinfo.AutoSize = true;
			this.lblinfo.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.lblinfo.Location = new global::System.Drawing.Point(3, 221);
			this.lblinfo.Name = "lblinfo";
			this.lblinfo.Size = new global::System.Drawing.Size(21, 20);
			this.lblinfo.TabIndex = 2;
			this.lblinfo.Text = "...";
			this.Label2.AutoSize = true;
			this.Label2.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.Label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 16f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label2.Location = new global::System.Drawing.Point(3, 22);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(197, 37);
			this.Label2.TabIndex = 1;
			this.Label2.Text = "Repairs List";
			this.Label1.AutoSize = true;
			this.Label1.BackColor = global::System.Drawing.Color.Red;
			this.Label1.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.Label1.Location = new global::System.Drawing.Point(1221, 22);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(49, 20);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Close";
			this.dgvRepairs.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvRepairs.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dgvRepairs.Location = new global::System.Drawing.Point(0, 244);
			this.dgvRepairs.Name = "dgvRepairs";
			this.dgvRepairs.RowTemplate.Height = 28;
			this.dgvRepairs.Size = new global::System.Drawing.Size(1273, 304);
			this.dgvRepairs.TabIndex = 1;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.Controls.Add(this.dgvRepairs);
			base.Controls.Add(this.GroupBox1);
			base.Name = "RepairsView";
			base.Size = new global::System.Drawing.Size(1273, 548);
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.GroupBox2.ResumeLayout(false);
			this.GroupBox2.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvRepairs).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x0400188B RID: 6283
		private global::System.ComponentModel.IContainer components;
	}
}
