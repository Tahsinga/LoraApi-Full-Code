namespace PointOfSale
{
	// Token: 0x02000174 RID: 372
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class ProductsConverted : global::System.Windows.Forms.UserControl
	{
		// Token: 0x0600359D RID: 13725 RVA: 0x001CFF9C File Offset: 0x001CE19C
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

		// Token: 0x0600359E RID: 13726 RVA: 0x001CFFEC File Offset: 0x001CE1EC
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.Label5 = new global::System.Windows.Forms.Label();
			this.cboBranch = new global::System.Windows.Forms.ComboBox();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.DTEnddate = new global::System.Windows.Forms.DateTimePicker();
			this.DTStartdate = new global::System.Windows.Forms.DateTimePicker();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.dgvProducts = new global::System.Windows.Forms.DataGridView();
			this.Button2 = new global::System.Windows.Forms.Button();
			this.SaveFileDialog1 = new global::System.Windows.Forms.SaveFileDialog();
			this.cboType = new global::System.Windows.Forms.ComboBox();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.chkAll = new global::System.Windows.Forms.CheckBox();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.Label6 = new global::System.Windows.Forms.Label();
			this.GroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvProducts).BeginInit();
			base.SuspendLayout();
			this.GroupBox1.Controls.Add(this.Label6);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.chkAll);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.cboType);
			this.GroupBox1.Controls.Add(this.Button2);
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Controls.Add(this.Label5);
			this.GroupBox1.Controls.Add(this.cboBranch);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Controls.Add(this.DTEnddate);
			this.GroupBox1.Controls.Add(this.DTStartdate);
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new global::System.Drawing.Size(880, 145);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.Button1.BackColor = global::System.Drawing.Color.Lime;
			this.Button1.Location = new global::System.Drawing.Point(449, 113);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(94, 23);
			this.Button1.TabIndex = 25;
			this.Button1.Text = "VIEW";
			this.Button1.UseVisualStyleBackColor = false;
			this.Label5.AutoSize = true;
			this.Label5.Location = new global::System.Drawing.Point(26, 91);
			this.Label5.Name = "Label5";
			this.Label5.Size = new global::System.Drawing.Size(44, 13);
			this.Label5.TabIndex = 24;
			this.Label5.Text = "Branch:";
			this.cboBranch.FormattingEnabled = true;
			this.cboBranch.Location = new global::System.Drawing.Point(73, 88);
			this.cboBranch.Name = "cboBranch";
			this.cboBranch.Size = new global::System.Drawing.Size(200, 21);
			this.cboBranch.TabIndex = 23;
			this.Label1.AutoSize = true;
			this.Label1.Location = new global::System.Drawing.Point(12, 65);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(55, 13);
			this.Label1.TabIndex = 22;
			this.Label1.Text = "End Date:";
			this.DTEnddate.Location = new global::System.Drawing.Point(73, 62);
			this.DTEnddate.Name = "DTEnddate";
			this.DTEnddate.Size = new global::System.Drawing.Size(200, 20);
			this.DTEnddate.TabIndex = 21;
			this.DTStartdate.Location = new global::System.Drawing.Point(73, 39);
			this.DTStartdate.Name = "DTStartdate";
			this.DTStartdate.Size = new global::System.Drawing.Size(200, 20);
			this.DTStartdate.TabIndex = 20;
			this.Label4.AutoSize = true;
			this.Label4.Location = new global::System.Drawing.Point(9, 42);
			this.Label4.Name = "Label4";
			this.Label4.Size = new global::System.Drawing.Size(58, 13);
			this.Label4.TabIndex = 19;
			this.Label4.Text = "Start Date:";
			this.dgvProducts.AllowUserToAddRows = false;
			this.dgvProducts.AllowUserToDeleteRows = false;
			this.dgvProducts.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvProducts.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dgvProducts.Location = new global::System.Drawing.Point(0, 145);
			this.dgvProducts.Name = "dgvProducts";
			this.dgvProducts.ReadOnly = true;
			this.dgvProducts.Size = new global::System.Drawing.Size(880, 235);
			this.dgvProducts.TabIndex = 1;
			this.Button2.Location = new global::System.Drawing.Point(549, 113);
			this.Button2.Name = "Button2";
			this.Button2.Size = new global::System.Drawing.Size(125, 23);
			this.Button2.TabIndex = 26;
			this.Button2.Text = "EXPORT TO EXCEL";
			this.Button2.UseVisualStyleBackColor = true;
			this.cboType.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboType.FormattingEnabled = true;
			this.cboType.Items.AddRange(new object[] { "PRODUCTS MADE", "INGRIDIENTS USED" });
			this.cboType.Location = new global::System.Drawing.Point(73, 115);
			this.cboType.Name = "cboType";
			this.cboType.Size = new global::System.Drawing.Size(200, 21);
			this.cboType.TabIndex = 27;
			this.Label2.AutoSize = true;
			this.Label2.Location = new global::System.Drawing.Point(33, 118);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(34, 13);
			this.Label2.TabIndex = 28;
			this.Label2.Text = "Type:";
			this.chkAll.AutoSize = true;
			this.chkAll.Location = new global::System.Drawing.Point(279, 117);
			this.chkAll.Name = "chkAll";
			this.chkAll.Size = new global::System.Drawing.Size(73, 17);
			this.chkAll.TabIndex = 29;
			this.chkAll.Text = "View both";
			this.chkAll.UseVisualStyleBackColor = true;
			this.Label3.AutoSize = true;
			this.Label3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label3.Location = new global::System.Drawing.Point(341, 16);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(345, 24);
			this.Label3.TabIndex = 30;
			this.Label3.Text = "PRODUCTS CONVERTED REPORT";
			this.Label6.AutoSize = true;
			this.Label6.BackColor = global::System.Drawing.Color.Red;
			this.Label6.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.Label6.Location = new global::System.Drawing.Point(844, 16);
			this.Label6.Name = "Label6";
			this.Label6.Size = new global::System.Drawing.Size(33, 13);
			this.Label6.TabIndex = 31;
			this.Label6.Text = "Close";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.Controls.Add(this.dgvProducts);
			base.Controls.Add(this.GroupBox1);
			base.Name = "ProductsConverted";
			base.Size = new global::System.Drawing.Size(880, 380);
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvProducts).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x040016F0 RID: 5872
		private global::System.ComponentModel.IContainer components;
	}
}
