namespace PointOfSale
{
	// Token: 0x02000050 RID: 80
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class EditProductSupplier : global::System.Windows.Forms.Form
	{
		// Token: 0x06001140 RID: 4416 RVA: 0x000A67EC File Offset: 0x000A49EC
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

		// Token: 0x06001141 RID: 4417 RVA: 0x000A683C File Offset: 0x000A4A3C
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.Panel1 = new global::System.Windows.Forms.Panel();
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.Label5 = new global::System.Windows.Forms.Label();
			this.lblsupplierid = new global::System.Windows.Forms.Label();
			this.lblproductid = new global::System.Windows.Forms.Label();
			this.Button4 = new global::System.Windows.Forms.Button();
			this.cboSupplier = new global::System.Windows.Forms.ComboBox();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.lblSupplier = new global::System.Windows.Forms.Label();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.lblDesc = new global::System.Windows.Forms.Label();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.Panel2 = new global::System.Windows.Forms.Panel();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.txtSearchProductCode = new global::System.Windows.Forms.TextBox();
			this.Label15 = new global::System.Windows.Forms.Label();
			this.txtBarcode = new global::System.Windows.Forms.TextBox();
			this.lblerror = new global::System.Windows.Forms.Label();
			this.Panel3 = new global::System.Windows.Forms.Panel();
			this.DGVSearch = new global::System.Windows.Forms.DataGridView();
			this.GroupBox4 = new global::System.Windows.Forms.GroupBox();
			this.Label34 = new global::System.Windows.Forms.Label();
			this.Button3 = new global::System.Windows.Forms.Button();
			this.Label19 = new global::System.Windows.Forms.Label();
			this.txtsearch = new global::System.Windows.Forms.TextBox();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.Panel1.SuspendLayout();
			this.GroupBox1.SuspendLayout();
			this.Panel2.SuspendLayout();
			this.Panel3.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.DGVSearch).BeginInit();
			this.GroupBox4.SuspendLayout();
			base.SuspendLayout();
			this.Panel1.Controls.Add(this.GroupBox1);
			this.Panel1.Controls.Add(this.Panel2);
			this.Panel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.Panel1.Location = new global::System.Drawing.Point(0, 0);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new global::System.Drawing.Size(1002, 691);
			this.Panel1.TabIndex = 0;
			this.GroupBox1.Controls.Add(this.Label5);
			this.GroupBox1.Controls.Add(this.lblsupplierid);
			this.GroupBox1.Controls.Add(this.lblproductid);
			this.GroupBox1.Controls.Add(this.Button4);
			this.GroupBox1.Controls.Add(this.cboSupplier);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.lblSupplier);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.lblDesc);
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 323);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new global::System.Drawing.Size(1002, 368);
			this.GroupBox1.TabIndex = 44;
			this.GroupBox1.TabStop = false;
			this.Label5.AutoSize = true;
			this.Label5.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8f, global::System.Drawing.FontStyle.Italic, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label5.Location = new global::System.Drawing.Point(204, 257);
			this.Label5.Name = "Label5";
			this.Label5.Size = new global::System.Drawing.Size(376, 20);
			this.Label5.TabIndex = 65;
			this.Label5.Text = "alternatively type the first letter of the supplier name)";
			this.lblsupplierid.AutoSize = true;
			this.lblsupplierid.Location = new global::System.Drawing.Point(921, 133);
			this.lblsupplierid.Name = "lblsupplierid";
			this.lblsupplierid.Size = new global::System.Drawing.Size(18, 20);
			this.lblsupplierid.TabIndex = 64;
			this.lblsupplierid.Text = "0";
			this.lblproductid.AutoSize = true;
			this.lblproductid.Location = new global::System.Drawing.Point(8, 153);
			this.lblproductid.Name = "lblproductid";
			this.lblproductid.Size = new global::System.Drawing.Size(21, 20);
			this.lblproductid.TabIndex = 63;
			this.lblproductid.Text = "...";
			this.Button4.BackColor = global::System.Drawing.Color.Yellow;
			this.Button4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Button4.Location = new global::System.Drawing.Point(668, 207);
			this.Button4.Name = "Button4";
			this.Button4.Size = new global::System.Drawing.Size(298, 45);
			this.Button4.TabIndex = 62;
			this.Button4.Text = "Create New Supplier";
			this.Button4.UseVisualStyleBackColor = false;
			this.cboSupplier.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.cboSupplier.FormattingEnabled = true;
			this.cboSupplier.Location = new global::System.Drawing.Point(202, 213);
			this.cboSupplier.Name = "cboSupplier";
			this.cboSupplier.Size = new global::System.Drawing.Size(460, 37);
			this.cboSupplier.TabIndex = 61;
			this.Label3.AutoSize = true;
			this.Label3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label3.Location = new global::System.Drawing.Point(8, 216);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(166, 29);
			this.Label3.TabIndex = 3;
			this.Label3.Text = "New Supplier:";
			this.lblSupplier.AutoSize = true;
			this.lblSupplier.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblSupplier.Location = new global::System.Drawing.Point(207, 176);
			this.lblSupplier.Name = "lblSupplier";
			this.lblSupplier.Size = new global::System.Drawing.Size(31, 29);
			this.lblSupplier.TabIndex = 2;
			this.lblSupplier.Text = "...";
			this.Label2.AutoSize = true;
			this.Label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label2.Location = new global::System.Drawing.Point(8, 176);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(195, 29);
			this.Label2.TabIndex = 1;
			this.Label2.Text = "Current Supplier:";
			this.lblDesc.BackColor = global::System.Drawing.Color.White;
			this.lblDesc.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblDesc.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblDesc.Location = new global::System.Drawing.Point(6, 22);
			this.lblDesc.Name = "lblDesc";
			this.lblDesc.Size = new global::System.Drawing.Size(963, 111);
			this.lblDesc.TabIndex = 0;
			this.lblDesc.Text = "...";
			this.Button1.BackColor = global::System.Drawing.Color.Lime;
			this.Button1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Button1.Location = new global::System.Drawing.Point(202, 298);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(268, 50);
			this.Button1.TabIndex = 1;
			this.Button1.Text = "Save Changes";
			this.Button1.UseVisualStyleBackColor = false;
			this.Panel2.Controls.Add(this.Label4);
			this.Panel2.Controls.Add(this.txtSearchProductCode);
			this.Panel2.Controls.Add(this.Label15);
			this.Panel2.Controls.Add(this.txtBarcode);
			this.Panel2.Controls.Add(this.lblerror);
			this.Panel2.Controls.Add(this.Panel3);
			this.Panel2.Controls.Add(this.Label1);
			this.Panel2.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.Panel2.Location = new global::System.Drawing.Point(0, 0);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new global::System.Drawing.Size(1002, 323);
			this.Panel2.TabIndex = 0;
			this.Label4.AutoSize = true;
			this.Label4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8f, global::System.Drawing.FontStyle.Italic, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label4.Location = new global::System.Drawing.Point(476, 138);
			this.Label4.Name = "Label4";
			this.Label4.Size = new global::System.Drawing.Size(319, 20);
			this.Label4.TabIndex = 43;
			this.Label4.Text = "(alternatively type the code and press Enter)";
			this.txtSearchProductCode.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtSearchProductCode.Location = new global::System.Drawing.Point(510, 206);
			this.txtSearchProductCode.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtSearchProductCode.Name = "txtSearchProductCode";
			this.txtSearchProductCode.Size = new global::System.Drawing.Size(181, 35);
			this.txtSearchProductCode.TabIndex = 42;
			this.txtSearchProductCode.TabStop = false;
			this.txtSearchProductCode.Visible = false;
			this.Label15.AutoSize = true;
			this.Label15.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label15.Location = new global::System.Drawing.Point(472, 60);
			this.Label15.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label15.Name = "Label15";
			this.Label15.Size = new global::System.Drawing.Size(240, 25);
			this.Label15.TabIndex = 41;
			this.Label15.Text = "SEARCH BY BAR CODE:";
			this.txtBarcode.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtBarcode.Location = new global::System.Drawing.Point(477, 94);
			this.txtBarcode.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtBarcode.Name = "txtBarcode";
			this.txtBarcode.Size = new global::System.Drawing.Size(298, 39);
			this.txtBarcode.TabIndex = 40;
			this.lblerror.AutoSize = true;
			this.lblerror.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.lblerror.Location = new global::System.Drawing.Point(469, 303);
			this.lblerror.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblerror.Name = "lblerror";
			this.lblerror.Size = new global::System.Drawing.Size(21, 20);
			this.lblerror.TabIndex = 31;
			this.lblerror.Text = "...";
			this.Panel3.BackColor = global::System.Drawing.Color.FromArgb(192, 255, 255);
			this.Panel3.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.Panel3.Controls.Add(this.DGVSearch);
			this.Panel3.Controls.Add(this.GroupBox4);
			this.Panel3.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.Panel3.Location = new global::System.Drawing.Point(0, 0);
			this.Panel3.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Panel3.Name = "Panel3";
			this.Panel3.Size = new global::System.Drawing.Size(469, 323);
			this.Panel3.TabIndex = 30;
			this.DGVSearch.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DGVSearch.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.DGVSearch.Location = new global::System.Drawing.Point(0, 106);
			this.DGVSearch.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.DGVSearch.Name = "DGVSearch";
			this.DGVSearch.ReadOnly = true;
			this.DGVSearch.Size = new global::System.Drawing.Size(465, 213);
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
			this.Label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label1.Location = new global::System.Drawing.Point(471, 9);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(510, 32);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Select  a product to edit the Supplier";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1002, 691);
			base.Controls.Add(this.Panel1);
			base.Name = "EditProductSupplier";
			this.Text = "Edit Product Supplier";
			this.Panel1.ResumeLayout(false);
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.Panel2.ResumeLayout(false);
			this.Panel2.PerformLayout();
			this.Panel3.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.DGVSearch).EndInit();
			this.GroupBox4.ResumeLayout(false);
			this.GroupBox4.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04000821 RID: 2081
		private global::System.ComponentModel.IContainer components;
	}
}
