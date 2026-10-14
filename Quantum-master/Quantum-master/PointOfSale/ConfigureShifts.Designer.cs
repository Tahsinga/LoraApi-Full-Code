namespace PointOfSale
{
	// Token: 0x0200002D RID: 45
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class ConfigureShifts : global::System.Windows.Forms.Form
	{
		// Token: 0x060008A3 RID: 2211 RVA: 0x00053B74 File Offset: 0x00051D74
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

		// Token: 0x060008A4 RID: 2212 RVA: 0x00053BC4 File Offset: 0x00051DC4
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.DataGridView1 = new global::System.Windows.Forms.DataGridView();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.GroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.DataGridView1).BeginInit();
			base.SuspendLayout();
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new global::System.Drawing.Size(520, 91);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.DataGridView1.AllowUserToDeleteRows = false;
			this.DataGridView1.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridView1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.DataGridView1.Location = new global::System.Drawing.Point(0, 91);
			this.DataGridView1.Name = "DataGridView1";
			this.DataGridView1.Size = new global::System.Drawing.Size(520, 171);
			this.DataGridView1.TabIndex = 1;
			this.Button1.Location = new global::System.Drawing.Point(169, 62);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(134, 23);
			this.Button1.TabIndex = 0;
			this.Button1.Text = "Save Changes";
			this.Button1.UseVisualStyleBackColor = true;
			this.Label1.AutoSize = true;
			this.Label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label1.Location = new global::System.Drawing.Point(165, 16);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(141, 24);
			this.Label1.TabIndex = 1;
			this.Label1.Text = "Configure Shifts";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(520, 262);
			base.Controls.Add(this.DataGridView1);
			base.Controls.Add(this.GroupBox1);
			base.Name = "ConfigureShifts";
			this.Text = "Configure Shifts";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.DataGridView1).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x0400040C RID: 1036
		private global::System.ComponentModel.IContainer components;
	}
}
