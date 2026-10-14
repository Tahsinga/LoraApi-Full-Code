namespace PointOfSale
{
	// Token: 0x020001FF RID: 511
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class TaxReturns : global::System.Windows.Forms.UserControl
	{
		// Token: 0x06005BDA RID: 23514 RVA: 0x0034DB30 File Offset: 0x0034BD30
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

		// Token: 0x06005BDB RID: 23515 RVA: 0x0034DB80 File Offset: 0x0034BD80
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.cboBranch = new global::System.Windows.Forms.ComboBox();
			this.Label5 = new global::System.Windows.Forms.Label();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.DTend = new global::System.Windows.Forms.DateTimePicker();
			this.DTstart = new global::System.Windows.Forms.DateTimePicker();
			this.ReportViewer1 = new global::Microsoft.Reporting.WinForms.ReportViewer();
			this.TaxReturnsForPeriodSummary1BindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.POSDataSet = new global::PointOfSale.POSDataSet();
			this.TaxReturnsForPeriod1BindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.GetCompanyDetailsBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.TaxReturnsForPeriodSummary1TableAdapter = new global::PointOfSale.POSDataSetTableAdapters.TaxReturnsForPeriodSummary1TableAdapter();
			this.TaxReturnsForPeriod1TableAdapter = new global::PointOfSale.POSDataSetTableAdapters.TaxReturnsForPeriod1TableAdapter();
			this.GetCompanyDetailsTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.GetCompanyDetailsTableAdapter();
			this.VATInputBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.VATInputTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.VATInputTableAdapter();
			this.VATOutputBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.VATOutputTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.VATOutputTableAdapter();
			this.GroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.TaxReturnsForPeriodSummary1BindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.POSDataSet).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.TaxReturnsForPeriod1BindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetCompanyDetailsBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.VATInputBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.VATOutputBindingSource).BeginInit();
			base.SuspendLayout();
			this.GroupBox1.Controls.Add(this.cboBranch);
			this.GroupBox1.Controls.Add(this.Label5);
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Controls.Add(this.DTend);
			this.GroupBox1.Controls.Add(this.DTstart);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Padding = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GroupBox1.Size = new global::System.Drawing.Size(1568, 235);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.cboBranch.FormattingEnabled = true;
			this.cboBranch.Location = new global::System.Drawing.Point(120, 149);
			this.cboBranch.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cboBranch.Name = "cboBranch";
			this.cboBranch.Size = new global::System.Drawing.Size(298, 28);
			this.cboBranch.TabIndex = 14;
			this.Label5.AutoSize = true;
			this.Label5.Location = new global::System.Drawing.Point(40, 154);
			this.Label5.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label5.Name = "Label5";
			this.Label5.Size = new global::System.Drawing.Size(64, 20);
			this.Label5.TabIndex = 13;
			this.Label5.Text = "Branch:";
			this.Label4.AutoSize = true;
			this.Label4.BackColor = global::System.Drawing.Color.Red;
			this.Label4.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.Label4.Location = new global::System.Drawing.Point(1515, 24);
			this.Label4.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label4.Name = "Label4";
			this.Label4.Size = new global::System.Drawing.Size(49, 20);
			this.Label4.TabIndex = 12;
			this.Label4.Text = "Close";
			this.Label3.AutoSize = true;
			this.Label3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label3.Location = new global::System.Drawing.Point(434, 25);
			this.Label3.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(535, 32);
			this.Label3.TabIndex = 11;
			this.Label3.Text = "VAT Returns List For Period for Company";
			this.Label2.AutoSize = true;
			this.Label2.Location = new global::System.Drawing.Point(24, 115);
			this.Label2.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(81, 20);
			this.Label2.TabIndex = 10;
			this.Label2.Text = "End Date:";
			this.Button1.BackColor = global::System.Drawing.Color.Lime;
			this.Button1.Location = new global::System.Drawing.Point(120, 191);
			this.Button1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(178, 35);
			this.Button1.TabIndex = 9;
			this.Button1.Text = "View";
			this.Button1.UseVisualStyleBackColor = false;
			this.Label1.AutoSize = true;
			this.Label1.Location = new global::System.Drawing.Point(24, 75);
			this.Label1.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(87, 20);
			this.Label1.TabIndex = 8;
			this.Label1.Text = "Start Date:";
			this.DTend.Location = new global::System.Drawing.Point(120, 109);
			this.DTend.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.DTend.Name = "DTend";
			this.DTend.Size = new global::System.Drawing.Size(298, 26);
			this.DTend.TabIndex = 7;
			this.DTstart.Location = new global::System.Drawing.Point(120, 69);
			this.DTstart.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.DTstart.Name = "DTstart";
			this.DTstart.Size = new global::System.Drawing.Size(298, 26);
			this.DTstart.TabIndex = 6;
			this.ReportViewer1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			reportDataSource.Name = "TaxSummary";
			reportDataSource.Value = this.TaxReturnsForPeriodSummary1BindingSource;
			reportDataSource2.Name = "TaxDetail";
			reportDataSource2.Value = this.TaxReturnsForPeriod1BindingSource;
			reportDataSource3.Name = "CompanyDetails";
			reportDataSource3.Value = this.GetCompanyDetailsBindingSource;
			reportDataSource4.Name = "VATInput";
			reportDataSource4.Value = this.VATInputBindingSource;
			reportDataSource5.Name = "VATOutput";
			reportDataSource5.Value = this.VATOutputBindingSource;
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource2);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource3);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource4);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource5);
			this.ReportViewer1.LocalReport.ReportEmbeddedResource = "PointOfSale.TaxReport.rdlc";
			this.ReportViewer1.Location = new global::System.Drawing.Point(0, 235);
			this.ReportViewer1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ReportViewer1.Name = "ReportViewer1";
			this.ReportViewer1.Size = new global::System.Drawing.Size(1568, 523);
			this.ReportViewer1.TabIndex = 1;
			this.TaxReturnsForPeriodSummary1BindingSource.DataMember = "TaxReturnsForPeriodSummary1";
			this.TaxReturnsForPeriodSummary1BindingSource.DataSource = this.POSDataSet;
			this.POSDataSet.DataSetName = "POSDataSet";
			this.POSDataSet.SchemaSerializationMode = global::System.Data.SchemaSerializationMode.IncludeSchema;
			this.TaxReturnsForPeriod1BindingSource.DataMember = "TaxReturnsForPeriod1";
			this.TaxReturnsForPeriod1BindingSource.DataSource = this.POSDataSet;
			this.GetCompanyDetailsBindingSource.DataMember = "GetCompanyDetails";
			this.GetCompanyDetailsBindingSource.DataSource = this.POSDataSet;
			this.TaxReturnsForPeriodSummary1TableAdapter.ClearBeforeFill = true;
			this.TaxReturnsForPeriod1TableAdapter.ClearBeforeFill = true;
			this.GetCompanyDetailsTableAdapter.ClearBeforeFill = true;
			this.VATInputBindingSource.DataMember = "VATInput";
			this.VATInputBindingSource.DataSource = this.POSDataSet;
			this.VATInputTableAdapter.ClearBeforeFill = true;
			this.VATOutputBindingSource.DataMember = "VATOutput";
			this.VATOutputBindingSource.DataSource = this.POSDataSet;
			this.VATOutputTableAdapter.ClearBeforeFill = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.Controls.Add(this.ReportViewer1);
			base.Controls.Add(this.GroupBox1);
			base.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			base.Name = "TaxReturns";
			base.Size = new global::System.Drawing.Size(1568, 758);
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.TaxReturnsForPeriodSummary1BindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.POSDataSet).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.TaxReturnsForPeriod1BindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetCompanyDetailsBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.VATInputBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.VATOutputBindingSource).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x0400282D RID: 10285
		private global::System.ComponentModel.IContainer components;
	}
}
