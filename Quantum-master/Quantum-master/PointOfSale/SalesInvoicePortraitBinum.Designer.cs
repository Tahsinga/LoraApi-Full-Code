namespace PointOfSale
{
	// Token: 0x020001A7 RID: 423
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class SalesInvoicePortraitBinum : global::System.Windows.Forms.Form
	{
		// Token: 0x06004BB2 RID: 19378 RVA: 0x002D38CC File Offset: 0x002D1ACC
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

		// Token: 0x06004BB3 RID: 19379 RVA: 0x002D391C File Offset: 0x002D1B1C
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
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource9 = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			this.GetPaymentMethodsForInvoiceBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.POSDataSet = new global::PointOfSale.POSDataSet();
			this.GetUserForInvoiceBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.FetchCustomerDetailsFromInvBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.SalesByInvoiceNumberBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.GetBranchDetails1BindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.GetBankingDetailsBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.SalesByInvoiceNumberTotalsBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.GetCompanyDetailsForCoidBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.ReportViewer1 = new global::Microsoft.Reporting.WinForms.ReportViewer();
			this.GetPaymentMethodsForInvoiceTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.GetPaymentMethodsForInvoiceTableAdapter();
			this.GetUserForInvoiceTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.GetUserForInvoiceTableAdapter();
			this.FetchCustomerDetailsFromInvTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.FetchCustomerDetailsFromInvTableAdapter();
			this.SalesByInvoiceNumberTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.SalesByInvoiceNumberTableAdapter();
			this.GetBranchDetails1TableAdapter = new global::PointOfSale.POSDataSetTableAdapters.GetBranchDetails1TableAdapter();
			this.GetBankingDetailsTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.GetBankingDetailsTableAdapter();
			this.SalesByInvoiceNumberTotalsTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.SalesByInvoiceNumberTotalsTableAdapter();
			this.GetCompanyDetailsForCoidTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.GetCompanyDetailsForCoidTableAdapter();
			((global::System.ComponentModel.ISupportInitialize)this.GetPaymentMethodsForInvoiceBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.POSDataSet).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetUserForInvoiceBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.FetchCustomerDetailsFromInvBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.SalesByInvoiceNumberBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetBranchDetails1BindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetBankingDetailsBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.SalesByInvoiceNumberTotalsBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetCompanyDetailsForCoidBindingSource).BeginInit();
			base.SuspendLayout();
			this.GetPaymentMethodsForInvoiceBindingSource.DataMember = "GetPaymentMethodsForInvoice";
			this.GetPaymentMethodsForInvoiceBindingSource.DataSource = this.POSDataSet;
			this.POSDataSet.DataSetName = "POSDataSet";
			this.POSDataSet.SchemaSerializationMode = global::System.Data.SchemaSerializationMode.IncludeSchema;
			this.GetUserForInvoiceBindingSource.DataMember = "GetUserForInvoice";
			this.GetUserForInvoiceBindingSource.DataSource = this.POSDataSet;
			this.FetchCustomerDetailsFromInvBindingSource.DataMember = "FetchCustomerDetailsFromInv";
			this.FetchCustomerDetailsFromInvBindingSource.DataSource = this.POSDataSet;
			this.SalesByInvoiceNumberBindingSource.DataMember = "SalesByInvoiceNumber";
			this.SalesByInvoiceNumberBindingSource.DataSource = this.POSDataSet;
			this.GetBranchDetails1BindingSource.DataMember = "GetBranchDetails1";
			this.GetBranchDetails1BindingSource.DataSource = this.POSDataSet;
			this.GetBankingDetailsBindingSource.DataMember = "GetBankingDetails";
			this.GetBankingDetailsBindingSource.DataSource = this.POSDataSet;
			this.SalesByInvoiceNumberTotalsBindingSource.DataMember = "SalesByInvoiceNumberTotals";
			this.SalesByInvoiceNumberTotalsBindingSource.DataSource = this.POSDataSet;
			this.GetCompanyDetailsForCoidBindingSource.DataMember = "GetCompanyDetailsForCoid";
			this.GetCompanyDetailsForCoidBindingSource.DataSource = this.POSDataSet;
			this.ReportViewer1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			reportDataSource.Name = "PaymentMethods";
			reportDataSource.Value = this.GetPaymentMethodsForInvoiceBindingSource;
			reportDataSource2.Name = "InvoiceUser";
			reportDataSource2.Value = this.GetUserForInvoiceBindingSource;
			reportDataSource3.Name = "CustomerDetails";
			reportDataSource3.Value = this.FetchCustomerDetailsFromInvBindingSource;
			reportDataSource4.Name = "InvoiceDetails";
			reportDataSource4.Value = this.SalesByInvoiceNumberBindingSource;
			reportDataSource5.Name = "BranchDetails";
			reportDataSource5.Value = this.GetBranchDetails1BindingSource;
			reportDataSource6.Name = "BankingDetails";
			reportDataSource6.Value = this.GetBankingDetailsBindingSource;
			reportDataSource7.Name = "BankingDetails2";
			reportDataSource7.Value = null;
			reportDataSource8.Name = "InvTotals";
			reportDataSource8.Value = this.SalesByInvoiceNumberTotalsBindingSource;
			reportDataSource9.Name = "CompanyDetails";
			reportDataSource9.Value = this.GetCompanyDetailsForCoidBindingSource;
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource2);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource3);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource4);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource5);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource6);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource7);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource8);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource9);
			this.ReportViewer1.LocalReport.ReportEmbeddedResource = "PointOfSale.SalesInvoicePortraitBinum.rdlc";
			this.ReportViewer1.Location = new global::System.Drawing.Point(0, 0);
			this.ReportViewer1.Name = "ReportViewer1";
			this.ReportViewer1.Size = new global::System.Drawing.Size(1245, 649);
			this.ReportViewer1.TabIndex = 0;
			this.GetPaymentMethodsForInvoiceTableAdapter.ClearBeforeFill = true;
			this.GetUserForInvoiceTableAdapter.ClearBeforeFill = true;
			this.FetchCustomerDetailsFromInvTableAdapter.ClearBeforeFill = true;
			this.SalesByInvoiceNumberTableAdapter.ClearBeforeFill = true;
			this.GetBranchDetails1TableAdapter.ClearBeforeFill = true;
			this.GetBankingDetailsTableAdapter.ClearBeforeFill = true;
			this.SalesByInvoiceNumberTotalsTableAdapter.ClearBeforeFill = true;
			this.GetCompanyDetailsForCoidTableAdapter.ClearBeforeFill = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1245, 649);
			base.Controls.Add(this.ReportViewer1);
			base.Name = "SalesInvoicePortraitBinum";
			this.Text = "SalesInvoicePortraitBinum";
			((global::System.ComponentModel.ISupportInitialize)this.GetPaymentMethodsForInvoiceBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.POSDataSet).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetUserForInvoiceBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.FetchCustomerDetailsFromInvBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.SalesByInvoiceNumberBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetBranchDetails1BindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetBankingDetailsBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.SalesByInvoiceNumberTotalsBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetCompanyDetailsForCoidBindingSource).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04002140 RID: 8512
		private global::System.ComponentModel.IContainer components;
	}
}
