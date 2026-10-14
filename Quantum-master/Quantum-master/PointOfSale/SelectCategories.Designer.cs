namespace PointOfSale
{
	// Token: 0x020001B8 RID: 440
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class SelectCategories : global::System.Windows.Forms.Form
	{
		// Token: 0x06004FD0 RID: 20432 RVA: 0x002FABB0 File Offset: 0x002F8DB0
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

		// Token: 0x06004FD1 RID: 20433 RVA: 0x002FAC00 File Offset: 0x002F8E00
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.Button2 = new global::System.Windows.Forms.Button();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.dgvCategories = new global::System.Windows.Forms.DataGridView();
			this.GroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvCategories).BeginInit();
			base.SuspendLayout();
			this.GroupBox1.Controls.Add(this.Button2);
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Padding = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GroupBox1.Size = new global::System.Drawing.Size(732, 114);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.Button2.Location = new global::System.Drawing.Point(9, 69);
			this.Button2.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Button2.Name = "Button2";
			this.Button2.Size = new global::System.Drawing.Size(112, 35);
			this.Button2.TabIndex = 1;
			this.Button2.Text = "Select All";
			this.Button2.UseVisualStyleBackColor = true;
			this.Button1.BackColor = global::System.Drawing.Color.Lime;
			this.Button1.Location = new global::System.Drawing.Point(264, 29);
			this.Button1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(200, 35);
			this.Button1.TabIndex = 0;
			this.Button1.Text = "SAVE SELECTION";
			this.Button1.UseVisualStyleBackColor = false;
			this.dgvCategories.AllowUserToAddRows = false;
			this.dgvCategories.AllowUserToDeleteRows = false;
			this.dgvCategories.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCategories.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dgvCategories.Location = new global::System.Drawing.Point(0, 114);
			this.dgvCategories.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dgvCategories.Name = "dgvCategories";
			this.dgvCategories.Size = new global::System.Drawing.Size(732, 401);
			this.dgvCategories.TabIndex = 1;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(732, 515);
			base.Controls.Add(this.dgvCategories);
			base.Controls.Add(this.GroupBox1);
			base.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			base.Name = "SelectCategories";
			this.Text = "Select Categories";
			this.GroupBox1.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.dgvCategories).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x0400239A RID: 9114
		private global::System.ComponentModel.IContainer components;
	}
}
