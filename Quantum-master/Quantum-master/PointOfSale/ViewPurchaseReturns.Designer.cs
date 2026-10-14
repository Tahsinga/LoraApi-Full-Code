namespace PointOfSale
{
	// Token: 0x02000214 RID: 532
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class ViewPurchaseReturns : global::System.Windows.Forms.Form
	{
		// Token: 0x06005F3D RID: 24381 RVA: 0x00368B18 File Offset: 0x00366D18
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

		// Token: 0x06005F3E RID: 24382 RVA: 0x00368B68 File Offset: 0x00366D68
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.dgvReturns = new global::System.Windows.Forms.DataGridView();
			this.DTStartDate = new global::System.Windows.Forms.DateTimePicker();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.DTEndDate = new global::System.Windows.Forms.DateTimePicker();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.GroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvReturns).BeginInit();
			base.SuspendLayout();
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.DTEndDate);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Controls.Add(this.DTStartDate);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new global::System.Drawing.Size(897, 166);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Period";
			this.dgvReturns.AllowUserToAddRows = false;
			this.dgvReturns.AllowUserToDeleteRows = false;
			this.dgvReturns.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvReturns.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dgvReturns.Location = new global::System.Drawing.Point(0, 166);
			this.dgvReturns.Name = "dgvReturns";
			this.dgvReturns.ReadOnly = true;
			this.dgvReturns.Size = new global::System.Drawing.Size(897, 227);
			this.dgvReturns.TabIndex = 1;
			this.DTStartDate.Location = new global::System.Drawing.Point(134, 45);
			this.DTStartDate.Name = "DTStartDate";
			this.DTStartDate.Size = new global::System.Drawing.Size(200, 20);
			this.DTStartDate.TabIndex = 0;
			this.Label1.AutoSize = true;
			this.Label1.Location = new global::System.Drawing.Point(70, 47);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(58, 13);
			this.Label1.TabIndex = 1;
			this.Label1.Text = "Start Date:";
			this.Label2.AutoSize = true;
			this.Label2.Location = new global::System.Drawing.Point(70, 73);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(58, 13);
			this.Label2.TabIndex = 3;
			this.Label2.Text = "Start Date:";
			this.DTEndDate.Location = new global::System.Drawing.Point(134, 71);
			this.DTEndDate.Name = "DTEndDate";
			this.DTEndDate.Size = new global::System.Drawing.Size(200, 20);
			this.DTEndDate.TabIndex = 2;
			this.Button1.Location = new global::System.Drawing.Point(134, 97);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(127, 23);
			this.Button1.TabIndex = 4;
			this.Button1.Text = "View Purchase Returns";
			this.Button1.UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(897, 393);
			base.Controls.Add(this.dgvReturns);
			base.Controls.Add(this.GroupBox1);
			base.Name = "ViewPurchaseReturns";
			this.Text = "View Purchase Returns";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvReturns).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x040029D0 RID: 10704
		private global::System.ComponentModel.IContainer components;
	}
}
