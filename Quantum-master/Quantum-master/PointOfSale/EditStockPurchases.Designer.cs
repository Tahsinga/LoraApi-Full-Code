namespace PointOfSale
{
	// Token: 0x02000052 RID: 82
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class EditStockPurchases : global::System.Windows.Forms.UserControl
	{
		// Token: 0x060011A1 RID: 4513 RVA: 0x000A9DA8 File Offset: 0x000A7FA8
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

		// Token: 0x060011A2 RID: 4514 RVA: 0x000A9DF8 File Offset: 0x000A7FF8
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.Label5 = new global::System.Windows.Forms.Label();
			this.cboBranch = new global::System.Windows.Forms.ComboBox();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.lblinfo = new global::System.Windows.Forms.Label();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.DTday = new global::System.Windows.Forms.DateTimePicker();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.dgvPurchases = new global::System.Windows.Forms.DataGridView();
			this.GroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvPurchases).BeginInit();
			base.SuspendLayout();
			this.GroupBox1.Controls.Add(this.Label5);
			this.GroupBox1.Controls.Add(this.cboBranch);
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Controls.Add(this.lblinfo);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.DTday);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new global::System.Drawing.Size(1037, 121);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.Label5.AutoSize = true;
			this.Label5.Location = new global::System.Drawing.Point(429, 82);
			this.Label5.Name = "Label5";
			this.Label5.Size = new global::System.Drawing.Size(41, 13);
			this.Label5.TabIndex = 16;
			this.Label5.Text = "Branch";
			this.cboBranch.FormattingEnabled = true;
			this.cboBranch.Location = new global::System.Drawing.Point(476, 79);
			this.cboBranch.Name = "cboBranch";
			this.cboBranch.Size = new global::System.Drawing.Size(172, 21);
			this.cboBranch.TabIndex = 15;
			this.Label4.AutoSize = true;
			this.Label4.Location = new global::System.Drawing.Point(39, 56);
			this.Label4.Name = "Label4";
			this.Label4.Size = new global::System.Drawing.Size(907, 13);
			this.Label4.TabIndex = 6;
			this.Label4.Text = "*Use this form only to correct errors when entering new stock purchases. Do not use to adjust stock - use the the Stock Take function for that. VALID ON THE SAME DAY AS THE MISTAKE.";
			this.lblinfo.AutoSize = true;
			this.lblinfo.Location = new global::System.Drawing.Point(807, 86);
			this.lblinfo.Name = "lblinfo";
			this.lblinfo.Size = new global::System.Drawing.Size(16, 13);
			this.lblinfo.TabIndex = 5;
			this.lblinfo.Text = "...";
			this.Label3.AutoSize = true;
			this.Label3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label3.Location = new global::System.Drawing.Point(375, 16);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(187, 24);
			this.Label3.TabIndex = 4;
			this.Label3.Text = "Edit Stock Purchases";
			this.Button1.Location = new global::System.Drawing.Point(654, 78);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(147, 23);
			this.Button1.TabIndex = 3;
			this.Button1.Text = "View Stock Purchases";
			this.Button1.UseVisualStyleBackColor = true;
			this.Label2.AutoSize = true;
			this.Label2.Location = new global::System.Drawing.Point(-5, 82);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(177, 13);
			this.Label2.TabIndex = 2;
			this.Label2.Text = "Select Date when stock purchased:";
			this.DTday.Enabled = false;
			this.DTday.Location = new global::System.Drawing.Point(178, 80);
			this.DTday.Name = "DTday";
			this.DTday.Size = new global::System.Drawing.Size(200, 20);
			this.DTday.TabIndex = 1;
			this.Label1.AutoSize = true;
			this.Label1.BackColor = global::System.Drawing.Color.Red;
			this.Label1.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.Label1.Location = new global::System.Drawing.Point(1001, 16);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(33, 13);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Close";
			this.dgvPurchases.AllowUserToAddRows = false;
			this.dgvPurchases.AllowUserToDeleteRows = false;
			this.dgvPurchases.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvPurchases.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dgvPurchases.Location = new global::System.Drawing.Point(0, 121);
			this.dgvPurchases.Name = "dgvPurchases";
			this.dgvPurchases.Size = new global::System.Drawing.Size(1037, 340);
			this.dgvPurchases.TabIndex = 1;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.Controls.Add(this.dgvPurchases);
			base.Controls.Add(this.GroupBox1);
			base.Name = "EditStockPurchases";
			base.Size = new global::System.Drawing.Size(1037, 461);
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvPurchases).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000848 RID: 2120
		private global::System.ComponentModel.IContainer components;
	}
}
