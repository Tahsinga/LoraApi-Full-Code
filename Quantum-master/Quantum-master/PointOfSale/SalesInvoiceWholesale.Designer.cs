namespace PointOfSale
{
	// Token: 0x020001B1 RID: 433
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class SalesInvoiceWholesale : global::System.Windows.Forms.Form
	{
		// Token: 0x06004D84 RID: 19844 RVA: 0x002DE5F0 File Offset: 0x002DC7F0
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

		// Token: 0x06004D85 RID: 19845 RVA: 0x002DE640 File Offset: 0x002DC840
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
			this.GetPaymentMethodsForInvoiceBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.POSDataSet = new global::PointOfSale.POSDataSet();
			this.GetUserForInvoiceBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.FetchCustomerDetailsFromInvBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.GetCompanyDetailsBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.SalesByInvoiceNumberBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.GetBankingDetailsBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.BankingDetails2BindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.GetBranchDetailsBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.ReportViewer1 = new global::Microsoft.Reporting.WinForms.ReportViewer();
			this.GetPaymentMethodsForInvoiceTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.GetPaymentMethodsForInvoiceTableAdapter();
			this.GetUserForInvoiceTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.GetUserForInvoiceTableAdapter();
			this.FetchCustomerDetailsFromInvTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.FetchCustomerDetailsFromInvTableAdapter();
			this.GetCompanyDetailsTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.GetCompanyDetailsTableAdapter();
			this.SalesByInvoiceNumberTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.SalesByInvoiceNumberTableAdapter();
			this.GetBankingDetailsTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.GetBankingDetailsTableAdapter();
			this.BankingDetails2TableAdapter = new global::PointOfSale.POSDataSetTableAdapters.BankingDetails2TableAdapter();
			this.GetBranchDetailsTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.GetBranchDetailsTableAdapter();
			((global::System.ComponentModel.ISupportInitialize)this.GetPaymentMethodsForInvoiceBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.POSDataSet).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetUserForInvoiceBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.FetchCustomerDetailsFromInvBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetCompanyDetailsBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.SalesByInvoiceNumberBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetBankingDetailsBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.BankingDetails2BindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetBranchDetailsBindingSource).BeginInit();
			base.SuspendLayout();
			this.GetPaymentMethodsForInvoiceBindingSource.DataMember = "GetPaymentMethodsForInvoice";
			this.GetPaymentMethodsForInvoiceBindingSource.DataSource = this.POSDataSet;
			this.POSDataSet.DataSetName = "POSDataSet";
			this.POSDataSet.SchemaSerializationMode = global::System.Data.SchemaSerializationMode.IncludeSchema;
			this.GetUserForInvoiceBindingSource.DataMember = "GetUserForInvoice";
			this.GetUserForInvoiceBindingSource.DataSource = this.POSDataSet;
			this.FetchCustomerDetailsFromInvBindingSource.DataMember = "FetchCustomerDetailsFromInv";
			this.FetchCustomerDetailsFromInvBindingSource.DataSource = this.POSDataSet;
			this.GetCompanyDetailsBindingSource.DataMember = "GetCompanyDetails";
			this.GetCompanyDetailsBindingSource.DataSource = this.POSDataSet;
			this.SalesByInvoiceNumberBindingSource.DataMember = "SalesByInvoiceNumber";
			this.SalesByInvoiceNumberBindingSource.DataSource = this.POSDataSet;
			this.GetBankingDetailsBindingSource.DataMember = "GetBankingDetails";
			this.GetBankingDetailsBindingSource.DataSource = this.POSDataSet;
			this.BankingDetails2BindingSource.DataMember = "BankingDetails2";
			this.BankingDetails2BindingSource.DataSource = this.POSDataSet;
			this.GetBranchDetailsBindingSource.DataMember = "GetBranchDetails";
			this.GetBranchDetailsBindingSource.DataSource = this.POSDataSet;
			this.ReportViewer1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			reportDataSource.Name = "PaymentMethods";
			reportDataSource.Value = this.GetPaymentMethodsForInvoiceBindingSource;
			reportDataSource2.Name = "InvoiceUser";
			reportDataSource2.Value = this.GetUserForInvoiceBindingSource;
			reportDataSource3.Name = "CustomerDetails";
			reportDataSource3.Value = this.FetchCustomerDetailsFromInvBindingSource;
			reportDataSource4.Name = "CompanyDetails";
			reportDataSource4.Value = this.GetCompanyDetailsBindingSource;
			reportDataSource5.Name = "InvoiceDetails";
			reportDataSource5.Value = this.SalesByInvoiceNumberBindingSource;
			reportDataSource6.Name = "BankingDetails";
			reportDataSource6.Value = this.GetBankingDetailsBindingSource;
			reportDataSource7.Name = "BankingDetails2";
			reportDataSource7.Value = this.BankingDetails2BindingSource;
			reportDataSource8.Name = "BranchDetails";
			reportDataSource8.Value = this.GetBranchDetailsBindingSource;
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource2);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource3);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource4);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource5);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource6);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource7);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource8);
			this.ReportViewer1.LocalReport.ReportEmbeddedResource = "PointOfSale.SalesInvoiceWarehousePortrait.rdlc";
			this.ReportViewer1.Location = new global::System.Drawing.Point(0, 0);
			this.ReportViewer1.Name = "ReportViewer1";
			this.ReportViewer1.Size = new global::System.Drawing.Size(965, 526);
			this.ReportViewer1.TabIndex = 0;
			this.GetPaymentMethodsForInvoiceTableAdapter.ClearBeforeFill = true;
			this.GetUserForInvoiceTableAdapter.ClearBeforeFill = true;
			this.FetchCustomerDetailsFromInvTableAdapter.ClearBeforeFill = true;
			this.GetCompanyDetailsTableAdapter.ClearBeforeFill = true;
			this.SalesByInvoiceNumberTableAdapter.ClearBeforeFill = true;
			this.GetBankingDetailsTableAdapter.ClearBeforeFill = true;
			this.BankingDetails2TableAdapter.ClearBeforeFill = true;
			this.GetBranchDetailsTableAdapter.ClearBeforeFill = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(965, 526);
			base.Controls.Add(this.ReportViewer1);
			base.Name = "SalesInvoiceWholesale";
			this.Text = "Sales Invoice Wholesale";
			((global::System.ComponentModel.ISupportInitialize)this.GetPaymentMethodsForInvoiceBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.POSDataSet).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetUserForInvoiceBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.FetchCustomerDetailsFromInvBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetCompanyDetailsBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.SalesByInvoiceNumberBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetBankingDetailsBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.BankingDetails2BindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetBranchDetailsBindingSource).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x0400226C RID: 8812
		private global::System.ComponentModel.IContainer components;
	}
}
