namespace PointOfSale
{
	// Token: 0x0200005E RID: 94
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class frmAccStatement : global::System.Windows.Forms.Form
	{
		// Token: 0x060013CF RID: 5071 RVA: 0x000BC368 File Offset: 0x000BA568
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

		// Token: 0x060013D0 RID: 5072 RVA: 0x000BC3B8 File Offset: 0x000BA5B8
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			this.ReportViewer1 = new global::Microsoft.Reporting.WinForms.ReportViewer();
			this.GetCompanyDetailsBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.POSDataSet = new global::PointOfSale.POSDataSet();
			this.BillingCustomerTransactionsBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.BillingCalcAccBalanceBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.GetCompanyDetailsTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.GetCompanyDetailsTableAdapter();
			this.BillingCustomerTransactionsTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.BillingCustomerTransactionsTableAdapter();
			this.BillingCalcAccBalanceTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.BillingCalcAccBalanceTableAdapter();
			((global::System.ComponentModel.ISupportInitialize)this.GetCompanyDetailsBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.POSDataSet).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.BillingCustomerTransactionsBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.BillingCalcAccBalanceBindingSource).BeginInit();
			base.SuspendLayout();
			this.ReportViewer1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			reportDataSource.Name = "CompanyDetails";
			reportDataSource.Value = this.GetCompanyDetailsBindingSource;
			reportDataSource2.Name = "Transactions";
			reportDataSource2.Value = this.BillingCustomerTransactionsBindingSource;
			reportDataSource3.Name = "AccBal";
			reportDataSource3.Value = this.BillingCalcAccBalanceBindingSource;
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource2);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource3);
			this.ReportViewer1.LocalReport.ReportEmbeddedResource = "PointOfSale.AccStatement.rdlc";
			this.ReportViewer1.Location = new global::System.Drawing.Point(0, 0);
			this.ReportViewer1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ReportViewer1.Name = "ReportViewer1";
			this.ReportViewer1.Size = new global::System.Drawing.Size(1434, 823);
			this.ReportViewer1.TabIndex = 0;
			this.GetCompanyDetailsBindingSource.DataMember = "GetCompanyDetails";
			this.GetCompanyDetailsBindingSource.DataSource = this.POSDataSet;
			this.POSDataSet.DataSetName = "POSDataSet";
			this.POSDataSet.SchemaSerializationMode = global::System.Data.SchemaSerializationMode.IncludeSchema;
			this.BillingCustomerTransactionsBindingSource.DataMember = "BillingCustomerTransactions";
			this.BillingCustomerTransactionsBindingSource.DataSource = this.POSDataSet;
			this.BillingCalcAccBalanceBindingSource.DataMember = "BillingCalcAccBalance";
			this.BillingCalcAccBalanceBindingSource.DataSource = this.POSDataSet;
			this.GetCompanyDetailsTableAdapter.ClearBeforeFill = true;
			this.BillingCustomerTransactionsTableAdapter.ClearBeforeFill = true;
			this.BillingCalcAccBalanceTableAdapter.ClearBeforeFill = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1434, 823);
			base.Controls.Add(this.ReportViewer1);
			base.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			base.Name = "frmAccStatement";
			this.Text = "Account Statement";
			((global::System.ComponentModel.ISupportInitialize)this.GetCompanyDetailsBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.POSDataSet).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.BillingCustomerTransactionsBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.BillingCalcAccBalanceBindingSource).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000A0C RID: 2572
		private global::System.ComponentModel.IContainer components;
	}
}
