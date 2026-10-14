namespace PointOfSale
{
	// Token: 0x0200001B RID: 27
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class BulkStockEntry : global::System.Windows.Forms.Form
	{
		// Token: 0x060004E8 RID: 1256 RVA: 0x0002FCCC File Offset: 0x0002DECC
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

		// Token: 0x060004E9 RID: 1257 RVA: 0x0002FD1C File Offset: 0x0002DF1C
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::PointOfSale.BulkStockEntry));
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.chkIdentical = new global::System.Windows.Forms.CheckBox();
			this.Button4 = new global::System.Windows.Forms.Button();
			this.chkAutoGenCode = new global::System.Windows.Forms.CheckBox();
			this.chkIsCatID_A_NAME = new global::System.Windows.Forms.CheckBox();
			this.cboSuppliers = new global::System.Windows.Forms.ComboBox();
			this.CheckBox1 = new global::System.Windows.Forms.CheckBox();
			this.Label7 = new global::System.Windows.Forms.Label();
			this.Button3 = new global::System.Windows.Forms.Button();
			this.Label6 = new global::System.Windows.Forms.Label();
			this.ChkWarehouse = new global::System.Windows.Forms.CheckBox();
			this.Button2 = new global::System.Windows.Forms.Button();
			this.Label5 = new global::System.Windows.Forms.Label();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.CBOBranches = new global::System.Windows.Forms.ComboBox();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.txtRef = new global::System.Windows.Forms.TextBox();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.txtCompanyID = new global::System.Windows.Forms.TextBox();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.DataGridView1 = new global::System.Windows.Forms.DataGridView();
			this.chkGridSupplier = new global::System.Windows.Forms.CheckBox();
			this.GroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.DataGridView1).BeginInit();
			base.SuspendLayout();
			this.GroupBox1.Controls.Add(this.chkGridSupplier);
			this.GroupBox1.Controls.Add(this.chkIdentical);
			this.GroupBox1.Controls.Add(this.Button4);
			this.GroupBox1.Controls.Add(this.chkAutoGenCode);
			this.GroupBox1.Controls.Add(this.chkIsCatID_A_NAME);
			this.GroupBox1.Controls.Add(this.cboSuppliers);
			this.GroupBox1.Controls.Add(this.CheckBox1);
			this.GroupBox1.Controls.Add(this.Label7);
			this.GroupBox1.Controls.Add(this.Button3);
			this.GroupBox1.Controls.Add(this.Label6);
			this.GroupBox1.Controls.Add(this.ChkWarehouse);
			this.GroupBox1.Controls.Add(this.Button2);
			this.GroupBox1.Controls.Add(this.Label5);
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Controls.Add(this.CBOBranches);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.txtRef);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.txtCompanyID);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Padding = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GroupBox1.Size = new global::System.Drawing.Size(1853, 359);
			this.GroupBox1.TabIndex = 1;
			this.GroupBox1.TabStop = false;
			this.chkIdentical.AutoSize = true;
			this.chkIdentical.Location = new global::System.Drawing.Point(376, 176);
			this.chkIdentical.Name = "chkIdentical";
			this.chkIdentical.Size = new global::System.Drawing.Size(339, 24);
			this.chkIdentical.TabIndex = 21;
			this.chkIdentical.Text = "Identical Product Desc is the same Product";
			this.chkIdentical.UseVisualStyleBackColor = true;
			this.Button4.Location = new global::System.Drawing.Point(371, 244);
			this.Button4.Name = "Button4";
			this.Button4.Size = new global::System.Drawing.Size(186, 35);
			this.Button4.TabIndex = 19;
			this.Button4.Text = "Clear Grid";
			this.Button4.UseVisualStyleBackColor = true;
			this.chkAutoGenCode.AutoSize = true;
			this.chkAutoGenCode.Location = new global::System.Drawing.Point(376, 142);
			this.chkAutoGenCode.Name = "chkAutoGenCode";
			this.chkAutoGenCode.Size = new global::System.Drawing.Size(250, 24);
			this.chkAutoGenCode.TabIndex = 18;
			this.chkAutoGenCode.Text = "Auto Generate Product Codes";
			this.chkAutoGenCode.UseVisualStyleBackColor = true;
			this.chkIsCatID_A_NAME.AutoSize = true;
			this.chkIsCatID_A_NAME.Location = new global::System.Drawing.Point(129, 176);
			this.chkIsCatID_A_NAME.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.chkIsCatID_A_NAME.Name = "chkIsCatID_A_NAME";
			this.chkIsCatID_A_NAME.Size = new global::System.Drawing.Size(230, 24);
			this.chkIsCatID_A_NAME.TabIndex = 17;
			this.chkIsCatID_A_NAME.Text = "Is CategoryID a Full Name?";
			this.chkIsCatID_A_NAME.UseVisualStyleBackColor = true;
			this.cboSuppliers.FormattingEnabled = true;
			this.cboSuppliers.Location = new global::System.Drawing.Point(131, 208);
			this.cboSuppliers.Name = "cboSuppliers";
			this.cboSuppliers.Size = new global::System.Drawing.Size(220, 28);
			this.cboSuppliers.TabIndex = 16;
			this.CheckBox1.AutoSize = true;
			this.CheckBox1.Location = new global::System.Drawing.Point(923, 189);
			this.CheckBox1.Name = "CheckBox1";
			this.CheckBox1.Size = new global::System.Drawing.Size(250, 24);
			this.CheckBox1.TabIndex = 15;
			this.CheckBox1.Text = "Adjust Stock Quantitites Only?";
			this.CheckBox1.UseVisualStyleBackColor = true;
			this.CheckBox1.Visible = false;
			this.Label7.AutoSize = true;
			this.Label7.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.Label7.Location = new global::System.Drawing.Point(4, 294);
			this.Label7.Name = "Label7";
			this.Label7.Size = new global::System.Drawing.Size(495, 20);
			this.Label7.TabIndex = 14;
			this.Label7.Text = "Col1- Product ID (NOT PRODUCT CODE), Col2 - New Stock Balance";
			this.Label7.Visible = false;
			this.Button3.Location = new global::System.Drawing.Point(923, 221);
			this.Button3.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Button3.Name = "Button3";
			this.Button3.Size = new global::System.Drawing.Size(222, 58);
			this.Button3.TabIndex = 13;
			this.Button3.Text = "Set Stock Balances (Stock Take)";
			this.Button3.UseVisualStyleBackColor = true;
			this.Button3.Visible = false;
			this.Label6.AutoSize = true;
			this.Label6.Location = new global::System.Drawing.Point(4, 210);
			this.Label6.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label6.Name = "Label6";
			this.Label6.Size = new global::System.Drawing.Size(117, 20);
			this.Label6.TabIndex = 12;
			this.Label6.Text = "Supplier Name:";
			this.ChkWarehouse.AutoSize = true;
			this.ChkWarehouse.Location = new global::System.Drawing.Point(129, 142);
			this.ChkWarehouse.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ChkWarehouse.Name = "ChkWarehouse";
			this.ChkWarehouse.Size = new global::System.Drawing.Size(139, 24);
			this.ChkWarehouse.TabIndex = 10;
			this.ChkWarehouse.Text = "IsWarehouse?";
			this.ChkWarehouse.UseVisualStyleBackColor = true;
			this.Button2.Location = new global::System.Drawing.Point(208, 21);
			this.Button2.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Button2.Name = "Button2";
			this.Button2.Size = new global::System.Drawing.Size(142, 35);
			this.Button2.TabIndex = 9;
			this.Button2.Text = "Load Branches";
			this.Button2.UseVisualStyleBackColor = true;
			this.Label5.AutoSize = true;
			this.Label5.Location = new global::System.Drawing.Point(544, 85);
			this.Label5.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label5.Name = "Label5";
			this.Label5.Size = new global::System.Drawing.Size(661, 20);
			this.Label5.TabIndex = 8;
			this.Label5.Text = "Copy the data from your excel sheet, click the grey space below then paste by pressing ctl+V.";
			this.Label4.AutoSize = true;
			this.Label4.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.Label4.Location = new global::System.Drawing.Point(4, 314);
			this.Label4.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label4.Name = "Label4";
			this.Label4.Size = new global::System.Drawing.Size(975, 40);
			this.Label4.TabIndex = 7;
			this.Label4.Text = componentResourceManager.GetString("Label4.Text");
			this.CBOBranches.FormattingEnabled = true;
			this.CBOBranches.Location = new global::System.Drawing.Point(131, 100);
			this.CBOBranches.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.CBOBranches.Name = "CBOBranches";
			this.CBOBranches.Size = new global::System.Drawing.Size(220, 28);
			this.CBOBranches.TabIndex = 6;
			this.Label3.AutoSize = true;
			this.Label3.Location = new global::System.Drawing.Point(54, 108);
			this.Label3.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(64, 20);
			this.Label3.TabIndex = 5;
			this.Label3.Text = "Branch:";
			this.txtRef.Location = new global::System.Drawing.Point(129, 64);
			this.txtRef.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtRef.Name = "txtRef";
			this.txtRef.Size = new global::System.Drawing.Size(220, 26);
			this.txtRef.TabIndex = 4;
			this.Label2.AutoSize = true;
			this.Label2.Location = new global::System.Drawing.Point(80, 68);
			this.Label2.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(39, 20);
			this.Label2.TabIndex = 3;
			this.Label2.Text = "Ref:";
			this.txtCompanyID.Location = new global::System.Drawing.Point(129, 24);
			this.txtCompanyID.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtCompanyID.Name = "txtCompanyID";
			this.txtCompanyID.Size = new global::System.Drawing.Size(68, 26);
			this.txtCompanyID.TabIndex = 2;
			this.Label1.AutoSize = true;
			this.Label1.Location = new global::System.Drawing.Point(18, 28);
			this.Label1.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(101, 20);
			this.Label1.TabIndex = 1;
			this.Label1.Text = "Company ID:";
			this.Button1.BackColor = global::System.Drawing.Color.Lime;
			this.Button1.Location = new global::System.Drawing.Point(129, 244);
			this.Button1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(222, 35);
			this.Button1.TabIndex = 0;
			this.Button1.Text = "Enter Bulk New Stock";
			this.Button1.UseVisualStyleBackColor = false;
			this.DataGridView1.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridView1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.DataGridView1.Location = new global::System.Drawing.Point(0, 359);
			this.DataGridView1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.DataGridView1.Name = "DataGridView1";
			this.DataGridView1.Size = new global::System.Drawing.Size(1853, 357);
			this.DataGridView1.TabIndex = 2;
			this.chkGridSupplier.AutoSize = true;
			this.chkGridSupplier.Location = new global::System.Drawing.Point(376, 210);
			this.chkGridSupplier.Name = "chkGridSupplier";
			this.chkGridSupplier.Size = new global::System.Drawing.Size(181, 24);
			this.chkGridSupplier.TabIndex = 22;
			this.chkGridSupplier.Text = "Use Supplier in grid?";
			this.chkGridSupplier.UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1853, 716);
			base.Controls.Add(this.DataGridView1);
			base.Controls.Add(this.GroupBox1);
			base.Name = "BulkStockEntry";
			this.Text = "Bulk Stock Entry";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.DataGridView1).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x0400023E RID: 574
		private global::System.ComponentModel.IContainer components;
	}
}
