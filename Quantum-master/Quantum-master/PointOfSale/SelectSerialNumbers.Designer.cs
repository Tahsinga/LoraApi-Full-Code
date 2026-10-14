namespace PointOfSale
{
	// Token: 0x020001BB RID: 443
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class SelectSerialNumbers : global::System.Windows.Forms.Form
	{
		// Token: 0x0600500D RID: 20493 RVA: 0x002FCA04 File Offset: 0x002FAC04
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

		// Token: 0x0600500E RID: 20494 RVA: 0x002FCA54 File Offset: 0x002FAC54
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.GroupBox2 = new global::System.Windows.Forms.GroupBox();
			this.Button2 = new global::System.Windows.Forms.Button();
			this.txtSearch = new global::System.Windows.Forms.TextBox();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.TXTDESC = new global::System.Windows.Forms.TextBox();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.dgvSerials = new global::System.Windows.Forms.DataGridView();
			this.lblNumOfSerials = new global::System.Windows.Forms.Label();
			this.GroupBox1.SuspendLayout();
			this.GroupBox2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvSerials).BeginInit();
			base.SuspendLayout();
			this.GroupBox1.Controls.Add(this.lblNumOfSerials);
			this.GroupBox1.Controls.Add(this.GroupBox2);
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.TXTDESC);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new global::System.Drawing.Size(862, 259);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.GroupBox2.Controls.Add(this.Button2);
			this.GroupBox2.Controls.Add(this.txtSearch);
			this.GroupBox2.Controls.Add(this.Label4);
			this.GroupBox2.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.GroupBox2.Location = new global::System.Drawing.Point(3, 182);
			this.GroupBox2.Name = "GroupBox2";
			this.GroupBox2.Size = new global::System.Drawing.Size(856, 74);
			this.GroupBox2.TabIndex = 10;
			this.GroupBox2.TabStop = false;
			this.GroupBox2.Text = "Search";
			this.Button2.BackColor = global::System.Drawing.Color.Yellow;
			this.Button2.Location = new global::System.Drawing.Point(265, 30);
			this.Button2.Name = "Button2";
			this.Button2.Size = new global::System.Drawing.Size(114, 32);
			this.Button2.TabIndex = 8;
			this.Button2.Text = "Search";
			this.Button2.UseVisualStyleBackColor = false;
			this.txtSearch.Location = new global::System.Drawing.Point(92, 33);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new global::System.Drawing.Size(167, 26);
			this.txtSearch.TabIndex = 7;
			this.Label4.AutoSize = true;
			this.Label4.Location = new global::System.Drawing.Point(22, 36);
			this.Label4.Name = "Label4";
			this.Label4.Size = new global::System.Drawing.Size(64, 20);
			this.Label4.TabIndex = 6;
			this.Label4.Text = "Search:";
			this.Button1.BackColor = global::System.Drawing.Color.Lime;
			this.Button1.Location = new global::System.Drawing.Point(291, 141);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(139, 35);
			this.Button1.TabIndex = 9;
			this.Button1.Text = "SUBMIT";
			this.Button1.UseVisualStyleBackColor = false;
			this.Label3.AutoSize = true;
			this.Label3.Location = new global::System.Drawing.Point(29, 108);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(256, 20);
			this.Label3.TabIndex = 8;
			this.Label3.Text = "Number of serial numbers required:";
			this.Label2.AutoSize = true;
			this.Label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label2.Location = new global::System.Drawing.Point(77, 22);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(537, 29);
			this.Label2.TabIndex = 7;
			this.Label2.Text = "SELECT SERIAL NUMBERS FOR PRODUCT";
			this.TXTDESC.Enabled = false;
			this.TXTDESC.Location = new global::System.Drawing.Point(291, 66);
			this.TXTDESC.Name = "TXTDESC";
			this.TXTDESC.Size = new global::System.Drawing.Size(415, 26);
			this.TXTDESC.TabIndex = 6;
			this.Label1.AutoSize = true;
			this.Label1.Location = new global::System.Drawing.Point(217, 68);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(68, 20);
			this.Label1.TabIndex = 5;
			this.Label1.Text = "Product:";
			this.dgvSerials.AllowUserToAddRows = false;
			this.dgvSerials.AllowUserToDeleteRows = false;
			this.dgvSerials.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSerials.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dgvSerials.Location = new global::System.Drawing.Point(0, 259);
			this.dgvSerials.Name = "dgvSerials";
			this.dgvSerials.RowTemplate.Height = 28;
			this.dgvSerials.Size = new global::System.Drawing.Size(862, 483);
			this.dgvSerials.TabIndex = 1;
			this.lblNumOfSerials.AutoSize = true;
			this.lblNumOfSerials.Location = new global::System.Drawing.Point(291, 108);
			this.lblNumOfSerials.Name = "lblNumOfSerials";
			this.lblNumOfSerials.Size = new global::System.Drawing.Size(21, 20);
			this.lblNumOfSerials.TabIndex = 11;
			this.lblNumOfSerials.Text = "...";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(862, 742);
			base.Controls.Add(this.dgvSerials);
			base.Controls.Add(this.GroupBox1);
			base.Name = "SelectSerialNumbers";
			this.Text = "Select Serial Numbers";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.GroupBox2.ResumeLayout(false);
			this.GroupBox2.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvSerials).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x040023BE RID: 9150
		private global::System.ComponentModel.IContainer components;
	}
}
