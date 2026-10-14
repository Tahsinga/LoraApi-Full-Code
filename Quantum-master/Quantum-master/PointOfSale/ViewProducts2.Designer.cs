namespace PointOfSale
{
	// Token: 0x02000213 RID: 531
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class ViewProducts2 : global::System.Windows.Forms.Form
	{
		// Token: 0x06005F27 RID: 24359 RVA: 0x0036820C File Offset: 0x0036640C
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

		// Token: 0x06005F28 RID: 24360 RVA: 0x0036825C File Offset: 0x0036645C
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.lblerror = new global::System.Windows.Forms.Label();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.txtsearch = new global::System.Windows.Forms.TextBox();
			this.DataGridView1 = new global::System.Windows.Forms.DataGridView();
			this.GroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.DataGridView1).BeginInit();
			base.SuspendLayout();
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.lblerror);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Controls.Add(this.txtsearch);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new global::System.Drawing.Size(365, 112);
			this.GroupBox1.TabIndex = 1;
			this.GroupBox1.TabStop = false;
			this.Button1.Location = new global::System.Drawing.Point(239, 56);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(75, 23);
			this.Button1.TabIndex = 4;
			this.Button1.Text = "Show All";
			this.Button1.UseVisualStyleBackColor = true;
			this.Label2.AutoSize = true;
			this.Label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label2.Location = new global::System.Drawing.Point(21, 9);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(225, 24);
			this.Label2.TabIndex = 3;
			this.Label2.Text = "VIEW PRODUCT CODES";
			this.lblerror.AutoSize = true;
			this.lblerror.Location = new global::System.Drawing.Point(12, 80);
			this.lblerror.Name = "lblerror";
			this.lblerror.Size = new global::System.Drawing.Size(16, 13);
			this.lblerror.TabIndex = 2;
			this.lblerror.Text = "...";
			this.Label1.AutoSize = true;
			this.Label1.Location = new global::System.Drawing.Point(12, 40);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(249, 13);
			this.Label1.TabIndex = 1;
			this.Label1.Text = "Type in the space to search by product description:";
			this.txtsearch.Location = new global::System.Drawing.Point(15, 57);
			this.txtsearch.Name = "txtsearch";
			this.txtsearch.Size = new global::System.Drawing.Size(219, 20);
			this.txtsearch.TabIndex = 0;
			this.DataGridView1.AllowUserToAddRows = false;
			this.DataGridView1.AllowUserToDeleteRows = false;
			this.DataGridView1.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridView1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.DataGridView1.Location = new global::System.Drawing.Point(0, 112);
			this.DataGridView1.Name = "DataGridView1";
			this.DataGridView1.ReadOnly = true;
			this.DataGridView1.Size = new global::System.Drawing.Size(365, 502);
			this.DataGridView1.TabIndex = 2;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(365, 614);
			base.Controls.Add(this.DataGridView1);
			base.Controls.Add(this.GroupBox1);
			base.Name = "ViewProducts2";
			this.Text = "View Product Codes";
			base.TopMost = true;
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.DataGridView1).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x040029C7 RID: 10695
		private global::System.ComponentModel.IContainer components;
	}
}
