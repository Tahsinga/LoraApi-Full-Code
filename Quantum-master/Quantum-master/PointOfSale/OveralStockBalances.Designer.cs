namespace PointOfSale
{
	// Token: 0x02000083 RID: 131
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class OveralStockBalances : global::System.Windows.Forms.UserControl
	{
		// Token: 0x06001E28 RID: 7720 RVA: 0x0010CCF0 File Offset: 0x0010AEF0
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

		// Token: 0x06001E29 RID: 7721 RVA: 0x0010CD40 File Offset: 0x0010AF40
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.Button2 = new global::System.Windows.Forms.Button();
			this.Label5 = new global::System.Windows.Forms.Label();
			this.cboCategories = new global::System.Windows.Forms.ComboBox();
			this.txtProductCode = new global::System.Windows.Forms.TextBox();
			this.lblerror = new global::System.Windows.Forms.Label();
			this.Panel2 = new global::System.Windows.Forms.Panel();
			this.DGVSearch = new global::System.Windows.Forms.DataGridView();
			this.GroupBox4 = new global::System.Windows.Forms.GroupBox();
			this.Button3 = new global::System.Windows.Forms.Button();
			this.Label19 = new global::System.Windows.Forms.Label();
			this.txtsearch = new global::System.Windows.Forms.TextBox();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.DTDate = new global::System.Windows.Forms.DateTimePicker();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.dgvStocks = new global::System.Windows.Forms.DataGridView();
			this.chkUseActual = new global::System.Windows.Forms.CheckBox();
			this.chkAllCats = new global::System.Windows.Forms.CheckBox();
			this.GroupBox1.SuspendLayout();
			this.Panel2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.DGVSearch).BeginInit();
			this.GroupBox4.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvStocks).BeginInit();
			base.SuspendLayout();
			this.GroupBox1.Controls.Add(this.chkAllCats);
			this.GroupBox1.Controls.Add(this.chkUseActual);
			this.GroupBox1.Controls.Add(this.Button2);
			this.GroupBox1.Controls.Add(this.Label5);
			this.GroupBox1.Controls.Add(this.cboCategories);
			this.GroupBox1.Controls.Add(this.txtProductCode);
			this.GroupBox1.Controls.Add(this.lblerror);
			this.GroupBox1.Controls.Add(this.Panel2);
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Controls.Add(this.DTDate);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Padding = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GroupBox1.Size = new global::System.Drawing.Size(1462, 306);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.Button2.Location = new global::System.Drawing.Point(888, 236);
			this.Button2.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Button2.Name = "Button2";
			this.Button2.Size = new global::System.Drawing.Size(141, 35);
			this.Button2.TabIndex = 55;
			this.Button2.Text = "Export to Excel";
			this.Button2.UseVisualStyleBackColor = true;
			this.Label5.AutoSize = true;
			this.Label5.Location = new global::System.Drawing.Point(596, 199);
			this.Label5.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label5.Name = "Label5";
			this.Label5.Size = new global::System.Drawing.Size(126, 20);
			this.Label5.TabIndex = 54;
			this.Label5.Text = "Select Category:";
			this.cboCategories.FormattingEnabled = true;
			this.cboCategories.Location = new global::System.Drawing.Point(729, 194);
			this.cboCategories.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cboCategories.Name = "cboCategories";
			this.cboCategories.Size = new global::System.Drawing.Size(298, 28);
			this.cboCategories.TabIndex = 53;
			this.txtProductCode.Location = new global::System.Drawing.Point(1190, 48);
			this.txtProductCode.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtProductCode.Name = "txtProductCode";
			this.txtProductCode.Size = new global::System.Drawing.Size(148, 26);
			this.txtProductCode.TabIndex = 35;
			this.txtProductCode.Visible = false;
			this.lblerror.AutoSize = true;
			this.lblerror.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.lblerror.Location = new global::System.Drawing.Point(476, 281);
			this.lblerror.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblerror.Name = "lblerror";
			this.lblerror.Size = new global::System.Drawing.Size(21, 20);
			this.lblerror.TabIndex = 34;
			this.lblerror.Text = "...";
			this.Panel2.BackColor = global::System.Drawing.Color.FromArgb(192, 255, 255);
			this.Panel2.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.Panel2.Controls.Add(this.DGVSearch);
			this.Panel2.Controls.Add(this.GroupBox4);
			this.Panel2.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.Panel2.Location = new global::System.Drawing.Point(4, 24);
			this.Panel2.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new global::System.Drawing.Size(472, 277);
			this.Panel2.TabIndex = 32;
			this.DGVSearch.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DGVSearch.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.DGVSearch.Location = new global::System.Drawing.Point(0, 106);
			this.DGVSearch.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.DGVSearch.Name = "DGVSearch";
			this.DGVSearch.ReadOnly = true;
			this.DGVSearch.Size = new global::System.Drawing.Size(468, 167);
			this.DGVSearch.StandardTab = true;
			this.DGVSearch.TabIndex = 1;
			this.GroupBox4.Controls.Add(this.Button3);
			this.GroupBox4.Controls.Add(this.Label19);
			this.GroupBox4.Controls.Add(this.txtsearch);
			this.GroupBox4.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox4.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox4.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GroupBox4.Name = "GroupBox4";
			this.GroupBox4.Padding = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GroupBox4.Size = new global::System.Drawing.Size(468, 106);
			this.GroupBox4.TabIndex = 0;
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
			this.Label19.TabIndex = 9;
			this.Label19.Text = "Type in the space to search by product description:";
			this.txtsearch.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtsearch.Location = new global::System.Drawing.Point(12, 52);
			this.txtsearch.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtsearch.Name = "txtsearch";
			this.txtsearch.Size = new global::System.Drawing.Size(326, 39);
			this.txtsearch.TabIndex = 0;
			this.Label4.AutoSize = true;
			this.Label4.Location = new global::System.Drawing.Point(597, 119);
			this.Label4.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label4.Name = "Label4";
			this.Label4.Size = new global::System.Drawing.Size(122, 20);
			this.Label4.TabIndex = 5;
			this.Label4.Text = "Balances As At:";
			this.DTDate.Location = new global::System.Drawing.Point(729, 114);
			this.DTDate.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.DTDate.Name = "DTDate";
			this.DTDate.Size = new global::System.Drawing.Size(298, 26);
			this.DTDate.TabIndex = 4;
			this.Label3.AutoSize = true;
			this.Label3.BackColor = global::System.Drawing.Color.Red;
			this.Label3.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.Label3.Location = new global::System.Drawing.Point(1409, 24);
			this.Label3.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(49, 20);
			this.Label3.TabIndex = 3;
			this.Label3.Text = "Close";
			this.Label1.AutoSize = true;
			this.Label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label1.Location = new global::System.Drawing.Point(594, 26);
			this.Label1.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(530, 32);
			this.Label1.TabIndex = 1;
			this.Label1.Text = "View Stock Balances for the Company";
			this.Button1.BackColor = global::System.Drawing.Color.Lime;
			this.Button1.Location = new global::System.Drawing.Point(729, 236);
			this.Button1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(150, 35);
			this.Button1.TabIndex = 0;
			this.Button1.Text = "Run Report";
			this.Button1.UseVisualStyleBackColor = false;
			this.dgvStocks.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvStocks.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dgvStocks.Location = new global::System.Drawing.Point(0, 306);
			this.dgvStocks.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dgvStocks.Name = "dgvStocks";
			this.dgvStocks.Size = new global::System.Drawing.Size(1462, 517);
			this.dgvStocks.TabIndex = 1;
			this.chkUseActual.AutoSize = true;
			this.chkUseActual.Checked = true;
			this.chkUseActual.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.chkUseActual.Location = new global::System.Drawing.Point(729, 82);
			this.chkUseActual.Name = "chkUseActual";
			this.chkUseActual.Size = new global::System.Drawing.Size(267, 24);
			this.chkUseActual.TabIndex = 56;
			this.chkUseActual.Text = "Use Current Running Bal (faster)";
			this.chkUseActual.UseVisualStyleBackColor = true;
			this.chkAllCats.AutoSize = true;
			this.chkAllCats.Location = new global::System.Drawing.Point(729, 162);
			this.chkAllCats.Name = "chkAllCats";
			this.chkAllCats.Size = new global::System.Drawing.Size(133, 24);
			this.chkAllCats.TabIndex = 57;
			this.chkAllCats.Text = "All Categories";
			this.chkAllCats.UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.Controls.Add(this.dgvStocks);
			base.Controls.Add(this.GroupBox1);
			base.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			base.Name = "OveralStockBalances";
			base.Size = new global::System.Drawing.Size(1462, 823);
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.Panel2.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.DGVSearch).EndInit();
			this.GroupBox4.ResumeLayout(false);
			this.GroupBox4.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvStocks).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000E5C RID: 3676
		private global::System.ComponentModel.IContainer components;
	}
}
