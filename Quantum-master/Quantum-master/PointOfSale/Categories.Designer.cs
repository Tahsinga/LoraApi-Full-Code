namespace PointOfSale
{
	// Token: 0x0200001D RID: 29
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Categories : global::System.Windows.Forms.Form
	{
		// Token: 0x0600054D RID: 1357 RVA: 0x00034A30 File Offset: 0x00032C30
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

		// Token: 0x0600054E RID: 1358 RVA: 0x00034A80 File Offset: 0x00032C80
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.Panel1 = new global::System.Windows.Forms.Panel();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.DataGridView1 = new global::System.Windows.Forms.DataGridView();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.Panel1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.DataGridView1).BeginInit();
			base.SuspendLayout();
			this.Panel1.Controls.Add(this.Label2);
			this.Panel1.Controls.Add(this.Button1);
			this.Panel1.Controls.Add(this.Label1);
			this.Panel1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.Panel1.Location = new global::System.Drawing.Point(0, 0);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new global::System.Drawing.Size(660, 122);
			this.Panel1.TabIndex = 0;
			this.Button1.BackColor = global::System.Drawing.Color.Lime;
			this.Button1.Location = new global::System.Drawing.Point(266, 82);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(75, 23);
			this.Button1.TabIndex = 1;
			this.Button1.Text = "Save";
			this.Button1.UseVisualStyleBackColor = false;
			this.Label1.AutoSize = true;
			this.Label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label1.Location = new global::System.Drawing.Point(232, 9);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(169, 24);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Edit Categories List";
			this.DataGridView1.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridView1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.DataGridView1.Location = new global::System.Drawing.Point(0, 122);
			this.DataGridView1.Name = "DataGridView1";
			this.DataGridView1.Size = new global::System.Drawing.Size(660, 235);
			this.DataGridView1.TabIndex = 1;
			this.Label2.AutoSize = true;
			this.Label2.Location = new global::System.Drawing.Point(12, 53);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(342, 13);
			this.Label2.TabIndex = 2;
			this.Label2.Text = "*Edit the Category Description below. The gray areas cannot be edited.";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(660, 357);
			base.Controls.Add(this.DataGridView1);
			base.Controls.Add(this.Panel1);
			base.Name = "Categories";
			this.Text = "Categories";
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.DataGridView1).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000265 RID: 613
		private global::System.ComponentModel.IContainer components;
	}
}
