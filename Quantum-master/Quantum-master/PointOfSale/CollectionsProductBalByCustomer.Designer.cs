namespace PointOfSale
{
	// Token: 0x02000029 RID: 41
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class CollectionsProductBalByCustomer : global::System.Windows.Forms.Form
	{
		// Token: 0x060007B2 RID: 1970 RVA: 0x0004D5E0 File Offset: 0x0004B7E0
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

		// Token: 0x060007B3 RID: 1971 RVA: 0x0004D630 File Offset: 0x0004B830
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.txtProductBal = new global::System.Windows.Forms.TextBox();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.txtProductID = new global::System.Windows.Forms.TextBox();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.txtProductName = new global::System.Windows.Forms.TextBox();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.dgvDetail = new global::System.Windows.Forms.DataGridView();
			this.GroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvDetail).BeginInit();
			base.SuspendLayout();
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Controls.Add(this.txtProductBal);
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Controls.Add(this.txtProductID);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.txtProductName);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Padding = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GroupBox1.Size = new global::System.Drawing.Size(1212, 245);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.Button1.BackColor = global::System.Drawing.Color.Yellow;
			this.Button1.Location = new global::System.Drawing.Point(784, 174);
			this.Button1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(286, 35);
			this.Button1.TabIndex = 7;
			this.Button1.Text = "Export to Excel";
			this.Button1.UseVisualStyleBackColor = false;
			this.Button1.Visible = false;
			this.txtProductBal.Enabled = false;
			this.txtProductBal.Location = new global::System.Drawing.Point(158, 178);
			this.txtProductBal.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtProductBal.Name = "txtProductBal";
			this.txtProductBal.Size = new global::System.Drawing.Size(144, 26);
			this.txtProductBal.TabIndex = 6;
			this.Label4.AutoSize = true;
			this.Label4.Location = new global::System.Drawing.Point(51, 183);
			this.Label4.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label4.Name = "Label4";
			this.Label4.Size = new global::System.Drawing.Size(95, 20);
			this.Label4.TabIndex = 5;
			this.Label4.Text = "Product Bal:";
			this.txtProductID.Enabled = false;
			this.txtProductID.Location = new global::System.Drawing.Point(158, 138);
			this.txtProductID.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtProductID.Name = "txtProductID";
			this.txtProductID.Size = new global::System.Drawing.Size(223, 26);
			this.txtProductID.TabIndex = 4;
			this.Label3.AutoSize = true;
			this.Label3.Location = new global::System.Drawing.Point(57, 143);
			this.Label3.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(89, 20);
			this.Label3.TabIndex = 3;
			this.Label3.Text = "Product ID:";
			this.txtProductName.Enabled = false;
			this.txtProductName.Location = new global::System.Drawing.Point(158, 98);
			this.txtProductName.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtProductName.Name = "txtProductName";
			this.txtProductName.Size = new global::System.Drawing.Size(348, 26);
			this.txtProductName.TabIndex = 2;
			this.Label2.AutoSize = true;
			this.Label2.Location = new global::System.Drawing.Point(32, 103);
			this.Label2.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(114, 20);
			this.Label2.TabIndex = 1;
			this.Label2.Text = "Product Name:";
			this.Label1.AutoSize = true;
			this.Label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label1.Location = new global::System.Drawing.Point(18, 25);
			this.Label1.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(761, 32);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Collections/Delivery Product Balance grouped by Customer";
			this.dgvDetail.AllowUserToAddRows = false;
			this.dgvDetail.AllowUserToDeleteRows = false;
			this.dgvDetail.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDetail.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dgvDetail.Location = new global::System.Drawing.Point(0, 245);
			this.dgvDetail.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dgvDetail.Name = "dgvDetail";
			this.dgvDetail.ReadOnly = true;
			this.dgvDetail.Size = new global::System.Drawing.Size(1212, 387);
			this.dgvDetail.TabIndex = 1;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1212, 632);
			base.Controls.Add(this.dgvDetail);
			base.Controls.Add(this.GroupBox1);
			base.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			base.Name = "CollectionsProductBalByCustomer";
			this.Text = "Collections ProductBalByCustomer";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvDetail).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x0400039B RID: 923
		private global::System.ComponentModel.IContainer components;
	}
}
