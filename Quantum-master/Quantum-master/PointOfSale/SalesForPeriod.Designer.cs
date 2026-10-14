namespace PointOfSale
{
	// Token: 0x0200019E RID: 414
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class SalesForPeriod : global::System.Windows.Forms.UserControl
	{
		// Token: 0x060049D5 RID: 18901 RVA: 0x002C8AF4 File Offset: 0x002C6CF4
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

		// Token: 0x060049D6 RID: 18902 RVA: 0x002C8B44 File Offset: 0x002C6D44
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
			this.CostofSalesForPeriodBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.CostofAdjustmentsBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.ExpensesForPeriodBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.SalesPaymentSummaryPERIODBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.TaxReturnsForPeriodSummaryBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.BillingSalesBreakdownForPeriodBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.BillingPaymentSummaryPeriodBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.SalesForPeriodBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.Label5 = new global::System.Windows.Forms.Label();
			this.cboBranch = new global::System.Windows.Forms.ComboBox();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.DTEnddate = new global::System.Windows.Forms.DateTimePicker();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.DTStartdate = new global::System.Windows.Forms.DateTimePicker();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.ReportViewer1 = new global::Microsoft.Reporting.WinForms.ReportViewer();
			this.GetCompanyDetailsTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.GetCompanyDetailsTableAdapter();
			this.CostofSalesForPeriodTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.CostofSalesForPeriodTableAdapter();
			this.CostofAdjustmentsTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.CostofAdjustmentsTableAdapter();
			this.ExpensesForPeriodTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.ExpensesForPeriodTableAdapter();
			this.SalesForPeriodTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.SalesForPeriodTableAdapter();
			this.TaxReturnsForPeriodSummaryTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.TaxReturnsForPeriodSummaryTableAdapter();
			this.SalesPaymentSummaryPERIODTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.SalesPaymentSummaryPERIODTableAdapter();
			this.BillingSalesBreakdownForPeriodTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.BillingSalesBreakdownForPeriodTableAdapter();
			this.BillingPaymentSummaryPeriodTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.BillingPaymentSummaryPeriodTableAdapter();
			this.GetInvoiceDiscountsForPeriodBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.GetInvoiceDiscountsForPeriodTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.GetInvoiceDiscountsForPeriodTableAdapter();
			((global::System.ComponentModel.ISupportInitialize)this.GetCompanyDetailsBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.POSDataSet).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.CostofSalesForPeriodBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.CostofAdjustmentsBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.ExpensesForPeriodBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.SalesPaymentSummaryPERIODBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.TaxReturnsForPeriodSummaryBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.BillingSalesBreakdownForPeriodBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.BillingPaymentSummaryPeriodBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.SalesForPeriodBindingSource).BeginInit();
			this.GroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.GetInvoiceDiscountsForPeriodBindingSource).BeginInit();
			base.SuspendLayout();
			this.GetCompanyDetailsBindingSource.DataMember = "GetCompanyDetails";
			this.GetCompanyDetailsBindingSource.DataSource = this.POSDataSet;
			this.POSDataSet.DataSetName = "POSDataSet";
			this.POSDataSet.SchemaSerializationMode = global::System.Data.SchemaSerializationMode.IncludeSchema;
			this.CostofSalesForPeriodBindingSource.DataMember = "CostofSalesForPeriod";
			this.CostofSalesForPeriodBindingSource.DataSource = this.POSDataSet;
			this.CostofAdjustmentsBindingSource.DataMember = "CostofAdjustments";
			this.CostofAdjustmentsBindingSource.DataSource = this.POSDataSet;
			this.ExpensesForPeriodBindingSource.DataMember = "ExpensesForPeriod";
			this.ExpensesForPeriodBindingSource.DataSource = this.POSDataSet;
			this.SalesPaymentSummaryPERIODBindingSource.DataMember = "SalesPaymentSummaryPERIOD";
			this.SalesPaymentSummaryPERIODBindingSource.DataSource = this.POSDataSet;
			this.TaxReturnsForPeriodSummaryBindingSource.DataMember = "TaxReturnsForPeriodSummary";
			this.TaxReturnsForPeriodSummaryBindingSource.DataSource = this.POSDataSet;
			this.BillingSalesBreakdownForPeriodBindingSource.DataMember = "BillingSalesBreakdownForPeriod";
			this.BillingSalesBreakdownForPeriodBindingSource.DataSource = this.POSDataSet;
			this.BillingPaymentSummaryPeriodBindingSource.DataMember = "BillingPaymentSummaryPeriod";
			this.BillingPaymentSummaryPeriodBindingSource.DataSource = this.POSDataSet;
			this.SalesForPeriodBindingSource.DataMember = "SalesForPeriod";
			this.SalesForPeriodBindingSource.DataSource = this.POSDataSet;
			this.GroupBox1.Controls.Add(this.Label5);
			this.GroupBox1.Controls.Add(this.cboBranch);
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.DTEnddate);
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Controls.Add(this.DTStartdate);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new global::System.Drawing.Size(998, 90);
			this.GroupBox1.TabIndex = 1;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Details";
			this.Label5.AutoSize = true;
			this.Label5.Location = new global::System.Drawing.Point(625, 60);
			this.Label5.Name = "Label5";
			this.Label5.Size = new global::System.Drawing.Size(41, 13);
			this.Label5.TabIndex = 10;
			this.Label5.Text = "Branch";
			this.cboBranch.FormattingEnabled = true;
			this.cboBranch.Location = new global::System.Drawing.Point(672, 57);
			this.cboBranch.Name = "cboBranch";
			this.cboBranch.Size = new global::System.Drawing.Size(172, 21);
			this.cboBranch.TabIndex = 9;
			this.Label4.AutoSize = true;
			this.Label4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label4.Location = new global::System.Drawing.Point(358, 16);
			this.Label4.Name = "Label4";
			this.Label4.Size = new global::System.Drawing.Size(325, 24);
			this.Label4.TabIndex = 6;
			this.Label4.Text = "Revenue Report for Period for Branch";
			this.Label3.AutoSize = true;
			this.Label3.BackColor = global::System.Drawing.Color.Red;
			this.Label3.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.Label3.Location = new global::System.Drawing.Point(962, 16);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(33, 13);
			this.Label3.TabIndex = 5;
			this.Label3.Text = "Close";
			this.Label2.AutoSize = true;
			this.Label2.Location = new global::System.Drawing.Point(321, 60);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(55, 13);
			this.Label2.TabIndex = 4;
			this.Label2.Text = "End Date:";
			this.DTEnddate.Location = new global::System.Drawing.Point(382, 57);
			this.DTEnddate.Name = "DTEnddate";
			this.DTEnddate.Size = new global::System.Drawing.Size(200, 20);
			this.DTEnddate.TabIndex = 3;
			this.Button1.BackColor = global::System.Drawing.Color.Lime;
			this.Button1.Location = new global::System.Drawing.Point(860, 55);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(138, 23);
			this.Button1.TabIndex = 2;
			this.Button1.Text = "RUN REPORT";
			this.Button1.UseVisualStyleBackColor = false;
			this.DTStartdate.Location = new global::System.Drawing.Point(75, 57);
			this.DTStartdate.Name = "DTStartdate";
			this.DTStartdate.Size = new global::System.Drawing.Size(200, 20);
			this.DTStartdate.TabIndex = 1;
			this.Label1.AutoSize = true;
			this.Label1.Location = new global::System.Drawing.Point(11, 60);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(58, 13);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Start Date:";
			this.ReportViewer1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			reportDataSource.Name = "CostofSales";
			reportDataSource.Value = this.CostofSalesForPeriodBindingSource;
			reportDataSource2.Name = "CostofAdjustments";
			reportDataSource2.Value = this.CostofAdjustmentsBindingSource;
			reportDataSource3.Name = "Expenses";
			reportDataSource3.Value = this.ExpensesForPeriodBindingSource;
			reportDataSource4.Name = "Sales";
			reportDataSource4.Value = this.SalesPaymentSummaryPERIODBindingSource;
			reportDataSource5.Name = "Tax";
			reportDataSource5.Value = this.TaxReturnsForPeriodSummaryBindingSource;
			reportDataSource6.Name = "TotalSales";
			reportDataSource6.Value = this.BillingSalesBreakdownForPeriodBindingSource;
			reportDataSource7.Name = "AccPayments";
			reportDataSource7.Value = this.BillingPaymentSummaryPeriodBindingSource;
			reportDataSource8.Name = "InvDiscounts";
			reportDataSource8.Value = this.GetInvoiceDiscountsForPeriodBindingSource;
			reportDataSource9.Name = "CompanyDetails";
			reportDataSource9.Value = this.GetCompanyDetailsBindingSource;
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource2);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource3);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource4);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource5);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource6);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource7);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource8);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource9);
			this.ReportViewer1.LocalReport.ReportEmbeddedResource = "PointOfSale.SalesForPeriod.rdlc";
			this.ReportViewer1.Location = new global::System.Drawing.Point(0, 90);
			this.ReportViewer1.Name = "ReportViewer1";
			this.ReportViewer1.Size = new global::System.Drawing.Size(998, 296);
			this.ReportViewer1.TabIndex = 2;
			this.GetCompanyDetailsTableAdapter.ClearBeforeFill = true;
			this.CostofSalesForPeriodTableAdapter.ClearBeforeFill = true;
			this.CostofAdjustmentsTableAdapter.ClearBeforeFill = true;
			this.ExpensesForPeriodTableAdapter.ClearBeforeFill = true;
			this.SalesForPeriodTableAdapter.ClearBeforeFill = true;
			this.TaxReturnsForPeriodSummaryTableAdapter.ClearBeforeFill = true;
			this.SalesPaymentSummaryPERIODTableAdapter.ClearBeforeFill = true;
			this.BillingSalesBreakdownForPeriodTableAdapter.ClearBeforeFill = true;
			this.BillingPaymentSummaryPeriodTableAdapter.ClearBeforeFill = true;
			this.GetInvoiceDiscountsForPeriodBindingSource.DataMember = "GetInvoiceDiscountsForPeriod";
			this.GetInvoiceDiscountsForPeriodBindingSource.DataSource = this.POSDataSet;
			this.GetInvoiceDiscountsForPeriodTableAdapter.ClearBeforeFill = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.Controls.Add(this.ReportViewer1);
			base.Controls.Add(this.GroupBox1);
			base.Name = "SalesForPeriod";
			base.Size = new global::System.Drawing.Size(998, 386);
			((global::System.ComponentModel.ISupportInitialize)this.GetCompanyDetailsBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.POSDataSet).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.CostofSalesForPeriodBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.CostofAdjustmentsBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.ExpensesForPeriodBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.SalesPaymentSummaryPERIODBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.TaxReturnsForPeriodSummaryBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.BillingSalesBreakdownForPeriodBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.BillingPaymentSummaryPeriodBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.SalesForPeriodBindingSource).EndInit();
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.GetInvoiceDiscountsForPeriodBindingSource).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x0400205B RID: 8283
		private global::System.ComponentModel.IContainer components;
	}
}
