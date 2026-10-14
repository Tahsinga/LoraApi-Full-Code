namespace PointOfSale
{
	// Token: 0x02000062 RID: 98
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class frmStockExpiry : global::System.Windows.Forms.Form
	{
		// Token: 0x0600142F RID: 5167 RVA: 0x000BEA74 File Offset: 0x000BCC74
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

		// Token: 0x06001430 RID: 5168 RVA: 0x000BEAC4 File Offset: 0x000BCCC4
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.dtExp = new global::System.Windows.Forms.DateTimePicker();
			this.dgvBal = new global::System.Windows.Forms.DataGridView();
			this.Button2 = new global::System.Windows.Forms.Button();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.SaveFileDialog1 = new global::System.Windows.Forms.SaveFileDialog();
			this.GroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvBal).BeginInit();
			base.SuspendLayout();
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.Button2);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Controls.Add(this.dtExp);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Padding = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GroupBox1.Size = new global::System.Drawing.Size(1310, 217);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.Label2.AutoSize = true;
			this.Label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label2.Location = new global::System.Drawing.Point(18, 25);
			this.Label2.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(751, 32);
			this.Label2.TabIndex = 3;
			this.Label2.Text = "VIEW PRODUCTS EXPIRING BEFORE SELECTED DATE";
			this.Button1.BackColor = global::System.Drawing.Color.Lime;
			this.Button1.Location = new global::System.Drawing.Point(198, 149);
			this.Button1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(300, 35);
			this.Button1.TabIndex = 2;
			this.Button1.Text = "View Products Expiring";
			this.Button1.UseVisualStyleBackColor = false;
			this.Label1.AutoSize = true;
			this.Label1.Location = new global::System.Drawing.Point(44, 111);
			this.Label1.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(143, 20);
			this.Label1.TabIndex = 1;
			this.Label1.Text = "Select Expiry Date:";
			this.dtExp.Location = new global::System.Drawing.Point(198, 106);
			this.dtExp.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dtExp.Name = "dtExp";
			this.dtExp.Size = new global::System.Drawing.Size(298, 26);
			this.dtExp.TabIndex = 0;
			this.dgvBal.AllowUserToAddRows = false;
			this.dgvBal.AllowUserToDeleteRows = false;
			this.dgvBal.AutoSizeColumnsMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvBal.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvBal.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dgvBal.Location = new global::System.Drawing.Point(0, 217);
			this.dgvBal.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dgvBal.Name = "dgvBal";
			this.dgvBal.ReadOnly = true;
			this.dgvBal.Size = new global::System.Drawing.Size(1310, 438);
			this.dgvBal.TabIndex = 1;
			this.Button2.Location = new global::System.Drawing.Point(547, 150);
			this.Button2.Name = "Button2";
			this.Button2.Size = new global::System.Drawing.Size(222, 32);
			this.Button2.TabIndex = 4;
			this.Button2.Text = "Export to Excel";
			this.Button2.UseVisualStyleBackColor = true;
			this.Label3.AutoSize = true;
			this.Label3.BackColor = global::System.Drawing.Color.Red;
			this.Label3.Location = new global::System.Drawing.Point(940, 192);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(119, 20);
			this.Label3.TabIndex = 5;
			this.Label3.Text = "Already Expired";
			this.Label4.AutoSize = true;
			this.Label4.BackColor = global::System.Drawing.Color.Yellow;
			this.Label4.Location = new global::System.Drawing.Point(1124, 192);
			this.Label4.Name = "Label4";
			this.Label4.Size = new global::System.Drawing.Size(143, 20);
			this.Label4.TabIndex = 6;
			this.Label4.Text = "Expires In A Month";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1310, 655);
			base.Controls.Add(this.dgvBal);
			base.Controls.Add(this.GroupBox1);
			base.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			base.Name = "frmStockExpiry";
			this.Text = "Stock Expiry";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvBal).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000A3C RID: 2620
		private global::System.ComponentModel.IContainer components;
	}
}
