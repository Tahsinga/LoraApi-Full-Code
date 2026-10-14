namespace PointOfSale
{
	// Token: 0x02000172 RID: 370
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class ProductPics : global::System.Windows.Forms.Form
	{
		// Token: 0x06003476 RID: 13430 RVA: 0x001C5328 File Offset: 0x001C3528
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

		// Token: 0x06003477 RID: 13431 RVA: 0x001C5378 File Offset: 0x001C3578
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.lblcode = new global::System.Windows.Forms.Label();
			this.btnChoose = new global::System.Windows.Forms.Button();
			this.Label20 = new global::System.Windows.Forms.Label();
			this.txtBarCode = new global::System.Windows.Forms.TextBox();
			this.txtSearchProductCode = new global::System.Windows.Forms.TextBox();
			this.txtDesc = new global::System.Windows.Forms.TextBox();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.Panel1 = new global::System.Windows.Forms.Panel();
			this.DGVSearch = new global::System.Windows.Forms.DataGridView();
			this.GroupBox4 = new global::System.Windows.Forms.GroupBox();
			this.Button3 = new global::System.Windows.Forms.Button();
			this.Label12 = new global::System.Windows.Forms.Label();
			this.txtsearch = new global::System.Windows.Forms.TextBox();
			this.lblerror = new global::System.Windows.Forms.Label();
			this.DataGridView1 = new global::System.Windows.Forms.DataGridView();
			this.GroupBox1.SuspendLayout();
			this.Panel1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.DGVSearch).BeginInit();
			this.GroupBox4.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.DataGridView1).BeginInit();
			base.SuspendLayout();
			this.GroupBox1.Controls.Add(this.lblcode);
			this.GroupBox1.Controls.Add(this.btnChoose);
			this.GroupBox1.Controls.Add(this.Label20);
			this.GroupBox1.Controls.Add(this.txtBarCode);
			this.GroupBox1.Controls.Add(this.txtSearchProductCode);
			this.GroupBox1.Controls.Add(this.txtDesc);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.Panel1);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new global::System.Drawing.Size(699, 301);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Select Product and Add Images";
			this.lblcode.AutoSize = true;
			this.lblcode.Location = new global::System.Drawing.Point(350, 201);
			this.lblcode.Name = "lblcode";
			this.lblcode.Size = new global::System.Drawing.Size(16, 13);
			this.lblcode.TabIndex = 42;
			this.lblcode.Text = "...";
			this.btnChoose.BackColor = global::System.Drawing.Color.Lime;
			this.btnChoose.Location = new global::System.Drawing.Point(347, 233);
			this.btnChoose.Name = "btnChoose";
			this.btnChoose.Size = new global::System.Drawing.Size(203, 23);
			this.btnChoose.TabIndex = 39;
			this.btnChoose.Text = "Choose and Save File...";
			this.btnChoose.UseVisualStyleBackColor = false;
			this.Label20.AutoSize = true;
			this.Label20.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label20.Location = new global::System.Drawing.Point(344, 43);
			this.Label20.Name = "Label20";
			this.Label20.Size = new global::System.Drawing.Size(92, 17);
			this.Label20.TabIndex = 38;
			this.Label20.Text = "BAR CODE:";
			this.txtBarCode.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtBarCode.Location = new global::System.Drawing.Point(442, 37);
			this.txtBarCode.Name = "txtBarCode";
			this.txtBarCode.Size = new global::System.Drawing.Size(247, 26);
			this.txtBarCode.TabIndex = 37;
			this.txtBarCode.TabStop = false;
			this.txtSearchProductCode.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtSearchProductCode.Location = new global::System.Drawing.Point(325, 12);
			this.txtSearchProductCode.Name = "txtSearchProductCode";
			this.txtSearchProductCode.Size = new global::System.Drawing.Size(122, 26);
			this.txtSearchProductCode.TabIndex = 35;
			this.txtSearchProductCode.TabStop = false;
			this.txtSearchProductCode.Visible = false;
			this.txtDesc.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtDesc.Enabled = false;
			this.txtDesc.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtDesc.Location = new global::System.Drawing.Point(347, 87);
			this.txtDesc.Multiline = true;
			this.txtDesc.Name = "txtDesc";
			this.txtDesc.ReadOnly = true;
			this.txtDesc.Size = new global::System.Drawing.Size(342, 111);
			this.txtDesc.TabIndex = 20;
			this.Label2.AutoSize = true;
			this.Label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label2.Location = new global::System.Drawing.Point(344, 66);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(165, 17);
			this.Label2.TabIndex = 19;
			this.Label2.Text = "View Product Description";
			this.Panel1.BackColor = global::System.Drawing.Color.FromArgb(192, 255, 255);
			this.Panel1.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.Panel1.Controls.Add(this.DGVSearch);
			this.Panel1.Controls.Add(this.GroupBox4);
			this.Panel1.Controls.Add(this.lblerror);
			this.Panel1.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.Panel1.Location = new global::System.Drawing.Point(3, 16);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new global::System.Drawing.Size(316, 282);
			this.Panel1.TabIndex = 16;
			this.DGVSearch.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DGVSearch.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.DGVSearch.Location = new global::System.Drawing.Point(0, 69);
			this.DGVSearch.Name = "DGVSearch";
			this.DGVSearch.ReadOnly = true;
			this.DGVSearch.Size = new global::System.Drawing.Size(312, 196);
			this.DGVSearch.StandardTab = true;
			this.DGVSearch.TabIndex = 1;
			this.GroupBox4.Controls.Add(this.Button3);
			this.GroupBox4.Controls.Add(this.Label12);
			this.GroupBox4.Controls.Add(this.txtsearch);
			this.GroupBox4.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox4.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox4.Name = "GroupBox4";
			this.GroupBox4.Size = new global::System.Drawing.Size(312, 69);
			this.GroupBox4.TabIndex = 0;
			this.GroupBox4.TabStop = false;
			this.Button3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Button3.Location = new global::System.Drawing.Point(233, 32);
			this.Button3.Name = "Button3";
			this.Button3.Size = new global::System.Drawing.Size(75, 31);
			this.Button3.TabIndex = 10;
			this.Button3.TabStop = false;
			this.Button3.Text = "Show All";
			this.Button3.UseVisualStyleBackColor = true;
			this.Label12.AutoSize = true;
			this.Label12.Location = new global::System.Drawing.Point(5, 13);
			this.Label12.Name = "Label12";
			this.Label12.Size = new global::System.Drawing.Size(249, 13);
			this.Label12.TabIndex = 9;
			this.Label12.Text = "Type in the space to search by product description:";
			this.txtsearch.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtsearch.Location = new global::System.Drawing.Point(8, 34);
			this.txtsearch.Name = "txtsearch";
			this.txtsearch.Size = new global::System.Drawing.Size(219, 29);
			this.txtsearch.TabIndex = 0;
			this.lblerror.AutoSize = true;
			this.lblerror.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.lblerror.Location = new global::System.Drawing.Point(0, 265);
			this.lblerror.Name = "lblerror";
			this.lblerror.Size = new global::System.Drawing.Size(16, 13);
			this.lblerror.TabIndex = 21;
			this.lblerror.Text = "...";
			this.DataGridView1.AllowUserToAddRows = false;
			this.DataGridView1.AllowUserToDeleteRows = false;
			this.DataGridView1.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridView1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.DataGridView1.Location = new global::System.Drawing.Point(0, 301);
			this.DataGridView1.Name = "DataGridView1";
			this.DataGridView1.ReadOnly = true;
			this.DataGridView1.Size = new global::System.Drawing.Size(699, 291);
			this.DataGridView1.TabIndex = 1;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(699, 592);
			base.Controls.Add(this.DataGridView1);
			base.Controls.Add(this.GroupBox1);
			base.Name = "ProductPics";
			this.Text = "Product Images";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.DGVSearch).EndInit();
			this.GroupBox4.ResumeLayout(false);
			this.GroupBox4.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.DataGridView1).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04001679 RID: 5753
		private global::System.ComponentModel.IContainer components;
	}
}
