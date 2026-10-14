namespace PointOfSale
{
	// Token: 0x0200019A RID: 410
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class SalesForCustomer : global::System.Windows.Forms.UserControl
	{
		// Token: 0x060048EC RID: 18668 RVA: 0x002C3DB0 File Offset: 0x002C1FB0
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

		// Token: 0x060048ED RID: 18669 RVA: 0x002C3E00 File Offset: 0x002C2000
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.Label6 = new global::System.Windows.Forms.Label();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.cboCustomers = new global::System.Windows.Forms.ComboBox();
			this.Label5 = new global::System.Windows.Forms.Label();
			this.cboBranch = new global::System.Windows.Forms.ComboBox();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.DTEnddate = new global::System.Windows.Forms.DateTimePicker();
			this.DTStartdate = new global::System.Windows.Forms.DateTimePicker();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.ReportViewer1 = new global::Microsoft.Reporting.WinForms.ReportViewer();
			this.GetCompanyDetailsBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.POSDataSet = new global::PointOfSale.POSDataSet();
			this.CustomerSalesForPeriodBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.CustomerSalesPaymentSummaryPeriodBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.GetCompanyDetailsTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.GetCompanyDetailsTableAdapter();
			this.CustomerSalesForPeriodTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.CustomerSalesForPeriodTableAdapter();
			this.CustomerSalesPaymentSummaryPeriodTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.CustomerSalesPaymentSummaryPeriodTableAdapter();
			this.FetchCustomerDetailsEntrynoBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.FetchCustomerDetailsEntrynoTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.FetchCustomerDetailsEntrynoTableAdapter();
			this.GroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.GetCompanyDetailsBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.POSDataSet).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.CustomerSalesForPeriodBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.CustomerSalesPaymentSummaryPeriodBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.FetchCustomerDetailsEntrynoBindingSource).BeginInit();
			base.SuspendLayout();
			this.GroupBox1.Controls.Add(this.Label6);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.cboCustomers);
			this.GroupBox1.Controls.Add(this.Label5);
			this.GroupBox1.Controls.Add(this.cboBranch);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Controls.Add(this.DTEnddate);
			this.GroupBox1.Controls.Add(this.DTStartdate);
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Padding = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GroupBox1.Size = new global::System.Drawing.Size(1492, 266);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.Label6.AutoSize = true;
			this.Label6.BackColor = global::System.Drawing.Color.Red;
			this.Label6.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.Label6.Location = new global::System.Drawing.Point(1439, 24);
			this.Label6.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label6.Name = "Label6";
			this.Label6.Size = new global::System.Drawing.Size(49, 20);
			this.Label6.TabIndex = 29;
			this.Label6.Text = "Close";
			this.Label3.AutoSize = true;
			this.Label3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label3.Location = new global::System.Drawing.Point(544, 25);
			this.Label3.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(256, 32);
			this.Label3.TabIndex = 28;
			this.Label3.Text = "Sales for Customer";
			this.Button1.BackColor = global::System.Drawing.Color.Lime;
			this.Button1.Location = new global::System.Drawing.Point(498, 186);
			this.Button1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(154, 35);
			this.Button1.TabIndex = 27;
			this.Button1.Text = "RUN REPORT";
			this.Button1.UseVisualStyleBackColor = false;
			this.Label2.AutoSize = true;
			this.Label2.Location = new global::System.Drawing.Point(99, 191);
			this.Label2.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(82, 20);
			this.Label2.TabIndex = 26;
			this.Label2.Text = "Customer:";
			this.cboCustomers.FormattingEnabled = true;
			this.cboCustomers.Location = new global::System.Drawing.Point(189, 186);
			this.cboCustomers.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cboCustomers.Name = "cboCustomers";
			this.cboCustomers.Size = new global::System.Drawing.Size(298, 28);
			this.cboCustomers.TabIndex = 25;
			this.Label5.AutoSize = true;
			this.Label5.Location = new global::System.Drawing.Point(118, 149);
			this.Label5.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label5.Name = "Label5";
			this.Label5.Size = new global::System.Drawing.Size(60, 20);
			this.Label5.TabIndex = 24;
			this.Label5.Text = "Branch";
			this.cboBranch.FormattingEnabled = true;
			this.cboBranch.Location = new global::System.Drawing.Point(189, 145);
			this.cboBranch.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cboBranch.Name = "cboBranch";
			this.cboBranch.Size = new global::System.Drawing.Size(298, 28);
			this.cboBranch.TabIndex = 23;
			this.Label1.AutoSize = true;
			this.Label1.Location = new global::System.Drawing.Point(98, 109);
			this.Label1.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(81, 20);
			this.Label1.TabIndex = 22;
			this.Label1.Text = "End Date:";
			this.DTEnddate.Location = new global::System.Drawing.Point(189, 105);
			this.DTEnddate.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.DTEnddate.Name = "DTEnddate";
			this.DTEnddate.Size = new global::System.Drawing.Size(298, 26);
			this.DTEnddate.TabIndex = 21;
			this.DTStartdate.Location = new global::System.Drawing.Point(189, 69);
			this.DTStartdate.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.DTStartdate.Name = "DTStartdate";
			this.DTStartdate.Size = new global::System.Drawing.Size(298, 26);
			this.DTStartdate.TabIndex = 20;
			this.Label4.AutoSize = true;
			this.Label4.Location = new global::System.Drawing.Point(93, 74);
			this.Label4.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label4.Name = "Label4";
			this.Label4.Size = new global::System.Drawing.Size(87, 20);
			this.Label4.TabIndex = 19;
			this.Label4.Text = "Start Date:";
			this.ReportViewer1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			reportDataSource.Name = "CompanyDetails";
			reportDataSource.Value = this.GetCompanyDetailsBindingSource;
			reportDataSource2.Name = "Sales";
			reportDataSource2.Value = this.CustomerSalesForPeriodBindingSource;
			reportDataSource3.Name = "CustomerDetails";
			reportDataSource3.Value = this.FetchCustomerDetailsEntrynoBindingSource;
			reportDataSource4.Name = "PaymentSummary";
			reportDataSource4.Value = this.CustomerSalesPaymentSummaryPeriodBindingSource;
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource2);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource3);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource4);
			this.ReportViewer1.LocalReport.ReportEmbeddedResource = "PointOfSale.SalesForCustomer.rdlc";
			this.ReportViewer1.Location = new global::System.Drawing.Point(0, 266);
			this.ReportViewer1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ReportViewer1.Name = "ReportViewer1";
			this.ReportViewer1.Size = new global::System.Drawing.Size(1492, 346);
			this.ReportViewer1.TabIndex = 5;
			this.GetCompanyDetailsBindingSource.DataMember = "GetCompanyDetails";
			this.GetCompanyDetailsBindingSource.DataSource = this.POSDataSet;
			this.POSDataSet.DataSetName = "POSDataSet";
			this.POSDataSet.SchemaSerializationMode = global::System.Data.SchemaSerializationMode.IncludeSchema;
			this.CustomerSalesForPeriodBindingSource.DataMember = "CustomerSalesForPeriod";
			this.CustomerSalesForPeriodBindingSource.DataSource = this.POSDataSet;
			this.CustomerSalesPaymentSummaryPeriodBindingSource.DataMember = "CustomerSalesPaymentSummaryPeriod";
			this.CustomerSalesPaymentSummaryPeriodBindingSource.DataSource = this.POSDataSet;
			this.GetCompanyDetailsTableAdapter.ClearBeforeFill = true;
			this.CustomerSalesForPeriodTableAdapter.ClearBeforeFill = true;
			this.CustomerSalesPaymentSummaryPeriodTableAdapter.ClearBeforeFill = true;
			this.FetchCustomerDetailsEntrynoBindingSource.DataMember = "FetchCustomerDetailsEntryno";
			this.FetchCustomerDetailsEntrynoBindingSource.DataSource = this.POSDataSet;
			this.FetchCustomerDetailsEntrynoTableAdapter.ClearBeforeFill = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.Controls.Add(this.ReportViewer1);
			base.Controls.Add(this.GroupBox1);
			base.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			base.Name = "SalesForCustomer";
			base.Size = new global::System.Drawing.Size(1492, 612);
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.GetCompanyDetailsBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.POSDataSet).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.CustomerSalesForPeriodBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.CustomerSalesPaymentSummaryPeriodBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.FetchCustomerDetailsEntrynoBindingSource).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04001FEE RID: 8174
		private global::System.ComponentModel.IContainer components;
	}
}
