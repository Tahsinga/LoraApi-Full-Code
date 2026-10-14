namespace PointOfSale
{
	// Token: 0x020001A4 RID: 420
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class SalesInvoice : global::System.Windows.Forms.Form
	{
		// Token: 0x06004B34 RID: 19252 RVA: 0x002D1344 File Offset: 0x002CF544
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

		// Token: 0x06004B35 RID: 19253 RVA: 0x002D1394 File Offset: 0x002CF594
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			this.GetPaymentMethodsForInvoiceBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.POSDataSet = new global::PointOfSale.POSDataSet();
			this.GetUserForInvoiceBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.SalesByInvoiceNumberBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.FetchCustomerDetailsFromInvBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.GetCompanyDetailsBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.ReportViewer1 = new global::Microsoft.Reporting.WinForms.ReportViewer();
			this.GetCompanyDetailsTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.GetCompanyDetailsTableAdapter();
			this.SalesByInvoiceNumberTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.SalesByInvoiceNumberTableAdapter();
			this.GetPaymentMethodsForInvoiceTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.GetPaymentMethodsForInvoiceTableAdapter();
			this.GetUserForInvoiceTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.GetUserForInvoiceTableAdapter();
			this.FetchCustomerDetailsFromInvTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.FetchCustomerDetailsFromInvTableAdapter();
			((global::System.ComponentModel.ISupportInitialize)this.GetPaymentMethodsForInvoiceBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.POSDataSet).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetUserForInvoiceBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.SalesByInvoiceNumberBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.FetchCustomerDetailsFromInvBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetCompanyDetailsBindingSource).BeginInit();
			base.SuspendLayout();
			this.GetPaymentMethodsForInvoiceBindingSource.DataMember = "GetPaymentMethodsForInvoice";
			this.GetPaymentMethodsForInvoiceBindingSource.DataSource = this.POSDataSet;
			this.POSDataSet.DataSetName = "POSDataSet";
			this.POSDataSet.SchemaSerializationMode = global::System.Data.SchemaSerializationMode.IncludeSchema;
			this.GetUserForInvoiceBindingSource.DataMember = "GetUserForInvoice";
			this.GetUserForInvoiceBindingSource.DataSource = this.POSDataSet;
			this.SalesByInvoiceNumberBindingSource.DataMember = "SalesByInvoiceNumber";
			this.SalesByInvoiceNumberBindingSource.DataSource = this.POSDataSet;
			this.FetchCustomerDetailsFromInvBindingSource.DataMember = "FetchCustomerDetailsFromInv";
			this.FetchCustomerDetailsFromInvBindingSource.DataSource = this.POSDataSet;
			this.GetCompanyDetailsBindingSource.DataMember = "GetCompanyDetails";
			this.GetCompanyDetailsBindingSource.DataSource = this.POSDataSet;
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
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource2);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource3);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource4);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource5);
			this.ReportViewer1.LocalReport.ReportEmbeddedResource = "PointOfSale.SalesInvoice.rdlc";
			this.ReportViewer1.Location = new global::System.Drawing.Point(0, 0);
			this.ReportViewer1.Name = "ReportViewer1";
			this.ReportViewer1.Size = new global::System.Drawing.Size(1055, 426);
			this.ReportViewer1.TabIndex = 3;
			this.GetCompanyDetailsTableAdapter.ClearBeforeFill = true;
			this.SalesByInvoiceNumberTableAdapter.ClearBeforeFill = true;
			this.GetPaymentMethodsForInvoiceTableAdapter.ClearBeforeFill = true;
			this.GetUserForInvoiceTableAdapter.ClearBeforeFill = true;
			this.FetchCustomerDetailsFromInvTableAdapter.ClearBeforeFill = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1055, 426);
			base.Controls.Add(this.ReportViewer1);
			base.Name = "SalesInvoice";
			this.Text = "SalesInvoice";
			((global::System.ComponentModel.ISupportInitialize)this.GetPaymentMethodsForInvoiceBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.POSDataSet).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetUserForInvoiceBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.SalesByInvoiceNumberBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.FetchCustomerDetailsFromInvBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetCompanyDetailsBindingSource).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x040020FA RID: 8442
		private global::System.ComponentModel.IContainer components;
	}
}
