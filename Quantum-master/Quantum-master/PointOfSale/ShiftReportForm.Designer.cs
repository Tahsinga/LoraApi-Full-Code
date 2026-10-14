namespace PointOfSale
{
	// Token: 0x020001DF RID: 479
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class ShiftReportForm : global::System.Windows.Forms.Form
	{
		// Token: 0x06005402 RID: 21506 RVA: 0x0030B794 File Offset: 0x00309994
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

		// Token: 0x06005403 RID: 21507 RVA: 0x0030B7E4 File Offset: 0x003099E4
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
			this.GetCompanyDetailsBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.POSDataSet = new global::PointOfSale.POSDataSet();
			this.USERSalesDayDetailBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.USERSalesPaymentSummaryBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.UserSalesCategorySummaryPERIODBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.ShiftSalesSummaryByUserBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.BillingSalesBreakdownForUserBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.BillingPaymentSummaryUserBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.DiscountsForUserForDayBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.DiscountsForDayBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.lbluser = new global::System.Windows.Forms.Label();
			this.lblbranch = new global::System.Windows.Forms.Label();
			this.Label5 = new global::System.Windows.Forms.Label();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.DTStartDate = new global::System.Windows.Forms.DateTimePicker();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.ReportViewer1 = new global::Microsoft.Reporting.WinForms.ReportViewer();
			this.GetCompanyDetailsTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.GetCompanyDetailsTableAdapter();
			this.USERSalesDayDetailTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.USERSalesDayDetailTableAdapter();
			this.USERSalesPaymentSummaryTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.USERSalesPaymentSummaryTableAdapter();
			this.UserSalesCategorySummaryPERIODTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.UserSalesCategorySummaryPERIODTableAdapter();
			this.ShiftSalesSummaryByUserTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.ShiftSalesSummaryByUserTableAdapter();
			this.BillingSalesBreakdownForUserTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.BillingSalesBreakdownForUserTableAdapter();
			this.BillingPaymentSummaryUserTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.BillingPaymentSummaryUserTableAdapter();
			this.DiscountsForUserForDayTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.DiscountsForUserForDayTableAdapter();
			this.DiscountsForDayTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.DiscountsForDayTableAdapter();
			this.ShiftDetailBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.ShiftDetailTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.ShiftDetailTableAdapter();
			((global::System.ComponentModel.ISupportInitialize)this.GetCompanyDetailsBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.POSDataSet).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.USERSalesDayDetailBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.USERSalesPaymentSummaryBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.UserSalesCategorySummaryPERIODBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.ShiftSalesSummaryByUserBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.BillingSalesBreakdownForUserBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.BillingPaymentSummaryUserBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.DiscountsForUserForDayBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.DiscountsForDayBindingSource).BeginInit();
			this.GroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.ShiftDetailBindingSource).BeginInit();
			base.SuspendLayout();
			this.GetCompanyDetailsBindingSource.DataMember = "GetCompanyDetails";
			this.GetCompanyDetailsBindingSource.DataSource = this.POSDataSet;
			this.POSDataSet.DataSetName = "POSDataSet";
			this.POSDataSet.SchemaSerializationMode = global::System.Data.SchemaSerializationMode.IncludeSchema;
			this.USERSalesDayDetailBindingSource.DataMember = "USERSalesDayDetail";
			this.USERSalesDayDetailBindingSource.DataSource = this.POSDataSet;
			this.USERSalesPaymentSummaryBindingSource.DataMember = "USERSalesPaymentSummary";
			this.USERSalesPaymentSummaryBindingSource.DataSource = this.POSDataSet;
			this.UserSalesCategorySummaryPERIODBindingSource.DataMember = "UserSalesCategorySummaryPERIOD";
			this.UserSalesCategorySummaryPERIODBindingSource.DataSource = this.POSDataSet;
			this.ShiftSalesSummaryByUserBindingSource.DataMember = "ShiftSalesSummaryByUser";
			this.ShiftSalesSummaryByUserBindingSource.DataSource = this.POSDataSet;
			this.BillingSalesBreakdownForUserBindingSource.DataMember = "BillingSalesBreakdownForUser";
			this.BillingSalesBreakdownForUserBindingSource.DataSource = this.POSDataSet;
			this.BillingPaymentSummaryUserBindingSource.DataMember = "BillingPaymentSummaryUser";
			this.BillingPaymentSummaryUserBindingSource.DataSource = this.POSDataSet;
			this.DiscountsForUserForDayBindingSource.DataMember = "DiscountsForUserForDay";
			this.DiscountsForUserForDayBindingSource.DataSource = this.POSDataSet;
			this.DiscountsForDayBindingSource.DataMember = "DiscountsForDay";
			this.DiscountsForDayBindingSource.DataSource = this.POSDataSet;
			this.GroupBox1.Controls.Add(this.lbluser);
			this.GroupBox1.Controls.Add(this.lblbranch);
			this.GroupBox1.Controls.Add(this.Label5);
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Controls.Add(this.DTStartDate);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Padding = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GroupBox1.Size = new global::System.Drawing.Size(1444, 188);
			this.GroupBox1.TabIndex = 2;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Details";
			this.lbluser.AutoSize = true;
			this.lbluser.Location = new global::System.Drawing.Point(106, 140);
			this.lbluser.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbluser.Name = "lbluser";
			this.lbluser.Size = new global::System.Drawing.Size(21, 20);
			this.lbluser.TabIndex = 10;
			this.lbluser.Text = "...";
			this.lblbranch.AutoSize = true;
			this.lblbranch.Location = new global::System.Drawing.Point(525, 140);
			this.lblbranch.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblbranch.Name = "lblbranch";
			this.lblbranch.Size = new global::System.Drawing.Size(21, 20);
			this.lblbranch.TabIndex = 9;
			this.lblbranch.Text = "...";
			this.Label5.AutoSize = true;
			this.Label5.Location = new global::System.Drawing.Point(450, 138);
			this.Label5.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label5.Name = "Label5";
			this.Label5.Size = new global::System.Drawing.Size(64, 20);
			this.Label5.TabIndex = 8;
			this.Label5.Text = "Branch:";
			this.Label4.AutoSize = true;
			this.Label4.Location = new global::System.Drawing.Point(0, 132);
			this.Label4.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label4.Name = "Label4";
			this.Label4.Size = new global::System.Drawing.Size(96, 20);
			this.Label4.TabIndex = 5;
			this.Label4.Text = "Select User:";
			this.Label3.AutoSize = true;
			this.Label3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label3.Location = new global::System.Drawing.Point(532, 25);
			this.Label3.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(356, 32);
			this.Label3.TabIndex = 4;
			this.Label3.Text = "Daily Sales Report By User";
			this.Button1.Location = new global::System.Drawing.Point(414, 83);
			this.Button1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(207, 35);
			this.Button1.TabIndex = 2;
			this.Button1.Text = "RUN REPORT";
			this.Button1.UseVisualStyleBackColor = true;
			this.DTStartDate.Location = new global::System.Drawing.Point(105, 88);
			this.DTStartDate.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.DTStartDate.Name = "DTStartDate";
			this.DTStartDate.Size = new global::System.Drawing.Size(298, 26);
			this.DTStartDate.TabIndex = 1;
			this.Label1.AutoSize = true;
			this.Label1.Location = new global::System.Drawing.Point(9, 91);
			this.Label1.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(85, 20);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Shift Date:";
			this.ReportViewer1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			reportDataSource.Name = "CompanyDetails";
			reportDataSource.Value = this.GetCompanyDetailsBindingSource;
			reportDataSource2.Name = "SalesDetail";
			reportDataSource2.Value = this.USERSalesDayDetailBindingSource;
			reportDataSource3.Name = "PaymentSummary";
			reportDataSource3.Value = this.USERSalesPaymentSummaryBindingSource;
			reportDataSource4.Name = "SalesSummary";
			reportDataSource4.Value = this.UserSalesCategorySummaryPERIODBindingSource;
			reportDataSource5.Name = "OveralSalesSummaryByUser";
			reportDataSource5.Value = this.ShiftSalesSummaryByUserBindingSource;
			reportDataSource6.Name = "SalesBreakdown";
			reportDataSource6.Value = this.BillingSalesBreakdownForUserBindingSource;
			reportDataSource7.Name = "AccPaymentSummary";
			reportDataSource7.Value = this.BillingPaymentSummaryUserBindingSource;
			reportDataSource8.Name = "InvDiscounts";
			reportDataSource8.Value = this.DiscountsForUserForDayBindingSource;
			reportDataSource9.Name = "DiscountsGivenByAll";
			reportDataSource9.Value = this.DiscountsForDayBindingSource;
			reportDataSource10.Name = "Shift";
			reportDataSource10.Value = this.ShiftDetailBindingSource;
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
			this.ReportViewer1.LocalReport.ReportEmbeddedResource = "PointOfSale.SalesForDayByUser.rdlc";
			this.ReportViewer1.Location = new global::System.Drawing.Point(0, 188);
			this.ReportViewer1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ReportViewer1.Name = "ReportViewer1";
			this.ReportViewer1.Size = new global::System.Drawing.Size(1444, 740);
			this.ReportViewer1.TabIndex = 3;
			this.GetCompanyDetailsTableAdapter.ClearBeforeFill = true;
			this.USERSalesDayDetailTableAdapter.ClearBeforeFill = true;
			this.USERSalesPaymentSummaryTableAdapter.ClearBeforeFill = true;
			this.UserSalesCategorySummaryPERIODTableAdapter.ClearBeforeFill = true;
			this.ShiftSalesSummaryByUserTableAdapter.ClearBeforeFill = true;
			this.BillingSalesBreakdownForUserTableAdapter.ClearBeforeFill = true;
			this.BillingPaymentSummaryUserTableAdapter.ClearBeforeFill = true;
			this.DiscountsForUserForDayTableAdapter.ClearBeforeFill = true;
			this.DiscountsForDayTableAdapter.ClearBeforeFill = true;
			this.ShiftDetailBindingSource.DataMember = "ShiftDetail";
			this.ShiftDetailBindingSource.DataSource = this.POSDataSet;
			this.ShiftDetailTableAdapter.ClearBeforeFill = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1444, 928);
			base.Controls.Add(this.ReportViewer1);
			base.Controls.Add(this.GroupBox1);
			base.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			base.Name = "ShiftReportForm";
			this.Text = "Shift Report";
			((global::System.ComponentModel.ISupportInitialize)this.GetCompanyDetailsBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.POSDataSet).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.USERSalesDayDetailBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.USERSalesPaymentSummaryBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.UserSalesCategorySummaryPERIODBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.ShiftSalesSummaryByUserBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.BillingSalesBreakdownForUserBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.BillingPaymentSummaryUserBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.DiscountsForUserForDayBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.DiscountsForDayBindingSource).EndInit();
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.ShiftDetailBindingSource).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x040024A4 RID: 9380
		private global::System.ComponentModel.IContainer components;
	}
}
