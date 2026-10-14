namespace PointOfSale
{
	// Token: 0x0200004E RID: 78
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class EditProductCategory : global::System.Windows.Forms.Form
	{
		// Token: 0x06001085 RID: 4229 RVA: 0x0009C25C File Offset: 0x0009A45C
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

		// Token: 0x06001086 RID: 4230 RVA: 0x0009C2AC File Offset: 0x0009A4AC
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.Label5 = new global::System.Windows.Forms.Label();
			this.txtBarCode = new global::System.Windows.Forms.TextBox();
			this.Label15 = new global::System.Windows.Forms.Label();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.cboCategory = new global::System.Windows.Forms.ComboBox();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.txtSearchProductCode = new global::System.Windows.Forms.TextBox();
			this.lblDesc = new global::System.Windows.Forms.TextBox();
			this.lblerror = new global::System.Windows.Forms.Label();
			this.Panel4 = new global::System.Windows.Forms.Panel();
			this.DGVSearch = new global::System.Windows.Forms.DataGridView();
			this.GroupBox4 = new global::System.Windows.Forms.GroupBox();
			this.Button4 = new global::System.Windows.Forms.Button();
			this.Label16 = new global::System.Windows.Forms.Label();
			this.txtsearch = new global::System.Windows.Forms.TextBox();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.cboNewCat = new global::System.Windows.Forms.ComboBox();
			this.GroupBox1.SuspendLayout();
			this.Panel4.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.DGVSearch).BeginInit();
			this.GroupBox4.SuspendLayout();
			base.SuspendLayout();
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Controls.Add(this.cboNewCat);
			this.GroupBox1.Controls.Add(this.Label5);
			this.GroupBox1.Controls.Add(this.txtBarCode);
			this.GroupBox1.Controls.Add(this.Label15);
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.cboCategory);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.txtSearchProductCode);
			this.GroupBox1.Controls.Add(this.lblDesc);
			this.GroupBox1.Controls.Add(this.lblerror);
			this.GroupBox1.Controls.Add(this.Panel4);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new global::System.Drawing.Size(933, 279);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.Label5.AutoSize = true;
			this.Label5.Location = new global::System.Drawing.Point(331, 38);
			this.Label5.Name = "Label5";
			this.Label5.Size = new global::System.Drawing.Size(54, 13);
			this.Label5.TabIndex = 60;
			this.Label5.Text = "Bar Code:";
			this.txtBarCode.Location = new global::System.Drawing.Point(391, 35);
			this.txtBarCode.Name = "txtBarCode";
			this.txtBarCode.Size = new global::System.Drawing.Size(132, 20);
			this.txtBarCode.TabIndex = 59;
			this.txtBarCode.TabStop = false;
			this.Label15.AutoSize = true;
			this.Label15.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label15.Location = new global::System.Drawing.Point(330, 19);
			this.Label15.Name = "Label15";
			this.Label15.Size = new global::System.Drawing.Size(174, 13);
			this.Label15.TabIndex = 58;
			this.Label15.Text = "SEARCH BY BAR CODE (F1):";
			this.Button1.BackColor = global::System.Drawing.Color.Lime;
			this.Button1.Location = new global::System.Drawing.Point(433, 229);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(142, 23);
			this.Button1.TabIndex = 57;
			this.Button1.Text = "Update Category";
			this.Button1.UseVisualStyleBackColor = false;
			this.Label2.AutoSize = true;
			this.Label2.Location = new global::System.Drawing.Point(338, 178);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(89, 13);
			this.Label2.TabIndex = 56;
			this.Label2.Text = "Current Category:";
			this.cboCategory.Enabled = false;
			this.cboCategory.FormattingEnabled = true;
			this.cboCategory.Location = new global::System.Drawing.Point(433, 175);
			this.cboCategory.Name = "cboCategory";
			this.cboCategory.Size = new global::System.Drawing.Size(250, 21);
			this.cboCategory.TabIndex = 55;
			this.Label1.AutoSize = true;
			this.Label1.Location = new global::System.Drawing.Point(331, 86);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(103, 13);
			this.Label1.TabIndex = 54;
			this.Label1.Text = "Product Description:";
			this.Label3.AutoSize = true;
			this.Label3.Location = new global::System.Drawing.Point(681, 86);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(75, 13);
			this.Label3.TabIndex = 53;
			this.Label3.Text = "Product Code:";
			this.Label3.Visible = false;
			this.txtSearchProductCode.Location = new global::System.Drawing.Point(762, 84);
			this.txtSearchProductCode.Name = "txtSearchProductCode";
			this.txtSearchProductCode.Size = new global::System.Drawing.Size(139, 20);
			this.txtSearchProductCode.TabIndex = 52;
			this.txtSearchProductCode.TabStop = false;
			this.txtSearchProductCode.Visible = false;
			this.lblDesc.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblDesc.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 24f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblDesc.ForeColor = global::System.Drawing.Color.Red;
			this.lblDesc.Location = new global::System.Drawing.Point(334, 110);
			this.lblDesc.Name = "lblDesc";
			this.lblDesc.ReadOnly = true;
			this.lblDesc.Size = new global::System.Drawing.Size(567, 44);
			this.lblDesc.TabIndex = 51;
			this.lblDesc.TabStop = false;
			this.lblerror.AutoSize = true;
			this.lblerror.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.lblerror.Location = new global::System.Drawing.Point(319, 263);
			this.lblerror.Name = "lblerror";
			this.lblerror.Size = new global::System.Drawing.Size(16, 13);
			this.lblerror.TabIndex = 50;
			this.lblerror.Text = "...";
			this.Panel4.BackColor = global::System.Drawing.Color.FromArgb(192, 255, 255);
			this.Panel4.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.Panel4.Controls.Add(this.DGVSearch);
			this.Panel4.Controls.Add(this.GroupBox4);
			this.Panel4.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.Panel4.Location = new global::System.Drawing.Point(3, 16);
			this.Panel4.Name = "Panel4";
			this.Panel4.Size = new global::System.Drawing.Size(316, 260);
			this.Panel4.TabIndex = 34;
			this.DGVSearch.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DGVSearch.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.DGVSearch.Location = new global::System.Drawing.Point(0, 69);
			this.DGVSearch.Name = "DGVSearch";
			this.DGVSearch.ReadOnly = true;
			this.DGVSearch.Size = new global::System.Drawing.Size(312, 187);
			this.DGVSearch.StandardTab = true;
			this.DGVSearch.TabIndex = 1;
			this.GroupBox4.Controls.Add(this.Button4);
			this.GroupBox4.Controls.Add(this.Label16);
			this.GroupBox4.Controls.Add(this.txtsearch);
			this.GroupBox4.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox4.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox4.Name = "GroupBox4";
			this.GroupBox4.Size = new global::System.Drawing.Size(312, 69);
			this.GroupBox4.TabIndex = 0;
			this.GroupBox4.TabStop = false;
			this.Button4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Button4.Location = new global::System.Drawing.Point(233, 32);
			this.Button4.Name = "Button4";
			this.Button4.Size = new global::System.Drawing.Size(75, 31);
			this.Button4.TabIndex = 10;
			this.Button4.TabStop = false;
			this.Button4.Text = "Show All";
			this.Button4.UseVisualStyleBackColor = true;
			this.Label16.AutoSize = true;
			this.Label16.Location = new global::System.Drawing.Point(5, 13);
			this.Label16.Name = "Label16";
			this.Label16.Size = new global::System.Drawing.Size(249, 13);
			this.Label16.TabIndex = 9;
			this.Label16.Text = "Type in the space to search by product description:";
			this.txtsearch.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtsearch.Location = new global::System.Drawing.Point(8, 34);
			this.txtsearch.Name = "txtsearch";
			this.txtsearch.Size = new global::System.Drawing.Size(219, 29);
			this.txtsearch.TabIndex = 0;
			this.Label4.AutoSize = true;
			this.Label4.Location = new global::System.Drawing.Point(350, 205);
			this.Label4.Name = "Label4";
			this.Label4.Size = new global::System.Drawing.Size(77, 13);
			this.Label4.TabIndex = 62;
			this.Label4.Text = "New Category:";
			this.cboNewCat.FormattingEnabled = true;
			this.cboNewCat.Location = new global::System.Drawing.Point(433, 202);
			this.cboNewCat.Name = "cboNewCat";
			this.cboNewCat.Size = new global::System.Drawing.Size(250, 21);
			this.cboNewCat.TabIndex = 61;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(933, 279);
			base.Controls.Add(this.GroupBox1);
			base.Name = "EditProductCategory";
			this.Text = "Edit Product Category";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.Panel4.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.DGVSearch).EndInit();
			this.GroupBox4.ResumeLayout(false);
			this.GroupBox4.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x040007DF RID: 2015
		private global::System.ComponentModel.IContainer components;
	}
}
