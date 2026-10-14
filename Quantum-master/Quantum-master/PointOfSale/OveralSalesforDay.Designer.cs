namespace PointOfSale
{
	// Token: 0x02000082 RID: 130
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class OveralSalesforDay : global::System.Windows.Forms.UserControl
	{
		// Token: 0x06001E03 RID: 7683 RVA: 0x0010C140 File Offset: 0x0010A340
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

		// Token: 0x06001E04 RID: 7684 RVA: 0x0010C190 File Offset: 0x0010A390
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.ReportViewer1 = new global::Microsoft.Reporting.WinForms.ReportViewer();
			this.POSDataSet = new global::PointOfSale.POSDataSet();
			this.OveralSalesSummaryForDayBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.OveralSalesSummaryForDayTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.OveralSalesSummaryForDayTableAdapter();
			this.OveralPaymentSummaryForDayBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.OveralPaymentSummaryForDayTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.OveralPaymentSummaryForDayTableAdapter();
			this.OveralSalesDetailForDayBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.OveralSalesDetailForDayTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.OveralSalesDetailForDayTableAdapter();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.DTdate = new global::System.Windows.Forms.DateTimePicker();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.GetCompanyDetailsBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.GetCompanyDetailsTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.GetCompanyDetailsTableAdapter();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.GroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.POSDataSet).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.OveralSalesSummaryForDayBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.OveralPaymentSummaryForDayBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.OveralSalesDetailForDayBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetCompanyDetailsBindingSource).BeginInit();
			base.SuspendLayout();
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Controls.Add(this.DTdate);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new global::System.Drawing.Size(940, 93);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Report Parameters";
			this.ReportViewer1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			reportDataSource.Name = "SalesSummary";
			reportDataSource.Value = this.OveralSalesSummaryForDayBindingSource;
			reportDataSource2.Name = "PaymentSummary";
			reportDataSource2.Value = this.OveralPaymentSummaryForDayBindingSource;
			reportDataSource3.Name = "SalesDetail";
			reportDataSource3.Value = this.OveralSalesDetailForDayBindingSource;
			reportDataSource4.Name = "CompanyDetails";
			reportDataSource4.Value = this.GetCompanyDetailsBindingSource;
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource2);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource3);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource4);
			this.ReportViewer1.LocalReport.ReportEmbeddedResource = "PointOfSale.OveralSalesforDay.rdlc";
			this.ReportViewer1.Location = new global::System.Drawing.Point(0, 93);
			this.ReportViewer1.Name = "ReportViewer1";
			this.ReportViewer1.Size = new global::System.Drawing.Size(940, 286);
			this.ReportViewer1.TabIndex = 1;
			this.POSDataSet.DataSetName = "POSDataSet";
			this.POSDataSet.SchemaSerializationMode = global::System.Data.SchemaSerializationMode.IncludeSchema;
			this.OveralSalesSummaryForDayBindingSource.DataMember = "OveralSalesSummaryForDay";
			this.OveralSalesSummaryForDayBindingSource.DataSource = this.POSDataSet;
			this.OveralSalesSummaryForDayTableAdapter.ClearBeforeFill = true;
			this.OveralPaymentSummaryForDayBindingSource.DataMember = "OveralPaymentSummaryForDay";
			this.OveralPaymentSummaryForDayBindingSource.DataSource = this.POSDataSet;
			this.OveralPaymentSummaryForDayTableAdapter.ClearBeforeFill = true;
			this.OveralSalesDetailForDayBindingSource.DataMember = "OveralSalesDetailForDay";
			this.OveralSalesDetailForDayBindingSource.DataSource = this.POSDataSet;
			this.OveralSalesDetailForDayTableAdapter.ClearBeforeFill = true;
			this.Label3.AutoSize = true;
			this.Label3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label3.Location = new global::System.Drawing.Point(280, 16);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(361, 24);
			this.Label3.TabIndex = 8;
			this.Label3.Text = "Daily Sales Report for the whole Company";
			this.Button1.Location = new global::System.Drawing.Point(403, 57);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(138, 23);
			this.Button1.TabIndex = 7;
			this.Button1.Text = "RUN REPORT";
			this.Button1.UseVisualStyleBackColor = true;
			this.DTdate.Location = new global::System.Drawing.Point(197, 57);
			this.DTdate.Name = "DTdate";
			this.DTdate.Size = new global::System.Drawing.Size(200, 20);
			this.DTdate.TabIndex = 6;
			this.Label1.AutoSize = true;
			this.Label1.Location = new global::System.Drawing.Point(127, 60);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(64, 13);
			this.Label1.TabIndex = 5;
			this.Label1.Text = "Select date:";
			this.GetCompanyDetailsBindingSource.DataMember = "GetCompanyDetails";
			this.GetCompanyDetailsBindingSource.DataSource = this.POSDataSet;
			this.GetCompanyDetailsTableAdapter.ClearBeforeFill = true;
			this.Label2.AutoSize = true;
			this.Label2.BackColor = global::System.Drawing.Color.Red;
			this.Label2.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.Label2.Location = new global::System.Drawing.Point(904, 16);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(33, 13);
			this.Label2.TabIndex = 9;
			this.Label2.Text = "Close";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.Controls.Add(this.ReportViewer1);
			base.Controls.Add(this.GroupBox1);
			base.Name = "OveralSalesforDay";
			base.Size = new global::System.Drawing.Size(940, 379);
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.POSDataSet).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.OveralSalesSummaryForDayBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.OveralPaymentSummaryForDayBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.OveralSalesDetailForDayBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetCompanyDetailsBindingSource).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000E4B RID: 3659
		private global::System.ComponentModel.IContainer components;
	}
}
