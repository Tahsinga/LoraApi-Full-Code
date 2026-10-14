namespace PointOfSale
{
	// Token: 0x02000160 RID: 352
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class PriceList : global::System.Windows.Forms.Form
	{
		// Token: 0x06002ED6 RID: 11990 RVA: 0x00196FC0 File Offset: 0x001951C0
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

		// Token: 0x06002ED7 RID: 11991 RVA: 0x00197010 File Offset: 0x00195210
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.chkCategories = new global::System.Windows.Forms.CheckBox();
			this.cboCategories = new global::System.Windows.Forms.ComboBox();
			this.cmbPayMethods = new global::System.Windows.Forms.ComboBox();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.cmbFontSize = new global::System.Windows.Forms.ComboBox();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.ReportViewer1 = new global::Microsoft.Reporting.WinForms.ReportViewer();
			this.cboBranch = new global::System.Windows.Forms.ComboBox();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.Label5 = new global::System.Windows.Forms.Label();
			this.Label6 = new global::System.Windows.Forms.Label();
			this.cboPriceType = new global::System.Windows.Forms.ComboBox();
			this.GetCompanyDetailsBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.POSDataSet = new global::PointOfSale.POSDataSet();
			this.GetProductPricesBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.GetCompanyDetailsTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.GetCompanyDetailsTableAdapter();
			this.GetProductPricesTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.GetProductPricesTableAdapter();
			this.GroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.GetCompanyDetailsBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.POSDataSet).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetProductPricesBindingSource).BeginInit();
			base.SuspendLayout();
			this.GroupBox1.Controls.Add(this.cboPriceType);
			this.GroupBox1.Controls.Add(this.Label6);
			this.GroupBox1.Controls.Add(this.Label5);
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Controls.Add(this.cboBranch);
			this.GroupBox1.Controls.Add(this.chkCategories);
			this.GroupBox1.Controls.Add(this.cboCategories);
			this.GroupBox1.Controls.Add(this.cmbPayMethods);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Controls.Add(this.cmbFontSize);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new global::System.Drawing.Size(906, 188);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.chkCategories.AutoSize = true;
			this.chkCategories.Location = new global::System.Drawing.Point(440, 95);
			this.chkCategories.Name = "chkCategories";
			this.chkCategories.Size = new global::System.Drawing.Size(122, 17);
			this.chkCategories.TabIndex = 7;
			this.chkCategories.Text = "View All Categories?";
			this.chkCategories.UseVisualStyleBackColor = true;
			this.cboCategories.FormattingEnabled = true;
			this.cboCategories.Location = new global::System.Drawing.Point(178, 93);
			this.cboCategories.Name = "cboCategories";
			this.cboCategories.Size = new global::System.Drawing.Size(256, 21);
			this.cboCategories.TabIndex = 6;
			this.cmbPayMethods.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbPayMethods.FormattingEnabled = true;
			this.cmbPayMethods.Items.AddRange(new object[]
			{
				"6", "7", "8", "9", "10", "11", "12", "13", "14", "15",
				"16", "17", "18", "19", "20", "21", "22", "23", "24", "25",
				"26", "27", "28", "29", "30", "31", "32", "33", "34", "35",
				"36", "37", "38", "39", "40", "41", "42", "43", "44", "45",
				"46", "47", "48", "49", "50"
			});
			this.cmbPayMethods.Location = new global::System.Drawing.Point(178, 68);
			this.cmbPayMethods.Name = "cmbPayMethods";
			this.cmbPayMethods.Size = new global::System.Drawing.Size(256, 21);
			this.cmbPayMethods.TabIndex = 5;
			this.Label3.AutoSize = true;
			this.Label3.Location = new global::System.Drawing.Point(49, 76);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(123, 13);
			this.Label3.TabIndex = 4;
			this.Label3.Text = "Select Payment Method:";
			this.Label2.AutoSize = true;
			this.Label2.Location = new global::System.Drawing.Point(85, 49);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(87, 13);
			this.Label2.TabIndex = 3;
			this.Label2.Text = "Select Font Size:";
			this.Button1.BackColor = global::System.Drawing.Color.FromArgb(0, 192, 0);
			this.Button1.Location = new global::System.Drawing.Point(316, 147);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(118, 23);
			this.Button1.TabIndex = 9;
			this.Button1.Text = "RUN REPORT";
			this.Button1.UseVisualStyleBackColor = false;
			this.cmbFontSize.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbFontSize.FormattingEnabled = true;
			this.cmbFontSize.Items.AddRange(new object[]
			{
				"6", "7", "8", "9", "10", "11", "12", "13", "14", "15",
				"16", "17", "18", "19", "20", "21", "22", "23", "24", "25",
				"26", "27", "28", "29", "30", "31", "32", "33", "34", "35",
				"36", "37", "38", "39", "40", "41", "42", "43", "44", "45",
				"46", "47", "48", "49", "50"
			});
			this.cmbFontSize.Location = new global::System.Drawing.Point(178, 41);
			this.cmbFontSize.Name = "cmbFontSize";
			this.cmbFontSize.Size = new global::System.Drawing.Size(63, 21);
			this.cmbFontSize.TabIndex = 1;
			this.Label1.AutoSize = true;
			this.Label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label1.Location = new global::System.Drawing.Point(181, 12);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(208, 24);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "PRICE LIST REPORT";
			this.ReportViewer1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			reportDataSource.Name = "CompanyDetails";
			reportDataSource.Value = this.GetCompanyDetailsBindingSource;
			reportDataSource2.Name = "Prices";
			reportDataSource2.Value = this.GetProductPricesBindingSource;
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource2);
			this.ReportViewer1.LocalReport.ReportEmbeddedResource = "PointOfSale.PriceList.rdlc";
			this.ReportViewer1.Location = new global::System.Drawing.Point(0, 188);
			this.ReportViewer1.Name = "ReportViewer1";
			this.ReportViewer1.Size = new global::System.Drawing.Size(906, 332);
			this.ReportViewer1.TabIndex = 1;
			this.cboBranch.FormattingEnabled = true;
			this.cboBranch.Location = new global::System.Drawing.Point(178, 120);
			this.cboBranch.Name = "cboBranch";
			this.cboBranch.Size = new global::System.Drawing.Size(256, 21);
			this.cboBranch.TabIndex = 8;
			this.Label4.AutoSize = true;
			this.Label4.Location = new global::System.Drawing.Point(88, 99);
			this.Label4.Name = "Label4";
			this.Label4.Size = new global::System.Drawing.Size(85, 13);
			this.Label4.TabIndex = 9;
			this.Label4.Text = "Select Category:";
			this.Label5.AutoSize = true;
			this.Label5.Location = new global::System.Drawing.Point(96, 123);
			this.Label5.Name = "Label5";
			this.Label5.Size = new global::System.Drawing.Size(77, 13);
			this.Label5.TabIndex = 10;
			this.Label5.Text = "Select Branch:";
			this.Label6.AutoSize = true;
			this.Label6.Location = new global::System.Drawing.Point(111, 152);
			this.Label6.Name = "Label6";
			this.Label6.Size = new global::System.Drawing.Size(61, 13);
			this.Label6.TabIndex = 11;
			this.Label6.Text = "Price Type:";
			this.cboPriceType.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboPriceType.FormattingEnabled = true;
			this.cboPriceType.Items.AddRange(new object[] { "RETAIL", "WHOLESALE", "SPECIAL" });
			this.cboPriceType.Location = new global::System.Drawing.Point(178, 149);
			this.cboPriceType.Name = "cboPriceType";
			this.cboPriceType.Size = new global::System.Drawing.Size(132, 21);
			this.cboPriceType.TabIndex = 12;
			this.GetCompanyDetailsBindingSource.DataMember = "GetCompanyDetails";
			this.GetCompanyDetailsBindingSource.DataSource = this.POSDataSet;
			this.POSDataSet.DataSetName = "POSDataSet";
			this.POSDataSet.SchemaSerializationMode = global::System.Data.SchemaSerializationMode.IncludeSchema;
			this.GetProductPricesBindingSource.DataMember = "GetProductPrices";
			this.GetProductPricesBindingSource.DataSource = this.POSDataSet;
			this.GetCompanyDetailsTableAdapter.ClearBeforeFill = true;
			this.GetProductPricesTableAdapter.ClearBeforeFill = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(906, 520);
			base.Controls.Add(this.ReportViewer1);
			base.Controls.Add(this.GroupBox1);
			base.Name = "PriceList";
			this.Text = "PriceList";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.GetCompanyDetailsBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.POSDataSet).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetProductPricesBindingSource).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04001414 RID: 5140
		private global::System.ComponentModel.IContainer components;
	}
}
