namespace PointOfSale
{
	// Token: 0x020001E1 RID: 481
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class StockAdjustmentsReportCum : global::System.Windows.Forms.Form
	{
		// Token: 0x0600546E RID: 21614 RVA: 0x0030DC50 File Offset: 0x0030BE50
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

		// Token: 0x0600546F RID: 21615 RVA: 0x0030DCA0 File Offset: 0x0030BEA0
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			this.GetCompanyDetailsBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.POSDataSet = new global::PointOfSale.POSDataSet();
			this.StockAdjustmentsForPeriodCumulativeBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.Label5 = new global::System.Windows.Forms.Label();
			this.cboBranch = new global::System.Windows.Forms.ComboBox();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.DTEnddate = new global::System.Windows.Forms.DateTimePicker();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.DTStartdate = new global::System.Windows.Forms.DateTimePicker();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.ReportViewer1 = new global::Microsoft.Reporting.WinForms.ReportViewer();
			this.GetCompanyDetailsTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.GetCompanyDetailsTableAdapter();
			this.StockAdjustmentsForPeriodCumulativeTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.StockAdjustmentsForPeriodCumulativeTableAdapter();
			this.Button2 = new global::System.Windows.Forms.Button();
			this.cboRefs = new global::System.Windows.Forms.ComboBox();
			this.Label6 = new global::System.Windows.Forms.Label();
			((global::System.ComponentModel.ISupportInitialize)this.GetCompanyDetailsBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.POSDataSet).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.StockAdjustmentsForPeriodCumulativeBindingSource).BeginInit();
			this.GroupBox1.SuspendLayout();
			base.SuspendLayout();
			this.GetCompanyDetailsBindingSource.DataMember = "GetCompanyDetails";
			this.GetCompanyDetailsBindingSource.DataSource = this.POSDataSet;
			this.POSDataSet.DataSetName = "POSDataSet";
			this.POSDataSet.SchemaSerializationMode = global::System.Data.SchemaSerializationMode.IncludeSchema;
			this.StockAdjustmentsForPeriodCumulativeBindingSource.DataMember = "StockAdjustmentsForPeriodCumulative";
			this.StockAdjustmentsForPeriodCumulativeBindingSource.DataSource = this.POSDataSet;
			this.GroupBox1.Controls.Add(this.Label6);
			this.GroupBox1.Controls.Add(this.cboRefs);
			this.GroupBox1.Controls.Add(this.Button2);
			this.GroupBox1.Controls.Add(this.Label5);
			this.GroupBox1.Controls.Add(this.cboBranch);
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.DTEnddate);
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Controls.Add(this.DTStartdate);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new global::System.Drawing.Size(955, 159);
			this.GroupBox1.TabIndex = 4;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Details";
			this.Label5.AutoSize = true;
			this.Label5.Location = new global::System.Drawing.Point(595, 60);
			this.Label5.Name = "Label5";
			this.Label5.Size = new global::System.Drawing.Size(41, 13);
			this.Label5.TabIndex = 20;
			this.Label5.Text = "Branch";
			this.cboBranch.FormattingEnabled = true;
			this.cboBranch.Location = new global::System.Drawing.Point(642, 57);
			this.cboBranch.Name = "cboBranch";
			this.cboBranch.Size = new global::System.Drawing.Size(172, 21);
			this.cboBranch.TabIndex = 19;
			this.Label4.AutoSize = true;
			this.Label4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label4.Location = new global::System.Drawing.Point(371, 16);
			this.Label4.Name = "Label4";
			this.Label4.Size = new global::System.Drawing.Size(225, 24);
			this.Label4.TabIndex = 6;
			this.Label4.Text = "Stock Adjustments Report";
			this.Label3.AutoSize = true;
			this.Label3.BackColor = global::System.Drawing.Color.Red;
			this.Label3.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.Label3.Location = new global::System.Drawing.Point(919, 16);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(33, 13);
			this.Label3.TabIndex = 5;
			this.Label3.Text = "Close";
			this.Label2.AutoSize = true;
			this.Label2.Location = new global::System.Drawing.Point(312, 60);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(55, 13);
			this.Label2.TabIndex = 4;
			this.Label2.Text = "End Date:";
			this.DTEnddate.Location = new global::System.Drawing.Point(373, 57);
			this.DTEnddate.Name = "DTEnddate";
			this.DTEnddate.Size = new global::System.Drawing.Size(200, 20);
			this.DTEnddate.TabIndex = 3;
			this.Button1.BackColor = global::System.Drawing.Color.Lime;
			this.Button1.Location = new global::System.Drawing.Point(81, 112);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(200, 23);
			this.Button1.TabIndex = 2;
			this.Button1.Text = "RUN REPORT";
			this.Button1.UseVisualStyleBackColor = false;
			this.DTStartdate.Location = new global::System.Drawing.Point(81, 57);
			this.DTStartdate.Name = "DTStartdate";
			this.DTStartdate.Size = new global::System.Drawing.Size(200, 20);
			this.DTStartdate.TabIndex = 1;
			this.Label1.AutoSize = true;
			this.Label1.Location = new global::System.Drawing.Point(11, 60);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(58, 13);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Start Date:";
			this.ReportViewer1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			reportDataSource.Name = "CompanyDetails";
			reportDataSource.Value = this.GetCompanyDetailsBindingSource;
			reportDataSource2.Name = "StockAdj";
			reportDataSource2.Value = this.StockAdjustmentsForPeriodCumulativeBindingSource;
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource2);
			this.ReportViewer1.LocalReport.ReportEmbeddedResource = "PointOfSale.StockAdjCum.rdlc";
			this.ReportViewer1.Location = new global::System.Drawing.Point(0, 159);
			this.ReportViewer1.Name = "ReportViewer1";
			this.ReportViewer1.Size = new global::System.Drawing.Size(955, 280);
			this.ReportViewer1.TabIndex = 5;
			this.GetCompanyDetailsTableAdapter.ClearBeforeFill = true;
			this.StockAdjustmentsForPeriodCumulativeTableAdapter.ClearBeforeFill = true;
			this.Button2.Location = new global::System.Drawing.Point(823, 55);
			this.Button2.Name = "Button2";
			this.Button2.Size = new global::System.Drawing.Size(126, 23);
			this.Button2.TabIndex = 21;
			this.Button2.Text = "Load References";
			this.Button2.UseVisualStyleBackColor = true;
			this.cboRefs.FormattingEnabled = true;
			this.cboRefs.Location = new global::System.Drawing.Point(81, 85);
			this.cboRefs.Name = "cboRefs";
			this.cboRefs.Size = new global::System.Drawing.Size(200, 21);
			this.cboRefs.TabIndex = 22;
			this.Label6.AutoSize = true;
			this.Label6.Location = new global::System.Drawing.Point(12, 88);
			this.Label6.Name = "Label6";
			this.Label6.Size = new global::System.Drawing.Size(65, 13);
			this.Label6.TabIndex = 23;
			this.Label6.Text = "References:";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(955, 439);
			base.Controls.Add(this.ReportViewer1);
			base.Controls.Add(this.GroupBox1);
			base.Name = "StockAdjustmentsReportCum";
			this.Text = "StockAdjustmentsReportCum";
			((global::System.ComponentModel.ISupportInitialize)this.GetCompanyDetailsBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.POSDataSet).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.StockAdjustmentsForPeriodCumulativeBindingSource).EndInit();
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x040024D8 RID: 9432
		private global::System.ComponentModel.IContainer components;
	}
}
