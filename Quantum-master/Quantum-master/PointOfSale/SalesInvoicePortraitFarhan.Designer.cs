namespace PointOfSale
{
	// Token: 0x020001A9 RID: 425
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class SalesInvoicePortraitFarhan : global::System.Windows.Forms.Form
	{
		// Token: 0x06004C0F RID: 19471 RVA: 0x002D5F10 File Offset: 0x002D4110
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

		// Token: 0x06004C10 RID: 19472 RVA: 0x002D5F60 File Offset: 0x002D4160
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
			this.ReportViewer1 = new global::Microsoft.Reporting.WinForms.ReportViewer();
			this.POSDataSet = new global::PointOfSale.POSDataSet();
			this.GetPaymentMethodsForInvoiceBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.GetPaymentMethodsForInvoiceTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.GetPaymentMethodsForInvoiceTableAdapter();
			this.GetUserForInvoiceBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.GetUserForInvoiceTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.GetUserForInvoiceTableAdapter();
			this.FetchCustomerDetailsFromInvBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.FetchCustomerDetailsFromInvTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.FetchCustomerDetailsFromInvTableAdapter();
			this.SalesByInvoiceNumberBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.SalesByInvoiceNumberTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.SalesByInvoiceNumberTableAdapter();
			this.GetBranchDetails1BindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.GetBranchDetails1TableAdapter = new global::PointOfSale.POSDataSetTableAdapters.GetBranchDetails1TableAdapter();
			this.GetBankingDetailsBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.GetBankingDetailsTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.GetBankingDetailsTableAdapter();
			this.SalesByInvoiceNumberTotalsBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.SalesByInvoiceNumberTotalsTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.SalesByInvoiceNumberTotalsTableAdapter();
			this.GetCompanyDetailsForCoidBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.GetCompanyDetailsForCoidTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.GetCompanyDetailsForCoidTableAdapter();
			((global::System.ComponentModel.ISupportInitialize)this.POSDataSet).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetPaymentMethodsForInvoiceBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetUserForInvoiceBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.FetchCustomerDetailsFromInvBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.SalesByInvoiceNumberBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetBranchDetails1BindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetBankingDetailsBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.SalesByInvoiceNumberTotalsBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetCompanyDetailsForCoidBindingSource).BeginInit();
			base.SuspendLayout();
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
			reportDataSource7.Name = "InvTotals";
			reportDataSource7.Value = this.SalesByInvoiceNumberTotalsBindingSource;
			reportDataSource8.Name = "CompanyDetails";
			reportDataSource8.Value = this.GetCompanyDetailsForCoidBindingSource;
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource2);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource3);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource4);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource5);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource6);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource7);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource8);
			this.ReportViewer1.LocalReport.ReportEmbeddedResource = "PointOfSale.SalesInvoicePortraitFarhan.rdlc";
			this.ReportViewer1.Location = new global::System.Drawing.Point(0, 0);
			this.ReportViewer1.Name = "ReportViewer1";
			this.ReportViewer1.Size = new global::System.Drawing.Size(986, 507);
			this.ReportViewer1.TabIndex = 0;
			this.POSDataSet.DataSetName = "POSDataSet";
			this.POSDataSet.SchemaSerializationMode = global::System.Data.SchemaSerializationMode.IncludeSchema;
			this.GetPaymentMethodsForInvoiceBindingSource.DataMember = "GetPaymentMethodsForInvoice";
			this.GetPaymentMethodsForInvoiceBindingSource.DataSource = this.POSDataSet;
			this.GetPaymentMethodsForInvoiceTableAdapter.ClearBeforeFill = true;
			this.GetUserForInvoiceBindingSource.DataMember = "GetUserForInvoice";
			this.GetUserForInvoiceBindingSource.DataSource = this.POSDataSet;
			this.GetUserForInvoiceTableAdapter.ClearBeforeFill = true;
			this.FetchCustomerDetailsFromInvBindingSource.DataMember = "FetchCustomerDetailsFromInv";
			this.FetchCustomerDetailsFromInvBindingSource.DataSource = this.POSDataSet;
			this.FetchCustomerDetailsFromInvTableAdapter.ClearBeforeFill = true;
			this.SalesByInvoiceNumberBindingSource.DataMember = "SalesByInvoiceNumber";
			this.SalesByInvoiceNumberBindingSource.DataSource = this.POSDataSet;
			this.SalesByInvoiceNumberTableAdapter.ClearBeforeFill = true;
			this.GetBranchDetails1BindingSource.DataMember = "GetBranchDetails1";
			this.GetBranchDetails1BindingSource.DataSource = this.POSDataSet;
			this.GetBranchDetails1TableAdapter.ClearBeforeFill = true;
			this.GetBankingDetailsBindingSource.DataMember = "GetBankingDetails";
			this.GetBankingDetailsBindingSource.DataSource = this.POSDataSet;
			this.GetBankingDetailsTableAdapter.ClearBeforeFill = true;
			this.SalesByInvoiceNumberTotalsBindingSource.DataMember = "SalesByInvoiceNumberTotals";
			this.SalesByInvoiceNumberTotalsBindingSource.DataSource = this.POSDataSet;
			this.SalesByInvoiceNumberTotalsTableAdapter.ClearBeforeFill = true;
			this.GetCompanyDetailsForCoidBindingSource.DataMember = "GetCompanyDetailsForCoid";
			this.GetCompanyDetailsForCoidBindingSource.DataSource = this.POSDataSet;
			this.GetCompanyDetailsForCoidTableAdapter.ClearBeforeFill = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(986, 507);
			base.Controls.Add(this.ReportViewer1);
			base.Name = "SalesInvoicePortraitFarhan";
			this.Text = "Sales Invoice Portrait Farhan";
			((global::System.ComponentModel.ISupportInitialize)this.POSDataSet).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetPaymentMethodsForInvoiceBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetUserForInvoiceBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.FetchCustomerDetailsFromInvBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.SalesByInvoiceNumberBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetBranchDetails1BindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetBankingDetailsBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.SalesByInvoiceNumberTotalsBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetCompanyDetailsForCoidBindingSource).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x0400217E RID: 8574
		private global::System.ComponentModel.IContainer components;
	}
}
