namespace PointOfSale
{
	// Token: 0x02000019 RID: 25
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class BreakCase : global::System.Windows.Forms.UserControl
	{
		// Token: 0x0600046E RID: 1134 RVA: 0x0002B278 File Offset: 0x00029478
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

		// Token: 0x0600046F RID: 1135 RVA: 0x0002B2C8 File Offset: 0x000294C8
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.Panel2 = new global::System.Windows.Forms.Panel();
			this.DGVSearch = new global::System.Windows.Forms.DataGridView();
			this.GroupBox4 = new global::System.Windows.Forms.GroupBox();
			this.Label34 = new global::System.Windows.Forms.Label();
			this.Button3 = new global::System.Windows.Forms.Button();
			this.Label19 = new global::System.Windows.Forms.Label();
			this.txtsearch = new global::System.Windows.Forms.TextBox();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.txtDesc = new global::System.Windows.Forms.TextBox();
			this.txtStockAvail = new global::System.Windows.Forms.TextBox();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.lblerror = new global::System.Windows.Forms.Label();
			this.GroupBox1.SuspendLayout();
			this.Panel2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.DGVSearch).BeginInit();
			this.GroupBox4.SuspendLayout();
			base.SuspendLayout();
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.txtDesc);
			this.GroupBox1.Controls.Add(this.txtStockAvail);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.lblerror);
			this.GroupBox1.Controls.Add(this.Panel2);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new global::System.Drawing.Size(1212, 443);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "BREAK CASE";
			this.Panel2.BackColor = global::System.Drawing.Color.FromArgb(192, 255, 255);
			this.Panel2.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.Panel2.Controls.Add(this.DGVSearch);
			this.Panel2.Controls.Add(this.GroupBox4);
			this.Panel2.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.Panel2.Location = new global::System.Drawing.Point(3, 22);
			this.Panel2.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new global::System.Drawing.Size(469, 418);
			this.Panel2.TabIndex = 30;
			this.Panel2.Visible = false;
			this.DGVSearch.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DGVSearch.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.DGVSearch.Location = new global::System.Drawing.Point(0, 106);
			this.DGVSearch.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.DGVSearch.Name = "DGVSearch";
			this.DGVSearch.ReadOnly = true;
			this.DGVSearch.Size = new global::System.Drawing.Size(465, 308);
			this.DGVSearch.StandardTab = true;
			this.DGVSearch.TabIndex = 2;
			this.GroupBox4.Controls.Add(this.Label34);
			this.GroupBox4.Controls.Add(this.Button3);
			this.GroupBox4.Controls.Add(this.Label19);
			this.GroupBox4.Controls.Add(this.txtsearch);
			this.GroupBox4.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox4.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox4.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GroupBox4.Name = "GroupBox4";
			this.GroupBox4.Padding = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GroupBox4.Size = new global::System.Drawing.Size(465, 106);
			this.GroupBox4.TabIndex = 1;
			this.GroupBox4.TabStop = false;
			this.Label34.AutoSize = true;
			this.Label34.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Italic, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label34.ForeColor = global::System.Drawing.Color.Red;
			this.Label34.Location = new global::System.Drawing.Point(9, 20);
			this.Label34.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label34.Name = "Label34";
			this.Label34.Size = new global::System.Drawing.Size(68, 20);
			this.Label34.TabIndex = 64;
			this.Label34.Text = "PageUp";
			this.Button3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Button3.Location = new global::System.Drawing.Point(350, 49);
			this.Button3.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Button3.Name = "Button3";
			this.Button3.Size = new global::System.Drawing.Size(112, 48);
			this.Button3.TabIndex = 10;
			this.Button3.TabStop = false;
			this.Button3.Text = "Show All";
			this.Button3.UseVisualStyleBackColor = true;
			this.Label19.AutoSize = true;
			this.Label19.Location = new global::System.Drawing.Point(86, 20);
			this.Label19.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label19.Name = "Label19";
			this.Label19.Size = new global::System.Drawing.Size(366, 20);
			this.Label19.TabIndex = 0;
			this.Label19.Text = "Type in the space to search by product description:";
			this.txtsearch.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtsearch.Location = new global::System.Drawing.Point(12, 52);
			this.txtsearch.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtsearch.Name = "txtsearch";
			this.txtsearch.Size = new global::System.Drawing.Size(326, 39);
			this.txtsearch.TabIndex = 1;
			this.Label2.AutoSize = true;
			this.Label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label2.Location = new global::System.Drawing.Point(496, 22);
			this.Label2.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(181, 25);
			this.Label2.TabIndex = 31;
			this.Label2.Text = "Product Description";
			this.txtDesc.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtDesc.Enabled = false;
			this.txtDesc.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtDesc.ForeColor = global::System.Drawing.Color.Red;
			this.txtDesc.Location = new global::System.Drawing.Point(501, 54);
			this.txtDesc.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtDesc.Multiline = true;
			this.txtDesc.Name = "txtDesc";
			this.txtDesc.ReadOnly = true;
			this.txtDesc.Size = new global::System.Drawing.Size(467, 117);
			this.txtDesc.TabIndex = 32;
			this.txtDesc.TabStop = false;
			this.txtStockAvail.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtStockAvail.Enabled = false;
			this.txtStockAvail.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtStockAvail.ForeColor = global::System.Drawing.Color.Red;
			this.txtStockAvail.Location = new global::System.Drawing.Point(707, 174);
			this.txtStockAvail.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtStockAvail.Name = "txtStockAvail";
			this.txtStockAvail.ReadOnly = true;
			this.txtStockAvail.Size = new global::System.Drawing.Size(116, 35);
			this.txtStockAvail.TabIndex = 33;
			this.txtStockAvail.TabStop = false;
			this.Label3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label3.Location = new global::System.Drawing.Point(496, 174);
			this.Label3.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(203, 34);
			this.Label3.TabIndex = 34;
			this.Label3.Text = "Stock Available:";
			this.lblerror.AutoSize = true;
			this.lblerror.Location = new global::System.Drawing.Point(977, 445);
			this.lblerror.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblerror.Name = "lblerror";
			this.lblerror.Size = new global::System.Drawing.Size(21, 20);
			this.lblerror.TabIndex = 35;
			this.lblerror.Text = "...";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.Controls.Add(this.GroupBox1);
			base.Name = "BreakCase";
			base.Size = new global::System.Drawing.Size(1212, 711);
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.Panel2.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.DGVSearch).EndInit();
			this.GroupBox4.ResumeLayout(false);
			this.GroupBox4.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04000209 RID: 521
		private global::System.ComponentModel.IContainer components;
	}
}
