namespace PointOfSale
{
	// Token: 0x0200019F RID: 415
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class SalesforPeriodbyShift : global::System.Windows.Forms.UserControl
	{
		// Token: 0x06004A1C RID: 18972 RVA: 0x002CA390 File Offset: 0x002C8590
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

		// Token: 0x06004A1D RID: 18973 RVA: 0x002CA3E0 File Offset: 0x002C85E0
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
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource10 = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource11 = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.DTStartdate = new global::System.Windows.Forms.DateTimePicker();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.cboBranch = new global::System.Windows.Forms.ComboBox();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.Label5 = new global::System.Windows.Forms.Label();
			this.DTEnddate = new global::System.Windows.Forms.DateTimePicker();
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.ReportViewer1 = new global::Microsoft.Reporting.WinForms.ReportViewer();
			this.ShiftSalesPaymentSummaryforPeriodBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.POSDataSet = new global::PointOfSale.POSDataSet();
			this.ShiftSalesForPERIODBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.ShiftSalesSummaryByUserPeriodBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.GetCompanyDetailsBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.BillingSalesBreakdownForPeriodBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.BillingPaymentSummaryPeriodBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.DiscountsForPeriodBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.SalesbyTaxPeriodAllUsersBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.GetProdCreditNoteChargesBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.CreditPaymentsForPeriodBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.PeriodAuditInfoBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.ShiftSalesPaymentSummaryforPeriodTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.ShiftSalesPaymentSummaryforPeriodTableAdapter();
			this.ShiftSalesForPERIODTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.ShiftSalesForPERIODTableAdapter();
			this.ShiftSalesSummaryByUserPeriodTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.ShiftSalesSummaryByUserPeriodTableAdapter();
			this.GetCompanyDetailsTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.GetCompanyDetailsTableAdapter();
			this.BillingSalesBreakdownForPeriodTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.BillingSalesBreakdownForPeriodTableAdapter();
			this.BillingPaymentSummaryPeriodTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.BillingPaymentSummaryPeriodTableAdapter();
			this.DiscountsForPeriodTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.DiscountsForPeriodTableAdapter();
			this.SalesbyTaxPeriodAllUsersTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.SalesbyTaxPeriodAllUsersTableAdapter();
			this.GetProdCreditNoteChargesTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.GetProdCreditNoteChargesTableAdapter();
			this.CreditPaymentsForPeriodTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.CreditPaymentsForPeriodTableAdapter();
			this.PeriodAuditInfoTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.PeriodAuditInfoTableAdapter();
			this.chkReduce = new global::System.Windows.Forms.CheckBox();
			this.GroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.ShiftSalesPaymentSummaryforPeriodBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.POSDataSet).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.ShiftSalesForPERIODBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.ShiftSalesSummaryByUserPeriodBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetCompanyDetailsBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.BillingSalesBreakdownForPeriodBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.BillingPaymentSummaryPeriodBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.DiscountsForPeriodBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.SalesbyTaxPeriodAllUsersBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetProdCreditNoteChargesBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.CreditPaymentsForPeriodBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.PeriodAuditInfoBindingSource).BeginInit();
			base.SuspendLayout();
			this.Label1.AutoSize = true;
			this.Label1.Location = new global::System.Drawing.Point(3, 89);
			this.Label1.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(94, 20);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Select date:";
			this.DTStartdate.Location = new global::System.Drawing.Point(108, 85);
			this.DTStartdate.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.DTStartdate.Name = "DTStartdate";
			this.DTStartdate.Size = new global::System.Drawing.Size(298, 26);
			this.DTStartdate.TabIndex = 1;
			this.Button1.BackColor = global::System.Drawing.Color.Lime;
			this.Button1.Location = new global::System.Drawing.Point(1208, 83);
			this.Button1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(207, 35);
			this.Button1.TabIndex = 2;
			this.Button1.Text = "RUN REPORT";
			this.Button1.UseVisualStyleBackColor = false;
			this.Label2.AutoSize = true;
			this.Label2.BackColor = global::System.Drawing.Color.Red;
			this.Label2.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.Label2.Location = new global::System.Drawing.Point(1403, 24);
			this.Label2.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(49, 20);
			this.Label2.TabIndex = 3;
			this.Label2.Text = "Close";
			this.Label3.AutoSize = true;
			this.Label3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label3.Location = new global::System.Drawing.Point(532, 25);
			this.Label3.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(446, 32);
			this.Label3.TabIndex = 4;
			this.Label3.Text = "Sales Report for Period for Branch";
			this.cboBranch.FormattingEnabled = true;
			this.cboBranch.Location = new global::System.Drawing.Point(940, 85);
			this.cboBranch.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cboBranch.Name = "cboBranch";
			this.cboBranch.Size = new global::System.Drawing.Size(256, 28);
			this.cboBranch.TabIndex = 5;
			this.Label4.AutoSize = true;
			this.Label4.Location = new global::System.Drawing.Point(870, 89);
			this.Label4.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label4.Name = "Label4";
			this.Label4.Size = new global::System.Drawing.Size(60, 20);
			this.Label4.TabIndex = 6;
			this.Label4.Text = "Branch";
			this.Label5.AutoSize = true;
			this.Label5.Location = new global::System.Drawing.Point(453, 89);
			this.Label5.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label5.Name = "Label5";
			this.Label5.Size = new global::System.Drawing.Size(81, 20);
			this.Label5.TabIndex = 7;
			this.Label5.Text = "End Date:";
			this.DTEnddate.Location = new global::System.Drawing.Point(544, 85);
			this.DTEnddate.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.DTEnddate.Name = "DTEnddate";
			this.DTEnddate.Size = new global::System.Drawing.Size(298, 26);
			this.DTEnddate.TabIndex = 8;
			this.GroupBox1.Controls.Add(this.chkReduce);
			this.GroupBox1.Controls.Add(this.DTEnddate);
			this.GroupBox1.Controls.Add(this.Label5);
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Controls.Add(this.cboBranch);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Controls.Add(this.DTStartdate);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Padding = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GroupBox1.Size = new global::System.Drawing.Size(1456, 138);
			this.GroupBox1.TabIndex = 2;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Details";
			this.ReportViewer1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			reportDataSource.Name = "PaymentSummary";
			reportDataSource.Value = this.ShiftSalesPaymentSummaryforPeriodBindingSource;
			reportDataSource2.Name = "Sales";
			reportDataSource2.Value = this.ShiftSalesForPERIODBindingSource;
			reportDataSource3.Name = "UserSalesSummary";
			reportDataSource3.Value = this.ShiftSalesSummaryByUserPeriodBindingSource;
			reportDataSource4.Name = "CompanyDetails";
			reportDataSource4.Value = this.GetCompanyDetailsBindingSource;
			reportDataSource5.Name = "SalesBreakdown";
			reportDataSource5.Value = this.BillingSalesBreakdownForPeriodBindingSource;
			reportDataSource6.Name = "AccPayments";
			reportDataSource6.Value = this.BillingPaymentSummaryPeriodBindingSource;
			reportDataSource7.Name = "DiscountsForPeriod";
			reportDataSource7.Value = this.DiscountsForPeriodBindingSource;
			reportDataSource8.Name = "SalesbyTax";
			reportDataSource8.Value = this.SalesbyTaxPeriodAllUsersBindingSource;
			reportDataSource9.Name = "Charges";
			reportDataSource9.Value = this.GetProdCreditNoteChargesBindingSource;
			reportDataSource10.Name = "Refunds";
			reportDataSource10.Value = this.CreditPaymentsForPeriodBindingSource;
			reportDataSource11.Name = "Audit";
			reportDataSource11.Value = this.PeriodAuditInfoBindingSource;
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource2);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource3);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource4);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource5);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource6);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource7);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource8);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource9);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource10);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource11);
			this.ReportViewer1.LocalReport.ReportEmbeddedResource = "PointOfSale.ShiftSalesForPeriod.rdlc";
			this.ReportViewer1.Location = new global::System.Drawing.Point(0, 138);
			this.ReportViewer1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ReportViewer1.Name = "ReportViewer1";
			this.ReportViewer1.Size = new global::System.Drawing.Size(1456, 640);
			this.ReportViewer1.TabIndex = 3;
			this.ShiftSalesPaymentSummaryforPeriodBindingSource.DataMember = "ShiftSalesPaymentSummaryforPeriod";
			this.ShiftSalesPaymentSummaryforPeriodBindingSource.DataSource = this.POSDataSet;
			this.POSDataSet.DataSetName = "POSDataSet";
			this.POSDataSet.SchemaSerializationMode = global::System.Data.SchemaSerializationMode.IncludeSchema;
			this.ShiftSalesForPERIODBindingSource.DataMember = "ShiftSalesForPERIOD";
			this.ShiftSalesForPERIODBindingSource.DataSource = this.POSDataSet;
			this.ShiftSalesSummaryByUserPeriodBindingSource.DataMember = "ShiftSalesSummaryByUserPeriod";
			this.ShiftSalesSummaryByUserPeriodBindingSource.DataSource = this.POSDataSet;
			this.GetCompanyDetailsBindingSource.DataMember = "GetCompanyDetails";
			this.GetCompanyDetailsBindingSource.DataSource = this.POSDataSet;
			this.BillingSalesBreakdownForPeriodBindingSource.DataMember = "BillingSalesBreakdownForPeriod";
			this.BillingSalesBreakdownForPeriodBindingSource.DataSource = this.POSDataSet;
			this.BillingPaymentSummaryPeriodBindingSource.DataMember = "BillingPaymentSummaryPeriod";
			this.BillingPaymentSummaryPeriodBindingSource.DataSource = this.POSDataSet;
			this.DiscountsForPeriodBindingSource.DataMember = "DiscountsForPeriod";
			this.DiscountsForPeriodBindingSource.DataSource = this.POSDataSet;
			this.SalesbyTaxPeriodAllUsersBindingSource.DataMember = "SalesbyTaxPeriodAllUsers";
			this.SalesbyTaxPeriodAllUsersBindingSource.DataSource = this.POSDataSet;
			this.GetProdCreditNoteChargesBindingSource.DataMember = "GetProdCreditNoteCharges";
			this.GetProdCreditNoteChargesBindingSource.DataSource = this.POSDataSet;
			this.CreditPaymentsForPeriodBindingSource.DataMember = "CreditPaymentsForPeriod";
			this.CreditPaymentsForPeriodBindingSource.DataSource = this.POSDataSet;
			this.PeriodAuditInfoBindingSource.DataMember = "PeriodAuditInfo";
			this.PeriodAuditInfoBindingSource.DataSource = this.POSDataSet;
			this.ShiftSalesPaymentSummaryforPeriodTableAdapter.ClearBeforeFill = true;
			this.ShiftSalesForPERIODTableAdapter.ClearBeforeFill = true;
			this.ShiftSalesSummaryByUserPeriodTableAdapter.ClearBeforeFill = true;
			this.GetCompanyDetailsTableAdapter.ClearBeforeFill = true;
			this.BillingSalesBreakdownForPeriodTableAdapter.ClearBeforeFill = true;
			this.BillingPaymentSummaryPeriodTableAdapter.ClearBeforeFill = true;
			this.DiscountsForPeriodTableAdapter.ClearBeforeFill = true;
			this.SalesbyTaxPeriodAllUsersTableAdapter.ClearBeforeFill = true;
			this.GetProdCreditNoteChargesTableAdapter.ClearBeforeFill = true;
			this.CreditPaymentsForPeriodTableAdapter.ClearBeforeFill = true;
			this.PeriodAuditInfoTableAdapter.ClearBeforeFill = true;
			this.chkReduce.AutoSize = true;
			this.chkReduce.Location = new global::System.Drawing.Point(1208, 51);
			this.chkReduce.Name = "chkReduce";
			this.chkReduce.Size = new global::System.Drawing.Size(235, 24);
			this.chkReduce.TabIndex = 9;
			this.chkReduce.Text = "Reduce Cost by Tax amount";
			this.chkReduce.UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.Controls.Add(this.ReportViewer1);
			base.Controls.Add(this.GroupBox1);
			base.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			base.Name = "SalesforPeriodbyShift";
			base.Size = new global::System.Drawing.Size(1456, 778);
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.ShiftSalesPaymentSummaryforPeriodBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.POSDataSet).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.ShiftSalesForPERIODBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.ShiftSalesSummaryByUserPeriodBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetCompanyDetailsBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.BillingSalesBreakdownForPeriodBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.BillingPaymentSummaryPeriodBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.DiscountsForPeriodBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.SalesbyTaxPeriodAllUsersBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetProdCreditNoteChargesBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.CreditPaymentsForPeriodBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.PeriodAuditInfoBindingSource).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x0400207D RID: 8317
		private global::System.ComponentModel.IContainer components;
	}
}
