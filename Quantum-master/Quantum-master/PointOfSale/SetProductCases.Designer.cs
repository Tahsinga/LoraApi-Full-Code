namespace PointOfSale
{
	// Token: 0x020001DE RID: 478
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class SetProductCases : global::System.Windows.Forms.UserControl
	{
		// Token: 0x060053D6 RID: 21462 RVA: 0x0030A684 File Offset: 0x00308884
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

		// Token: 0x060053D7 RID: 21463 RVA: 0x0030A6D4 File Offset: 0x003088D4
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.Panel1 = new global::System.Windows.Forms.Panel();
			this.GroupBox2 = new global::System.Windows.Forms.GroupBox();
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.txtCaseQty = new global::System.Windows.Forms.TextBox();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.CheckBox1 = new global::System.Windows.Forms.CheckBox();
			this.txtDesc = new global::System.Windows.Forms.TextBox();
			this.Panel3 = new global::System.Windows.Forms.Panel();
			this.txtSearchProductCode = new global::System.Windows.Forms.TextBox();
			this.Label24 = new global::System.Windows.Forms.Label();
			this.Label20 = new global::System.Windows.Forms.Label();
			this.txtBarCode = new global::System.Windows.Forms.TextBox();
			this.Panel2 = new global::System.Windows.Forms.Panel();
			this.DGVSearch = new global::System.Windows.Forms.DataGridView();
			this.GroupBox4 = new global::System.Windows.Forms.GroupBox();
			this.Label34 = new global::System.Windows.Forms.Label();
			this.Button3 = new global::System.Windows.Forms.Button();
			this.Label19 = new global::System.Windows.Forms.Label();
			this.txtsearch = new global::System.Windows.Forms.TextBox();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.Panel1.SuspendLayout();
			this.GroupBox1.SuspendLayout();
			this.Panel3.SuspendLayout();
			this.Panel2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.DGVSearch).BeginInit();
			this.GroupBox4.SuspendLayout();
			base.SuspendLayout();
			this.Panel1.Controls.Add(this.GroupBox2);
			this.Panel1.Controls.Add(this.GroupBox1);
			this.Panel1.Controls.Add(this.CheckBox1);
			this.Panel1.Controls.Add(this.txtDesc);
			this.Panel1.Controls.Add(this.Panel3);
			this.Panel1.Controls.Add(this.Panel2);
			this.Panel1.Controls.Add(this.Label1);
			this.Panel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.Panel1.Location = new global::System.Drawing.Point(0, 0);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new global::System.Drawing.Size(1230, 502);
			this.Panel1.TabIndex = 0;
			this.GroupBox2.Location = new global::System.Drawing.Point(585, 384);
			this.GroupBox2.Name = "GroupBox2";
			this.GroupBox2.Size = new global::System.Drawing.Size(305, 100);
			this.GroupBox2.TabIndex = 38;
			this.GroupBox2.TabStop = false;
			this.GroupBox2.Text = "Set Case Product";
			this.GroupBox1.Controls.Add(this.txtCaseQty);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Location = new global::System.Drawing.Point(585, 277);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new global::System.Drawing.Size(305, 94);
			this.GroupBox1.TabIndex = 37;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Case Details";
			this.txtCaseQty.Location = new global::System.Drawing.Point(141, 42);
			this.txtCaseQty.Name = "txtCaseQty";
			this.txtCaseQty.Size = new global::System.Drawing.Size(100, 26);
			this.txtCaseQty.TabIndex = 36;
			this.Label2.AutoSize = true;
			this.Label2.Location = new global::System.Drawing.Point(41, 45);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(94, 20);
			this.Label2.TabIndex = 34;
			this.Label2.Text = "Qty in Case:";
			this.CheckBox1.AutoSize = true;
			this.CheckBox1.Location = new global::System.Drawing.Point(556, 247);
			this.CheckBox1.Name = "CheckBox1";
			this.CheckBox1.Size = new global::System.Drawing.Size(168, 24);
			this.CheckBox1.TabIndex = 35;
			this.CheckBox1.Text = "Product is a Case?";
			this.CheckBox1.UseVisualStyleBackColor = true;
			this.txtDesc.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtDesc.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.txtDesc.Enabled = false;
			this.txtDesc.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtDesc.ForeColor = global::System.Drawing.Color.Red;
			this.txtDesc.Location = new global::System.Drawing.Point(469, 108);
			this.txtDesc.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtDesc.Multiline = true;
			this.txtDesc.Name = "txtDesc";
			this.txtDesc.ReadOnly = true;
			this.txtDesc.Size = new global::System.Drawing.Size(712, 117);
			this.txtDesc.TabIndex = 33;
			this.txtDesc.TabStop = false;
			this.Panel3.Controls.Add(this.txtSearchProductCode);
			this.Panel3.Controls.Add(this.Label24);
			this.Panel3.Controls.Add(this.Label20);
			this.Panel3.Controls.Add(this.txtBarCode);
			this.Panel3.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.Panel3.Location = new global::System.Drawing.Point(469, 0);
			this.Panel3.Name = "Panel3";
			this.Panel3.Size = new global::System.Drawing.Size(712, 108);
			this.Panel3.TabIndex = 32;
			this.txtSearchProductCode.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtSearchProductCode.Location = new global::System.Drawing.Point(263, 2);
			this.txtSearchProductCode.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtSearchProductCode.Name = "txtSearchProductCode";
			this.txtSearchProductCode.Size = new global::System.Drawing.Size(181, 35);
			this.txtSearchProductCode.TabIndex = 56;
			this.txtSearchProductCode.TabStop = false;
			this.txtSearchProductCode.Visible = false;
			this.Label24.AutoSize = true;
			this.Label24.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Italic, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label24.ForeColor = global::System.Drawing.Color.Red;
			this.Label24.Location = new global::System.Drawing.Point(483, 51);
			this.Label24.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label24.Name = "Label24";
			this.Label24.Size = new global::System.Drawing.Size(28, 20);
			this.Label24.TabIndex = 55;
			this.Label24.Text = "F1";
			this.Label20.AutoSize = true;
			this.Label20.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label20.Location = new global::System.Drawing.Point(73, 51);
			this.Label20.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label20.Name = "Label20";
			this.Label20.Size = new global::System.Drawing.Size(130, 25);
			this.Label20.TabIndex = 38;
			this.Label20.Text = "BAR CODE:";
			this.txtBarCode.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtBarCode.Location = new global::System.Drawing.Point(217, 42);
			this.txtBarCode.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtBarCode.Name = "txtBarCode";
			this.txtBarCode.Size = new global::System.Drawing.Size(258, 35);
			this.txtBarCode.TabIndex = 37;
			this.txtBarCode.TabStop = false;
			this.Panel2.BackColor = global::System.Drawing.Color.FromArgb(192, 255, 255);
			this.Panel2.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.Panel2.Controls.Add(this.DGVSearch);
			this.Panel2.Controls.Add(this.GroupBox4);
			this.Panel2.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.Panel2.Location = new global::System.Drawing.Point(0, 0);
			this.Panel2.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new global::System.Drawing.Size(469, 502);
			this.Panel2.TabIndex = 30;
			this.Panel2.Visible = false;
			this.DGVSearch.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DGVSearch.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.DGVSearch.Location = new global::System.Drawing.Point(0, 106);
			this.DGVSearch.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.DGVSearch.Name = "DGVSearch";
			this.DGVSearch.ReadOnly = true;
			this.DGVSearch.Size = new global::System.Drawing.Size(465, 392);
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
			this.Label1.AutoSize = true;
			this.Label1.BackColor = global::System.Drawing.Color.Red;
			this.Label1.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.Label1.Location = new global::System.Drawing.Point(1181, 0);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(49, 20);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Close";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.Controls.Add(this.Panel1);
			base.Name = "SetProductCases";
			base.Size = new global::System.Drawing.Size(1230, 502);
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.Panel3.ResumeLayout(false);
			this.Panel3.PerformLayout();
			this.Panel2.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.DGVSearch).EndInit();
			this.GroupBox4.ResumeLayout(false);
			this.GroupBox4.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x0400248F RID: 9359
		private global::System.ComponentModel.IContainer components;
	}
}
