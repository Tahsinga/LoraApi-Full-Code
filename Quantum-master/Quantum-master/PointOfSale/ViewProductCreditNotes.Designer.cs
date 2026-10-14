namespace PointOfSale
{
	// Token: 0x02000211 RID: 529
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class ViewProductCreditNotes : global::System.Windows.Forms.Form
	{
		// Token: 0x06005EFA RID: 24314 RVA: 0x00366AE8 File Offset: 0x00364CE8
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

		// Token: 0x06005EFB RID: 24315 RVA: 0x00366B38 File Offset: 0x00364D38
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.DTStartDate = new global::System.Windows.Forms.DateTimePicker();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.DTEndDate = new global::System.Windows.Forms.DateTimePicker();
			this.dgvCredits = new global::System.Windows.Forms.DataGridView();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.GroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvCredits).BeginInit();
			base.SuspendLayout();
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.DTEndDate);
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Controls.Add(this.DTStartDate);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new global::System.Drawing.Size(1013, 128);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.DTStartDate.Location = new global::System.Drawing.Point(107, 44);
			this.DTStartDate.Name = "DTStartDate";
			this.DTStartDate.Size = new global::System.Drawing.Size(200, 20);
			this.DTStartDate.TabIndex = 0;
			this.Label1.AutoSize = true;
			this.Label1.Location = new global::System.Drawing.Point(43, 47);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(58, 13);
			this.Label1.TabIndex = 1;
			this.Label1.Text = "Start Date:";
			this.Button1.Location = new global::System.Drawing.Point(107, 96);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(200, 23);
			this.Button1.TabIndex = 2;
			this.Button1.Text = "View Credit Notes by Product";
			this.Button1.UseVisualStyleBackColor = true;
			this.Label2.AutoSize = true;
			this.Label2.Location = new global::System.Drawing.Point(46, 74);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(55, 13);
			this.Label2.TabIndex = 4;
			this.Label2.Text = "End Date:";
			this.DTEndDate.Location = new global::System.Drawing.Point(107, 70);
			this.DTEndDate.Name = "DTEndDate";
			this.DTEndDate.Size = new global::System.Drawing.Size(200, 20);
			this.DTEndDate.TabIndex = 3;
			this.dgvCredits.AllowUserToAddRows = false;
			this.dgvCredits.AllowUserToDeleteRows = false;
			this.dgvCredits.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCredits.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dgvCredits.Location = new global::System.Drawing.Point(0, 128);
			this.dgvCredits.Name = "dgvCredits";
			this.dgvCredits.Size = new global::System.Drawing.Size(1013, 251);
			this.dgvCredits.TabIndex = 1;
			this.Label3.AutoSize = true;
			this.Label3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label3.Location = new global::System.Drawing.Point(12, 16);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(406, 20);
			this.Label3.TabIndex = 5;
			this.Label3.Text = "VIEW PRODUCTS RETURNED - CREDIT NOTES";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1013, 379);
			base.Controls.Add(this.dgvCredits);
			base.Controls.Add(this.GroupBox1);
			base.Name = "ViewProductCreditNotes";
			this.Text = "View Product Credit Notes";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvCredits).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x040029B4 RID: 10676
		private global::System.ComponentModel.IContainer components;
	}
}
