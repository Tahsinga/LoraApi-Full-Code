namespace PointOfSale
{
	// Token: 0x02000023 RID: 35
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class CheckConnectedbranchStatus : global::System.Windows.Forms.Form
	{
		// Token: 0x060006BF RID: 1727 RVA: 0x000445C8 File Offset: 0x000427C8
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

		// Token: 0x060006C0 RID: 1728 RVA: 0x00044618 File Offset: 0x00042818
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.txtCoid = new global::System.Windows.Forms.TextBox();
			this.dgvStatus = new global::System.Windows.Forms.DataGridView();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.Timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.lblinfo = new global::System.Windows.Forms.Label();
			this.GroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvStatus).BeginInit();
			base.SuspendLayout();
			this.GroupBox1.Controls.Add(this.lblinfo);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.txtCoid);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new global::System.Drawing.Size(733, 104);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Company ID";
			this.Label1.AutoSize = true;
			this.Label1.Location = new global::System.Drawing.Point(127, 30);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(45, 20);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Coid:";
			this.txtCoid.Location = new global::System.Drawing.Point(178, 27);
			this.txtCoid.Name = "txtCoid";
			this.txtCoid.ReadOnly = true;
			this.txtCoid.Size = new global::System.Drawing.Size(100, 26);
			this.txtCoid.TabIndex = 1;
			this.dgvStatus.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvStatus.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dgvStatus.Location = new global::System.Drawing.Point(0, 104);
			this.dgvStatus.Name = "dgvStatus";
			this.dgvStatus.RowTemplate.Height = 28;
			this.dgvStatus.Size = new global::System.Drawing.Size(733, 251);
			this.dgvStatus.TabIndex = 1;
			this.Label2.AutoSize = true;
			this.Label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8f, global::System.Drawing.FontStyle.Italic, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label2.ForeColor = global::System.Drawing.Color.FromArgb(0, 0, 192);
			this.Label2.Location = new global::System.Drawing.Point(284, 30);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(271, 20);
			this.Label2.TabIndex = 2;
			this.Label2.Text = "*automatically refreshes every minute";
			this.lblinfo.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.lblinfo.ForeColor = global::System.Drawing.Color.Red;
			this.lblinfo.Location = new global::System.Drawing.Point(3, 56);
			this.lblinfo.Name = "lblinfo";
			this.lblinfo.Size = new global::System.Drawing.Size(727, 45);
			this.lblinfo.TabIndex = 3;
			this.lblinfo.Text = "...";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(733, 355);
			base.Controls.Add(this.dgvStatus);
			base.Controls.Add(this.GroupBox1);
			base.Name = "CheckConnectedbranchStatus";
			this.Text = "Check Connected Branch Status";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvStatus).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000325 RID: 805
		private global::System.ComponentModel.IContainer components;
	}
}
