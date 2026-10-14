namespace PointOfSale
{
	// Token: 0x0200003F RID: 63
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class DespatchNoteForm : global::System.Windows.Forms.Form
	{
		// Token: 0x06000E41 RID: 3649 RVA: 0x00089C70 File Offset: 0x00087E70
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

		// Token: 0x06000E42 RID: 3650 RVA: 0x00089CC0 File Offset: 0x00087EC0
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			this.GetUserForInvoiceBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.POSDataSet = new global::PointOfSale.POSDataSet();
			this.DespatchNoteBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.GetBranchDetails1BindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.GetCompanyDetailsForCoidBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.ReportViewer1 = new global::Microsoft.Reporting.WinForms.ReportViewer();
			this.GetUserForInvoiceTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.GetUserForInvoiceTableAdapter();
			this.DespatchNoteTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.DespatchNoteTableAdapter();
			this.GetBranchDetails1TableAdapter = new global::PointOfSale.POSDataSetTableAdapters.GetBranchDetails1TableAdapter();
			this.GetCompanyDetailsForCoidTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.GetCompanyDetailsForCoidTableAdapter();
			this.GetUserForDespatchBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.GetUserForDespatchTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.GetUserForDespatchTableAdapter();
			this.FetchCustomerDetailsFromDespatchBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.FetchCustomerDetailsFromDespatchTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.FetchCustomerDetailsFromDespatchTableAdapter();
			((global::System.ComponentModel.ISupportInitialize)this.GetUserForInvoiceBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.POSDataSet).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.DespatchNoteBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetBranchDetails1BindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetCompanyDetailsForCoidBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetUserForDespatchBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.FetchCustomerDetailsFromDespatchBindingSource).BeginInit();
			base.SuspendLayout();
			this.GetUserForInvoiceBindingSource.DataMember = "GetUserForInvoice";
			this.GetUserForInvoiceBindingSource.DataSource = this.POSDataSet;
			this.POSDataSet.DataSetName = "POSDataSet";
			this.POSDataSet.SchemaSerializationMode = global::System.Data.SchemaSerializationMode.IncludeSchema;
			this.DespatchNoteBindingSource.DataMember = "DespatchNote";
			this.DespatchNoteBindingSource.DataSource = this.POSDataSet;
			this.GetBranchDetails1BindingSource.DataMember = "GetBranchDetails1";
			this.GetBranchDetails1BindingSource.DataSource = this.POSDataSet;
			this.GetCompanyDetailsForCoidBindingSource.DataMember = "GetCompanyDetailsForCoid";
			this.GetCompanyDetailsForCoidBindingSource.DataSource = this.POSDataSet;
			this.ReportViewer1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			reportDataSource.Name = "InvoiceUser";
			reportDataSource.Value = this.GetUserForDespatchBindingSource;
			reportDataSource2.Name = "CustomerDetails";
			reportDataSource2.Value = this.FetchCustomerDetailsFromDespatchBindingSource;
			reportDataSource3.Name = "InvoiceDetails";
			reportDataSource3.Value = this.DespatchNoteBindingSource;
			reportDataSource4.Name = "BranchDetails";
			reportDataSource4.Value = this.GetBranchDetails1BindingSource;
			reportDataSource5.Name = "CompanyDetails";
			reportDataSource5.Value = this.GetCompanyDetailsForCoidBindingSource;
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource2);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource3);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource4);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource5);
			this.ReportViewer1.LocalReport.ReportEmbeddedResource = "PointOfSale.DespatchNote.rdlc";
			this.ReportViewer1.Location = new global::System.Drawing.Point(0, 0);
			this.ReportViewer1.Name = "ReportViewer1";
			this.ReportViewer1.Size = new global::System.Drawing.Size(1375, 780);
			this.ReportViewer1.TabIndex = 0;
			this.GetUserForInvoiceTableAdapter.ClearBeforeFill = true;
			this.DespatchNoteTableAdapter.ClearBeforeFill = true;
			this.GetBranchDetails1TableAdapter.ClearBeforeFill = true;
			this.GetCompanyDetailsForCoidTableAdapter.ClearBeforeFill = true;
			this.GetUserForDespatchBindingSource.DataMember = "GetUserForDespatch";
			this.GetUserForDespatchBindingSource.DataSource = this.POSDataSet;
			this.GetUserForDespatchTableAdapter.ClearBeforeFill = true;
			this.FetchCustomerDetailsFromDespatchBindingSource.DataMember = "FetchCustomerDetailsFromDespatch";
			this.FetchCustomerDetailsFromDespatchBindingSource.DataSource = this.POSDataSet;
			this.FetchCustomerDetailsFromDespatchTableAdapter.ClearBeforeFill = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1375, 780);
			base.Controls.Add(this.ReportViewer1);
			base.Name = "DespatchNoteForm";
			this.Text = "Despatch Note Form";
			((global::System.ComponentModel.ISupportInitialize)this.GetUserForInvoiceBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.POSDataSet).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.DespatchNoteBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetBranchDetails1BindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetCompanyDetailsForCoidBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetUserForDespatchBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.FetchCustomerDetailsFromDespatchBindingSource).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x040006C3 RID: 1731
		private global::System.ComponentModel.IContainer components;
	}
}
