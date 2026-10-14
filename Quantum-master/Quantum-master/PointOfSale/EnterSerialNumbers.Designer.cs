namespace PointOfSale
{
	// Token: 0x02000055 RID: 85
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class EnterSerialNumbers : global::System.Windows.Forms.Form
	{
		// Token: 0x060011DF RID: 4575 RVA: 0x000AB868 File Offset: 0x000A9A68
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

		// Token: 0x060011E0 RID: 4576 RVA: 0x000AB8B8 File Offset: 0x000A9AB8
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.dgvSerials = new global::System.Windows.Forms.DataGridView();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.TXTDESC = new global::System.Windows.Forms.TextBox();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.GroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvSerials).BeginInit();
			base.SuspendLayout();
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.TXTDESC);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new global::System.Drawing.Size(778, 193);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.dgvSerials.AllowUserToAddRows = false;
			this.dgvSerials.AllowUserToDeleteRows = false;
			this.dgvSerials.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSerials.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dgvSerials.Location = new global::System.Drawing.Point(0, 193);
			this.dgvSerials.Name = "dgvSerials";
			this.dgvSerials.RowTemplate.Height = 28;
			this.dgvSerials.Size = new global::System.Drawing.Size(778, 299);
			this.dgvSerials.TabIndex = 1;
			this.Label1.AutoSize = true;
			this.Label1.Location = new global::System.Drawing.Point(35, 68);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(68, 20);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Product:";
			this.TXTDESC.Enabled = false;
			this.TXTDESC.Location = new global::System.Drawing.Point(109, 66);
			this.TXTDESC.Name = "TXTDESC";
			this.TXTDESC.Size = new global::System.Drawing.Size(415, 26);
			this.TXTDESC.TabIndex = 1;
			this.Label2.AutoSize = true;
			this.Label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label2.Location = new global::System.Drawing.Point(12, 22);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(700, 29);
			this.Label2.TabIndex = 2;
			this.Label2.Text = "ENTER SERIAL NUMBERS FOR NEW STOCK PURCHASE";
			this.Label3.AutoSize = true;
			this.Label3.Location = new global::System.Drawing.Point(35, 107);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(83, 20);
			this.Label3.TabIndex = 3;
			this.Label3.Text = "Number of";
			this.Button1.BackColor = global::System.Drawing.Color.Lime;
			this.Button1.Location = new global::System.Drawing.Point(109, 141);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(139, 35);
			this.Button1.TabIndex = 4;
			this.Button1.Text = "SUBMIT";
			this.Button1.UseVisualStyleBackColor = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(778, 492);
			base.Controls.Add(this.dgvSerials);
			base.Controls.Add(this.GroupBox1);
			base.Name = "EnterSerialNumbers";
			this.Text = "EnterSerialNumbers";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvSerials).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000861 RID: 2145
		private global::System.ComponentModel.IContainer components;
	}
}
