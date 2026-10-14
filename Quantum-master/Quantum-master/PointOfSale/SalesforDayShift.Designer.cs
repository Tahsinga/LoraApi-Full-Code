namespace PointOfSale
{
	// Token: 0x0200019D RID: 413
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class SalesforDayShift : global::System.Windows.Forms.UserControl
	{
		// Token: 0x060049A7 RID: 18855 RVA: 0x002C7C38 File Offset: 0x002C5E38
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

		// Token: 0x060049A8 RID: 18856 RVA: 0x002C7C88 File Offset: 0x002C5E88
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			this.GetCompanyDetailsBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.POSDataSet = new global::PointOfSale.POSDataSet();
			this.ShiftSalesCategorySummaryBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.ShiftSalesPaymentSummaryBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.ShiftSalesDayDetailBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.ShiftSalesNightDetailBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.cboBranch = new global::System.Windows.Forms.Label();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.DTdate = new global::System.Windows.Forms.DateTimePicker();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.ReportViewer1 = new global::Microsoft.Reporting.WinForms.ReportViewer();
			this.GetCompanyDetailsTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.GetCompanyDetailsTableAdapter();
			this.ShiftSalesCategorySummaryTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.ShiftSalesCategorySummaryTableAdapter();
			this.ShiftSalesPaymentSummaryTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.ShiftSalesPaymentSummaryTableAdapter();
			this.ShiftSalesDayDetailTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.ShiftSalesDayDetailTableAdapter();
			this.ShiftSalesNightDetailTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.ShiftSalesNightDetailTableAdapter();
			((global::System.ComponentModel.ISupportInitialize)this.GetCompanyDetailsBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.POSDataSet).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.ShiftSalesCategorySummaryBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.ShiftSalesPaymentSummaryBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.ShiftSalesDayDetailBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.ShiftSalesNightDetailBindingSource).BeginInit();
			this.GroupBox1.SuspendLayout();
			base.SuspendLayout();
			this.GetCompanyDetailsBindingSource.DataMember = "GetCompanyDetails";
			this.GetCompanyDetailsBindingSource.DataSource = this.POSDataSet;
			this.POSDataSet.DataSetName = "POSDataSet";
			this.POSDataSet.SchemaSerializationMode = global::System.Data.SchemaSerializationMode.IncludeSchema;
			this.ShiftSalesCategorySummaryBindingSource.DataMember = "ShiftSalesCategorySummary";
			this.ShiftSalesCategorySummaryBindingSource.DataSource = this.POSDataSet;
			this.ShiftSalesPaymentSummaryBindingSource.DataMember = "ShiftSalesPaymentSummary";
			this.ShiftSalesPaymentSummaryBindingSource.DataSource = this.POSDataSet;
			this.ShiftSalesDayDetailBindingSource.DataMember = "ShiftSalesDayDetail";
			this.ShiftSalesDayDetailBindingSource.DataSource = this.POSDataSet;
			this.ShiftSalesNightDetailBindingSource.DataMember = "ShiftSalesNightDetail";
			this.ShiftSalesNightDetailBindingSource.DataSource = this.POSDataSet;
			this.GroupBox1.Controls.Add(this.cboBranch);
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Controls.Add(this.DTdate);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new global::System.Drawing.Size(982, 90);
			this.GroupBox1.TabIndex = 1;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Details";
			this.cboBranch.AutoSize = true;
			this.cboBranch.Location = new global::System.Drawing.Point(444, 60);
			this.cboBranch.Name = "cboBranch";
			this.cboBranch.Size = new global::System.Drawing.Size(16, 13);
			this.cboBranch.TabIndex = 7;
			this.cboBranch.Text = "...";
			this.Label4.AutoSize = true;
			this.Label4.Location = new global::System.Drawing.Point(397, 62);
			this.Label4.Name = "Label4";
			this.Label4.Size = new global::System.Drawing.Size(41, 13);
			this.Label4.TabIndex = 6;
			this.Label4.Text = "Branch";
			this.Label3.AutoSize = true;
			this.Label3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label3.Location = new global::System.Drawing.Point(355, 16);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(253, 24);
			this.Label3.TabIndex = 4;
			this.Label3.Text = "Daily Sales Report for Branch";
			this.Label2.AutoSize = true;
			this.Label2.BackColor = global::System.Drawing.Color.Red;
			this.Label2.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.Label2.Location = new global::System.Drawing.Point(946, 16);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(33, 13);
			this.Label2.TabIndex = 3;
			this.Label2.Text = "Close";
			this.Button1.Location = new global::System.Drawing.Point(622, 54);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(138, 23);
			this.Button1.TabIndex = 2;
			this.Button1.Text = "RUN REPORT";
			this.Button1.UseVisualStyleBackColor = true;
			this.DTdate.Location = new global::System.Drawing.Point(163, 57);
			this.DTdate.Name = "DTdate";
			this.DTdate.Size = new global::System.Drawing.Size(200, 20);
			this.DTdate.TabIndex = 1;
			this.Label1.AutoSize = true;
			this.Label1.Location = new global::System.Drawing.Point(93, 60);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(64, 13);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Select date:";
			this.ReportViewer1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			reportDataSource.Name = "CompanyDetails";
			reportDataSource.Value = this.GetCompanyDetailsBindingSource;
			reportDataSource2.Name = "SalesSummary";
			reportDataSource2.Value = this.ShiftSalesCategorySummaryBindingSource;
			reportDataSource3.Name = "PaymentSummary";
			reportDataSource3.Value = this.ShiftSalesPaymentSummaryBindingSource;
			reportDataSource4.Name = "DayShift";
			reportDataSource4.Value = this.ShiftSalesDayDetailBindingSource;
			reportDataSource5.Name = "NightShift";
			reportDataSource5.Value = this.ShiftSalesNightDetailBindingSource;
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource2);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource3);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource4);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource5);
			this.ReportViewer1.LocalReport.ReportEmbeddedResource = "PointOfSale.ShiftDailySales.rdlc";
			this.ReportViewer1.Location = new global::System.Drawing.Point(0, 90);
			this.ReportViewer1.Name = "ReportViewer1";
			this.ReportViewer1.Size = new global::System.Drawing.Size(982, 326);
			this.ReportViewer1.TabIndex = 2;
			this.GetCompanyDetailsTableAdapter.ClearBeforeFill = true;
			this.ShiftSalesCategorySummaryTableAdapter.ClearBeforeFill = true;
			this.ShiftSalesPaymentSummaryTableAdapter.ClearBeforeFill = true;
			this.ShiftSalesDayDetailTableAdapter.ClearBeforeFill = true;
			this.ShiftSalesNightDetailTableAdapter.ClearBeforeFill = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.Controls.Add(this.ReportViewer1);
			base.Controls.Add(this.GroupBox1);
			base.Name = "SalesforDayShift";
			base.Size = new global::System.Drawing.Size(982, 416);
			((global::System.ComponentModel.ISupportInitialize)this.GetCompanyDetailsBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.POSDataSet).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.ShiftSalesCategorySummaryBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.ShiftSalesPaymentSummaryBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.ShiftSalesDayDetailBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.ShiftSalesNightDetailBindingSource).EndInit();
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04002045 RID: 8261
		private global::System.ComponentModel.IContainer components;
	}
}
