namespace PointOfSale
{
	// Token: 0x02000051 RID: 81
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class EditShiftDetail : global::System.Windows.Forms.Form
	{
		// Token: 0x0600118D RID: 4493 RVA: 0x000A9288 File Offset: 0x000A7488
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

		// Token: 0x0600118E RID: 4494 RVA: 0x000A92D8 File Offset: 0x000A74D8
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.DTShiftDate = new global::System.Windows.Forms.DateTimePicker();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.Button2 = new global::System.Windows.Forms.Button();
			this.DataGridView1 = new global::System.Windows.Forms.DataGridView();
			this.GroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.DataGridView1).BeginInit();
			base.SuspendLayout();
			this.GroupBox1.Controls.Add(this.Button2);
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Controls.Add(this.DTShiftDate);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new global::System.Drawing.Size(1040, 116);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.Label1.AutoSize = true;
			this.Label1.Location = new global::System.Drawing.Point(41, 23);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(90, 13);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Select Shift Date:";
			this.DTShiftDate.Location = new global::System.Drawing.Point(137, 23);
			this.DTShiftDate.Name = "DTShiftDate";
			this.DTShiftDate.Size = new global::System.Drawing.Size(200, 20);
			this.DTShiftDate.TabIndex = 1;
			this.Button1.Location = new global::System.Drawing.Point(137, 49);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(200, 23);
			this.Button1.TabIndex = 2;
			this.Button1.Text = "View Shifts";
			this.Button1.UseVisualStyleBackColor = true;
			this.Button2.Location = new global::System.Drawing.Point(137, 78);
			this.Button2.Name = "Button2";
			this.Button2.Size = new global::System.Drawing.Size(200, 23);
			this.Button2.TabIndex = 3;
			this.Button2.Text = "Open Selected Shift(s)";
			this.Button2.UseVisualStyleBackColor = true;
			this.DataGridView1.AllowUserToAddRows = false;
			this.DataGridView1.AllowUserToDeleteRows = false;
			this.DataGridView1.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridView1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.DataGridView1.Location = new global::System.Drawing.Point(0, 116);
			this.DataGridView1.Name = "DataGridView1";
			this.DataGridView1.Size = new global::System.Drawing.Size(1040, 225);
			this.DataGridView1.TabIndex = 1;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1040, 341);
			base.Controls.Add(this.DataGridView1);
			base.Controls.Add(this.GroupBox1);
			base.Name = "EditShiftDetail";
			this.Text = "EditShiftDetail";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.DataGridView1).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000840 RID: 2112
		private global::System.ComponentModel.IContainer components;
	}
}
