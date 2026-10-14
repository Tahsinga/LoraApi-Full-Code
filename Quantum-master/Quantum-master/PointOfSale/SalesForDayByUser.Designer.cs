namespace PointOfSale
{
	// Token: 0x0200019C RID: 412
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class SalesForDayByUser : global::System.Windows.Forms.UserControl
	{
		// Token: 0x0600494B RID: 18763 RVA: 0x002C5F14 File Offset: 0x002C4114
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

		// Token: 0x0600494C RID: 18764 RVA: 0x002C5F64 File Offset: 0x002C4164
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
			this.chkHideCats = new global::System.Windows.Forms.CheckBox();
			this.chkShowAll = new global::System.Windows.Forms.CheckBox();
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
			this.UserAccSalesSummaryBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.SalesSummaryForDayBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.SalesDetailForDayBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.PaymentSummaryForDayBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.GetCompanyDetailsTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.GetCompanyDetailsTableAdapter();
			this.USERSalesDayDetailTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.USERSalesDayDetailTableAdapter();
			this.USERSalesPaymentSummaryTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.USERSalesPaymentSummaryTableAdapter();
			this.UserSalesCategorySummaryPERIODTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.UserSalesCategorySummaryPERIODTableAdapter();
			this.SalesSummaryForDayTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.SalesSummaryForDayTableAdapter();
			this.SalesDetailForDayTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.SalesDetailForDayTableAdapter();
			this.PaymentSummaryForDayTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.PaymentSummaryForDayTableAdapter();
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
			((global::System.ComponentModel.ISupportInitialize)this.UserAccSalesSummaryBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.SalesSummaryForDayBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.SalesDetailForDayBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.PaymentSummaryForDayBindingSource).BeginInit();
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
			this.GroupBox1.Controls.Add(this.chkHideCats);
			this.GroupBox1.Controls.Add(this.chkShowAll);
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
			this.GroupBox1.Size = new global::System.Drawing.Size(1490, 188);
			this.GroupBox1.TabIndex = 1;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Details";
			this.chkHideCats.AutoSize = true;
			this.chkHideCats.Location = new global::System.Drawing.Point(908, 86);
			this.chkHideCats.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.chkHideCats.Name = "chkHideCats";
			this.chkHideCats.Size = new global::System.Drawing.Size(158, 24);
			this.chkHideCats.TabIndex = 10;
			this.chkHideCats.Text = "Hide Categories?";
			this.chkHideCats.UseVisualStyleBackColor = true;
			this.chkShowAll.AutoSize = true;
			this.chkShowAll.Enabled = false;
			this.chkShowAll.Location = new global::System.Drawing.Point(556, 128);
			this.chkShowAll.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.chkShowAll.Name = "chkShowAll";
			this.chkShowAll.Size = new global::System.Drawing.Size(249, 24);
			this.chkShowAll.TabIndex = 9;
			this.chkShowAll.Text = "Show All User Sales Summary";
			this.chkShowAll.UseVisualStyleBackColor = true;
			this.Label5.AutoSize = true;
			this.Label5.Location = new global::System.Drawing.Point(481, 90);
			this.Label5.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label5.Name = "Label5";
			this.Label5.Size = new global::System.Drawing.Size(64, 20);
			this.Label5.TabIndex = 8;
			this.Label5.Text = "Branch:";
			this.cboBranch.FormattingEnabled = true;
			this.cboBranch.Location = new global::System.Drawing.Point(556, 86);
			this.cboBranch.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cboBranch.Name = "cboBranch";
			this.cboBranch.Size = new global::System.Drawing.Size(249, 28);
			this.cboBranch.TabIndex = 7;
			this.cboUsers.FormattingEnabled = true;
			this.cboUsers.Location = new global::System.Drawing.Point(105, 128);
			this.cboUsers.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cboUsers.Name = "cboUsers";
			this.cboUsers.Size = new global::System.Drawing.Size(298, 28);
			this.cboUsers.TabIndex = 6;
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
			this.Label2.AutoSize = true;
			this.Label2.BackColor = global::System.Drawing.Color.Red;
			this.Label2.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.Label2.Location = new global::System.Drawing.Point(1437, 24);
			this.Label2.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(49, 20);
			this.Label2.TabIndex = 3;
			this.Label2.Text = "Close";
			this.Button1.BackColor = global::System.Drawing.Color.Lime;
			this.Button1.Location = new global::System.Drawing.Point(908, 128);
			this.Button1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(207, 35);
			this.Button1.TabIndex = 2;
			this.Button1.Text = "RUN REPORT";
			this.Button1.UseVisualStyleBackColor = false;
			this.DTStartDate.Location = new global::System.Drawing.Point(105, 88);
			this.DTStartDate.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.DTStartDate.Name = "DTStartDate";
			this.DTStartDate.Size = new global::System.Drawing.Size(298, 26);
			this.DTStartDate.TabIndex = 1;
			this.Label1.AutoSize = true;
			this.Label1.Location = new global::System.Drawing.Point(0, 92);
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
			this.ReportViewer1.Size = new global::System.Drawing.Size(1490, 484);
			this.ReportViewer1.TabIndex = 2;
			this.UserAccSalesSummaryBindingSource.DataMember = "UserAccSalesSummary";
			this.UserAccSalesSummaryBindingSource.DataSource = this.POSDataSet;
			this.SalesSummaryForDayBindingSource.DataMember = "SalesSummaryForDay";
			this.SalesSummaryForDayBindingSource.DataSource = this.POSDataSet;
			this.SalesDetailForDayBindingSource.DataMember = "SalesDetailForDay";
			this.SalesDetailForDayBindingSource.DataSource = this.POSDataSet;
			this.PaymentSummaryForDayBindingSource.DataMember = "PaymentSummaryForDay";
			this.PaymentSummaryForDayBindingSource.DataSource = this.POSDataSet;
			this.GetCompanyDetailsTableAdapter.ClearBeforeFill = true;
			this.USERSalesDayDetailTableAdapter.ClearBeforeFill = true;
			this.USERSalesPaymentSummaryTableAdapter.ClearBeforeFill = true;
			this.UserSalesCategorySummaryPERIODTableAdapter.ClearBeforeFill = true;
			this.SalesSummaryForDayTableAdapter.ClearBeforeFill = true;
			this.SalesDetailForDayTableAdapter.ClearBeforeFill = true;
			this.PaymentSummaryForDayTableAdapter.ClearBeforeFill = true;
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
			base.Controls.Add(this.ReportViewer1);
			base.Controls.Add(this.GroupBox1);
			base.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			base.Name = "SalesForDayByUser";
			base.Size = new global::System.Drawing.Size(1490, 672);
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
			((global::System.ComponentModel.ISupportInitialize)this.UserAccSalesSummaryBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.SalesSummaryForDayBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.SalesDetailForDayBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.PaymentSummaryForDayBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.ShiftDetailBindingSource).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x0400201A RID: 8218
		private global::System.ComponentModel.IContainer components;
	}
}
