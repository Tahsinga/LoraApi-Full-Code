namespace PointOfSale
{
	// Token: 0x0200019B RID: 411
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class SalesForDay : global::System.Windows.Forms.UserControl
	{
		// Token: 0x06004920 RID: 18720 RVA: 0x002C5108 File Offset: 0x002C3308
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

		// Token: 0x06004921 RID: 18721 RVA: 0x002C5158 File Offset: 0x002C3358
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			this.GetCompanyDetailsBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.POSDataSet = new global::PointOfSale.POSDataSet();
			this.SalesSummaryForDayBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.SalesDetailForDayBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.PaymentSummaryForDayBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.cboBranch = new global::System.Windows.Forms.ComboBox();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.DTdate = new global::System.Windows.Forms.DateTimePicker();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.ReportViewer1 = new global::Microsoft.Reporting.WinForms.ReportViewer();
			this.GetCompanyDetailsTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.GetCompanyDetailsTableAdapter();
			this.SalesSummaryForDayTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.SalesSummaryForDayTableAdapter();
			this.SalesDetailForDayTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.SalesDetailForDayTableAdapter();
			this.PaymentSummaryForDayTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.PaymentSummaryForDayTableAdapter();
			((global::System.ComponentModel.ISupportInitialize)this.GetCompanyDetailsBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.POSDataSet).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.SalesSummaryForDayBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.SalesDetailForDayBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.PaymentSummaryForDayBindingSource).BeginInit();
			this.GroupBox1.SuspendLayout();
			base.SuspendLayout();
			this.GetCompanyDetailsBindingSource.DataMember = "GetCompanyDetails";
			this.GetCompanyDetailsBindingSource.DataSource = this.POSDataSet;
			this.POSDataSet.DataSetName = "POSDataSet";
			this.POSDataSet.SchemaSerializationMode = global::System.Data.SchemaSerializationMode.IncludeSchema;
			this.SalesSummaryForDayBindingSource.DataMember = "SalesSummaryForDay";
			this.SalesSummaryForDayBindingSource.DataSource = this.POSDataSet;
			this.SalesDetailForDayBindingSource.DataMember = "SalesDetailForDay";
			this.SalesDetailForDayBindingSource.DataSource = this.POSDataSet;
			this.PaymentSummaryForDayBindingSource.DataMember = "PaymentSummaryForDay";
			this.PaymentSummaryForDayBindingSource.DataSource = this.POSDataSet;
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Controls.Add(this.cboBranch);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Controls.Add(this.DTdate);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new global::System.Drawing.Size(993, 90);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Details";
			this.Label4.AutoSize = true;
			this.Label4.Location = new global::System.Drawing.Point(397, 62);
			this.Label4.Name = "Label4";
			this.Label4.Size = new global::System.Drawing.Size(41, 13);
			this.Label4.TabIndex = 6;
			this.Label4.Text = "Branch";
			this.cboBranch.FormattingEnabled = true;
			this.cboBranch.Location = new global::System.Drawing.Point(444, 55);
			this.cboBranch.Name = "cboBranch";
			this.cboBranch.Size = new global::System.Drawing.Size(172, 21);
			this.cboBranch.TabIndex = 5;
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
			this.Label2.Location = new global::System.Drawing.Point(957, 16);
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
			reportDataSource2.Value = this.SalesSummaryForDayBindingSource;
			reportDataSource3.Name = "SalesDetail";
			reportDataSource3.Value = this.SalesDetailForDayBindingSource;
			reportDataSource4.Name = "PaymentSummary";
			reportDataSource4.Value = this.PaymentSummaryForDayBindingSource;
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource2);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource3);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource4);
			this.ReportViewer1.LocalReport.ReportEmbeddedResource = "PointOfSale.SalesForDay.rdlc";
			this.ReportViewer1.Location = new global::System.Drawing.Point(0, 90);
			this.ReportViewer1.Name = "ReportViewer1";
			this.ReportViewer1.Size = new global::System.Drawing.Size(993, 347);
			this.ReportViewer1.TabIndex = 1;
			this.GetCompanyDetailsTableAdapter.ClearBeforeFill = true;
			this.SalesSummaryForDayTableAdapter.ClearBeforeFill = true;
			this.SalesDetailForDayTableAdapter.ClearBeforeFill = true;
			this.PaymentSummaryForDayTableAdapter.ClearBeforeFill = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.Controls.Add(this.ReportViewer1);
			base.Controls.Add(this.GroupBox1);
			base.Name = "SalesForDay";
			base.Size = new global::System.Drawing.Size(993, 437);
			((global::System.ComponentModel.ISupportInitialize)this.GetCompanyDetailsBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.POSDataSet).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.SalesSummaryForDayBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.SalesDetailForDayBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.PaymentSummaryForDayBindingSource).EndInit();
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04002006 RID: 8198
		private global::System.ComponentModel.IContainer components;
	}
}
