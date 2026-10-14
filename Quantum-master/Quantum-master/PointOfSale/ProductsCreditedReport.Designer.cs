namespace PointOfSale
{
	// Token: 0x02000175 RID: 373
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class ProductsCreditedReport : global::System.Windows.Forms.Form
	{
		// Token: 0x060035C7 RID: 13767 RVA: 0x001D0F78 File Offset: 0x001CF178
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

		// Token: 0x060035C8 RID: 13768 RVA: 0x001D0FC8 File Offset: 0x001CF1C8
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
			this.GetCompanyDetailsBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.POSDataSet = new global::PointOfSale.POSDataSet();
			this.ProductCreditNotePayMethodsBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.ProductCreditNoteUserBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.ProductCreditNoteCustomerDetailsBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.ProductCreditNoteSelectBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.GetBranchDetailsBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.GetBankingDetailsBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.BankingDetails2BindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.ProductCreditNoteInvTotalsBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.ReportViewer1 = new global::Microsoft.Reporting.WinForms.ReportViewer();
			this.GetCompanyDetailsTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.GetCompanyDetailsTableAdapter();
			this.ProductCreditNotePayMethodsTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.ProductCreditNotePayMethodsTableAdapter();
			this.ProductCreditNoteUserTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.ProductCreditNoteUserTableAdapter();
			this.ProductCreditNoteCustomerDetailsTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.ProductCreditNoteCustomerDetailsTableAdapter();
			this.ProductCreditNoteSelectTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.ProductCreditNoteSelectTableAdapter();
			this.GetBranchDetailsTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.GetBranchDetailsTableAdapter();
			this.GetBankingDetailsTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.GetBankingDetailsTableAdapter();
			this.BankingDetails2TableAdapter = new global::PointOfSale.POSDataSetTableAdapters.BankingDetails2TableAdapter();
			this.ProductCreditNoteInvTotalsTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.ProductCreditNoteInvTotalsTableAdapter();
			((global::System.ComponentModel.ISupportInitialize)this.GetCompanyDetailsBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.POSDataSet).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.ProductCreditNotePayMethodsBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.ProductCreditNoteUserBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.ProductCreditNoteCustomerDetailsBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.ProductCreditNoteSelectBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetBranchDetailsBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetBankingDetailsBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.BankingDetails2BindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.ProductCreditNoteInvTotalsBindingSource).BeginInit();
			base.SuspendLayout();
			this.GetCompanyDetailsBindingSource.DataMember = "GetCompanyDetails";
			this.GetCompanyDetailsBindingSource.DataSource = this.POSDataSet;
			this.POSDataSet.DataSetName = "POSDataSet";
			this.POSDataSet.SchemaSerializationMode = global::System.Data.SchemaSerializationMode.IncludeSchema;
			this.ProductCreditNotePayMethodsBindingSource.DataMember = "ProductCreditNotePayMethods";
			this.ProductCreditNotePayMethodsBindingSource.DataSource = this.POSDataSet;
			this.ProductCreditNoteUserBindingSource.DataMember = "ProductCreditNoteUser";
			this.ProductCreditNoteUserBindingSource.DataSource = this.POSDataSet;
			this.ProductCreditNoteCustomerDetailsBindingSource.DataMember = "ProductCreditNoteCustomerDetails";
			this.ProductCreditNoteCustomerDetailsBindingSource.DataSource = this.POSDataSet;
			this.ProductCreditNoteSelectBindingSource.DataMember = "ProductCreditNoteSelect";
			this.ProductCreditNoteSelectBindingSource.DataSource = this.POSDataSet;
			this.GetBranchDetailsBindingSource.DataMember = "GetBranchDetails";
			this.GetBranchDetailsBindingSource.DataSource = this.POSDataSet;
			this.GetBankingDetailsBindingSource.DataMember = "GetBankingDetails";
			this.GetBankingDetailsBindingSource.DataSource = this.POSDataSet;
			this.BankingDetails2BindingSource.DataMember = "BankingDetails2";
			this.BankingDetails2BindingSource.DataSource = this.POSDataSet;
			this.ProductCreditNoteInvTotalsBindingSource.DataMember = "ProductCreditNoteInvTotals";
			this.ProductCreditNoteInvTotalsBindingSource.DataSource = this.POSDataSet;
			this.ReportViewer1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			reportDataSource.Name = "CompanyDetails";
			reportDataSource.Value = this.GetCompanyDetailsBindingSource;
			reportDataSource2.Name = "PaymentMethods";
			reportDataSource2.Value = this.ProductCreditNotePayMethodsBindingSource;
			reportDataSource3.Name = "InvoiceUser";
			reportDataSource3.Value = this.ProductCreditNoteUserBindingSource;
			reportDataSource4.Name = "CustomerDetails";
			reportDataSource4.Value = this.ProductCreditNoteCustomerDetailsBindingSource;
			reportDataSource5.Name = "InvoiceDetails";
			reportDataSource5.Value = this.ProductCreditNoteSelectBindingSource;
			reportDataSource6.Name = "BranchDetails";
			reportDataSource6.Value = this.GetBranchDetailsBindingSource;
			reportDataSource7.Name = "BankingDetails";
			reportDataSource7.Value = this.GetBankingDetailsBindingSource;
			reportDataSource8.Name = "BankingDetails2";
			reportDataSource8.Value = this.BankingDetails2BindingSource;
			reportDataSource9.Name = "InvTotals";
			reportDataSource9.Value = this.ProductCreditNoteInvTotalsBindingSource;
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource2);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource3);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource4);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource5);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource6);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource7);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource8);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource9);
			this.ReportViewer1.LocalReport.ReportEmbeddedResource = "PointOfSale.ProductsCreditedReport.rdlc";
			this.ReportViewer1.Location = new global::System.Drawing.Point(0, 0);
			this.ReportViewer1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ReportViewer1.Name = "ReportViewer1";
			this.ReportViewer1.Size = new global::System.Drawing.Size(1234, 568);
			this.ReportViewer1.TabIndex = 0;
			this.GetCompanyDetailsTableAdapter.ClearBeforeFill = true;
			this.ProductCreditNotePayMethodsTableAdapter.ClearBeforeFill = true;
			this.ProductCreditNoteUserTableAdapter.ClearBeforeFill = true;
			this.ProductCreditNoteCustomerDetailsTableAdapter.ClearBeforeFill = true;
			this.ProductCreditNoteSelectTableAdapter.ClearBeforeFill = true;
			this.GetBranchDetailsTableAdapter.ClearBeforeFill = true;
			this.GetBankingDetailsTableAdapter.ClearBeforeFill = true;
			this.BankingDetails2TableAdapter.ClearBeforeFill = true;
			this.ProductCreditNoteInvTotalsTableAdapter.ClearBeforeFill = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1234, 568);
			base.Controls.Add(this.ReportViewer1);
			base.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			base.Name = "ProductsCreditedReport";
			this.Text = "Products Credited Report";
			((global::System.ComponentModel.ISupportInitialize)this.GetCompanyDetailsBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.POSDataSet).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.ProductCreditNotePayMethodsBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.ProductCreditNoteUserBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.ProductCreditNoteCustomerDetailsBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.ProductCreditNoteSelectBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetBranchDetailsBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetBankingDetailsBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.BankingDetails2BindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.ProductCreditNoteInvTotalsBindingSource).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04001703 RID: 5891
		private global::System.ComponentModel.IContainer components;
	}
}
