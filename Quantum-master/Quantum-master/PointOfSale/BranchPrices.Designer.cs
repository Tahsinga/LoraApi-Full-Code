namespace PointOfSale
{
	// Token: 0x02000018 RID: 24
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class BranchPrices : global::System.Windows.Forms.Form
	{
		// Token: 0x06000437 RID: 1079 RVA: 0x000274B8 File Offset: 0x000256B8
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

		// Token: 0x06000438 RID: 1080 RVA: 0x00027508 File Offset: 0x00025708
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.Label15 = new global::System.Windows.Forms.Label();
			this.txtProductCode = new global::System.Windows.Forms.TextBox();
			this.lblerror = new global::System.Windows.Forms.Label();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.Button4 = new global::System.Windows.Forms.Button();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.lblView = new global::System.Windows.Forms.Label();
			this.cboBranch = new global::System.Windows.Forms.ComboBox();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.Panel2 = new global::System.Windows.Forms.Panel();
			this.DGVSearch = new global::System.Windows.Forms.DataGridView();
			this.GroupBox4 = new global::System.Windows.Forms.GroupBox();
			this.Button3 = new global::System.Windows.Forms.Button();
			this.Label19 = new global::System.Windows.Forms.Label();
			this.txtsearch = new global::System.Windows.Forms.TextBox();
			this.dgvProducts = new global::System.Windows.Forms.DataGridView();
			this.GroupBox1.SuspendLayout();
			this.Panel2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.DGVSearch).BeginInit();
			this.GroupBox4.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvProducts).BeginInit();
			base.SuspendLayout();
			this.GroupBox1.Controls.Add(this.Label15);
			this.GroupBox1.Controls.Add(this.txtProductCode);
			this.GroupBox1.Controls.Add(this.lblerror);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.Button4);
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Controls.Add(this.lblView);
			this.GroupBox1.Controls.Add(this.cboBranch);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Controls.Add(this.Panel2);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Padding = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GroupBox1.Size = new global::System.Drawing.Size(1678, 355);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.Label15.AutoSize = true;
			this.Label15.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label15.Location = new global::System.Drawing.Point(483, 69);
			this.Label15.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label15.Name = "Label15";
			this.Label15.Size = new global::System.Drawing.Size(224, 20);
			this.Label15.TabIndex = 43;
			this.Label15.Text = "SEARCH BY BAR CODE:";
			this.Label15.Visible = false;
			this.txtProductCode.Location = new global::System.Drawing.Point(488, 94);
			this.txtProductCode.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtProductCode.Name = "txtProductCode";
			this.txtProductCode.Size = new global::System.Drawing.Size(253, 26);
			this.txtProductCode.TabIndex = 42;
			this.txtProductCode.Visible = false;
			this.lblerror.AutoSize = true;
			this.lblerror.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.lblerror.Location = new global::System.Drawing.Point(476, 330);
			this.lblerror.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblerror.Name = "lblerror";
			this.lblerror.Size = new global::System.Drawing.Size(21, 20);
			this.lblerror.TabIndex = 41;
			this.lblerror.Text = "...";
			this.Label2.AutoSize = true;
			this.Label2.Location = new global::System.Drawing.Point(818, 65);
			this.Label2.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(146, 20);
			this.Label2.TabIndex = 40;
			this.Label2.Text = "Load Global Prices:";
			this.Button4.BackColor = global::System.Drawing.Color.Lime;
			this.Button4.Location = new global::System.Drawing.Point(981, 225);
			this.Button4.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Button4.Name = "Button4";
			this.Button4.Size = new global::System.Drawing.Size(288, 35);
			this.Button4.TabIndex = 39;
			this.Button4.Text = "Save All Price Changes";
			this.Button4.UseVisualStyleBackColor = false;
			this.Button1.Location = new global::System.Drawing.Point(981, 57);
			this.Button1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(288, 35);
			this.Button1.TabIndex = 37;
			this.Button1.Text = "Load Global Prices";
			this.Button1.UseVisualStyleBackColor = true;
			this.lblView.AutoSize = true;
			this.lblView.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblView.Location = new global::System.Drawing.Point(975, 158);
			this.lblView.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblView.Name = "lblView";
			this.lblView.Size = new global::System.Drawing.Size(49, 29);
			this.lblView.TabIndex = 36;
			this.lblView.Text = "......";
			this.cboBranch.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboBranch.FormattingEnabled = true;
			this.cboBranch.Location = new global::System.Drawing.Point(981, 102);
			this.cboBranch.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cboBranch.Name = "cboBranch";
			this.cboBranch.Size = new global::System.Drawing.Size(286, 28);
			this.cboBranch.TabIndex = 35;
			this.Label1.AutoSize = true;
			this.Label1.Location = new global::System.Drawing.Point(818, 111);
			this.Label1.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(151, 20);
			this.Label1.TabIndex = 34;
			this.Label1.Text = "Load Branch Prices:";
			this.Panel2.BackColor = global::System.Drawing.Color.FromArgb(192, 255, 255);
			this.Panel2.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.Panel2.Controls.Add(this.DGVSearch);
			this.Panel2.Controls.Add(this.GroupBox4);
			this.Panel2.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.Panel2.Location = new global::System.Drawing.Point(4, 24);
			this.Panel2.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new global::System.Drawing.Size(472, 326);
			this.Panel2.TabIndex = 33;
			this.DGVSearch.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DGVSearch.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.DGVSearch.Location = new global::System.Drawing.Point(0, 106);
			this.DGVSearch.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.DGVSearch.Name = "DGVSearch";
			this.DGVSearch.ReadOnly = true;
			this.DGVSearch.Size = new global::System.Drawing.Size(468, 216);
			this.DGVSearch.StandardTab = true;
			this.DGVSearch.TabIndex = 2;
			this.GroupBox4.Controls.Add(this.Button3);
			this.GroupBox4.Controls.Add(this.Label19);
			this.GroupBox4.Controls.Add(this.txtsearch);
			this.GroupBox4.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox4.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox4.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GroupBox4.Name = "GroupBox4";
			this.GroupBox4.Padding = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GroupBox4.Size = new global::System.Drawing.Size(468, 106);
			this.GroupBox4.TabIndex = 1;
			this.GroupBox4.TabStop = false;
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
			this.Label19.Location = new global::System.Drawing.Point(8, 20);
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
			this.dgvProducts.AllowUserToAddRows = false;
			this.dgvProducts.AllowUserToDeleteRows = false;
			this.dgvProducts.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvProducts.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dgvProducts.Location = new global::System.Drawing.Point(0, 355);
			this.dgvProducts.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dgvProducts.Name = "dgvProducts";
			this.dgvProducts.Size = new global::System.Drawing.Size(1678, 322);
			this.dgvProducts.TabIndex = 1;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1678, 677);
			base.Controls.Add(this.dgvProducts);
			base.Controls.Add(this.GroupBox1);
			base.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			base.Name = "BranchPrices";
			this.Text = "BranchPrices";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.Panel2.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.DGVSearch).EndInit();
			this.GroupBox4.ResumeLayout(false);
			this.GroupBox4.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvProducts).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x040001F3 RID: 499
		private global::System.ComponentModel.IContainer components;
	}
}
