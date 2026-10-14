namespace PointOfSale
{
	// Token: 0x02000067 RID: 103
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class KDUs : global::System.Windows.Forms.Form
	{
		// Token: 0x060015F2 RID: 5618 RVA: 0x000CCD20 File Offset: 0x000CAF20
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

		// Token: 0x060015F3 RID: 5619 RVA: 0x000CCD70 File Offset: 0x000CAF70
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.dgvKDUs = new global::System.Windows.Forms.DataGridView();
			this.GroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvKDUs).BeginInit();
			base.SuspendLayout();
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new global::System.Drawing.Size(547, 195);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.Label1.AutoSize = true;
			this.Label1.Location = new global::System.Drawing.Point(157, 22);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(210, 20);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Create Kitchen Display Units";
			this.Label2.AutoSize = true;
			this.Label2.Location = new global::System.Drawing.Point(24, 100);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(281, 20);
			this.Label2.TabIndex = 1;
			this.Label2.Text = "Enter/Edit the name in the grid below...";
			this.Button1.BackColor = global::System.Drawing.Color.Lime;
			this.Button1.Location = new global::System.Drawing.Point(203, 123);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(127, 49);
			this.Button1.TabIndex = 2;
			this.Button1.Text = "SAVE";
			this.Button1.UseVisualStyleBackColor = false;
			this.dgvKDUs.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvKDUs.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dgvKDUs.Location = new global::System.Drawing.Point(0, 195);
			this.dgvKDUs.Name = "dgvKDUs";
			this.dgvKDUs.RowTemplate.Height = 28;
			this.dgvKDUs.Size = new global::System.Drawing.Size(547, 283);
			this.dgvKDUs.TabIndex = 1;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(547, 478);
			base.Controls.Add(this.dgvKDUs);
			base.Controls.Add(this.GroupBox1);
			base.Name = "KDUs";
			this.Text = "KDUs";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvKDUs).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000AF9 RID: 2809
		private global::System.ComponentModel.IContainer components;
	}
}
