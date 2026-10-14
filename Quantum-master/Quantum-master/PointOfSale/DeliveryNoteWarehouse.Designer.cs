namespace PointOfSale
{
	// Token: 0x0200003C RID: 60
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class DeliveryNoteWarehouse : global::System.Windows.Forms.Form
	{
		// Token: 0x06000D27 RID: 3367 RVA: 0x00080960 File Offset: 0x0007EB60
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

		// Token: 0x06000D28 RID: 3368 RVA: 0x000809B0 File Offset: 0x0007EBB0
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
			this.GetPaymentMethodsForInvoiceBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.GetUserForInvoiceBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.FetchCustomerDetailsFromInvBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.GetBranchDetailsBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.SalesByInvoiceNumberBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.GetBankingDetailsBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.BankingDetails2BindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.ReportViewer1 = new global::Microsoft.Reporting.WinForms.ReportViewer();
			this.GetCompanyDetailsTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.GetCompanyDetailsTableAdapter();
			this.GetPaymentMethodsForInvoiceTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.GetPaymentMethodsForInvoiceTableAdapter();
			this.GetUserForInvoiceTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.GetUserForInvoiceTableAdapter();
			this.FetchCustomerDetailsFromInvTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.FetchCustomerDetailsFromInvTableAdapter();
			this.GetBranchDetailsTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.GetBranchDetailsTableAdapter();
			this.SalesByInvoiceNumberTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.SalesByInvoiceNumberTableAdapter();
			this.GetBankingDetailsTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.GetBankingDetailsTableAdapter();
			this.BankingDetails2TableAdapter = new global::PointOfSale.POSDataSetTableAdapters.BankingDetails2TableAdapter();
			((global::System.ComponentModel.ISupportInitialize)this.GetCompanyDetailsBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.POSDataSet).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetPaymentMethodsForInvoiceBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetUserForInvoiceBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.FetchCustomerDetailsFromInvBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetBranchDetailsBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.SalesByInvoiceNumberBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetBankingDetailsBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.BankingDetails2BindingSource).BeginInit();
			base.SuspendLayout();
			this.GetCompanyDetailsBindingSource.DataMember = "GetCompanyDetails";
			this.GetCompanyDetailsBindingSource.DataSource = this.POSDataSet;
			this.POSDataSet.DataSetName = "POSDataSet";
			this.POSDataSet.SchemaSerializationMode = global::System.Data.SchemaSerializationMode.IncludeSchema;
			this.GetPaymentMethodsForInvoiceBindingSource.DataMember = "GetPaymentMethodsForInvoice";
			this.GetPaymentMethodsForInvoiceBindingSource.DataSource = this.POSDataSet;
			this.GetUserForInvoiceBindingSource.DataMember = "GetUserForInvoice";
			this.GetUserForInvoiceBindingSource.DataSource = this.POSDataSet;
			this.FetchCustomerDetailsFromInvBindingSource.DataMember = "FetchCustomerDetailsFromInv";
			this.FetchCustomerDetailsFromInvBindingSource.DataSource = this.POSDataSet;
			this.GetBranchDetailsBindingSource.DataMember = "GetBranchDetails";
			this.GetBranchDetailsBindingSource.DataSource = this.POSDataSet;
			this.SalesByInvoiceNumberBindingSource.DataMember = "SalesByInvoiceNumber";
			this.SalesByInvoiceNumberBindingSource.DataSource = this.POSDataSet;
			this.GetBankingDetailsBindingSource.DataMember = "GetBankingDetails";
			this.GetBankingDetailsBindingSource.DataSource = this.POSDataSet;
			this.BankingDetails2BindingSource.DataMember = "BankingDetails2";
			this.BankingDetails2BindingSource.DataSource = this.POSDataSet;
			this.ReportViewer1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			reportDataSource.Name = "CompanyDetails";
			reportDataSource.Value = this.GetCompanyDetailsBindingSource;
			reportDataSource2.Name = "PaymentMethods";
			reportDataSource2.Value = this.GetPaymentMethodsForInvoiceBindingSource;
			reportDataSource3.Name = "InvoiceUser";
			reportDataSource3.Value = this.GetUserForInvoiceBindingSource;
			reportDataSource4.Name = "CustomerDetails";
			reportDataSource4.Value = this.FetchCustomerDetailsFromInvBindingSource;
			reportDataSource5.Name = "BranchDetails";
			reportDataSource5.Value = this.GetBranchDetailsBindingSource;
			reportDataSource6.Name = "InvoiceDetails";
			reportDataSource6.Value = this.SalesByInvoiceNumberBindingSource;
			reportDataSource7.Name = "BankingDetails";
			reportDataSource7.Value = this.GetBankingDetailsBindingSource;
			reportDataSource8.Name = "BankingDetails2";
			reportDataSource8.Value = this.BankingDetails2BindingSource;
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource2);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource3);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource4);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource5);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource6);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource7);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource8);
			this.ReportViewer1.LocalReport.ReportEmbeddedResource = "PointOfSale.DeliveryNoteWarehouse.rdlc";
			this.ReportViewer1.Location = new global::System.Drawing.Point(0, 0);
			this.ReportViewer1.Name = "ReportViewer1";
			this.ReportViewer1.Size = new global::System.Drawing.Size(909, 401);
			this.ReportViewer1.TabIndex = 0;
			this.GetCompanyDetailsTableAdapter.ClearBeforeFill = true;
			this.GetPaymentMethodsForInvoiceTableAdapter.ClearBeforeFill = true;
			this.GetUserForInvoiceTableAdapter.ClearBeforeFill = true;
			this.FetchCustomerDetailsFromInvTableAdapter.ClearBeforeFill = true;
			this.GetBranchDetailsTableAdapter.ClearBeforeFill = true;
			this.SalesByInvoiceNumberTableAdapter.ClearBeforeFill = true;
			this.GetBankingDetailsTableAdapter.ClearBeforeFill = true;
			this.BankingDetails2TableAdapter.ClearBeforeFill = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(909, 401);
			base.Controls.Add(this.ReportViewer1);
			base.Name = "DeliveryNoteWarehouse";
			this.Text = "Delivery Note Warehouse";
			((global::System.ComponentModel.ISupportInitialize)this.GetCompanyDetailsBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.POSDataSet).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetPaymentMethodsForInvoiceBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetUserForInvoiceBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.FetchCustomerDetailsFromInvBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetBranchDetailsBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.SalesByInvoiceNumberBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetBankingDetailsBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.BankingDetails2BindingSource).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000627 RID: 1575
		private global::System.ComponentModel.IContainer components;
	}
}
