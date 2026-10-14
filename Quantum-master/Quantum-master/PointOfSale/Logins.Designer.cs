namespace PointOfSale
{
	// Token: 0x0200006B RID: 107
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Logins : global::System.Windows.Forms.Form
	{
		// Token: 0x0600166E RID: 5742 RVA: 0x000D0CEC File Offset: 0x000CEEEC
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

		// Token: 0x0600166F RID: 5743 RVA: 0x000D0D3C File Offset: 0x000CEF3C
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.DataGridView1 = new global::System.Windows.Forms.DataGridView();
			((global::System.ComponentModel.ISupportInitialize)this.DataGridView1).BeginInit();
			base.SuspendLayout();
			this.DataGridView1.AllowUserToAddRows = false;
			this.DataGridView1.AllowUserToDeleteRows = false;
			this.DataGridView1.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridView1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.DataGridView1.Location = new global::System.Drawing.Point(0, 0);
			this.DataGridView1.Name = "DataGridView1";
			this.DataGridView1.ReadOnly = true;
			this.DataGridView1.Size = new global::System.Drawing.Size(518, 261);
			this.DataGridView1.TabIndex = 0;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(518, 261);
			base.Controls.Add(this.DataGridView1);
			base.Name = "Logins";
			this.Text = "Logins";
			((global::System.ComponentModel.ISupportInitialize)this.DataGridView1).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000B31 RID: 2865
		private global::System.ComponentModel.IContainer components;
	}
}
