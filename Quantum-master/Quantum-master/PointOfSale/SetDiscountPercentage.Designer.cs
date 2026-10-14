namespace PointOfSale
{
	// Token: 0x020001DB RID: 475
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class SetDiscountPercentage : global::System.Windows.Forms.Form
	{
		// Token: 0x06005344 RID: 21316 RVA: 0x00306724 File Offset: 0x00304924
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

		// Token: 0x06005345 RID: 21317 RVA: 0x00306774 File Offset: 0x00304974
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.dgvDiscounts = new global::System.Windows.Forms.DataGridView();
			this.GroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvDiscounts).BeginInit();
			base.SuspendLayout();
			this.GroupBox1.BackColor = global::System.Drawing.Color.FromArgb(255, 224, 192);
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new global::System.Drawing.Size(410, 95);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.Label4.AutoSize = true;
			this.Label4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Italic, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label4.Location = new global::System.Drawing.Point(292, 77);
			this.Label4.Name = "Label4";
			this.Label4.Size = new global::System.Drawing.Size(112, 13);
			this.Label4.TabIndex = 4;
			this.Label4.Text = "*max 5 decimal places";
			this.Label3.AutoSize = true;
			this.Label3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label3.Location = new global::System.Drawing.Point(74, 16);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(250, 24);
			this.Label3.TabIndex = 3;
			this.Label3.Text = "Invoice Discount Percentage";
			this.Button1.BackColor = global::System.Drawing.Color.Lime;
			this.Button1.Location = new global::System.Drawing.Point(156, 55);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(75, 23);
			this.Button1.TabIndex = 2;
			this.Button1.Text = "SAVE";
			this.Button1.UseVisualStyleBackColor = false;
			this.dgvDiscounts.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDiscounts.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dgvDiscounts.Location = new global::System.Drawing.Point(0, 95);
			this.dgvDiscounts.Name = "dgvDiscounts";
			this.dgvDiscounts.Size = new global::System.Drawing.Size(410, 136);
			this.dgvDiscounts.TabIndex = 1;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(410, 231);
			base.Controls.Add(this.dgvDiscounts);
			base.Controls.Add(this.GroupBox1);
			base.Name = "SetDiscountPercentage";
			this.Text = "Set Discount Percentage";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvDiscounts).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x0400244E RID: 9294
		private global::System.ComponentModel.IContainer components;
	}
}
