namespace PointOfSale
{
	// Token: 0x020001BC RID: 444
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class SelectTable : global::System.Windows.Forms.Form
	{
		// Token: 0x0600502D RID: 20525 RVA: 0x002FD8A8 File Offset: 0x002FBAA8
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

		// Token: 0x0600502E RID: 20526 RVA: 0x002FD8F8 File Offset: 0x002FBAF8
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.Panel1 = new global::System.Windows.Forms.Panel();
			this.GroupBox2 = new global::System.Windows.Forms.GroupBox();
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.lblCurrTableDesc = new global::System.Windows.Forms.Label();
			this.lblCurrentTable = new global::System.Windows.Forms.Label();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.Panel2 = new global::System.Windows.Forms.Panel();
			this.GroupBox4 = new global::System.Windows.Forms.Panel();
			this.GroupBox3 = new global::System.Windows.Forms.GroupBox();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.Panel1.SuspendLayout();
			this.GroupBox1.SuspendLayout();
			this.Panel2.SuspendLayout();
			this.GroupBox3.SuspendLayout();
			base.SuspendLayout();
			this.Panel1.Controls.Add(this.GroupBox2);
			this.Panel1.Controls.Add(this.GroupBox1);
			this.Panel1.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.Panel1.Location = new global::System.Drawing.Point(0, 0);
			this.Panel1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new global::System.Drawing.Size(522, 858);
			this.Panel1.TabIndex = 0;
			this.GroupBox2.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.GroupBox2.Location = new global::System.Drawing.Point(0, 106);
			this.GroupBox2.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GroupBox2.Name = "GroupBox2";
			this.GroupBox2.Padding = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GroupBox2.Size = new global::System.Drawing.Size(522, 752);
			this.GroupBox2.TabIndex = 1;
			this.GroupBox2.TabStop = false;
			this.GroupBox2.Text = "YOUR CURRENT TABLES";
			this.GroupBox1.BackColor = global::System.Drawing.Color.FromArgb(255, 255, 192);
			this.GroupBox1.Controls.Add(this.lblCurrTableDesc);
			this.GroupBox1.Controls.Add(this.lblCurrentTable);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Padding = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GroupBox1.Size = new global::System.Drawing.Size(522, 106);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.lblCurrTableDesc.AutoSize = true;
			this.lblCurrTableDesc.Location = new global::System.Drawing.Point(401, 72);
			this.lblCurrTableDesc.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblCurrTableDesc.Name = "lblCurrTableDesc";
			this.lblCurrTableDesc.Size = new global::System.Drawing.Size(21, 20);
			this.lblCurrTableDesc.TabIndex = 2;
			this.lblCurrTableDesc.Text = "...";
			this.lblCurrTableDesc.Visible = false;
			this.lblCurrentTable.AutoSize = true;
			this.lblCurrentTable.Location = new global::System.Drawing.Point(338, 72);
			this.lblCurrentTable.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblCurrentTable.Name = "lblCurrentTable";
			this.lblCurrentTable.Size = new global::System.Drawing.Size(21, 20);
			this.lblCurrentTable.TabIndex = 1;
			this.lblCurrentTable.Text = "...";
			this.lblCurrentTable.Visible = false;
			this.Label1.AutoSize = true;
			this.Label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label1.Location = new global::System.Drawing.Point(9, 37);
			this.Label1.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(478, 32);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "SELECT YOUR CURRENT TABLE";
			this.Panel2.Controls.Add(this.GroupBox4);
			this.Panel2.Controls.Add(this.GroupBox3);
			this.Panel2.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.Panel2.Location = new global::System.Drawing.Point(522, 0);
			this.Panel2.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new global::System.Drawing.Size(1108, 858);
			this.Panel2.TabIndex = 1;
			this.GroupBox4.AutoScroll = true;
			this.GroupBox4.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.GroupBox4.Location = new global::System.Drawing.Point(0, 106);
			this.GroupBox4.Name = "GroupBox4";
			this.GroupBox4.Size = new global::System.Drawing.Size(1108, 752);
			this.GroupBox4.TabIndex = 2;
			this.GroupBox3.BackColor = global::System.Drawing.Color.Lime;
			this.GroupBox3.Controls.Add(this.Button1);
			this.GroupBox3.Controls.Add(this.Label2);
			this.GroupBox3.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.GroupBox3.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox3.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GroupBox3.Name = "GroupBox3";
			this.GroupBox3.Padding = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GroupBox3.Size = new global::System.Drawing.Size(1108, 106);
			this.GroupBox3.TabIndex = 1;
			this.GroupBox3.TabStop = false;
			this.Label2.AutoSize = true;
			this.Label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label2.Location = new global::System.Drawing.Point(75, 37);
			this.Label2.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(349, 32);
			this.Label2.TabIndex = 1;
			this.Label2.Text = "SELECT A FREE TABLE";
			this.Button1.Location = new global::System.Drawing.Point(717, 37);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(322, 54);
			this.Button1.TabIndex = 2;
			this.Button1.Text = "Create New Table";
			this.Button1.UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1630, 858);
			base.Controls.Add(this.Panel2);
			base.Controls.Add(this.Panel1);
			base.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			base.Name = "SelectTable";
			this.Text = "Select Table";
			this.Panel1.ResumeLayout(false);
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.Panel2.ResumeLayout(false);
			this.GroupBox3.ResumeLayout(false);
			this.GroupBox3.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x040023D0 RID: 9168
		private global::System.ComponentModel.IContainer components;
	}
}
