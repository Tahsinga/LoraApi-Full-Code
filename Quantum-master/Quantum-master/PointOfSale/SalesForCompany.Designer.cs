namespace PointOfSale
{
	// Token: 0x02000198 RID: 408
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class SalesForCompany : global::System.Windows.Forms.UserControl
	{
		// Token: 0x06004883 RID: 18563 RVA: 0x002C185C File Offset: 0x002BFA5C
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

		// Token: 0x06004884 RID: 18564 RVA: 0x002C18AC File Offset: 0x002BFAAC
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.ReportViewer1 = new global::Microsoft.Reporting.WinForms.ReportViewer();
			this.POSDataSet = new global::PointOfSale.POSDataSet();
			this.GetCompanyDetailsForCoidBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.GetCompanyDetailsForCoidTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.GetCompanyDetailsForCoidTableAdapter();
			this.SalesForCompanyBranchSummaryBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.SalesForCompanyBranchSummaryTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.SalesForCompanyBranchSummaryTableAdapter();
			this.SalesForCompanyPaySummaryBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.SalesForCompanyPaySummaryTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.SalesForCompanyPaySummaryTableAdapter();
			this.SalesForCompanyCategoriesBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.SalesForCompanyCategoriesTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.SalesForCompanyCategoriesTableAdapter();
			this.SalesForCompanySaleTypeBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.SalesForCompanySaleTypeTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.SalesForCompanySaleTypeTableAdapter();
			this.SalesForCompanyDetailBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.SalesForCompanyDetailTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.SalesForCompanyDetailTableAdapter();
			this.DTEnddate = new global::System.Windows.Forms.DateTimePicker();
			this.Label5 = new global::System.Windows.Forms.Label();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.DTStartdate = new global::System.Windows.Forms.DateTimePicker();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.chkHideCats = new global::System.Windows.Forms.CheckBox();
			this.GroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.POSDataSet).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetCompanyDetailsForCoidBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.SalesForCompanyBranchSummaryBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.SalesForCompanyPaySummaryBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.SalesForCompanyCategoriesBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.SalesForCompanySaleTypeBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.SalesForCompanyDetailBindingSource).BeginInit();
			base.SuspendLayout();
			this.GroupBox1.BackColor = global::System.Drawing.Color.FromArgb(192, 255, 255);
			this.GroupBox1.Controls.Add(this.chkHideCats);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.DTEnddate);
			this.GroupBox1.Controls.Add(this.Label5);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Controls.Add(this.DTStartdate);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new global::System.Drawing.Size(1435, 225);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Details";
			this.ReportViewer1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			reportDataSource.Name = "CompanyDetails";
			reportDataSource.Value = this.GetCompanyDetailsForCoidBindingSource;
			reportDataSource2.Name = "BranchSales";
			reportDataSource2.Value = this.SalesForCompanyBranchSummaryBindingSource;
			reportDataSource3.Name = "PaySummary";
			reportDataSource3.Value = this.SalesForCompanyPaySummaryBindingSource;
			reportDataSource4.Name = "CategorySales";
			reportDataSource4.Value = this.SalesForCompanyCategoriesBindingSource;
			reportDataSource5.Name = "SaleType";
			reportDataSource5.Value = this.SalesForCompanySaleTypeBindingSource;
			reportDataSource6.Name = "SalesDetail";
			reportDataSource6.Value = this.SalesForCompanyDetailBindingSource;
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource2);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource3);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource4);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource5);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource6);
			this.ReportViewer1.LocalReport.ReportEmbeddedResource = "PointOfSale.SalesForCompany.rdlc";
			this.ReportViewer1.Location = new global::System.Drawing.Point(0, 225);
			this.ReportViewer1.Name = "ReportViewer1";
			this.ReportViewer1.Size = new global::System.Drawing.Size(1435, 521);
			this.ReportViewer1.TabIndex = 1;
			this.POSDataSet.DataSetName = "POSDataSet";
			this.POSDataSet.SchemaSerializationMode = global::System.Data.SchemaSerializationMode.IncludeSchema;
			this.GetCompanyDetailsForCoidBindingSource.DataMember = "GetCompanyDetailsForCoid";
			this.GetCompanyDetailsForCoidBindingSource.DataSource = this.POSDataSet;
			this.GetCompanyDetailsForCoidTableAdapter.ClearBeforeFill = true;
			this.SalesForCompanyBranchSummaryBindingSource.DataMember = "SalesForCompanyBranchSummary";
			this.SalesForCompanyBranchSummaryBindingSource.DataSource = this.POSDataSet;
			this.SalesForCompanyBranchSummaryTableAdapter.ClearBeforeFill = true;
			this.SalesForCompanyPaySummaryBindingSource.DataMember = "SalesForCompanyPaySummary";
			this.SalesForCompanyPaySummaryBindingSource.DataSource = this.POSDataSet;
			this.SalesForCompanyPaySummaryTableAdapter.ClearBeforeFill = true;
			this.SalesForCompanyCategoriesBindingSource.DataMember = "SalesForCompanyCategories";
			this.SalesForCompanyCategoriesBindingSource.DataSource = this.POSDataSet;
			this.SalesForCompanyCategoriesTableAdapter.ClearBeforeFill = true;
			this.SalesForCompanySaleTypeBindingSource.DataMember = "SalesForCompanySaleType";
			this.SalesForCompanySaleTypeBindingSource.DataSource = this.POSDataSet;
			this.SalesForCompanySaleTypeTableAdapter.ClearBeforeFill = true;
			this.SalesForCompanyDetailBindingSource.DataMember = "SalesForCompanyDetail";
			this.SalesForCompanyDetailBindingSource.DataSource = this.POSDataSet;
			this.SalesForCompanyDetailTableAdapter.ClearBeforeFill = true;
			this.DTEnddate.Location = new global::System.Drawing.Point(121, 144);
			this.DTEnddate.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.DTEnddate.Name = "DTEnddate";
			this.DTEnddate.Size = new global::System.Drawing.Size(298, 26);
			this.DTEnddate.TabIndex = 29;
			this.Label5.AutoSize = true;
			this.Label5.Location = new global::System.Drawing.Point(29, 148);
			this.Label5.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label5.Name = "Label5";
			this.Label5.Size = new global::System.Drawing.Size(81, 20);
			this.Label5.TabIndex = 28;
			this.Label5.Text = "End Date:";
			this.Label3.AutoSize = true;
			this.Label3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label3.Location = new global::System.Drawing.Point(22, 44);
			this.Label3.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(371, 32);
			this.Label3.TabIndex = 25;
			this.Label3.Text = "Sales Report for Company";
			this.Button1.BackColor = global::System.Drawing.Color.Lime;
			this.Button1.Location = new global::System.Drawing.Point(121, 180);
			this.Button1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(298, 35);
			this.Button1.TabIndex = 24;
			this.Button1.Text = "RUN REPORT";
			this.Button1.UseVisualStyleBackColor = false;
			this.DTStartdate.Location = new global::System.Drawing.Point(121, 104);
			this.DTStartdate.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.DTStartdate.Name = "DTStartdate";
			this.DTStartdate.Size = new global::System.Drawing.Size(298, 26);
			this.DTStartdate.TabIndex = 23;
			this.Label1.AutoSize = true;
			this.Label1.Location = new global::System.Drawing.Point(16, 108);
			this.Label1.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(94, 20);
			this.Label1.TabIndex = 22;
			this.Label1.Text = "Select date:";
			this.Label2.AutoSize = true;
			this.Label2.BackColor = global::System.Drawing.Color.Red;
			this.Label2.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.Label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label2.Location = new global::System.Drawing.Point(1361, 22);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(71, 20);
			this.Label2.TabIndex = 30;
			this.Label2.Text = "Close X";
			this.chkHideCats.AutoSize = true;
			this.chkHideCats.Location = new global::System.Drawing.Point(441, 144);
			this.chkHideCats.Name = "chkHideCats";
			this.chkHideCats.Size = new global::System.Drawing.Size(158, 24);
			this.chkHideCats.TabIndex = 31;
			this.chkHideCats.Text = "Hide Categories?";
			this.chkHideCats.UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.Controls.Add(this.ReportViewer1);
			base.Controls.Add(this.GroupBox1);
			base.Name = "SalesForCompany";
			base.Size = new global::System.Drawing.Size(1435, 746);
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.POSDataSet).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetCompanyDetailsForCoidBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.SalesForCompanyBranchSummaryBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.SalesForCompanyPaySummaryBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.SalesForCompanyCategoriesBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.SalesForCompanySaleTypeBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.SalesForCompanyDetailBindingSource).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04001FBD RID: 8125
		private global::System.ComponentModel.IContainer components;
	}
}
