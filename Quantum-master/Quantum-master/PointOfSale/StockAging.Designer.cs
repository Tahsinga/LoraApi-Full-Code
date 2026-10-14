namespace PointOfSale
{
	// Token: 0x020001E2 RID: 482
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class StockAging : global::System.Windows.Forms.Form
	{
		// Token: 0x0600549C RID: 21660 RVA: 0x0030ED60 File Offset: 0x0030CF60
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

		// Token: 0x0600549D RID: 21661 RVA: 0x0030EDB0 File Offset: 0x0030CFB0
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.dgvStocks = new global::System.Windows.Forms.DataGridView();
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.Button2 = new global::System.Windows.Forms.Button();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.chkAll = new global::System.Windows.Forms.CheckBox();
			this.cboBranches = new global::System.Windows.Forms.ComboBox();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.DateTimePicker1 = new global::System.Windows.Forms.DateTimePicker();
			this.SaveFileDialog1 = new global::System.Windows.Forms.SaveFileDialog();
			this.ProgressBar1 = new global::System.Windows.Forms.ProgressBar();
			((global::System.ComponentModel.ISupportInitialize)this.dgvStocks).BeginInit();
			this.GroupBox1.SuspendLayout();
			base.SuspendLayout();
			this.dgvStocks.AllowUserToAddRows = false;
			this.dgvStocks.AllowUserToDeleteRows = false;
			this.dgvStocks.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvStocks.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dgvStocks.Location = new global::System.Drawing.Point(0, 156);
			this.dgvStocks.Name = "dgvStocks";
			this.dgvStocks.ReadOnly = true;
			this.dgvStocks.Size = new global::System.Drawing.Size(1044, 356);
			this.dgvStocks.TabIndex = 3;
			this.GroupBox1.Controls.Add(this.Button2);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Controls.Add(this.chkAll);
			this.GroupBox1.Controls.Add(this.cboBranches);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Controls.Add(this.DateTimePicker1);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new global::System.Drawing.Size(1044, 156);
			this.GroupBox1.TabIndex = 2;
			this.GroupBox1.TabStop = false;
			this.Button2.BackColor = global::System.Drawing.Color.FromArgb(255, 192, 128);
			this.Button2.Location = new global::System.Drawing.Point(274, 115);
			this.Button2.Name = "Button2";
			this.Button2.Size = new global::System.Drawing.Size(123, 23);
			this.Button2.TabIndex = 6;
			this.Button2.Text = "Export to Excel";
			this.Button2.UseVisualStyleBackColor = false;
			this.Label2.AutoSize = true;
			this.Label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label2.Location = new global::System.Drawing.Point(141, 16);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(269, 24);
			this.Label2.TabIndex = 5;
			this.Label2.Text = "FIFO STOCK AGING REPORT";
			this.Button1.BackColor = global::System.Drawing.Color.Lime;
			this.Button1.Location = new global::System.Drawing.Point(145, 115);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(123, 23);
			this.Button1.TabIndex = 4;
			this.Button1.Text = "RUN REPORT";
			this.Button1.UseVisualStyleBackColor = false;
			this.chkAll.AutoSize = true;
			this.chkAll.Location = new global::System.Drawing.Point(351, 91);
			this.chkAll.Name = "chkAll";
			this.chkAll.Size = new global::System.Drawing.Size(91, 17);
			this.chkAll.TabIndex = 3;
			this.chkAll.Text = "All Branches?";
			this.chkAll.UseVisualStyleBackColor = true;
			this.chkAll.Visible = false;
			this.cboBranches.FormattingEnabled = true;
			this.cboBranches.Location = new global::System.Drawing.Point(145, 88);
			this.cboBranches.Name = "cboBranches";
			this.cboBranches.Size = new global::System.Drawing.Size(200, 21);
			this.cboBranches.TabIndex = 2;
			this.Label1.AutoSize = true;
			this.Label1.Location = new global::System.Drawing.Point(95, 91);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(44, 13);
			this.Label1.TabIndex = 1;
			this.Label1.Text = "Branch:";
			this.DateTimePicker1.Location = new global::System.Drawing.Point(145, 62);
			this.DateTimePicker1.Name = "DateTimePicker1";
			this.DateTimePicker1.Size = new global::System.Drawing.Size(200, 20);
			this.DateTimePicker1.TabIndex = 0;
			this.ProgressBar1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.ProgressBar1.Location = new global::System.Drawing.Point(0, 156);
			this.ProgressBar1.Name = "ProgressBar1";
			this.ProgressBar1.Size = new global::System.Drawing.Size(1044, 23);
			this.ProgressBar1.TabIndex = 4;
			this.ProgressBar1.Visible = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1044, 512);
			base.Controls.Add(this.ProgressBar1);
			base.Controls.Add(this.dgvStocks);
			base.Controls.Add(this.GroupBox1);
			base.Name = "StockAging";
			this.Text = "Stock Aging";
			((global::System.ComponentModel.ISupportInitialize)this.dgvStocks).EndInit();
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x040024ED RID: 9453
		private global::System.ComponentModel.IContainer components;
	}
}
