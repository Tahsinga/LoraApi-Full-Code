namespace PointOfSale
{
	// Token: 0x02000196 RID: 406
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class SalesByInvoice2 : global::System.Windows.Forms.UserControl
	{
		// Token: 0x0600480B RID: 18443 RVA: 0x002BE8E8 File Offset: 0x002BCAE8
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

		// Token: 0x0600480C RID: 18444 RVA: 0x002BE938 File Offset: 0x002BCB38
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
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.chkReduce = new global::System.Windows.Forms.CheckBox();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.cboBranch = new global::System.Windows.Forms.ComboBox();
			this.Label6 = new global::System.Windows.Forms.Label();
			this.DTEnddate = new global::System.Windows.Forms.DateTimePicker();
			this.Label5 = new global::System.Windows.Forms.Label();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.DTStartdate = new global::System.Windows.Forms.DateTimePicker();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.ReportViewer1 = new global::Microsoft.Reporting.WinForms.ReportViewer();
			this.chkByTime = new global::System.Windows.Forms.CheckBox();
			this.DTTimeStart = new global::System.Windows.Forms.DateTimePicker();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.Label7 = new global::System.Windows.Forms.Label();
			this.DTTimeEnd = new global::System.Windows.Forms.DateTimePicker();
			this.ShiftSalesPaymentSummaryforPeriodBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.POSDataSet = new global::PointOfSale.POSDataSet();
			this.ShiftSalesForPERIODBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.ShiftSalesSummaryByUserPeriodBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.GetCompanyDetailsBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.BillingSalesBreakdownForPeriodBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.BillingPaymentSummaryPeriodBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.ShiftSalesPaymentSummaryforPeriodTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.ShiftSalesPaymentSummaryforPeriodTableAdapter();
			this.ShiftSalesForPERIODTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.ShiftSalesForPERIODTableAdapter();
			this.ShiftSalesSummaryByUserPeriodTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.ShiftSalesSummaryByUserPeriodTableAdapter();
			this.GetCompanyDetailsTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.GetCompanyDetailsTableAdapter();
			this.BillingSalesBreakdownForPeriodTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.BillingSalesBreakdownForPeriodTableAdapter();
			this.BillingPaymentSummaryPeriodTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.BillingPaymentSummaryPeriodTableAdapter();
			this.GroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.ShiftSalesPaymentSummaryforPeriodBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.POSDataSet).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.ShiftSalesForPERIODBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.ShiftSalesSummaryByUserPeriodBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetCompanyDetailsBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.BillingSalesBreakdownForPeriodBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.BillingPaymentSummaryPeriodBindingSource).BeginInit();
			base.SuspendLayout();
			this.GroupBox1.Controls.Add(this.Label7);
			this.GroupBox1.Controls.Add(this.DTTimeEnd);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.DTTimeStart);
			this.GroupBox1.Controls.Add(this.chkByTime);
			this.GroupBox1.Controls.Add(this.chkReduce);
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Controls.Add(this.cboBranch);
			this.GroupBox1.Controls.Add(this.Label6);
			this.GroupBox1.Controls.Add(this.DTEnddate);
			this.GroupBox1.Controls.Add(this.Label5);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Controls.Add(this.DTStartdate);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new global::System.Drawing.Size(1338, 244);
			this.GroupBox1.TabIndex = 2;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Set Parameters";
			this.chkReduce.AutoSize = true;
			this.chkReduce.Location = new global::System.Drawing.Point(789, 192);
			this.chkReduce.Name = "chkReduce";
			this.chkReduce.Size = new global::System.Drawing.Size(235, 24);
			this.chkReduce.TabIndex = 25;
			this.chkReduce.Text = "Reduce Cost by Tax amount";
			this.chkReduce.UseVisualStyleBackColor = true;
			this.chkReduce.Visible = false;
			this.Label4.AutoSize = true;
			this.Label4.Location = new global::System.Drawing.Point(960, 89);
			this.Label4.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label4.Name = "Label4";
			this.Label4.Size = new global::System.Drawing.Size(60, 20);
			this.Label4.TabIndex = 24;
			this.Label4.Text = "Branch";
			this.cboBranch.FormattingEnabled = true;
			this.cboBranch.Location = new global::System.Drawing.Point(1030, 85);
			this.cboBranch.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cboBranch.Name = "cboBranch";
			this.cboBranch.Size = new global::System.Drawing.Size(256, 28);
			this.cboBranch.TabIndex = 23;
			this.Label6.AutoSize = true;
			this.Label6.BackColor = global::System.Drawing.Color.Red;
			this.Label6.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.Label6.Location = new global::System.Drawing.Point(1286, 22);
			this.Label6.Name = "Label6";
			this.Label6.Size = new global::System.Drawing.Size(49, 20);
			this.Label6.TabIndex = 22;
			this.Label6.Text = "Close";
			this.DTEnddate.Location = new global::System.Drawing.Point(623, 87);
			this.DTEnddate.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.DTEnddate.Name = "DTEnddate";
			this.DTEnddate.Size = new global::System.Drawing.Size(298, 26);
			this.DTEnddate.TabIndex = 18;
			this.Label5.AutoSize = true;
			this.Label5.Location = new global::System.Drawing.Point(531, 91);
			this.Label5.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label5.Name = "Label5";
			this.Label5.Size = new global::System.Drawing.Size(81, 20);
			this.Label5.TabIndex = 17;
			this.Label5.Text = "End Date:";
			this.Label3.AutoSize = true;
			this.Label3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label3.Location = new global::System.Drawing.Point(29, 27);
			this.Label3.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(702, 32);
			this.Label3.TabIndex = 14;
			this.Label3.Text = "Sales Report by Invoice for Period for Branch - Lite";
			this.Button1.BackColor = global::System.Drawing.Color.Lime;
			this.Button1.Location = new global::System.Drawing.Point(579, 189);
			this.Button1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(203, 35);
			this.Button1.TabIndex = 13;
			this.Button1.Text = "RUN REPORT";
			this.Button1.UseVisualStyleBackColor = false;
			this.DTStartdate.Location = new global::System.Drawing.Point(167, 87);
			this.DTStartdate.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.DTStartdate.Name = "DTStartdate";
			this.DTStartdate.Size = new global::System.Drawing.Size(298, 26);
			this.DTStartdate.TabIndex = 12;
			this.Label1.AutoSize = true;
			this.Label1.Location = new global::System.Drawing.Point(23, 91);
			this.Label1.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(136, 20);
			this.Label1.TabIndex = 11;
			this.Label1.Text = "Select Start Date:";
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
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource2);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource3);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource4);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource5);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource6);
			this.ReportViewer1.LocalReport.ReportEmbeddedResource = "PointOfSale.ShiftSalesForPeriod2.rdlc";
			this.ReportViewer1.Location = new global::System.Drawing.Point(0, 244);
			this.ReportViewer1.Name = "ReportViewer1";
			this.ReportViewer1.Size = new global::System.Drawing.Size(1338, 626);
			this.ReportViewer1.TabIndex = 3;
			this.chkByTime.AutoSize = true;
			this.chkByTime.Location = new global::System.Drawing.Point(24, 123);
			this.chkByTime.Name = "chkByTime";
			this.chkByTime.Size = new global::System.Drawing.Size(137, 24);
			this.chkByTime.TabIndex = 26;
			this.chkByTime.Text = "Filter by Time?";
			this.chkByTime.UseVisualStyleBackColor = true;
			this.DTTimeStart.Location = new global::System.Drawing.Point(265, 122);
			this.DTTimeStart.Name = "DTTimeStart";
			this.DTTimeStart.Size = new global::System.Drawing.Size(200, 26);
			this.DTTimeStart.TabIndex = 27;
			this.DTTimeStart.Visible = false;
			this.Label2.AutoSize = true;
			this.Label2.Location = new global::System.Drawing.Point(173, 125);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(86, 20);
			this.Label2.TabIndex = 28;
			this.Label2.Text = "Start Time:";
			this.Label2.Visible = false;
			this.Label7.AutoSize = true;
			this.Label7.Location = new global::System.Drawing.Point(531, 124);
			this.Label7.Name = "Label7";
			this.Label7.Size = new global::System.Drawing.Size(86, 20);
			this.Label7.TabIndex = 30;
			this.Label7.Text = "Start Time:";
			this.Label7.Visible = false;
			this.DTTimeEnd.Location = new global::System.Drawing.Point(623, 121);
			this.DTTimeEnd.Name = "DTTimeEnd";
			this.DTTimeEnd.Size = new global::System.Drawing.Size(200, 26);
			this.DTTimeEnd.TabIndex = 29;
			this.DTTimeEnd.Visible = false;
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
			this.ShiftSalesPaymentSummaryforPeriodTableAdapter.ClearBeforeFill = true;
			this.ShiftSalesForPERIODTableAdapter.ClearBeforeFill = true;
			this.ShiftSalesSummaryByUserPeriodTableAdapter.ClearBeforeFill = true;
			this.GetCompanyDetailsTableAdapter.ClearBeforeFill = true;
			this.BillingSalesBreakdownForPeriodTableAdapter.ClearBeforeFill = true;
			this.BillingPaymentSummaryPeriodTableAdapter.ClearBeforeFill = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.Controls.Add(this.ReportViewer1);
			base.Controls.Add(this.GroupBox1);
			base.Name = "SalesByInvoice2";
			base.Size = new global::System.Drawing.Size(1338, 870);
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.ShiftSalesPaymentSummaryforPeriodBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.POSDataSet).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.ShiftSalesForPERIODBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.ShiftSalesSummaryByUserPeriodBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetCompanyDetailsBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.BillingSalesBreakdownForPeriodBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.BillingPaymentSummaryPeriodBindingSource).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04001F85 RID: 8069
		private global::System.ComponentModel.IContainer components;
	}
}
