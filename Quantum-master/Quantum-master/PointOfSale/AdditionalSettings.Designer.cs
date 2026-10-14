namespace PointOfSale
{
	// Token: 0x02000008 RID: 8
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class AdditionalSettings : global::System.Windows.Forms.Form
	{
		// Token: 0x06000157 RID: 343 RVA: 0x0000D234 File Offset: 0x0000B434
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

		// Token: 0x06000158 RID: 344 RVA: 0x0000D284 File Offset: 0x0000B484
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.dgvAdd = new global::System.Windows.Forms.DataGridView();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.GroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvAdd).BeginInit();
			base.SuspendLayout();
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new global::System.Drawing.Size(1140, 163);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.dgvAdd.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAdd.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dgvAdd.Location = new global::System.Drawing.Point(0, 163);
			this.dgvAdd.Name = "dgvAdd";
			this.dgvAdd.RowTemplate.Height = 28;
			this.dgvAdd.Size = new global::System.Drawing.Size(1140, 320);
			this.dgvAdd.TabIndex = 1;
			this.Button1.Location = new global::System.Drawing.Point(386, 83);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(168, 39);
			this.Button1.TabIndex = 0;
			this.Button1.Text = "Save Changes";
			this.Button1.UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1140, 483);
			base.Controls.Add(this.dgvAdd);
			base.Controls.Add(this.GroupBox1);
			base.Name = "AdditionalSettings";
			this.Text = "Additional Settings";
			this.GroupBox1.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.dgvAdd).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000090 RID: 144
		private global::System.ComponentModel.IContainer components;
	}
}
