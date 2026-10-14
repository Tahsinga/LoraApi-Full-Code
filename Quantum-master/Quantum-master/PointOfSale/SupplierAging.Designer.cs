namespace PointOfSale
{
	// Token: 0x020001FC RID: 508
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class SupplierAging : global::System.Windows.Forms.Form
	{
		// Token: 0x06005B71 RID: 23409 RVA: 0x0034AF98 File Offset: 0x00349198
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

		// Token: 0x06005B72 RID: 23410 RVA: 0x0034AFE8 File Offset: 0x003491E8
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.lblsuppliername = new global::System.Windows.Forms.Label();
			this.dgvAging = new global::System.Windows.Forms.DataGridView();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.SaveFileDialog1 = new global::System.Windows.Forms.SaveFileDialog();
			this.GroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvAging).BeginInit();
			base.SuspendLayout();
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Controls.Add(this.lblsuppliername);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new global::System.Drawing.Size(1136, 116);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Supplier";
			this.Label1.AutoSize = true;
			this.Label1.Location = new global::System.Drawing.Point(94, 43);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(117, 20);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Supplier Name:";
			this.lblsuppliername.AutoSize = true;
			this.lblsuppliername.Location = new global::System.Drawing.Point(217, 43);
			this.lblsuppliername.Name = "lblsuppliername";
			this.lblsuppliername.Size = new global::System.Drawing.Size(21, 20);
			this.lblsuppliername.TabIndex = 1;
			this.lblsuppliername.Text = "...";
			this.dgvAging.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAging.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dgvAging.Location = new global::System.Drawing.Point(0, 116);
			this.dgvAging.Name = "dgvAging";
			this.dgvAging.RowTemplate.Height = 28;
			this.dgvAging.Size = new global::System.Drawing.Size(1136, 274);
			this.dgvAging.TabIndex = 1;
			this.Button1.BackColor = global::System.Drawing.Color.Yellow;
			this.Button1.Location = new global::System.Drawing.Point(221, 78);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(171, 32);
			this.Button1.TabIndex = 2;
			this.Button1.Text = "Export to Excel";
			this.Button1.UseVisualStyleBackColor = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1136, 390);
			base.Controls.Add(this.dgvAging);
			base.Controls.Add(this.GroupBox1);
			base.Name = "SupplierAging";
			this.Text = "SupplierAging";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvAging).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x040027F9 RID: 10233
		private global::System.ComponentModel.IContainer components;
	}
}
