namespace PointOfSale
{
	// Token: 0x02000195 RID: 405
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class SalesByInvoice : global::System.Windows.Forms.Form
	{
		// Token: 0x060047CC RID: 18380 RVA: 0x002BD208 File Offset: 0x002BB408
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

		// Token: 0x060047CD RID: 18381 RVA: 0x002BD258 File Offset: 0x002BB458
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
			this.SalesForPeriodInvoiceNumbersBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.POSDataSet = new global::PointOfSale.POSDataSet();
			this.GetCompanyDetailsForCoidBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.DiscountsForPeriodBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.GetProdCreditNoteChargesBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.ShiftSalesPaymentSummaryforPeriodBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.PeriodAuditInfoBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.SalesForPeriodInvoiceNumbersTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.SalesForPeriodInvoiceNumbersTableAdapter();
			this.GetCompanyDetailsForCoidTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.GetCompanyDetailsForCoidTableAdapter();
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.chkAllusers = new global::System.Windows.Forms.CheckBox();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.cboUsers = new global::System.Windows.Forms.ComboBox();
			this.DTEnddate = new global::System.Windows.Forms.DateTimePicker();
			this.Label5 = new global::System.Windows.Forms.Label();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.cboBranch = new global::System.Windows.Forms.ComboBox();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.DTStartdate = new global::System.Windows.Forms.DateTimePicker();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.ReportViewer1 = new global::Microsoft.Reporting.WinForms.ReportViewer();
			this.DiscountsForPeriodTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.DiscountsForPeriodTableAdapter();
			this.GetProdCreditNoteChargesTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.GetProdCreditNoteChargesTableAdapter();
			this.ShiftSalesPaymentSummaryforPeriodTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.ShiftSalesPaymentSummaryforPeriodTableAdapter();
			this.PeriodAuditInfoTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.PeriodAuditInfoTableAdapter();
			this.CreditPaymentsForPeriodBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.CreditPaymentsForPeriodTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.CreditPaymentsForPeriodTableAdapter();
			((global::System.ComponentModel.ISupportInitialize)this.SalesForPeriodInvoiceNumbersBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.POSDataSet).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetCompanyDetailsForCoidBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.DiscountsForPeriodBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetProdCreditNoteChargesBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.ShiftSalesPaymentSummaryforPeriodBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.PeriodAuditInfoBindingSource).BeginInit();
			this.GroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.CreditPaymentsForPeriodBindingSource).BeginInit();
			base.SuspendLayout();
			this.SalesForPeriodInvoiceNumbersBindingSource.DataMember = "SalesForPeriodInvoiceNumbers";
			this.SalesForPeriodInvoiceNumbersBindingSource.DataSource = this.POSDataSet;
			this.POSDataSet.DataSetName = "POSDataSet";
			this.POSDataSet.SchemaSerializationMode = global::System.Data.SchemaSerializationMode.IncludeSchema;
			this.GetCompanyDetailsForCoidBindingSource.DataMember = "GetCompanyDetailsForCoid";
			this.GetCompanyDetailsForCoidBindingSource.DataSource = this.POSDataSet;
			this.DiscountsForPeriodBindingSource.DataMember = "DiscountsForPeriod";
			this.DiscountsForPeriodBindingSource.DataSource = this.POSDataSet;
			this.GetProdCreditNoteChargesBindingSource.DataMember = "GetProdCreditNoteCharges";
			this.GetProdCreditNoteChargesBindingSource.DataSource = this.POSDataSet;
			this.ShiftSalesPaymentSummaryforPeriodBindingSource.DataMember = "ShiftSalesPaymentSummaryforPeriod";
			this.ShiftSalesPaymentSummaryforPeriodBindingSource.DataSource = this.POSDataSet;
			this.PeriodAuditInfoBindingSource.DataMember = "PeriodAuditInfo";
			this.PeriodAuditInfoBindingSource.DataSource = this.POSDataSet;
			this.SalesForPeriodInvoiceNumbersTableAdapter.ClearBeforeFill = true;
			this.GetCompanyDetailsForCoidTableAdapter.ClearBeforeFill = true;
			this.GroupBox1.Controls.Add(this.chkAllusers);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.cboUsers);
			this.GroupBox1.Controls.Add(this.DTEnddate);
			this.GroupBox1.Controls.Add(this.Label5);
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Controls.Add(this.cboBranch);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Controls.Add(this.DTStartdate);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new global::System.Drawing.Size(1310, 181);
			this.GroupBox1.TabIndex = 1;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Set Parameters";
			this.chkAllusers.AutoSize = true;
			this.chkAllusers.Checked = true;
			this.chkAllusers.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.chkAllusers.Location = new global::System.Drawing.Point(815, 125);
			this.chkAllusers.Name = "chkAllusers";
			this.chkAllusers.Size = new global::System.Drawing.Size(107, 24);
			this.chkAllusers.TabIndex = 21;
			this.chkAllusers.Text = "All Users?";
			this.chkAllusers.UseVisualStyleBackColor = true;
			this.Label2.AutoSize = true;
			this.Label2.Location = new global::System.Drawing.Point(491, 129);
			this.Label2.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(55, 20);
			this.Label2.TabIndex = 20;
			this.Label2.Text = "Users:";
			this.cboUsers.FormattingEnabled = true;
			this.cboUsers.Location = new global::System.Drawing.Point(553, 125);
			this.cboUsers.Name = "cboUsers";
			this.cboUsers.Size = new global::System.Drawing.Size(256, 28);
			this.cboUsers.TabIndex = 19;
			this.DTEnddate.Location = new global::System.Drawing.Point(128, 127);
			this.DTEnddate.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.DTEnddate.Name = "DTEnddate";
			this.DTEnddate.Size = new global::System.Drawing.Size(298, 26);
			this.DTEnddate.TabIndex = 18;
			this.Label5.AutoSize = true;
			this.Label5.Location = new global::System.Drawing.Point(36, 131);
			this.Label5.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label5.Name = "Label5";
			this.Label5.Size = new global::System.Drawing.Size(81, 20);
			this.Label5.TabIndex = 17;
			this.Label5.Text = "End Date:";
			this.Label4.AutoSize = true;
			this.Label4.Location = new global::System.Drawing.Point(488, 91);
			this.Label4.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label4.Name = "Label4";
			this.Label4.Size = new global::System.Drawing.Size(60, 20);
			this.Label4.TabIndex = 16;
			this.Label4.Text = "Branch";
			this.cboBranch.FormattingEnabled = true;
			this.cboBranch.Location = new global::System.Drawing.Point(553, 87);
			this.cboBranch.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cboBranch.Name = "cboBranch";
			this.cboBranch.Size = new global::System.Drawing.Size(256, 28);
			this.cboBranch.TabIndex = 15;
			this.Label3.AutoSize = true;
			this.Label3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label3.Location = new global::System.Drawing.Point(29, 27);
			this.Label3.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(625, 32);
			this.Label3.TabIndex = 14;
			this.Label3.Text = "Sales Report by Invoice for Period for Branch";
			this.Button1.BackColor = global::System.Drawing.Color.Lime;
			this.Button1.Location = new global::System.Drawing.Point(1005, 114);
			this.Button1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(203, 35);
			this.Button1.TabIndex = 13;
			this.Button1.Text = "RUN REPORT";
			this.Button1.UseVisualStyleBackColor = false;
			this.DTStartdate.Location = new global::System.Drawing.Point(128, 87);
			this.DTStartdate.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.DTStartdate.Name = "DTStartdate";
			this.DTStartdate.Size = new global::System.Drawing.Size(298, 26);
			this.DTStartdate.TabIndex = 12;
			this.Label1.AutoSize = true;
			this.Label1.Location = new global::System.Drawing.Point(23, 91);
			this.Label1.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(94, 20);
			this.Label1.TabIndex = 11;
			this.Label1.Text = "Select date:";
			this.ReportViewer1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			reportDataSource.Name = "Sales";
			reportDataSource.Value = this.SalesForPeriodInvoiceNumbersBindingSource;
			reportDataSource2.Name = "CompanyDetails";
			reportDataSource2.Value = this.GetCompanyDetailsForCoidBindingSource;
			reportDataSource3.Name = "InvDisc";
			reportDataSource3.Value = this.DiscountsForPeriodBindingSource;
			reportDataSource4.Name = "Charges";
			reportDataSource4.Value = this.GetProdCreditNoteChargesBindingSource;
			reportDataSource5.Name = "PaySum";
			reportDataSource5.Value = this.ShiftSalesPaymentSummaryforPeriodBindingSource;
			reportDataSource6.Name = "audit";
			reportDataSource6.Value = this.PeriodAuditInfoBindingSource;
			reportDataSource7.Name = "Refunds";
			reportDataSource7.Value = this.CreditPaymentsForPeriodBindingSource;
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource2);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource3);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource4);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource5);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource6);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource7);
			this.ReportViewer1.LocalReport.ReportEmbeddedResource = "PointOfSale.SalesByInvoice.rdlc";
			this.ReportViewer1.Location = new global::System.Drawing.Point(0, 181);
			this.ReportViewer1.Name = "ReportViewer1";
			this.ReportViewer1.Size = new global::System.Drawing.Size(1310, 632);
			this.ReportViewer1.TabIndex = 2;
			this.DiscountsForPeriodTableAdapter.ClearBeforeFill = true;
			this.GetProdCreditNoteChargesTableAdapter.ClearBeforeFill = true;
			this.ShiftSalesPaymentSummaryforPeriodTableAdapter.ClearBeforeFill = true;
			this.PeriodAuditInfoTableAdapter.ClearBeforeFill = true;
			this.CreditPaymentsForPeriodBindingSource.DataMember = "CreditPaymentsForPeriod";
			this.CreditPaymentsForPeriodBindingSource.DataSource = this.POSDataSet;
			this.CreditPaymentsForPeriodTableAdapter.ClearBeforeFill = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1310, 813);
			base.Controls.Add(this.ReportViewer1);
			base.Controls.Add(this.GroupBox1);
			base.Name = "SalesByInvoice";
			this.Text = "Sales By Invoice";
			((global::System.ComponentModel.ISupportInitialize)this.SalesForPeriodInvoiceNumbersBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.POSDataSet).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetCompanyDetailsForCoidBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.DiscountsForPeriodBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetProdCreditNoteChargesBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.ShiftSalesPaymentSummaryforPeriodBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.PeriodAuditInfoBindingSource).EndInit();
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.CreditPaymentsForPeriodBindingSource).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04001F66 RID: 8038
		private global::System.ComponentModel.IContainer components;
	}
}
