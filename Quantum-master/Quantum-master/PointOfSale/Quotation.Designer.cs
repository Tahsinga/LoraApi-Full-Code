namespace PointOfSale
{
	// Token: 0x0200017D RID: 381
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Quotation : global::System.Windows.Forms.Form
	{
		// Token: 0x0600380C RID: 14348 RVA: 0x001E8D5C File Offset: 0x001E6F5C
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

		// Token: 0x0600380D RID: 14349 RVA: 0x001E8DAC File Offset: 0x001E6FAC
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
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource7 = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource8 = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			this.GetCompanyDetailsBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.POSDataSet = new global::PointOfSale.POSDataSet();
			this.FetchCustomerDetailsFromQuotationBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.GetQuotationDetailsBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.GetUserForQuotationBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.GetBankingDetailsBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.BankingDetails2BindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.GetBranchDetailsBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.ReportViewer1 = new global::Microsoft.Reporting.WinForms.ReportViewer();
			this.GetCompanyDetailsTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.GetCompanyDetailsTableAdapter();
			this.FetchCustomerDetailsFromQuotationTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.FetchCustomerDetailsFromQuotationTableAdapter();
			this.GetQuotationDetailsTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.GetQuotationDetailsTableAdapter();
			this.GetUserForQuotationTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.GetUserForQuotationTableAdapter();
			this.GetBranchDetailsTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.GetBranchDetailsTableAdapter();
			this.GetBankingDetailsTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.GetBankingDetailsTableAdapter();
			this.BankingDetails2TableAdapter = new global::PointOfSale.POSDataSetTableAdapters.BankingDetails2TableAdapter();
			this.GetQuotationHeaderBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.GetQuotationHeaderTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.GetQuotationHeaderTableAdapter();
			((global::System.ComponentModel.ISupportInitialize)this.GetCompanyDetailsBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.POSDataSet).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.FetchCustomerDetailsFromQuotationBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetQuotationDetailsBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetUserForQuotationBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetBankingDetailsBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.BankingDetails2BindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetBranchDetailsBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetQuotationHeaderBindingSource).BeginInit();
			base.SuspendLayout();
			this.GetCompanyDetailsBindingSource.DataMember = "GetCompanyDetails";
			this.GetCompanyDetailsBindingSource.DataSource = this.POSDataSet;
			this.POSDataSet.DataSetName = "POSDataSet";
			this.POSDataSet.SchemaSerializationMode = global::System.Data.SchemaSerializationMode.IncludeSchema;
			this.FetchCustomerDetailsFromQuotationBindingSource.DataMember = "FetchCustomerDetailsFromQuotation";
			this.FetchCustomerDetailsFromQuotationBindingSource.DataSource = this.POSDataSet;
			this.GetQuotationDetailsBindingSource.DataMember = "GetQuotationDetails";
			this.GetQuotationDetailsBindingSource.DataSource = this.POSDataSet;
			this.GetUserForQuotationBindingSource.DataMember = "GetUserForQuotation";
			this.GetUserForQuotationBindingSource.DataSource = this.POSDataSet;
			this.GetBankingDetailsBindingSource.DataMember = "GetBankingDetails";
			this.GetBankingDetailsBindingSource.DataSource = this.POSDataSet;
			this.BankingDetails2BindingSource.DataMember = "BankingDetails2";
			this.BankingDetails2BindingSource.DataSource = this.POSDataSet;
			this.GetBranchDetailsBindingSource.DataMember = "GetBranchDetails";
			this.GetBranchDetailsBindingSource.DataSource = this.POSDataSet;
			this.ReportViewer1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			reportDataSource.Name = "CompanyDetails";
			reportDataSource.Value = this.GetCompanyDetailsBindingSource;
			reportDataSource2.Name = "CustomerDetails";
			reportDataSource2.Value = this.FetchCustomerDetailsFromQuotationBindingSource;
			reportDataSource3.Name = "QuotationDetails";
			reportDataSource3.Value = this.GetQuotationDetailsBindingSource;
			reportDataSource4.Name = "QuotationUser";
			reportDataSource4.Value = this.GetUserForQuotationBindingSource;
			reportDataSource5.Name = "BankingDetails";
			reportDataSource5.Value = this.GetBankingDetailsBindingSource;
			reportDataSource6.Name = "BankingDetails2";
			reportDataSource6.Value = this.BankingDetails2BindingSource;
			reportDataSource7.Name = "GetBranchDetails";
			reportDataSource7.Value = this.GetBranchDetailsBindingSource;
			reportDataSource8.Name = "QuotationTotals";
			reportDataSource8.Value = this.GetQuotationHeaderBindingSource;
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource2);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource3);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource4);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource5);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource6);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource7);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource8);
			this.ReportViewer1.LocalReport.ReportEmbeddedResource = "PointOfSale.Quotation.rdlc";
			this.ReportViewer1.Location = new global::System.Drawing.Point(0, 0);
			this.ReportViewer1.Name = "ReportViewer1";
			this.ReportViewer1.Size = new global::System.Drawing.Size(1005, 459);
			this.ReportViewer1.TabIndex = 0;
			this.GetCompanyDetailsTableAdapter.ClearBeforeFill = true;
			this.FetchCustomerDetailsFromQuotationTableAdapter.ClearBeforeFill = true;
			this.GetQuotationDetailsTableAdapter.ClearBeforeFill = true;
			this.GetUserForQuotationTableAdapter.ClearBeforeFill = true;
			this.GetBranchDetailsTableAdapter.ClearBeforeFill = true;
			this.GetBankingDetailsTableAdapter.ClearBeforeFill = true;
			this.BankingDetails2TableAdapter.ClearBeforeFill = true;
			this.GetQuotationHeaderBindingSource.DataMember = "GetQuotationHeader";
			this.GetQuotationHeaderBindingSource.DataSource = this.POSDataSet;
			this.GetQuotationHeaderTableAdapter.ClearBeforeFill = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1005, 459);
			base.Controls.Add(this.ReportViewer1);
			base.Name = "Quotation";
			this.Text = "Quotation";
			((global::System.ComponentModel.ISupportInitialize)this.GetCompanyDetailsBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.POSDataSet).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.FetchCustomerDetailsFromQuotationBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetQuotationDetailsBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetUserForQuotationBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetBankingDetailsBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.BankingDetails2BindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetBranchDetailsBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetQuotationHeaderBindingSource).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x040017C1 RID: 6081
		private global::System.ComponentModel.IContainer components;
	}
}
