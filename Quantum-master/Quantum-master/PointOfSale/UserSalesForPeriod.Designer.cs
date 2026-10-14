namespace PointOfSale
{
	// Token: 0x02000208 RID: 520
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class UserSalesForPeriod : global::System.Windows.Forms.UserControl
	{
		// Token: 0x06005D9C RID: 23964 RVA: 0x0035B2F8 File Offset: 0x003594F8
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

		// Token: 0x06005D9D RID: 23965 RVA: 0x0035B348 File Offset: 0x00359548
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
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.chkHideCats = new global::System.Windows.Forms.CheckBox();
			this.DTEndDate = new global::System.Windows.Forms.DateTimePicker();
			this.Label6 = new global::System.Windows.Forms.Label();
			this.Label5 = new global::System.Windows.Forms.Label();
			this.cboBranch = new global::System.Windows.Forms.ComboBox();
			this.cboUsers = new global::System.Windows.Forms.ComboBox();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.DTStartDate = new global::System.Windows.Forms.DateTimePicker();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.ReportViewer1 = new global::Microsoft.Reporting.WinForms.ReportViewer();
			this.GetCompanyDetailsBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.POSDataSet = new global::PointOfSale.POSDataSet();
			this.UserSalesCategorySummaryPERIOD2BindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.USERSalesPaymentSummaryPeriodBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.USERSalesDetailPeriodBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.ShiftSalesSummaryByUserPeriodBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.BillingSalesBreakdownForUserPeriodBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.BillingPaymentSummaryUserPeriodBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.DiscountsForUserForPeriodBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.DiscountsForPeriodBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.SalesbyTaxPeriodBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.GetCompanyDetailsTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.GetCompanyDetailsTableAdapter();
			this.UserSalesCategorySummaryPERIOD2TableAdapter = new global::PointOfSale.POSDataSetTableAdapters.UserSalesCategorySummaryPERIOD2TableAdapter();
			this.USERSalesPaymentSummaryPeriodTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.USERSalesPaymentSummaryPeriodTableAdapter();
			this.USERSalesDetailPeriodTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.USERSalesDetailPeriodTableAdapter();
			this.ShiftSalesSummaryByUserPeriodTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.ShiftSalesSummaryByUserPeriodTableAdapter();
			this.BillingSalesBreakdownForUserPeriodTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.BillingSalesBreakdownForUserPeriodTableAdapter();
			this.BillingPaymentSummaryUserPeriodTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.BillingPaymentSummaryUserPeriodTableAdapter();
			this.DiscountsForUserForPeriodTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.DiscountsForUserForPeriodTableAdapter();
			this.DiscountsForPeriodTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.DiscountsForPeriodTableAdapter();
			this.SalesbyTaxPeriodTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.SalesbyTaxPeriodTableAdapter();
			this.GroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.GetCompanyDetailsBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.POSDataSet).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.UserSalesCategorySummaryPERIOD2BindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.USERSalesPaymentSummaryPeriodBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.USERSalesDetailPeriodBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.ShiftSalesSummaryByUserPeriodBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.BillingSalesBreakdownForUserPeriodBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.BillingPaymentSummaryUserPeriodBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.DiscountsForUserForPeriodBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.DiscountsForPeriodBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.SalesbyTaxPeriodBindingSource).BeginInit();
			base.SuspendLayout();
			this.GroupBox1.BackColor = global::System.Drawing.Color.FromArgb(192, 255, 255);
			this.GroupBox1.Controls.Add(this.chkHideCats);
			this.GroupBox1.Controls.Add(this.DTEndDate);
			this.GroupBox1.Controls.Add(this.Label6);
			this.GroupBox1.Controls.Add(this.Label5);
			this.GroupBox1.Controls.Add(this.cboBranch);
			this.GroupBox1.Controls.Add(this.cboUsers);
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Controls.Add(this.DTStartDate);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Padding = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GroupBox1.Size = new global::System.Drawing.Size(1498, 214);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.chkHideCats.AutoSize = true;
			this.chkHideCats.Location = new global::System.Drawing.Point(866, 108);
			this.chkHideCats.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.chkHideCats.Name = "chkHideCats";
			this.chkHideCats.Size = new global::System.Drawing.Size(158, 24);
			this.chkHideCats.TabIndex = 20;
			this.chkHideCats.Text = "Hide Categories?";
			this.chkHideCats.UseVisualStyleBackColor = true;
			this.DTEndDate.Location = new global::System.Drawing.Point(556, 108);
			this.DTEndDate.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.DTEndDate.Name = "DTEndDate";
			this.DTEndDate.Size = new global::System.Drawing.Size(298, 26);
			this.DTEndDate.TabIndex = 19;
			this.Label6.AutoSize = true;
			this.Label6.Location = new global::System.Drawing.Point(452, 112);
			this.Label6.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label6.Name = "Label6";
			this.Label6.Size = new global::System.Drawing.Size(85, 20);
			this.Label6.TabIndex = 18;
			this.Label6.Text = "Shift Date:";
			this.Label5.AutoSize = true;
			this.Label5.Location = new global::System.Drawing.Point(452, 163);
			this.Label5.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label5.Name = "Label5";
			this.Label5.Size = new global::System.Drawing.Size(64, 20);
			this.Label5.TabIndex = 17;
			this.Label5.Text = "Branch:";
			this.cboBranch.FormattingEnabled = true;
			this.cboBranch.Location = new global::System.Drawing.Point(556, 158);
			this.cboBranch.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cboBranch.Name = "cboBranch";
			this.cboBranch.Size = new global::System.Drawing.Size(298, 28);
			this.cboBranch.TabIndex = 16;
			this.cboUsers.FormattingEnabled = true;
			this.cboUsers.Location = new global::System.Drawing.Point(106, 152);
			this.cboUsers.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cboUsers.Name = "cboUsers";
			this.cboUsers.Size = new global::System.Drawing.Size(298, 28);
			this.cboUsers.TabIndex = 15;
			this.Label4.AutoSize = true;
			this.Label4.Location = new global::System.Drawing.Point(2, 157);
			this.Label4.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label4.Name = "Label4";
			this.Label4.Size = new global::System.Drawing.Size(96, 20);
			this.Label4.TabIndex = 14;
			this.Label4.Text = "Select User:";
			this.Label3.AutoSize = true;
			this.Label3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label3.Location = new global::System.Drawing.Point(9, 25);
			this.Label3.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(446, 32);
			this.Label3.TabIndex = 13;
			this.Label3.Text = "Sales Report By User for Period";
			this.Label2.AutoSize = true;
			this.Label2.BackColor = global::System.Drawing.Color.Red;
			this.Label2.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.Label2.Location = new global::System.Drawing.Point(1445, 24);
			this.Label2.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(49, 20);
			this.Label2.TabIndex = 12;
			this.Label2.Text = "Close";
			this.Button1.BackColor = global::System.Drawing.Color.Lime;
			this.Button1.Location = new global::System.Drawing.Point(866, 155);
			this.Button1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(207, 35);
			this.Button1.TabIndex = 11;
			this.Button1.Text = "RUN REPORT";
			this.Button1.UseVisualStyleBackColor = false;
			this.DTStartDate.Location = new global::System.Drawing.Point(106, 112);
			this.DTStartDate.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.DTStartDate.Name = "DTStartDate";
			this.DTStartDate.Size = new global::System.Drawing.Size(298, 26);
			this.DTStartDate.TabIndex = 10;
			this.Label1.AutoSize = true;
			this.Label1.Location = new global::System.Drawing.Point(2, 117);
			this.Label1.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(85, 20);
			this.Label1.TabIndex = 9;
			this.Label1.Text = "Shift Date:";
			this.ReportViewer1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			reportDataSource.Name = "CompanyDetails";
			reportDataSource.Value = this.GetCompanyDetailsBindingSource;
			reportDataSource2.Name = "CatSummary";
			reportDataSource2.Value = this.UserSalesCategorySummaryPERIOD2BindingSource;
			reportDataSource3.Name = "PaySummary";
			reportDataSource3.Value = this.USERSalesPaymentSummaryPeriodBindingSource;
			reportDataSource4.Name = "SalesDetail";
			reportDataSource4.Value = this.USERSalesDetailPeriodBindingSource;
			reportDataSource5.Name = "OveralSales";
			reportDataSource5.Value = this.ShiftSalesSummaryByUserPeriodBindingSource;
			reportDataSource6.Name = "SalesBreakdown";
			reportDataSource6.Value = this.BillingSalesBreakdownForUserPeriodBindingSource;
			reportDataSource7.Name = "AccPayments";
			reportDataSource7.Value = this.BillingPaymentSummaryUserPeriodBindingSource;
			reportDataSource8.Name = "DiscountsForUserForPeriod";
			reportDataSource8.Value = this.DiscountsForUserForPeriodBindingSource;
			reportDataSource9.Name = "DiscountsForPeriod";
			reportDataSource9.Value = this.DiscountsForPeriodBindingSource;
			reportDataSource10.Name = "SalesbyTax";
			reportDataSource10.Value = this.SalesbyTaxPeriodBindingSource;
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
			this.ReportViewer1.LocalReport.ReportEmbeddedResource = "PointOfSale.SalesForPeriodByUser.rdlc";
			this.ReportViewer1.Location = new global::System.Drawing.Point(0, 214);
			this.ReportViewer1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ReportViewer1.Name = "ReportViewer1";
			this.ReportViewer1.Size = new global::System.Drawing.Size(1498, 457);
			this.ReportViewer1.TabIndex = 3;
			this.GetCompanyDetailsBindingSource.DataMember = "GetCompanyDetails";
			this.GetCompanyDetailsBindingSource.DataSource = this.POSDataSet;
			this.POSDataSet.DataSetName = "POSDataSet";
			this.POSDataSet.SchemaSerializationMode = global::System.Data.SchemaSerializationMode.IncludeSchema;
			this.UserSalesCategorySummaryPERIOD2BindingSource.DataMember = "UserSalesCategorySummaryPERIOD2";
			this.UserSalesCategorySummaryPERIOD2BindingSource.DataSource = this.POSDataSet;
			this.USERSalesPaymentSummaryPeriodBindingSource.DataMember = "USERSalesPaymentSummaryPeriod";
			this.USERSalesPaymentSummaryPeriodBindingSource.DataSource = this.POSDataSet;
			this.USERSalesDetailPeriodBindingSource.DataMember = "USERSalesDetailPeriod";
			this.USERSalesDetailPeriodBindingSource.DataSource = this.POSDataSet;
			this.ShiftSalesSummaryByUserPeriodBindingSource.DataMember = "ShiftSalesSummaryByUserPeriod";
			this.ShiftSalesSummaryByUserPeriodBindingSource.DataSource = this.POSDataSet;
			this.BillingSalesBreakdownForUserPeriodBindingSource.DataMember = "BillingSalesBreakdownForUserPeriod";
			this.BillingSalesBreakdownForUserPeriodBindingSource.DataSource = this.POSDataSet;
			this.BillingPaymentSummaryUserPeriodBindingSource.DataMember = "BillingPaymentSummaryUserPeriod";
			this.BillingPaymentSummaryUserPeriodBindingSource.DataSource = this.POSDataSet;
			this.DiscountsForUserForPeriodBindingSource.DataMember = "DiscountsForUserForPeriod";
			this.DiscountsForUserForPeriodBindingSource.DataSource = this.POSDataSet;
			this.DiscountsForPeriodBindingSource.DataMember = "DiscountsForPeriod";
			this.DiscountsForPeriodBindingSource.DataSource = this.POSDataSet;
			this.SalesbyTaxPeriodBindingSource.DataMember = "SalesbyTaxPeriod";
			this.SalesbyTaxPeriodBindingSource.DataSource = this.POSDataSet;
			this.GetCompanyDetailsTableAdapter.ClearBeforeFill = true;
			this.UserSalesCategorySummaryPERIOD2TableAdapter.ClearBeforeFill = true;
			this.USERSalesPaymentSummaryPeriodTableAdapter.ClearBeforeFill = true;
			this.USERSalesDetailPeriodTableAdapter.ClearBeforeFill = true;
			this.ShiftSalesSummaryByUserPeriodTableAdapter.ClearBeforeFill = true;
			this.BillingSalesBreakdownForUserPeriodTableAdapter.ClearBeforeFill = true;
			this.BillingPaymentSummaryUserPeriodTableAdapter.ClearBeforeFill = true;
			this.DiscountsForUserForPeriodTableAdapter.ClearBeforeFill = true;
			this.DiscountsForPeriodTableAdapter.ClearBeforeFill = true;
			this.SalesbyTaxPeriodTableAdapter.ClearBeforeFill = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.Controls.Add(this.ReportViewer1);
			base.Controls.Add(this.GroupBox1);
			base.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			base.Name = "UserSalesForPeriod";
			base.Size = new global::System.Drawing.Size(1498, 671);
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.GetCompanyDetailsBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.POSDataSet).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.UserSalesCategorySummaryPERIOD2BindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.USERSalesPaymentSummaryPeriodBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.USERSalesDetailPeriodBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.ShiftSalesSummaryByUserPeriodBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.BillingSalesBreakdownForUserPeriodBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.BillingPaymentSummaryUserPeriodBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.DiscountsForUserForPeriodBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.DiscountsForPeriodBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.SalesbyTaxPeriodBindingSource).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x040028EF RID: 10479
		private global::System.ComponentModel.IContainer components;
	}
}
